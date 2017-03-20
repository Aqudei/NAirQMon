Imports GMap.NET
Imports GMap.NET.WindowsForms

Public Class MonitoringPage

    Dim locationMarkers As New GMap.NET.WindowsForms.GMapOverlay("locations")

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        TheMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
        GMaps.Instance.Mode = AccessMode.ServerAndCache
        TheMap.Position = New PointLatLng(12.5008589, 124.629162)
        TheMap.Overlays.Add(locationMarkers)
        AddHandler TheMap.OnMarkerClick, AddressOf MarkerClicked

        LoadMarker()
    End Sub

    Private Sub MarkerClicked(item As GMapMarker, e As MouseEventArgs)
        Animate(item)
        Using Form As New ReportingFormBar
            Form.ShowDialog()
        End Using

    End Sub



    Private Sub Animate(item As GMapMarker)
        Dim orig = item.LocalPosition

        For index = 1 To 1000
            item.IsVisible = (index Mod 10 = 0)
            Application.DoEvents()
        Next

        item.IsVisible = True
    End Sub

    Private Sub LoadMarker()
        Dim locs As IEnumerable(Of Location)
        Using ctx As New AirQContext
            locs = ctx.Locations.ToList
        End Using

        For Each _loc In locs
            Dim marker = New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(_loc.Latitude, _loc.Longitude), WindowsForms.Markers.GMarkerGoogleType.red)
            locationMarkers.Markers.Add(marker)
        Next

    End Sub

    Private Sub ReloadMetroButton_Click(sender As Object, e As EventArgs) Handles ReloadMetroButton.Click
        locationMarkers.Markers.Clear()
        LoadMarker()
    End Sub
End Class
