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
                        .Place = c.String(nullable:=False, maxLength:=32, fixedLength:=True),
                        .LocationLabel = c.String(unicode:=False, storeType:="text"),
                        .Latitude = c.Double(),
                        .Longitude = c.Double()
                    }) _
                .PrimaryKey(Function(t) t.Place)

            CreateTable(
                "dbo.AirQualityTable",
                Function(c) New With
                    {
                        .SensorDataItemId = c.Int(nullable:=False, identity:=True),
                        .TimeRead = c.DateTime(),
                        .CarbonMonoxideLevel = c.Single(),
                        .WarningLevel = c.Single(),
                        .SerialNumber = c.String(maxLength:=10, fixedLength:=True),
                        .SensorLifeExpiry = c.DateTime(storeType:="date"),
                        .OverrangeExposure = c.String(maxLength:=10, fixedLength:=True),
                        .Place = c.String(maxLength:=32, fixedLength:=True)
                    }) _
                .PrimaryKey(Function(t) t.SensorDataItemId) _
                .ForeignKey("dbo.LocationTable", Function(t) t.Place) _
                .Index(Function(t) t.Place)

        End Sub

        Public Overrides Sub Down()
            DropForeignKey("dbo.AirQualityTable", "Place", "dbo.LocationTable")
            DropIndex("dbo.AirQualityTable", New String() {"Place"})
            DropTable("dbo.AirQualityTable")
            DropTable("dbo.LocationTable")
        End Sub
    End Class
End Namespace
