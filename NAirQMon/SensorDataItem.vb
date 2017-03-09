Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("AirQualityTable")>
Partial Public Class SensorDataItem

    Public Sub New()
        TimeRead = DateTime.Now
    End Sub

    Public Property TimeRead As Date?

    Public Property CarbonMonoxideLevel As Single?

    Public Property WarningLevel As Single?

    <StringLength(10)>
    Public Property SerialNumber As String

    <Column(TypeName:="date")>
    Public Property SensorLifeExpiry As Date?

    <StringLength(10)>
    Public Property OverrangeExposure As String

    <StringLength(32)>
    Public Property Place As String

    <Key>
    Public Property SensorDataItemId As Integer

    Public Overridable Property LocationTable As Location

    Public Overloads Overrides Function Equals(obj As Object) As Boolean
        If obj Is Nothing Then Return False
        If TypeOf (obj) IsNot SensorDataItem Then Return False

        Return MyBase.Equals(obj) And TimeRead = CType(obj, SensorDataItem).TimeRead
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode() Xor TimeRead.GetHashCode
    End Function


End Class
