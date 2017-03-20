Public Class ReadingsDao
    Function GetLatestCO2Value(place As String, altitude As Integer) As SensorDataItem
        Try
            Using ctx As New AirQContext
                Dim latest = ctx.SensorDataItems.Where(Function(r) r.Place = place And r.Altitude = altitude).OrderByDescending(Function(r) r.TimeRead).FirstOrDefault
                If latest IsNot Nothing Then
                    Return latest
                Else
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
