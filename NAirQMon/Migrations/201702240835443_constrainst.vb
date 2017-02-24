Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class constrainst
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.AirQualityTable", "SensorName", "dbo.LocationTable")
            DropIndex("dbo.AirQualityTable", New String() { "SensorName" })
            AddColumn("dbo.AirQualityTable", "LocationTable_SensorName", Function(c) c.String(maxLength := 32, fixedLength := true))
            AddColumn("dbo.AirQualityTable", "Location_SensorName", Function(c) c.String(maxLength := 32, fixedLength := true))
            CreateIndex("dbo.AirQualityTable", "LocationTable_SensorName")
            CreateIndex("dbo.AirQualityTable", "Location_SensorName")
            AddForeignKey("dbo.AirQualityTable", "Location_SensorName", "dbo.LocationTable", "SensorName")
            AddForeignKey("dbo.AirQualityTable", "LocationTable_SensorName", "dbo.LocationTable", "SensorName")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.AirQualityTable", "LocationTable_SensorName", "dbo.LocationTable")
            DropForeignKey("dbo.AirQualityTable", "Location_SensorName", "dbo.LocationTable")
            DropIndex("dbo.AirQualityTable", New String() { "Location_SensorName" })
            DropIndex("dbo.AirQualityTable", New String() { "LocationTable_SensorName" })
            DropColumn("dbo.AirQualityTable", "Location_SensorName")
            DropColumn("dbo.AirQualityTable", "LocationTable_SensorName")
            CreateIndex("dbo.AirQualityTable", "SensorName")
            AddForeignKey("dbo.AirQualityTable", "SensorName", "dbo.LocationTable", "SensorName")
        End Sub
    End Class
End Namespace
