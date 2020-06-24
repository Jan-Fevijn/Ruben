Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    ' maak lijsten aan 
    Public vaken As New List(Of vak)
    Public leerlingen As New List(Of leerling)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'haalt de vakken en de leerlingen uit de databank en steekt ze in de lijsten van objecten

        loadVak()
        loadleerling()
        'zorgt ervoor dat de datagridview niet kan gewijzigd worden 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = False
        DataGridView1.AllowUserToResizeRows = False
    End Sub
    Private Sub loadleerling()
        Dim conn = f.openConn()
        Dim mySelectQuery As String = "SELECT * FROM leerling "
        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()

        While (rd.Read())
            Dim leerling As New leerling(rd(0), rd(1), rd(2), rd(3), rd(4))
            leerlingen.Add(leerling)
        End While
        For Each leerling In leerlingen
            ComboBox1.Items.Add(leerling.voornaam & "  " & leerling.naam)
            listLeerlingen.Items.Add(leerling.voornaam & "  " & leerling.naam)
        Next
    End Sub
    Private Sub loadVak()
        Dim conn = f.openConn()
        Dim mySelectQuery As String = "SELECT * FROM vak "
        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()

        While (rd.Read())

            Dim vak As New vak(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5))
            vaken.Add(vak)

        End While
        For Each vak In vaken
            listVakken.Items.Add(vak.vaknaam)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'als je een leerling selecteerd zie je al zijn toetsen in de datagridview
        Dim idleerling = ComboBox1.SelectedIndex + 1
        f.selectToDataGridView("SELECT * FROM vak where idleerling= " & idleerling, DataGridView1)
    End Sub

    Private Sub btnAanpasbaar_Click(sender As Object, e As EventArgs) Handles btnAanpasbaar.Click
        'zorgt ervoor dat je de datagridview niet kan aanpassen tot je op de knop "aanpasbaar" klikt
        If DataGridView1.AllowUserToAddRows = False Then
            DataGridView1.AllowUserToAddRows = True
            DataGridView1.AllowUserToDeleteRows = True
            DataGridView1.AllowUserToOrderColumns = True
            DataGridView1.AllowUserToResizeRows = True

        Else
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.AllowUserToDeleteRows = False
            DataGridView1.AllowUserToOrderColumns = False
            DataGridView1.AllowUserToResizeRows = False
        End If

    End Sub
End Class
