Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class locationChangedId
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.AirQualityTable", "LocationTable_Place", "dbo.LocationTable")
            DropForeignKey("dbo.AirQualityTable", "Location_Place", "dbo.LocationTable")
            DropIndex("dbo.AirQualityTable", New String() { "LocationTable_Place" })
            DropIndex("dbo.AirQualityTable", New String() { "Location_Place" })
            RenameColumn(table := "dbo.AirQualityTable", name := "Location_Place", newName := "Location_LocationId")
            RenameColumn(table := "dbo.AirQualityTable", name := "LocationTable_Place", newName := "LocationTable_LocationId")
            DropPrimaryKey("dbo.LocationTable")
            AddColumn("dbo.LocationTable", "LocationId", Function(c) c.Long(nullable := False, identity := True))
            AlterColumn("dbo.LocationTable", "Place", Function(c) c.String(maxLength := 32, fixedLength := true))
            AlterColumn("dbo.AirQualityTable", "LocationTable_LocationId", Function(c) c.Long())
            AlterColumn("dbo.AirQualityTable", "Location_LocationId", Function(c) c.Long())
            AddPrimaryKey("dbo.LocationTable", "LocationId")
            CreateIndex("dbo.AirQualityTable", "LocationTable_LocationId")
            CreateIndex("dbo.AirQualityTable", "Location_LocationId")
            AddForeignKey("dbo.AirQualityTable", "LocationTable_LocationId", "dbo.LocationTable", "LocationId")
            AddForeignKey("dbo.AirQualityTable", "Location_LocationId", "dbo.LocationTable", "LocationId")
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.AirQualityTable", "Location_LocationId", "dbo.LocationTable")
            DropForeignKey("dbo.AirQualityTable", "LocationTable_LocationId", "dbo.LocationTable")
            DropIndex("dbo.AirQualityTable", New String() { "Location_LocationId" })
            DropIndex("dbo.AirQualityTable", New String() { "LocationTable_LocationId" })
            DropPrimaryKey("dbo.LocationTable")
            AlterColumn("dbo.AirQualityTable", "Location_LocationId", Function(c) c.String(maxLength := 32, fixedLength := true))
            AlterColumn("dbo.AirQualityTable", "LocationTable_LocationId", Function(c) c.String(maxLength := 32, fixedLength := true))
            AlterColumn("dbo.LocationTable", "Place", Function(c) c.String(nullable := False, maxLength := 32, fixedLength := true))
            DropColumn("dbo.LocationTable", "LocationId")
            AddPrimaryKey("dbo.LocationTable", "Place")
            RenameColumn(table := "dbo.AirQualityTable", name := "LocationTable_LocationId", newName := "LocationTable_Place")
            RenameColumn(table := "dbo.AirQualityTable", name := "Location_LocationId", newName := "Location_Place")
            CreateIndex("dbo.AirQualityTable", "Location_Place")
            CreateIndex("dbo.AirQualityTable", "LocationTable_Place")
            AddForeignKey("dbo.AirQualityTable", "Location_Place", "dbo.LocationTable", "Place")
            AddForeignKey("dbo.AirQualityTable", "LocationTable_Place", "dbo.LocationTable", "Place")
        End Sub
    End Class
End Namespace
