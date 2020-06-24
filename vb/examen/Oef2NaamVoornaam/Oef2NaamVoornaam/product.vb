Public Class product
    Private _idproduct As Int16
    Public Property idproduct() As Int16
        Get
            Return _idproduct
        End Get
        Set(ByVal value As Int16)
            _idproduct = value
        End Set
    End Property
    Private _naamproduct As String
    Public Property naamproduct() As String
        Get
            Return _naamproduct
        End Get
        Set(ByVal value As String)
            _naamproduct = value
        End Set
    End Property
    Private _hoeveelheid As Int16
    Public Property hoeveelheid() As Int16
        Get
            Return _hoeveelheid
        End Get
        Set(ByVal value As Int16)
            _hoeveelheid = value
        End Set
    End Property

    Public Sub New(idproduct As Short, naamproduct As String, hoeveelheid As Short)
        _idproduct = idproduct
        _naamproduct = naamproduct
        _hoeveelheid = hoeveelheid
    End Sub

    Public Sub New()
    End Sub
End Class
