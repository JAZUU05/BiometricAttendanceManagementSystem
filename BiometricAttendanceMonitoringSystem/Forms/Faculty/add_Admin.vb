Public Class add_Admin
    Public employee_id As Integer = 0
    Public facultyname As String
    Dim username As String
    Dim password As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Public Function emptyFields() As Boolean
        username = txtusername.Text.Trim
        password = txtpassword.Text.Trim
        If facultyname = "" Or username = "" Or password = "" Then
            Return True
        End If
        Return False
    End Function
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Dim recovery_question As String = txtRecoveryQuestion.Text
        Dim recovery_answer As String = txtRecoveryAnswer.Text
        If emptyFields() Then
            MessageBox.Show("Write Your Username or Password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        sql = "SELECT username FROM login_admin WHERE username = '" & txtusername.Text.ToLower.Trim & "'"
        If checkDuplicate(sql) Then
            MessageBox.Show("Username Already In Use!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        sql = "INSERT INTO login_admin(employee_id, name, username, password, recovery_question, recovery_answer) VALUES ('" & employee_id & "', '" & facultyname & "', '" & username & "', '" & password & "', '" & recovery_question & "', '" & recovery_answer & "')"
        insertRecord(sql)
        MessageBox.Show("Admin Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtpassword.Clear()
        txtusername.Clear()
        facultyList.refreshData()
        Me.Hide()
    End Sub
End Class