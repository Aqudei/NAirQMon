Public Class LoginForm
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UsernameTextBox.Text = "1" And PasswordTextBox.Text = "1" Then
            Close()
        End If
    End Sub
End Class