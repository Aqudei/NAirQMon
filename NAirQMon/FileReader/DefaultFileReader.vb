Imports System.IO
Imports System.Runtime.Serialization
Imports NAirQMon

Public Class DefaultFileReader
    Inherits SensorDataReader

    Public Overrides Function ReadFileReturnReadings(filename As String) As List(Of SensorDataItem)
        Dim lines = IO.File.ReadAllLines(filename)
        Dim list = New List(Of SensorDataItem)
        Dim dtf = New DateTimeFormat("YYYY-MM-dd HH:mm:ss")
        'Loop through all the lines in file
        For index = 0 To (lines.Length - 1)
            Dim theLine = lines.ElementAt(index)
            Dim csvs = theLine.Split(",".ToCharArray)

            'If its the first line, then it is a header, skip
            If index = 0 Then Continue For

            'Set first column to sensor name
            Dim newItem = New SensorDataItem
            With newItem
                .Place = Path.GetFileNameWithoutExtension(filename).Trim("0123456789".ToCharArray)
                .TimeRead = DateTime.Parse(csvs(1), dtf.FormatProvider)
                .CarbonMonoxideLevel = Single.Parse(csvs(2))
                .WarningLevel = Single.Parse(csvs(3))
                If csvs.Length > 4 Then
                    .SerialNumber = csvs(4)
                    Dim tmpDate = csvs(5).Split("/".ToCharArray)
                    .SensorLifeExpiry = New Date(Integer.Parse(tmpDate.ElementAt(2)), Integer.Parse(tmpDate.ElementAt(1)), Integer.Parse(tmpDate.ElementAt(0)))
                    .OverrangeExposure = csvs(6)
                End If
            End With

            list.Add(newItem)
        Next

        Return list
    End Function

End Class
