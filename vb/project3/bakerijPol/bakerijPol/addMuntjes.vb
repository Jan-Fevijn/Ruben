
Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class addMuntjes
    Private Sub addMuntjes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        muntjes.Items.Add(0.01)
        muntjes.Items.Add(0.02)
        muntjes.Items.Add(0.05)
        muntjes.Items.Add(0.1)
        muntjes.Items.Add(0.2)
        muntjes.Items.Add(0.5)
        muntjes.Items.Add(1)
        muntjes.Items.Add(2)
        muntjes.Items.Add(5)
        muntjes.Items.Add(10)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim i = 0
        For i = 0 To numAmount.Value

            Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
            Dim con As New MySqlConnection(connStr)

            con.Open()
            Dim Query = " INSERT INTO `bakerijpol`.`muntjes` (`value`, `transactie`) VALUES ('" & muntjes.SelectedItem & "', '" & muntjes.SelectedItem & "');"
            '  MsgBox(Query)
            ' MsgBox(muntjes.SelectedItem)
            Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
            Dim y As Integer = cmd.ExecuteNonQuery()
            If (y > 0) Then
                'deletid sucsesfuly 
            Else
                'failed
                MsgBox("it failed")
            End If



        Next
        Me.Hide()
    End Sub
End Class