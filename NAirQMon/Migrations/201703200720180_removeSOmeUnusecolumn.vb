Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class removeSOmeUnusecolumn
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.AirQualityTable", "LocationTable_LocationId", "dbo.LocationTable")
            DropIndex("dbo.AirQualityTable", New String() { "LocationTable_LocationId" })
            DropColumn("dbo.AirQualityTable", "LocationTable_LocationId")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.AirQualityTable", "LocationTable_LocationId", Function(c) c.Long())
            CreateIndex("dbo.AirQualityTable", "LocationTable_LocationId")
            AddForeignKey("dbo.AirQualityTable", "LocationTable_LocationId", "dbo.LocationTable", "LocationId")
        End Sub
    End Class
End Namespace
