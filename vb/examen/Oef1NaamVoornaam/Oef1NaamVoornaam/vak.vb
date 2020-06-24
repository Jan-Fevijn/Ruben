Public Class vak
    'idvak, vaknaam, toetsdatum, idleerling, cijfer, Max
    Private _idvak As Int16
    Private _vaknaam As String
    Private _toetsdatum As Date
    Private _idleerling As Int16
    Private _cijfer As Int16
    Private _max As Int16
    Public Property idvak() As Int16
        Get
            Return _idvak
        End Get
        Set(ByVal value As Int16)
            _idvak = value
        End Set
    End Property


    Public Property vaknaam() As String
        Get
            Return _vaknaam
        End Get
        Set(ByVal value As String)
            _vaknaam = value
        End Set
    End Property


    Public Property toetsdatum() As Date
        Get
            Return _toetsdatum
        End Get
        Set(ByVal value As Date)
            _toetsdatum = value
        End Set
    End Property


    Public Property idleerling() As Int16
        Get
            Return _idleerling
        End Get
        Set(ByVal value As Int16)
            _idleerling = value
        End Set
    End Property


    Public Property cijfer() As Int16
        Get
            Return _cijfer
        End Get
        Set(ByVal value As Int16)
            _cijfer = value
        End Set
    End Property

    Public Property max() As Int16
        Get
            Return _max
        End Get
        Set(ByVal value As Int16)
            _max = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(idvak As Short, vaknaam As String, toetsdatum As Date, idleerling As Short, cijfer As Short, max As Short)
        Me.idvak = idvak
        Me.vaknaam = vaknaam
        Me.toetsdatum = toetsdatum
        Me.idleerling = idleerling
        Me.cijfer = cijfer
        Me.max = max
    End Sub
End Class
