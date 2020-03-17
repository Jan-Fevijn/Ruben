Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Public Class user
    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _voornaam As String
    Public Property voornaam() As String
        Get
            Return _voornaam
        End Get
        Set(ByVal value As String)
            _voornaam = value
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

    Private _password As String
    Public Property password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Private _vegan As String
    Public Property vegan() As Boolean
        Get
            Return _vegan
        End Get
        Set(ByVal value As Boolean)
            _vegan = value
        End Set
    End Property

    Private _veganistisch As String
    Public Property veganistisch() As Boolean
        Get
            Return _veganistisch
        End Get
        Set(ByVal value As Boolean)
            _veganistisch = value
        End Set
    End Property

    Private _admin As String
    Public Property admin() As Boolean
        Get
            Return admin
        End Get
        Set(ByVal value As Boolean)
            _admin = value
        End Set
    End Property

    Private _username As String
    Public Property username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property


End Class
