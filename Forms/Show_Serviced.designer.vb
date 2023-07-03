<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_Serviced
    Inherits ESAR_Controls.UIControls.eForms.eFadeGradientForm

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
        Me.EAppearanceControl1 = New ESAR_Controls.Appearance.eAppearanceControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Show_Search_Panel = New ESAR_Controls.UIControls.GroupBox.eGroupBox()
        Me.S_Prod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.S_Clear = New System.Windows.Forms.Button()
        Me.S_Search = New System.Windows.Forms.Button()
        Me.S_Month = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.S_List_Box = New ESAR_Controls.UIControls.GroupBox.eGroupBox()
        Me.S_DataGrd = New Duty.DGV_Empty.DataGrid()
        Me.Cid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.doi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cph = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serviced = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.feed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Refresh = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Show_Search_Panel.SuspendLayout()
        Me.S_List_Box.SuspendLayout()
        CType(Me.S_DataGrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EAppearanceControl1
        '
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intBackground = -16273
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intBorderHighlight = -13410648
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientBegin = -8294
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientEnd = -22964
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intGradientMiddle = -15500
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intHighlight = -3878683
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intPressedBackground = -98242
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.CheckedAppearance.intSelectedBackground = -98242
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intBorder = -16777088
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intBorderHighlight = -13410648
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientBegin = -98242
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientEnd = -8294
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intGradientMiddle = -20115
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.PressedAppearance.intHighlight = -6771246
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.BorderHighlight = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intBorder = -16777088
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intBorderHighlight = -16777088
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientBegin = -34
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientEnd = -13432
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intGradientMiddle = -7764
        Me.EAppearanceControl1.CustomAppearance.ButtonAppearance.SelectedAppearance.intHighlight = -3878683
        Me.EAppearanceControl1.CustomAppearance.GripAppearance.intDark = -14204554
        Me.EAppearanceControl1.CustomAppearance.GripAppearance.intLight = -1
        Me.EAppearanceControl1.CustomAppearance.GripAppearance.Light = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Normal.intGradientBegin = -1839105
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Normal.intGradientEnd = -8674080
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Normal.intGradientMiddle = -3415556
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Revealed.intGradientBegin = -3416586
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Revealed.intGradientEnd = -9266217
        Me.EAppearanceControl1.CustomAppearance.ImageMarginAppearance.Revealed.intGradientMiddle = -6175239
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.Border = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intBorder = -16777088
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intPressedGradientBegin = -1839105
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intPressedGradientEnd = -8674080
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intPressedGradientMiddle = -6175239
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intSelected = -4414
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intSelectedGradientBegin = -34
        Me.EAppearanceControl1.CustomAppearance.MenuItemAppearance.intSelectedGradientEnd = -13432
        Me.EAppearanceControl1.CustomAppearance.MenuStripAppearance.intBorder = -16765546
        Me.EAppearanceControl1.CustomAppearance.MenuStripAppearance.intGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.MenuStripAppearance.intGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.OverflowButtonAppearance.intGradientBegin = -8408582
        Me.EAppearanceControl1.CustomAppearance.OverflowButtonAppearance.intGradientEnd = -16763503
        Me.EAppearanceControl1.CustomAppearance.OverflowButtonAppearance.intGradientMiddle = -11370544
        Me.EAppearanceControl1.CustomAppearance.RaftingContainerAppearance.intGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.RaftingContainerAppearance.intGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.SeparatorAppearance.intDark = -9794357
        Me.EAppearanceControl1.CustomAppearance.SeparatorAppearance.intLight = -919041
        Me.EAppearanceControl1.CustomAppearance.StatusStripAppearance.intGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.StatusStripAppearance.intGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intBorder = -12885604
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intContentPanelGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intContentPanelGradientEnd = -3876102
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intDropDownBackground = -592138
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intGradientBegin = -1839105
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intGradientEnd = -8674080
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intGradientMiddle = -3415556
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intPanelGradientBegin = -6373643
        Me.EAppearanceControl1.CustomAppearance.ToolStripAppearance.intPanelGradientEnd = -3876102
        Me.EAppearanceControl1.Preset = ESAR_Controls.Appearance.eAppearanceControl.enumPresetStyles.Custom
        Me.EAppearanceControl1.Renderer.RoundedEdges = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Show_Search_Panel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.S_List_Box)
        Me.SplitContainer1.Size = New System.Drawing.Size(956, 499)
        Me.SplitContainer1.SplitterDistance = 60
        Me.SplitContainer1.TabIndex = 8
        '
        'Show_Search_Panel
        '
        Me.Show_Search_Panel.BackgroundColor = System.Drawing.Color.LightGray
        Me.Show_Search_Panel.BackgroundGradientColor = System.Drawing.Color.White
        Me.Show_Search_Panel.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.Show_Search_Panel.BorderColor = System.Drawing.Color.Black
        Me.Show_Search_Panel.BorderThickness = 1.0!
        Me.Show_Search_Panel.Controls.Add(Me.S_Prod)
        Me.Show_Search_Panel.Controls.Add(Me.Label1)
        Me.Show_Search_Panel.Controls.Add(Me.S_Clear)
        Me.Show_Search_Panel.Controls.Add(Me.S_Search)
        Me.Show_Search_Panel.Controls.Add(Me.S_Month)
        Me.Show_Search_Panel.Controls.Add(Me.Label2)
        Me.Show_Search_Panel.CustomGroupBoxColor = System.Drawing.Color.White
        Me.Show_Search_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Show_Search_Panel.GroupImage = Nothing
        Me.Show_Search_Panel.GroupTitle = "Search :"
        Me.Show_Search_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Show_Search_Panel.Name = "Show_Search_Panel"
        Me.Show_Search_Panel.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.Show_Search_Panel.PaintGroupBox = False
        Me.Show_Search_Panel.RoundCorners = 10
        Me.Show_Search_Panel.ShadowColor = System.Drawing.Color.DarkGray
        Me.Show_Search_Panel.ShadowControl = False
        Me.Show_Search_Panel.ShadowThickness = 3
        Me.Show_Search_Panel.Size = New System.Drawing.Size(956, 60)
        Me.Show_Search_Panel.TabIndex = 0
        '
        'S_Prod
        '
        Me.S_Prod.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.S_Prod.FormattingEnabled = True
        Me.S_Prod.Location = New System.Drawing.Point(306, 27)
        Me.S_Prod.Name = "S_Prod"
        Me.S_Prod.Size = New System.Drawing.Size(225, 21)
        Me.S_Prod.TabIndex = 7
        Me.S_Prod.Text = "All Products"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Product Name"
        '
        'S_Clear
        '
        Me.S_Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.S_Clear.FlatAppearance.BorderSize = 0
        Me.S_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.S_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.S_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Clear.Image = Global.Duty.My.Resources.Resources.clear
        Me.S_Clear.Location = New System.Drawing.Point(578, 27)
        Me.S_Clear.Name = "S_Clear"
        Me.S_Clear.Size = New System.Drawing.Size(20, 20)
        Me.S_Clear.TabIndex = 5
        Me.S_Clear.UseVisualStyleBackColor = True
        '
        'S_Search
        '
        Me.S_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.S_Search.FlatAppearance.BorderSize = 0
        Me.S_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.S_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.S_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.S_Search.Image = Global.Duty.My.Resources.Resources.find
        Me.S_Search.Location = New System.Drawing.Point(537, 27)
        Me.S_Search.Name = "S_Search"
        Me.S_Search.Size = New System.Drawing.Size(20, 20)
        Me.S_Search.TabIndex = 4
        Me.S_Search.UseVisualStyleBackColor = True
        '
        'S_Month
        '
        Me.S_Month.FormattingEnabled = True
        Me.S_Month.Location = New System.Drawing.Point(72, 28)
        Me.S_Month.Name = "S_Month"
        Me.S_Month.Size = New System.Drawing.Size(121, 21)
        Me.S_Month.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Month"
        '
        'S_List_Box
        '
        Me.S_List_Box.BackgroundColor = System.Drawing.Color.DarkGray
        Me.S_List_Box.BackgroundGradientColor = System.Drawing.Color.White
        Me.S_List_Box.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.S_List_Box.BorderColor = System.Drawing.Color.Black
        Me.S_List_Box.BorderThickness = 1.0!
        Me.S_List_Box.Controls.Add(Me.S_DataGrd)
        Me.S_List_Box.Controls.Add(Me.Panel1)
        Me.S_List_Box.CustomGroupBoxColor = System.Drawing.Color.White
        Me.S_List_Box.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_List_Box.GroupImage = Nothing
        Me.S_List_Box.GroupTitle = "Products Listed :"
        Me.S_List_Box.Location = New System.Drawing.Point(0, 0)
        Me.S_List_Box.Name = "S_List_Box"
        Me.S_List_Box.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.S_List_Box.PaintGroupBox = False
        Me.S_List_Box.RoundCorners = 10
        Me.S_List_Box.ShadowColor = System.Drawing.Color.DarkGray
        Me.S_List_Box.ShadowControl = False
        Me.S_List_Box.ShadowThickness = 3
        Me.S_List_Box.Size = New System.Drawing.Size(956, 435)
        Me.S_List_Box.TabIndex = 0
        '
        'S_DataGrd
        '
        Me.S_DataGrd.AllowUserToAddRows = False
        Me.S_DataGrd.AllowUserToDeleteRows = False
        Me.S_DataGrd.AllowUserToResizeColumns = False
        Me.S_DataGrd.AllowUserToResizeRows = False
        Me.S_DataGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.S_DataGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.S_DataGrd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cid, Me.cname, Me.Pname, Me.doi, Me.dos, Me.CAddress, Me.cph, Me.Serviced, Me.feed})
        Me.S_DataGrd.DisplaySumRowHeader = False
        Me.S_DataGrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_DataGrd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.S_DataGrd.EmptyDataText = ""
        Me.S_DataGrd.EmptyDataTextHorizontalAlign = Duty.DGV_Empty.DataGrid.HorizontalAlign.Left
        Me.S_DataGrd.EmptyDataTextLocationX = 0.0!
        Me.S_DataGrd.EmptyDataTextLocationY = 0.0!
        Me.S_DataGrd.EmptyDataTextVerticalAlign = Duty.DGV_Empty.DataGrid.VerticalAlign.Top
        Me.S_DataGrd.Location = New System.Drawing.Point(10, 25)
        Me.S_DataGrd.MultiSelect = False
        Me.S_DataGrd.Name = "S_DataGrd"
        Me.S_DataGrd.RowHeadersVisible = False
        Me.S_DataGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.S_DataGrd.Size = New System.Drawing.Size(936, 382)
        Me.S_DataGrd.SummaryColumns = Nothing
        Me.S_DataGrd.SummaryRowBackColor = System.Drawing.Color.Empty
        Me.S_DataGrd.SummaryRowSpace = 0
        Me.S_DataGrd.SummaryRowVisible = False
        Me.S_DataGrd.SumRowHeaderText = Nothing
        Me.S_DataGrd.SumRowHeaderTextBold = False
        Me.S_DataGrd.TabIndex = 0
        '
        'Cid
        '
        Me.Cid.HeaderText = "Customer Id"
        Me.Cid.Name = "Cid"
        Me.Cid.ReadOnly = True
        '
        'cname
        '
        Me.cname.HeaderText = "Customer Name"
        Me.cname.Name = "cname"
        Me.cname.ReadOnly = True
        '
        'Pname
        '
        Me.Pname.HeaderText = "Product Name"
        Me.Pname.Name = "Pname"
        Me.Pname.ReadOnly = True
        '
        'doi
        '
        Me.doi.HeaderText = "Date of Instalation"
        Me.doi.Name = "doi"
        Me.doi.ReadOnly = True
        '
        'dos
        '
        Me.dos.HeaderText = "Date of Next Service"
        Me.dos.Name = "dos"
        Me.dos.ReadOnly = True
        '
        'CAddress
        '
        Me.CAddress.HeaderText = "Customer Address"
        Me.CAddress.Name = "CAddress"
        Me.CAddress.ReadOnly = True
        '
        'cph
        '
        Me.cph.HeaderText = "Phone Number"
        Me.cph.Name = "cph"
        Me.cph.ReadOnly = True
        '
        'Serviced
        '
        Me.Serviced.HeaderText = "Serviced"
        Me.Serviced.Name = "Serviced"
        '
        'feed
        '
        Me.feed.HeaderText = "Feedback"
        Me.feed.Name = "feed"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Refresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(10, 407)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 18)
        Me.Panel1.TabIndex = 0
        '
        'Refresh
        '
        Me.Refresh.AutoSize = True
        Me.Refresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.Refresh.Image = Global.Duty.My.Resources.Resources.refresh_icon
        Me.Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Refresh.Location = New System.Drawing.Point(871, 0)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(65, 13)
        Me.Refresh.TabIndex = 0
        Me.Refresh.Text = "       Refresh"
        '
        'Show_Serviced
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(956, 499)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.GradientBegin = System.Drawing.SystemColors.Control
        Me.GradientEnd = System.Drawing.SystemColors.Control
        Me.GradientMiddle = System.Drawing.SystemColors.Control
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.Custom
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Show_Serviced"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show_Serviced"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Show_Search_Panel.ResumeLayout(False)
        Me.Show_Search_Panel.PerformLayout()
        Me.S_List_Box.ResumeLayout(False)
        CType(Me.S_DataGrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EAppearanceControl1 As ESAR_Controls.Appearance.eAppearanceControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Show_Search_Panel As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents S_List_Box As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents S_Clear As System.Windows.Forms.Button
    Friend WithEvents S_Search As System.Windows.Forms.Button
    Friend WithEvents S_Month As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents S_Prod As System.Windows.Forms.ComboBox
    Friend WithEvents Refresh As System.Windows.Forms.Label
    Friend WithEvents S_DataGrd As Duty.DGV_Empty.DataGrid
    Friend WithEvents Cid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents doi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cph As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serviced As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents feed As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
