Module Constanta
    Public americano As String = "americano"

    Public latte As String = "latter"

    Public susuAmericano As Int16 = 0

    Public susuLatte As Int16 = 200

    Public kopiAmericano As Int16 = 16

    Public kopiLatter As Int16 = 20

    Public susu As String = "susu"

    Public kopi As String = "kopi"

    Public jakarta As String = "Jakarta"
    Public bandung As String = "Bandung"

    Function calculateOngkir(kota As String)
        Dim ongkir As Int16 = 0
        If kota = jakarta Then
            ongkir = 8000
        End If
        If kota = bandung Then
            ongkir = 15000
        End If
        Return ongkir
    End Function
End Module
