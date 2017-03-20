Imports System.IO
Imports System.Runtime.Serialization

Public MustInherit Class SensorDataReader


    MustOverride Function ReadFileReturnReadings(filename As String) As List(Of SensorDataItem)

End Class
