Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("AirQualityTable")>
Partial Public Class SensorDataItem
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
    Public Property SensorName As String

    <Key>
    Public Property SensorDataItemId As Integer

    Public Overridable Property LocationTable As Location
End Class
