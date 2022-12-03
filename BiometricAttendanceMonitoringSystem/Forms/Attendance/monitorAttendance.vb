Public Class monitorAttendance
    Private Sub tmr_time_Tick(sender As Object, e As EventArgs) Handles tmr_time.Tick
        lbltime.Text = TimeOfDay.ToString("hh:mm:ss tt").ToUpper
        'lbldate.Text = DateAndTime.MonthToString("D, dd MMMM yyyy")
        lbldate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")
    End Sub

    Private Sub monitorAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmr_time.Start()
    End Sub
End Class