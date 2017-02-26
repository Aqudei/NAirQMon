Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
Imports Newtonsoft.Json

<Table("LocationTable")>
Partial Public Class Location
    Public Sub New()
        SensorDataItems = New HashSet(Of SensorDataItem)()
    End Sub

    <Column(TypeName:="text")>
    Public Property LocationLabel As String

    Public Property Latitude As Double?

    Public Property Longitude As Double?

    <Key>
    <StringLength(32)>
    Public Property SensorName As String

    <JsonIgnore>
    Public Overridable Property SensorDataItems As ICollection(Of SensorDataItem)
End Class
