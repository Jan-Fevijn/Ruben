Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class bakerijPol
    Dim broodsoorten As New List(Of broodsoort)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loudbroodsoorten()
        loudLocaties()
        loudKlanten()
    End Sub

    Private Sub loudKlanten()
        klanten.ShowItemToolTips = True
        klanten.View = View.Details

        klanten.Clear()


        klanten.Columns.Add("code", 120)
        klanten.Columns.Add("saldo", 120)

        Dim connStr As String = "server=localhost;user=root;database=bakerijpol;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        '  Try


        conn.Open()

        Dim mySelectQuery As String = "SELECT * FROM bakerijpol.user "
        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()

        While (rd.Read())

            Dim TempStr(3) As String
            Dim TempNode As ListViewItem
            TempStr(0) = rd(1)
            TempStr(1) = rd(2)
            TempNode = New ListViewItem(TempStr)
            klanten.Items.Add(TempNode)
        End While


    End Sub

    Private Sub loudbroodsoorten()
        broodsoorten.Clear()
        listBrooden.Items.Clear()

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

    End Sub

    Private Sub loudLocaties()
        locaties.ShowItemToolTips = True
        locaties.View = View.Details

        locaties.Clear()


        locaties.Columns.Add("locatie", 120)
        locaties.Columns.Add("brood", 120)
        locaties.Columns.Add("aantal", 120)
        Dim connStr As String = "server=localhost;user=root;database=bakerijpol;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        '  Try


        conn.Open()

        Dim mySelectQuery As String = "SELECT locatie,  soortbrood.naam ,broodLocatie.hoeveelheid FROM bakerijpol.broodlocatie inner join soortbrood on broodlocatie.IDsoordBrood = soortbrood.idsoortBrood where broodLocatie.hoeveelheid > 0   order by locatie"
        Dim myCommand As New MySqlCommand(mySelectQuery, conn)

        Dim rd As MySqlDataReader
        rd = myCommand.ExecuteReader()

        While (rd.Read())

            Dim TempStr(3) As String
            Dim TempNode As ListViewItem
            TempStr(0) = rd(0)
            TempStr(1) = rd(1)
            TempStr(2) = rd(2)
            TempNode = New ListViewItem(TempStr)
            locaties.Items.Add(TempNode)
        End While



    End Sub

    Private Sub btnCLearLocaties_Click(sender As Object, e As EventArgs) Handles btnCLearLocaties.Click
        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim con As New MySqlConnection(connStr)

        con.Open()
        Dim Query = "DELETE FROM `bakerijpol`.`broodlocatie` WHERE (`idBroodLocatier` < '100000000000') "
        MsgBox(Query)
        Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
        Dim y As Integer = cmd.ExecuteNonQuery()
        If (y > 0) Then
            'deletid sucsesfuly 
        End If
        loudLocaties()
    End Sub
    Private Sub btnSaldoWijzigen_Click(sender As Object, e As EventArgs) Handles btnSaldoWijzigen.Click
        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim con As New MySqlConnection(connStr)

        con.Open()
        Dim Query = "UPDATE `bakerijpol`.`user` SET `saldo` = '" & numBudget.Value & "' WHERE (`code` = '" & numUsercode.Value & "')"
        MsgBox(Query)
        Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
        Dim y As Integer = cmd.ExecuteNonQuery()
        If (y > 0) Then
            'deletid sucsesfuly 
        End If
        loudKlanten()
    End Sub
    Private Sub btnGebruikerToevoegen_Click(sender As Object, e As EventArgs) Handles btnGebruikerToevoegen.Click
        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim con As New MySqlConnection(connStr)

        con.Open()
        Dim Query = "INSERT INTO `bakerijpol`.`user` ( `code`, `saldo`) VALUES ( '" & numUsercode.Value & "', '" & numBudget.Value & "')"
        MsgBox(Query)
        Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
        Dim y As Integer = cmd.ExecuteNonQuery()
        If (y > 0) Then
            'deletid sucsesfuly 
        End If
        loudKlanten()
    End Sub
    Private Sub btnAddBrood_Click(sender As Object, e As EventArgs) Handles btnAddBrood.Click
        ' INSERT INTO `bakerijpol`.`soortbrood` (`idsoortBrood`, `naam`, `hoeveelheid`) VALUES ('4', 'ss', '5');

        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
        Dim con As New MySqlConnection(connStr)

        con.Open()
        Dim Query = "INSERT INTO `bakerijpol`.`soortbrood` ( `naam`, `hoeveelheid` , `img`) VALUES ('" & txtNaamBrood.Text & "', '5', '')"
        MsgBox(Query)
        Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
        Dim y As Integer = cmd.ExecuteNonQuery()
        If (y > 0) Then
            'deletid sucsesfuly 
        End If
        loudbroodsoorten()
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

    Private Sub btnBroodInAutomaatSteeken_Click(sender As Object, e As EventArgs) Handles btnBroodInAutomaatSteeken.Click
        If txtLocatie.Text <> "" Then
            If numHoeveelheid.Value <> 0 Then
                For Each broodsoort In broodsoorten
                    If broodsoort.id = listBrooden.SelectedIndex + 1 Then
                        MsgBox(broodsoort.naam & "  " & broodsoort.hoeveelheid & "stuks")
                        Dim connStr As String = "server=localhost;user=root;database=kokenvoorgroepen;port=3307;password=usbw;"
                        Dim con As New MySqlConnection(connStr)

                        con.Open()
                        Dim Query = "INSERT INTO `bakerijpol`.`broodlocatie` ( `IDsoordBrood`, `locatie`, `hoeveelheid`) VALUES ( '" & broodsoort.id & "', '" & txtLocatie.Text & "'  , '" & numHoeveelheid.Value & "')"
                        MsgBox(Query)
                        Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
                        Dim y As Integer = cmd.ExecuteNonQuery()
                        If (y > 0) Then
                            'deletid sucsesfuly 
                        Else
                            'failed
                            MsgBox("it failed")
                        End If


                    End If

                Next
                txtLocatie.Text = ""
                loudLocaties()
            Else
                MsgBox("gelieve eerst in te geeven hoeveel brooden van hetzelvde type je er wil in steeken.")
            End If
        Else
            MsgBox("gelieve eerst hut nummer in te typen dat je wil rezerveren voor dat brood.")
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPrijs.Click

    End Sub

    Private Sub btnOpnieuwLadenUsers_Click(sender As Object, e As EventArgs) Handles btnOpnieuwLadenUsers.Click
        loudKlanten()
    End Sub

    Private Sub btnOpnieuwLaadenLocatie_Click(sender As Object, e As EventArgs) Handles btnOpnieuwLaadenLocatie.Click
        loudLocaties()
    End Sub
End Class
