Public Class userManagement
    Public userId As Integer
    Private oldUsername As String

    Private Sub clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtRecoveryQuestion.Clear()
        txtRecoveryAnswer.Clear()
    End Sub
    Private Sub userManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRecordsOnDatagrid()
        DataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub loadRecordsOnDatagrid()
        sql = "SELECT id, username, '••••' as password, recovery_question, recovery_answer, name as full_name FROM login_admin"
        loadRecords(sql, DataGridView1)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If user_id = userId Then
            MessageBox.Show("Cannot delete currently logged in user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        sql = "DELETE FROM login_admin WHERE id = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
        deleteRecord(sql)
        clear()
        Call userManagement_Load(sender, e)
    End Sub

    Private Sub showDuplicateUsernameError()
        MessageBox.Show("Username already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Function validForm() As Boolean
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        If username = "" Or password = "" Then
            MessageBox.Show("Empty fields are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        userId = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtUsername.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtRecoveryQuestion.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtRecoveryAnswer.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        oldUsername = txtUsername.Text
        updateDeleteAction()
    End Sub
    Private Sub userManagement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        clear()
        userId = 0
        addAction()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim question As String = txtRecoveryQuestion.Text.Trim()
        Dim answer As String = txtRecoveryAnswer.Text.Trim()

        If Not validForm() Then
            Return
        End If
        ' Check if duplicate username
        Dim check_sql = "SELECT * FROM login_admin where username='" & username & "'"
        If checkDuplicate(check_sql) And username <> oldUsername Then
            showDuplicateUsernameError()
            Return
        End If

        Try
            strCon.Open()
            With cmd
                sql = "UPDATE login_admin SET username = @username, password = @password, recovery_question=@question, recovery_answer=@answer WHERE id = @userId"
                .Connection = strCon
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@username", username)
                .Parameters.AddWithValue("@password", password)
                .Parameters.AddWithValue("@question", question)
                .Parameters.AddWithValue("@answer", answer)
                .Parameters.AddWithValue("@userId", userId)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Successfully updated user.")
            updateDeleteAction()
            clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
            da.Dispose()
        End Try
        loadRecordsOnDatagrid()
    End Sub

    Private Sub addAction()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub updateDeleteAction()
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
    End Sub
End Class