Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class AirQContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("AirQContext")
    End Sub

    Public Overridable Property SensorDataItems As DbSet(Of SensorDataItem)
    Public Overridable Property Locations As DbSet(Of Location)
    Public Overridable Property UserAccounts As DbSet(Of UserAccount)

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
            .Property(Function(e) e.Place) _
            .IsFixedLength()

        modelBuilder.Entity(Of Location)().HasMany(Function(e) e.SensorDataItems).WithOptional()

        modelBuilder.Entity(Of Location)() _
            .Property(Function(e) e.Place) _
            .IsFixedLength()

        modelBuilder.Entity(Of UserAccount)().HasKey(Function(k) k.UserAccounId) _
            .Property(Function(p) p.UserAccounId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
    End Sub
End Class