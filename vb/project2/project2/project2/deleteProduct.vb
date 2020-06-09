Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class deleteProduct

    Private Sub deleteProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNaam.Text = ADMIN.voornaam & " " & ADMIN.naam
        lblUsername.Text = ADMIN.gebruikersnaam
        loadProducten()
    End Sub

    Private Sub loadProducten()
        producten.ShowItemToolTips = True
        producten.View = View.Details

        producten.Clear()
        ADMIN.producten.Clear()

        producten.Columns.Add("productID", 120)
        producten.Columns.Add("productnaam", 120)
        producten.Columns.Add("hoeveelheid in stock", 120)
        producten.Columns.Add("winkel (aankoop)", 120)
        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        '  Try


        conn.Open()

        Dim mySelectQuery As String = "select idproduct, sub.naam as productnaam ,hoeveelheid, eenheid, winkel.naam as winkel  from winkel inner join  (select idproduct, naam , hoeveelheid ,idwinkel,voluit as eenheid from product inner join eenheden on eenheden.afkorting = product.eenheid ) as sub on  winkel.idwinkel = sub.idwinkel ORDER BY idproduct "
        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()
        Dim user As New user
        While (rd.Read())
            Dim product As New product(rd(0), rd(1), rd(2), rd(3), rd(4))
            ADMIN.producten.add(product)
        End While

        For Each product In ADMIN.producten
            Dim TempStr(3) As String
            Dim TempNode As ListViewItem
            TempStr(0) = product.id
            TempStr(1) = product.productNaam
            TempStr(2) = product.hoeveelheid & " " & product.eenheid
            TempStr(3) = product.winkel


            TempNode = New ListViewItem(TempStr)
            producten.Items.Add(TempNode)
        Next

    End Sub
    Private Sub btnDeleteSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteSelected.Click
        MsgBox(producten.SelectedItems.Count)

        Dim productid = producten.SelectedItems(0).SubItems(0).Text
            MsgBox(productid)
            Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
            Dim con As New MySqlConnection(connStr)
            con.Open()
            Dim Query = "DELETE FROM `kokenvoorgroepen`.`product` WHERE (`idproduct` = " & productid & ");"
            Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
            MsgBox(Query)
            Dim y As Integer = cmd.ExecuteNonQuery()
            If (y > 0) Then
                'deletid sucsesfuly 
            Else
                'failed
                MsgBox("it failed")
            End If
            con.Close()
            loadProducten()

    End Sub
    '----------------------------<MENUSTRIP>-----------------------------------'
    '-----------event
    Private Sub ToevoegenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' add event
        addEvent.Show()
        Me.Hide()
    End Sub
    Private Sub VerwijderenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' delete event
        deleteEvent.Show()
        Me.Hide()
    End Sub
    Private Sub WijzigenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ' delete event
        changeEvent.Show()
        Me.Hide()
    End Sub

    '-----------------gerecht
    Private Sub WijzigenToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ' add gerecht
        addGerecht.Show()
        Me.Hide()
    End Sub



    Private Sub WijzigenToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        ' delete gerecht
        deleteGerecht.Show()
        Me.Hide()
    End Sub

    Private Sub WijzigenToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        ' change gerecht
        changeGerecht.Show()
        Me.Hide()
    End Sub

    '----------product
    Private Sub ToevoegenToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ' add product
        addProduct.Show()
        Me.Hide()
    End Sub
    Private Sub VerwijderenToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'delete product 
        Me.Show()
        Me.Hide()
    End Sub

    Private Sub WijzigenToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        'change product 
        changeProduct.Show()
        Me.Hide()
    End Sub

    Private Sub KoppelingenToolStripMenuItem_Click(sender As Object, e As EventArgs)
        koppelingen.Show()
        Me.Hide()
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ADMIN.Show()
        Me.Hide()
    End Sub
    '----------------------------</MENUSTRIP>-----------------------------------'
End Class