Imports System.IO

Public Class SensorDataItem

    Private _firstColumn As String
    Public Property FirstColumn() As String
        Get
            Return _firstColumn
        End Get
        Set(ByVal value As String)
            _firstColumn = value
        End Set
    End Property

    Private _carbonMonoxideLevel As Double
    Public Property CarbonMonoxideLevel() As Double
        Get
            Return _carbonMonoxideLevel
        End Get
        Set(ByVal value As Double)
            _carbonMonoxideLevel = value
        End Set
    End Property


    Private _time As String
    Public Property Time() As String
        Get
            Return _time
        End Get
        Set(ByVal value As String)
            _time = value
        End Set
    End Property


    Private warningLevelValue As Double
    Public Property WarningLevel() As Double
        Get
            Return warningLevelValue
        End Get
        Set(ByVal value As Double)
            warningLevelValue = value
        End Set
    End Property

    Private _serialNumber As String
    Public Property SerialNumber() As String
        Get
            Return _serialNumber
        End Get
        Set(ByVal value As String)
            _serialNumber = value
        End Set
    End Property

    Private _sensorLifeExpiry As DateTime
    Public Property SensorLifeExpiry() As DateTime
        Get
            Return _sensorLifeExpiry
        End Get
        Set(ByVal value As DateTime)
            _sensorLifeExpiry = value
        End Set
    End Property


    Private _overrangeExposure As String
    Public Property OverrangeExposure() As String
        Get
            Return _overrangeExposure
        End Get
        Set(ByVal value As String)
            _overrangeExposure = value
        End Set
    End Property


    Public Shared Function ReadFile(filename As String) As DataTable
        Dim lines = IO.File.ReadAllLines(filename)
        Dim dt = New DataTable

        'Loop through all the lines in file
        For index = 0 To (lines.Length - 1)
            Dim theLine = lines.ElementAt(index)
            Dim csvs = theLine.Split(",".ToCharArray).ToList

            'If its the first line, then it is a header 
            If index = 0 Then
                For Each csv In csvs
                    dt.Columns.Add(csv)
                Next
                Continue For
            End If

            Dim newRow = dt.NewRow()
            For idx = 0 To csvs.Count - 1
                newRow(idx) = csvs(idx)
            Next
            dt.Rows.Add(newRow)
        Next

        Return dt
    End Function

    Public Sub New()

    End Sub

End Class
