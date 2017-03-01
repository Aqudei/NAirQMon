Imports System.IO


Public Class MainForm



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        ShowLogin()
        Init()
    End Sub

    Private Sub Init()
        BeginInvoke(
            Sub(arg As Form)
                'Start loading map image
                WebBrowser1.ScriptErrorsSuppressed = True
                WebBrowser1.ObjectForScripting = New ScriptCallable


                LoadSensorData()
                LoadLocations()
            End Sub, Me)
    End Sub

    'This will be called by the javascript providing the sensorname
    ' of the clicked marker
    Public Sub MarkerClicked(sensorName As String)
        MsgBox("")
    End Sub

    Sub ShowLogin()
        Dim loginForm = New LoginForm
        BeginInvoke(Sub(arg As Form)
                        loginForm.ShowDialog(arg)
                        If loginForm.IsGuest Then
                            For Each p As TabPage In TabControl1.TabPages
                                If p.Text.ToLower.Contains("overview") <> True Then
                                    TabControl1.TabPages.Remove(p)
                                End If
                            Next
                        End If
                    End Sub, Me)
    End Sub

    Private Sub ImportDataLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ImportDataLinkLabel.LinkClicked
        Dim sensorDatas As New List(Of SensorDataItem)()

        Using ofd As New OpenFileDialog
            ofd.Multiselect = True
            If ofd.ShowDialog() = DialogResult.OK Then
                If ofd.FileNames.Length > 0 Then

                    'Open all selected Files
                    For Each filename In ofd.FileNames
                        sensorDatas.AddRange(SensorDataReader.ReadFileReturnSensorDataList(filename))
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
        BeginInvoke(Sub()
                        Dim filledMap = MapFiller.FillMap(Path.Combine(Application.StartupPath, "map_termplate.html"))
                        WebBrowser1.Url = New Uri(filledMap)
                        WebBrowser1.Refresh()
                    End Sub)
    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged
        If TabControl1.TabPages(TabControl1.TabIndex).Text.ToLower.Contains("overview") Then
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs)
        Dim newLoc As New Location
        With newLoc
            .Barangay = BarangayTextBox.Text
            .Latitude = LatitudeTextBox.Text
            .Longitude = LongitudeTextBox.Text
            .Municipality = MunicipalityTextBox.Text
            .Province = ProvinceTextBox.Text
            .SensorName = ShortNameTextBox.Text
        End With
        Using ctx = New AirQContext
            ctx.Locations.Add(newLoc)
            ctx.SaveChanges()
        End Using
        LoadLocations()
    End Sub



    Sub LoadLocations()
        Using ctx = New AirQContext
            LocationsDataGridView.DataBindings.Clear()
            LocationsDataGridView.DataSource = ctx.Locations.ToList
        End Using
        LoadMap()
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles SaveAccountButton.Click
        Using ctx As New AirQContext
            Dim newAccount = New UserAccount
            newAccount.UserPass = PasswordCopyTextBox.Text
            newAccount.Username = UsernameTextBox.Text
            newAccount.FirstName = FirstNameTextBox.Text
            newAccount.MiddleName = MiddleNameTextBox.Text
            newAccount.LastName = LastNameTextBox.Text
            ctx.UserAccounts.Add(newAccount)
            ctx.SaveChanges()
        End Using
        LoadAccount()
    End Sub

    Sub LoadAccount()

    End Sub

    Private Sub SaveLocationButton_Click(sender As Object, e As EventArgs) Handles SaveLocationButton.Click
        Dim newLoc As New Location
        With newLoc
            .Barangay = BarangayTextBox.Text
            .Latitude = LatitudeTextBox.Text
            .Longitude = LongitudeTextBox.Text
            .Municipality = MunicipalityTextBox.Text
            .Province = ProvinceTextBox.Text
            .SensorName = ShortNameTextBox.Text
        End With
        Using ctx = New AirQContext
            ctx.Locations.Add(newLoc)
            ctx.SaveChanges()
        End Using
        LoadLocations()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        If LocationsDataGridView.SelectedRows.Count <= 0 Then
            MsgBox("Nothing is selected", MsgBoxStyle.Exclamation, "Error")
            Return
        End If
        For Each item As DataGridViewRow In LocationsDataGridView.SelectedRows
            Dim loc = CType(item.DataBoundItem, Location)
            Using ctx = New AirQContext
                Dim itm = ctx.Locations.Find(loc.SensorName)
                ctx.Locations.Remove(itm)
                ctx.SaveChanges()
            End Using
            LoadLocations()
        Next
    End Sub
End Class
