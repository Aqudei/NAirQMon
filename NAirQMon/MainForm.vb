Imports System.IO


Public Class MainForm

    <System.Runtime.InteropServices.ComVisible(True)>
    Public Class ScriptCallable
        Public Sub MarkerClicked(sensorName As String)
            Debug.WriteLine(sensorName)
        End Sub

    End Class

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SendToBack()

        ShowLogin()

        Init()

        LoadSensorData()
    End Sub

    Private Sub Init()

        BeginInvoke(Sub(arg As Form)
                        WebBrowser1.ScriptErrorsSuppressed = True
                        WebBrowser1.ObjectForScripting = New ScriptCallable
                        WebBrowser1.Url = New Uri(Path.Combine(Application.StartupPath, "map.html"))
                        WebBrowser1.Refresh()

                        LoadSensorData()
                    End Sub, Me)
    End Sub

    Public Sub MarkerClicked(sensorName As Stream)
        MsgBox("")
    End Sub

    Sub ShowLogin()
        Dim loginForm = New LoginForm

        BeginInvoke(Sub(arg As Form)
                        loginForm.ShowDialog(arg)
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
