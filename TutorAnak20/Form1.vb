Public Class Form1
    Dim repository As New Repository
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pemesanan.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Debug.WriteLine(Repository.dataPesanan)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Bom2.Show()
    End Sub
End Class
