Imports System.Runtime.Serialization
Imports CsvHelper
Imports NAirQMon

Public Class SingleFlightFileReader
    Inherits SensorDataReader

    Public Overrides Function ReadFileReturnReadings(filename As String) As List(Of SensorDataItem)
        Dim dtf = New DateTimeFormat("YYYY-MM-dd HH:mm:ss")

        Dim fileStream = IO.File.OpenText(filename)
        ReadFileReturnReadings = New List(Of SensorDataItem)

        Dim csv = New CsvReader(fileStream)
        Dim readCount = -1
        While (csv.Read)

            If readCount = -1 Then ' skipping first record
                readCount = readCount + 1
                Continue While
            End If

            Dim timeread = csv.GetField(Of String)(1)
            Dim co2 = csv.GetField(Of Single)(2)
            Dim warninglevel = csv.GetField(Of Single)(3)

            Dim newReading = New SensorDataItem
            With newReading
                .Place = IO.Path.GetFileNameWithoutExtension(filename).Trim("01234567890@-".ToCharArray).Trim
                .TimeRead = DateTime.Parse(timeread, dtf.FormatProvider)
                .CarbonMonoxideLevel = co2
                .WarningLevel = warninglevel
                .Altitude = 10 + (readCount * 10)
            End With

            ReadFileReturnReadings.Add(newReading)

            readCount = readCount + 1

            If readCount = 4 Then
                Exit While
            End If

        End While
    End Function
End Class
