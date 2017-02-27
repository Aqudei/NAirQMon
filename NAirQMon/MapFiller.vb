Imports System.Text

Public Class MapFiller

    Public Shared Function MarkersAsString()
        Dim sb As StringBuilder
        sb = New StringBuilder

        Using context As New AirQContext
            Dim locs = context.Locations.ToList

            For Each loc As Location In locs

                Dim lasVal = context.SensorDataItems _
                    .Where(Function(s) s.SensorName = loc.SensorName) _
                    .OrderByDescending(Function(o) o.TimeRead) _
                    .FirstOrDefault

                sb.Append("{")
                sb.AppendFormat("SensorName:'{0}',", loc.SensorName.Trim)
                sb.AppendFormat("Lat:{0},", loc.Latitude)
                sb.AppendFormat("Long:{0},", loc.Longitude)
                sb.AppendFormat("Barangay:'{0}',", loc.Barangay)
                sb.AppendFormat("Municipality:'{0}',", loc.Municipality)
                sb.AppendFormat("Province:'{0}'", loc.Province)

                If lasVal IsNot Nothing Then
                    sb.AppendFormat(", LastReading:'{0}'", lasVal.CarbonMonoxideLevel.ToString)
                Else
                    sb.AppendFormat(", LastReading:'{0}'", "N/A")
                End If

                If lasVal IsNot Nothing Then
                    sb.AppendFormat(", LastReadingDateTime:'{0}'", lasVal.TimeRead.ToString)
                Else
                    sb.AppendFormat(", LastReadingDateTime:'{0}'", "N/A")
                End If

                sb.Append("},")
            Next
            MarkersAsString = sb.ToString().TrimEnd(",".ToCharArray)
        End Using
    End Function

    Public Shared Function FillMap(path As String) As String

        Using reader = New IO.StreamReader(path)

            Dim map_output = IO.Path.Combine(Application.StartupPath, "map_output.html")

            Using writer = New IO.StreamWriter(IO.Path.Combine(map_output))

                Dim mapContent As String
                mapContent = reader.ReadToEnd()
                writer.Write(mapContent.Replace("'[markers]'", MarkersAsString()))
                writer.Flush()
                FillMap = map_output
            End Using
        End Using
    End Function

End Class
