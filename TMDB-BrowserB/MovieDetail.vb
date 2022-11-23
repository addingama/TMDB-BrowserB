Imports System.IO
Imports System.Net

Public Class MovieDetail
    Private Sub lbl_overview_Click(sender As Object, e As EventArgs) Handles lbl_overview.Click

    End Sub

    Private Sub MovieDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ambil data film terpilih dari form MovieListLocal
        Dim film = MovieListLocal.selectedMovie

        With film
            'Set judul dari form
            Me.Text = "Detail Film : " & .title
            ' Tampilkan overview
            lbl_overview.Text = .overview

            'Client untuk download gambar dari internet
            Dim tClient As WebClient = New WebClient
            'Download gambar dari internet dan simpan ke dalam bentuk Bitmap
            Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(.poster_path)))
            'Set image dari PictureBox menggunakan Bitmap yang telah di download
            pb_poster.Image = tImage

        End With
    End Sub
End Class