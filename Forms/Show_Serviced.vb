Public Class Show_Serviced

    Private Sub load_Serviced()
        S_Month.Items.Add("January")
        S_Month.Text = "January"
        S_Month.Items.Add("February")
        S_Month.Text = "February"
        S_Month.Items.Add("March")
        S_Month.Text = "March"
        S_Month.Items.Add("April")
        S_Month.Text = "April"
        S_Month.Items.Add("May")
        S_Month.Text = "May"
        S_Month.Items.Add("June")
        S_Month.Text = "June"
        S_Month.Items.Add("July")
        S_Month.Text = "July"
        S_Month.Items.Add("August")
        S_Month.Text = "August"
        S_Month.Items.Add("September")
        S_Month.Text = "September"
        S_Month.Items.Add("October")
        S_Month.Text = "October"
        S_Month.Items.Add("November")
        S_Month.Text = "November"
        S_Month.Items.Add("December")
        S_Month.Text = "December"
        S_Month.SelectedIndex = Date.Now.Month - 1
        Try
            'S_Prod.Text = "All Products"
            S_Prod.Items.Add("All Products")
            cmd.CommandText = "select Product_Name from Prod where ID=@ID order by Product_Id"
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            Dim prd As String


            dr = cmd.ExecuteReader()
            While dr.Read()
                prd = dr("Product_Name").ToString()
                S_Prod.Items.Add(prd)
                'MessageBox.Show(prd)
            End While
            dr.Close()
            cmd.Parameters.Clear()

        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
        S_Prod.SelectedIndex = -1

        Try
            S_DataGrd.AllowUserToAddRows() = False
            S_DataGrd.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            S_DataGrd.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            S_DataGrd.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            S_DataGrd.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            S_DataGrd.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            S_DataGrd.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
            S_DataGrd.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
            S_DataGrd.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
            S_DataGrd.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable

            Dim i As Integer = 0
            cmd.CommandText = "Select Customer_Id,Customer_Name,Product_Name,DOI,Next_Service,Customer_Address,Phone_NUmber,Alt_Phone_Number,Serviced,Feedback from Cust where Service_Count>0 and ID=@ID"
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader()
            S_DataGrd.Rows.Clear()
            While (dr.Read)

                'If (CDate(dr("Next_Service").ToString()).Month = S_Month.SelectedIndex) Then
                S_DataGrd.Rows.Add()
                S_DataGrd.Rows(i).Cells(0).Value = dr("Customer_Id").ToString()
                S_DataGrd.Rows(i).Cells(1).Value = dr("Customer_Name").ToString()
                S_DataGrd.Rows(i).Cells(2).Value = dr("Product_Name").ToString()
                S_DataGrd.Rows(i).Cells(3).Value = CDate(dr("DOI").ToString()).ToShortDateString()
                S_DataGrd.Rows(i).Cells(4).Value = CDate(dr("Next_Service").ToString()).ToShortDateString()
                S_DataGrd.Rows(i).Cells(5).Value = dr("Customer_Address").ToString()
                ' S_DataGrd.Rows(i).Cells(3).Value = CDate(dr("DOP").ToString()).ToShortDateString()
                S_DataGrd.Rows(i).Cells(6).Value = dr("Phone_Number").ToString() + "  /  " + dr("Alt_Phone_Number").ToString()

                S_DataGrd.Rows(i).Cells(7).Value = True
                ' If (S_DataGrd.Rows(i).Cells(7).Value = True) Then
                'S_DataGrd.Rows(i).Cells(8).ReadOnly = True
                ' End If
                S_DataGrd.Rows(i).Cells(8).Value = dr("Feedback").ToString()
                'End If

                i = i + 1
            End While
            dr.Close()
            cmd.Parameters.Clear()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
        Cid_remove.Clear()
    End Sub

    Private Sub Show_Serviced_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.Z Then
            Save_Undo()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Space Then
            Try
                If S_DataGrd.Rows.Count > 0 Then
                    If S_DataGrd.CurrentRow.Index >= 0 Then
                        If S_DataGrd.CurrentRow.Cells(7).Value = True Then
                            S_DataGrd.CurrentRow.Cells(7).Value = False
                            Cid_remove.Add(S_DataGrd.CurrentRow.Index)
                        ElseIf S_DataGrd.CurrentRow.Cells(7).Value = False Then
                            S_DataGrd.CurrentRow.Cells(7).Value = True
                            If Cid_remove.Contains(S_DataGrd.CurrentRow.Index) Then
                                Cid_remove.Remove(S_DataGrd.CurrentRow.Index)
                            End If
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            S_DataGrd.Focus()
        End If
        'ElseIf e.KeyCode = Keys.Space Then
        '    If S_DataGrd.Rows.Count > 0 And S_DataGrd.CurrentRow.Index >= 0 Then
        '        If S_DataGrd.CurrentRow.Cells(7).Value = False Then
        '            S_DataGrd.CurrentRow.Cells(7).Value = True
        '            Cid_remove.Add(S_DataGrd.CurrentRow.Index)
        '        ElseIf S_DataGrd.CurrentRow.Cells(7).Value = True And Cid_remove.Contains(S_DataGrd.CurrentRow.Index) Then
        '            S_DataGrd.CurrentRow.Cells(7).Value = False
        '            Cid_remove.Remove(S_DataGrd.CurrentRow.Index)
        '        End If
        '    End If
        'ElseIf e.KeyCode = Keys.Down Then
        '    If S_DataGrd.Rows.Count > 0 And S_DataGrd.CurrentRow.Index < S_DataGrd.Rows.Count - 1 Then
        '        Dim i As Integer = S_DataGrd.CurrentRow.Index
        '        MessageBox.Show("Down")
        '        S_DataGrd.Rows(i + 1).Selected = True
        '    End If
        'ElseIf e.KeyCode = Keys.Up Then
        '    If S_DataGrd.Rows.Count > 0 Then
        '        Try
        '            Dim i As Integer = S_DataGrd.CurrentRow.Index
        '            If i >= 0 Then
        '                S_DataGrd.Rows(i - 1).Selected = True
        '            End If
        '        Catch ex As Exception
        '            MsgBox(ex.Message.ToString)
        '        End Try
        '    End If

    End Sub
    Private Sub Show_Serviced_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cid_remove.Clear()
        Show_Search_Panel.Enabled = False
        S_DataGrd.Focus()
        load_Serviced()
        S_DataGrd.Focus()
        'S_DataGrd.Rows(0).Selected = True
        Me.KeyPreview = True
    End Sub
    






    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Save_Undo()
    End Sub
    Public Sub Save_Undo()
        For Each i In Cid_remove

            If Cid_remove.Contains(i) Then
                undo(i)
            End If
        Next
        Cid_Changed.Clear()
        load_Serviced()
        Main2.loadWithMonth()
        Me.Close()
    End Sub
    Private Sub undo(ByVal i As Integer)

        Dim interval As Integer
        Dim nsdate As Date
        Dim count As Integer
        Try
            cmd.CommandText = "select Service_Interval,Next_Service,Service_Count from Cust where Customer_Id=@Customer_Id and ID=@ID"
            cmd.Parameters.AddWithValue("@Customer_Id", S_DataGrd.Rows(i).Cells(0).Value.ToString())
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                interval = Convert.ToInt32(dr("Service_Interval").ToString)
                nsdate = Convert.ToDateTime(dr("Next_Service").ToString)
                count = Convert.ToInt32(dr("Service_Count").ToString)
            End If
            dr.Close()
            cmd.Parameters.Clear()

        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString)
        End Try
        nsdate = nsdate.AddMonths(interval * -1)
        count = count - 1
        Try
            cmd.CommandText = "update Cust set Next_Service=@nsdate,Service_Count=@count where Customer_Id=@Customer_Id and ID=@ID"
            cmd.Parameters.AddWithValue("@d_temp", nsdate)

            ' MessageBox.Show(nsdate.ToString)

            cmd.Parameters.AddWithValue("@count", count)
            '  MessageBox.Show(count.ToString)

            cmd.Parameters.AddWithValue("@Customer_Id", S_DataGrd.Rows(i).Cells(0).Value.ToString())
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            'MessageBox.Show("next Date=" + d_temp)

        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try


    End Sub

    Private Sub S_Search_Click(sender As Object, e As EventArgs) Handles S_Search.Click
        Try


            Dim i As Integer = 0
            cmd.CommandText = "Select Customer_Id,Customer_Name,Product_Name,DOI,Next_Service,Customer_Address,Phone_NUmber,Alt_Phone_Number,Serviced,Feedback from Cust where MONTH(Next_Service)=@C_Month and Product_Name=@S_Prod AND ID=@ID"
            cmd.Parameters.AddWithValue("@C_Month", S_Month.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@S_Prod", S_Prod.Text)
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader()
            ' MessageBox.Show(S_Prod.Text)
            S_DataGrd.Rows.Clear()
            While (dr.Read)

                'If (CDate(dr("Next_Service").ToString()).Month = S_Month.SelectedIndex) Then
                S_DataGrd.Rows.Add()
                S_DataGrd.Rows(i).Cells(0).Value = dr("Customer_Id").ToString()
                S_DataGrd.Rows(i).Cells(1).Value = dr("Customer_Name").ToString()
                S_DataGrd.Rows(i).Cells(2).Value = dr("Product_Name").ToString()
                S_DataGrd.Rows(i).Cells(3).Value = CDate(dr("DOI").ToString()).ToShortDateString()
                S_DataGrd.Rows(i).Cells(4).Value = CDate(dr("Next_Service").ToString()).ToShortDateString()
                S_DataGrd.Rows(i).Cells(5).Value = dr("Customer_Address").ToString()
                ' S_DataGrd.Rows(i).Cells(3).Value = CDate(dr("DOP").ToString()).ToShortDateString()
                S_DataGrd.Rows(i).Cells(6).Value = dr("Phone_Number").ToString() + "  /  " + dr("Alt_Phone_Number").ToString()

                S_DataGrd.Rows(i).Cells(7).Value = dr("Serviced").ToString()
                If (S_DataGrd.Rows(i).Cells(7).Value = True) Then
                    S_DataGrd.Rows(i).Cells(8).ReadOnly = True
                End If
                S_DataGrd.Rows(i).Cells(8).Value = dr("Feedback").ToString()
                'End If

                i = i + 1
            End While
            dr.Close()
            cmd.Parameters.Clear()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
        If (S_DataGrd.Rows.Count = 0) Then
            S_DataGrd.EmptyDataText = "No Data Found !!!!"
        Else
            S_DataGrd.EmptyDataText = String.Empty
        End If
    End Sub

    Private Sub S_DataGrd_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        If S_DataGrd.IsCurrentCellDirty Then
            If e.ColumnIndex = 7 Then
                If S_DataGrd.Rows(e.RowIndex).Cells(7).Value = False Then
                    Cid_remove.Add(e.RowIndex)
                ElseIf S_DataGrd.Rows(e.RowIndex).Cells(7).Value = True And Cid_remove.Contains(e.RowIndex) Then
                    Cid_remove.Remove(e.RowIndex)
                End If
            End If
        End If

    End Sub
    Private Sub dgviewservice_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
        If S_DataGrd.IsCurrentCellDirty Then
            S_DataGrd.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

End Class