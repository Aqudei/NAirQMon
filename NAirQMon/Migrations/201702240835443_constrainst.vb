Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class constrainst
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.AirQualityTable", "Place", "dbo.LocationTable")
            DropIndex("dbo.AirQualityTable", New String() {"Place"})
            AddColumn("dbo.AirQualityTable", "LocationTable_SensorName", Function(c) c.String(maxLength:=32, fixedLength:=True))
            AddColumn("dbo.AirQualityTable", "Location_SensorName", Function(c) c.String(maxLength:=32, fixedLength:=True))
            CreateIndex("dbo.AirQualityTable", "LocationTable_SensorName")
            CreateIndex("dbo.AirQualityTable", "Location_SensorName")
            AddForeignKey("dbo.AirQualityTable", "Location_SensorName", "dbo.LocationTable", "Place")
            AddForeignKey("dbo.AirQualityTable", "LocationTable_SensorName", "dbo.LocationTable", "Place")
        End Sub

        Public Overrides Sub Down()
            DropForeignKey("dbo.AirQualityTable", "LocationTable_SensorName", "dbo.LocationTable")
            DropForeignKey("dbo.AirQualityTable", "Location_SensorName", "dbo.LocationTable")
            DropIndex("dbo.AirQualityTable", New String() {"Location_SensorName"})
            DropIndex("dbo.AirQualityTable", New String() {"LocationTable_SensorName"})
            DropColumn("dbo.AirQualityTable", "Location_SensorName")
            DropColumn("dbo.AirQualityTable", "LocationTable_SensorName")
            CreateIndex("dbo.AirQualityTable", "Place")
            AddForeignKey("dbo.AirQualityTable", "Place", "dbo.LocationTable", "Place")
        End Sub
    End Class
End Namespace
