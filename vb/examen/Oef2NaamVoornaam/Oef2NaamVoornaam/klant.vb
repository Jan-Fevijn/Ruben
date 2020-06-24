Public Class klant
    Private _idklant As Int16
    Public Property idklant() As Int16
        Get
            Return _idklant
        End Get
        Set(ByVal value As Int16)
            _idklant = value
        End Set
    End Property

    Private _naam As String
    Public Property naam() As String
        Get
            Return _naam
        End Get
        Set(ByVal value As String)
            _naam = value
        End Set
    End Property

    Private _wachtwoord As String
    Public Property wachtwoord() As String
        Get
            Return _wachtwoord
        End Get
        Set(ByVal value As String)
            _wachtwoord = value
        End Set
    End Property
    Private _rechten As Int16
    Public Property rechten() As Int16
        Get
            Return _rechten
        End Get
        Set(ByVal value As Int16)
            _rechten = value
        End Set
    End Property

    Public Sub New(idklant As Short, naam As String, wachtwoord As String, rechten As Short)
        _idklant = idklant
        _naam = naam
        _wachtwoord = wachtwoord
        _rechten = rechten
    End Sub
End Class
