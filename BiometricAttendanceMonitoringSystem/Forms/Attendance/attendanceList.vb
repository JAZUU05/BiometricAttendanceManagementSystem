Public Class attendanceList
    Private Sub attendanceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        drFrom.CustomFormat = "MMMM dd, yyyy"
        drTo.CustomFormat = "MMMM dd, yyyy"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id = txtid.Text
        Dim dateFrom = drFrom.Value.ToString("yyyy-MM-dd")
        Dim dateTo = drTo.Value.ToString("yyyy-MM-dd")
        If txtid.Text = "" Then
            sql = "SELECT DATE_FORMAT(ts.date_recorded, '%M %d, %Y') AS date, ts.time_sheet_id, ts.time_in_am, ts.time_out_am, ts.time_in_pm, 
                ts.time_out_pm, CONCAT(e.first_name, ' ', e.middle_name, ' ', e.last_name) AS name FROM time_sheet AS ts INNER JOIN employee AS e ON ts.employee_id = e.employee_id 
                WHERE ts.date_recorded BETWEEN '" & dateFrom & "' and '" & dateTo & "' ORDER BY ts.date_recorded ASC"
            loadRecords(sql, DataGridView1)
            If dt.Rows.Count > 0 Then
                Button3.Enabled = True
                Return
            Else
                Button3.Enabled = False
                Return
            End If

        End If
        sql = "SELECT DATE_FORMAT(ts.date_recorded, '%M %d, %Y') AS date, ts.time_sheet_id, ts.time_in_am, ts.time_out_am, ts.time_in_pm, 
                ts.time_out_pm, CONCAT(e.first_name, ' ', e.middle_name, ' ', e.last_name) AS name FROM time_sheet AS ts INNER JOIN employee AS e ON ts.employee_id = e.employee_id 
                WHERE (ts.date_recorded BETWEEN '" & dateFrom & "' and '" & dateTo & "') AND e.employeeID = '" & id & "' ORDER BY ts.date_recorded ASC"
        loadRecords(sql, DataGridView1)
        If dt.Rows.Count > 0 Then
            Button3.Enabled = True

        Else
            Button3.Enabled = False

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        time_sheet_form.ShowDialog()
    End Sub

End Class