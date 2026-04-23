Imports System.IO

Public Class Form1
    Dim filepath As String = "JurnalHarian.txt"
    Function AmbilMood() As String

        For Each ctrl As Control In GrpMood.Controls
            If TypeOf ctrl Is RadioButton Then
                Dim rb As RadioButton = CType(ctrl, RadioButton)
                If rb.Checked Then

                    Select Case rb.Text
                        Case "Bahagia" : Return "Bahagia 😊"
                        Case "Tenang" : Return "Tenang 🧘"
                        Case "Biasa" : Return "Biasa 😐"
                        Case "Sedih" : Return "Sedih 😢"
                        Case "Cemas" : Return "Cemas 😰"
                        Case "Marah" : Return "Marah 😡"
                        Case Else : Return rb.Text
                    End Select
                End If
            End If
        Next
        Return ""
    End Function

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Dim mood As String = AmbilMood()

        Dim skala As Integer = tbSkalaMood.Value


        If mood = "" Then
            MessageBox.Show("Pilih mood dulu ya 🌷", "Peringatan")
            Exit Sub
        End If

        Try

            Dim data As String =
            "================================" & Environment.NewLine &
            "Tanggal     : " & dtpTanggal.Value.ToShortDateString & Environment.NewLine &
            "Mood        : " & mood & Environment.NewLine &
            "Skala Mood  : " & skala & "/10" & Environment.NewLine &
            "Refleksi    : " & rtbRefleksi.Text & Environment.NewLine &
            "Manifestasi : " & rtbManifestasi.Text & Environment.NewLine &
            "================================" & Environment.NewLine & Environment.NewLine

            File.AppendAllText(filepath, data)

            MessageBox.Show("Jurnal Ruang Teduh berhasil disimpan! ✨", "Sukses")


            rtbRefleksi.Clear()
            rtbManifestasi.Clear()
            tbSkalaMood.Value = 5
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnBaca_Click(sender As Object, e As EventArgs) Handles BtnBaca.Click
        Try

            Dim bukaRiwayat As New FormRiwayat()
            bukaRiwayat.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka riwayat: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub tbSkalaMood_Scroll(sender As Object, e As EventArgs) Handles tbSkalaMood.Scroll
        lblAngka.Text = tbSkalaMood.Value.ToString()
    End Sub
End Class
