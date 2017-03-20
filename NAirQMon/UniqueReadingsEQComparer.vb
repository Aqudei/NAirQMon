Imports NAirQMon

Public Class UniqueReadingsEQComparer
    Implements IEqualityComparer(Of SensorDataItem)

    Public Shadows Function Equals(x As SensorDataItem, y As SensorDataItem) As Boolean Implements IEqualityComparer(Of SensorDataItem).Equals
        Return x.TimeRead.Equals(y.TimeRead)
    End Function

    Public Shadows Function GetHashCode(obj As SensorDataItem) As Integer Implements IEqualityComparer(Of SensorDataItem).GetHashCode
        Return obj.TimeRead.GetHashCode()
    End Function
End Class
