Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class altitudeToInt
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.LocationTable",
                Function(c) New With
                    {
                        .LocationId = c.Long(nullable := False, identity := True),
                        .Latitude = c.Double(),
                        .Longitude = c.Double(),
                        .Barangay = c.String(maxLength := 32),
                        .Municipality = c.String(maxLength := 32),
                        .Province = c.String(maxLength := 32),
                        .Place = c.String(maxLength := 32, fixedLength := true)
                    }) _
                .PrimaryKey(Function(t) t.LocationId)
            
            CreateTable(
                "dbo.AirQualityTable",
                Function(c) New With
                    {
                        .SensorDataItemId = c.Int(nullable := False, identity := True),
                        .TimeRead = c.DateTime(),
                        .Place = c.String(maxLength := 32, fixedLength := true),
                        .Altitude = c.Int(nullable := False),
                        .CarbonMonoxideLevel = c.Single(),
                        .WarningLevel = c.Single(),
                        .SerialNumber = c.String(maxLength := 10, fixedLength := true),
                        .SensorLifeExpiry = c.DateTime(storeType := "date"),
                        .OverrangeExposure = c.String(maxLength := 10, fixedLength := true),
                        .Location_LocationId = c.Long()
                    }) _
                .PrimaryKey(Function(t) t.SensorDataItemId) _
                .ForeignKey("dbo.LocationTable", Function(t) t.Location_LocationId) _
                .Index(Function(t) t.Location_LocationId)
            
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
            DropForeignKey("dbo.AirQualityTable", "Location_LocationId", "dbo.LocationTable")
            DropIndex("dbo.AirQualityTable", New String() { "Location_LocationId" })
            DropTable("dbo.UserAccounts")
            DropTable("dbo.AirQualityTable")
            DropTable("dbo.LocationTable")
        End Sub
    End Class
End Namespace
