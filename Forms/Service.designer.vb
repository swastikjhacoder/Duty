<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Service
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
        Me.EToolStrip1 = New ESAR_Controls.Strips.eToolStrip()
        Me.EAppearanceControl1 = New ESAR_Controls.Appearance.eAppearanceControl()
        Me.New_Btn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.S_Save = New System.Windows.Forms.ToolStripButton()
        Me.Export = New System.Windows.Forms.ToolStripButton()
        Me.S_Print = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EGroupBox2 = New ESAR_Controls.UIControls.GroupBox.eGroupBox()
        Me.S_Prod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.S_Clear = New System.Windows.Forms.Button()
        Me.S_Search = New System.Windows.Forms.Button()
        Me.S_Month = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.S_List_Box = New ESAR_Controls.UIControls.GroupBox.eGroupBox()
        Me.S_NO = New System.Windows.Forms.Label()
        Me.S_DataGrd = New System.Windows.Forms.DataGridView()
        Me.Customer_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Service_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone_Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serviced = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Feedback = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.S_Show_Serviced = New System.Windows.Forms.Label()
        Me.Refresh = New System.Windows.Forms.Label()
        Me.PrintDocumentClient = New System.Drawing.Printing.PrintDocument()
        Me.EToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.EGroupBox2.SuspendLayout()
        Me.S_List_Box.SuspendLayout()
        CType(Me.S_DataGrd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EToolStrip1
        '
        Me.EToolStrip1.Appearance = Me.EAppearanceControl1
        Me.EToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.New_Btn, Me.ToolStripButton2, Me.S_Save, Me.Export, Me.S_Print})
        Me.EToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.EToolStrip1.Name = "EToolStrip1"
        Me.EToolStrip1.RoundedEdges = True
        Me.EToolStrip1.Size = New System.Drawing.Size(956, 25)
        Me.EToolStrip1.TabIndex = 7
        Me.EToolStrip1.Text = "EToolStrip1"
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
        'New_Btn
        '
        Me.New_Btn.Image = Global.Duty.My.Resources.Resources._new
        Me.New_Btn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.New_Btn.Name = "New_Btn"
        Me.New_Btn.Size = New System.Drawing.Size(51, 22)
        Me.New_Btn.Text = "New"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Duty.My.Resources.Resources.list
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripButton2.Text = "List"
        '
        'S_Save
        '
        Me.S_Save.Image = Global.Duty.My.Resources.Resources.save
        Me.S_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.S_Save.Name = "S_Save"
        Me.S_Save.Size = New System.Drawing.Size(51, 22)
        Me.S_Save.Text = "Save"
        '
        'Export
        '
        Me.Export.Image = Global.Duty.My.Resources.Resources.excel
        Me.Export.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(60, 22)
        Me.Export.Text = "Export"
        '
        'S_Print
        '
        Me.S_Print.Image = Global.Duty.My.Resources.Resources.printicon
        Me.S_Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.S_Print.Name = "S_Print"
        Me.S_Print.Size = New System.Drawing.Size(52, 22)
        Me.S_Print.Text = "Print"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.EGroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.S_List_Box)
        Me.SplitContainer1.Size = New System.Drawing.Size(956, 474)
        Me.SplitContainer1.SplitterDistance = 60
        Me.SplitContainer1.TabIndex = 8
        '
        'EGroupBox2
        '
        Me.EGroupBox2.BackgroundColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox2.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox2.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox2.BorderThickness = 1.0!
        Me.EGroupBox2.Controls.Add(Me.S_Prod)
        Me.EGroupBox2.Controls.Add(Me.Label1)
        Me.EGroupBox2.Controls.Add(Me.S_Clear)
        Me.EGroupBox2.Controls.Add(Me.S_Search)
        Me.EGroupBox2.Controls.Add(Me.S_Month)
        Me.EGroupBox2.Controls.Add(Me.Label2)
        Me.EGroupBox2.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox2.GroupImage = Nothing
        Me.EGroupBox2.GroupTitle = "Search :"
        Me.EGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox2.Name = "EGroupBox2"
        Me.EGroupBox2.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox2.PaintGroupBox = False
        Me.EGroupBox2.RoundCorners = 10
        Me.EGroupBox2.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox2.ShadowControl = False
        Me.EGroupBox2.ShadowThickness = 3
        Me.EGroupBox2.Size = New System.Drawing.Size(956, 60)
        Me.EGroupBox2.TabIndex = 0
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
        Me.S_List_Box.BackgroundColor = System.Drawing.Color.White
        Me.S_List_Box.BackgroundGradientColor = System.Drawing.Color.White
        Me.S_List_Box.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.S_List_Box.BorderColor = System.Drawing.Color.Black
        Me.S_List_Box.BorderThickness = 1.0!
        Me.S_List_Box.Controls.Add(Me.S_NO)
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
        Me.S_List_Box.Size = New System.Drawing.Size(956, 410)
        Me.S_List_Box.TabIndex = 0
        '
        'S_NO
        '
        Me.S_NO.AutoSize = True
        Me.S_NO.Location = New System.Drawing.Point(337, 64)
        Me.S_NO.Name = "S_NO"
        Me.S_NO.Size = New System.Drawing.Size(194, 13)
        Me.S_NO.TabIndex = 13
        Me.S_NO.Text = "No Record Found For Current Selection"
        Me.S_NO.Visible = False
        '
        'S_DataGrd
        '
        Me.S_DataGrd.AllowUserToDeleteRows = False
        Me.S_DataGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.S_DataGrd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.S_DataGrd.BackgroundColor = System.Drawing.Color.White
        Me.S_DataGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.S_DataGrd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Customer_Id, Me.Customer_Name, Me.Product_Name, Me.DOI, Me.Service_Date, Me.Customer_Address, Me.Phone_Number, Me.Serviced, Me.Feedback})
        Me.S_DataGrd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.S_DataGrd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.S_DataGrd.Location = New System.Drawing.Point(10, 25)
        Me.S_DataGrd.Name = "S_DataGrd"
        Me.S_DataGrd.RowHeadersVisible = False
        Me.S_DataGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.S_DataGrd.Size = New System.Drawing.Size(936, 357)
        Me.S_DataGrd.TabIndex = 11
        '
        'Customer_Id
        '
        Me.Customer_Id.HeaderText = "Customer Id"
        Me.Customer_Id.Name = "Customer_Id"
        Me.Customer_Id.ReadOnly = True
        '
        'Customer_Name
        '
        Me.Customer_Name.HeaderText = "Customer Name"
        Me.Customer_Name.Name = "Customer_Name"
        Me.Customer_Name.ReadOnly = True
        '
        'Product_Name
        '
        Me.Product_Name.HeaderText = "Product Name"
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.ReadOnly = True
        '
        'DOI
        '
        Me.DOI.HeaderText = "Date of Instalation"
        Me.DOI.Name = "DOI"
        Me.DOI.ReadOnly = True
        '
        'Service_Date
        '
        Me.Service_Date.HeaderText = "Service Date"
        Me.Service_Date.Name = "Service_Date"
        Me.Service_Date.ReadOnly = True
        '
        'Customer_Address
        '
        Me.Customer_Address.HeaderText = "Customer Address"
        Me.Customer_Address.Name = "Customer_Address"
        Me.Customer_Address.ReadOnly = True
        '
        'Phone_Number
        '
        Me.Phone_Number.HeaderText = "Phone Number"
        Me.Phone_Number.Name = "Phone_Number"
        Me.Phone_Number.ReadOnly = True
        '
        'Serviced
        '
        Me.Serviced.HeaderText = "Serviced"
        Me.Serviced.Name = "Serviced"
        '
        'Feedback
        '
        Me.Feedback.HeaderText = "Feedback"
        Me.Feedback.Name = "Feedback"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.S_Show_Serviced)
        Me.Panel1.Controls.Add(Me.Refresh)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(10, 382)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 18)
        Me.Panel1.TabIndex = 0
        '
        'S_Show_Serviced
        '
        Me.S_Show_Serviced.AutoSize = True
        Me.S_Show_Serviced.Dock = System.Windows.Forms.DockStyle.Left
        Me.S_Show_Serviced.Image = Global.Duty.My.Resources.Resources.ok
        Me.S_Show_Serviced.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.S_Show_Serviced.Location = New System.Drawing.Point(0, 0)
        Me.S_Show_Serviced.Name = "S_Show_Serviced"
        Me.S_Show_Serviced.Size = New System.Drawing.Size(76, 13)
        Me.S_Show_Serviced.TabIndex = 14
        Me.S_Show_Serviced.Text = "         Serviced"
        Me.S_Show_Serviced.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 499)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.EToolStrip1)
        Me.GradientBegin = System.Drawing.Color.LightCyan
        Me.GradientEnabled = True
        Me.GradientEnd = System.Drawing.Color.RoyalBlue
        Me.GradientMiddle = System.Drawing.Color.LightBlue
        Me.GradientPreset = ESAR_Controls.UIControls.eForms.GradientPresets.RoyalLight
        Me.Name = "Service"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service"
        Me.EToolStrip1.ResumeLayout(False)
        Me.EToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.EGroupBox2.ResumeLayout(False)
        Me.EGroupBox2.PerformLayout()
        Me.S_List_Box.ResumeLayout(False)
        Me.S_List_Box.PerformLayout()
        CType(Me.S_DataGrd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EToolStrip1 As ESAR_Controls.Strips.eToolStrip
    Friend WithEvents EAppearanceControl1 As ESAR_Controls.Appearance.eAppearanceControl
    Friend WithEvents New_Btn As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Export As System.Windows.Forms.ToolStripButton
    Friend WithEvents S_Print As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EGroupBox2 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents S_List_Box As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents S_DataGrd As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents S_Clear As System.Windows.Forms.Button
    Friend WithEvents S_Search As System.Windows.Forms.Button
    Friend WithEvents S_Month As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Refresh As System.Windows.Forms.Label
    Friend WithEvents Customer_Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Customer_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Service_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Customer_Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phone_Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Serviced As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Feedback As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents S_Prod As System.Windows.Forms.ComboBox
    Friend WithEvents S_Save As System.Windows.Forms.ToolStripButton
    Friend WithEvents S_NO As System.Windows.Forms.Label
    Friend WithEvents S_Show_Serviced As System.Windows.Forms.Label
    Friend WithEvents PrintDocumentClient As System.Drawing.Printing.PrintDocument
End Class
