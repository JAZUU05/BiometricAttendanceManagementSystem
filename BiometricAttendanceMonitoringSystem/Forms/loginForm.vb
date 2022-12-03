'Imports MySql.Data.MySqlClient
Imports System.Data.Common.DbConnection
Imports MySql.Data.MySqlClient

Public Class loginForm
    Dim attempt As Integer = 3
    Dim timer As Integer = 4
    Private Sub clear()
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub
    Private Sub disableControls()
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        btnLogin.Enabled = False
        btnCancel.Enabled = False
        chkShowPassword.Enabled = False
    End Sub
    Private Sub enableControls()
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        btnLogin.Enabled = True
        btnCancel.Enabled = True
        chkShowPassword.Enabled = True
    End Sub
    Private Function verifyLogin() As Boolean
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Inputs Required", MsgBoxStyle.Information, "Input Username/Password")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub LoginUser()
        Try
            Dim loginSuccess = ValidateLogin(txtUsername.Text, txtPassword.Text)
            If loginSuccess Then
                'Open Main Form here
                dashboard.Show()
                Me.Hide()
            Else
                MsgBox("Login Failed", MsgBoxStyle.Critical, "Login Failed")
                attempt -= 1
                attemptLeft.Text = "Attemp Left: " + attempt.ToString
                If attempt = 0 Then
                    MsgBox("Login Form Freezed! Wait for it", MsgBoxStyle.OkOnly, "Login Attempt Reached")
                    attemptLeft.Text = "Attemp Left: " + attempt.ToString
                    countdown.Start()
                    disableControls()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private _trackAttendace As TrackAttendance
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If _trackAttendace Is Nothing Then
            _trackAttendace = New TrackAttendance
        End If
        _trackAttendace.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        attemptLeft.Text = "Attempt Left: " + attempt.ToString

        Try
            strCon.Open()
            sql = "SELECT id FROM login_admin"
            With cmd
                .Connection = strCon
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
            da.Dispose()

            If dt.Rows.Count = 0 Then
                firstAdmin.ShowDialog()
            End If
        End Try

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim valid As Boolean = verifyLogin()
        If (valid) Then
            LoginUser()
            clear()
        End If
    End Sub

    Private Sub countdown_Tick(sender As Object, e As EventArgs) Handles countdown.Tick
        If attempt = 0 Then
            timer -= 1
            lbltimer.Text = timer

            If timer = 0 Then
                countdown.Stop()
                MsgBox("Freezing Time Finished Try Again", MsgBoxStyle.OkOnly, "Try Again")
                enableControls()
                attempt = 3
                attemptLeft.Text = "Attempt Left: " + attempt.ToString
                timer = 4
                lbltimer.Text = ""
                'Timer1.Start()

            End If
        End If
    End Sub


    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        enterFunction(e)
    End Sub

    Private Sub username_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        enterFunction(e)
    End Sub
    Private Sub enterFunction(ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Dim valid As Boolean = verifyLogin()
            If (valid) Then
                LoginUser()
                clear()
            End If
        End If
    End Sub

    Private Sub linkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForgotPassword.LinkClicked
        ForgotPassword.ShowDialog()
    End Sub
End Class
