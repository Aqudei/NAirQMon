Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class removelocationlabel
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.LocationTable", "LocationLabel")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.LocationTable", "LocationLabel", Function(c) c.String(unicode := false, storeType := "text"))
        End Sub
    End Class
End Namespace
