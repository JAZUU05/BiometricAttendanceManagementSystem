Public Class ResetPassword
    Public username As String
    Private Sub clear()
        txtCPassword.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub resetForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim password As String = txtpassword.Text
        Dim confirm_password As String = txtCPassword.Text
        If password = "" Or confirm_password = "" Then
            MessageBox.Show("Invalid, Empty Field", "Falied", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If password = confirm_password Then
            Try
                strCon.Open()
                With cmd
                    sql = "UPDATE login_admin SET password = @password WHERE username =@username"
                    .Connection = strCon
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@username", username)
                    .Parameters.AddWithValue("@password", password)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Successfully reset password.")
                clear()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                strCon.Close()
                da.Dispose()
            End Try
        Else
            MessageBox.Show("Password Does Not Match", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class