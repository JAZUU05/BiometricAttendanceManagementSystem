Public Class firstAdmin
    Public employee_id As Integer = 0
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim name As String = txtname.Text
        Dim username As String = txtusername.Text
        Dim password As String = txtpassword.Text
        Dim question As String = txtRecoveryQuestion.Text
        Dim answer As String = txtRecoveryAnswer.Text
        sql = "INSERT INTO login_admin(employee_id, name, username, password, recovery_question, recovery_answer) VALUES ('" & employee_id & "', '" & name & "', '" & username & "', '" & password & "', '" & question & "', '" & answer & "')"
        insertRecord(sql)
        MessageBox.Show("Admin Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtname.Clear()
        txtpassword.Clear()
        txtusername.Clear()
        txtRecoveryQuestion.Clear()
        txtRecoveryAnswer.Clear()
        Me.Hide()
    End Sub
End Class