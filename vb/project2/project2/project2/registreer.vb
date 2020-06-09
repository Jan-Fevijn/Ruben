Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Public Class registreer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistreer_Click(sender As Object, e As EventArgs) Handles btnRegistreer.Click
        If txtNaam.Text <> "" Then
            If txtUsername.Text <> "" Then
                If txtVoornaam.Text <> "" Then
                    If txtWachtwoord1.Text <> "" Then
                        If txtWachtwoord2.Text <> "" Then
                            If txtWachtwoord1.Text = txtWachtwoord2.Text Then

                                Dim ok = False
                                Dim vegan = False
                                Dim vegitarisch = False
                                If Radvegitarisch.Checked = True Then
                                    vegan = True
                                    vegitarisch = False
                                    ok = True
                                ElseIf RadVeganistisch.Checked = True Then
                                    vegan = False
                                    vegitarisch = True
                                    ok = True
                                ElseIf radGeen.Checked = True Then
                                    vegan = False
                                    vegitarisch = False
                                    ok = True
                                Else

                                End If

                                If ok = True Then
                                    registreeren(vegan, vegitarisch)
                                Else
                                    MsgBox("gelieve ons eerst te laaten weten of je vegitarisch / veganistisch bent of niet. ")
                                End If
                            Else
                                MsgBox("de 2 wachtwoorden koomen niet overeen.")
                            End If
                        Else
                            MsgBox("gelieve je wachtwoord te herhaalen ")
                        End If
                    Else
                        MsgBox("gelieve een wachtwoord in te geven")
                    End If
                Else
                    MsgBox("gelieve een voornaam in te geven")
                End If
            Else
                MsgBox("gelieve een gebruikersnaam in te geven")
            End If
        Else
            MsgBox("gelieve u naam in te geven")
        End If

    End Sub

    Private Sub registreeren(vegan, veganistisch)

        Dim sqlCommand As New MySqlCommand
        Dim str_carSql As String
        Dim connectionString As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim SQLConnection As MySqlConnection = New MySqlConnection
        Dim oDt_sched As New DataTable()
        SQLConnection = New MySqlConnection()
        SQLConnection.ConnectionString = connectionString
        SQLConnection.Open()
        Try

            str_carSql = "insert into user (voornaam, naam, password,vegan,veganistisch,admin, username  ) values (@naam,@voornaam,@w1 ,@vegan,@vaganistisch,@admin,@username)"
            sqlCommand.Connection = SQLConnection
            sqlCommand.CommandText = str_carSql
            sqlCommand.Parameters.AddWithValue("@naam", txtNaam.Text)
            sqlCommand.Parameters.AddWithValue("@username", txtUsername.Text)
            sqlCommand.Parameters.AddWithValue("@voornaam", txtVoornaam.Text)
            sqlCommand.Parameters.AddWithValue("@w1", txtWachtwoord1.Text)
            sqlCommand.Parameters.AddWithValue("@Admin", False)
            sqlCommand.Parameters.AddWithValue("@vegan", vegan)
            sqlCommand.Parameters.AddWithValue("@vaganistisch", veganistisch)



            sqlCommand.ExecuteNonQuery()

            userHome.Show()
            Me.Hide()

        Catch ex As Exception
            If ex.Message.Contains("username") Then
                MsgBox("username reeds in gebruik, gelieve eens een andere te probeeren")
            Else
                MsgBox("there went somthing wrong, please try again. registreer.vb")
            End If

        End Try
    End Sub
End Class