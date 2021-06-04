Public Class Repository
    Public Shared dataPesanan As New List(Of PesananModel)
    Sub New()

    End Sub
    Sub savePesanan(pesanan As PesananModel)
        dataPesanan.Add(pesanan)
        Debug.WriteLine("BERHASIL")
    End Sub
End Class
