Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class f

#Region "MySQL functions"
    Public Shared Function connStr()
        Dim database = "syntax_ex"
        Dim port = "3307"
        Return "server=localhost;user=root;database=" + database + ";port=" + port + ";password=usbw;"
    End Function
    Public Shared Function openConn()
        Dim x
        Try
            Dim conn As New MySqlConnection(connStr())
            conn.Open()
            x = conn
        Catch ex As Exception
            x = ex.Message
        End Try
        Return x
    End Function

    Public Shared Function execute(Query)
        Dim X

        Dim conn As New MySqlConnection(connStr())
        Try
            conn.Open()
            Dim myCommand As New MySqlCommand(Query, conn)

            Dim cmd As MySqlCommand = New MySqlCommand(Query, conn)
            X = cmd.ExecuteNonQuery()
        Catch ex As Exception
            X = ex.Message
        End Try




        Return X
    End Function

    Public Shared Function selectToDataGridView(Query As String, DataGridView1 As Object)
        Dim x
        Try
            Dim conn
            conn = New MySqlConnection(connStr())
            conn.Open()

            Dim myCommand As New MySqlCommand(Query, conn)

            Dim rd As MySqlDataReader
            rd = myCommand.ExecuteReader()

            Dim dt = New DataTable()
            dt.Load(rd)
            DataGridView1.DataSource = dt
            DataGridView1.Refresh()

            Dim ds As New DataSet("d")
            ds.Tables.Add(dt)
            x = 1
        Catch ex As Exception
            x = ex.Message
        End Try

        Return x
    End Function

    Public Shared Function dataViewAddCollom(name, coll1, coll2, coll3)
        Dim x
        Try

            name.Rows.Add(coll1, coll2, coll3)
            x = 1
        Catch ex As Exception
            x = ex.Message
        End Try
        Return x
    End Function
#End Region



End Class
