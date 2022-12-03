Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateTime.Start()
    End Sub

    Private Sub dateTime_Tick(sender As Object, e As EventArgs) Handles dateTime.Tick
        lbldate.Text = TimeOfDay.ToString("hh:mm:ss tt").ToUpper
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pbAddFaculty_Click_1(sender As Object, e As EventArgs) Handles pbAddFaculty.Click
        addFaculty.ShowDialog()
    End Sub

    Private Sub pbFacultyList_Click_1(sender As Object, e As EventArgs) Handles pbFacultyList.Click
        facultyList.refreshData()
        facultyList.ShowDialog()
    End Sub

    Private Sub pbAttendanceList_Click_1(sender As Object, e As EventArgs) Handles pbAttendanceList.Click
        attendanceList.ShowDialog()
    End Sub

    Private Sub addUser_Click_1(sender As Object, e As EventArgs) Handles addUser.Click
        userManagement.ShowDialog()
    End Sub

    Private Sub pbAbout_Click_1(sender As Object, e As EventArgs) Handles pbAbout.Click
        about.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginForm.Show()
        Me.Hide()
    End Sub

End Class