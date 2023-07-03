Public Class UsersForm

    Private Sub UsersForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.N Then
            If cur_mod_user = True Then
                Dim newuser As New AddUser
                newuser.ShowDialog()
                loadusers()
            Else
                MessageBox.Show("Your Account does not have privilages to add Users")
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.O Then
            Dim open As New MaintainUser
            showuser = True
            showusername = Us_grid.CurrentRow.Cells(0).Value.ToString
            open.ShowDialog()
            loadusers()

        End If
    End Sub

    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        loadusers()
       
    End Sub
    Public Sub loadusers()
        Try
            Us_grid.ColumnCount = 5
            Us_grid.Columns(0).Name = "Username"
            Us_grid.Columns(1).Name = "Administrator"
            Us_grid.Columns(2).Name = "Can Modify Data"
            Us_grid.Columns(3).Name = "Can Service Customer"
            Us_grid.Columns(4).Name = "Can Modify User"
            Us_grid.Rows.Clear()
            Dim i As Integer = 0
            cmd.CommandText = "select * from UserAcc"
            dr = cmd.ExecuteReader
            While dr.Read
                Us_grid.Rows.Add()
                Us_grid.Rows(i).Cells(0).Value = dr("U_Name").ToString
                Us_grid.Rows(i).Cells(1).Value = Convert.ToBoolean(dr("Is_admin").ToString)
                Us_grid.Rows(i).Cells(2).Value = Convert.ToBoolean(dr("Can_add").ToString)
                Us_grid.Rows(i).Cells(3).Value = Convert.ToBoolean(dr("Can_Service").ToString)
                Us_grid.Rows(i).Cells(4).Value = Convert.ToBoolean(dr("Can_Mod_User").ToString)
                i = i + 1
            End While
            dr.Close()
            cmd.Parameters.Clear()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString)
        End Try
        Dim admincheck As New UserManagerX
        If admincheck.adminPresent() = False Then
            MessageBox.Show("There must be atleast one Administrator present")
            If MessageBox.Show("Do you want to create a new administrator account?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Dim adm As New newUser
                adm.ShowDialog()

            End If
        End If
    End Sub
End Class