Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class _error
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.UserAccounts", "PhotoPath")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.UserAccounts", "PhotoPath", Function(c) c.String())
        End Sub
    End Class
End Namespace
