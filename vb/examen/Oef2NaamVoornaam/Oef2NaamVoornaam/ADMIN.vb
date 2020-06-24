Public Class ADMIN
    Private Sub ADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'de producten worden in een lijst op het scherm getoont 
        loadProduct()

    End Sub
    Private Sub loadProduct()
        producten.ShowItemToolTips = True
        producten.View = View.Details

        producten.Clear()

        producten.Columns.Add("idproduct", 120)
        producten.Columns.Add("naamproduct", 120)
        producten.Columns.Add("hoeveelheid", 120)
        For Each product In Form1.producten
            Dim TempStr(3) As String
            Dim TempNode As ListViewItem
            TempStr(0) = product.idproduct
            TempStr(1) = product.naamproduct
            TempStr(2) = product.hoeveelheid
            TempNode = New ListViewItem(TempStr)
            producten.Items.Add(TempNode)
        Next
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' voegt een product toe aan de producten 
        Dim productToAdd As New product(producten.Items.Count + 1, txtNaamProduct.Text, numHoeveelheid.Value)
        Form1.producten.Add(productToAdd)
        loadProduct()
    End Sub

    Private Sub btnUitloggen_Click(sender As Object, e As EventArgs) Handles btnUitloggen.Click
        Form1.Show()
        Me.Hide()

    End Sub
End Class