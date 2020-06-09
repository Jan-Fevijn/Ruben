Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class addEvent
    Private Sub addEvent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNaam.Text = ADMIN.voornaam & " " & ADMIN.naam
        lblUsernamee.Text = ADMIN.gebruikersnaam
        loadEventen()
    End Sub
    Private Sub loadEventen()
        eventen.Clear()
        ADMIN.evenementen.Clear()
        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        '  Try


        conn.Open()

        Dim mySelectQuery As String = "select * from event "
        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()
        Dim user As New user


        While (rd.Read())

            '  MsgBox(rd(0) & rd(1) & rd(2) & rd(3) & rd(4))
            Dim evenement As New evenement
            evenement.idevent = rd(0)
            evenement.van = rd(1)
            evenement.datumEnd = rd(2)
            evenement.img = rd(3)
            evenement.naam = rd(4)
            '   MsgBox(evenement.idevent & " " & evenement.van & " " & evenement.datumEnd & " " & evenement.img & " " & evenement.naam)
            ADMIN.evenementen.Add(evenement)



        End While


        eventen.ShowItemToolTips = True
        eventen.View = View.Details


        eventen.Columns.Add("eventID", 120)
        eventen.Columns.Add("naam event", 120)
        eventen.Columns.Add("van", 120)
        eventen.Columns.Add("tot", 120)
        eventen.Columns.Add("url", 120)
        For Each evenement In ADMIN.evenementen

            Dim TempStr(4) As String
            Dim TempNode As ListViewItem
            TempStr(0) = evenement.idevent
            TempStr(1) = evenement.naam
            TempStr(2) = evenement.van
            TempStr(3) = evenement.datumEnd
            TempStr(4) = evenement.img
            TempNode = New ListViewItem(TempStr)
            eventen.Items.Add(TempNode)
        Next

    End Sub
    Private Sub btnAddEvent_Click(sender As Object, e As EventArgs) Handles btnAddEvent.Click
        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim con As New MySqlConnection(connStr)
        con.Open()
        Dim Query = "INSERT INTO `kokenvoorgroepen`.`event` ( `datumStart`, `datumEnd`, `img`, `naam`) VALUES ('" & txtVan.Text & "', '" & txtTot.Text & "', '" & txtUrl.Text & "', '" & txtNaam.Text & "')"
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
        loadEventen()
    End Sub
    '----------------------------<MENUSTRIP>-----------------------------------'
    '-----------event
    Private Sub ToevoegenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToevoegenToolStripMenuItem.Click
        ' add event
        Me.Show()
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
        addGerecht.Show()
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

    Private Sub KoppelingenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KoppelingenToolStripMenuItem.Click
        koppelingen.Show()
        Me.Hide()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ADMIN.Show()
        Me.Hide()
    End Sub
    '----------------------------</MENUSTRIP>-----------------------------------'
End Class