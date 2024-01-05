Imports MySql.Data.MySqlClient
Module DB
    'connection statement includes the server=localhost, password, user=root and the database

    Public connect As New MySqlConnection("Server=localhost;password=;user=root;database=fpms; convert zero datetime=true")
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public ds As DataTable
    Public da As New MySqlDataAdapter
    Function qry(ByVal r As String) As String
        Dim cmd As New MySqlCommand(r, connect)
        connect.Open()
        cmd.ExecuteNonQuery()
        connect.Close()
        Return r
    End Function

    Public Sub cQuery(q As String)
        Dim cmd As New MySqlCommand(q, connect)
        connect.Open()
        cmd.ExecuteNonQuery()
        connect.Close()
    End Sub

    Sub setconnection()
        Try
            connect.ConnectionString = "Server=" & My.Settings.host & ";Database=" & My.Settings.dbname & ";User ID=" & My.Settings.usid & ";Password =" & My.Settings.pwd & ""
            connect.Open()
            connect.Close()
        Catch ex As Exception
            ex.ToString()
        End Try
    End Sub

End Module
