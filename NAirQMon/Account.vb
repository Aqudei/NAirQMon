Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("AccountTAble")>
Public Class Account


    <Column(TypeName:="text")>
    Public Property AccountName As String

    Public Property Username As String

    Public Property Password As Double

    Public Property FName As String

    Public Property MName As String

    Public Property LName As String


    <Key>
    Public Property AccountID As String

End Class

