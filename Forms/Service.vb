Imports System.Text

Public Class Service

    Public Sub loadAll()
        S_Save.Enabled = False
        Try
            S_Month.SelectedIndex = -1
            Dim i As Integer = 0
            cmd.CommandText = "Select Customer_Id,Customer_Name,Product_Name,DOI,Next_Service,Customer_Address,Phone_NUmber,Alt_Phone_Number,Serviced,Feedback from Cust"
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
            S_NO.Visible = True
        Else
            S_NO.Visible = False
        End If
    End Sub
    Public Sub loadWithMonth()
        S_Save.Enabled = True


        Try


            Dim i As Integer = 0
            cmd.CommandText = "Select Customer_Id,Customer_Name,Product_Name,DOI,Next_Service,Customer_Address,Phone_NUmber,Alt_Phone_Number,Serviced,Feedback from Cust where MONTH(Next_Service)=@C_Month"
            cmd.Parameters.AddWithValue("@C_Month", S_Month.SelectedIndex + 1)
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
            S_NO.Visible = True
        Else
            S_NO.Visible = False
        End If
    End Sub
    Private Sub Service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        S_DataGrd.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        S_DataGrd.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        S_DataGrd.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        S_DataGrd.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        S_DataGrd.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        S_DataGrd.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        S_DataGrd.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        S_DataGrd.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
        S_DataGrd.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
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
        'S_Save.Enabled = False
        S_DataGrd.AllowUserToAddRows() = False
        Try
            'S_Prod.Text = "All Products"
            S_Prod.Items.Add("All Products")
            cmd.CommandText = "select Product_Name from Prod order by Product_Id"
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
        loadWithMonth()
        If (S_DataGrd.Rows.Count = 0) Then
            S_Save.Enabled = False
            S_NO.Visible = True
        End If
        If (S_DataGrd.Rows.Count = 0) Then
            S_NO.Visible = True
        Else
            S_NO.Visible = False
        End If
    End Sub

    Private Sub P_Catagory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S_Month.SelectedIndexChanged

        loadWithMonth()
        If (S_DataGrd.Rows.Count = 0) Then
            S_NO.Visible = True
        Else
            S_NO.Visible = False
        End If
        S_Prod.ResetText()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles S_Search.Click
        Try


            Dim i As Integer = 0
            cmd.CommandText = "Select Customer_Id,Customer_Name,Product_Name,DOI,Next_Service,Customer_Address,Phone_NUmber,Alt_Phone_Number,Serviced,Feedback from Cust where MONTH(Next_Service)=@C_Month and Product_Name=@S_Prod"
            cmd.Parameters.AddWithValue("@C_Month", S_Month.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@S_Prod", S_Prod.Text)
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
            S_NO.Visible = True
        Else
            S_NO.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles S_Clear.Click
        S_Month.SelectedIndex = -1
        S_Prod.SelectedIndex = -1
        S_Save.Enabled = False
        loadAll()
        If (S_DataGrd.Rows.Count = 0) Then
            S_NO.Visible = True
        Else
            S_NO.Visible = False
        End If
    End Sub

    
    'code
    Private Sub dgviewservice_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles S_DataGrd.CurrentCellDirtyStateChanged
        If S_DataGrd.IsCurrentCellDirty Then
            S_DataGrd.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        S_Save.Enabled = False
        loadAll()
        If (S_DataGrd.Rows.Count = 0) Then
            S_NO.Visible = True
        Else
            S_NO.Visible = False
        End If
    End Sub

    

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Refresh.Click, Refresh.Click
        S_Month.SelectedIndex = -1
        S_Prod.SelectedIndex = -1
        S_Save.Enabled = False
        loadAll()
        If (S_DataGrd.Rows.Count = 0) Then
            S_NO.Visible = True
        Else
            S_NO.Visible = False
        End If

    End Sub
    'code
    Private Sub dgviewservice_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles S_DataGrd.CellValueChanged

        'Try
        '    If S_DataGrd.Rows.Count > 0 Then
        '        If e.ColumnIndex = 7 Then
        '            If (S_DataGrd.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) Then
        '                MessageBox.Show(" oh yes")
        '                S_DataGrd.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = ""
        '                S_DataGrd.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).ReadOnly = True
        '                Try
        '                    cmd.CommandText = "update Cust set Serviced=True ,Feedback=@Feedback where Customer_id=@Customer_Id"
        '                    cmd.Parameters.AddWithValue("@Feedback", S_DataGrd.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value.ToString())
        '                    cmd.Parameters.AddWithValue("@Customer_Id", S_DataGrd.Rows(e.RowIndex).Cells(0).Value.ToString())
        '                    cmd.ExecuteNonQuery()
        '                    cmd.Parameters.Clear()
        '                Catch ex As Exception
        '                    dr.Close()
        '                    cmd.Parameters.Clear()
        '                    MsgBox(ex.Message.ToString)
        '                End Try
        '            Else
        '                S_DataGrd.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).ReadOnly = False
        '                If (S_DataGrd.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value = "") Then
        '                    If MessageBox.Show("Please enter Feedback", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
        '                        S_DataGrd.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Selected = True
        '                    End If

        '                End If

        '            End If
        '        ElseIf e.ColumnIndex = 8 Then
        '            S_Index = e.RowIndex
        '            '    If (S_DataGrd.Rows(e.RowIndex).Cells(e.ColumnIndex).) Then
        '            '        Try
        '            '            cmd.CommandText = "update Cust set Serviced=false ,Feedback=@Feedback where Customer_id=@Customer_Id"
        '            '            cmd.Parameters.AddWithValue("@Feedback", S_DataGrd.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value.ToString())
        '            '            cmd.Parameters.AddWithValue("@Customer_Id", S_DataGrd.Rows(e.RowIndex).Cells(0).Value.ToString())
        '            '            cmd.ExecuteNonQuery()
        '            '            cmd.Parameters.Clear()
        '            '        Catch ex As Exception
        '            '            dr.Close()
        '            '            cmd.Parameters.Clear()
        '            '            MsgBox(ex.Message.ToString)
        '            '        End Try
        '            '    End If
        '        End If
        '    End If
        'Catch ex As Exception

        'End Try

        ''Try
        ''    cmd.CommandText = "update Cust set Serviced=@Serviced ,Feedback=@Feedback where Customer_id=@Customer_Id"
        ''    cmd.Parameters.AddWithValue("@Serviced", S_DataGrd.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        ''    cmd.Parameters.AddWithValue("@Feedback", S_DataGrd.Rows(e.RowIndex).Cells(e.ColumnIndex + 1).Value)
        ''    cmd.Parameters.AddWithValue("@Customer_Id", S_DataGrd.Rows(e.RowIndex).Cells(0))
        ''    cmd.ExecuteNonQuery()
        ''    cmd.Parameters.Clear()
        ''Catch ex As Exception
        ''    dr.Close()
        ''    cmd.Parameters.Clear()
        ''    MsgBox(ex.Message.ToString)
        ''End Try
        'this is redundant after debug
        Try
            If S_DataGrd.Rows.Count > 0 Then

                If e.ColumnIndex = 8 Or e.ColumnIndex = 7 Then
                    S_Index = e.RowIndex
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub S_Save_Click(sender As Object, e As EventArgs) Handles S_Save.Click
        Dim S_Next_Inv As Integer = 0
        ' MessageBox.Show(S_Index.ToString())
        Try
            If (S_DataGrd.Rows(S_Index).Cells(7).Value = True) Then
                S_DataGrd.Rows(S_Index).Cells(8).Value = ""
                cmd.CommandText = "update Cust set Serviced=True ,Feedback=@Feedback where Customer_id=@Customer_Id"
                S_Next_Inv = 1
            Else
                cmd.CommandText = "update Cust set Next_Service=@d_temp ,Serviced=false ,Feedback=@Feedback where Customer_id=@Customer_Id"
                Dim d_temp As Date = CDate(S_DataGrd.Rows(S_Index).Cells(4).Value.ToString()).ToShortDateString()
                d_temp = d_temp.AddMonths(1)

                cmd.Parameters.AddWithValue("@d_temp", d_temp)

            End If
            cmd.Parameters.AddWithValue("@Feedback", S_DataGrd.Rows(S_Index).Cells(8).Value.ToString())
            cmd.Parameters.AddWithValue("@Customer_Id", S_DataGrd.Rows(S_Index).Cells(0).Value.ToString())
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString)
        End Try

        If (S_Next_Inv = 1) Then
            Dim up As New ClsCustomer
            up.setnextnext(S_DataGrd.Rows(S_Index).Cells(0).Value.ToString())
        End If
        If (S_Month.SelectedIndex <> -1) Then
            loadWithMonth()
        Else
            S_Save.Enabled = False
            loadAll()
            If (S_DataGrd.Rows.Count = 0) Then
                S_NO.Visible = True
            Else
                S_NO.Visible = False
            End If
            S_Index = -1
        End If
    End Sub
    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        Try
            If ((S_DataGrd.Columns.Count = 0) Or (S_DataGrd.Rows.Count = 0)) Then
                If MessageBox.Show("No record found to export!!!", "Duty - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Stop) = DialogResult.OK Then
                    Exit Sub
                End If
            Else
                'Dim Imagefile As String = AppDomain.CurrentDomain.BaseDirectory + "\\ESAR Report.bmp"
                Dim dset As New DataSet
                dset.Tables.Add()
                For i As Integer = 0 To S_DataGrd.ColumnCount - 1
                    dset.Tables(0).Columns.Add(S_DataGrd.Columns(i).HeaderText)
                Next
                Dim dr1 As DataRow
                For i As Integer = 0 To S_DataGrd.RowCount - 1
                    dr1 = dset.Tables(0).NewRow
                    For j As Integer = 0 To S_DataGrd.Columns.Count - 1
                        dr1(j) = S_DataGrd.Rows(i).Cells(j).Value
                    Next
                    dset.Tables(0).Rows.Add(dr1)
                Next
                Dim excel As New Microsoft.Office.Interop.Excel.Application
                Dim wBook As Microsoft.Office.Interop.Excel.Workbook
                Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
                wBook = excel.Workbooks.Add()
                wSheet = wBook.ActiveSheet()
                Dim dt As System.Data.DataTable = dset.Tables(0)
                Dim dc As System.Data.DataColumn
                Dim dr As System.Data.DataRow
                Dim colIndex As Integer = 0
                Dim rowIndex As Integer = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(1, colIndex) = dc.ColumnName
                Next
                For Each dr In dt.Rows
                    rowIndex = rowIndex + 1
                    colIndex = 0
                    For Each dc In dt.Columns
                        colIndex = colIndex + 1
                        excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                    Next
                Next
                wSheet.Columns.AutoFit()
                Dim strFileName As String = "Customer List" + "_" + Now.ToString("dd-mm-yyyy_hh.mm.ss") + ".xls"
                Dim blnFileOpen As Boolean = False
                Try
                    Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                    fileTemp.Close()
                Catch ex As Exception
                    blnFileOpen = False
                End Try
                If System.IO.File.Exists(strFileName) Then
                    System.IO.File.Delete(strFileName)
                End If
                'wSheet.SetBackgroundPicture(Imagefile)
                wBook.SaveAs(strFileName)
                excel.Workbooks.Open(strFileName)
                excel.Visible = True
                ' MessageBox.Show("Export")
            End If
        Catch ex As Exception

        End Try
    

        '    Dim default_location As String = Application.StartupPath & "\kuchina\" & Me.Text & ".xls"
        ''Creating dataset to export
        'Dim dset As New DataSet
        ''add table to dataset
        '    dset.Tables.Add()
        ''add column to that table
        '    For i As Integer = 0 To S_DataGrd.ColumnCount - 1
        '        dset.Tables(0).Columns.Add(S_DataGrd.Columns(i).HeaderText)
        '    Next
        ''add rows to the table
        'Dim dr1 As DataRow
        '    For i As Integer = 0 To S_DataGrd.RowCount - 1
        '        dr1 = dset.Tables(0).NewRow
        '        For j As Integer = 0 To S_DataGrd.Columns.Count - 1
        '            dr1(j) = S_DataGrd.Rows(i).Cells(j).Value
        '        Next
        '        dset.Tables(0).Rows.Add(dr1)
        '    Next

        'Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        'Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        'Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        '    excel.Visible = True
        '    excel.UserControl = True

        '    wBook = excel.Workbooks.Add(System.Reflection.Missing.Value)
        '    wSheet = wBook.Sheets("sheet1")
        '    excel.Range("A50:I50").EntireColumn.AutoFit()
        '    With wBook
        '        .Sheets("Sheet1").Select()
        '        .Sheets(1).Name = "NameYourSheet"
        '    End With

        'Dim dt As System.Data.DataTable = dset.Tables(0)
        '    wSheet.Cells(1).value = Me.Text

        '    For i = 0 To S_DataGrd.RowCount - 1
        '        For j = 0 To S_DataGrd.ColumnCount - 1
        '            wSheet.Cells(i + 1, j + 1).value = S_DataGrd.Rows(i).Cells(j).Value.tosring
        '        Next j
        '    Next i

        '    wSheet.Columns.AutoFit()
        'Dim blnFileOpen As Boolean = False
        '    Try
        'Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(default_location)
        '        fileTemp.Close()
        '    Catch ex As Exception
        '        blnFileOpen = False
        '    End Try

        '    If System.IO.File.Exists(default_location) Then
        '        System.IO.File.Delete(default_location)
        '    End If

        '    wBook.SaveAs(default_location)
        '    excel.Workbooks.Open(default_location)
        '    excel.Visible = True
    End Sub

    Private Sub S_Show_Serviced_Click(sender As Object, e As EventArgs) Handles S_Show_Serviced.Click

        ' Dim frm As New Show_Serviced
        'frm.Show()
        'Try
        '    S_Month.SelectedIndex = -1
        '    Dim i As Integer = 0
        '    cmd.CommandText = "Select Customer_Id,Customer_Name,Product_Name,DOI,Next_Service,Customer_Address,Phone_NUmber,Alt_Phone_Number,Serviced,Feedback from Cust where Service_Count>0"
        '    dr = cmd.ExecuteReader()
        '    S_DataGrd.Rows.Clear()
        '    While (dr.Read)

        '        'If (CDate(dr("Next_Service").ToString()).Month = S_Month.SelectedIndex) Then
        '        S_DataGrd.Rows.Add()
        '        S_DataGrd.Rows(i).Cells(0).Value = dr("Customer_Id").ToString()
        '        S_DataGrd.Rows(i).Cells(1).Value = dr("Customer_Name").ToString()
        '        S_DataGrd.Rows(i).Cells(2).Value = dr("Product_Name").ToString()
        '        S_DataGrd.Rows(i).Cells(3).Value = CDate(dr("DOI").ToString()).ToShortDateString()
        '        S_DataGrd.Rows(i).Cells(4).Value = CDate(dr("Next_Service").ToString()).ToShortDateString()
        '        S_DataGrd.Rows(i).Cells(5).Value = dr("Customer_Address").ToString()
        '        ' S_DataGrd.Rows(i).Cells(3).Value = CDate(dr("DOP").ToString()).ToShortDateString()
        '        S_DataGrd.Rows(i).Cells(6).Value = dr("Phone_Number").ToString() + "  /  " + dr("Alt_Phone_Number").ToString()

        '        S_DataGrd.Rows(i).Cells(7).Value = True
        '        If (S_DataGrd.Rows(i).Cells(7).Value = True) Then
        '            S_DataGrd.Rows(i).Cells(8).ReadOnly = True
        '        End If
        '        S_DataGrd.Rows(i).Cells(8).Value = dr("Feedback").ToString()
        '        'End If

        '        i = i + 1
        '    End While
        '    dr.Close()
        '    cmd.Parameters.Clear()
        'Catch ex As Exception
        '    dr.Close()
        '    cmd.Parameters.Clear()
        '    MsgBox(ex.Message.ToString())
        'End Try
        'If (S_DataGrd.Rows.Count <> 0) Then
        '    S_NO.Visible = False
        'Else
        '    S_NO.Visible = True
        'End If
    End Sub

   
    Private Sub S_Print_Click(sender As Object, e As EventArgs) Handles S_Print.Click
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocumentClient
        printDialog.UseEXDialog = True

        If DialogResult.OK = printDialog.ShowDialog() Then
            PrintDocumentClient.DocumentName = "Client Page Print"
            PrintDocumentClient.Print()
        End If
    End Sub
End Class