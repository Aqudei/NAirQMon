Imports NAirQMon

Public Class ReportingForm



    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Sub New(locationLabel As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Text = locationLabel
        rpt = New MainReport
        rpt.SetParameterValue("LocationLabel", locationLabel)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Public rpt As MainReport

    Private Sub CrystalReportViewer1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CrystalReportViewer1.KeyPress

    End Sub
End Class