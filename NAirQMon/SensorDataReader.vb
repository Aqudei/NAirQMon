Imports System.IO

Public Class SensorDataReader

    Public Shared Function ReadFile(filename As String) As DataTable
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
