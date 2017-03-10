Public Class LocationManager
    Inherits MetroFramework.Controls.MetroUserControl
    Private Sub DeleteMetroLink2_Click(sender As Object, e As EventArgs) Handles DeleteMetroLink2.Click
        If LocationsMetroGrid.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In LocationsMetroGrid.SelectedRows
                DeleteLocation(row.DataBoundItem)
            Next
        End If
    End Sub

    Private Sub DeleteLocation(dataBoundItem As Object)

    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click

    End Sub
End Class
