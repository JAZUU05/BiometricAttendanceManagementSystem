Imports MySql.Data.MySqlClient

Module DbConnection
    Dim DbServer As String = "localhost"
    Dim DbUser As String = "root"
    Dim DbPassword As String = ""
    Dim DbName As String = "bams"
    Dim DbPort As Integer = "3306"

    Private Function connectionString() As MySqlConnection
        Return New MySqlConnection($"server={DbServer}; user id={DbUser}; password={DbPassword}; database={DbName}")
    End Function

    Public strCon As MySqlConnection = connectionString()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public sql As String

    Public user_id As String
    ' For Checking Duplicates
    Public Function checkDuplicate(ByVal sql As String) As Boolean
        Dim duplicate As Boolean = False
        Try
            strCon.Open()
            With cmd
                .Connection = strCon
                .CommandText = sql
                .Parameters.Clear()
                .Prepare()
                cmd.ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            strCon.Close()
            da.Dispose()
            If dt.Rows.Count > 0 Then
                duplicate = True
            End If
        End Try

        Return duplicate
    End Function
    ' For checking if in use
    Public Function checkInUse(ByVal sql As String) As Boolean
        Dim duplicate As Boolean = False
        Try
            strCon.Open()
            With cmd
                .Connection = strCon
                .CommandText = sql
                .Parameters.Clear()
                .Prepare()
                cmd.ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            strCon.Close()
            da.Dispose()
            If dt.Rows.Count > 0 Then
                duplicate = True
            End If
        End Try

        Return duplicate
    End Function
    ' For SELECT Query
    Public Function ValidateLogin(ByVal uname As String, ByVal pword As String) As Boolean
        Dim success As Boolean = False
        Try
            strCon.Open()
            With cmd
                .Connection = strCon
                .CommandText = "SELECT * FROM login_admin WHERE username=@username AND password=@password"
                .Parameters.Clear()
                .Parameters.AddWithValue("@username", uname)
                .Parameters.AddWithValue("@password", pword)
                .Prepare()
                cmd.ExecuteNonQuery()
            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            strCon.Close()
            da.Dispose()
            If dt.Rows.Count > 0 Then
                Dim Username, Password As String
                user_id = dt.Rows(0).Item("id")
                Username = dt.Rows(0).Item("username")
                Password = dt.Rows(0).Item("password")
                If uname = Username And pword = Password Then
                    success = True
                Else
                    MsgBox("Incorrect Username/Password", MsgBoxStyle.Critical, "Login Failed")
                End If
            End If
        End Try
        If success Then
            Return True
        End If

        Return False
    End Function

    ' For SQL INSERT statements
    Public Sub insertRecord(ByVal sql As String)
        Try
            strCon.Open()
            With cmd
                .Connection = strCon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                'If result = 0 Then
                '    MessageBox.Show("FAILED TO SAVE DATA TO DATABASE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Else
                '    MessageBox.Show("DATA HAS BEEN SAVED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
        End Try
    End Sub


    ' For SQL UPDATE statements
    Public Sub updateRecord(ByVal sql As String)
        Try
            strCon.Open()
            With cmd
                .Connection = strCon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO UPDATE RECORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    'MessageBox.Show("RECORD HAS BEEN UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
        End Try
    End Sub

    ' For SQL DELETE Statements
    Public Sub deleteRecord(ByVal sql As String)

        Try
            strCon.Open()
            With cmd
                .Connection = strCon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    'MessageBox.Show("FAILED TO DELETE RECORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    'MessageBox.Show("RECORD HAS BEEN DELETED IN DATABASE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
        End Try
    End Sub

    ' For SQL SELECT Statements
    Public Sub loadRecords(ByVal sql As String, ByVal dgView As Object)
        Try
            dt = New DataTable
            strCon.Open()
            With cmd
                .Connection = strCon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            dgView.datasource = dt

            If dt.Rows.Count = 0 Then
                MessageBox.Show("No Records Found", "No Records Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strCon.Close()
            da.Dispose()
        End Try
    End Sub

    'For SQL LoadData
    Public Sub loadPosition(ByVal sql As String)
        Try
            strCon.Open()
            With cmd
                .Parameters.Clear()
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
        End Try
    End Sub
End Module
