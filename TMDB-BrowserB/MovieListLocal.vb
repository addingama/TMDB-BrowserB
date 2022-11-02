Imports System.Net.Http
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class MovieListLocal


    Private Sub MovieListLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub btn_get_todo_Click(sender As Object, e As EventArgs) Handles btn_get_todo.Click
        ' Membuat http client untuk API call
        Dim client As HttpClient = New HttpClient()
        ' Endpoint untuk dapatkan daftar film
        Dim url = "https://api.themoviedb.org/3/movie/now_playing?api_key=f71d911906b0a0157109443316cf77f8"
        'Await menunggu fungsig GetStringAsync sampai selesai
        'Melakukan get request ke url dan mendapatkan hasil akhir berupa String
        Dim response = Await client.GetStringAsync(url)

        'Melakukan Deserialisasi string response ke Object GetNowPlayingMoviesResponse menggunakan library Newtonsoft
        Dim nowPlayingMoviesResponse = JsonConvert.DeserializeObject(Of GetNowPlayingMoviesResponse)(response)

        'Variable penampung film pada index ke x
        Dim firstMovie = nowPlayingMoviesResponse.results(2)

        'Tampilkan data film ke aplikasi
        lbl_title.Text = firstMovie.title
        lbl_release_date.Text = firstMovie.release_date
        lbl_overview.Text = firstMovie.overview

        'Proses cek apakah data film dengan id x sudah ada di tabel atau belum
        OpenConnection()
        Dim checkFilmId = String.Format("Select * from films where id = {0}", firstMovie.id)
        CMD = New MySqlCommand(checkFilmId, CONN)
        'Karena butuh tau hasil dari CMD, maka gunakan ExecuteReader
        Dim result = CMD.ExecuteReader()

        'Periksa apakah hasilnya tidak ada/kosong
        If (Not result.HasRows()) Then
            'Close connection pengecekan id
            CloseConnection()

            'Buka koneksi baru untuk proses simpan data
            OpenConnection()
            'Simpan data ke DB
            Dim saveData As String = String.Format("Insert into films values ({0}, ""{1}"", ""{2}"", ""{3}"", ""{4}"", ""{5}"")", firstMovie.id, firstMovie.title, firstMovie.poster_path, firstMovie.release_date, firstMovie.vote_average, firstMovie.overview)
            CMD = New MySqlCommand(saveData, CONN)
            CMD.ExecuteNonQuery()


            MessageBox.Show("Data tersimpan")

        Else
            MessageBox.Show("Data duplikat")
        End If

        CloseConnection()



    End Sub
End Class