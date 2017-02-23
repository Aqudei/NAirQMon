Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowLogin()
    End Sub

    Sub ShowLogin()
        Dim loginForm = New LoginForm

        BeginInvoke(Sub(arg)
                        loginForm.ShowDialog(arg)
                    End Sub, Me)
    End Sub
End Class
