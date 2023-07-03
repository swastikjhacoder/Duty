<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.EProfilePic1 = New ESAR_Controls.UIControls.PictureBox.eProfilePic()
        CType(Me.EProfilePic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EProfilePic1
        '
        Me.EProfilePic1.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.EProfilePic1.Image = Global.Duty.My.Resources.Resources.favicon
        Me.EProfilePic1.ImageSizeLimit = CType(-1, Long)
        Me.EProfilePic1.Location = New System.Drawing.Point(98, 70)
        Me.EProfilePic1.Name = "EProfilePic1"
        Me.EProfilePic1.ReadOnly = False
        Me.EProfilePic1.Size = New System.Drawing.Size(100, 111)
        Me.EProfilePic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EProfilePic1.TabIndex = 0
        Me.EProfilePic1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.EProfilePic1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.EProfilePic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents EProfilePic1 As ESAR_Controls.UIControls.PictureBox.eProfilePic
End Class
