Public Class LocationManager
    Inherits MetroFramework.Controls.MetroUserControl

    Sub SaveAll()
        Using ctx As New AirQContext
            For Each item In LocationBindingSource.List

                Dim location = CType(item, Location)
                If location.LocationId <= 0 Then
                    ctx.Locations.Add(location)
                Else
                    ctx.Locations.Attach(location)
                    ctx.Entry(location).State = Entity.EntityState.Modified
                End If
            Next
            ctx.SaveChanges()
            MetroFramework.MetroMessageBox.Show(Me, "Save Successful")
        End Using
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        SaveAll()
    End Sub

    Sub LoadLocations()
        Using ctx As New AirQContext
            LocationBindingSource.DataSource = ctx.Locations.ToList
        End Using
    End Sub

    Private Sub LocationManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DesignMode = True Then Return
        LoadLocations()
    End Sub

End Class
