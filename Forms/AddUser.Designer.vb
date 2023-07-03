<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.add_username = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.add_Password1 = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.add_password = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(390, 196)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 25)
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
        Me.ERoundedPanel1.Controls.Add(Me.add_username)
        Me.ERoundedPanel1.Controls.Add(Me.add_Password1)
        Me.ERoundedPanel1.Controls.Add(Me.Label5)
        Me.ERoundedPanel1.Controls.Add(Me.add_password)
        Me.ERoundedPanel1.Controls.Add(Me.Label3)
        Me.ERoundedPanel1.Controls.Add(Me.Label4)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(390, 167)
        Me.ERoundedPanel1.TabIndex = 0
        '
        'moduseraccess
        '
        Me.moduseraccess.AutoSize = True
        Me.moduseraccess.Location = New System.Drawing.Point(230, 138)
        Me.moduseraccess.Name = "moduseraccess"
        Me.moduseraccess.Size = New System.Drawing.Size(142, 17)
        Me.moduseraccess.TabIndex = 6
        Me.moduseraccess.Text = "Can Modify User Access"
        Me.moduseraccess.UseVisualStyleBackColor = True
        '
        'canservice
        '
        Me.canservice.AutoSize = True
        Me.canservice.Location = New System.Drawing.Point(230, 115)
        Me.canservice.Name = "canservice"
        Me.canservice.Size = New System.Drawing.Size(131, 17)
        Me.canservice.TabIndex = 4
        Me.canservice.Text = "Can Service Customer"
        Me.canservice.UseVisualStyleBackColor = True
        '
        'canmodify
        '
        Me.canmodify.AutoSize = True
        Me.canmodify.Location = New System.Drawing.Point(99, 138)
        Me.canmodify.Name = "canmodify"
        Me.canmodify.Size = New System.Drawing.Size(105, 17)
        Me.canmodify.TabIndex = 5
        Me.canmodify.Text = "Can Modify Data"
        Me.canmodify.UseVisualStyleBackColor = True
        '
        'isadmin
        '
        Me.isadmin.AutoSize = True
        Me.isadmin.Location = New System.Drawing.Point(99, 115)
        Me.isadmin.Name = "isadmin"
        Me.isadmin.Size = New System.Drawing.Size(97, 17)
        Me.isadmin.TabIndex = 3
        Me.isadmin.Text = "Is Administrator"
        Me.isadmin.UseVisualStyleBackColor = True
        '
        'add_username
        '
        Me.add_username.BackColor = System.Drawing.Color.White
        Me.add_username.Location = New System.Drawing.Point(134, 27)
        Me.add_username.Name = "add_username"
        Me.add_username.Required = False
        Me.add_username.ShowErrorIcon = False
        Me.add_username.Size = New System.Drawing.Size(238, 20)
        Me.add_username.TabIndex = 0
        Me.add_username.TextBox = ""
        Me.add_username.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.add_username.WaterMark = "Username ...."
        Me.add_username.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.add_username.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_username.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'add_Password1
        '
        Me.add_Password1.BackColor = System.Drawing.Color.White
        Me.add_Password1.Location = New System.Drawing.Point(134, 75)
        Me.add_Password1.Name = "add_Password1"
        Me.add_Password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.add_Password1.Required = False
        Me.add_Password1.ShowErrorIcon = False
        Me.add_Password1.Size = New System.Drawing.Size(238, 20)
        Me.add_Password1.TabIndex = 2
        Me.add_Password1.TextBox = ""
        Me.add_Password1.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.add_Password1.WaterMark = "Confirm New Password ...."
        Me.add_Password1.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.add_Password1.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_Password1.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Enter New Password -"
        '
        'add_password
        '
        Me.add_password.BackColor = System.Drawing.Color.White
        Me.add_password.Location = New System.Drawing.Point(134, 51)
        Me.add_password.Name = "add_password"
        Me.add_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.add_password.Required = False
        Me.add_password.ShowErrorIcon = False
        Me.add_password.Size = New System.Drawing.Size(238, 20)
        Me.add_password.TabIndex = 1
        Me.add_password.TextBox = ""
        Me.add_password.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.add_password.WaterMark = "New Password ...."
        Me.add_password.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.add_password.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_password.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Enter New Password -"
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
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(390, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddUser"
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
    Friend WithEvents moduseraccess As System.Windows.Forms.CheckBox
    Friend WithEvents canservice As System.Windows.Forms.CheckBox
    Friend WithEvents canmodify As System.Windows.Forms.CheckBox
    Friend WithEvents isadmin As System.Windows.Forms.CheckBox
    Friend WithEvents add_username As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents add_Password1 As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents add_password As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
