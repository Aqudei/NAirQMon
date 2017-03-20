Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class nextmigration
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.AirQualityTable", "Altitude", Function(c) c.Double(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.AirQualityTable", "Altitude")
        End Sub
    End Class
End Namespace
