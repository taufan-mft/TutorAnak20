Public Class Bom2
    Dim repository As New Repository
    Private Sub comboChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        If ComboBox1.SelectedItem.ToString() = "Americano" Then
            Dim jumlah As Int16 = repository.getProductCount(Constanta.americano)
            TextBox1.Text = jumlah.ToString
            populateField(jumlah, Constanta.americano)
        End If
        If ComboBox1.SelectedItem.ToString() = "Latte" Then
            Dim jumlah As Int16 = repository.getProductCount(Constanta.latte)
            TextBox1.Text = jumlah.ToString()
            populateField(jumlah, Constanta.latte)
        End If
    End Sub

    Private Sub Bom2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox1.SelectedValue = "Americano" Then
            TextBox1.Text = repository.getProductCount(Constanta.americano).ToString()
        End If
        If ComboBox1.SelectedValue = "Latte" Then
            TextBox1.Text = repository.getProductCount(Constanta.latte).ToString()
        End If
    End Sub

    Private Sub populateField(jumlah As Int16, jenis As String)
        If jenis = Constanta.americano Then
            Label3.Text = jumlah * Constanta.susuAmericano
            Label4.Text = jumlah * Constanta.kopiAmericano
        End If
        If jenis = Constanta.latte Then
            Label3.Text = jumlah * Constanta.susuLatte
            Label4.Text = jumlah * Constanta.kopiLatter
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bahan As New BahanBakuModel(CInt(Label3.Text), CInt(Label4.Text))
        repository.saveRequiredBahan(bahan)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GudangBahanBaku.Show()
    End Sub
End Class