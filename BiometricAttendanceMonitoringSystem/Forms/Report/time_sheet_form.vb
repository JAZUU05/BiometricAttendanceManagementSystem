Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports Org.BouncyCastle.Utilities
Imports System.IO

Public Class time_sheet_form
    Private Sub time_sheet_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim id = attendanceList.txtid.Text
        Dim date_from = attendanceList.drFrom.Value
        Dim date_to = attendanceList.drTo.Value
        time_sheet.LocalReport.ReportPath = Path.Combine(My.Application.Info.DirectoryPath & "\time_sheet.rdlc")
        strCon.Open()
        If String.IsNullOrEmpty(id) Then
            Try
                cmd = New MySqlCommand("SELECT t.*, DATE_FORMAT(t.date_recorded, '%Y-%m-%d') AS date, CONCAT(e.first_name, ' ',  e.middle_name, ' ', e.last_name) as name 
                                        FROM time_sheet as t INNER JOIN employee as e ON t.employee_id = e.employee_id WHERE t.date_recorded BETWEEN '" & date_from.ToString("yyyy-MM-dd") & "' and 
                                        '" & date_to.ToString("yyyy-MM-dd") & "' ORDER BY t.date_recorded ASC", strCon)
                dt = New DataTable
                da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            Try
                cmd = New MySqlCommand("SELECT t.*, DATE_FORMAT(t.date_recorded, '%Y-%m-%d') AS date, CONCAT(e.first_name, ' ',  e.middle_name, ' ', e.last_name) as name 
                                        FROM time_sheet as t INNER JOIN employee as e ON t.employee_id = e.employee_id WHERE ( t.date_recorded BETWEEN '" & date_from.ToString("yyyy-MM-dd") & "' and 
                                        '" & date_to.ToString("yyyy-MM-dd") & "') AND e.employeeID = '" & id & "'  ORDER BY t.date_recorded ASC", strCon)
                dt = New DataTable
                da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        strCon.Close()
        da.Dispose()

        Dim rptparameter(1) As ReportParameter
        rptparameter(0) = New ReportParameter("date_from", date_from.ToString("MMMM dd, yyyy"))
        rptparameter(1) = New ReportParameter("date_to", date_to.ToString("MMMM dd, yyyy"))


        With Me.time_sheet.LocalReport
            .SetParameters(rptparameter)
            .DataSources.Clear()
            .DataSources.Add(New ReportDataSource("time_sheet", dt))
        End With
        With time_sheet
            .SetDisplayMode(DisplayMode.PrintLayout)
            .ZoomMode = ZoomMode.Percent
            .ZoomPercent = 100
        End With
        Me.time_sheet.RefreshReport()
    End Sub
End Class