<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintain_Products
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.B_back = New System.Windows.Forms.Button()
        Me.B_Next = New System.Windows.Forms.Button()
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel()
        Me.P_Pid = New System.Windows.Forms.Label()
        Me.Product_Id = New System.Windows.Forms.Label()
        Me.P_Service = New System.Windows.Forms.NumericUpDown()
        Me.P_Model = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.P_Name = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        CType(Me.P_Service, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ERoundedPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(376, 216)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Maintain Products "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(322, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.B_back)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.B_Next)
        Me.SplitContainer2.Size = New System.Drawing.Size(54, 25)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.TabIndex = 9
        '
        'B_back
        '
        Me.B_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.B_back.FlatAppearance.BorderSize = 0
        Me.B_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_back.Image = Global.Duty.My.Resources.Resources.back
        Me.B_back.Location = New System.Drawing.Point(4, -1)
        Me.B_back.Name = "B_back"
        Me.B_back.Size = New System.Drawing.Size(23, 23)
        Me.B_back.TabIndex = 4
        Me.B_back.UseVisualStyleBackColor = True
        '
        'B_Next
        '
        Me.B_Next.Dock = System.Windows.Forms.DockStyle.Fill
        Me.B_Next.FlatAppearance.BorderSize = 0
        Me.B_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_Next.Image = Global.Duty.My.Resources.Resources._next
        Me.B_Next.Location = New System.Drawing.Point(0, 0)
        Me.B_Next.Name = "B_Next"
        Me.B_Next.Size = New System.Drawing.Size(25, 25)
        Me.B_Next.TabIndex = 9
        Me.B_Next.UseVisualStyleBackColor = True
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.LightGray
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.P_Pid)
        Me.ERoundedPanel1.Controls.Add(Me.Product_Id)
        Me.ERoundedPanel1.Controls.Add(Me.P_Service)
        Me.ERoundedPanel1.Controls.Add(Me.P_Model)
        Me.ERoundedPanel1.Controls.Add(Me.P_Name)
        Me.ERoundedPanel1.Controls.Add(Me.Label3)
        Me.ERoundedPanel1.Controls.Add(Me.Label2)
        Me.ERoundedPanel1.Controls.Add(Me.Label4)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(376, 187)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'P_Pid
        '
        Me.P_Pid.AutoSize = True
        Me.P_Pid.Location = New System.Drawing.Point(120, 28)
        Me.P_Pid.Name = "P_Pid"
        Me.P_Pid.Size = New System.Drawing.Size(0, 13)
        Me.P_Pid.TabIndex = 18
        '
        'Product_Id
        '
        Me.Product_Id.AutoSize = True
        Me.Product_Id.Location = New System.Drawing.Point(30, 28)
        Me.Product_Id.Name = "Product_Id"
        Me.Product_Id.Size = New System.Drawing.Size(62, 13)
        Me.Product_Id.TabIndex = 17
        Me.Product_Id.Text = "Product Id -"
        '
        'P_Service
        '
        Me.P_Service.Location = New System.Drawing.Point(123, 102)
        Me.P_Service.Name = "P_Service"
        Me.P_Service.Size = New System.Drawing.Size(120, 20)
        Me.P_Service.TabIndex = 2
        '
        'P_Model
        '
        Me.P_Model.BackColor = System.Drawing.Color.White
        Me.P_Model.Location = New System.Drawing.Point(122, 77)
        Me.P_Model.Name = "P_Model"
        Me.P_Model.Required = False
        Me.P_Model.ShowErrorIcon = False
        Me.P_Model.Size = New System.Drawing.Size(217, 20)
        Me.P_Model.TabIndex = 1
        Me.P_Model.TextBox = ""
        Me.P_Model.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.P_Model.WaterMark = "Model Number ...."
        Me.P_Model.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.P_Model.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_Model.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'P_Name
        '
        Me.P_Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.P_Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.P_Name.BackColor = System.Drawing.Color.White
        Me.P_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.P_Name.Location = New System.Drawing.Point(122, 51)
        Me.P_Name.Name = "P_Name"
        Me.P_Name.Required = False
        Me.P_Name.ShowErrorIcon = False
        Me.P_Name.Size = New System.Drawing.Size(217, 20)
        Me.P_Name.TabIndex = 0
        Me.P_Name.TextBox = ""
        Me.P_Name.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.P_Name.WaterMark = "Enter Product Name..."
        Me.P_Name.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.P_Name.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_Name.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Service Interval -"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Model Number -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Product Name -"
        '
        'Maintain_Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(376, 216)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.GradientBegin = System.Drawing.SystemColors.Control
        Me.GradientEnd = System.Drawing.SystemColors.Control
        Me.GradientMiddle = System.Drawing.SystemColors.Control
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Maintain_Products"
        Me.Orientation = ESAR_Controls.UIControls.eForms.GradientOrientation.Horizontal
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintain Products "
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        CType(Me.P_Service, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EAppearanceControl1 As ESAR_Controls.Appearance.eAppearanceControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents P_Model As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents P_Name As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents P_Service As System.Windows.Forms.NumericUpDown
    Friend WithEvents Product_Id As System.Windows.Forms.Label
    Friend WithEvents P_Pid As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents B_back As System.Windows.Forms.Button
    Friend WithEvents B_Next As System.Windows.Forms.Button
End Class
