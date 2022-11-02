Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Module DBConnection
    Public CONN As MySqlConnection = New MySqlConnection()
    Public CMD As MySqlCommand

    Sub OpenConnection()
        CONN.ConnectionString = "server=localhost;user id=root;password=;database=movie_browser_b"
        CONN.Open()
    End Sub

    Sub CloseConnection()
        CONN.Close()
    End Sub
End Module
