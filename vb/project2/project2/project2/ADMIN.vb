
Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class ADMIN
    Public voornaam As String
    Public naam As String
    Public gebruikersnaam As String
    Public producten As New List(Of product)
    Public winkels As New List(Of winkel)
    Public eenheden As New List(Of eenheid)

    Public listGerechtID As New List(Of Integer)
        Public evenementen As New List(Of evenement)
        Public listOfgerechten As New List(Of gerecht)

        Private Sub userHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Gerechten.Items.Add("gelieve eerst een event aan te duiden.")
            Dim username
            If registreer.txtUsername.Text <> "" Then
                username = registreer.txtUsername.Text
            Else
                username = Login.txtUsername.Text
            End If


            inloggen(username)
            loadEventen()

        End Sub



    Public Sub inloggen(username)
        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        '  Try


        conn.Open()

        Dim mySelectQuery As String = "select * from user WHERE username = '" & username & "'"
        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()
        Dim user As New user
        While (rd.Read())

            '  MsgBox(rd(0) & rd(1) & rd(2) & rd(3) & rd(4) & rd(5) & rd(6) & rd(7))
            user.id = rd(0)
            user.voornaam = rd(1)
            user.naam = rd(2)
            user.password = rd(3)
            user.vegan = rd(4)
            user.veganistisch = rd(5)
            user.admin = rd(6)
            user.username = rd(7)



        End While
        lblNaam.Text = user.voornaam & " " & user.naam
        lblUsername.Text = user.username

        voornaam = user.voornaam
        naam = user.naam
        gebruikersnaam = user.username
        '   Catch ex As Exception
        '    MsgBox("error: there went somiting wrong.")


        '    End Try
        conn.Close()

    End Sub

    Public Sub loadEventen()

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
            evenementen.Add(evenement)



        End While
        For Each evenement In evenementen
            eventen.Items.Add(evenement.naam & " van " & evenement.van & " tot" & evenement.datumEnd)
        Next

        '   Catch ex As Exception
        '    MsgBox("error: there went somiting wrong.")


        '    End Try
        conn.Close()
    End Sub

    Private Sub eventen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles eventen.SelectedIndexChanged
            Gerechten.Clear()
            listOfgerechten.Clear()
            Dim idEvent = eventen.FocusedItem.Index + 1
            loadGerechten(idEvent)
            '  MsgBox(idEvent)
            loadEventData(idEvent)

        End Sub

        Private Sub loadEventData(idEvent)
            Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
            Dim conn As New MySqlConnection(connStr)
            '  Try


            conn.Open()



            Dim mySelectQuery As String = " select *from event WHERE idEvent = ' " & idEvent & "' "
            Dim myCommand As New MySqlCommand(mySelectQuery, conn)

            Dim rd As MySqlDataReader
            rd = myCommand.ExecuteReader()
            Dim user As New user


            While (rd.Read())
                lblEventNaam.Text = "naam event :" & rd(4)
                lblEventPer.Text = "van" & rd(1) & "tot" & rd(2)
            End While

        End Sub

        Private Sub loadGerechten(idEvent)

            Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
            Dim conn As New MySqlConnection(connStr)
            '  Try


            conn.Open()



            Dim mySelectQuery As String = " select egg.naam,egg.img, event.idEvent, egg.idGerecht, egg.vegan ,egg.veganistisch from event inner join ( SELECT  naam,img,vegan,veganistisch,idEvent, g.idGerecht FROM kokenvoorgroepen.gerecht as g inner join kokenvoorgroepen.eventgerecht as eg on g.idgerecht = eg.idgerecht ) as egg on egg.idEvent =  event.idEvent WHERE event.idEvent = ' " & idEvent & "' "
            Dim myCommand As New MySqlCommand(mySelectQuery, conn)

            Dim rd As MySqlDataReader
            rd = myCommand.ExecuteReader()
            Dim user As New user


            While (rd.Read())

                '   MsgBox(rd(0) & rd(1) & rd(2) & rd(3) & rd(4))
                Dim gerecht As New gerecht(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5))
                listOfgerechten.Add(gerecht)

            End While
            Dim vegan As String
            listGerechtID.Clear()

            For Each gerecht In listOfgerechten
                If gerecht.vegan = True Then
                    vegan = "vegitarisch gerecht"
                Else
                    If gerecht.veganistisch = True Then
                        vegan = "veganistisch gerecht"
                    Else
                        vegan = "niet vegitarisch / veganistisch"
                    End If

                End If

                Gerechten.Items.Add(gerecht.naam & " " & vegan)
                listGerechtID.Add(gerecht.idGerecht)
            Next
        End Sub

        Private Sub Gerechten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Gerechten.SelectedIndexChanged
            '''''''''''

            Dim idGerecht = listGerechtID(Gerechten.FocusedItem.Index)
            For Each gerecht In listOfgerechten
                If idGerecht = gerecht.idGerecht Then

                    Dim vegan As String


                    If gerecht.vegan = True Then
                        vegan = "vegitarisch gerecht"
                    Else
                        If gerecht.veganistisch = True Then
                            vegan = "veganistisch gerecht"
                        Else
                            vegan = "niet vegitarisch / veganistisch"
                        End If

                    End If
                    lblGerechtNaam.Text = "naam : " & gerecht.naam
                    lblGerechtVegan.Text = vegan
                    '  MsgBox(gerecht.idGerecht)
                    loadProducten(gerecht.idGerecht)

                End If

            Next

        End Sub

    Private Sub loadProducten(idGerecht)
        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        '  Try


        conn.Open()



        Dim mySelectQuery As String = " select naam from product  inner join  ( SELECT productid ,gerechtid FROM gerecht as g inner join produtgerecht as pg on pg.gerechtid = g.idgerecht ) as a on product.idproduct = a.productid where a.gerechtid = ' " & idGerecht & " '"
        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()
        Dim user As New user

        lblGerechtProducten.Text = "ingrediënten: "
        While (rd.Read())
            lblGerechtProducten.Text = lblGerechtProducten.Text & " " & rd(0)
        End While
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
        deleteProduct.show()
        Me.Hide()
    End Sub

    Private Sub WijzigenToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles WijzigenToolStripMenuItem3.Click
        'change product 
        changeProduct.Show()
        Me.Hide()
    End Sub
    '----------------------------</MENUSTRIP>-----------------------------------'
End Class