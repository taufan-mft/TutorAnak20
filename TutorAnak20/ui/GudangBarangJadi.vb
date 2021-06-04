Public Class GudangBarangJadi
    Dim repository As New Repository
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListView1.Items.Clear()
        For Each entry In Repository.dataJadi
            ListView1.Items.Add(New ListViewItem(New String() {entry.name, entry.qty}))
        Next
    End Sub

    Private Sub GudangBarangJadi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Items.Clear()
        For Each entry In Repository.dataJadi
            ListView1.Items.Add(New ListViewItem(New String() {entry.name, entry.qty}))
        Next
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Logistik.Show()
    End Sub
End Class