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

    Public Property Latitude As Double?
    Public Property Longitude As Double?

    <StringLength(32)>
    Public Property Barangay As String
    <StringLength(32)>
    Public Property Municipality As String
    <StringLength(32)>
    Public Property Province As String

    <Key>
    <StringLength(32)>
    Public Property SensorName As String

    <JsonIgnore>
    <System.ComponentModel.Browsable(False)>
    Public Overridable Property SensorDataItems As ICollection(Of SensorDataItem)

End Class
