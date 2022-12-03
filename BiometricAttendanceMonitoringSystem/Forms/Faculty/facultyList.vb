Imports MySql.Data.MySqlClient
Public Class facultyList
    Dim id As String

    Private _currentEmployeeID As String
    Public Sub refreshData()
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnAdmin.Enabled = False
        sql = "SELECT e.employee_id, e.employeeID, CONCAT(e.first_name, ' ' , e.middle_name, ' ', e.last_name) AS name FROM employee as e"
        loadRecords(sql, DataGridView1)

        Dim i As Integer

        For i = 0 To DataGridView1.RowCount - 1
            If checkAdmin(DataGridView1.Rows(i).Cells(1).Value) Then
                DataGridView1.Rows(i).Cells(0).Value = "Yes"
            End If
        Next

        DataGridView1.Columns("employee_id").Visible = False
    End Sub
    Public Function checkAdmin(ByVal id As Integer) As Boolean
        Try
            strCon.Open()
            sql = "SELECT l.id FROM login_admin AS l INNER JOIN employee AS e ON l.employee_id = e.employee_id WHERE l.employee_id = '" & id & "'"
            With cmd
                .CommandText = sql
                .Connection = strCon
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
            da.Dispose()
            dt.Dispose()
        End Try
        Return False
    End Function

    Private Sub facultyList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        sql = "DELETE FROM employee WHERE employee_id = '" & _currentEmployeeID & "'"
        deleteRecord(sql)
        Dim delete_fingerprints = "DELETE FROM fingerprint WHERE employee_id='" & _currentEmployeeID & "'"
        deleteRecord(delete_fingerprints)
        MessageBox.Show("RECORD HAS BEEN DELETED IN DATABASE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call facultyList_Load(sender, e)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnEdit.Enabled = True
        _currentEmployeeID = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Try
            strCon.Open()
            sql = "SELECT l.id FROM login_admin AS l INNER JOIN employee AS e ON l.employee_id = e.employee_id WHERE l.employee_id = '" & _currentEmployeeID & "'"
            With cmd
                .CommandText = sql
                .Connection = strCon
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
        End Try
        If dt.Rows.Count = 0 Then
            btnDelete.Enabled = True
            btnAdmin.Enabled = True
        Else
            btnDelete.Enabled = False
            btnAdmin.Enabled = False
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        updateFaculty.employeeId = DataGridView1.CurrentRow.Cells(1).Value.ToString
        updateFaculty.Show()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        With add_Admin
            .facultyname = DataGridView1.CurrentRow.Cells(3).Value.ToString
            .employee_id = DataGridView1.CurrentRow.Cells(1).Value.ToString
            .Show()
        End With
    End Sub
End Class