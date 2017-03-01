Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class addeduseraccounts
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.UserAccounts",
                Function(c) New With
                    {
                        .UserAccounId = c.Int(nullable := False, identity := True),
                        .Username = c.String(),
                        .Password = c.String()
                    }) _
                .PrimaryKey(Function(t) t.UserAccounId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.UserAccounts")
        End Sub
    End Class
End Namespace
