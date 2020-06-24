Public Class leerling
    'idleerling, naam, voornaam, klas, geboortedatum'
    Private _idleerling As Decimal
    Private _naam As String
    Private _voornaam As String
    Private klas As String
    Private _geboortedatum As Date
    Public Property idleerling() As Decimal
        Get
            Return _idleerling
        End Get
        Set(ByVal value As Decimal)
            _idleerling = value
        End Set
    End Property



    Public Property naam() As String
        Get
            Return _naam
        End Get
        Set(ByVal value As String)
            _naam = value
        End Set
    End Property


    Public Property voornaam() As String
        Get
            Return _voornaam
        End Get
        Set(ByVal value As String)
            _voornaam = value
        End Set
    End Property


    Public Property _klas() As String
        Get
            Return klas
        End Get
        Set(ByVal value As String)
            klas = value
        End Set
    End Property



    Public Property geboortedatum() As Date
        Get
            Return _geboortedatum
        End Get
        Set(ByVal value As Date)
            _geboortedatum = value
        End Set
    End Property

    Public Sub New(idleerling As Decimal, naam As String, voornaam As String, klas As String, geboortedatum As Date)
        Me.idleerling = idleerling
        Me.naam = naam
        Me.voornaam = voornaam
        _klas = klas
        Me.geboortedatum = geboortedatum
    End Sub


End Class
