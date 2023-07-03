Public Class Maintain_customer

   
    Private Sub Maintain_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C_Details.GroupTitle = "Customer Details :"
        Me.KeyPreview = True
        C_inv.Focus()
        If cur_canAdd = False Then
            C_inv.ReadOnly = True
            C_Name.ReadOnly = True
            C_Adr.ReadOnly = True
            C_Ph.ReadOnly = True
            C_Ph1.ReadOnly = True
            C_Prod.Enabled = False
            C_Mdno.Enabled = False
            C_dop.Enabled = False
            C_Doi.Enabled = False
        End If
        Try
            cmd.CommandText = "select DISTINCT Product_Name from Prod where ID=@ID"
            Dim prd As String

            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader()
            While dr.Read()
                prd = dr("Product_Name").ToString()
                C_Prod.Items.Add(prd)
                'MessageBox.Show(prd)
            End While
            dr.Close()
            cmd.Parameters.Clear()

        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try

        If (C_Show_G = True) Then
            Dim i As Integer = 0
            B_Back.Enabled = True
            B_Next.Enabled = True
            If (C_Index = 0) Then
                B_Back.Enabled = False
            End If
            If (C_Index = C_Count_G - 1) Then
                B_Next.Enabled = False
            End If
            Try
                
                ' MessageBox.Show("i =" + C_Index.ToString())
                cmd.CommandText = "select Customer_Name,Product_Name,Model_Number,DOP,DOI,Customer_Address,Phone_Number,Alt_Phone_Number from Cust where Customer_Id=@Customer_Id and ID=@ID"
                cmd.Parameters.AddWithValue("@Customer_Id", C_Id)
                cmd.Parameters.AddWithValue("@ID", loadcomp)
                dr = cmd.ExecuteReader

                If dr.Read() Then

                    C_inv.Text = C_Id.ToString()
                    C_Name.Text = dr("Customer_Name").ToString()
                    C_Prod.Text = dr("Product_Name").ToString()
                    C_Mdno.Text = dr("Model_Number").ToString()
                    C_dop.Value = Convert.ToDateTime((dr("DOP").ToString()))
                    C_Doi.Text = Convert.ToDateTime(dr("DOI").ToString())
                    C_Adr.Text = dr("Customer_Address").ToString()
                    C_Ph.Text = dr("Phone_number").ToString()
                    C_Ph1.Text = dr("Alt_Phone_Number").ToString()

                End If

                dr.Close()
                cmd.Parameters.Clear()
                Load_Model(C_Prod.Text)
            Catch ex As Exception
                dr.Close()
                cmd.Parameters.Clear()
                MsgBox(ex.Message.ToString())
            End Try
        Else
            B_Back.Enabled = False
            B_Next.Enabled = False
        End If
        C_inv.Focus()
    End Sub

    Private Sub New_Btn_Click(sender As Object, e As EventArgs)
        new_Customer()
    End Sub
    Public Sub new_Customer()
        C_inv.ResetText()
        C_Name.ResetText()
        C_Adr.ResetText()
        C_Ph.ResetText()
        C_Ph1.ResetText()
        C_Prod.ResetText()
        C_Doi.ResetText()
        C_dop.ResetText()
        C_Mdno.ResetText()
        C_inv.Focus()
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Main2.loadcustomers()
        Me.Close()
    End Sub

    Private Sub SaveSingle()
        Dim Save As New ClsCustomer
        If (C_inv.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customer Id", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_inv.Focus()
            End If

        ElseIf (C_Name.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customer Name.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_Name.Focus()
            End If

        ElseIf (C_dop.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Date of Purchase", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_dop.Focus()
            End If
        ElseIf (C_Doi.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Date of Instalation.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_Doi.Focus()
            End If
        ElseIf (C_Adr.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customer Address.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_Doi.Focus()
            End If
        ElseIf (C_Ph.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customers Phone Number.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_Doi.Focus()
            End If
        ElseIf (C_Ph1.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customers Alternate Phone Number.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_Doi.Focus()
            End If

        Else
            If MessageBox.Show("Accept all these ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                Save.SaveData(Convert.ToInt32(C_inv.Text), C_Name.Text, C_Prod.Text, C_Mdno.Text, C_dop.Value.Date, C_Doi.Value.Date, C_Adr.Text.ToString(), C_Ph.Text, C_Ph1.Text)
                'Save.setnext(Convert.ToInt32(C_inv.Text), C_Name.Text, C_Prod.Text, C_dop.Value.Date, C_Doi.Value.Date, C_Adr.Text, C_Ph.Text, C_Ph1.Text)

                MessageBox.Show("Saved Successfully")
                Main2.loadcustomers()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub SaveMultiple()
        Dim Save As New ClsCustomer
        If (C_inv.Text.Trim() = "") Then
            If MessageBox.Show("Please enter product name.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_inv.Focus()
            End If

        ElseIf (C_Name.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Model Number.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_Name.Focus()
            End If

        ElseIf (C_dop.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Service Interval.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_dop.Focus()
            End If
        ElseIf (C_Doi.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Service Interval.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_Doi.Focus()
            End If
        ElseIf (C_Adr.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customer Address.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_Doi.Focus()
            End If
        ElseIf (C_Ph.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customers Phone Number.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_Doi.Focus()
            End If
        ElseIf (C_Ph1.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customers Alternate Phone Number.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                C_Doi.Focus()
            End If

        Else
            If MessageBox.Show("Accept all these ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                Save.SaveData(Convert.ToInt32(C_inv.Text), C_Name.Text, C_Prod.Text, C_Mdno.Text, C_dop.Value.Date, C_Doi.Value.Date, C_Adr.Text, C_Ph.Text, C_Ph1.Text)
                'Save.setnext(Convert.ToInt32(C_inv.Text), C_Name.Text, C_Prod.Text, C_dop.Value.Date, C_Doi.Value.Date, C_Adr.Text, C_Ph.Text, C_Ph1.Text)
                MessageBox.Show("Saved Successfully")
                'Dim listCust As New List_Customers
                C_inv.Text = ""
                C_Name.Text = ""
                C_dop.ResetText()
                C_Doi.ResetText()
                C_Adr.Text = ""
                C_Ph.Text = ""
                C_Ph1.Text = ""
                C_Prod.ResetText()
                C_Mdno.ResetText()
                C_inv.Focus()
                Main2.loadcustomers()
            End If
        End If
    End Sub




    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        delete_Customer()
    End Sub
    Private Sub delete_Customer()
        Dim del As New ClsCustomer
        If (Not (C_inv.Text.Trim() = "")) Then

            del.DelData(C_inv.Text)
            C_inv.Text = ""
            C_Name.Text = ""
            C_Prod.Text = ""
            C_Mdno.Text = ""
            C_dop.Text = ""
            C_Doi.Text = ""
            C_Adr.Text = ""
            C_Ph.Text = ""
            C_Ph1.Text = ""

            
            Me.Close()

        End If
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles B_Back.Click
        prev_Customer()
    End Sub
    Private Sub prev_Customer()
        Try
            If (C_Show_G = True) Then
                Dim i As Integer = 0
                B_Back.Enabled = True
                B_Next.Enabled = True
                ' MessageBox.Show("i =" + C_Index.ToString())
                cmd.CommandText = "select * from Cust where ID=@ID order by Customer_Id"
                cmd.Parameters.AddWithValue("@ID", loadcomp)
                dr = cmd.ExecuteReader
                C_Index = C_Index - 1
                If (C_Index <= 0) Then
                    B_Back.Enabled = False
                End If
                While dr.Read()
                    If (i = C_Index) Then
                        C_inv.Text = dr("Customer_Id").ToString()
                        C_Name.Text = dr("Customer_Name").ToString()
                        C_Prod.Text = dr("Product_Name").ToString()
                        C_Mdno.Text = dr("Model_Number").ToString()
                        C_dop.Value = dr("DOP").ToString()
                        C_Doi.Value = dr("DOI").ToString()
                        C_Adr.Text = dr("Customer_Address").ToString()
                        C_Ph.Text = dr("Phone_number").ToString()
                        C_Ph1.Text = dr("Alt_Phone_Number").ToString()

                    End If
                    i += 1
                End While

                dr.Close()
                cmd.Parameters.Clear()
                Load_Model(C_Prod.Text)
            End If
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles C_dop.ValueChanged
        C_Doi.MinDate = C_dop.Value
    End Sub

    Private Sub B_Next_Click(sender As Object, e As EventArgs) Handles B_Next.Click
        next_Customer()
    End Sub
    Private Sub next_Customer()
        Try
            If (C_Show_G = True) Then
                Dim i As Integer = 0
                B_Back.Enabled = True
                B_Next.Enabled = True
                'MessageBox.Show("i =" + C_Index.ToString())
                cmd.CommandText = "select * from Cust where ID=@ID order by Customer_Id"
                cmd.Parameters.AddWithValue("@ID", loadcomp)
                dr = cmd.ExecuteReader
                C_Index = C_Index + 1
                If (C_Index >= C_Count_G - 1) Then
                    B_Next.Enabled = False
                End If
                While dr.Read()
                    If (i = C_Index) Then
                        C_inv.Text = dr("Customer_Id").ToString
                        C_Name.Text = dr("Customer_Name").ToString()
                        C_Prod.Text = dr("Product_Name").ToString()
                        C_Mdno.Text = dr("Model_Number").ToString()
                        C_dop.Value = dr("DOP").ToString()
                        C_Doi.Value = dr("DOI").ToString()
                        C_Adr.Text = dr("Customer_Address").ToString()
                        C_Ph.Text = dr("Phone_number").ToString()
                        C_Ph1.Text = dr("Alt_Phone_Number").ToString()
                    End If
                    i += 1
                End While
                dr.Close()
                cmd.Parameters.Clear()
                Load_Model(C_Prod.Text)
            End If
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try

    End Sub



    Private Sub C_Prod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_Prod.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Public Sub Load_Model(Product_Name As String)
        Try
            C_Mdno.Items.Clear()

            cmd.CommandText = "select Model_Number from Prod where Product_Name=@Product_Name and ID=@ID"
            ' MessageBox.Show(C_Prod.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Product_Name", Product_Name)
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            Dim prd As String


            dr = cmd.ExecuteReader()
            While dr.Read()
                prd = dr("Model_Number").ToString()
                C_Mdno.Items.Add(prd)
                'MessageBox.Show(prd)
            End While
            dr.Close()
            cmd.Parameters.Clear()

        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub


    Private Sub C_Prod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C_Prod.SelectedIndexChanged

        If (C_Show_G = False) Then
            C_Mdno.ResetText()
            Load_Model(C_Prod.SelectedItem.ToString())
        End If
    End Sub

    

    Private Sub C_Ph_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles C_Ph.KeyPress
        If Asc(e.KeyChar) < 32 Then Exit Sub
        If Not (Asc(e.KeyChar) >= 47 And Asc(e.KeyChar) <= 58) Then
            e.KeyChar = ChrW(CInt(0))
        End If
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub C_Ph1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_Ph1.KeyPress
        If Asc(e.KeyChar) < 32 Then Exit Sub
        If Not (Asc(e.KeyChar) >= 47 And Asc(e.KeyChar) <= 58) Then
            e.KeyChar = ChrW(CInt(0))
        End If
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub C_inv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_inv.KeyPress
        If Asc(e.KeyChar) < 32 Then Exit Sub
        If Not (Asc(e.KeyChar) >= 47 And Asc(e.KeyChar) <= 58) Then
            e.KeyChar = ChrW(CInt(0))
        End If
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub

    Private Sub C_Mdno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_Mdno.KeyPress
        If Asc(e.KeyChar) <> 13 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt And e.KeyCode = Keys.Left And B_back.Enabled = True Then
            prev_Customer()
        ElseIf e.Alt And e.KeyCode = Keys.Right And B_Next.Enabled = True Then
            next_Customer()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            If cur_canAdd = False Then
                new_Customer()
            Else
                MessageBox.Show("You do not have privilages to add new customer")
            End If
        ElseIf e.Control And e.KeyCode = Keys.L Then
            Main2.loadcustomers()
            Me.Close()
        ElseIf e.Shift And e.KeyCode = Keys.Delete Then
            If cur_canAdd = True Then
                ' Remove()
                delete_Customer()
            Else
                MessageBox.Show("you do not have privilages to delete customer")
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            ' Remove()
            Main2.loadcustomers()

            Me.Close()
        ElseIf e.Control And e.Shift And e.KeyCode = Keys.S Then
            If cur_canAdd = True Then
                SaveMultiple()
                ' Remove()
                '  new_Cust_Show_Keys()
            Else
                MessageBox.Show("You do not have privilages to modify customer data")
            End If
        ElseIf e.Control And e.KeyCode = Keys.S Then
            If cur_canAdd = True Then
                'Remove()
                SaveSingle()
            Else
                MessageBox.Show("you do not have privilages to modify customer data")
            End If
        End If
    End Sub

  
    
    
   
End Class