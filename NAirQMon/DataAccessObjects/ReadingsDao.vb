Public Class ReadingsDao
    Function GetLatestCO2Value(place As String, altitude As Integer) As Single
        Try
            Using ctx As New AirQContext
                Dim latest = ctx.SensorDataItems.Where(Function(r) r.Place = place And r.Altitude = altitude).OrderByDescending(Function(r) r.TimeRead).FirstOrDefault
                If latest Is Nothing Then
                    Return latest.CarbonMonoxideLevel
                Else
                    Return 0
                End If
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class
