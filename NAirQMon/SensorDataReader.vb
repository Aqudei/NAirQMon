Imports System.IO
Imports System.Runtime.Serialization

Public Class SensorDataReader

    Public Shared Function ReadFileReturnDataTable(filename As String) As DataTable
        Dim lines = IO.File.ReadAllLines(filename)
        Dim dt = New DataTable

        'Loop through all the lines in file
        For index = 0 To (lines.Length - 1)
            Dim theLine = lines.ElementAt(index)
            Dim csvs = theLine.Split(",".ToCharArray)

            'If its the first line, then it is a header 
            If index = 0 Then
                BuildHeader(dt, csvs)
                Continue For
            End If

            'Set first column to sensor name
            BuildRow(dt, csvs).Item(0) = Path.GetFileNameWithoutExtension(filename)
        Next

        Return dt
    End Function

    Public Shared Function ReadFileReturnSensorDataList(filename As String) As List(Of SensorDataItem)
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
                .SensorName = Path.GetFileNameWithoutExtension(filename)
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

    Private Shared Sub BuildHeader(ByRef dt As DataTable, csvs As String())
        dt.Columns.Clear()
        For Each csv In csvs
            dt.Columns.Add(csv)
        Next
        dt.Columns.Item(0).ColumnName = "Sensor"
        dt.Columns.Item(0).Caption = "Sensor"
    End Sub

    Private Shared Function BuildRow(ByRef dt As DataTable, csvs As String()) As DataRow
        Dim newRow = dt.NewRow()
        For idx = 0 To csvs.Count - 1
            If idx = 0 Then Continue For
            newRow(idx) = csvs(idx)
        Next
        dt.Rows.Add(newRow)
        Return newRow
    End Function

    Public Sub New()

    End Sub

End Class
