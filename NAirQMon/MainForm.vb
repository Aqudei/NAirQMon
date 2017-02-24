﻿Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowLogin()
    End Sub

    Sub ShowLogin()
        Dim loginForm = New LoginForm

        BeginInvoke(Sub(arg)
                        loginForm.ShowDialog(arg)
                    End Sub, Me)
    End Sub

    Private Sub ImportDataLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ImportDataLinkLabel.LinkClicked
        Using ofd As New OpenFileDialog
            ofd.Multiselect = True
            If ofd.ShowDialog() = DialogResult.OK Then
                If ofd.FileNames.Length > 0 Then
                    'Open File Here

                End If
            End If
        End Using
    End Sub
End Class
