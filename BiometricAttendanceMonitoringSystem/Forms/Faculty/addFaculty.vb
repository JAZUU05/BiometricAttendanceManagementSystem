Imports System.IO
Imports System.Runtime.Intrinsics.X86
Imports Org.BouncyCastle.Utilities

Public Class addFaculty

    Private _leftFingerprint(2047) As Byte
    Private _hasLeftFingerprint As Boolean = False
    Private _rightFingerprint(2047) As Byte
    Private _hasRightFingerprint As Boolean = False

    Private Sub ClearFieldsImageFingerprints()
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is RichTextBox Then
                ctrl.Text = ""
            End If

            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = "--Select--"
            End If
        Next
        txtEmployeeID.Text = Nothing
        txtFname.Text = Nothing
        txtMname.Text = Nothing
        txtLname.Text = Nothing
        employeeImage.Image = Nothing
        lblLeftStatus.Text = "Empty"
        lblRightStatus.Text = "Empty"
        _hasLeftFingerprint = False
        _hasRightFingerprint = False
    End Sub
    Private Function hasEmptyFields() As Boolean

        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is RichTextBox Then
                If ctrl.Text = "" Then
                    Return True
                End If
            End If
            If TypeOf ctrl Is ComboBox Then
                If ctrl.Text = "--Select--" Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Function hasImage() As Boolean
        If employeeImage.Image Is Nothing Then
            Return False
        End If
        Return True
    End Function

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub
    Private Function insertEmployee() As Boolean
        Dim ms As New MemoryStream
        employeeImage.Image.Save(ms, employeeImage.Image.RawFormat)
        Dim firstName As String = txtFname.Text
        Dim lastName As String = txtLname.Text
        Dim middleName As String = txtMname.Text
        Dim employeeID As String = txtEmployeeID.Text
        sql = "INSERT INTO employee (employeeID, first_name, middle_name, last_name, image) VALUES 
               (@employeeID, @firstName, @middleName, @lastName, @image)"
        Try
            strCon.Open()
            With cmd
                .Parameters.Clear()
                .Connection = strCon
                .CommandText = sql
                .Parameters.AddWithValue("@employeeID", employeeID)
                .Parameters.AddWithValue("@firstName", firstName)
                .Parameters.AddWithValue("@middleName", middleName)
                .Parameters.AddWithValue("@lastName", lastName)
                .Parameters.AddWithValue("@image", ms.ToArray)
                .Prepare()
                Dim result = cmd.ExecuteNonQuery()
                If result > 0 Then
                    Return True
                End If
                Return False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
        End Try
        Return False
    End Function

    Private Sub btnuploadImage_Click(sender As Object, e As EventArgs) Handles btnuploadImage.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            ofd.Filter = "Picture Files (*) | *.bmp; *.gif; *.jpg"
            employeeImage.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub addFaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        If Not CompletedPreEnrollment() Then
            MessageBox.Show("Please add 2 fingerprints first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If Not hasImage() Then
            MessageBox.Show("Please select an image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If hasEmptyFields() Then
            MessageBox.Show("Fill the Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        sql = "SELECT employee_id FROM employee WHERE employeeID = '" & txtEmployeeID.Text & "' "
        If checkDuplicate(sql) Then
            MessageBox.Show("Employee ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not insertEmployee() Then
            MessageBox.Show("Error occurred while adding employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim id = cmd.LastInsertedId

        If insertFingerprint(LeftFingerprint, "L", id) And insertFingerprint(RightFingerprint, "R", id) Then
            MessageBox.Show("Successfully added user", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFieldsImageFingerprints()
            Close()
        End If
    End Sub

    Private Function insertFingerprint(fmd As Byte(), finger_type As String, fingerprint_id As String) As Boolean
        Dim success As Boolean = False
        sql = "INSERT INTO fingerprint (employee_id, type, fingerprint_image) VALUES 
               (@fingerprintId, @type, @fingerprint_image)"
        Try
            strCon.Open()
            With cmd
                .Parameters.Clear()
                .Connection = strCon
                .CommandText = sql
                .Parameters.AddWithValue("@fingerprintId", fingerprint_id)
                .Parameters.AddWithValue("@type", finger_type)
                .Parameters.AddWithValue("@fingerprint_image", fmd)
                .Prepare()
                Dim result = cmd.ExecuteNonQuery()
                If result = 0 Then
                    MessageBox.Show("Error saving fingerprint", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    success = True
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error saving fingerprint", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            strCon.Close()
        End Try
        Return success
    End Function

    Private Function CompletedPreEnrollment() As Boolean
        If _hasLeftFingerprint And _hasRightFingerprint Then
            Return True
        End If
        Return False
    End Function

    Private Sub addFaculty_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ClearFieldsImageFingerprints()
    End Sub

    Public Property LeftFingerprint As Byte()
        Get
            Return _leftFingerprint
        End Get
        Set(value As Byte())
            _hasLeftFingerprint = True
            lblLeftStatus.Text = "DONE"
            _leftFingerprint = value
        End Set
    End Property

    Public Property RightFingerprint As Byte()
        Get
            Return _rightFingerprint
        End Get
        Set(value As Byte())
            _hasRightFingerprint = True
            lblRightStatus.Text = "DONE"
            _rightFingerprint = value
        End Set
    End Property
    Private _fingerPreEnrollmentForm As FingerprintPreEnrollment

    Private Sub btnAddLeftFingerprint_Click(sender As Object, e As EventArgs) Handles btnAddLeftFingerprint.Click
        If _fingerPreEnrollmentForm IsNot Nothing Then
            _fingerPreEnrollmentForm.Dispose()
        End If
        _fingerPreEnrollmentForm = New FingerprintPreEnrollment
        _fingerPreEnrollmentForm._sender = Me
        _fingerPreEnrollmentForm._fingerType = "L"
        _fingerPreEnrollmentForm.ShowDialog()
    End Sub

    Private Sub btnAddRightFingerprint_Click(sender As Object, e As EventArgs) Handles btnAddRightFingerprint.Click
        If _fingerPreEnrollmentForm Is Nothing Then
            _fingerPreEnrollmentForm.Dispose()
        End If
        _fingerPreEnrollmentForm = New FingerprintPreEnrollment
        _fingerPreEnrollmentForm._sender = Me
        _fingerPreEnrollmentForm._fingerType = "R"
        _fingerPreEnrollmentForm.ShowDialog()
    End Sub
End Class