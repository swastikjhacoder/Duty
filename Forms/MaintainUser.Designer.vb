<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintainUser
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel()
        Me.moduseraccess = New System.Windows.Forms.CheckBox()
        Me.canservice = New System.Windows.Forms.CheckBox()
        Me.canmodify = New System.Windows.Forms.CheckBox()
        Me.isadmin = New System.Windows.Forms.CheckBox()
        Me.M_Username = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.M_N_Password1 = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.M_N_Password = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.M_O_Password = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ERoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ERoundedPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(384, 223)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Maintain User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.LightGray
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.moduseraccess)
        Me.ERoundedPanel1.Controls.Add(Me.canservice)
        Me.ERoundedPanel1.Controls.Add(Me.canmodify)
        Me.ERoundedPanel1.Controls.Add(Me.isadmin)
        Me.ERoundedPanel1.Controls.Add(Me.M_Username)
        Me.ERoundedPanel1.Controls.Add(Me.M_N_Password1)
        Me.ERoundedPanel1.Controls.Add(Me.Label5)
        Me.ERoundedPanel1.Controls.Add(Me.M_N_Password)
        Me.ERoundedPanel1.Controls.Add(Me.Label3)
        Me.ERoundedPanel1.Controls.Add(Me.M_O_Password)
        Me.ERoundedPanel1.Controls.Add(Me.Label2)
        Me.ERoundedPanel1.Controls.Add(Me.Label4)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(384, 194)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'moduseraccess
        '
        Me.moduseraccess.AutoSize = True
        Me.moduseraccess.Location = New System.Drawing.Point(230, 164)
        Me.moduseraccess.Name = "moduseraccess"
        Me.moduseraccess.Size = New System.Drawing.Size(142, 17)
        Me.moduseraccess.TabIndex = 7
        Me.moduseraccess.Text = "Can Modify User Access"
        Me.moduseraccess.UseVisualStyleBackColor = True
        '
        'canservice
        '
        Me.canservice.AutoSize = True
        Me.canservice.Location = New System.Drawing.Point(230, 141)
        Me.canservice.Name = "canservice"
        Me.canservice.Size = New System.Drawing.Size(131, 17)
        Me.canservice.TabIndex = 5
        Me.canservice.Text = "Can Service Customer"
        Me.canservice.UseVisualStyleBackColor = True
        '
        'canmodify
        '
        Me.canmodify.AutoSize = True
        Me.canmodify.Location = New System.Drawing.Point(99, 164)
        Me.canmodify.Name = "canmodify"
        Me.canmodify.Size = New System.Drawing.Size(105, 17)
        Me.canmodify.TabIndex = 6
        Me.canmodify.Text = "Can Modify Data"
        Me.canmodify.UseVisualStyleBackColor = True
        '
        'isadmin
        '
        Me.isadmin.AutoSize = True
        Me.isadmin.Location = New System.Drawing.Point(99, 141)
        Me.isadmin.Name = "isadmin"
        Me.isadmin.Size = New System.Drawing.Size(97, 17)
        Me.isadmin.TabIndex = 4
        Me.isadmin.Text = "Is Administrator"
        Me.isadmin.UseVisualStyleBackColor = True
        '
        'M_Username
        '
        Me.M_Username.BackColor = System.Drawing.Color.White
        Me.M_Username.Location = New System.Drawing.Point(134, 27)
        Me.M_Username.Name = "M_Username"
        Me.M_Username.Required = False
        Me.M_Username.ShowErrorIcon = False
        Me.M_Username.Size = New System.Drawing.Size(238, 20)
        Me.M_Username.TabIndex = 0
        Me.M_Username.TextBox = ""
        Me.M_Username.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.M_Username.WaterMark = "Username ...."
        Me.M_Username.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.M_Username.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_Username.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'M_N_Password1
        '
        Me.M_N_Password1.BackColor = System.Drawing.Color.White
        Me.M_N_Password1.Location = New System.Drawing.Point(134, 101)
        Me.M_N_Password1.Name = "M_N_Password1"
        Me.M_N_Password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.M_N_Password1.Required = False
        Me.M_N_Password1.ShowErrorIcon = False
        Me.M_N_Password1.Size = New System.Drawing.Size(238, 20)
        Me.M_N_Password1.TabIndex = 3
        Me.M_N_Password1.TextBox = ""
        Me.M_N_Password1.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.M_N_Password1.WaterMark = "Confirm New Password ...."
        Me.M_N_Password1.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.M_N_Password1.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_N_Password1.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Enter New Password -"
        '
        'M_N_Password
        '
        Me.M_N_Password.BackColor = System.Drawing.Color.White
        Me.M_N_Password.Location = New System.Drawing.Point(134, 77)
        Me.M_N_Password.Name = "M_N_Password"
        Me.M_N_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.M_N_Password.Required = False
        Me.M_N_Password.ShowErrorIcon = False
        Me.M_N_Password.Size = New System.Drawing.Size(238, 20)
        Me.M_N_Password.TabIndex = 2
        Me.M_N_Password.TextBox = ""
        Me.M_N_Password.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.M_N_Password.WaterMark = "New Password ...."
        Me.M_N_Password.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.M_N_Password.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_N_Password.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Enter New Password -"
        '
        'M_O_Password
        '
        Me.M_O_Password.BackColor = System.Drawing.Color.White
        Me.M_O_Password.Location = New System.Drawing.Point(134, 52)
        Me.M_O_Password.Name = "M_O_Password"
        Me.M_O_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.M_O_Password.Required = False
        Me.M_O_Password.ShowErrorIcon = False
        Me.M_O_Password.Size = New System.Drawing.Size(238, 20)
        Me.M_O_Password.TabIndex = 1
        Me.M_O_Password.TextBox = ""
        Me.M_O_Password.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.M_O_Password.WaterMark = "Old Password ...."
        Me.M_O_Password.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.M_O_Password.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M_O_Password.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Enter Old Password -"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Username -"
        '
        'MaintainUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(384, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MaintainUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MaintainUser"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents M_O_Password As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents M_N_Password1 As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents M_N_Password As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents M_Username As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents canmodify As System.Windows.Forms.CheckBox
    Friend WithEvents isadmin As System.Windows.Forms.CheckBox
    Friend WithEvents moduseraccess As System.Windows.Forms.CheckBox
    Friend WithEvents canservice As System.Windows.Forms.CheckBox
End Class
