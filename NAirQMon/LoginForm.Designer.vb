<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LoginMetroLink = New MetroFramework.Controls.MetroLink()
        Me.UsernameMetroTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.PasswordMetroTextBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.MessageMetroLabel = New MetroFramework.Controls.MetroLabel()
        Me.GuestLoginMetroLink = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'LoginMetroLink
        '
        Me.LoginMetroLink.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.LoginMetroLink.Location = New System.Drawing.Point(159, 216)
        Me.LoginMetroLink.Name = "LoginMetroLink"
        Me.LoginMetroLink.Size = New System.Drawing.Size(95, 54)
        Me.LoginMetroLink.TabIndex = 0
        Me.LoginMetroLink.Text = "Login"
        Me.LoginMetroLink.UseSelectable = True
        '
        'UsernameMetroTextBox
        '
        '
        '
        '
        Me.UsernameMetroTextBox.CustomButton.Image = Nothing
        Me.UsernameMetroTextBox.CustomButton.Location = New System.Drawing.Point(364, 2)
        Me.UsernameMetroTextBox.CustomButton.Name = ""
        Me.UsernameMetroTextBox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.UsernameMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.UsernameMetroTextBox.CustomButton.TabIndex = 1
        Me.UsernameMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.UsernameMetroTextBox.CustomButton.UseSelectable = True
        Me.UsernameMetroTextBox.CustomButton.Visible = False
        Me.UsernameMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.UsernameMetroTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.UsernameMetroTextBox.Lines = New String(-1) {}
        Me.UsernameMetroTextBox.Location = New System.Drawing.Point(37, 104)
        Me.UsernameMetroTextBox.MaxLength = 32767
        Me.UsernameMetroTextBox.Name = "UsernameMetroTextBox"
        Me.UsernameMetroTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameMetroTextBox.PromptText = "Enter username"
        Me.UsernameMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.UsernameMetroTextBox.SelectedText = ""
        Me.UsernameMetroTextBox.SelectionLength = 0
        Me.UsernameMetroTextBox.SelectionStart = 0
        Me.UsernameMetroTextBox.ShortcutsEnabled = True
        Me.UsernameMetroTextBox.Size = New System.Drawing.Size(402, 40)
        Me.UsernameMetroTextBox.TabIndex = 1
        Me.UsernameMetroTextBox.UseSelectable = True
        Me.UsernameMetroTextBox.WaterMark = "Enter username"
        Me.UsernameMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.UsernameMetroTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PasswordMetroTextBox
        '
        '
        '
        '
        Me.PasswordMetroTextBox.CustomButton.Image = Nothing
        Me.PasswordMetroTextBox.CustomButton.Location = New System.Drawing.Point(364, 2)
        Me.PasswordMetroTextBox.CustomButton.Name = ""
        Me.PasswordMetroTextBox.CustomButton.Size = New System.Drawing.Size(35, 35)
        Me.PasswordMetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PasswordMetroTextBox.CustomButton.TabIndex = 1
        Me.PasswordMetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PasswordMetroTextBox.CustomButton.UseSelectable = True
        Me.PasswordMetroTextBox.CustomButton.Visible = False
        Me.PasswordMetroTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.PasswordMetroTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.PasswordMetroTextBox.Lines = New String(-1) {}
        Me.PasswordMetroTextBox.Location = New System.Drawing.Point(37, 160)
        Me.PasswordMetroTextBox.MaxLength = 32767
        Me.PasswordMetroTextBox.Name = "PasswordMetroTextBox"
        Me.PasswordMetroTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordMetroTextBox.PromptText = "Enter Password"
        Me.PasswordMetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PasswordMetroTextBox.SelectedText = ""
        Me.PasswordMetroTextBox.SelectionLength = 0
        Me.PasswordMetroTextBox.SelectionStart = 0
        Me.PasswordMetroTextBox.ShortcutsEnabled = True
        Me.PasswordMetroTextBox.Size = New System.Drawing.Size(402, 40)
        Me.PasswordMetroTextBox.TabIndex = 2
        Me.PasswordMetroTextBox.UseSelectable = True
        Me.PasswordMetroTextBox.WaterMark = "Enter Password"
        Me.PasswordMetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PasswordMetroTextBox.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLink2
        '
        Me.MetroLink2.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink2.Location = New System.Drawing.Point(36, 216)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(95, 54)
        Me.MetroLink2.TabIndex = 3
        Me.MetroLink2.Text = "Exit"
        Me.MetroLink2.UseSelectable = True
        '
        'MessageMetroLabel
        '
        Me.MessageMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MessageMetroLabel.ForeColor = System.Drawing.Color.DarkRed
        Me.MessageMetroLabel.Location = New System.Drawing.Point(-2, 273)
        Me.MessageMetroLabel.Name = "MessageMetroLabel"
        Me.MessageMetroLabel.Size = New System.Drawing.Size(476, 84)
        Me.MessageMetroLabel.TabIndex = 4
        Me.MessageMetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MessageMetroLabel.UseCustomForeColor = True
        '
        'GuestLoginMetroLink
        '
        Me.GuestLoginMetroLink.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.GuestLoginMetroLink.Location = New System.Drawing.Point(291, 216)
        Me.GuestLoginMetroLink.Name = "GuestLoginMetroLink"
        Me.GuestLoginMetroLink.Size = New System.Drawing.Size(148, 54)
        Me.GuestLoginMetroLink.TabIndex = 5
        Me.GuestLoginMetroLink.Text = "Login As Guest"
        Me.GuestLoginMetroLink.UseSelectable = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NAirQMon.My.Resources.Resources._12
        Me.ClientSize = New System.Drawing.Size(474, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.GuestLoginMetroLink)
        Me.Controls.Add(Me.MessageMetroLabel)
        Me.Controls.Add(Me.MetroLink2)
        Me.Controls.Add(Me.PasswordMetroTextBox)
        Me.Controls.Add(Me.UsernameMetroTextBox)
        Me.Controls.Add(Me.LoginMetroLink)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginMetroLink As MetroFramework.Controls.MetroLink
    Friend WithEvents UsernameMetroTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PasswordMetroTextBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents MessageMetroLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents GuestLoginMetroLink As MetroFramework.Controls.MetroLink
End Class
