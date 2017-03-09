Public Class AccountManager
    Inherits MetroFramework.Controls.MetroUserControl

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles MetroLink2.Click

        If AccountsMetroGrid.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In AccountsMetroGrid.SelectedRows
                DeleteAccount(row.DataBoundItem)
                UserAccountBindingSource.Remove(row.DataBoundItem)
            Next
        End If
    End Sub

    Private Sub DeleteAccount(dataBoundItem As Object)

        If dataBoundItem Is Nothing Then Return

        Dim account = CType(dataBoundItem, UserAccount)

        Using ctx As New AirQContext
            Dim toBeDeleted = ctx.UserAccounts.Where(Function(u) u.UserAccounId = account.UserAccounId).FirstOrDefault()
            If toBeDeleted Is Nothing Then Return

            ctx.UserAccounts.Remove(toBeDeleted)
            ctx.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Delete Successfull")


        End Using
    End Sub

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

    Private Sub AccountsMetroGrid_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles AccountsMetroGrid.UserDeletingRow
        DeleteAccount(e.Row.DataBoundItem)
    End Sub
End Class
