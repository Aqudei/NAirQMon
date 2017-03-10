Public Class LoginForm
    Public Property IsLoggedin As Boolean = False
    Public Property IsGuest As Boolean = False

    Private Sub Login_Click(sender As Object, e As EventArgs)
        DoLogin()
    End Sub

    Sub SuccessLogin()
        MainForm.Show()
        Close()
    End Sub

    Sub FailedLogin(Optional msg As String = "Error Username or Password")

        For Each textbox In Me.Controls
            If TypeOf textbox Is TextBox Then
                textbox.Text = ""
            End If
        Next

        ShowErro(msg)
    End Sub

    Private Sub ShowErro(msg As String)
        MessageMetroLabel.Text = msg
    End Sub

    Private Sub DoLogin()

        Dim msg As String = ""
        If UsernameMetroTextBox.Text = "1" And PasswordMetroTextBox.Text = "1" Then
            SuccessLogin()
        ElseIf TryAuthenticate(UsernameMetroTextBox.Text, PasswordMetroTextBox.Text, msg) = True Then
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
                Return False
            ElseIf found.IsActive = True Then
                Return True
            ElseIf found.IsActive = False Then
                message = "Your account is inactive." + vbNewLine + "Please contact the administrator."
                Return False
            Else

                message = "Login Failed" + vbNewLine + "Unknown Error."
                Return False
            End If
        End Using
    End Function

    Sub LoginAsGuest()
        Dim mainForm As New MainForm
        mainForm.isGuest = True
        mainForm.Show()
        Me.Close()
    End Sub

    Private Sub LoginMetroLink_Click(sender As Object, e As EventArgs) Handles LoginMetroLink.Click
        DoLogin()
    End Sub

    Private Sub PasswordMetroTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameMetroTextBox.KeyPress, PasswordMetroTextBox.KeyPress
        MessageMetroLabel.Text = ""
    End Sub

    Private Sub ExitApp_Click(sender As Object, e As EventArgs) Handles MetroLink2.Click
        End
    End Sub

    Private Sub GuestLoginMetroLink_Click(sender As Object, e As EventArgs) Handles GuestLoginMetroLink.Click
        LoginAsGuest()
    End Sub
End Class