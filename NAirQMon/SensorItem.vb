Imports System.IO

Public Class SensorItem

    Private _carbonMonoxideLevel As Double
    Public Property CarbonMonoxideLevel() As Double
        Get
            Return _carbonMonoxideLevel
        End Get
        Set(ByVal value As Double)
            _carbonMonoxideLevel = value
        End Set
    End Property

    Public Shared Function ReadFile(filename As String) As List(Of SensorItem)
        Dim tw As New StreamReader(IO.File.OpenRead(filename))
        Dim csvParser As New CsvHelper.CsvParser(tw)
        'csvParser.Rea
    End Function
End Class
