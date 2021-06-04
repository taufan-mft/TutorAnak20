Public Class Repository
    Public Shared dataPesanan As New List(Of PesananModel)

    Sub New()

    End Sub
    Sub savePesanan(pesanan As PesananModel)
        dataPesanan.Add(pesanan)
        Debug.WriteLine("BERHASIL")
    End Sub

    Function getProductCount(name As String)
        Dim total As Int16 = 0
        For Each pesanan In dataPesanan
            If name = Constanta.americano Then
                total = total + pesanan.americano
            End If

            If name = Constanta.latte Then
                total = total + pesanan.latte
            End If
        Next
        Return total
    End Function
End Class
