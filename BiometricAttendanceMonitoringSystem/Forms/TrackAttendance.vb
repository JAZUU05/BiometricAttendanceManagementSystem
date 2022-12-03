Imports libzkfpcsharp
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities
Imports System.Drawing.Imaging
Imports System.Reflection.Metadata
Imports System.Runtime.InteropServices
Imports System.Runtime.Intrinsics.X86
Imports System.Threading

Public Class TrackAttendance
    Private _currentScanner As IntPtr = IntPtr.Zero
    Private _cacheFingerprint As IntPtr = IntPtr.Zero
    Private FormHandle As IntPtr = IntPtr.Zero
    Private _scannedFingerprint As Byte() = New Byte(2047) {}
    Private _bufferFingerprint As Byte()
    Private _captureSize As Integer = 2048
    Private _stopScanning As Boolean = False

    Const MESSAGE_CAPTURED_OK As Integer = &H400 + 6

    Private mfpWidth As Integer = 0
    Private mfpHeight As Integer = 0

    Private cbRegTmp As Integer = 0

    Private _currentEmployeeId As String


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
                Dim fid = 0, score = 0
                ' Identify Fingerprint
                Dim ret As Integer = zkfp2.DBIdentify(_cacheFingerprint, _scannedFingerprint, fid, score)
                If zkfp.ZKFP_ERR_OK = ret Then
                    SendMessage(Action.SendMessage, "Identified, fingerprint_id = " & fid & ",score = " & score & "!")
                    DisplayEmployeeResult(fid)
                    Dim nextAction = getNextAction()
                    If nextAction Is Nothing Then
                        SendMessage(Action.SendMessage, "No action need to be taken")
                    Else
                        If nextAction = "time_in_am" Then
                            'insert new row to time_sheet table
                            Dim sql = "INSERT INTO time_sheet(employee_id, time_in_am, date_recorded) VALUES('" & _currentEmployeeId & "', TIME(NOW()) ,date(NOW()))"
                            insertRecord(sql)
                            SendMessage(Action.SendMessage, "AM TIME IN EMPLOYEE ID " & _currentEmployeeId & "!")
                        Else
                            ' update the record for the employee for the current day
                            Dim sql = "UPDATE time_sheet SET `" & nextAction & "`=TIME(NOW()) WHERE employee_id='" & _currentEmployeeId & "' AND date_recorded=DATE(NOW())"
                            updateRecord(sql)
                            Dim am_pm = nextAction.Substring(nextAction.LastIndexOf("_") + 1).ToUpper
                            nextAction = nextAction.Replace("_", " ").Remove(8).ToUpper
                            SendMessage(Action.SendMessage, am_pm & " " & nextAction & " EMPLOYEE ID " & _currentEmployeeId & "!")
                        End If
                    End If
                    LoadTimeSheet(_currentEmployeeId)
                    StartTimer("")
                    Return
                Else
                    SendMessage(Action.SendMessage, "Fingerprint did not match")
                    Return
                End If
            Case Else
                MyBase.DefWndProc(m)
        End Select
    End Sub

    Private Sub StartTimer(ByVal str As String)
        If Me.InvokeRequired Then
            Dim args() As String = {""}
            Me.Invoke(New Action(Of String)(AddressOf StartTimer), args)
            Return
        End If
        Timer1.Start()
    End Sub

    Private clearTime = 5
    Private Sub timerClear_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        clearTime -= 1
        If clearTime <= 0 Then
            Timer1.Stop()
            pbFingerprint.Image = Nothing
            lblMessage.Text = "Ready to Scan"
            lblEmployeeId.Text = ""
            lblFirstName.Text = ""
            lblMiddleName.Text = ""
            lblLastName.Text = ""

            txtIn_AM.Clear()
            txtOut_AM.Clear()
            txtIn_PM.Clear()
            txtOut_PM.Clear()
            clearTime = 5
        End If
    End Sub


    Private Sub LoadTimeSheet(ByVal employee_id As String)
        If Me.InvokeRequired Then
            Dim args() As String = {employee_id}
            Me.Invoke(New Action(Of String)(AddressOf LoadTimeSheet), args)
            Return
        End If
        Dim sql As String = "SELECT * FROM `time_sheet` WHERE employee_id = '" & employee_id & "' and date_recorded=date(NOW())"
        Try
            strCon.Open()
            With cmd
                .Connection = strCon
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            txtIn_AM.Text = dt.Rows(0).Item("time_in_am").ToString
            txtOut_AM.Text = dt.Rows(0).Item("time_out_am").ToString
            txtIn_PM.Text = dt.Rows(0).Item("time_in_pm").ToString
            txtOut_PM.Text = dt.Rows(0).Item("time_out_pm").ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strCon.Close()
            da.Dispose()
            'dt.Dispose()
        End Try
    End Sub

    Public Function getNextAction() As String
        Dim row = dt.Rows(0)
        If DBNull.Value.Equals(row.Item("time_in_am")) Then
            Return "time_in_am"
        ElseIf DBNull.Value.Equals(row.Item("time_out_am")) Then
            Return "time_out_am"
        ElseIf DBNull.Value.Equals(row.Item("time_in_pm")) Then
            Return "time_in_pm"
        ElseIf DBNull.Value.Equals(row.Item("time_out_pm")) Then
            Return "time_out_pm"
        Else
            Return Nothing
        End If
        Return Nothing
    End Function

    Public Sub DisplayEmployeeResult(ByVal fingerprint_id As String) 
        If Me.InvokeRequired Then
            Dim args() As String = {fingerprint_id}
            Me.Invoke(New Action(Of String)(AddressOf DisplayEmployeeResult), args)
            Return
        End If
        Dim sql As String = "SELECT e.employee_id, e.employeeID, e.first_name,  e.middle_name, e.last_name, t.* FROM fingerprint as f INNER JOIN employee as e ON e.employee_id = f.employee_id LEFT JOIN time_sheet as t ON t.employee_id = f.employee_id AND t.date_recorded=date(NOW())  WHERE f.fingerprint_id = '" & fingerprint_id & "';"
        Try
            strCon.Open()
            With cmd
                .Connection = strCon
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            _currentEmployeeId = dt.Rows(0).Item("employee_id").ToString
            lblEmployeeId.Text = dt.Rows(0).Item("employeeID").ToString
            lblFirstName.Text = dt.Rows(0).Item("first_name").ToString
            lblMiddleName.Text = dt.Rows(0).Item("middle_name").ToString
            lblLastName.Text = dt.Rows(0).Item("last_name").ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strCon.Close()
            da.Dispose()
            'dt.Dispose()
        End Try
    End Sub

    Private Sub TrackAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerClock.Start()
        lbldate.Text = Today().ToString("D")
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
                SendMessage(Action.SendMessage, "Ready to Scan")

                LoadAllFingerprints()
                If dt.Rows.Count = 0 Then
                    SendMessage(Action.SendMessage, "No fingerprints on database, please login to add new fingerprints.")
                    Close()
                End If

            Else
                zkfp2.Terminate()
                MessageBox.Show("No device connected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Close()
            End If
        Else
            MessageBox.Show("Fingerprint initialization failed, is your fingerprint scanner connected?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End If
    End Sub

    Private Sub dateTime_Tick(sender As Object, e As EventArgs) Handles TimerClock.Tick
        lblTime.Text = TimeOfDay.ToString("hh:mm:ss tt").ToUpper
    End Sub


    Private Sub LoadAllFingerprints()
        Try
            strCon.Open()
            With cmd
                .Connection = strCon
                .CommandText = "SELECT * FROM fingerprint;"
                .Prepare()
                cmd.ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            strCon.Close()
            da.Dispose()
        End Try
        If dt.Rows.Count = 0 Then
            Return
        End If
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim ret = zkfp2.DBAdd(_cacheFingerprint, dt.Rows(i).Item("fingerprint_id"), dt.Rows(i).Item("fingerprint_image"))
            If Not ret = zkfp.ZKFP_ERR_OK Then
                MessageBox.Show("Error loading fingerprint to memory")
                Close()
            End If
        Next
    End Sub

    Private Sub FingerprintPreEnrollment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _stopScanning = True
        zkfp2.CloseDevice(_currentScanner)
        zkfp2.Terminate()
        zkfp2.DBFree(_cacheFingerprint)
        pbFingerprint.Image = Nothing
        lblMessage.Text = ""
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
    Private _loginForm As loginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If _loginForm IsNot Nothing Then
            _loginForm.Dispose()
        End If
        _loginForm = New loginForm
        _loginForm.Show()
        _loginForm = Nothing
        Hide()
    End Sub

#Region "SendMessage"
    Public Enum Action
        SendBitmap
        SendMessage
    End Enum
    Private Delegate Sub SendMessageCallback(ByVal action As Action, ByVal payload As Object)
    Private Sub SendMessage(ByVal action As Action, ByVal payload As Object)
        On Error Resume Next

        If pbFingerprint.InvokeRequired Then
            Dim d As New SendMessageCallback(AddressOf SendMessage)
            Me.Invoke(d, New Object() {action, payload})
        Else
            Select Case action
                Case Action.SendBitmap
                    pbFingerprint.Image = DirectCast(payload, Bitmap)
                    pbFingerprint.Refresh()
                Case Action.SendMessage
                    lblMessage.Text = DirectCast(payload, String)
            End Select

        End If
    End Sub

    Private Sub TrackAttendance_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not Visible Then
            _stopScanning = True
            zkfp2.CloseDevice(_currentScanner)
            zkfp2.Terminate()
            zkfp2.DBFree(_cacheFingerprint)
        End If
    End Sub

#End Region
End Class