<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocationManager
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.LocationsMetroGrid = New MetroFramework.Controls.MetroGrid()
        Me.LocationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LatitudeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LongitudeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarangayDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MunicipalityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.LocationsMetroGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.MetroLink1)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 253)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(741, 100)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'MetroLink1
        '
        Me.MetroLink1.Location = New System.Drawing.Point(647, 3)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(91, 23)
        Me.MetroLink1.TabIndex = 0
        Me.MetroLink1.Text = "Save Changes"
        Me.MetroLink1.UseSelectable = True
        '
        'LocationsMetroGrid
        '
        Me.LocationsMetroGrid.AllowUserToResizeRows = False
        Me.LocationsMetroGrid.AutoGenerateColumns = False
        Me.LocationsMetroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LocationsMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LocationsMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LocationsMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.LocationsMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LocationsMetroGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.LocationsMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LocationsMetroGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LatitudeDataGridViewTextBoxColumn1, Me.LongitudeDataGridViewTextBoxColumn1, Me.BarangayDataGridViewTextBoxColumn1, Me.MunicipalityDataGridViewTextBoxColumn1, Me.ProvinceDataGridViewTextBoxColumn1, Me.PlaceDataGridViewTextBoxColumn1, Me.IsActiveDataGridViewCheckBoxColumn})
        Me.LocationsMetroGrid.DataSource = Me.LocationBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.LocationsMetroGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.LocationsMetroGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LocationsMetroGrid.EnableHeadersVisualStyles = False
        Me.LocationsMetroGrid.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LocationsMetroGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LocationsMetroGrid.Location = New System.Drawing.Point(0, 0)
        Me.LocationsMetroGrid.Name = "LocationsMetroGrid"
        Me.LocationsMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LocationsMetroGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.LocationsMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.LocationsMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LocationsMetroGrid.Size = New System.Drawing.Size(741, 253)
        Me.LocationsMetroGrid.TabIndex = 1
        '
        'LocationBindingSource
        '
        Me.LocationBindingSource.DataSource = GetType(NAirQMon.Location)
        '
        'LatitudeDataGridViewTextBoxColumn1
        '
        Me.LatitudeDataGridViewTextBoxColumn1.DataPropertyName = "Latitude"
        Me.LatitudeDataGridViewTextBoxColumn1.HeaderText = "Latitude"
        Me.LatitudeDataGridViewTextBoxColumn1.Name = "LatitudeDataGridViewTextBoxColumn1"
        '
        'LongitudeDataGridViewTextBoxColumn1
        '
        Me.LongitudeDataGridViewTextBoxColumn1.DataPropertyName = "Longitude"
        Me.LongitudeDataGridViewTextBoxColumn1.HeaderText = "Longitude"
        Me.LongitudeDataGridViewTextBoxColumn1.Name = "LongitudeDataGridViewTextBoxColumn1"
        '
        'BarangayDataGridViewTextBoxColumn1
        '
        Me.BarangayDataGridViewTextBoxColumn1.DataPropertyName = "Barangay"
        Me.BarangayDataGridViewTextBoxColumn1.HeaderText = "Barangay"
        Me.BarangayDataGridViewTextBoxColumn1.Name = "BarangayDataGridViewTextBoxColumn1"
        '
        'MunicipalityDataGridViewTextBoxColumn1
        '
        Me.MunicipalityDataGridViewTextBoxColumn1.DataPropertyName = "Municipality"
        Me.MunicipalityDataGridViewTextBoxColumn1.HeaderText = "Municipality"
        Me.MunicipalityDataGridViewTextBoxColumn1.Name = "MunicipalityDataGridViewTextBoxColumn1"
        '
        'ProvinceDataGridViewTextBoxColumn1
        '
        Me.ProvinceDataGridViewTextBoxColumn1.DataPropertyName = "Province"
        Me.ProvinceDataGridViewTextBoxColumn1.HeaderText = "Province"
        Me.ProvinceDataGridViewTextBoxColumn1.Name = "ProvinceDataGridViewTextBoxColumn1"
        '
        'PlaceDataGridViewTextBoxColumn1
        '
        Me.PlaceDataGridViewTextBoxColumn1.DataPropertyName = "Place"
        Me.PlaceDataGridViewTextBoxColumn1.HeaderText = "Place"
        Me.PlaceDataGridViewTextBoxColumn1.Name = "PlaceDataGridViewTextBoxColumn1"
        '
        'IsActiveDataGridViewCheckBoxColumn
        '
        Me.IsActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive"
        Me.IsActiveDataGridViewCheckBoxColumn.Name = "IsActiveDataGridViewCheckBoxColumn"
        '
        'LocationManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LocationsMetroGrid)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Name = "LocationManager"
        Me.Size = New System.Drawing.Size(741, 353)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.LocationsMetroGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents LocationsMetroGrid As MetroFramework.Controls.MetroGrid
    Friend WithEvents LocationBindingSource As BindingSource
    Friend WithEvents LatitudeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LongitudeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BarangayDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MunicipalityDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProvinceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PlaceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IsActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
