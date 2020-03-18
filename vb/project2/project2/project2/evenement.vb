Public Class evenement
    Private _idEvent As Integer
    Public Property idevent() As Integer
        Get
            Return _idEvent
        End Get
        Set(ByVal value As Integer)
            _idEvent = value
        End Set
    End Property

    Private _van As String
    Public Property van() As String
        Get
            Return _van
        End Get
        Set(ByVal value As String)
            _van = value
        End Set
    End Property

    Private _datumEnd As String
    Public Property datumEnd() As String
        Get
            Return _datumEnd
        End Get
        Set(ByVal value As String)
            _datumEnd = value
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
    Private _naam As String


    Public Property naam() As String
        Get
            Return _naam
        End Get
        Set(ByVal value As String)
            _naam = value
        End Set
    End Property


End Class
