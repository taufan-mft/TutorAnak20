﻿Public Class GudangBahanBaku
    Dim repository As New Repository
    Private Sub GudangBahanBaku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load bahan yang dibutuhkan to listview
        Label5.Text = "0"
        Label6.Text = "0"
        For Each entry In Repository.neededBahan
            ListView1.Items.Add(New ListViewItem(New String() {entry.kopi, entry.susu}))
        Next
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        'load stok yang ada ke listview
        For Each entry In Repository.dataBahan
            ListView2.Items.Add(New ListViewItem(New String() {entry.kopi, entry.susu}))
        Next
        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        'calculate kekurangan
        Dim neededKopi As Int16 = repository.getNeededBahanCount(Constanta.kopi)
        Dim neededSusu As Int16 = repository.getNeededBahanCount(Constanta.susu)
        Dim availableKopi As Int16 = repository.getRealBahanCount(Constanta.kopi)
        Dim availableSusu As Int16 = repository.getRealBahanCount(Constanta.susu)
        If neededKopi - availableKopi > 0 Then
            Label5.Text = neededKopi - availableKopi
        End If
        If neededSusu - availableSusu > 0 Then
            Label6.Text = neededSusu - availableSusu
        End If
    End Sub
End Class