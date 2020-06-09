Public Class product
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _productNaam As String
    Public Property productNaam() As String
        Get
            Return _productNaam
        End Get
        Set(ByVal value As String)
            _productNaam = value
        End Set
    End Property

    Private _hoeveelheid As Integer
    Public Property hoeveelheid() As Integer
        Get
            Return _hoeveelheid
        End Get
        Set(ByVal value As Integer)
            _hoeveelheid = value
        End Set
    End Property
    Private _eenheid As String
    Public Property eenheid() As String
        Get
            Return _eenheid
        End Get
        Set(ByVal value As String)
            _eenheid = value
        End Set
    End Property



    Private _winkel As String
    Public Property winkel() As String
        Get
            Return _winkel
        End Get
        Set(ByVal value As String)
            _winkel = value
        End Set
    End Property

    Public Sub New(id As Integer, productNaam As String, hoeveelheid As Integer, eenheid As String, winkel As String)
        _id = id
        _productNaam = productNaam
        _hoeveelheid = hoeveelheid
        _eenheid = eenheid
        _winkel = winkel
    End Sub
End Class
