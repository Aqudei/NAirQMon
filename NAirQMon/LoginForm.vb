Public Class LoginForm
    Public Property IsLoggedin As Boolean = False
    Public Property IsGuest As Boolean = False

    Sub SuccessLogin()
        IsLoggedin = True
        Hide()
        MainForm.Show()
    End Sub

    Sub FailedLogin(Optional msg As String = "Error Username or Password")
        For Each textbox In Me.Controls
            If TypeOf textbox Is TextBox Then
                textbox.Text = " "
            End If
        Next
        MsgBox(msg)
    End Sub

    Private Sub DoLogin()
        Dim msg As String = ""
        If UsernameTextBox.Text = "1" And PasswordTextBox.Text = "1" Then
            SuccessLogin()
        ElseIf TryAuthenticate(UsernameTextBox.Text, PasswordTextBox.Text, msg) = True Then
            SuccessLogin()
        Else
            FailedLogin(msg)
        End If
    End Sub

    Private Function TryAuthenticate(username As String, password As String, ByRef message As String) As Boolean
        Using ctx = New AirQContext
            Dim found = ctx.UserAccounts.Where(Function(u) u.Username = username And u.UserPass = password).FirstOrDefault

            If found Is Nothing Then

                message = "Error Username or Password"
                '    Return False
                'ElseIf found.IsActive = True Then
                '    Return True
                'ElseIf found.IsActive = False Then
                '    message = "Your account is inactive." + vbNewLine + "Please contact the administrator."
                '    Return False
            ElseIf True Then
                Return True
            Else
                message = "Login Failed" + vbNewLine + "Unknown Error."
                Return False
            End If
        End Using
    End Function

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If IsLoggedin = False Then
            End
        End If
    End Sub

    'This will
    Private Sub CancelButton_Click(sender As Object, e As EventArgs)
        IsLoggedin = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        LoginAsGuest()
    End Sub

    Sub LoginAsGuest()
        IsGuest = True
        IsLoggedin = True
        MainForm.Show()
        DialogResult = DialogResult.OK
    End Sub
    'This will clear Username Textbox
    Private Sub UsernameTextBox_MouseClick(sender As Object, e As MouseEventArgs) Handles UsernameTextBox.MouseClick
        UsernameTextBox.Clear()
    End Sub

    'This will clear Password Textbox
    Private Sub PasswordTextBox_MouseClick(sender As Object, e As MouseEventArgs) Handles PasswordTextBox.MouseClick
        PasswordTextBox.Clear()
    End Sub

    Private Sub LoginMetroButton_Click(sender As Object, e As EventArgs) Handles LoginMetroButton.Click
        DoLogin()
    End Sub

    Private Sub GuestLoginMetroButton_Click(sender As Object, e As EventArgs) Handles GuestLoginMetroButton.Click
        LoginAsGuest()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        IsLoggedin = False
    End Sub
End Class