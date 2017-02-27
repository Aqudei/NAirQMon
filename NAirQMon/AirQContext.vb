Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class AirQContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=AirQContext")
    End Sub

    Public Overridable Property SensorDataItems As DbSet(Of SensorDataItem)
    Public Overridable Property Locations As DbSet(Of Location)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)

        modelBuilder.Entity(Of SensorDataItem)().ToTable("AirQualityTable") _
            .Property(Function(e) e.SerialNumber) _
            .IsFixedLength()

        modelBuilder.Entity(Of SensorDataItem)() _
            .Property(Function(e) e.SensorDataItemId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)

        modelBuilder.Entity(Of SensorDataItem)() _
            .Property(Function(e) e.OverrangeExposure) _
            .IsFixedLength()

        modelBuilder.Entity(Of SensorDataItem)() _
            .Property(Function(e) e.SensorName) _
            .IsFixedLength()

        modelBuilder.Entity(Of Location)().HasMany(Function(e) e.SensorDataItems).WithOptional()

        modelBuilder.Entity(Of Location)() _
            .Property(Function(e) e.SensorName) _
            .IsFixedLength()
    End Sub
End Class
