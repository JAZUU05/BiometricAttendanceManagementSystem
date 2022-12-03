Public Class positionManagement
    Dim id As String
    Dim jobTitle As String
    Dim jobDesc As String
    Dim check As Boolean
    Private Function checkPosition() As Boolean
        Try
            strCon.Open()
            sql = "SELECT * FROM position WHERE job_title = '" & txtTitle.Text & "'"
            With cmd
                .Connection = strCon
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
            da.Dispose()
        End Try
    End Function
    Private Sub clear()
        txtDescription.Clear()
        txtTitle.Clear()
        id = ""
        jobDesc = ""
        jobTitle = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        clear()
        addAction()
    End Sub

    Private Sub positionManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT position_id, job_title, description FROM position"
        loadRecords(sql, DataGridView1)
        addAction()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        id = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtTitle.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtDescription.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        btnDelete.Enabled = True
        btnUpdate.Enabled = True

        jobTitle = txtTitle.Text
        updateDeleteAction()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        id = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Dim check_sql As String = "SELECT employee_id from employee as e WHERE position_id='" & id & "'"
        If checkInUse(check_sql) Then
            MessageBox.Show("Cannot delete, position is in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        sql = "DELETE FROM position WHERE position_id = '" & id & "'"
        deleteRecord(sql)
        clear()
        Call positionManagement_Load(sender, e)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If isDuplicateJobTitle(txtTitle.Text) And jobTitle.ToLower <> txtTitle.Text.Trim.ToLower Then
            showDuplicateError()
            Return
        End If

        jobTitle = txtTitle.Text.Trim
        jobDesc = txtDescription.Text.Trim
        sql = "UPDATE position SET job_title = '" & jobTitle & "', description = '" & jobDesc & "' WHERE position_id = '" & id & "'"
        updateRecord(sql)
        clear()
        Call positionManagement_Load(sender, e)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        jobTitle = txtTitle.Text.Trim
        jobDesc = txtDescription.Text.Trim
        If isDuplicateJobTitle(jobTitle) Then
            showDuplicateError()
            Return
        End If
        sql = "INSERT INTO position (job_title, description) VALUES ('" & jobTitle & "', '" & jobDesc & "')"
        insertRecord(sql)
        MessageBox.Show("Record Inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clear()
        Call positionManagement_Load(sender, e)
    End Sub

    Private Sub addAction()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnSave.Enabled = True
    End Sub

    Public Function isDuplicateJobTitle(ByVal jobTitle As String) As Boolean
        Dim check_sql As String = "SELECT position_id FROM position WHERE LOWER( position.job_title ) = '" & jobTitle.ToLower & "'"
        If checkDuplicate(check_sql) Then
            Return True
        End If
        Return False
    End Function

    Private Sub showDuplicateError()
        MessageBox.Show("Duplicate Job Title entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub updateDeleteAction()
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        btnSave.Enabled = False
    End Sub

    Private Sub positionManagement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        clear()
    End Sub
End Class