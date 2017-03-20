Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class isActiveToLocation
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.LocationTable", "IsActive", Function(c) c.Boolean(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.LocationTable", "IsActive")
        End Sub
    End Class
End Namespace
