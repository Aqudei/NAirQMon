Imports System.IO
Imports GMap.NET

Public Class MainForm

    Dim fileReader As SensorDataReader

    Property isGuest As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DesignMode = False Then
            Init()
        End If
    End Sub

    Private Sub Init()
        LoadLocations()
        LoadAccount()
        LoadSensorData()

        If isGuest Then
            BeginInvoke(Sub(arg As Form)
                            If isGuest Then
                                For Each p As TabPage In TabControl1.TabPages
                                    If p Is MonitoringTabPage <> True Then
                                        TabControl1.TabPages.Remove(p)
                                    End If
                                Next
                            End If
                        End Sub, Me)
        End If
    End Sub

    'This will be called by the javascript providing the sensorname
    ' of the clicked marker
    Public Sub MarkerClicked(sensorName As String)
        MsgBox("")
    End Sub

    Private Sub ImportDataLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ImportDataLinkLabel.LinkClicked
        Dim sensorDatas As New List(Of SensorDataItem)()

        Using ofd As New OpenFileDialog
            ofd.Multiselect = True
            If ofd.ShowDialog() = DialogResult.OK Then
                If ofd.FileNames.Length > 0 Then

                    'Open all selected Files
                    For Each filename In ofd.FileNames
                        sensorDatas.AddRange(fileReader.ReadFileReturnReadings(filename))
                    Next
                    Dim uniqueReadings = sensorDatas.Distinct(New UniqueReadingsEQComparer).ToList()
                    Using importForm As New ImportSensorDataForm
                        importForm.TempSenseDataDataGridView.DataSource = uniqueReadings
                        If importForm.ShowDialog() = DialogResult.OK Then
                            LoadSensorData()
                        End If
                    End Using

                End If
            End If
        End Using
    End Sub

    Sub LoadSensorData()
        Using ctx = New AirQContext
            SensorDataDataGridView.DataSource = ctx.SensorDataItems.ToList
        End Using

        LoadMap()
    End Sub

    Sub LoadMap()

    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged
        If TabControl1.TabPages(TabControl1.TabIndex).Text.ToLower.Contains("overview") Then
        End If
    End Sub





    Sub LoadLocations()
        Using ctx = New AirQContext
            LocationsDataGridView.DataBindings.Clear()
            LocationsDataGridView.DataSource = ctx.Locations.ToList
        End Using
        LoadMap()
    End Sub




    Sub LoadAccount()
        Using ctx = New AirQContext
            AccountManager1.DataBindings.Clear()


        End Using
    End Sub



    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        If LocationsDataGridView.SelectedRows.Count <= 0 Then
            MsgBox("Nothing is selected", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        For Each item As DataGridViewRow In LocationsDataGridView.SelectedRows
            Dim loc = CType(item.DataBoundItem, Location)
            Using ctx = New AirQContext
                Dim itm = ctx.Locations.Find(loc.Place)
                ctx.Locations.Remove(itm)
                ctx.SaveChanges()
            End Using
            LoadLocations()
        Next
    End Sub

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fileReader = New SingleFlightFileReader
    End Sub


End Class
