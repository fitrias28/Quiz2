Public Class Form5

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click


        Dim hargaSewaPerHari As Integer = 0
        Dim tambahanBiayaSopir As Integer = 0

        Select Case ComboBox1.SelectedItem.ToString()
            Case "Toyota Avanza"
                hargaSewaPerHari = 240000
            Case "Toyota Calya"
                hargaSewaPerHari = 210000
            Case "Toyota Inova"
                hargaSewaPerHari = 340000
            Case "Daihatsu Xenia"
                hargaSewaPerHari = 230000
            Case "Daihatsu Sigra"
                hargaSewaPerHari = 200000
            Case "Honda Brio"
                hargaSewaPerHari = 230000
            Case "Honda Mobilio"
                hargaSewaPerHari = 240000
            Case "Mitsubishi Xpander"
                hargaSewaPerHari = 300000
        End Select

        If ComboBox2.SelectedItem.ToString() = "Dengan Sopir" Then
            tambahanBiayaSopir = 150000
        End If

        Dim lamaSewa As Integer = Convert.ToInt32(TextBox4.Text)
        Dim biayaSewa As Integer = (hargaSewaPerHari + tambahanBiayaSopir) * lamaSewa

        ' Menampilkan data pesanan
        MessageBox.Show("No. Identitas: " & TextBox1.Text & Environment.NewLine & "Nama: " & TextBox2.Text & Environment.NewLine & "No Hp: " & TextBox3.Text & Environment.NewLine & "Jenis Mobil: " & ComboBox1.SelectedItem.ToString() & Environment.NewLine & "Tipe Layanan: " & ComboBox2.SelectedItem.ToString() & Environment.NewLine & "Lama Sewa: " & TextBox4.Text & Environment.NewLine & "Biaya Sewa: Rp " & biayaSewa.ToString("#,##0"))
    End Sub
End Class