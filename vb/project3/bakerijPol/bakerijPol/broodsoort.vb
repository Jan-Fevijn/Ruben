Public Class broodsoort
    Private _id As Integer
    Private _naam As String
    Private _hoeveelheid As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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


    Public Property hoeveelheid() As Integer
        Get
            Return _hoeveelheid
        End Get
        Set(ByVal value As Integer)
            _hoeveelheid = value
        End Set
    End Property

    Public Sub New(id As Integer, naam As String, hoeveelheid As Integer)
        Me.id = id
        Me.naam = naam
        Me.hoeveelheid = hoeveelheid
    End Sub
End Class
