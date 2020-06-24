Public Class gebruiker
    Private Sub gebruiker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'zet producten in de lijst 
        loadProducts()
    End Sub
    Private Sub loadProducts()
        comboProducten.Items.Clear()
        For Each product In Form1.producten
            If product.hoeveelheid > 1 Then
                comboProducten.Items.Add(product.naamproduct)
            End If

        Next
    End Sub
    Private Sub btnBestellen_Click(sender As Object, e As EventArgs) Handles btnBestellen.Click
        'als je op bestellen klikt wordt de hoeveelheid van het product met 1 afgetrokken 
        'en wordt de lijst van prodcuten in de combobox (dropdown) opnieuw gelaaden.
        For Each product In Form1.producten
            If product.idproduct = comboProducten.SelectedIndex + 1 Then
                product.hoeveelheid = product.hoeveelheid - 1
            End If
        Next
        loadProducts()

    End Sub

    Private Sub btnUitloggen_Click(sender As Object, e As EventArgs) Handles btnUitloggen.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class