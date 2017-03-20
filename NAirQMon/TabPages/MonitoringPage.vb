Imports GMap.NET
Imports GMap.NET.WindowsForms

Public Class MonitoringPage

    Dim locationMarkers As New GMap.NET.WindowsForms.GMapOverlay("locations")
    Dim readingsDao As New ReadingsDao
    Dim mapCentre As New PointLatLng(12.5008589, 124.629162) 'Catarman Northern Samar

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        TheMap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
        GMaps.Instance.Mode = AccessMode.ServerAndCache
        TheMap.Position = mapCentre
        TheMap.Overlays.Add(locationMarkers)
        AddHandler TheMap.OnMarkerClick, AddressOf MarkerClicked

        LoadMarkers()
    End Sub


    Private Sub MarkerClicked(item As GMapMarker, e As MouseEventArgs)
        Dim loc = DirectCast(item.Tag, Location)
        If loc IsNot Nothing Then
            Using reportForm As New ReportingFormBar
                reportForm.CurrentPlace = loc.Place
                reportForm.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub LoadMarkers()

        locationMarkers.Clear()

        Using ctx As New AirQContext
            Dim locs = ctx.Locations.ToList

            For Each _loc In locs

                Dim marker = New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New PointLatLng(_loc.Latitude, _loc.Longitude), WindowsForms.Markers.GMarkerGoogleType.red)
                locationMarkers.Markers.Add(marker)

                marker.Tag = _loc

                Dim lastCO2 = readingsDao.GetLatestCO2Value(_loc.Place, GetAltitudeValue)

                With _loc
                    marker.ToolTipText = String.Format("Brgy. {0}, {1}, {2}" & vbNewLine & "CO2 Level: {3}" & vbNewLine & "Last Reading Time: {4}" & vbNewLine & "Altitude: {5} meter/s",
                                                       .Barangay, .Municipality, .Province, lastCO2?.CarbonMonoxideLevel, lastCO2?.TimeRead, GetAltitudeValue)
                End With
            Next
        End Using
    End Sub

    Private Sub ReloadMetroButton_Click(sender As Object, e As EventArgs)
        LoadMarkers()
    End Sub

    Private Sub MetroTrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles AltitudeMetroTrackBar.ValueChanged
        AltitudeMetroLabel.Text = "" & GetAltitudeValue()
        LoadMarkers()
    End Sub

    Private Function GetAltitudeValue() As Integer
        Return AltitudeMetroTrackBar.Value * 10
    End Function

End Class
