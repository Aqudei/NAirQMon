Public Class ReportingFormBar

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Property CurrentPlace As String

    Private Sub ReportingFormBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BarChartReport1.SetParameterValue("PlaceParameter", CurrentPlace)
    End Sub
End Class