Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class removedescription
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.LocationTable", "Description")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.LocationTable", "Description", Function(c) c.String())
        End Sub
    End Class
End Namespace
