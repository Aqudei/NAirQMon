Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.LocationMgmtTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MetroGrid1 = New NAirQMon.MetroGrid()
        Me.LocationsDataGridView = New MetroFramework.Controls.MetroGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataMgmtTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SensorDataDataGridView = New MetroFramework.Controls.MetroGrid()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ImportDataLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.MonitoringTabPage = New MetroFramework.Controls.MetroTabPage()
        Me.MonitoringPage1 = New NAirQMon.MonitoringPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.AccountManager1 = New NAirQMon.AccountManager()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.LocationManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationManagerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.LocationMgmtTabPage.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.LocationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataMgmtTabPage.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SensorDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MonitoringTabPage.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.LocationManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationManagerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.LocationMgmtTabPage)
        Me.TabControl1.Controls.Add(Me.DataMgmtTabPage)
        Me.TabControl1.Controls.Add(Me.MonitoringTabPage)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(20, 60)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 2
        Me.TabControl1.Size = New System.Drawing.Size(744, 630)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.UseSelectable = True
        '
        'LocationMgmtTabPage
        '
        Me.LocationMgmtTabPage.Controls.Add(Me.Panel3)
        Me.LocationMgmtTabPage.HorizontalScrollbarBarColor = True
        Me.LocationMgmtTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.LocationMgmtTabPage.HorizontalScrollbarSize = 10
        Me.LocationMgmtTabPage.Location = New System.Drawing.Point(4, 38)
        Me.LocationMgmtTabPage.Name = "LocationMgmtTabPage"
        Me.LocationMgmtTabPage.Padding = New System.Windows.Forms.Padding(10)
        Me.LocationMgmtTabPage.Size = New System.Drawing.Size(736, 588)
        Me.LocationMgmtTabPage.TabIndex = 3
        Me.LocationMgmtTabPage.Text = "Location Management"
        Me.LocationMgmtTabPage.UseVisualStyleBackColor = True
        Me.LocationMgmtTabPage.VerticalScrollbarBarColor = True
        Me.LocationMgmtTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.LocationMgmtTabPage.VerticalScrollbarSize = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.MetroGrid1)
        Me.Panel3.Controls.Add(Me.LocationsDataGridView)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(10, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(716, 568)
        Me.Panel3.TabIndex = 1
        '
        'MetroGrid1
        '
        Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid1.Location = New System.Drawing.Point(0, 20)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.Size = New System.Drawing.Size(716, 548)
        Me.MetroGrid1.TabIndex = 6
        Me.MetroGrid1.UseSelectable = True
        '
        'LocationsDataGridView
        '
        Me.LocationsDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.LocationsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.LocationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LocationsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LocationsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LocationsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.LocationsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LocationsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.LocationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LocationsDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.LocationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocationsDataGridView.EnableHeadersVisualStyles = False
        Me.LocationsDataGridView.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LocationsDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LocationsDataGridView.Location = New System.Drawing.Point(0, 20)
        Me.LocationsDataGridView.Name = "LocationsDataGridView"
        Me.LocationsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LocationsDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.LocationsDataGridView.RowHeadersWidth = 10
        Me.LocationsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.LocationsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LocationsDataGridView.Size = New System.Drawing.Size(716, 548)
        Me.LocationsDataGridView.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Location List"
        '
        'DataMgmtTabPage
        '
        Me.DataMgmtTabPage.Controls.Add(Me.Panel1)
        Me.DataMgmtTabPage.HorizontalScrollbarBarColor = True
        Me.DataMgmtTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.DataMgmtTabPage.HorizontalScrollbarSize = 10
        Me.DataMgmtTabPage.Location = New System.Drawing.Point(4, 38)
        Me.DataMgmtTabPage.Name = "DataMgmtTabPage"
        Me.DataMgmtTabPage.Padding = New System.Windows.Forms.Padding(10)
        Me.DataMgmtTabPage.Size = New System.Drawing.Size(736, 588)
        Me.DataMgmtTabPage.TabIndex = 1
        Me.DataMgmtTabPage.Text = "Data Management"
        Me.DataMgmtTabPage.UseVisualStyleBackColor = True
        Me.DataMgmtTabPage.VerticalScrollbarBarColor = True
        Me.DataMgmtTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.DataMgmtTabPage.VerticalScrollbarSize = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ImportDataLinkLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(716, 568)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SensorDataDataGridView)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(5, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(706, 545)
        Me.Panel2.TabIndex = 2
        '
        'SensorDataDataGridView
        '
        Me.SensorDataDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.SensorDataDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.SensorDataDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SensorDataDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SensorDataDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SensorDataDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SensorDataDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.SensorDataDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SensorDataDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.SensorDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SensorDataDataGridView.DefaultCellStyle = DataGridViewCellStyle7
        Me.SensorDataDataGridView.EnableHeadersVisualStyles = False
        Me.SensorDataDataGridView.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.SensorDataDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SensorDataDataGridView.Location = New System.Drawing.Point(10, 9)
        Me.SensorDataDataGridView.Name = "SensorDataDataGridView"
        Me.SensorDataDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SensorDataDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.SensorDataDataGridView.RowHeadersWidth = 10
        Me.SensorDataDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.SensorDataDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SensorDataDataGridView.Size = New System.Drawing.Size(576, 526)
        Me.SensorDataDataGridView.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button2.Location = New System.Drawing.Point(612, 338)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ImportDataLinkLabel
        '
        Me.ImportDataLinkLabel.AutoSize = True
        Me.ImportDataLinkLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImportDataLinkLabel.Location = New System.Drawing.Point(5, 5)
        Me.ImportDataLinkLabel.Margin = New System.Windows.Forms.Padding(10)
        Me.ImportDataLinkLabel.Name = "ImportDataLinkLabel"
        Me.ImportDataLinkLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ImportDataLinkLabel.Size = New System.Drawing.Size(62, 13)
        Me.ImportDataLinkLabel.TabIndex = 1
        Me.ImportDataLinkLabel.TabStop = True
        Me.ImportDataLinkLabel.Text = "Import Data"
        Me.ImportDataLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonitoringTabPage
        '
        Me.MonitoringTabPage.Controls.Add(Me.MonitoringPage1)
        Me.MonitoringTabPage.HorizontalScrollbarBarColor = True
        Me.MonitoringTabPage.HorizontalScrollbarHighlightOnWheel = False
        Me.MonitoringTabPage.HorizontalScrollbarSize = 10
        Me.MonitoringTabPage.Location = New System.Drawing.Point(4, 38)
        Me.MonitoringTabPage.Name = "MonitoringTabPage"
        Me.MonitoringTabPage.Padding = New System.Windows.Forms.Padding(10)
        Me.MonitoringTabPage.Size = New System.Drawing.Size(736, 588)
        Me.MonitoringTabPage.TabIndex = 2
        Me.MonitoringTabPage.Text = "Monitoring"
        Me.MonitoringTabPage.UseVisualStyleBackColor = True
        Me.MonitoringTabPage.VerticalScrollbarBarColor = True
        Me.MonitoringTabPage.VerticalScrollbarHighlightOnWheel = False
        Me.MonitoringTabPage.VerticalScrollbarSize = 10
        '
        'MonitoringPage1
        '
        Me.MonitoringPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonitoringPage1.Location = New System.Drawing.Point(10, 10)
        Me.MonitoringPage1.Name = "MonitoringPage1"
        Me.MonitoringPage1.Size = New System.Drawing.Size(716, 568)
        Me.MonitoringPage1.TabIndex = 2
        Me.MonitoringPage1.UseSelectable = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.AccountManager1)
        Me.TabPage5.Controls.Add(Me.Label20)
        Me.TabPage5.Location = New System.Drawing.Point(4, 38)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(736, 588)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Account Management"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'AccountManager1
        '
        Me.AccountManager1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccountManager1.Location = New System.Drawing.Point(0, 20)
        Me.AccountManager1.Name = "AccountManager1"
        Me.AccountManager1.Size = New System.Drawing.Size(736, 568)
        Me.AccountManager1.TabIndex = 4
        Me.AccountManager1.UseSelectable = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(0, 0)
        Me.Label20.Margin = New System.Windows.Forms.Padding(3)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(109, 20)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Account List"
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.Location = New System.Drawing.Point(674, 31)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 1
        Me.MetroButton1.Text = "Log out"
        Me.MetroButton1.UseSelectable = True
        '
        'LocationManagerBindingSource
        '
        Me.LocationManagerBindingSource.DataSource = GetType(NAirQMon.LocationManager)
        '
        'LocationManagerBindingSource1
        '
        Me.LocationManagerBindingSource1.DataSource = GetType(NAirQMon.LocationManager)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 710)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.TabControl1)
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "AirQualityIndex"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.LocationMgmtTabPage.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.LocationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataMgmtTabPage.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.SensorDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MonitoringTabPage.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.LocationManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationManagerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataMgmtTabPage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ImportDataLinkLabel As LinkLabel
    Friend WithEvents MonitoringTabPage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents AccountManager1 As AccountManager
    Friend WithEvents LocationsDataGridView As MetroFramework.Controls.MetroGrid
    Friend WithEvents SensorDataDataGridView As MetroFramework.Controls.MetroGrid
    Friend WithEvents TabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents LocationMgmtTabPage As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MonitoringPage1 As MonitoringPage
    Friend WithEvents LocationManagerBindingSource As BindingSource
    Friend WithEvents LocationManagerBindingSource1 As BindingSource
    Friend WithEvents MetroGrid1 As MetroGrid
    Friend WithEvents MetroButton1 As MetroButton
End Class
