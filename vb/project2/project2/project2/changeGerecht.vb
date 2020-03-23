Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class changeGerecht
    Private Sub changeGerecht_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNaam.Text = ADMIN.voornaam & " " & ADMIN.naam
        lblusername.Text = ADMIN.gebruikersnaam
        loadProducten()
    End Sub


    Private Sub loadProducten()
        producten.ShowItemToolTips = True
        producten.View = View.Details

        producten.Clear()
        ADMIN.adminGerechten.Clear()

        producten.Columns.Add("gerechtID", 120)
        producten.Columns.Add("naam", 120)
        producten.Columns.Add("img url", 120)
        producten.Columns.Add("vegitarisch / veganistisch", 120)
        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        '  Try


        conn.Open()

        Dim mySelectQuery As String = "select * from gerecht "
        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()
        Dim user As New user
        While (rd.Read())
            Dim product As New adminGerecht(rd(0), rd(1), rd(2), rd(3), rd(4))
            ADMIN.adminGerechten.Add(product)
        End While

        For Each product In ADMIN.adminGerechten
            Dim TempStr(3) As String
            Dim TempNode As ListViewItem
            TempStr(0) = product.idGerecht
            TempStr(1) = product.naam
            TempStr(2) = product.img
            Dim vegan

            If product.vegan = True Then
                vegan = "veganistisch gerecht"
            ElseIf product.veganistisch = True Then
                vegan = "vegitarisch gerecht"
            Else
                vegan = "niet vegitarisch / veganistisch "
            End If

            TempStr(3) = product.vegan


            TempNode = New ListViewItem(TempStr)
            producten.Items.Add(TempNode)
        Next

    End Sub


    Private Sub btnAddGerecht_Click(sender As Object, e As EventArgs) Handles btnAddGerecht.Click

        Dim idgerecht = producten.SelectedItems(0).SubItems(0).Text

        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim con As New MySqlConnection(connStr)
        Dim vegan
        Dim veganistisch
        If radVegan.Checked = True Then
            vegan = True
            veganistisch = False
        ElseIf radVeganistisch.Checked = True Then
            vegan = False
            veganistisch = True
        ElseIf radGeen.Checked = True Then
            vegan = False
            veganistisch = False
        End If
        con.Open()
        Dim Query = "UPDATE `kokenvoorgroepen`.`gerecht` SET `naam` = '" & txtNaam.Text & "', `img` = '" & txtUrl.Text & "', `vegan` = '" & vegan & "', `veganistisch` = '" & veganistisch & "' WHERE (`idgerecht` = '" & idgerecht & "')"
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
        Me.Show()
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
        deleteProduct.Show()
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