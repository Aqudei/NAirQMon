Imports System.Linq

Public Class ImportSensorDataForm
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Using ctx = New AirQContext
            Dim datas = From d As DataGridViewRow In TempSenseDataDataGridView.Rows
                        Select d.DataBoundItem

            For Each sensorDataItem As SensorDataItem In datas

                If ctx.SensorDataItems.Any(Function(s) s.TimeRead.Equals(sensorDataItem.TimeRead)) = False Then
                    ctx.SensorDataItems.Add(sensorDataItem)
                End If
            Next

            ctx.SaveChanges()
        End Using

        DialogResult = DialogResult.OK
    End Sub
End Class