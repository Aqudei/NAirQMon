Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class StringLengthadded
        Inherits DbMigration
    
        Public Overrides Sub Up()
            RenameTable(name := "dbo.UserAccounts", newName := "UserAccountTable")
            AlterColumn("dbo.LocationTable", "Barangay", Function(c) c.String(maxLength := 32))
            AlterColumn("dbo.LocationTable", "Municipality", Function(c) c.String(maxLength := 32))
            AlterColumn("dbo.LocationTable", "Province", Function(c) c.String(maxLength := 32))
        End Sub
        
        Public Overrides Sub Down()
            AlterColumn("dbo.LocationTable", "Province", Function(c) c.String())
            AlterColumn("dbo.LocationTable", "Municipality", Function(c) c.String())
            AlterColumn("dbo.LocationTable", "Barangay", Function(c) c.String())
            RenameTable(name := "dbo.UserAccountTable", newName := "UserAccounts")
        End Sub
    End Class
End Namespace
