Public Class Logistik
    Dim repository As New Repository
    Private Sub Logistik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each entry In Repository.dataPesanan
            ComboBox1.Items.Add(entry.name)
        Next
    End Sub

    Private Sub comboNameChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Dim pesanan As PesananModel = repository.getPesananByName(ComboBox1.SelectedItem.ToString())
        Label6.Text = pesanan.americano
        Label7.Text = pesanan.latte

    End Sub
    Private Sub comboCityChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedValueChanged
        Dim ongkir As Int16 = calculateOngkir(ComboBox2.SelectedItem.ToString())
        Label9.Text = ongkir

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim logistikEntry As New LogistikModel(ComboBox1.SelectedItem.ToString(), ComboBox2.SelectedItem.ToString(), Label9.Text)
        repository.saveLogistik(logistikEntry)
        'kurangi barang jadi
        Dim americanoDrink As New BarangJadiModel("Americano", -CInt(Label6.Text))
        Dim latteDrink As New BarangJadiModel("Latte", -CInt(Label7.Text))
        repository.saveBarangJadi(americanoDrink)
        repository.saveBarangJadi(latteDrink)
    End Sub
End Class