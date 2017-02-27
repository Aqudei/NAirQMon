Imports System.ComponentModel.DataAnnotations

Public Class UserAccount
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

    Private _username As String
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Private _userPass As String
    Public Property UserPass() As String
        Get
            Return _userPass
        End Get
        Set(ByVal value As String)
            _userPass = value
        End Set
    End Property
End Class
