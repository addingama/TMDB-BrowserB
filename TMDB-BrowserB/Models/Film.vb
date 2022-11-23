Imports MySql.Data.MySqlClient

Public Class Film
    Public id As Integer
    Public title As String
    Public poster_path As String
    Public vote_average As Double
    Public release_date As String
    Public overview As String

    Public Function ApakahAdaDiDatabase()
        'Proses cek apakah data film dengan id x sudah ada di tabel atau belum
        OpenConnection()
        Dim checkFilmId = String.Format("Select * from films where id = {0}", id)
        CMD = New MySqlCommand(checkFilmId, CONN)
        'Karena butuh tau hasil dari CMD, maka gunakan ExecuteReader
        Dim result = CMD.ExecuteReader()
        Dim isExist = result.HasRows()
        CloseConnection()
        Return isExist

    End Function

    Public Sub SimpanKeDatabase()
        'Buka koneksi baru untuk proses simpan data
        OpenConnection()
        Dim escapedTitle = title.Replace("'", "\'")
        Dim escapedOverview = overview.Replace("'", "\'")
        'Simpan data ke DB
        Dim saveData As String = String.Format("Insert into films values ({0}, '{1}', ""{2}"", ""{3}"", ""{4}"", '{5}')", id, escapedTitle, poster_path, release_date, vote_average, escapedOverview)
        CMD = New MySqlCommand(saveData, CONN)
        CMD.ExecuteNonQuery()


        ' MessageBox.Show("Data film " & title & " berhasil disimpan")
        CloseConnection()
    End Sub
End Class
