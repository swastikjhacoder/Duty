Public Class newUser

    Private Sub newUser_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            If Username.Text.Trim() = "" Then
                If MessageBox.Show("Please enter Username for the Administrator Account.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    Username.Focus()
                End If
            ElseIf password.Text.Trim() = "" Then
                If MessageBox.Show("Please enter Password for the Administrator Account.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.OK Then
                    password.Focus()
                End If
            Else
                If MessageBox.Show("Accept the Username and Password for the Administrator Account ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                    Dim addadmin As New UserManagerX
                    addadmin.addAdmin(Username.Text.ToString, password.Text.ToString)
                    Me.Close()
                End If
            End If
        End If

    End Sub



    Private Sub newUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
End Class