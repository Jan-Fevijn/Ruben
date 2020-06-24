Public Class Product

    Private _idProduct As Int32
    Private _naam As String


    Public Sub New(idProduct As Integer, naam As String)
        Me.idProduct = idProduct
        Me.Naam = naam
    End Sub

    Public Sub New()
    End Sub


    Public Property idProduct() As Int32
        Get
            Return _idProduct
        End Get
        Set(ByVal value As Int32)
            _idProduct = value
        End Set
    End Property


    Public Property Naam() As String
        Get
            Return _naam
        End Get
        Set(ByVal value As String)
            _naam = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "Product: " & Naam
    End Function
End Class
