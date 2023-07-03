Namespace UIControls.Button
    Partial Class HelpButton
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.pictureBox = New System.Windows.Forms.PictureBox()
            DirectCast(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pictureBox
            ' 
            Me.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pictureBox.Image = Global.Duty.My.Resources.help32
            Me.pictureBox.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox.Name = "pictureBox"
            Me.pictureBox.Size = New System.Drawing.Size(32, 32)
            Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox.TabIndex = 0
            Me.pictureBox.TabStop = False
            AddHandler Me.pictureBox.Click, AddressOf Me.pictureBox_Click
            ' 
            ' HelpButton
            ' 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.pictureBox)
            Me.Name = "HelpButton"
            Me.Size = New System.Drawing.Size(32, 32)
            DirectCast(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private pictureBox As System.Windows.Forms.PictureBox
    End Class
End Namespace