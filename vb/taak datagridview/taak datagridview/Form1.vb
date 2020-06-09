Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Form1
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ' DataGridView1.DataSource = inhout.getAll()



        Dim connectionString As String = "server=localhost;user=root;database=diepvries;port=3307;password=usbw;"

        Dim database As New DataTable
        Dim Sql As String = "SELECT * FROM productinhoud"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(Sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Student")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Student"


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub
End Class
