Public Class UserManagerX
    'Public Sub checkAdminPres(username As String, password As String)
    '    Try
    '        cmd.CommandText = "select * from users"
    '        dr = cmd.ExecuteReader
    '        Dim i As Integer = 0
    '        If dr.Read() Then
    '            While dr.Read()
    '                i = i + 1
    '            End While
    '            dr.Close()
    '            cmd.Parameters.Clear()
    '            usercount = i
    '            If i > 3 Then
    '                MessageBox.Show("At Max 3 Users are suported by the Current Software")
    '            Else
    '                'adduser()
    '            End If
    '        Else
    '            dr.Close()
    '            cmd.Parameters.Clear()
    '            ' saveadmin(username, password)
    '        End If
    '    Catch ex As Exception
    '        dr.Close()
    '        cmd.Parameters.Clear()
    '        MsgBox(ex.Message.ToString)
    '    End Try

    'End Sub
  
    Public Function adminPresent() As Boolean
        Try
            cmd.CommandText = "select * from UserAcc where Is_admin=True"
            dr = cmd.ExecuteReader
            Dim i As Integer = 0
            If dr.Read() Then
                dr.Close()
                ' MessageBox.Show("Admin is present")
                Return True
            Else
                dr.Close()
                'MessageBox.Show("Admin is not Present")
                Return False
            End If
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString)
        End Try
        Return False
    End Function
    Public Sub addAdmin(Username As String, Password As String)
        Try
            'cmd.CommandText = "insert into Users(UserName,Password,Is_admin,Can_add,Can_Service,Can_Mod_User) values (@UserName,@Password,TRUE,TRUE,TRUE,TRUE)"
            cmd.CommandText = "insert into UserAcc (U_Name,U_Password,Is_admin,Can_add,Can_Service,Can_Mod_User) values ('" & Username & "','" & Password & "'," & True & "," & True & "," & True & "," & True & ")"
            'cmd.Parameters.AddWithValue("@UserName", Username.ToString)
            ' cmd.Parameters.AddWithValue("@Password", Password.ToString)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString)
        End Try
        cur_username = Username
        cur_password = Password
        cur_isadmin = True
        cur_canAdd = True
        cur_canService = True
        cur_mod_user = True
    End Sub
    Public Function authenticateuser(Username As String, Password As String) As Boolean
        Dim U_Name As String = String.Empty
        Dim U_Pass As String = String.Empty
        Try
            cmd.CommandText = "select * from UserAcc where U_Name=@U_Name"
            cmd.Parameters.AddWithValue("@U_Name", Username)
            dr = cmd.ExecuteReader
            If dr.Read Then
                U_Name = dr("U_Name").ToString
                U_Pass = dr("U_Password").ToString
                
                If (U_Name.Equals(Username.Trim) And U_Pass.Equals(Password.Trim)) Then
                    cur_username = U_Name
                    cur_password = U_Pass
                    cur_isadmin = Convert.ToBoolean(dr("Is_admin").ToString)
                    cur_canAdd = Convert.ToBoolean(dr("Can_add").ToString)
                    cur_canService = Convert.ToBoolean(dr("Can_Service").ToString)
                    cur_mod_user = Convert.ToBoolean(dr("Can_Mod_User").ToString)
                    dr.Close()
                    cmd.Parameters.Clear()
                    Return True
                Else
                    dr.Close()
                    cmd.Parameters.Clear()
                    Return False
                End If
            Else
                dr.Close()
                cmd.Parameters.Clear()
                Return False
            End If
            dr.Close()
            cmd.Parameters.Clear()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString)
        End Try
        Return False
    End Function
    Public Sub adduser(add_username As String, add_password As String, isadmin As Boolean, canservice As Boolean, canmodify As Boolean, moduseraccess As Boolean)
        Try
            'cmd.CommandText = "insert into Users(UserName,Password,Is_admin,Can_add,Can_Service,Can_Mod_User) values (@UserName,@Password,TRUE,TRUE,TRUE,TRUE)"
            cmd.CommandText = "insert into UserAcc (U_Name,U_Password,Is_admin,Can_add,Can_Service,Can_Mod_User) values ('" & add_username & "','" & add_password & "'," & isadmin & "," & canmodify & "," & canservice & "," & moduseraccess & ")"
            'cmd.Parameters.AddWithValue("@UserName", Username.ToString)
            ' cmd.Parameters.AddWithValue("@Password", Password.ToString)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString)
        End Try

    End Sub
    Public Sub updatePassword(Username As String, New_Password As String)
        Try
            cmd.CommandText = "update UserAcc set U_Password=@New_Password where U_Name=@U_Name"
            cmd.Parameters.AddWithValue("@New_Password", New_Password)
            cmd.Parameters.AddWithValue("@U_Name", Username)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Password Updated")
            cmd.Parameters.Clear()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub updateRoles(username As String, isadmin As Boolean, can_add As Boolean, can_Service As Boolean, can_Mod_User As Boolean)
        Try
            cmd.CommandText = "update UserAcc set Is_admin=@Is_admin,Can_add=@Can_add,Can_Service=@Can_Service,Can_Mod_User=@Can_Mod_User where U_Name=@U_Name"
            cmd.Parameters.AddWithValue("@Is_admin", isadmin)
            cmd.Parameters.AddWithValue("@Can_add", can_add)
            cmd.Parameters.AddWithValue("@Can_Service", can_Service)
            cmd.Parameters.AddWithValue("@Can_Mod_User", can_Mod_User)
            cmd.Parameters.AddWithValue("@U_Name", username)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class
