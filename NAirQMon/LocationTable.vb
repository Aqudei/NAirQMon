Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("LocationTable")>
Partial Public Class LocationTable
    Public Sub New()
        AirQualityTables = New HashSet(Of AirQualityTable)()
    End Sub

    <Column(TypeName:="text")>
    Public Property LocationLabel As String

    Public Property Latitude As Double?

    Public Property Longitude As Double?

    <Key>
    <StringLength(32)>
    Public Property SensorName As String

    Public Overridable Property AirQualityTables As ICollection(Of AirQualityTable)
End Class
