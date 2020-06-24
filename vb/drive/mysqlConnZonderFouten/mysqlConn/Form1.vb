Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.IO

Public Class Form1

    Public conn As MySqlConnection
    Public connstring As String = "server=localhost;Port=3307;database=spel;uid=root;password=usbw; "

    Public lijstproducten As List(Of Product)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New MySqlConnection(connstring)

        conn.Open()

        Dim mySelectQuery As String = "select * from spel"

        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()


        Dim dt = New DataTable()
        dt.Load(rd)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        Dim ds As New DataSet("d")
        ds.Tables.Add(dt)

        'File.WriteAllText("test.txt", ds.GetXml)
        'MessageBox.Show(ds.GetXml())

        test(1)
        'test2()
        'test3()
    End Sub



    Public Sub test(ByVal nr As Integer)

        Dim sqlQuery As String = "SELECT * FROM spel "

        Using sqlConn As New MySqlConnection(connstring)
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = sqlConn
                    .CommandText = sqlQuery
                    .CommandType = CommandType.Text

                End With
                Try
                    sqlConn.Open()
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        Label1.Text = sqlReader("idspel").ToString()
                        Label2.Text = sqlReader("idUitgever").ToString()
                    End While
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message & " " & ex.Number)
                    ' add your exception here '
                End Try
            End Using
        End Using
    End Sub


    Public Sub test2()
        Dim connString As String = "server=localhost;Port=3307;database=oefening;uid=root;password=;"
        Dim sqlQuery As String = "SELECT * FROM d"

        Using sqlConn As New MySqlConnection(connString)
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = sqlConn
                    .CommandText = sqlQuery
                    .CommandType = CommandType.Text

                End With
                Try
                    sqlConn.Open()
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        ListBox1.Items.Add(sqlReader("a").ToString() & " " & sqlReader("naam").ToString())
                    End While
                Catch ex As MySqlException
                    ' add your exception here '
                End Try
            End Using
        End Using
    End Sub

    Public Sub test3()
        Dim connString As String = "server=localhost;Port=3306;database=oefening;uid=root;password=;"
        Dim sqlQuery As String = "SELECT idgerecht,naam FROM gerecht"

        lijstproducten = New List(Of Product)

        Using sqlConn As New MySqlConnection(connString)
            Using sqlComm As New MySqlCommand()
                With sqlComm
                    .Connection = sqlConn
                    .CommandText = sqlQuery
                    .CommandType = CommandType.Text

                End With
                Try
                    sqlConn.Open()
                    Dim sqlReader As MySqlDataReader = sqlComm.ExecuteReader()
                    While sqlReader.Read()
                        lijstproducten.Add(New Product(sqlReader("idgerecht"), sqlReader("naam").ToString()))
                        'ComboBox1.Items.Add(sqlReader("naam").ToString())

                    End While
                Catch ex As MySqlException
                    ' add your exception here '
                End Try

                ComboBox1.DisplayMember = "Naam"
                ComboBox1.ValueMember = "idgerecht"

                ComboBox1.DataSource = lijstproducten
            End Using
        End Using
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ger As New Product()
        ger = ComboBox1.SelectedItem

        MessageBox.Show(ger.idProduct)
        test(ger.idProduct)

        MessageBox.Show(ListBox1.SelectedItem.ToString)
    End Sub
End Class

