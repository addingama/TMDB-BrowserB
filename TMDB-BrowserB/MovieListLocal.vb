Imports System.Net.Http
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class MovieListLocal
    Dim filmList As FilmList = New FilmList()
    Dim movies As List(Of Film)
    Public selectedMovie As Film
    Private Sub MovieListLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hasil data film akan di simpan ke variable movies
        movies = filmList.AmbilDaftarFilmPadaLocalDatabase()

        ' Gunakan with untuk tidak mengulang menulis dgv_movie_list
        With dgv_movie_list
            .ColumnCount = 3 'Set jumlah kolom
            .Columns(0).Name = "Judul" ' Atur judul kolom, kolom pertama = index ke 0
            .Columns(0).Width = 200 ' Atur lebar kolom
            .Columns(1).Name = "Release Date"
            .Columns(1).Width = 100
            .Columns(2).Name = "Overview"

            ' Lakukan perulangan untuk setiap data yang ada pada movies
            For Each movie As Film In movies
                ' Format data menjadi array string yang memiliki 3 data
                Dim row() As String = {movie.title, movie.release_date, movie.overview}
                ' Tambahkan data yang telah di format ke baris DataGridView
                .Rows.Add(row)
            Next
        End With
    End Sub

    Private Async Sub btn_get_todo_Click(sender As Object, e As EventArgs) Handles btn_get_todo.Click



        For page = 1 To 10

            Dim response = Await filmList.AmbilDaftarFilmPadaHalaman(page)
            'Melakukan Deserialisasi string response ke Object GetNowPlayingMoviesResponse menggunakan library Newtonsoft
            Dim nowPlayingMoviesResponse = JsonConvert.DeserializeObject(Of GetNowPlayingMoviesResponse)(response)

            'Lakukan penyimpanan semua data film yang ada di results
            For index = 0 To nowPlayingMoviesResponse.results.Length - 1
                'Variable penampung film pada index ke x
                Dim filmYangTerpilih = nowPlayingMoviesResponse.results(index)

                'Periksa apakah hasilnya tidak ada/kosong
                If (Not filmYangTerpilih.ApakahAdaDiDatabase()) Then
                    filmYangTerpilih.SimpanKeDatabase()
                Else
                    'MessageBox.Show("Data duplikat")
                End If

                CloseConnection()
            Next

        Next


    End Sub


    Private Sub dgv_movie_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_movie_list.CellDoubleClick
        ' Menyimpan objek Film sesuai dengan index yang terpilih
        selectedMovie = movies(e.RowIndex)
        'Tutup detail form
        MovieDetail.Close()
        'buka lagi
        MovieDetail.Show()
    End Sub


End Class