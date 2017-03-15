Public Class AccountManager
    Inherits MetroFramework.Controls.MetroUserControl

    Sub SaveAll()
        Using ctx As New AirQContext

            For Each item In UserAccountBindingSource.List
                Dim account = CType(item, UserAccount)
                If account.UserAccounId <= 0 Then
                    ctx.UserAccounts.Add(account)
                Else
                    ctx.UserAccounts.Attach(account)
                    ctx.Entry(account).State = Entity.EntityState.Modified
                End If
            Next

            ctx.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Save Successfull")
        End Using
    End Sub

    Private Sub SaveAllClicked_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        SaveAll()
    End Sub

    Sub LoadAccounts()
        Using ctx As New AirQContext
            UserAccountBindingSource.DataSource = ctx.UserAccounts.ToList
        End Using
    End Sub

    Private Sub AccountManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DesignMode = True Then Return 
        LoadAccounts()
    End Sub


End Class
