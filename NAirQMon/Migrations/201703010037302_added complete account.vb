Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class addedcompleteaccount
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.UserAccounts", "FirstName", Function(c) c.String())
            AddColumn("dbo.UserAccounts", "Middle", Function(c) c.String())
            AddColumn("dbo.UserAccounts", "LastName", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.UserAccounts", "LastName")
            DropColumn("dbo.UserAccounts", "Middle")
            DropColumn("dbo.UserAccounts", "FirstName")
        End Sub
    End Class
End Namespace
