Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class addedfieldstoLocation
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.LocationTable", "Barangay", Function(c) c.String())
            AddColumn("dbo.LocationTable", "Municipality", Function(c) c.String())
            AddColumn("dbo.LocationTable", "Province", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.LocationTable", "Province")
            DropColumn("dbo.LocationTable", "Municipality")
            DropColumn("dbo.LocationTable", "Barangay")
        End Sub
    End Class
End Namespace
