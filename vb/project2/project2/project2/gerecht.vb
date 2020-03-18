Public Class gerecht
    Private _naam As String
    Public Property naam() As String
        Get
            Return _naam
        End Get
        Set(ByVal value As String)
            _naam = value
        End Set
    End Property

    Private _img As String
    Public Property img() As String
        Get
            Return _img
        End Get
        Set(ByVal value As String)
            _img = value
        End Set
    End Property

    Private _idEvent As Integer
    Public Property idEvent() As Integer
        Get
            Return _idEvent
        End Get
        Set(ByVal value As Integer)
            _idEvent = value
        End Set
    End Property

    Private _idGerecht As Integer
    Public Property idGerecht() As Integer
        Get
            Return _idGerecht
        End Get
        Set(ByVal value As Integer)
            _idGerecht = value
        End Set
    End Property

    Private _vegan As Boolean
    Public Property vegan() As Boolean
        Get
            Return _vegan
        End Get
        Set(ByVal value As Boolean)
            _vegan = value
        End Set
    End Property

    Private _veganistisch As Boolean
    Public Property veganistisch() As Boolean
        Get
            Return _veganistisch
        End Get
        Set(ByVal value As Boolean)
            _veganistisch = value
        End Set
    End Property


End Class
