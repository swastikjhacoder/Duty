Public Class MaintainUser
    Dim old As String
    Dim rolechange As Integer = -1
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
        rolechange = rolechange + 1
    End Sub

    Private Sub MaintainUser_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            trigerSave()
            UsersForm.loadusers()
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub trigerSave()
        Dim changepassword As Boolean = False
        Dim changerole As Boolean = False
        If M_O_Password.Enabled = True Then
            If M_O_Password.Text.Equals(old) Then
                If M_N_Password.Text.Equals(M_N_Password1.Text) Then
                    If MessageBox.Show("Accept the changes in password ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                        Dim up As New UserManagerX
                        up.updatePassword(M_Username.Text.Trim, M_N_Password1.Text.Trim)
                        changepassword = True
                    End If
                End If
            End If
        End If
        If Not (rolechange = -1) Then
            If MessageBox.Show("Accept the changes in User Rolse ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                Dim uprole As New UserManagerX
                uprole.updateRoles(M_Username.Text.Trim, isadmin.Checked, canmodify.Checked, canservice.Checked, moduseraccess.Checked)
                changerole = True
            End If
        End If
        If M_Username.Text.Trim.Equals(cur_username.Trim) Then
            If changepassword = True Then
                'login logout
            End If
            If changerole = True Then
                cur_isadmin = isadmin.Checked
                cur_canAdd = canmodify.Checked
                cur_canService = canservice.Checked
                cur_mod_user = moduseraccess.Checked
            End If
        End If
        Me.Close()
    End Sub
    Private Sub MaintainUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        M_Username.ReadOnly = True
        If showuser = True Then
            Try
                cmd.CommandText = "select * from UserAcc where U_Name=@U_Name"
                cmd.Parameters.AddWithValue("@U_Name", showusername)
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    M_Username.Text = dr("U_Name").ToString
                    M_O_Password.Text = dr("U_Password").ToString
                    isadmin.Checked = Convert.ToBoolean(dr("Is_admin").ToString)
                    canservice.Checked = Convert.ToBoolean(dr("Can_Service").ToString)
                    canmodify.Checked = Convert.ToBoolean(dr("Can_add").ToString)
                    moduseraccess.Checked = Convert.ToBoolean(dr("Can_Mod_User").ToString)
                End If
                dr.Close()
                cmd.Parameters.Clear()
            Catch ex As Exception
                dr.Close()
                cmd.Parameters.Clear()
                MsgBox(ex.Message.ToString)
            End Try
            old = M_O_Password.Text.Trim
            M_O_Password.Enabled = False
            M_N_Password.Enabled = False
            M_N_Password1.Enabled = False
            isadmin.Enabled = False
            canservice.Enabled = False
            canmodify.Enabled = False
            moduseraccess.Enabled = False
            M_O_Password.ResetText()
            If cur_username.Equals(M_Username.Text) Then
                M_Username.ReadOnly = True


                M_O_Password.Enabled = True
                M_N_Password.Enabled = True
                M_N_Password1.Enabled = True
                isadmin.Enabled = False
                canservice.Enabled = False
                canmodify.Enabled = False
                moduseraccess.Enabled = False
            End If
            If cur_isadmin = True Or cur_mod_user = True Then
                isadmin.Enabled = True
                canservice.Enabled = True
                canmodify.Enabled = True
                moduseraccess.Enabled = True
            End If
        End If
    End Sub

    Private Sub canservice_CheckedChanged(sender As Object, e As EventArgs) Handles canservice.CheckedChanged
        rolechange = rolechange + 1
    End Sub

    Private Sub canmodify_CheckedChanged(sender As Object, e As EventArgs) Handles canmodify.CheckedChanged
        rolechange = rolechange + 1
    End Sub

    Private Sub moduseraccess_CheckedChanged(sender As Object, e As EventArgs) Handles moduseraccess.CheckedChanged
        rolechange = rolechange + 1
    End Sub
End Class