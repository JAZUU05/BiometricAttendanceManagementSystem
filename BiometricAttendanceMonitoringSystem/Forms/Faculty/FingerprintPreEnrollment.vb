Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.Threading
Imports libzkfpcsharp
Public Class FingerprintPreEnrollment
    Public _sender As addFaculty
    Public _fingerType As String

    Private _currentScanner As IntPtr = IntPtr.Zero
    Private _cacheFingerprint As IntPtr = IntPtr.Zero
    Private FormHandle As IntPtr = IntPtr.Zero
    Private _scannedFingerprint As Byte() = New Byte(2047) {}
    Private _bufferFingerprint As Byte()
    Private _captureSize As Integer = 2048
    Private _stopScanning As Boolean = False

    Private _newRegistration As Byte() = New Byte(2047) {}
    Private _newRegCompleted As Boolean = False

    Private _RegistrationTempFPs As Byte()() = New Byte(2)() {}

    Const MESSAGE_CAPTURED_OK As Integer = &H400 + 6
    Const REGISTER_FINGER_COUNT As Integer = 3

    Private mfpWidth As Integer = 0
    Private mfpHeight As Integer = 0

    Private RegisterCount As Integer = 0
    Private cbRegTmp As Integer = 0


    <DllImport("user32.dll", EntryPoint:="SendMessageA")>
    Public Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function


    Public Property CurrentScanner As IntPtr
        Get
            Return _currentScanner
        End Get
        Set(value As IntPtr)
            _currentScanner = value
        End Set
    End Property

    Public Property FingerprintCache As IntPtr
        Get
            Return _cacheFingerprint
        End Get
        Set(value As IntPtr)
            _cacheFingerprint = value
        End Set
    End Property
    ' Capture Handler

    Private Sub DoCapture()
        While Not _stopScanning
            _captureSize = 2048
            Dim ret = zkfp2.AcquireFingerprint(_currentScanner, _bufferFingerprint, _scannedFingerprint, _captureSize)
            If ret = zkfp.ZKFP_ERR_OK Then
                SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero)
            End If
            Thread.Sleep(200)
        End While
    End Sub

    Protected Overrides Sub DefWndProc(ByRef m As Message)
        Select Case m.Msg
            Case MESSAGE_CAPTURED_OK
                SendMessage(Action.SendBitmap, CreateBitmap(_bufferFingerprint, mfpWidth, mfpHeight))
                SendMessage(Action.SendMessage, "Fingerprint Scanned!!!")
                PreEnrollment()
            Case Else
                MyBase.DefWndProc(m)
        End Select
    End Sub

    Private Sub PreEnrollment()
        Dim ret = zkfp.ZKFP_ERR_OK
        Dim fid = 0, score = 0
        ret = zkfp2.DBIdentify(_cacheFingerprint, _scannedFingerprint, fid, score)
        If zkfp.ZKFP_ERR_OK = ret Then
            SendMessage(Action.SendMessage, "This finger was already register by " & fid & "! YOU CANNOT USE IT AGAIN!")
            Return
        End If
        If RegisterCount > 0 AndAlso zkfp2.DBMatch(_cacheFingerprint, _scannedFingerprint, _RegistrationTempFPs(RegisterCount - 1)) <= 0 Then
            SendMessage(Action.SendMessage, "Please press the same finger 3 times for the enrollment")
            Return
        End If
        Array.Copy(_scannedFingerprint, _RegistrationTempFPs(RegisterCount), _captureSize)
        Dim strBase64 = zkfp2.BlobToBase64(_scannedFingerprint, _captureSize)
        Dim blob = zkfp2.Base64ToBlob(strBase64)
        RegisterCount += 1
        If RegisterCount >= REGISTER_FINGER_COUNT Then
            RegisterCount = 0
            Dim iFid = 1
            If zkfp.ZKFP_ERR_OK = (ret = zkfp2.DBMerge(_cacheFingerprint, _RegistrationTempFPs(0), _RegistrationTempFPs(1), _RegistrationTempFPs(2), _newRegistration, cbRegTmp)) Then
                SendMessage(Action.SendMessage, "====================")
                SendMessage(Action.SendMessage, "ENROLLMENT SUCCESSFUL, PRESS SAVE TO CONTINUE OR SCAN AGAIN TO REPLACE")
                SendMessage(Action.SendMessage, "====================")
                zkfp2.DBClear(_cacheFingerprint)
                _newRegCompleted = True
            Else
                SendMessage(Action.SendMessage, "Enroll fail, error code= " & ret)
            End If
            Return
        Else
            SendMessage(Action.SendMessage, "You need to press the " & REGISTER_FINGER_COUNT - RegisterCount & " times fingerprint")
        End If
    End Sub



    Private Sub FingerprintPreEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormHandle = Handle
        ' Fingerprint Scanner Init
        Dim ret = zkfp2.Init()
        If ret = zkfperrdef.ZKFP_ERR_OK Then
            Dim nCount As Integer = zkfp2.GetDeviceCount()
            If nCount > 0 Then
                ' Open Scanner Here
                _currentScanner = zkfp2.OpenDevice(0)
                If IntPtr.Zero = _currentScanner Then
                    MessageBox.Show("OpenDevice fail")
                    Return
                End If
                _cacheFingerprint = zkfp2.DBInit()
                If IntPtr.Zero = _cacheFingerprint Then
                    MessageBox.Show("Init DB fail")
                    zkfp2.CloseDevice(_currentScanner)
                    _currentScanner = IntPtr.Zero
                    Return
                End If
                RegisterCount = 0
                cbRegTmp = 0
                For i = 0 To 2
                    _RegistrationTempFPs(i) = New Byte(2047) {}
                Next
                Dim paramValue = New Byte(3) {}
                Dim size = 4
                zkfp2.GetParameters(_currentScanner, 1, paramValue, size)
                zkfp2.ByteArray2Int(paramValue, mfpWidth)

                size = 4
                zkfp2.GetParameters(_currentScanner, 2, paramValue, size)
                zkfp2.ByteArray2Int(paramValue, mfpHeight)

                _bufferFingerprint = New Byte(mfpWidth * mfpHeight - 1) {}

                Dim captureThread As Thread = New Thread(New ThreadStart(AddressOf DoCapture))
                captureThread.IsBackground = True
                captureThread.Start()
                _stopScanning = False
                lblScannerStatus.Text = "Connected!"
                SendMessage(Action.SendMessage, "Please press the same finger 3 times for the enrollment")
            Else
                zkfp2.Terminate()
                lblScannerStatus.Text = "No device connected!"
                Close()
            End If
        Else
            lblScannerStatus.Text = "Initialize fail, ret=" & ret & " !"
            Close()
        End If
    End Sub

    Private Sub FingerprintPreEnrollment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        zkfp2.CloseDevice(_currentScanner)
        zkfp2.Terminate()
        txtMessage.Clear()
        pbPicture.Image = Nothing
        _stopScanning = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    ''' <summary>
    ''' Create a bitmap from raw data in row/column format.
    ''' </summary>
    ''' <param name="bytes"></param>
    ''' <param name="width"></param>
    ''' <param name="height"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CreateBitmap(ByVal bytes As [Byte](), ByVal width As Integer, ByVal height As Integer) As Bitmap
        Dim rgbBytes As Byte() = New Byte(bytes.Length * 3 - 1) {}

        For i As Integer = 0 To bytes.Length - 1
            rgbBytes((i * 3)) = bytes(i)
            rgbBytes((i * 3) + 1) = bytes(i)
            rgbBytes((i * 3) + 2) = bytes(i)
        Next
        Dim bmp As New Bitmap(width, height, PixelFormat.Format24bppRgb)

        Dim data As BitmapData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.[WriteOnly], PixelFormat.Format24bppRgb)

        For i As Integer = 0 To bmp.Height - 1
            Dim p As New IntPtr(data.Scan0.ToInt64() + data.Stride * i)
            System.Runtime.InteropServices.Marshal.Copy(rgbBytes, i * bmp.Width * 3, p, bmp.Width * 3)
        Next

        bmp.UnlockBits(data)

        Return bmp
    End Function

#Region "SendMessage"
    Public Enum Action
        SendBitmap
        SendMessage
    End Enum
    Private Delegate Sub SendMessageCallback(ByVal action As Action, ByVal payload As Object)
    Private Sub SendMessage(ByVal action As Action, ByVal payload As Object)
        On Error Resume Next

        If pbPicture.InvokeRequired Then
            Dim d As New SendMessageCallback(AddressOf SendMessage)
            Me.Invoke(d, New Object() {action, payload})
        Else
            Select Case action
                Case Action.SendBitmap
                    pbPicture.Image = DirectCast(payload, Bitmap)
                    pbPicture.Refresh()
                Case Action.SendMessage
                    txtMessage.Text += payload & vbCrLf & vbCrLf
                    txtMessage.SelectionStart = txtMessage.TextLength
                    txtMessage.ScrollToCaret()
            End Select

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not _newRegCompleted Then
            MessageBox.Show("Please complete the Pre-enrollment first")
            Return
        End If

        If _fingerType = "L" Then
            _sender.LeftFingerprint = _newRegistration
        ElseIf _fingerType = "R" Then
            _sender.RightFingerprint = _newRegistration
        End If

        Close()
    End Sub

#End Region
End Class