Imports System.Data
Imports System.Drawing.StringFormat
Public Class Main2
    Private Enum DGVHeaderImageAlignments As Int32
        [Default] = 0
        FillCell = 1
        SingleCentered = 2
        SingleLeft = 3
        SingleRight = 4
        Stretch = [Default]
        Tile = 5
    End Enum
    Dim datagridforprint As New DataGridView
    Dim strFormat As StringFormat
    Dim arrColumnLefts As New ArrayList()
    Dim arrColumnWidths As New ArrayList()
    Dim iCellHeight As Integer = 0
    Dim iTotalWidth As Integer = 0
    Dim iRow As Integer = 0
    Dim bFirstPage As Boolean = False
    Dim bNewPage As Boolean = False
    Dim iHeaderHeight As Integer = 0

#Region "Product Functions"
    Public Sub loadproducts()
        Try
            'list_Product_Keys_Show()
            DataGrd.ColumnCount = 4
            DataGrd.Columns(0).Name = "Product Id"
            DataGrd.Columns(1).Name = "Product Name"
            DataGrd.Columns(2).Name = "Model Number"
            DataGrd.Columns(3).Name = "Service Interval"
            DataGrd.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            DataGrd.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            DataGrd.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            DataGrd.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            DataGrd.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
            Dim i As Integer = 0
            DataGrd.Rows.Clear()
            cmd.CommandText = "select * from Prod where ID=@ID order by Product_Id "
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader
            While dr.Read()
                DataGrd.Rows.Add()
                DataGrd.Rows(i).Cells(0).Value = dr("Product_Id").ToString()

                DataGrd.Rows(i).Cells(1).Value = dr("Product_Name").ToString()
                DataGrd.Rows(i).Cells(2).Value = dr("Model_Number").ToString()
                DataGrd.Rows(i).Cells(3).Value = dr("Servicing_Interval").ToString()

                i += 1
            End While
            dr.Close()
            cmd.Parameters.Clear()
            If DataGrd.Rows.Count = 0 Then
                DataGrd.EmptyDataText = "No Data Found !!!!"
            Else
                DataGrd.EmptyDataText = String.Empty
            End If
            Dim count As Integer = DataGrd.Rows.Count
            P_List_Box.GroupTitle = "Products Listed :" + count.ToString()
            P_Count_G = count

            ' grpClients.GroupTitle = "Client Listed: " + count.ToString()

            'If count > 0 Then
            'dgviewclient.EmptyDataText = ""
            'Else
            'dgviewclient.EmptyDataText = "NO RECORD FOUND!!!"
            'End If
            ' DataGrd.ClearSelection()

            ' If count > 0 Then
            ' btnopen.Enabled = True
            ' Else
            ' btnopen.Enabled = False
            'End If
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    'Private Sub Print_Products()
    '    Dim printDialog As New PrintDialog()
    '    printDialog.Document = PrintDocumentClient
    '    printDialog.UseEXDialog = True

    '    If DialogResult.OK = printDialog.ShowDialog() Then
    '        PrintDocumentClient.DocumentName = "Client Page Print"
    '        PrintDocumentClient.Print()
    '    End If
    'End Sub
    Private Sub Prod_export()
        Try
            If ((DataGrd.Columns.Count = 0) Or (DataGrd.Rows.Count = 0)) Then
                If MessageBox.Show("No record found to export!!!", "Duty - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Stop) = DialogResult.OK Then
                    Exit Sub
                End If
            Else
                'Dim Imagefile As String = AppDomain.CurrentDomain.BaseDirectory + "\\ESAR Report.bmp"
                Dim dset As New DataSet
                dset.Tables.Add()
                For i As Integer = 0 To DataGrd.ColumnCount - 1
                    dset.Tables(0).Columns.Add(DataGrd.Columns(i).HeaderText)
                Next
                Dim dr1 As DataRow
                For i As Integer = 0 To DataGrd.RowCount - 1
                    dr1 = dset.Tables(0).NewRow
                    For j As Integer = 0 To DataGrd.Columns.Count - 1
                        dr1(j) = DataGrd.Rows(i).Cells(j).Value
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
    End Sub
    Private Sub New_Products()
        '  Remove()
        ' new_Prod_Show_Keys()
        Dim p_main As New Maintain_Products
        P_Show_G = False
        p_main.ShowDialog()
        loadproducts()

    End Sub
    Private Sub Open_Products()
        Try
            ' maintainProd_keys_Show()
            Dim i As Integer = DataGrd.CurrentRow.Cells(0).Value
            P_CanUpdate = True
            P_Show_G = True
            P_Index = i
            ' Dim uc As New MaintainClient
            ' OpenClient = New Popup(uc, btnopen)
            ' AddHandler OpenClient.PopupForm.NewValueUpdated, AddressOf LoadClients
            ' OpenClient.Show()
            Dim maintain_Form As New Maintain_Products
            maintain_Form.ShowDialog()
            loadproducts()

        Catch ex As Exception
            MessageBox.Show("No Data in Record")
        End Try

    End Sub
    Private Sub Search_Product()
        Try
            If P_SearchBox.Text.Trim() = "" Then
                If MessageBox.Show("Please enter search text!!!", "Roster Advance - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning) = DialogResult.OK Then
                    P_SearchBox.Focus()
                End If
            ElseIf P_Catagory.Text.Trim() = "" Then
                If MessageBox.Show("Please enter/select search in!!!", "Roster Advance - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning) = DialogResult.OK Then
                    P_Catagory.Focus()
                End If
            ElseIf P_Catagory.Text.Trim() = "Product Id" Then
                Dim i As Integer
                DataGrd.ClearSelection()
                For i = 0 To DataGrd.Rows.Count - 1
                    If DataGrd.Rows(i).Cells(0).Value.ToString().ToUpper() Like UCase(P_SearchBox.Text) Then
                        DataGrd.Rows(i).Selected = True
                        DataGrd.CurrentCell = DataGrd.Rows(i).Cells(0)
                        Exit For
                    End If
                Next
            ElseIf P_Catagory.Text.Trim() = "Product Name" Then
                Dim i As Integer
                DataGrd.ClearSelection()
                For i = 0 To DataGrd.Rows.Count - 1
                    If DataGrd.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(P_SearchBox.Text) Then
                        DataGrd.Rows(i).Selected = True
                        DataGrd.CurrentCell = DataGrd.Rows(i).Cells(1)
                        Exit For
                    End If
                Next
            ElseIf P_Catagory.Text.Trim() = "Model Number" Then
                Dim i As Integer
                DataGrd.ClearSelection()
                For i = 0 To DataGrd.Rows.Count - 1
                    If DataGrd.Rows(i).Cells(2).Value.ToString().ToUpper() Like UCase(P_SearchBox.Text) Then
                        DataGrd.Rows(i).Selected = True
                        DataGrd.CurrentCell = DataGrd.Rows(i).Cells(2)
                        Exit For
                    End If
                Next
            ElseIf P_Catagory.Text.Trim() = "Service Interval" Then
                Dim i As Integer
                DataGrd.ClearSelection()
                For i = 0 To DataGrd.Rows.Count - 1
                    If DataGrd.Rows(i).Cells(3).Value.ToString().ToUpper() Like UCase(P_SearchBox.Text) Then
                        DataGrd.Rows(i).Selected = True
                        DataGrd.CurrentCell = DataGrd.Rows(i).Cells(3)
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            cmd.Parameters.Clear()
            dr.Close()
            MsgBox(ex.Message.ToString())
        End Try
        P_Search_Panel.Enabled = False
        P_SearchBox.ResetText()
        P_Catagory.ResetText()
    End Sub


#End Region
#Region "Main KeyPress"
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Try
            If keyData = Keys.F2 Then
                ETabControlEx1.SelectTab(TabPage1)
            ElseIf keyData = Keys.F3 Then
                ETabControlEx1.SelectTab(TabPage2)
            ElseIf keyData = Keys.F4 Then
                ETabControlEx1.SelectTab(TabPage3)
                'ElseIf keyData = Keys.F10 Then
                '    If MessageBox.Show("Are you sure you want exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                '        Me.Close()
                '    End If
            ElseIf keyData = Keys.F6 Then
                Dim x As New UserManagerX
                If x.adminPresent = False Then
                    Dim newus As New newUser
                    newus.ShowDialog()
                Else
                    Dim showall As New UsersForm
                    showall.ShowDialog()
                    ' ElseIf x.usercount < 3 Then
                    '     Dim newus As New UsersForm
                End If
                'ElseIf keyData = Keys.F6 Then
                '    ETabControlEx1.SelectTab(TabPage1)
                '    New_Products()
                'ElseIf keyData = Keys.F7 Then
                '    Dim frm As New Maintain_customer
                '    frm.ShowDialog()
                '    ETabControlEx1.SelectTab(TabPage2)
                'ElseIf keyData = Keys.F8 Then
                '    Dim frm As New Show_Serviced
                '    frm.ShowDialog()
                '    ETabControlEx1.SelectTab(TabPage3)
            End If
        Catch ex As Exception

        End Try
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.N Then
            If cur_canAdd = True Then
                If ETabControlEx1.SelectedIndex = 0 Then
                    New_Products()
                ElseIf ETabControlEx1.SelectedIndex = 1 Then
                    New_Customers()
                End If
            Else
                MessageBox.Show("You do not have privilages to add products or customers")
            End If
        ElseIf e.Control And e.KeyCode = Keys.P Then


            If ETabControlEx1.SelectedIndex = 0 Then
                datagridforprint = DataGrd
            ElseIf ETabControlEx1.SelectedIndex = 1 Then
                datagridforprint = C_Datagrd
            ElseIf ETabControlEx1.SelectedIndex = 2 Then
                datagridforprint = DataGrid1
            End If
            'Try
            '    Dim printProcess As New Diagnostics.ProcessStartInfo()
            '    printProcess.FileName = AppDomain.CurrentDomain.BaseDirectory + "\product.html"
            '    printProcess.Verb = "Print"
            '    printProcess.WindowStyle = ProcessWindowStyle.Normal
            '    Process.Start(printProcess)
            'Catch ex As Exception
            '    MsgBox(ex.Message.ToString)
            'End Try
            printfuntion()
        ElseIf e.Alt And e.KeyCode = Keys.X Then
            If MessageBox.Show("Are you sure you want exit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        ElseIf e.Control And e.KeyCode = Keys.R Then
            Dim htmlrep As String = String.Empty
            If ETabControlEx1.SelectedIndex = 2 Then
                genXML(DataGrid1)
                htmlrep = AppDomain.CurrentDomain.BaseDirectory + "\service.html"
                If System.IO.File.Exists(htmlrep) = True And DataGrid1.Rows.Count > 0 Then
                    Process.Start(htmlrep)
                Else
                    MessageBox.Show("HTML REPORT NOT GENERATED")
                End If
            ElseIf ETabControlEx1.SelectedIndex = 1 Then
                genXML(C_Datagrd)
                htmlrep = AppDomain.CurrentDomain.BaseDirectory + "\customer.html"
                If System.IO.File.Exists(htmlrep) = True And C_Datagrd.Rows.Count > 0 Then
                    Process.Start(htmlrep)
                Else
                    MessageBox.Show("HTML REPORT NOT GENERATED")
                End If
            ElseIf ETabControlEx1.SelectedIndex = 0 Then
                genXML(DataGrd)
                htmlrep = AppDomain.CurrentDomain.BaseDirectory + "\product.html"
                If System.IO.File.Exists(htmlrep) = True And DataGrd.Rows.Count > 0 Then
                    Process.Start(htmlrep)
                Else
                    MessageBox.Show("HTML REPORT NOT GENERATED")
                End If
            End If
            

        ElseIf e.Control And e.KeyCode = Keys.E And ETabControlEx1.SelectedIndex = 2 Then
            If cur_canService = True Then
                If DataGrid1.Rows.Count > 0 Then
                    If DataGrid1.CurrentRow.Index >= 0 Then
                        If DataGrid1.CurrentRow.Cells(7).Value = False Then
                            DataGrid1.CurrentRow.Cells(8).Selected = True
                            feed_Changed.Add(DataGrid1.CurrentRow.Index)
                        End If
                    End If
                End If
            Else
                MessageBox.Show("You do not have privilages to Service customers")
            End If

        ElseIf (e.Control And e.KeyCode = Keys.O) Or (e.KeyCode = Keys.Enter) Then
            If ETabControlEx1.SelectedIndex = 0 And P_Catagory.Focused = False Then
                Open_Products()
            ElseIf ETabControlEx1.SelectedIndex = 1 And C_Catagory.Focused = False Then
                Open_Customers()
            End If
        ElseIf e.Control And e.KeyCode = Keys.F Then
            If ETabControlEx1.SelectedIndex = 0 Then
                DataGrd.ClearSelection()

                DataGrd.CurrentCell = Nothing
                P_Search_Panel.Enabled = True
                P_SearchBox.Focus()
            ElseIf ETabControlEx1.SelectedIndex = 1 Then
                C_Datagrd.ClearSelection()
                C_Datagrd.CurrentCell = Nothing
                C_Search_Panel.Enabled = True
                C_SearchBox.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape And P_Search_Panel.Enabled = True And ETabControlEx1.SelectedIndex = 0 Then
            P_Search_Panel.Enabled = False
            DataGrd.Focus()
        ElseIf e.KeyCode = Keys.Escape And C_Search_Panel.Enabled = True And ETabControlEx1.SelectedIndex = 1 Then
            C_Search_Panel.Enabled = False
            C_Datagrd.Focus()
        ElseIf e.KeyCode = Keys.F5 And ETabControlEx1.SelectedIndex = 0 Then
            loadproducts()
        ElseIf e.KeyCode = Keys.F5 And ETabControlEx1.SelectedIndex = 1 Then
            loadcustomers()
        ElseIf e.Control And e.KeyCode = Keys.E Then
            If ETabControlEx1.SelectedIndex = 0 Then
                Prod_export()
            ElseIf ETabControlEx1.SelectedIndex = 1 Then
                Cust_Export()
            End If
        ElseIf e.Control And e.KeyCode = Keys.P Then
            ' Print_Products()
            'ElseIf e.Control And e.KeyCode = Keys.L And ETabControlEx1.SelectedIndex = 2 Then
            '    loadAll()
            'ElseIf e.KeyCode = Keys.Escape And ETabControlEx1.SelectedIndex = 2 Then
            '    S_Month.SelectedIndex = Date.Now.Month - 1
            '    loadWithMonth()
        ElseIf e.Control And ETabControlEx1.SelectedIndex = 2 And e.KeyCode = Keys.S Then
            ' S_Save()
            S_Save_Service()
            loadWithMonth()
            Cid_Changed.Clear()
            feed_Changed.Clear()
        ElseIf e.Alt And e.KeyCode = Keys.Right And ETabControlEx1.SelectedIndex = 2 Then
            If S_Month.SelectedIndex < 11 And S_Month.SelectedIndex < Date.Now.Month - 1 Then
                S_Month.SelectedIndex = S_Month.SelectedIndex + 1
            Else

                If cur_isadmin = True Then
                    If S_Month.SelectedIndex < 11 Then
                        S_Month.SelectedIndex = S_Month.SelectedIndex + 1
                    End If
                Else
                    MessageBox.Show("You do not have privilages to access next months data")
                End If
                DataGrid1.Focus()
            End If
        ElseIf e.Alt And e.KeyCode = Keys.Left And ETabControlEx1.SelectedIndex = 2 Then
            If S_Month.SelectedIndex > 0 Then
                S_Month.SelectedIndex = S_Month.SelectedIndex - 1
                DataGrid1.Focus()
            End If
        ElseIf e.Control And e.KeyCode = Keys.L Then
            If cur_canService = True Then
                Dim frm As New Show_Serviced
                frm.ShowDialog()
                loadServices()
            Else
                MessageBox.Show("You do not have privilages to Undo Services provided")
            End If
        ElseIf ETabControlEx1.SelectedIndex = 2 Then
            If e.KeyCode = Keys.Space Then
                Try
                    If DataGrid1.Rows.Count > 0 Then
                        If DataGrid1.CurrentRow.Index >= 0 Then
                            If DataGrid1.CurrentRow.Cells(7).Value = False Then
                                DataGrid1.CurrentRow.Cells(7).Value = True
                                Cid_Changed.Add(DataGrid1.CurrentRow.Index)
                            ElseIf DataGrid1.CurrentRow.Cells(7).Value = True Then
                                DataGrid1.CurrentRow.Cells(7).Value = False
                                If Cid_Changed.Contains(DataGrid1.CurrentRow.Index) Then
                                    Cid_Changed.Remove(DataGrid1.CurrentRow.Index)
                                End If
                            End If
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                DataGrid1.Focus()
            End If
        End If
    End Sub
#End Region
#Region "tab functions"

    Private Sub ETabControlEx1_TabIndexChanged(sender As Object, e As EventArgs) Handles ETabControlEx1.SelectedIndexChanged
        '  Remove()
        If ETabControlEx1.SelectedIndex = 0 Then
            'MessageBox.Show("tab1")
            ' list_Product_Keys_Show()
            loadproducts()
            DataGrd.Focus()
            P_Search_Panel.Enabled = False
        ElseIf ETabControlEx1.SelectedIndex = 1 Then
            loadcustomers()
            C_Datagrd.Focus()
            C_Search_Panel.Enabled = False
        ElseIf ETabControlEx1.SelectedIndex = 2 Then
            loadServices()
            Cid_Changed.Clear()
            DataGrid1.Focus()
            'ElseIf ETabControlEx1.SelectedIndex = 3 Then
            '    loadallServices()

        End If
    End Sub
#End Region
#Region "Customer Functions"
    Private Sub Cust_Export()
        Try
            If ((C_Datagrd.Columns.Count = 0) Or (C_Datagrd.Rows.Count = 0)) Then
                If MessageBox.Show("No record found to export!!!", "Duty - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Stop) = DialogResult.OK Then
                    Exit Sub
                End If
            Else
                'Dim Imagefile As String = AppDomain.CurrentDomain.BaseDirectory + "\\ESAR Report.bmp"
                Dim dset As New DataSet
                dset.Tables.Add()
                For i As Integer = 0 To C_Datagrd.ColumnCount - 1
                    dset.Tables(0).Columns.Add(C_Datagrd.Columns(i).HeaderText)
                Next
                Dim dr1 As DataRow
                For i As Integer = 0 To C_Datagrd.RowCount - 1
                    dr1 = dset.Tables(0).NewRow
                    For j As Integer = 0 To C_Datagrd.Columns.Count - 1
                        dr1(j) = C_Datagrd.Rows(i).Cells(j).Value.ToString  'Edit
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
    End Sub
    Public Sub loadcustomers()
        Dim C_Cu As New ClsCustomer
        ' C_Cu.loadservice()
        ' list_Customer_Keys_Show()
        Try
            C_Datagrd.ColumnCount = 7
            C_Datagrd.Columns(0).Name = "Customer Id"
            C_Datagrd.Columns(1).Name = "Customer Name"
            C_Datagrd.Columns(2).Name = "Product Name"

            C_Datagrd.Columns(3).Name = "Date of Purchase"
            C_Datagrd.Columns(4).Name = "Date of Instalation"
            C_Datagrd.Columns(5).Name = "Customer Address"
            C_Datagrd.Columns(6).Name = "Phone Number"
            C_Datagrd.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            C_Datagrd.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            C_Datagrd.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            C_Datagrd.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            C_Datagrd.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
            C_Datagrd.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
            C_Datagrd.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable

            Dim i As Integer = 0
            C_Datagrd.Rows.Clear()
            cmd.CommandText = "select Customer_Id, Customer_Name,Product_Name,DOP,DOI,Customer_Address,Phone_Number,Alt_Phone_Number from Cust where ID=@ID order by Customer_Id"
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader()
            'MessageBox.Show("load")

            While dr.Read()
                C_Datagrd.Rows.Add()
                C_Datagrd.Rows(i).Cells(0).Value = dr("Customer_Id").ToString()
                C_Datagrd.Rows(i).Cells(1).Value = dr("Customer_Name").ToString()
                C_Datagrd.Rows(i).Cells(2).Value = dr("Product_Name").ToString()
                C_Datagrd.Rows(i).Cells(3).Value = CDate(dr("DOP").ToString()).ToShortDateString()
                C_Datagrd.Rows(i).Cells(4).Value = CDate(dr("DOI").ToString()).ToShortDateString()
                C_Datagrd.Rows(i).Cells(5).Value = dr("Customer_Address").ToString()
                C_Datagrd.Rows(i).Cells(6).Value = dr("Phone_Number").ToString() + " \ " + dr("Alt_Phone_Number").ToString()


                i += 1
            End While
            dr.Close()
            cmd.Parameters.Clear()
            If C_Datagrd.Rows.Count = 0 Then
                C_Datagrd.EmptyDataText = "No Data Found !!!!"
            Else
                C_Datagrd.EmptyDataText = String.Empty
            End If
            Dim count As Integer = C_Datagrd.Rows.Count
            C_List_Box.GroupTitle = "Customers Listed :" + count.ToString()
            C_Count_G = count
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Private Sub New_Customers()
        C_Index = -1
        C_Show_G = False
        '' Remove()
        'new_Cust_Show_Keys()
        Dim n_cust As New Maintain_customer
        n_cust.new_Customer()
        n_cust.ShowDialog()
        n_cust.C_inv.Focus()
        n_cust.C_inv.ResetText()
        n_cust.C_Name.ResetText()
        n_cust.C_Adr.ResetText()
        n_cust.C_Ph.ResetText()
        n_cust.C_Ph.ResetText()
        n_cust.C_Ph.ResetText()
        n_cust.C_Ph1.ResetText()
        n_cust.C_Prod.ResetText()
        n_cust.C_Doi.ResetText()
        n_cust.C_dop.ResetText()
        n_cust.C_Mdno.ResetText()
        n_cust.C_inv.Focus()
        loadcustomers()
    End Sub
    Private Sub Open_Customers()
        Try
            ' Remove()
            ' maintainCust_keys_Show()
            Dim i As Integer = C_Datagrd.CurrentRow.Cells(0).Value
            Dim index As Integer = C_Datagrd.CurrentRow.Index
            C_Show_G = True
            C_Id = i
            C_Index = index
            'MessageBox.Show("maintain form opened")
            ' Dim uc As New MaintainClient
            ' OpenClient = New Popup(uc, btnopen)
            ' AddHandler OpenClient.PopupForm.NewValueUpdated, AddressOf LoadClients
            ' OpenClient.Show()
            Dim maintain_Form As New Maintain_customer
            maintain_Form.ShowDialog()
            loadcustomers()

        Catch ex As Exception
            MessageBox.Show("No Data in Record")
        End Try

    End Sub
    Private Sub Search_Customer()
        Try
            If C_SearchBox.Text.Trim() = "" Then
                If MessageBox.Show("Please enter search text!!!", "Roster Advance - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning) = DialogResult.OK Then
                    C_SearchBox.Focus()
                End If
            ElseIf C_Catagory.Text.Trim() = "" Then
                If MessageBox.Show("Please enter/select search in!!!", "Roster Advance - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning) = DialogResult.OK Then
                    C_Catagory.Focus()
                End If
            ElseIf C_Catagory.Text.Trim() = "Customer Id" Then
                Dim i As Integer
                C_Datagrd.ClearSelection()
                For i = 0 To C_Datagrd.Rows.Count - 1
                    If C_Datagrd.Rows(i).Cells(0).Value.ToString().ToUpper() Like UCase(C_SearchBox.Text) Then
                        C_Datagrd.Rows(i).Selected = True
                        C_Datagrd.CurrentCell = C_Datagrd.Rows(i).Cells(0)
                        Exit For
                    End If
                Next
            ElseIf C_Catagory.Text.Trim() = "Customer Name" Then
                Dim i As Integer
                C_Datagrd.ClearSelection()
                For i = 0 To C_Datagrd.Rows.Count - 1
                    If C_Datagrd.Rows(i).Cells(1).Value.ToString().ToUpper() Like UCase(C_SearchBox.Text) Then
                        C_Datagrd.Rows(i).Selected = True
                        C_Datagrd.CurrentCell = C_Datagrd.Rows(i).Cells(0)
                        Exit For
                    End If
                Next
            ElseIf C_Catagory.Text.Trim() = "Product Name" Then
                Dim i As Integer
                C_Datagrd.ClearSelection()
                For i = 0 To C_Datagrd.Rows.Count - 1
                    If C_Datagrd.Rows(i).Cells(2).Value.ToString().ToUpper() Like UCase(C_SearchBox.Text) Then
                        C_Datagrd.Rows(i).Selected = True
                        C_Datagrd.CurrentCell = C_Datagrd.Rows(i).Cells(0)
                        Exit For
                    End If
                Next
            ElseIf C_Catagory.Text.Trim() = "Date of Purchase" Then
                Dim i As Integer
                C_Datagrd.ClearSelection()
                For i = 0 To C_Datagrd.Rows.Count - 1
                    If C_Datagrd.Rows(i).Cells(3).Value.ToString().ToUpper() Like UCase(C_SearchBox.Text) Then
                        C_Datagrd.Rows(i).Selected = True
                        C_Datagrd.CurrentCell = C_Datagrd.Rows(i).Cells(0)
                        Exit For
                    End If
                Next
            ElseIf C_Catagory.Text.Trim() = "Date of instalation" Then
                Dim i As Integer
                C_Datagrd.ClearSelection()
                For i = 0 To C_Datagrd.Rows.Count - 1
                    If C_Datagrd.Rows(i).Cells(4).Value.ToString().ToUpper() Like UCase(C_SearchBox.Text) Then
                        C_Datagrd.Rows(i).Selected = True
                        C_Datagrd.CurrentCell = C_Datagrd.Rows(i).Cells(0)
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            cmd.Parameters.Clear()
            dr.Close()
            MsgBox(ex.Message.ToString())
        End Try
        C_Search_Panel.Enabled = False
        C_SearchBox.ResetText()
        C_Catagory.ResetText()
    End Sub

#End Region
#Region "Products Events"
    Private Sub Select_RowClick(sender As Object, e As EventArgs) Handles DataGrd.MouseDoubleClick
        Open_Products()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles P_clear.Click
        P_SearchBox.ResetText()
        C_Catagory.ResetText()
        loadproducts()
    End Sub





    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connect()
        cur_user_lable.Text = cur_user_lable.Text + cur_username
        cur_User_Lable1.Text = cur_User_Lable1.Text + cur_username
        cur_User_Lable2.Text = cur_User_Lable2.Text + cur_username
        Dim delcache As New ClsCustomer
        delcache.DelCache()
        Me.KeyPreview = True
        ' getcurrentuser()
        ETabControlEx1.SelectTab(TabPage3)

        P_Catagory.Items.Add("Product Id")
        P_Catagory.Items.Add("Product Name")
        P_Catagory.Items.Add("Model Number")
        P_Catagory.Items.Add("Service Interval")
        C_Catagory.Items.Add("Customer Id")
        C_Catagory.Items.Add("Customer Name")
        C_Catagory.Items.Add("Product Name")
        C_Catagory.Items.Add("Date of Purchase")
        C_Catagory.Items.Add("Date of instalation")
        ' loadallServices()

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles P_Search.Click
        Search_Product()
    End Sub

    Private Sub P_Catagory_KeyDown(sender As Object, e As KeyEventArgs) Handles P_Catagory.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search_Product()
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        loadproducts()
    End Sub

#End Region
#Region "Customer Events"


    Private Sub Select_CRowClick(sender As Object, e As EventArgs) Handles C_Datagrd.MouseDoubleClick
        Open_Customers()
    End Sub

    Private Sub C_Catagory_KeyDown(sender As Object, e As KeyEventArgs) Handles C_Catagory.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search_Customer()
        End If
    End Sub

    Private Sub C_Search_Click(sender As Object, e As EventArgs) Handles C_Search.Click
        Search_Customer()
    End Sub

    Private Sub C_Clear_Click(sender As Object, e As EventArgs) Handles C_Clear.Click
        C_SearchBox.ResetText()
        C_Catagory.ResetText()
        loadcustomers()
    End Sub
#End Region
#Region "Service functions"
    Private Sub loadServices()
        Cid_Changed.Clear()
        ' Remove()
        ' Service_List_Keys_Show()
        DataGrid1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGrid1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGrid1.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGrid1.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGrid1.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGrid1.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGrid1.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGrid1.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGrid1.Columns(8).SortMode = DataGridViewColumnSortMode.NotSortable
        DataGrid1.Columns(0).ReadOnly = True
        DataGrid1.Columns(1).ReadOnly = True
        DataGrid1.Columns(2).ReadOnly = True
        DataGrid1.Columns(3).ReadOnly = True
        DataGrid1.Columns(4).ReadOnly = True
        DataGrid1.Columns(5).ReadOnly = True
        DataGrid1.Columns(6).ReadOnly = True
        DataGrid1.Columns(7).ReadOnly = False
        DataGrid1.Columns(8).ReadOnly = False



        S_Month.Items.Clear()
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
        DataGrid1.AllowUserToAddRows() = False
        S_Prod.Items.Clear()
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
        loadWithMonth()
    End Sub
    Public Sub loadWithMonth()
        '        S_Save.Enabled = True
        Cid_Changed.Clear()
        DataGrid1.Focus()
        Try


            Dim i As Integer = 0
            cmd.CommandText = "Select Customer_Id,Customer_Name,Product_Name,DOI,Next_Service,Customer_Address,Phone_NUmber,Alt_Phone_Number,Serviced,Feedback from Cust where MONTH(Next_Service)=@C_Month and Service_Count<=3 and ID=@ID"
            cmd.Parameters.AddWithValue("@C_Month", S_Month.SelectedIndex + 1)
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader()
            DataGrid1.Rows.Clear()
            Cid_Changed.Clear()
            feed_Changed.Clear()
            While (dr.Read)

                'If (CDate(dr("Next_Service").ToString()).Month = S_Month.SelectedIndex) Then
                DataGrid1.Rows.Add()
                DataGrid1.Rows(i).Cells(0).Value = dr("Customer_Id").ToString()
                DataGrid1.Rows(i).Cells(1).Value = dr("Customer_Name").ToString()
                DataGrid1.Rows(i).Cells(2).Value = dr("Product_Name").ToString()
                DataGrid1.Rows(i).Cells(3).Value = CDate(dr("DOI").ToString()).ToShortDateString()
                DataGrid1.Rows(i).Cells(4).Value = CDate(dr("Next_Service").ToString()).ToShortDateString()
                DataGrid1.Rows(i).Cells(5).Value = dr("Customer_Address").ToString()
                ' S_DataGrd.Rows(i).Cells(3).Value = CDate(dr("DOP").ToString()).ToShortDateString()
                DataGrid1.Rows(i).Cells(6).Value = dr("Phone_Number").ToString() + "  /  " + dr("Alt_Phone_Number").ToString()
                DataGrid1.Rows(i).Cells(7).Value = dr("Serviced").ToString()
                If (DataGrid1.Rows(i).Cells(7).Value = True) Then
                    DataGrid1.Rows(i).Cells(8).ReadOnly = True
                End If
                DataGrid1.Rows(i).Cells(8).Value = dr("Feedback").ToString()
                'End If

                i = i + 1
            End While
            dr.Close()
            cmd.Parameters.Clear()
            If DataGrid1.Rows.Count = 0 Then
                DataGrid1.EmptyDataText = "No data found!!!!!"
            Else
                DataGrid1.EmptyDataText = String.Empty
            End If
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
        If (DataGrid1.Rows.Count = 0) Then
            S_NO.Visible = True
        Else
            S_NO.Visible = False

        End If

    End Sub
    Private Sub S_Save_Service()
        Dim up As New ClsCustomer
        If cur_canService = True Then
            For Each i In Cid_Changed
                If Cid_Changed.Contains(i) Then
                    'MessageBox.Show(i.ToString + " save for service")
                    DataGrid1.Rows(i).Cells(8).Value = ""
                    Try
                        cmd.CommandText = "update Cust set Serviced=True ,Feedback=@Feedback where Customer_id=@Customer_Id and ID=@ID"
                        cmd.Parameters.AddWithValue("@Feedback", DataGrid1.Rows(i).Cells(8).Value.ToString())
                        cmd.Parameters.AddWithValue("@Customer_Id", DataGrid1.Rows(i).Cells(0).Value.ToString())
                        cmd.Parameters.AddWithValue("@ID", loadcomp)
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                    Catch ex As Exception
                        dr.Close()
                        cmd.Parameters.Clear()
                        MsgBox(ex.Message.ToString)
                    End Try
                    up.setnextnext(DataGrid1.Rows(i).Cells(0).Value.ToString())
                End If
            Next
            For Each i In feed_Changed
                If feed_Changed.Contains(i) Then
                    If DataGrid1.Rows(i).Cells(8).Value.ToString.Trim.Equals(String.Empty) Then
                        MessageBox.Show("No feedback")
                    Else
                        MessageBox.Show(i.ToString + " saved for feedback")
                        ' If DataGrid1.Rows(i).Cells(8).Value.ToString <> String.Empty Then
                        Try
                            cmd.CommandText = "update Cust set Next_Service=@d_temp ,Serviced=false ,Feedback=@Feedback where Customer_id=@Customer_Id and ID=@ID"
                            Dim d_temp As Date = CDate(DataGrid1.Rows(i).Cells(4).Value.ToString()).ToShortDateString()
                            d_temp = d_temp.AddMonths(1)
                            cmd.Parameters.AddWithValue("@d_temp", d_temp)
                            cmd.Parameters.AddWithValue("@Feedback", DataGrid1.Rows(i).Cells(8).Value.ToString())
                            cmd.Parameters.AddWithValue("@Customer_Id", DataGrid1.Rows(i).Cells(0).Value.ToString())
                            cmd.Parameters.AddWithValue("@ID", loadcomp)
                            cmd.ExecuteNonQuery()
                            cmd.Parameters.Clear()
                        Catch ex As Exception
                            dr.Close()
                            cmd.Parameters.Clear()
                            MsgBox(ex.Message.ToString)
                        End Try
                        'End If
                    End If
                End If
            Next
            feed_Changed.Clear()
            DataGrid1.Focus()
        Else
            MessageBox.Show("You do not have privilages to Service a customer")
        End If
    End Sub
#End Region
#Region "Service Events"
    Private Sub S_Month_SelectedIndexChanged(sender As Object, e As EventArgs) Handles S_Month.SelectedIndexChanged
        loadWithMonth()
        Cid_Changed.Clear()
        If (DataGrid1.Rows.Count = 0) Then
            S_NO.Visible = True
        Else
            S_NO.Visible = False
            DataGrid1.Focus()
        End If
        S_Prod.ResetText()
    End Sub

    Private Sub S_DataGrd_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid1.CellValueChanged
        If DataGrid1.IsCurrentCellDirty Then
            Try
                If (e.ColumnIndex = 7) Then
                    If DataGrid1.Rows(e.RowIndex).Cells(7).Value = True Then
                        Cid_Changed.Add(e.RowIndex)
                        DataGrid1.Rows(e.RowIndex).Cells(8).Value = ""
                        DataGrid1.Rows(e.RowIndex).Cells(8).ReadOnly = True
                        'MessageBox.Show(e.RowIndex.ToString + " added")
                    ElseIf DataGrid1.Rows(e.RowIndex).Cells(7).Value = False And Cid_Changed.Contains(e.RowIndex) Then
                        Cid_Changed.Remove(e.RowIndex)
                        DataGrid1.Rows(e.RowIndex).Cells(8).ReadOnly = False
                        'MessageBox.Show(e.RowIndex.ToString + "  removed")
                    End If
                ElseIf e.ColumnIndex = 8 Then
                    If DataGrid1.Rows(e.RowIndex).Cells(8).Value <> String.Empty And feed_Changed.Contains(e.RowIndex) = False Then
                        feed_Changed.Add(e.RowIndex)
                        MessageBox.Show(e.RowIndex.ToString + "  addded for feedback array ")

                        ' MessageBox.Show("Added for feedback")
                    ElseIf (DataGrid1.Rows(e.RowIndex).Cells(8).Value.ToString.Trim.Equals(String.Empty) Or DataGrid1.Rows(e.RowIndex).Cells(7).Value = True) And feed_Changed.Contains(e.RowIndex) = True Then
                        feed_Changed.Remove(e.RowIndex)
                        MessageBox.Show(e.RowIndex.ToString + "  removed for feedback array ")

                        'ElseIf (S_DataGrd.Rows(e.RowIndex).Cells(8).Value) Then
                        '    MessageBox.Show("enter Feedback")
                    End If
                End If
            Catch
            End Try
        End If
    End Sub


    Private Sub dgviewservice_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs)
        If DataGrid1.IsCurrentCellDirty Then
            DataGrid1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

#End Region

    Public Sub genXML(S_All As DataGridView)
        Try
            If S_All.Rows.Count > 0 Then
                Dim dset As New DataSet
                dset.Tables.Add()
                For i As Integer = 0 To S_All.ColumnCount - 1
                    dset.Tables(0).Columns.Add(S_All.Columns(i).HeaderText)
                Next
                Dim dr1 As DataRow
                For i As Integer = 0 To S_All.RowCount - 1
                    dr1 = dset.Tables(0).NewRow
                    For j As Integer = 0 To S_All.Columns.Count - 1
                        dr1(j) = S_All.Rows(i).Cells(j).Value
                    Next
                    dset.Tables(0).Rows.Add(dr1)
                Next
                If ETabControlEx1.SelectedIndex = 2 Then
                    dset.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\Service.xml")
                ElseIf ETabControlEx1.SelectedIndex = 1 Then
                    dset.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\Customer.xml")
                ElseIf ETabControlEx1.SelectedIndex = 0 Then
                    dset.WriteXml(AppDomain.CurrentDomain.BaseDirectory + "\Product.xml")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub printfuntion()
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocumentClient
        printDialog.UseEXDialog = True

        If DialogResult.OK = printDialog.ShowDialog() Then
            PrintDocumentClient.DocumentName = "Page Print"
            PrintDocumentClient.Print()
        End If
    End Sub
    Private Sub PrintDocumentClient_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocumentClient.BeginPrint
        Try
            strFormat = New StringFormat()
            strFormat.Alignment = StringAlignment.Near
            strFormat.LineAlignment = StringAlignment.Center
            strFormat.Trimming = StringTrimming.EllipsisCharacter

            arrColumnLefts.Clear()
            arrColumnWidths.Clear()
            iCellHeight = 0
            iRow = 0
            bFirstPage = True
            bNewPage = True

            iTotalWidth = 0
            For Each dgvGridCol As DataGridViewColumn In datagridforprint.Columns
                iTotalWidth += dgvGridCol.Width
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub PrintDocumentClient_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentClient.PrintPage
        Try
            Dim iLeftMargin As Integer = e.MarginBounds.Left
            Dim iTopMargin As Integer = e.MarginBounds.Top
            Dim bMorePagesToPrint As Boolean = False
            Dim iTmpWidth As Integer = 0

            If bFirstPage Then
                For Each GridCol As DataGridViewColumn In datagridforprint.Columns
                    iTmpWidth = CInt(Math.Floor(CDbl(CDbl(GridCol.Width) / CDbl(iTotalWidth) * CDbl(iTotalWidth) * (CDbl(e.MarginBounds.Width) / CDbl(iTotalWidth)))))

                    iHeaderHeight = CInt(e.Graphics.MeasureString(GridCol.HeaderText, GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11

                    arrColumnLefts.Add(iLeftMargin)
                    arrColumnWidths.Add(iTmpWidth)
                    iLeftMargin += iTmpWidth
                Next
            End If
            While iRow <= datagridforprint.Rows.Count - 1
                Dim GridRow As DataGridViewRow = datagridforprint.Rows(iRow)
                iCellHeight = GridRow.Height + 5
                Dim iCount As Integer = 0
                If iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top Then
                    bNewPage = True
                    bFirstPage = False
                    bMorePagesToPrint = True
                    Exit While
                Else
                    If bNewPage Then
                        e.Graphics.DrawString("Client Summary", New Font(datagridforprint.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top - e.Graphics.MeasureString("Client Summary", New Font(datagridforprint.Font, FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        Dim strDate As [String] = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString()
                        e.Graphics.DrawString(strDate, New Font(C_Datagrd.Font, FontStyle.Bold), Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString(strDate, New Font(datagridforprint.Font, FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top - e.Graphics.MeasureString("Client Summary", New Font(New Font(datagridforprint.Font, FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13)

                        iTopMargin = e.MarginBounds.Top
                        For Each GridCol As DataGridViewColumn In datagridforprint.Columns
                            e.Graphics.FillRectangle(New SolidBrush(Color.LightGray), New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight))

                            e.Graphics.DrawRectangle(Pens.Black, New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight))

                            e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font, New SolidBrush(GridCol.InheritedStyle.ForeColor), New RectangleF(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iHeaderHeight), strFormat)
                            iCount += 1
                        Next
                        bNewPage = False
                        iTopMargin += iHeaderHeight
                    End If
                    iCount = 0
                    For Each Cel As DataGridViewCell In GridRow.Cells
                        If Cel.Value IsNot Nothing Then
                            e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font, New SolidBrush(Cel.InheritedStyle.ForeColor), New RectangleF(CInt(arrColumnLefts(iCount)), CSng(iTopMargin), CInt(arrColumnWidths(iCount)), CSng(iCellHeight)), strFormat)
                        End If
                        e.Graphics.DrawRectangle(Pens.Black, New Rectangle(CInt(arrColumnLefts(iCount)), iTopMargin, CInt(arrColumnWidths(iCount)), iCellHeight))

                        iCount += 1
                    Next
                End If
                iRow += 1
                iTopMargin += iCellHeight
            End While

            If bMorePagesToPrint Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch exc As Exception
            MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

   
    Private Sub Select_CRowClick(sender As Object, e As MouseEventArgs) Handles C_Datagrd.MouseDoubleClick

    End Sub
    Private Sub Select_RowClick(sender As Object, e As MouseEventArgs) Handles DataGrd.MouseDoubleClick

    End Sub
End Class

