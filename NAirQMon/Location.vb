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

    <StringLength(32)>
    Public Property Place As String

    <JsonIgnore>
    <System.ComponentModel.Browsable(False)>
    Public Overridable Property SensorDataItems As ICollection(Of SensorDataItem)


    Property LocationId As Long
    Property IsActive As Boolean = True
End Class
