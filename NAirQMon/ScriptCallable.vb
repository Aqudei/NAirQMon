﻿<Runtime.InteropServices.ComVisible(True)>
Public Class ScriptCallable

    Public Sub MarkerClicked(marker As Object)
        Debug.WriteLine(marker)
    End Sub

    Public Function GetMarkers() As String

        Using context As New AirQContext
            GetMarkers = Newtonsoft.Json.JsonConvert.SerializeObject(context.Locations.ToList())
        End Using
    End Function

    Public Sub JSDebug(msg As Object)
        Debug.Write(msg)
    End Sub

End Class
