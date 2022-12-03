Public Class about
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblabout.ForeColor = Color.Black Then
            lblabout.ForeColor = Color.Green
        Else
            lblabout.ForeColor = Color.Black
        End If
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class