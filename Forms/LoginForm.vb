Public Class LoginForm
    Private Sub L_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles L_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            If L_Username.Text.Trim = String.Empty Then
                If MessageBox.Show("Please enter Username.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    L_Username.Focus()
                End If
            ElseIf L_Password.Text.Trim = String.Empty Then
                If MessageBox.Show("Please enter Username.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    L_Password.Focus()
                End If
            Else
                Dim logintry As New UserManagerX
                If (logintry.authenticateuser(L_Username.Text, L_Password.Text) = True) Then
                    Dim app As New Main2
                    app.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Please Enter Correct Credentials")
                    L_Password.ResetText()
                    L_Username.ResetText()
                    L_Username.Focus()
                End If
            End If
        End If
       
    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
End Class