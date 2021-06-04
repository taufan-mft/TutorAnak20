Public Class Repository
    Public Shared dataPesanan As New List(Of PesananModel)
    Public Shared neededBahan As New List(Of BahanBakuModel) 'save the needed bahan baku
    Public Shared dataBahan As New List(Of BahanBakuModel) 'save the real bahan baku
    Public Shared dataJadi As New List(Of BarangJadiModel) 'save for logistics
    Public Shared dataLogistik As New List(Of LogistikModel)
    Sub New()

    End Sub
    Sub savePesanan(pesanan As PesananModel)
        dataPesanan.Add(pesanan)
        Debug.WriteLine("BERHASIL")
    End Sub

    Function getPesananByName(name As String)
        Dim result As PesananModel
        For Each entry In dataPesanan
            If entry.name = name Then
                result = entry
            End If
        Next
        Return result
    End Function

    Sub saveRequiredBahan(bahan As BahanBakuModel)
        neededBahan.Add(bahan)
    End Sub

    Sub saveRealBahan(bahan As BahanBakuModel)
        dataBahan.Add(bahan)
    End Sub

    Sub saveBarangJadi(barang As BarangJadiModel)
        dataJadi.Add(barang)
    End Sub

    Sub saveLogistik(entry As LogistikModel)
        dataLogistik.Add(entry)
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

    Function getNeededBahanCount(name As String)
        Dim total As Int16 = 0
        For Each entry In neededBahan
            If name = Constanta.kopi Then
                total = total + entry.kopi
            End If
            If name = Constanta.susu Then
                total = total + entry.susu
            End If

        Next
        Return total
    End Function

    Function getRealBahanCount(name As String)
        Dim total As Int16 = 0
        For Each entry In dataBahan
            If name = Constanta.kopi Then
                total = total + entry.kopi
            End If
            If name = Constanta.susu Then
                total = total + entry.susu
            End If
        Next
        Return total
    End Function
End Class
