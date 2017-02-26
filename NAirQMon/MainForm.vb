Imports System.IO


Public Class MainForm



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SendToBack()

        ShowLogin()

        Init()
    End Sub

    Private Sub Init()

        BeginInvoke(
            Sub(arg As Form)

                'Start loading map image
                WebBrowser1.ScriptErrorsSuppressed = True
                WebBrowser1.ObjectForScripting = New ScriptCallable
                Dim filledMap = MapFiller.FillMap(Path.Combine(Application.StartupPath, "map_termplate.html"))
                WebBrowser1.Url = New Uri(filledMap)
                WebBrowser1.Refresh()
                LoadSensorData()
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
        Using ofd As New OpenFileDialog
            ofd.Multiselect = True
            If ofd.ShowDialog() = DialogResult.OK Then
                If ofd.FileNames.Length > 0 Then
                    'Open File Here
                    Dim sensorDatas = SensorDataReader.ReadFileReturnSensorDataList(ofd.FileNames(0))

                    Using importForm As New ImportSensorDataForm
                        importForm.TempSenseDataDataGridView.DataSource = sensorDatas
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
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SensorDataDataGridView.CellContentClick

    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.TabIndexChanged
        If TabControl1.TabPages(TabControl1.TabIndex).Text.ToLower.Contains("overview") Then

        End If
    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub
End Class
