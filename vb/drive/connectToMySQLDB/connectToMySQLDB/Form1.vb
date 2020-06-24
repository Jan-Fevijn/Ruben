'Imports System.Data
'Imports MySql.Data

Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connStr As String = "server=localhost;user=root;database=6itntest;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        Try
            lstInfo.Items.Add("loading")

            conn.Open()
        Catch ex As Exception
            lstInfo.Items.Add("error: " & ex.ToString())


        End Try
        conn.Close()
        lstInfo.Items.Add("done")
    End Sub
End Class
