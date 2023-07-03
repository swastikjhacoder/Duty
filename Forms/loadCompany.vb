Public Class loadCompany

    Private Sub loadCompany_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.N Then
            Dim r As New company
            r.ShowDialog()
        ElseIf e.Control And e.KeyCode = Keys.E Then
            If (cm_datagrd.RowCount > 0) Then
                If cm_datagrd.CurrentRow.Index >= 0 Then
                    'loadcomp = cm_datagrd.CurrentRow.Index
                    Try
                        cmd.CommandText = "select ID from Company where Comp_Name=@Comp_Name"
                        cmd.Parameters.AddWithValue("@Comp_Name", cm_datagrd.CurrentRow.Cells(0).Value.ToString)
                        dr = cmd.ExecuteReader
                        If dr.Read() Then
                            loadcomp = Convert.ToInt32(dr("ID").ToString)
                        End If
                        dr.Close()
                        cmd.Parameters.Clear()
                    Catch ex As Exception
                        dr.Close()
                        cmd.Parameters.Clear()
                        MsgBox(ex.Message.ToString)
                    End Try
                End If

                Comp_Show_G = True
                Comp_Show_ID = loadcomp
                Dim t As New company
                t.ShowDialog()
                loadcompany()
            End If
        ElseIf e.Control And e.KeyCode = Keys.O Then
            If (cm_datagrd.RowCount > 0) Then
                If cm_datagrd.CurrentRow.Index >= 0 Then
                    'loadcomp = cm_datagrd.CurrentRow.Index
                    Try
                        cmd.CommandText = "select ID from Company where Comp_Name=@Comp_Name"
                        cmd.Parameters.AddWithValue("@Comp_Name", cm_datagrd.CurrentRow.Cells(0).Value.ToString)
                        dr = cmd.ExecuteReader
                        If dr.Read() Then
                            loadcomp = Convert.ToInt32(dr("ID").ToString)
                        End If
                        dr.Close()
                        cmd.Parameters.Clear()
                    Catch ex As Exception
                        dr.Close()
                        cmd.Parameters.Clear()
                        MsgBox(ex.Message.ToString)
                    End Try
                    Dim logincheck As New UserManagerX
                    If logincheck.adminPresent = False Then
                        Dim mform As New Main2
                        mform.Show()
                    Else
                        Dim login As New LoginForm
                        LoginForm.ShowDialog()
                    End If
                    Me.Close()
                End If
            End If
            ElseIf e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
    End Sub

    Private Sub loadCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        Me.KeyPreview = True
        loadcompany()
    End Sub
    Public Sub loadcompany()
        cm_datagrd.Rows.Clear()
        cm_datagrd.ColumnCount = 1
        cm_datagrd.Columns(0).Name = "Company"
        Dim i As Integer = 0
        Try
            cmd.CommandText = "select * from company"
            dr = cmd.ExecuteReader()
            While dr.Read()

                cm_datagrd.Rows.Add()
                cm_datagrd.Rows(i).Cells(0).Value = dr("Comp_Name").ToString()
                i = i + 1
            End While
            dr.Close()
            cmd.Parameters.Clear()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Cm_open_Click(sender As Object, e As EventArgs)
        If (cm_datagrd.RowCount > 0) Then
            If cm_datagrd.CurrentRow.Index >= 0 Then
                'loadcomp = cm_datagrd.CurrentRow.Index
                Try
                    cmd.CommandText = "select ID from Company where Comp_Name=@Comp_Name"
                    cmd.Parameters.AddWithValue("@Comp_Name", cm_datagrd.CurrentRow.Cells(0).Value.ToString)
                    dr = cmd.ExecuteReader
                    If dr.Read() Then
                        loadcomp = Convert.ToInt32(dr("ID").ToString)
                    End If
                    dr.Close()
                    cmd.Parameters.Clear()
                Catch ex As Exception
                    dr.Close()
                    cmd.Parameters.Clear()
                    MsgBox(ex.Message.ToString)
                End Try
                Dim logincheck As New UserManagerX
                If logincheck.adminPresent = False Then
                    Dim mform As New Main2
                    mform.Show()
                Else
                    Dim login As New LoginForm
                    LoginForm.ShowDialog()
                End If
                Me.Close()
            End If
        End If
    End Sub

    Private Sub cm_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

  
End Class