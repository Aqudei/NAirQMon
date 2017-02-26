Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class addedaccounts
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.AccountTAble",
                Function(c) New With
                    {
                        .AccountID = c.String(nullable := False, maxLength := 128),
                        .AccountName = c.String(unicode := false, storeType := "text"),
                        .Username = c.String(),
                        .Password = c.Double(nullable := False),
                        .FName = c.String(),
                        .MName = c.String(),
                        .LName = c.String()
                    }) _
                .PrimaryKey(Function(t) t.AccountID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.AccountTAble")
        End Sub
    End Class
End Namespace
