Public Class LoginForm
    Public Property IsLoggedin As Boolean = False

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UsernameTextBox.Text = "1" And PasswordTextBox.Text = "1" Then
            IsLoggedin = True
            Close()
        End If
    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If IsLoggedin = False Then
            End
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        IsLoggedin = False
    End Sub
End Class