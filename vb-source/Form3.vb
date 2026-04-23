Public Class FormLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUsername.Text = "admin" And TxtPassword.Text = "12345" Then
            MessageBox.Show("Selamat datang di Ruang Teduh ✨", "Login Berhasil")

            ' Membuka Form Jurnal (Form1) dan menyembunyikan Form Login
            Form1.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau Password salah! ❌", "Akses Ditolak")
            TxtPassword.Clear()
            TxtUsername.Focus()
        End If
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Application.Exit()
    End Sub
End Class