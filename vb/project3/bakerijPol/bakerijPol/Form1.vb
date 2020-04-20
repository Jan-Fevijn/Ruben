Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Dim broodsoorten As New List(Of broodsoort)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connStr As String = "server=localhost;user=root;database=bakerijPol;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        '  Try
        conn.Open()

        Dim mySelectQuery As String = "select * from soortbrood "
        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()
        While (rd.Read())

            '  MsgBox(rd(0) & rd(1) & rd(2) & rd(3) & rd(4))
            Dim broodsoord As New broodsoort(rd(0), rd(1), rd(3))


            '   MsgBox(evenement.idevent & " " & evenement.van & " " & evenement.datumEnd & " " & evenement.img & " " & evenement.naam)
            broodsoorten.Add(broodsoord)
        End While


        For Each broodsoort In broodsoorten
            listBrooden.Items.Add(broodsoort.naam)
        Next
    End Sub


    Private Sub listBrooden_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBrooden.SelectedIndexChanged
        If txtLocatie.Text <> "" Then
            txtLocatie.Text = ""
            For Each broodsoort In broodsoorten
                If broodsoort.id = listBrooden.SelectedIndex + 1 Then
                    MsgBox(broodsoort.naam & "  " & broodsoort.hoeveelheid & "stuks")
                End If

            Next

        Else
            MsgBox("gelieve eerst hut nummer in te typen dat je wil rezerveren voor dat brood.")
        End If
    End Sub

    '       -------machineknopen 
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtLocatie.Text = txtLocatie.Text & 1
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtLocatie.Text = txtLocatie.Text & 2
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtLocatie.Text = txtLocatie.Text & 3
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtLocatie.Text = txtLocatie.Text & 4
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtLocatie.Text = txtLocatie.Text & 5
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtLocatie.Text = txtLocatie.Text & 6
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtLocatie.Text = txtLocatie.Text & 7
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtLocatie.Text = txtLocatie.Text & 8
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtLocatie.Text = txtLocatie.Text & 9
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtLocatie.Text = txtLocatie.Text & 0
    End Sub


End Class
