Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class AirQContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=AirQContext")
    End Sub

    Public Overridable Property AirQualityTables As DbSet(Of AirQualityTable)
    Public Overridable Property LocationTables As DbSet(Of LocationTable)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of AirQualityTable)() _
            .Property(Function(e) e.SerialNumber) _
            .IsFixedLength()

        modelBuilder.Entity(Of AirQualityTable)() _
            .Property(Function(e) e.OverrangeExposure) _
            .IsFixedLength()

        modelBuilder.Entity(Of AirQualityTable)() _
            .Property(Function(e) e.SensorName) _
            .IsFixedLength()

        modelBuilder.Entity(Of LocationTable)() _
            .Property(Function(e) e.LocationLabel) _
            .IsUnicode(False)

        modelBuilder.Entity(Of LocationTable)() _
            .Property(Function(e) e.SensorName) _
            .IsFixedLength()
    End Sub
End Class
