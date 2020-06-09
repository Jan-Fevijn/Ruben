Public Class adminGerecht
    Private _idgerecht As Integer
    Private _naam As String
    Private _img As String
    Private _veganistisch As Boolean
    Private _vegan As Boolean
    Public Property idGerecht() As Integer
        Get
            Return _idgerecht
        End Get
        Set(ByVal value As Integer)
            _idgerecht = value
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

    Public Property img() As String
        Get
            Return _img
        End Get
        Set(ByVal value As String)
            _img = value
        End Set
    End Property


    Public Property vegan() As Boolean
        Get
            Return _vegan
        End Get
        Set(ByVal value As Boolean)
            _vegan = value
        End Set
    End Property


    Public Property veganistisch() As Boolean
        Get
            Return _veganistisch
        End Get
        Set(ByVal value As Boolean)
            _veganistisch = value
        End Set
    End Property

    Public Sub New(idGerecht As Integer, naam As String, img As String, vegan As Boolean, veganistisch As Boolean)
        Me.idGerecht = idGerecht
        Me.naam = naam
        Me.img = img
        Me.vegan = vegan
        Me.veganistisch = veganistisch
    End Sub
End Class
