Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Initial
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.LocationTable",
                Function(c) New With
                    {
                        .Place = c.String(nullable := False, maxLength := 32, fixedLength := true),
                        .Latitude = c.Double(),
                        .Longitude = c.Double(),
                        .Barangay = c.String(maxLength := 32),
                        .Municipality = c.String(maxLength := 32),
                        .Province = c.String(maxLength := 32)
                    }) _
                .PrimaryKey(Function(t) t.Place)
            
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
                        .Place = c.String(maxLength := 32, fixedLength := true),
                        .LocationTable_Place = c.String(maxLength := 32, fixedLength := true),
                        .Location_Place = c.String(maxLength := 32, fixedLength := true)
                    }) _
                .PrimaryKey(Function(t) t.SensorDataItemId) _
                .ForeignKey("dbo.LocationTable", Function(t) t.LocationTable_Place) _
                .ForeignKey("dbo.LocationTable", Function(t) t.Location_Place) _
                .Index(Function(t) t.LocationTable_Place) _
                .Index(Function(t) t.Location_Place)
            
            CreateTable(
                "dbo.UserAccounts",
                Function(c) New With
                    {
                        .UserAccounId = c.Int(nullable := False, identity := True),
                        .Username = c.String(),
                        .UserPass = c.String(),
                        .FirstName = c.String(),
                        .MiddleName = c.String(),
                        .LastName = c.String(),
                        .IsActive = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.UserAccounId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.AirQualityTable", "Location_Place", "dbo.LocationTable")
            DropForeignKey("dbo.AirQualityTable", "LocationTable_Place", "dbo.LocationTable")
            DropIndex("dbo.AirQualityTable", New String() { "Location_Place" })
            DropIndex("dbo.AirQualityTable", New String() { "LocationTable_Place" })
            DropTable("dbo.UserAccounts")
            DropTable("dbo.AirQualityTable")
            DropTable("dbo.LocationTable")
        End Sub
    End Class
End Namespace
