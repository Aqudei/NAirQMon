Public Class SensorDataItem
    Public Property CarbonMonoxideLevel As Double
    Public Property SensorName As String
    Public Property TimeRead As Date

    Private _warningLevel As Double
    Public Property WarningLevel() As Double
        Get
            Return _warningLevel
        End Get
        Set(ByVal value As Double)
            _warningLevel = value
        End Set
    End Property

    Public Property OverrangeExposure As String
    Public Property SerialNumber As String
    Public Property SensorLifeExpiry As String
End Class
