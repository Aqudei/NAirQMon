Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class addedUserStatus
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.UserAccounts", "IsActive", Function(c) c.Boolean(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.UserAccounts", "IsActive")
        End Sub
    End Class
End Namespace
