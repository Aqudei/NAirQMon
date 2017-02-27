Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class addeddescription
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.LocationTable", "Description", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.LocationTable", "Description")
        End Sub
    End Class
End Namespace
