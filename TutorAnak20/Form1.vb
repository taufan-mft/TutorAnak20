﻿Public Class Form1
    Dim repository As New Repository
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bahan As New BahanBakuModel(100, 100)
        repository.saveRealBahan(bahan)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pemesanan.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Bom2.Show() 'buk
    End Sub
End Class
