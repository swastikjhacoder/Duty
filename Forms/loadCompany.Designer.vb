<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loadCompany
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
        Me.cm_datagrd = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EGroupBox1.SuspendLayout()
        CType(Me.cm_datagrd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.cm_datagrd)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "Companies"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(284, 256)
        Me.EGroupBox1.TabIndex = 0
        '
        'cm_datagrd
        '
        Me.cm_datagrd.AllowUserToAddRows = False
        Me.cm_datagrd.AllowUserToDeleteRows = False
        Me.cm_datagrd.AllowUserToResizeColumns = False
        Me.cm_datagrd.AllowUserToResizeRows = False
        Me.cm_datagrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cm_datagrd.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.cm_datagrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cm_datagrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cm_datagrd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.cm_datagrd.Location = New System.Drawing.Point(10, 25)
        Me.cm_datagrd.MultiSelect = False
        Me.cm_datagrd.Name = "cm_datagrd"
        Me.cm_datagrd.ReadOnly = True
        Me.cm_datagrd.RowHeadersVisible = False
        Me.cm_datagrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cm_datagrd.Size = New System.Drawing.Size(264, 221)
        Me.cm_datagrd.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EGroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ERoundedPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(481, 256)
        Me.SplitContainer1.SplitterDistance = 284
        Me.SplitContainer1.TabIndex = 1
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.Label5)
        Me.ERoundedPanel1.Controls.Add(Me.Label4)
        Me.ERoundedPanel1.Controls.Add(Me.Label3)
        Me.ERoundedPanel1.Controls.Add(Me.Label2)
        Me.ERoundedPanel1.Controls.Add(Me.Label1)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(193, 256)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Edit Company: Ctrl + E"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Company: Ctrl + N"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Open Company: Ctrl + O"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Delete Company: Shift + Del"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Close Duty : Esc"
        '
        'loadCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(481, 256)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loadCompany"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Duty"
        Me.EGroupBox1.ResumeLayout(False)
        CType(Me.cm_datagrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents cm_datagrd As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
