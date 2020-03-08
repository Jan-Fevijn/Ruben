Imports System.Data
Imports System.IO
Imports MySql.Data.MySqlClient
Imports microsorft.Office.interop.Word
Imports microsorft.Office.interop
Imports Microsoft.Office.Interop
Imports System.Drawing.Printing


Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class frmInKomstUitgave
    Private WithEvents p_Document As PrintDocument = Nothing
    Public logedIN = False
    Public usserID
    Public userid

    Public buget As Integer
    Public inUitkomst As Boolean
    Public ok As Boolean
    Private inkomstUitgaven As New List(Of inkomstUItgeve)
    Dim connectionString As String = "server=localhost;user=root;database=inuitgaven;port=3307;password=usbw;"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()




    Private Sub frmInKomstUitgave_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        loginmode()



    End Sub



    Private Sub updateList()
        buget = 0
        inkomstUitgaven.Clear()
        list.Clear()
        Dim connStr As String = "server=localhost;user=root;database=inuitgaven;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        Try
            MsgBox("loading")

            conn.Open()

            Dim mySelectQuery As String = "select * from inkomsten WHERE iduser = '" & userid & "'"
            Dim myCommand As New MySqlCommand(mySelectQuery, conn)

            Dim rd As MySqlDataReader
            rd = myCommand.ExecuteReader()
            getListRedy()
            While (rd.Read())
                Dim inuit As New inkomstUItgeve(rd(0), rd(1), rd(2), rd(3))
                inkomstUitgaven.Add(inuit)


            End While
            For Each item In inkomstUitgaven
                addRecordToList(item.code, item.omschrijving, item.bedrag, item.io)
            Next
            lblBuget.Text = "u buget bedraagd momenteel : " & buget & "euro."
        Catch ex As Exception
            MsgBox("error: there went somiting wrong.")


        End Try
        conn.Close()


    End Sub

    Private Sub getListRedy()
        list.ShowItemToolTips = True
        list.View = View.Details
        list.Columns.Clear()

        list.Columns.Add("code", 120)
        list.Columns.Add("omscrijving", 120)
        list.Columns.Add("bedrag", 120)
        list.Columns.Add("inkomst / uitgave", 120)



    End Sub
    Private Sub addRecordToList(code, omscrijving, bedrag, io)
        Dim TempStr(3) As String
        Dim TempNode As ListViewItem
        TempStr(0) = code
        TempStr(1) = omscrijving
        TempStr(2) = bedrag
        If (io) Then
            TempStr(3) = "inkomst"
            buget = buget + bedrag
        Else
            TempStr(3) = "uitgave"
            buget = buget - bedrag
        End If

        TempNode = New ListViewItem(TempStr)
        list.Items.Add(TempNode)
    End Sub

    Private Sub radInkomst_CheckedChanged(sender As Object, e As EventArgs) Handles radInkomst.CheckedChanged
        radUitgave.Checked = False

    End Sub

    Private Sub radUitgave_CheckedChanged(sender As Object, e As EventArgs) Handles radUitgave.CheckedChanged

        radInkomst.Checked = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If radInkomst.Checked = True Then
            inUitkomst = True
            ok = True
        ElseIf radUitgave.Checked = True Then
            inUitkomst = False
            ok = True
        Else
            ok = False
            MsgBox("gelieve aan te duiden of het een inkomst of een uitgave is.")
        End If

        If (ok) Then
            Using SQLConnection As New MySqlConnection(connectionString)
                Using sqlCommand As New MySqlCommand()
                    With sqlCommand
                        .CommandText = "INSERT INTO inkomsten (`code`, `omschrijving`, `bedrag`, `io` , `iduser`) values (@xid,@m_id,@imodel,@icolor , ' " & userid & "')"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@xid", numCode.Value)
                        .Parameters.AddWithValue("@m_id", txtBeschrijving.Text)
                        .Parameters.AddWithValue("@imodel", numBedrag.Value)
                        .Parameters.AddWithValue("@icolor", inUitkomst)


                    End With
                    Try
                        SQLConnection.Open()
                        sqlCommand.ExecuteNonQuery()

                    Catch ex As MySqlException
                        MsgBox("it failed")
                    Finally
                        SQLConnection.Close()
                    End Try
                End Using
            End Using
            updateList()
            numCode.Value = 0
            txtBeschrijving.Text = ""
            numBedrag.Value = 0
            inUitkomst = 0
            radInkomst.Checked = False
            radUitgave.Checked = False


        End If
    End Sub

    Private Sub TxtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TxtToolStripMenuItem.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"



        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim filepath = SaveFileDialog1.FileName
            '   MsgBox(filepath)



            If Not System.IO.File.Exists(filepath) Then
                System.IO.File.Create(filepath).Dispose()
            End If

            Dim FILE_NAME As String = filepath
            '  MsgBox(FILE_NAME)
            If System.IO.File.Exists(FILE_NAME) = False Then
                System.IO.File.Create(FILE_NAME).Dispose()
            End If
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)

            '' start puch data to new dock 
            Dim Line As String
            Line = "code:;omschrijving:;bedrag:;inkomst/uitgave:;  "
            ' MsgBox(Line)
            objWriter.WriteLine(Line)
            Dim i
            MsgBox(list.Items.Count)
            For Each item In inkomstUitgaven
                If (item.io) Then
                    Line = item.code & ";" & item.omschrijving & ";" & item.bedrag & ";" & "inkkomsten"
                Else
                    Line = item.code & ";" & item.omschrijving & item.bedrag & ";" & "uitgaven"
                End If
                objWriter.WriteLine(Line)
            Next

            objWriter.Close()
            FileClose(1)
        End If
    End Sub

    Private Sub WordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordToolStripMenuItem.Click
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table
        Dim oTable2 As Word.Table
        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
        Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph

        Dim oRng As Word.Range
        Dim oShape As Word.InlineShape
        Dim oChart As Object
        Dim Pos As Double

        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add


        'Insert a paragraph at the end of the document.
        '** \endofdoc is a predefined bookmark.
        oPara1 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara1.Range.Text = "made by Ruben Aspeslag : "
        oPara1.Format.SpaceAfter = 6
        oPara1.Range.InsertParagraphAfter()



        'Insert a paragraph at the end of the document.
        '** \endofdoc is a predefined bookmark.
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Range.Text = "inkomsten en uitgaven : "
        oPara2.Format.SpaceAfter = 6
        oPara2.Range.InsertParagraphAfter()

        'Insert another paragraph.
        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Range.Text = ""
        oPara3.Range.Font.Bold = False
        oPara3.Format.SpaceAfter = 24
        oPara3.Range.InsertParagraphAfter()

        'Insert another paragraph.
        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Range.Text = "inkomsten:"
        oPara3.Range.Font.Bold = False
        oPara3.Format.SpaceAfter = 10
        oPara3.Range.InsertParagraphAfter()



        'Insert a 3 x 5 table, fill it with data, and make the first row
        'bold and italic.
        Dim x As Integer = 1
        For Each item In inkomstUitgaven
            If item.io = True Then
                x = x + 1
            End If
        Next

        oTable2 = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, x, 3)
        oTable2.Range.ParagraphFormat.SpaceAfter = 6
        Dim i

        i = i + 1

        oTable2.Cell(i, 1).Range.Text = "code"
        oTable2.Cell(i, 2).Range.Text = "bedrag"
        oTable2.Cell(i, 3).Range.Text = "omschrijving"

        For Each item In inkomstUitgaven
            If item.io = True Then
                i = i + 1

                oTable2.Cell(i, 1).Range.Text = item.code
                oTable2.Cell(i, 2).Range.Text = item.bedrag
                oTable2.Cell(i, 3).Range.Text = item.omschrijving
            End If
        Next
        oTable2.Rows.Item(1).Range.Font.Bold = True
        oTable2.Rows.Item(1).Range.Font.Italic = True



        'Insert another paragraph.
        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Range.Text = ""
        oPara3.Range.Font.Bold = False
        oPara3.Format.SpaceAfter = 24
        oPara3.Range.InsertParagraphAfter()


        'Insert another paragraph.
        oPara4 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara4.Range.Text = "uitgaven:"
        oPara4.Range.Font.Bold = False
        oPara4.Format.SpaceAfter = 10
        oPara4.Range.InsertParagraphAfter()

        'Insert a 3 x 5 table, fill it with data, and make the first row
        'bold and italic.
        x = 1
        For Each item In inkomstUitgaven

            If item.io = False Then
                x = x + 1
            End If
        Next
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, x, 3)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        i = 0


        i = i + 1

        oTable.Cell(i, 1).Range.Text = "code"
        oTable.Cell(i, 2).Range.Text = "bedrag"
        oTable.Cell(i, 3).Range.Text = "omschrijving"
        For Each item In inkomstUitgaven

            If item.io = False Then
                i = i + 1

                oTable.Cell(i, 1).Range.Text = item.code
                oTable.Cell(i, 2).Range.Text = item.bedrag
                oTable.Cell(i, 3).Range.Text = item.omschrijving
            End If
        Next
        oTable.Rows.Item(1).Range.Font.Bold = True
        oTable.Rows.Item(1).Range.Font.Italic = True


    End Sub

    Private Sub ViatxtFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViatxtFileToolStripMenuItem.Click
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            buget = 0
            inkomstUitgaven.Clear()
            list.Clear()

            FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
            Dim y As Integer
            Do While Not EOF(1)
                y = y + 1
                Dim lijn = LineInput(1)
                Dim x = lijn.Split(New Char() {";"})
                'leerkracht aanmaken 
                y = y + 1


                Dim inuit = New inkomstUItgeve(x(0), x(1), x(2), x(3))
                inkomstUitgaven.Add(inuit)

            Loop

            'insert to the db '

            For Each item In inkomstUitgaven
                'SQLConnection = New MySqlConnection()
                'SQLConnection.ConnectionString = connectionString
                'Dim sqlCommand As New MySqlCommand
                'Dim str_carSql As String

                'Try
                '    str_carSql = "INSERT INTO inkomsten (`code`, `omschrijving`, `bedrag`, `io`) VALUES (" & item.code & ", '" & item.omschrijving & "','" & item.bedrag & "'," & item.io & ")"
                '    MsgBox(str_carSql)
                '    txtBeschrijving.Text = str_carSql
                '    sqlCommand.Connection = SQLConnection
                '    sqlCommand.CommandText = str_carSql
                '    sqlCommand.ExecuteNonQuery()



                'Catch ex As Exception
                '    MsgBox(ex.Message)
                '    MsgBox("Error occured: Could not insert record")
                'End Try



                Using SQLConnection As New MySqlConnection(connectionString)
                    Using sqlCommand As New MySqlCommand()
                        With sqlCommand
                            .CommandText = "INSERT INTO inkomsten (`code`, `omschrijving`, `bedrag`, `io`,`iduser` ) values (@xid,@m_id,@imodel,@icolor,' " & userid & "')"
                            .Connection = SQLConnection
                            .CommandType = CommandType.Text
                            .Parameters.AddWithValue("@xid", item.code)
                            .Parameters.AddWithValue("@m_id", item.omschrijving)
                            .Parameters.AddWithValue("@imodel", item.bedrag)
                            .Parameters.AddWithValue("@icolor", item.io)


                        End With
                        Try
                            SQLConnection.Open()
                            sqlCommand.ExecuteNonQuery()

                        Catch ex As MySqlException
                            MsgBox("er is een fout opgeloopen, kijk of de code niet in gebruik is (dit programma maakt geen onderschijt in code's van inkomsten en code's van uitgaaven ")
                            ' MsgBox(ex.Message)
                        Finally
                            SQLConnection.Close()
                        End Try
                    End Using
                End Using


            Next
            updateList()

        End If
    End Sub


    ' ------------ login system : 

    '   login modes
    Private Sub loginmode()
        MenuStrip1.Visible = False
        lblAdd.Visible = False
        lblBuget.Visible = False
        lblCode.Visible = False
        lblInkomstUitgave.Visible = False
        lblLijst.Visible = False
        lblBedrag.Visible = False
        lblBeschrijving.Visible = False
        btnAdd.Visible = False
        radInkomst.Visible = False
        radUitgave.Visible = False
        numBedrag.Visible = False
        numCode.Visible = False
        txtBeschrijving.Visible = False
        list.Visible = False


        lblUsername.Visible = True
        lblPassword.Visible = True
        txtPassword.Visible = True
        txtUsername.Visible = True
        btnLogin.Visible = True

    End Sub

    Private Sub BtnText_Click(sender As Object, e As EventArgs) Handles btnLogin.Click



        Dim connStr As String = "server=localhost;user=root;database=inuitgaven;port=3307;password=usbw;"
        Dim conn As New MySqlConnection(connStr)
        Try
            MsgBox("loading")

            conn.Open()

            Dim mySelectQuery As String = "select * from user"
            Dim myCommand As New MySqlCommand(mySelectQuery, conn)

            Dim rd As MySqlDataReader
            rd = myCommand.ExecuteReader()
            getListRedy()
            While (rd.Read())
                'rd(0), rd(1) 
                If (rd(1) = txtUsername.Text And rd(2) = txtPassword.Text And rd(3) = 1) Then
                    userid = rd(0)

                    adminMode()

                End If
                If (rd(1) = txtUsername.Text And rd(2) = txtPassword.Text And rd(3) = False) Then
                    userid = rd(0)
                    updateList()
                    logedInmode()

                End If


            End While

        Catch
            MsgBox("try again ")
        End Try
    End Sub

    Private Sub adminMode()
        ' MsgBox("admin")
        ' admin 
        frmadminVieuw.Show()

    End Sub

    Private Sub logedInmode()
        MenuStrip1.Visible = True
        lblAdd.Visible = True
        lblBuget.Visible = True
        lblCode.Visible = True
        lblInkomstUitgave.Visible = True
        lblLijst.Visible = True
        lblBedrag.Visible = True
        lblBeschrijving.Visible = True
        btnAdd.Visible = True
        radInkomst.Visible = True
        radUitgave.Visible = True
        numBedrag.Visible = True
        numCode.Visible = True
        txtBeschrijving.Visible = True
        list.Visible = True

        lblUsername.Visible = False
        lblPassword.Visible = False
        txtPassword.Visible = False
        txtUsername.Visible = False
        btnLogin.Visible = False
    End Sub

    Private Sub UitloggenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UitloggenToolStripMenuItem.Click
        loginmode()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
End Class
