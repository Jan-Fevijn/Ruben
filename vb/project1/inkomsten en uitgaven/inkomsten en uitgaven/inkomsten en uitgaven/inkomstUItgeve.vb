Public Class inkomstUItgeve
    Private _code As Integer
    Public Property code() As Integer
        Get
            Return _code
        End Get
        Set(ByVal value As Integer)
            _code = value
        End Set
    End Property

    Private _omschrijving As String
    Public Property omschrijving() As String
        Get
            Return _omschrijving
        End Get
        Set(ByVal value As String)
            _omschrijving = value
        End Set
    End Property
    Private _bedrag As Integer
    Public Property bedrag() As Integer
        Get
            Return _bedrag
        End Get
        Set(ByVal value As Integer)
            _bedrag = value
        End Set
    End Property
    Private _io As Boolean
    Public Property io() As Boolean
        Get
            Return _io
        End Get
        Set(ByVal value As Boolean)
            _io = value
        End Set
    End Property

    Public Sub New(code As Integer, omschrijving As String, bedrag As Integer, io As Boolean)
        _code = code
        _omschrijving = omschrijving
        _bedrag = bedrag
        _io = io
    End Sub
End Class
