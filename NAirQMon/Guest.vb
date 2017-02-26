Imports System.IO
Imports NAirQMon.MainForm

Public Class Guest
    Private Sub Guest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BeginInvoke(
           Sub(arg As Form)

               'Start loading map image
               WebBrowser2.ScriptErrorsSuppressed = True
               WebBrowser2.ObjectForScripting = New ScriptCallable
               WebBrowser2.Url = New Uri(Path.Combine(Application.StartupPath, "map.html"))
               WebBrowser2.Refresh()


           End Sub, Me)
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim response As MsgBoxResult
        response = MsgBox("Do you want to close?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
            MainForm.Close()
        ElseIf response = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub
End Class