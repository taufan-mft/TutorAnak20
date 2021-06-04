Public Class Purchasing
    Dim repository As New Repository
    Private Sub Purchasing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub loadData()
        Label6.Text = 0
        Label7.Text = 0
        Dim neededKopi As Int16 = repository.getNeededBahanCount(kopi)
        Dim neededSusu As Int16 = repository.getNeededBahanCount(susu)
        Dim availableKopi As Int16 = repository.getRealBahanCount(kopi)
        Dim availableSusu As Int16 = repository.getRealBahanCount(susu)
        If neededKopi - availableKopi > 0 Then
            Label6.Text = neededKopi - availableKopi
            TextBox1.Text = neededKopi - availableKopi
        End If
        If neededSusu - availableSusu > 0 Then
            Label7.Text = neededSusu - availableSusu
            TextBox2.Text = neededSusu - availableSusu
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bahan As New BahanBakuModel(TextBox2.Text, TextBox1.Text)
        repository.saveRealBahan(bahan)
    End Sub
End Class