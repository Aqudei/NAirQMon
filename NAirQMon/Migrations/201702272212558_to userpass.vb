Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class touserpass
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.UserAccounts", "UserPass", Function(c) c.String())
            DropColumn("dbo.UserAccounts", "Password")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.UserAccounts", "Password", Function(c) c.String())
            DropColumn("dbo.UserAccounts", "UserPass")
        End Sub
    End Class
End Namespace
