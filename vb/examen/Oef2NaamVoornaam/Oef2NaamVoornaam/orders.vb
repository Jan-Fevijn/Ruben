Public Class order
    Private _idorder As Int16
    Public Property idorder() As Int16
        Get
            Return _idorder
        End Get
        Set(ByVal value As Int16)
            _idorder = value
        End Set
    End Property

    Private _idklant As Int16
    Public Property idklant() As Int16
        Get
            Return _idklant
        End Get
        Set(ByVal value As Int16)
            _idklant = value
        End Set
    End Property
    Private _idproduct As String
    Public Property idproduct() As String
        Get
            Return _idproduct
        End Get
        Set(ByVal value As String)
            _idproduct = value
        End Set
    End Property

    Public Sub New(idorder As Short, idklant As Short, idproduct As String)
        Me.idorder = idorder
        Me.idklant = idklant
        Me.idproduct = idproduct
    End Sub

    Public Sub New()
    End Sub
End Class
