Public Class Form4

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim hargaSewaPerHari As Integer = 0
        Dim tambahanBiaya As Integer = 0

        Select Case ComboBox1.SelectedItem.ToString()
            Case "Standard Room"
                hargaSewaPerHari = 200000
            Case "Superior Room"
                hargaSewaPerHari = 300000
            Case "Deluxe Room"
                hargaSewaPerHari = 350000
            Case "Suite Room"
                hargaSewaPerHari = 550000
        End Select



        If ComboBox2.SelectedItem.ToString() = "Dengan Breakfast" Then
            tambahanBiaya = 20000

        ElseIf ComboBox1.SelectedItem.ToString() = "Suite Room" AndAlso ComboBox2.SelectedItem.ToString = "Dengan Breakfast" Then
            tambahanBiaya = 0



        End If

        Dim lamaSewa As Integer = Convert.ToInt32(TextBox4.Text)
        Dim biayaSewa As Integer = (hargaSewaPerHari + tambahanBiaya) * lamaSewa

        ' Menampilkan data pesanan
        MessageBox.Show("No. Identitas: " & TextBox1.Text & Environment.NewLine & "Nama: " & TextBox2.Text & Environment.NewLine & "No Hp: " & TextBox3.Text & Environment.NewLine & "Jenis Kamar: " & ComboBox1.SelectedItem.ToString() & Environment.NewLine & "Tipe Layanan: " & ComboBox2.SelectedItem.ToString() & Environment.NewLine & "Lama Sewa: " & TextBox4.Text & Environment.NewLine & "Biaya Sewa: Rp " & biayaSewa.ToString("#,##0"))
    End Sub
End Class