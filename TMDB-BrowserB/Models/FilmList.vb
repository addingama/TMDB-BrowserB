Imports System.Diagnostics.Eventing
Imports System.Net.Http
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class FilmList
    Public Async Function AmbilDaftarFilmPadaHalaman(page As Integer) As Task(Of String)
        ' Membuat http client untuk API call
        Dim client As HttpClient = New HttpClient()
        ' Endpoint untuk dapatkan daftar film
        Dim url = String.Format("https://api.themoviedb.org/3/movie/now_playing?api_key=f71d911906b0a0157109443316cf77f8&page={0}", page)
        'Await menunggu fungsig GetStringAsync sampai selesai
        'Melakukan get request ke url dan mendapatkan hasil akhir berupa String
        Return Await client.GetStringAsync(url)
    End Function

    ' Data yang dikembalikan harus berupa List(Of Film)
    Public Function AmbilDaftarFilmPadaLocalDatabase() As List(Of Film)
        ' Karena butuh List (Of Film) maka harus di buat variable yang bertipe sama
        Dim penampungFilm = New List(Of Film)

        Dim query = "SELECT * FROM films"
        OpenConnection()
        CMD = New MySqlCommand(query, CONN)
        Dim result = CMD.ExecuteReader()

        ' Baca baris dari data yang di dapatkan dari database, jika ada maka eksekusi kode dalam while
        ' Jika sudah habis maka dilewati
        While result.Read()
            ' Karena hasilnya butuh objek film, maka harus harus di buat objek film
            Dim data = New Film()
            ' Mengisi data objek film dengan data yang ada dari database berdasarkan urutan kolom di database
            ' Kolom pertama sama dengan index ke 0
            data.id = result.GetValue(0)
            data.title = result.GetValue(1)
            Dim posterPath = result.GetValue(2)
            If (posterPath IsNot "") Then
                data.poster_path = "https://image.tmdb.org/t/p/original" & posterPath
            End If
            data.release_date = result.GetValue(3)
            data.vote_average = result.GetValue(4)
            data.overview = result.GetValue(5)
            ' Objek film simpan ke penampung
            penampungFilm.Add(data)
        End While

        ' Kembalikan data yang telah di format
        Return penampungFilm
        CloseConnection()
    End Function
End Class
