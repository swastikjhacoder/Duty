<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class company
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Comp_Name = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Comp_Address = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Comp_Phone = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Comp_Email = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ERoundedPanel2 = New ESAR_Controls.UIControls.Panel.eRoundedPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ERoundedPanel3 = New ESAR_Controls.UIControls.Panel.eRoundedPanel()
        Me.Comp_Id = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Comp_Web = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ERoundedPanel2.SuspendLayout()
        Me.ERoundedPanel3.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Company Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Company Phone Number :"
        '
        'Comp_Name
        '
        Me.Comp_Name.BackColor = System.Drawing.Color.White
        Me.Comp_Name.Location = New System.Drawing.Point(227, 56)
        Me.Comp_Name.Name = "Comp_Name"
        Me.Comp_Name.Required = False
        Me.Comp_Name.ShowErrorIcon = False
        Me.Comp_Name.Size = New System.Drawing.Size(244, 20)
        Me.Comp_Name.TabIndex = 5
        Me.Comp_Name.TextBox = ""
        Me.Comp_Name.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.Comp_Name.WaterMark = "Company Name ..."
        Me.Comp_Name.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.Comp_Name.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp_Name.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Comp_Address
        '
        Me.Comp_Address.BackColor = System.Drawing.Color.White
        Me.Comp_Address.Location = New System.Drawing.Point(227, 84)
        Me.Comp_Address.Multiline = True
        Me.Comp_Address.Name = "Comp_Address"
        Me.Comp_Address.Required = False
        Me.Comp_Address.ShowErrorIcon = False
        Me.Comp_Address.Size = New System.Drawing.Size(244, 85)
        Me.Comp_Address.TabIndex = 6
        Me.Comp_Address.TextBox = ""
        Me.Comp_Address.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.Comp_Address.WaterMark = "Company Address....."
        Me.Comp_Address.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.Comp_Address.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp_Address.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Comp_Phone
        '
        Me.Comp_Phone.BackColor = System.Drawing.Color.White
        Me.Comp_Phone.Location = New System.Drawing.Point(227, 175)
        Me.Comp_Phone.Name = "Comp_Phone"
        Me.Comp_Phone.Required = False
        Me.Comp_Phone.ShowErrorIcon = False
        Me.Comp_Phone.Size = New System.Drawing.Size(244, 20)
        Me.Comp_Phone.TabIndex = 7
        Me.Comp_Phone.TextBox = ""
        Me.Comp_Phone.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.Comp_Phone.WaterMark = "Company Phone Number......"
        Me.Comp_Phone.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.Comp_Phone.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp_Phone.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Company Email Address :"
        '
        'Comp_Email
        '
        Me.Comp_Email.BackColor = System.Drawing.Color.White
        Me.Comp_Email.Location = New System.Drawing.Point(227, 203)
        Me.Comp_Email.Name = "Comp_Email"
        Me.Comp_Email.Required = False
        Me.Comp_Email.ShowErrorIcon = False
        Me.Comp_Email.Size = New System.Drawing.Size(244, 20)
        Me.Comp_Email.TabIndex = 9
        Me.Comp_Email.TextBox = ""
        Me.Comp_Email.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.Comp_Email.WaterMark = "Company Email Address......"
        Me.Comp_Email.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.Comp_Email.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp_Email.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.DimGray
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ERoundedPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ERoundedPanel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(486, 344)
        Me.SplitContainer1.SplitterDistance = 59
        Me.SplitContainer1.TabIndex = 10
        '
        'ERoundedPanel2
        '
        Me.ERoundedPanel2.BackColor = System.Drawing.Color.LightGray
        Me.ERoundedPanel2.BorderRadius = 32
        Me.ERoundedPanel2.Controls.Add(Me.Label7)
        Me.ERoundedPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel2.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel2.Name = "ERoundedPanel2"
        Me.ERoundedPanel2.Size = New System.Drawing.Size(486, 59)
        Me.ERoundedPanel2.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(486, 59)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Maintain Company"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ERoundedPanel3
        '
        Me.ERoundedPanel3.BackColor = System.Drawing.Color.LightGray
        Me.ERoundedPanel3.BorderRadius = 32
        Me.ERoundedPanel3.Controls.Add(Me.Comp_Id)
        Me.ERoundedPanel3.Controls.Add(Me.Label6)
        Me.ERoundedPanel3.Controls.Add(Me.Comp_Address)
        Me.ERoundedPanel3.Controls.Add(Me.Comp_Web)
        Me.ERoundedPanel3.Controls.Add(Me.Comp_Name)
        Me.ERoundedPanel3.Controls.Add(Me.Label5)
        Me.ERoundedPanel3.Controls.Add(Me.Comp_Phone)
        Me.ERoundedPanel3.Controls.Add(Me.Label1)
        Me.ERoundedPanel3.Controls.Add(Me.Label3)
        Me.ERoundedPanel3.Controls.Add(Me.Comp_Email)
        Me.ERoundedPanel3.Controls.Add(Me.Label4)
        Me.ERoundedPanel3.Controls.Add(Me.Label2)
        Me.ERoundedPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel3.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel3.Name = "ERoundedPanel3"
        Me.ERoundedPanel3.Size = New System.Drawing.Size(486, 281)
        Me.ERoundedPanel3.TabIndex = 12
        '
        'Comp_Id
        '
        Me.Comp_Id.AutoSize = True
        Me.Comp_Id.Location = New System.Drawing.Point(230, 29)
        Me.Comp_Id.Name = "Comp_Id"
        Me.Comp_Id.Size = New System.Drawing.Size(39, 13)
        Me.Comp_Id.TabIndex = 13
        Me.Comp_Id.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Company Id"
        '
        'Comp_Web
        '
        Me.Comp_Web.BackColor = System.Drawing.Color.White
        Me.Comp_Web.Location = New System.Drawing.Point(227, 231)
        Me.Comp_Web.Name = "Comp_Web"
        Me.Comp_Web.Required = False
        Me.Comp_Web.ShowErrorIcon = False
        Me.Comp_Web.Size = New System.Drawing.Size(244, 20)
        Me.Comp_Web.TabIndex = 11
        Me.Comp_Web.TextBox = ""
        Me.Comp_Web.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.Comp_Web.WaterMark = "Company Website ......."
        Me.Comp_Web.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.Comp_Web.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comp_Web.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Company Website :"
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.White
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.SplitContainer1)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(486, 344)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(486, 344)
        Me.Controls.Add(Me.ERoundedPanel1)
        Me.Name = "company"
        Me.Text = "newCompany"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ERoundedPanel2.ResumeLayout(False)
        Me.ERoundedPanel3.ResumeLayout(False)
        Me.ERoundedPanel3.PerformLayout()
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Comp_Name As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Comp_Address As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Comp_Phone As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Comp_Email As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ERoundedPanel2 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents ERoundedPanel3 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Comp_Id As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Comp_Web As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
