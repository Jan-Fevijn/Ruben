Public Class Form1
    'maak de lijsten
    Public orders As New List(Of order)
    Public klanten As New List(Of klant)
    Public producten As New List(Of product)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'maak gebruikers aan 
        Dim klant1 As New klant(1, "Ruben", "Ruben2001", 1)
        klanten.Add(klant1)
        Dim klant2 As New klant(2, "Dieter", "Dieter2003", 0)
        klanten.Add(klant2)
        'maak producten aan
        Dim product1 As New product(1, "bal", 5)
        producten.Add(product1)

        Dim product2 As New product(2, "kaas", 6)
        producten.Add(product2)

        Dim product3 As New product(3, "snoep", 6)
        producten.Add(product3)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'login 
        For Each klant In klanten
            If txtGebruikersnaam.Text = klant.naam And txtWachtwoord.Text = klant.wachtwoord Then
                If klant.rechten = 1 Then
                    ADMIN.Show()
                    Me.Hide()
                End If
                If klant.rechten = 0 Then
                    gebruiker.Show()
                    Me.Hide()
                End If
            End If
        Next
    End Sub
End Class
