Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO



Public Class Login


    Private Sub btnRegistreer_Click(sender As Object, e As EventArgs) Handles btnRegistreer.Click
        registreer.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        '  Try


        conn.Open()

        Dim mySelectQuery As String = "select * from user WHERE username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'"
        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()
        Dim user As New user
        While (rd.Read())

            MsgBox(rd(0) & rd(1) & rd(2) & rd(3) & rd(4) & rd(5) & rd(6) & rd(7))
            userHome.Show()
            Me.Hide()



        End While

        '   Catch ex As Exception
        '    MsgBox("error: there went somiting wrong.")


        '    End Try
        conn.Close()

    End Sub
End Class
