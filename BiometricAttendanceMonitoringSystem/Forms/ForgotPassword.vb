Public Class ForgotPassword
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        checkData()
    End Sub
    Private Sub clear()
        txtAnswer.Clear()
        txtquestion.Clear()
        txtUsername.Clear()
    End Sub
    Private Sub checkData()
        Dim username As String = txtUsername.Text.Trim
        Try
            strCon.Open()
            With cmd
                sql = "SELECT recovery_question, recovery_answer FROM  login_admin WHERE username = @username"
                .Connection = strCon
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@username", username)
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MessageBox.Show("Username Found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAnswer.ReadOnly = False
                btnVerify.Enabled = True
                txtquestion.Text = dt.Rows(0).Item("recovery_question").ToString

            Else
                txtquestion.Clear()
                txtAnswer.Clear()
                txtAnswer.ReadOnly = True
                btnVerify.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
            da.Dispose()
        End Try
    End Sub
    Private Function validateAnswer() As Boolean
        If txtAnswer.Text.Trim = dt.Rows(0).Item("recovery_answer").ToString Then
            MessageBox.Show("Verified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            MessageBox.Show("Verification Error", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
    End Function
    Private Sub passwordReset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtquestion.ReadOnly = True
        txtAnswer.ReadOnly = True
        btnVerify.Enabled = False
    End Sub

    Private Sub passwordReset_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'loginForm.Show()
        loginForm.Visible = True

    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If txtAnswer.Text = "" Then
            MessageBox.Show("Answer Field Empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If validateAnswer() Then
            'Open password reset form
            ResetPassword.username = txtUsername.Text
            ResetPassword.ShowDialog()
            clear()
            Close()
        End If
    End Sub
End Class