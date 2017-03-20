<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonitoringPage
    Inherits MetroFramework.Controls.MetroUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AltitudeMetroLabel = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.ReloadMetroButton = New MetroFramework.Controls.MetroButton()
        Me.TheMap = New GMap.NET.WindowsForms.GMapControl()
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.AltitudeMetroTrackBar = New MetroFramework.Controls.MetroTrackBar()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TheMap)
        Me.SplitContainer1.Size = New System.Drawing.Size(710, 672)
        Me.SplitContainer1.SplitterDistance = 258
        Me.SplitContainer1.TabIndex = 3
        '
        'GroupBox3
        '
        Me.MetroStyleExtender1.SetApplyMetroTheme(Me.GroupBox3, True)
        Me.GroupBox3.Controls.Add(Me.MetroLabel1)
        Me.GroupBox3.Controls.Add(Me.AltitudeMetroTrackBar)
        Me.GroupBox3.Controls.Add(Me.AltitudeMetroLabel)
        Me.GroupBox3.Controls.Add(Me.MetroButton2)
        Me.GroupBox3.Controls.Add(Me.ReloadMetroButton)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 672)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'AltitudeMetroLabel
        '
        Me.AltitudeMetroLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AltitudeMetroLabel.AutoSize = True
        Me.AltitudeMetroLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.AltitudeMetroLabel.Location = New System.Drawing.Point(202, 85)
        Me.AltitudeMetroLabel.Name = "AltitudeMetroLabel"
        Me.AltitudeMetroLabel.Size = New System.Drawing.Size(30, 25)
        Me.AltitudeMetroLabel.TabIndex = 28
        Me.AltitudeMetroLabel.Text = "70"
        Me.AltitudeMetroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroButton2
        '
        Me.MetroButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.MetroButton2.Location = New System.Drawing.Point(115, 143)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(117, 40)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroButton2.TabIndex = 22
        Me.MetroButton2.Text = "Start Search"
        Me.MetroButton2.UseSelectable = True
        '
        'ReloadMetroButton
        '
        Me.ReloadMetroButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReloadMetroButton.Location = New System.Drawing.Point(115, 189)
        Me.ReloadMetroButton.Name = "ReloadMetroButton"
        Me.ReloadMetroButton.Size = New System.Drawing.Size(117, 23)
        Me.ReloadMetroButton.TabIndex = 21
        Me.ReloadMetroButton.Text = "Reload Map"
        Me.ReloadMetroButton.UseSelectable = True
        '
        'TheMap
        '
        Me.TheMap.Bearing = 0!
        Me.TheMap.CanDragMap = True
        Me.TheMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TheMap.EmptyTileColor = System.Drawing.Color.Navy
        Me.TheMap.GrayScaleMode = False
        Me.TheMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.TheMap.LevelsKeepInMemmory = 5
        Me.TheMap.Location = New System.Drawing.Point(0, 0)
        Me.TheMap.MarkersEnabled = True
        Me.TheMap.MaxZoom = 17
        Me.TheMap.MinZoom = 2
        Me.TheMap.MouseWheelZoomEnabled = True
        Me.TheMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.TheMap.Name = "TheMap"
        Me.TheMap.NegativeMode = False
        Me.TheMap.PolygonsEnabled = True
        Me.TheMap.RetryLoadTile = 0
        Me.TheMap.RoutesEnabled = True
        Me.TheMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.TheMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TheMap.ShowTileGridLines = False
        Me.TheMap.Size = New System.Drawing.Size(448, 672)
        Me.TheMap.TabIndex = 0
        Me.TheMap.Zoom = 16.0R
        '
        'AltitudeMetroTrackBar
        '
        Me.AltitudeMetroTrackBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AltitudeMetroTrackBar.BackColor = System.Drawing.Color.Transparent
        Me.AltitudeMetroTrackBar.LargeChange = 10
        Me.AltitudeMetroTrackBar.Location = New System.Drawing.Point(6, 37)
        Me.AltitudeMetroTrackBar.Maximum = 7
        Me.AltitudeMetroTrackBar.Minimum = 1
        Me.AltitudeMetroTrackBar.Name = "AltitudeMetroTrackBar"
        Me.AltitudeMetroTrackBar.Size = New System.Drawing.Size(246, 23)
        Me.AltitudeMetroTrackBar.SmallChange = 10
        Me.AltitudeMetroTrackBar.TabIndex = 29
        Me.AltitudeMetroTrackBar.Text = "AltitudeMetroTrackBar"
        Me.AltitudeMetroTrackBar.Value = 7
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(21, 85)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(159, 25)
        Me.MetroLabel1.TabIndex = 30
        Me.MetroLabel1.Text = "ALTITUDE (meters) :"
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonitoringPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "MonitoringPage"
        Me.Size = New System.Drawing.Size(710, 672)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TheMap As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents ReloadMetroButton As MetroFramework.Controls.MetroButton

    Friend WithEvents AltitudeMetroLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents AltitudeMetroTrackBar As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
