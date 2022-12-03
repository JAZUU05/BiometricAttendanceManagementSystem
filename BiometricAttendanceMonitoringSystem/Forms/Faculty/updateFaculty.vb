Imports MySql.Data.MySqlClient
Imports System.IO

Public Class updateFaculty
    Public employeeId As String
    Private Sub clear()
        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is RichTextBox Then
                ctrl.Text = ""
            End If

            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = "--Select--"
            End If
        Next
        employeeImage.Image = Nothing
    End Sub
    Private Sub loadData()
        Dim img() As Byte
        Try
            sql = "SELECT * FROM employee as e WHERE e.employee_id = '" & employeeId & "'  "
            strCon.Open()
            With cmd
                .Connection = strCon
                .CommandText = sql
                .ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            txtEmployeeId.Text = dt.Rows(0).Item("employeeID").ToString
            txtFname.Text = dt.Rows(0).Item("first_name").ToString
            txtLname.Text = dt.Rows(0).Item("last_name").ToString
            txtMname.Text = dt.Rows(0).Item("middle_name").ToString
            img = dt.Rows(0).Item("image")
            Dim ms As New MemoryStream(img)
            employeeImage.Image = Image.FromStream(ms)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
            da.Dispose()
            'dt.Dispose()
        End Try

    End Sub

    Private Sub updateFaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub updateFaculty_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        clear()
    End Sub

    Private Function checkEmptyFields() As Boolean

        For Each ctrl As Control In Panel1.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is RichTextBox Then
                If ctrl.Text = "" Then
                    Return True
                End If
            End If
            If TypeOf ctrl Is ComboBox Then
                If ctrl.Text = "--Select--" Then
                    Return True
                End If
            End If

            If TypeOf ctrl Is PictureBox Then
                If employeeImage.Image Is Nothing Then
                    Return True
                End If
            End If
        Next

    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If checkEmptyFields() Then
            MessageBox.Show("Fill the Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim ms As New MemoryStream
        employeeImage.Image.Save(ms, employeeImage.Image.RawFormat)
        Dim employee_ID As String = txtEmployeeId.Text
        Dim firstName As String = txtFname.Text
        Dim lastName As String = txtLname.Text
        Dim middleName As String = txtMname.Text



        Try
            strCon.Open()
            sql = "UPDATE employee SET employeeID=@employeeID, first_name=@first_name,middle_name=@middle_name,last_name=@last_name,
                    image=@image WHERE employee_id = '" & employeeId & "'"
            With cmd
                .Connection = strCon
                .CommandText = sql
                .Parameters.Clear()
                .Parameters.AddWithValue("@employeeID", employee_ID)
                .Parameters.AddWithValue("@first_name", firstName)
                .Parameters.AddWithValue("@middle_name", middleName)
                .Parameters.AddWithValue("@last_name", lastName)
                .Parameters.AddWithValue("@image", ms.ToArray)
                .Prepare()
                result = cmd.ExecuteNonQuery

                sql = "UPDATE login_admin SET name=@name WHERE employee_id = " & employeeId & " "
                Dim name = String.Concat(txtFname.Text, " ", txtMname.Text, " ", txtLname.Text)

                With cmd
                    .Connection = strCon
                    .CommandText = sql
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@name", name)
                    .Prepare()
                    .ExecuteNonQuery()
                End With
                If result = 0 Then
                    MessageBox.Show("FAILED TO UPDATE RECORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("RECORD HAS BEEN UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)


                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
        End Try

        facultyList.refreshData()
        Me.Hide()
    End Sub

    Private Sub btnuploadImage_Click(sender As Object, e As EventArgs) Handles btnuploadImage.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            ofd.Filter = "Picture Files (*) | *.bmp; *.gif; *.jpg"
            employeeImage.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub
End Class