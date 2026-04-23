Imports System.IO

Public Class FormRiwayat
    Dim filepath As String = "JurnalHarian.txt"

    ' Event saat form terbuka
    Private Sub FormRiwayat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If File.Exists(filepath) Then
                ' Membaca semua isi file dan menampilkannya
                rtbLaporan.Text = File.ReadAllText(filepath)
            Else
                rtbLaporan.Text = "Belum ada catatan jurnal yang tersimpan. 🌸"
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat riwayat: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        Me.Close()
    End Sub
End Class