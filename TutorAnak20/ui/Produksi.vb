Public Class Produksi
    Dim repository As New Repository
    Private Sub Produksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each entry In Repository.dataPesanan
            ComboBox1.Items.Add(entry.name)
        Next
    End Sub

    Private Sub comboChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim pesanan As PesananModel = repository.getPesananByName(ComboBox1.SelectedItem.ToString())
        Label6.Text = pesanan.americano
        Label5.Text = pesanan.latte

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim americanoDrink As New BarangJadiModel("Americano", CInt(Label6.Text))
        Dim latteDrink As New BarangJadiModel("Latte", CInt(Label5.Text))
        'save buat nambahin bke gudang barang jadi
        repository.saveBarangJadi(americanoDrink)
        repository.saveBarangJadi(latteDrink)
        Dim bahanAmericano As New BahanBakuModel(-(CInt(Label6.Text) * susuAmericano), -(CInt(Label6.Text) * kopiAmericano))
        Dim bahanLatte As New BahanBakuModel(-(CInt(Label5.Text) * susuLatte), -(CInt(Label5.Text) * kopiLatter))
        'save buat ngurangin bahan baku
        repository.saveRealBahan(bahanAmericano)
        repository.saveRealBahan(bahanLatte)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GudangBarangJadi.Show()
    End Sub
End Class