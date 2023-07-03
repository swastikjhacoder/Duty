<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.L_Username = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.L_Password = New ESAR_Controls.UIControls.TextBox.eTextBox()
        Me.ERoundedPanel1 = New ESAR_Controls.UIControls.Panel.eRoundedPanel()
        Me.ERoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(41, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.Location = New System.Drawing.Point(41, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'L_Username
        '
        Me.L_Username.BackColor = System.Drawing.Color.White
        Me.L_Username.Location = New System.Drawing.Point(137, 51)
        Me.L_Username.Name = "L_Username"
        Me.L_Username.Required = False
        Me.L_Username.ShowErrorIcon = False
        Me.L_Username.Size = New System.Drawing.Size(151, 20)
        Me.L_Username.TabIndex = 2
        Me.L_Username.TextBox = ""
        Me.L_Username.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.L_Username.WaterMark = "Enter Username ...."
        Me.L_Username.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.L_Username.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Username.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'L_Password
        '
        Me.L_Password.BackColor = System.Drawing.Color.White
        Me.L_Password.Location = New System.Drawing.Point(137, 89)
        Me.L_Password.Name = "L_Password"
        Me.L_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.L_Password.Required = False
        Me.L_Password.ShowErrorIcon = False
        Me.L_Password.Size = New System.Drawing.Size(151, 20)
        Me.L_Password.TabIndex = 3
        Me.L_Password.TextBox = ""
        Me.L_Password.ValidationMode = ESAR_Controls.UIControls.TextBox.eTextBox.ValidationModes.None
        Me.L_Password.WaterMark = "Enter Password ...."
        Me.L_Password.WaterMarkActiveForeColor = System.Drawing.Color.Gray
        Me.L_Password.WaterMarkFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Password.WaterMarkForeColor = System.Drawing.Color.LightGray
        '
        'ERoundedPanel1
        '
        Me.ERoundedPanel1.BackColor = System.Drawing.Color.LightGray
        Me.ERoundedPanel1.BorderRadius = 32
        Me.ERoundedPanel1.Controls.Add(Me.L_Password)
        Me.ERoundedPanel1.Controls.Add(Me.Label1)
        Me.ERoundedPanel1.Controls.Add(Me.L_Username)
        Me.ERoundedPanel1.Controls.Add(Me.Label2)
        Me.ERoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERoundedPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ERoundedPanel1.Name = "ERoundedPanel1"
        Me.ERoundedPanel1.Size = New System.Drawing.Size(348, 162)
        Me.ERoundedPanel1.TabIndex = 4
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(348, 162)
        Me.ControlBox = False
        Me.Controls.Add(Me.ERoundedPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LoginForm"
        Me.ERoundedPanel1.ResumeLayout(False)
        Me.ERoundedPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents L_Username As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents L_Password As ESAR_Controls.UIControls.TextBox.eTextBox
    Friend WithEvents ERoundedPanel1 As ESAR_Controls.UIControls.Panel.eRoundedPanel
End Class
