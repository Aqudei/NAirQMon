Imports System.Linq

Public Class ImportSensorDataForm
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Using ctx = New AirQContext
            Dim datas = From d As DataGridViewRow In TempSenseDataDataGridView.Rows
                        Select d.DataBoundItem

            For Each d In datas
                ctx.SensorDataItems.Add(d)
            Next

            ctx.SaveChanges()
        End Using

        DialogResult = DialogResult.OK
    End Sub
End Class