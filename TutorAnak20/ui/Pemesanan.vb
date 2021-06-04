Public Class Pemesanan
    Dim repository As New Repository
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesanan As New PesananModel(TextBox1.Text, TextBox2.Text, TextBox3.Text)
        repository.savePesanan(pesanan)
        ListView1.Items.Clear()
        For Each pesanan In Repository.dataPesanan
            ListView1.Items.Add(New ListViewItem(New String() {pesanan.name, pesanan.americano, pesanan.latte}))
        Next
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
End Class