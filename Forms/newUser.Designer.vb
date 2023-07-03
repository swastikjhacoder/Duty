<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newUser
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.password = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Username = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EGroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EGroupBox1
        '
        Me.EGroupBox1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.BackgroundGradientColor = System.Drawing.Color.White
        Me.EGroupBox1.BackgroundGradientMode = ESAR_Controls.UIControls.GroupBox.eGroupBox.GroupBoxGradientMode.None
        Me.EGroupBox1.BorderColor = System.Drawing.Color.Black
        Me.EGroupBox1.BorderThickness = 1.0!
        Me.EGroupBox1.Controls.Add(Me.Panel1)
        Me.EGroupBox1.CustomGroupBoxColor = System.Drawing.Color.White
        Me.EGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EGroupBox1.GroupImage = Nothing
        Me.EGroupBox1.GroupTitle = "Create Admin for Duty"
        Me.EGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.EGroupBox1.Name = "EGroupBox1"
        Me.EGroupBox1.Padding = New System.Windows.Forms.Padding(10, 25, 10, 10)
        Me.EGroupBox1.PaintGroupBox = False
        Me.EGroupBox1.RoundCorners = 10
        Me.EGroupBox1.ShadowColor = System.Drawing.Color.DarkGray
        Me.EGroupBox1.ShadowControl = False
        Me.EGroupBox1.ShadowThickness = 3
        Me.EGroupBox1.Size = New System.Drawing.Size(366, 203)
        Me.EGroupBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.Username)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 168)
        Me.Panel1.TabIndex = 2
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.White
        Me.password.Location = New System.Drawing.Point(110, 100)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Required = False
        Me.password.ShowErrorIcon = False
        Me.password.Size = New System.Drawing.Size(207, 20)
        Me.password.TabIndex = 1
        Me.password.TextBox = ""
        Me.password.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.password.WaterMark = "Enter the Password"
        Me.password.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.password.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.White
        Me.Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Username.Location = New System.Drawing.Point(110, 49)
        Me.Username.Name = "Username"
        Me.Username.Required = False
        Me.Username.ShowErrorIcon = False
        Me.Username.Size = New System.Drawing.Size(207, 20)
        Me.Username.TabIndex = 0
        Me.Username.TextBox = ""
        Me.Username.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.Username.WaterMark = "Enter username for Administrator"
        Me.Username.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.Username.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(15, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(15, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'newUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(366, 203)
        Me.Controls.Add(Me.EGroupBox1)
        Me.Name = "newUser"
        Me.Text = "newUser"
        Me.EGroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EGroupBox1 As ESAR_Controls.UIControls.GroupBox.eGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Username As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents password As ESAR_Controls.UIControls.TextBox.eTextBox
End Class
