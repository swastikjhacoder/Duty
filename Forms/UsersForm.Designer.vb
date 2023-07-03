<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsersForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.EGroupBox1 = New ESAR_Controls.UIControls.GroupBox.eGroupBox()
        Me.Us_grid = New Duty.DGV_Empty.DataGrid()
        Me.EGroupBox1.SuspendLayout()
        CType(Me.Us_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.Us_grid)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "Number of Users :"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(502, 342)
        Me.EGroupBox1.TabIndex = 0
        '
        'Us_grid
        '
        Me.Us_grid.AllowUserToAddRows = False
        Me.Us_grid.AllowUserToDeleteRows = False
        Me.Us_grid.AllowUserToResizeColumns = False
        Me.Us_grid.AllowUserToResizeRows = False
        Me.Us_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Us_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Us_grid.DisplaySumRowHeader = False
        Me.Us_grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Us_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.Us_grid.EmptyDataText = ""
        Me.Us_grid.EmptyDataTextHorizontalAlign = Duty.DGV_Empty.DataGrid.HorizontalAlign.Left
        Me.Us_grid.EmptyDataTextLocationX = 0.0!
        Me.Us_grid.EmptyDataTextLocationY = 0.0!
        Me.Us_grid.EmptyDataTextVerticalAlign = Duty.DGV_Empty.DataGrid.VerticalAlign.Top
        Me.Us_grid.Location = New System.Drawing.Point(10, 25)
        Me.Us_grid.MultiSelect = False
        Me.Us_grid.Name = "Us_grid"
        Me.Us_grid.ReadOnly = True
        Me.Us_grid.RowHeadersVisible = False
        Me.Us_grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Us_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Us_grid.Size = New System.Drawing.Size(482, 307)
        Me.Us_grid.SummaryColumns = Nothing
        Me.Us_grid.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.Us_grid.SummaryRowSpace = 0
        Me.Us_grid.SummaryRowVisible = False
        Me.Us_grid.SumRowHeaderText = Nothing
        Me.Us_grid.SumRowHeaderTextBold = False
        Me.Us_grid.TabIndex = 0
        '
        'UsersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(502, 342)
        Me.ControlBox = False
        Me.Controls.Add(Me.EGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UsersForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "User"
        Me.EGroupBox1.ResumeLayout(False)
        CType(Me.Us_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents Us_grid As Duty.DGV_Empty.DataGrid
End Class
