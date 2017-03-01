Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class fixmiddletomiddleName
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.UserAccounts", "MiddleName", Function(c) c.String())
            DropColumn("dbo.UserAccounts", "Middle")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.UserAccounts", "Middle", Function(c) c.String())
            DropColumn("dbo.UserAccounts", "MiddleName")
        End Sub
    End Class
End Namespace
