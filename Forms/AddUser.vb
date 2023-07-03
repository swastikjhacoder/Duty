Public Class AddUser

    Private Sub AddUser_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            If add_username.Text.Trim = String.Empty Then
                If MessageBox.Show("Please enter Username for the Account.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    add_username.Focus()
                End If
            ElseIf add_password.Text.Trim = String.Empty Then
                If MessageBox.Show("Please enter Password for the Account.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    add_password.Focus()
                End If
            ElseIf add_Password1.Text.Trim = String.Empty Then
                If MessageBox.Show("Please confirm Password for the Account.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    add_Password1.Focus()
                End If
            ElseIf add_password.Text.Trim.Equals(add_Password1.Text.Trim) = False Then
                If MessageBox.Show("Please Enter Same Password in the two fields.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    add_password.ResetText()
                    add_Password1.ResetText()
                    add_password.Focus()
                End If
            ElseIf isadmin.Checked = False And canservice.Checked = False And canmodify.Checked = False And moduseraccess.Checked = False Then
                If MessageBox.Show("Please select atleast one Userrole for the account", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    isadmin.Focus()
                End If
            Else
                Dim adduser As New UserManagerX
                adduser.adduser(add_username.Text.Trim, add_password.Text.Trim, isadmin.Checked, canservice.Checked, canmodify.Checked, moduseraccess.Checked)
                UsersForm.loadusers()
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        add_username.Focus()
    End Sub

    Private Sub isadmin_CheckedChanged(sender As Object, e As EventArgs) Handles isadmin.CheckedChanged
        If isadmin.Checked = True Then
            canservice.Checked = True
            canservice.Enabled = False
            canmodify.Checked = True
            canmodify.Enabled = False
            moduseraccess.Checked = True
            moduseraccess.Enabled = False
        ElseIf isadmin.Checked = False Then
            canservice.Checked = True
            canservice.Enabled = True
            canmodify.Checked = True
            canmodify.Enabled = True
            moduseraccess.Checked = True
            moduseraccess.Enabled = True
        End If
    End Sub
End Class