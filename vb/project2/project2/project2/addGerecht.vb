Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class addGerecht
    Private Sub addGerecht_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNaam.Text = ADMIN.voornaam & " " & ADMIN.naam
        lblusername.Text = ADMIN.gebruikersnaam
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
            ADMIN.producten.Add(product)
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
    '----------------------------<MENUSTRIP>-----------------------------------'
    '-----------event
    Private Sub ToevoegenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToevoegenToolStripMenuItem.Click
        ' add event
        addEvent.Show()
        Me.Hide()
    End Sub
    Private Sub VerwijderenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerwijderenToolStripMenuItem.Click
        ' delete event
        deleteEvent.Show()
        Me.Hide()
    End Sub
    Private Sub WijzigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WijzigenToolStripMenuItem.Click
        ' delete event
        changeEvent.Show()
        Me.Hide()
    End Sub

    '-----------------gerecht
    Private Sub WijzigenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WijzigenToolStripMenuItem1.Click
        ' add gerecht
        Me.Show()
        Me.Hide()
    End Sub



    Private Sub WijzigenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles WijzigenToolStripMenuItem2.Click
        ' delete gerecht
        deleteGerecht.Show()
        Me.Hide()
    End Sub

    Private Sub WijzigenToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles WijzigenToolStripMenuItem4.Click
        ' change gerecht
        changeGerecht.Show()
        Me.Hide()
    End Sub

    '----------product
    Private Sub ToevoegenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToevoegenToolStripMenuItem1.Click
        ' add product
        addProduct.Show()
        Me.Hide()
    End Sub
    Private Sub VerwijderenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerwijderenToolStripMenuItem1.Click
        'delete product 
        deleteProduct.Show()
        Me.Hide()
    End Sub

    Private Sub WijzigenToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles WijzigenToolStripMenuItem3.Click
        'change product 
        changeProduct.Show()
        Me.Hide()
    End Sub
    '----------------------------</MENUSTRIP>-----------------------------------'
End Class