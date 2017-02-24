Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class initial
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.LocationTable",
                Function(c) New With
                    {
                        .SensorName = c.String(nullable := False, maxLength := 32, fixedLength := true),
                        .LocationLabel = c.String(unicode := false, storeType := "text"),
                        .Latitude = c.Double(),
                        .Longitude = c.Double()
                    }) _
                .PrimaryKey(Function(t) t.SensorName)
            
            CreateTable(
                "dbo.AirQualityTable",
                Function(c) New With
                    {
                        .SensorDataItemId = c.Int(nullable := False, identity := True),
                        .TimeRead = c.DateTime(),
                        .CarbonMonoxideLevel = c.Single(),
                        .WarningLevel = c.Single(),
                        .SerialNumber = c.String(maxLength := 10, fixedLength := true),
                        .SensorLifeExpiry = c.DateTime(storeType := "date"),
                        .OverrangeExposure = c.String(maxLength := 10, fixedLength := true),
                        .SensorName = c.String(maxLength := 32, fixedLength := true)
                    }) _
                .PrimaryKey(Function(t) t.SensorDataItemId) _
                .ForeignKey("dbo.LocationTable", Function(t) t.SensorName) _
                .Index(Function(t) t.SensorName)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.AirQualityTable", "SensorName", "dbo.LocationTable")
            DropIndex("dbo.AirQualityTable", New String() { "SensorName" })
            DropTable("dbo.AirQualityTable")
            DropTable("dbo.LocationTable")
        End Sub
    End Class
End Namespace
