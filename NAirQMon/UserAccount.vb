Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("UserAccountTable")>
Public Class UserAccount


    Sub New()
        IsActive = True
    End Sub

    Private _userAccoundId As Integer
    <Key>
    Public Property UserAccounId() As Integer
        Get
            Return _userAccoundId
        End Get
        Set(ByVal value As Integer)
            _userAccoundId = value
        End Set
    End Property

    <StringLength(20)>
    Private _username As String
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    <StringLength(20)>
    Private _userPass As String
    Public Property UserPass() As String
        Get
            Return _userPass
        End Get
        Set(ByVal value As String)
            _userPass = value
        End Set
    End Property

    <StringLength(20)>
    Private _userFirstName As String
    Public Property FirstName() As String
        Get
            Return _userFirstName
        End Get
        Set(value As String)
            _userFirstName = value
        End Set
    End Property

    <StringLength(20)>
    Private _userMiddleName As String
    Public Property MiddleName() As String
        Get
            Return _userMiddleName
        End Get
        Set(value As String)
            _userMiddleName = value
        End Set
    End Property

    <StringLength(20)>
    Private _userLastName As String
    Public Property LastName As String
        Get
            Return _userLastName
        End Get
        Set(value As String)
            _userLastName = value
        End Set
    End Property

    Private _isActive As Boolean
    Public Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal value As Boolean)
            _isActive = value
        End Set
    End Property


End Class
