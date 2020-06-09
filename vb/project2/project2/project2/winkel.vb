Public Class winkel
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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

    Public Sub New(id As Integer, naam As String)
        _id = id
        _naam = naam
    End Sub
End Class
