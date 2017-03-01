Public Class LoginForm
    Public Property IsLoggedin As Boolean = False
    Public Property IsGuest As Boolean = False

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameTextBox.Text = "1" And PasswordTextBox.Text = "1" Then
            IsLoggedin = True
            Hide()
            MainForm.Show()
        Else
            Dim textbox As Control
            For Each textbox In Me.Controls
                If TypeOf textbox Is TextBox Then
                    textbox.Text = Nothing
                End If
            Next
            MsgBox("Error Username or Password")

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles LoginAsButton.Click
        IsGuest = True
        IsLoggedin = True
        MainForm.Show()
        DialogResult = DialogResult.OK
    End Sub

    Private Sub UsernameTextBox_MouseClick(sender As Object, e As MouseEventArgs) Handles UsernameTextBox.MouseClick
        UsernameTextBox.Clear()
    End Sub

    Private Sub PasswordTextBox_MouseClick(sender As Object, e As MouseEventArgs) Handles PasswordTextBox.MouseClick
        PasswordTextBox.Clear()
    End Sub
End Class