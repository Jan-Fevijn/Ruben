Public Class eenheid
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _afkorting As String
    Public Property afkorting() As String
        Get
            Return _afkorting
        End Get
        Set(ByVal value As String)
            _afkorting = value
        End Set
    End Property

    Private voluit As String
    Public Property _voluit() As String
        Get
            Return voluit
        End Get
        Set(ByVal value As String)
            voluit = value
        End Set
    End Property

    Public Sub New(id As Integer, afkorting As String, voluit As String)
        _id = id
        _afkorting = afkorting
        Me.voluit = voluit
    End Sub
End Class
