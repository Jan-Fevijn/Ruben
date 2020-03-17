Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Public Class userHome
    Private Sub userHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username
        If registreer.txtUsername.Text <> "" Then
            username = registreer.txtUsername.Text
        Else
            username = Login.txtUsername.Text
        End If


        inloggen(username)

    End Sub
    Private Sub inloggen(username)
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

            MsgBox(rd(0) & rd(1) & rd(2) & rd(3) & rd(4) & rd(5) & rd(6) & rd(7))
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

        '   Catch ex As Exception
        '    MsgBox("error: there went somiting wrong.")


        '    End Try
        conn.Close()

    End Sub
End Class