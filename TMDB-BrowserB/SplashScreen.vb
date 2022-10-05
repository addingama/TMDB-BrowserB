Public Class SplashScreen
    ' Global variable untuk menampilkan nilai progress
    Dim progress As Integer = 0
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 10
        Timer1.Start()
    End Sub

    ' Fungsi yang akan dijalankan setiap interval timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Menghitung progress terbaru
        Dim newProgress = progress + 1
        ' Mengupdate global variable progress supaya tidak stuk di angka 0
        progress = newProgress

        'Jika progress sama dengan 100 maka hentikan timer
        If (progress = 100) Then
            Timer1.Stop()
            Me.Hide()
            MovieListLocal.Show()

        End If

        ' set progress bar value menggunakan nilai newProgress
        pb_progress.Value = newProgress
        lbl_loading.Text = "Loading... " & newProgress & "%"
    End Sub
End Class
