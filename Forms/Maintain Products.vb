Public Class Maintain_Products
    Private Sub New_Product()
        P_Pid.Text = P_Pidg.ToString()
        P_Name.Text = ""
        P_Model.Text = ""
        P_Service.Text = ""
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

        New_Product()
    End Sub

    Private Sub saverecord()
        Try
            Dim Save As New ClsProduct
            If (P_Name.Text.Trim() = "") Then
                If MessageBox.Show("Please enter product name.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    P_Name.Focus()
                End If

            ElseIf (P_Model.Text.Trim() = "") Then
                If MessageBox.Show("Please enter Model Number.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    P_Model.Focus()
                End If

            ElseIf (P_Service.Text.Trim() = "") Then
                If MessageBox.Show("Please enter Service Interval.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                    P_Service.Focus()
                End If
            ElseIf (Convert.ToInt32(P_Pid.Text.ToString() < P_Pidg) And P_CanUpdate = False) Then

                MessageBox.Show("The given Product Id is already Present for some other Products Please try some other Product_id")
                P_Pid.Text = P_Pidg.ToString
            Else
                If MessageBox.Show("Accept all these ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                    Save.SaveData(P_Pid.Text, P_Name.Text, P_Model.Text, P_Service.Text)
                    If Save.addok = True Then
                        MessageBox.Show("Record Saved Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                       
                    ElseIf Save.updateok = True Then
                        MessageBox.Show("Record Updated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveSingle()
        saverecord()
        P_Pidg = P_Pidg + 1
        Main2.loadproducts()
        Me.Close()
    End Sub
    Private Sub SaveMultiple()

        saverecord()
        P_Pidg = P_Pidg + 1
        'P_Pid.Text = (Convert.ToInt32(P_Pid.Text) + 1).ToString()
        ' MessageBox.Show(P_Pidg.ToString)
        P_Pid.Text = P_Pidg.ToString()
        Main2.loadproducts()
        P_Name.Text = ""
        P_Model.Text = ""
        P_Service.Text = ""
        P_Name.Focus()

    End Sub
  
    Private Sub Maintain_Products_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.N AndAlso e.Modifiers = Keys.Control Then
            If cur_canAdd = True Then
                e.Handled = True
                New_Product()
            Else
                MessageBox.Show("You do not have proper privilages to add products")
                Me.Close()
            End If
        End If
    End Sub
    Private Sub Maintain_Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        P_Name.Focus()
        P_Name.CharacterCasing = CharacterCasing.Upper
        P_Service.Text = ""
        Me.KeyPreview = True
        If cur_canAdd = False Then
            P_Name.ReadOnly = True
            P_Model.ReadOnly = True
            P_Service.Enabled = False
        End If
        Dim counter As Integer = 0
        Try
            cmd.CommandText = "select MAX(Product_Id) as pid from Prod"
            dr = cmd.ExecuteReader()
            If (dr.Read()) Then
                counter = Convert.ToInt32(dr("pid").ToString())
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
        counter = counter + 1
        P_Pid.Text = (counter).ToString()
        ' MessageBox.Show(counter.ToString())
        P_Pidg = counter
        Try
            If (P_Show_G = True) Then
                Dim i As Integer = 0
                B_back.Enabled = True
                B_Next.Enabled = True
                If (P_Index = 1) Then
                    B_back.Enabled = False
                End If
                If (P_Index = counter - 1) Then
                    B_Next.Enabled = False
                End If
                'MessageBox.Show("i =" + P_Index.ToString())
                cmd.CommandText = "select * from Prod where Product_Id=@P_Index and ID=@ID"
                cmd.Parameters.AddWithValue("@P_Index", P_Index)
                cmd.Parameters.AddWithValue("@ID", loadcomp)
                dr = cmd.ExecuteReader
                While dr.Read()
                    P_Pid.Text = dr("Product_Id").ToString()
                    P_Name.Text = dr("Product_Name").ToString()
                    P_Model.Text = dr("Model_Number").ToString()
                    P_Service.Text = dr("Servicing_Interval").ToString()
                    i += 1
                End While
                dr.Close()
                cmd.Parameters.Clear()
            Else
                B_back.Enabled = False
                B_Next.Enabled = False
            End If
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Private Sub B_back_Click(sender As Object, e As EventArgs) Handles B_back.Click
        Prev_Product(sender, e)
    End Sub
    Private Sub Prev_Product(sender As Object, e As EventArgs)
        Try
            If (P_Show_G = True) Then
                Dim i As Integer = 0
                B_back.Enabled = True
                B_Next.Enabled = True
                P_Index = P_Index - 1
                '   MessageBox.Show("i =" + P_Index.ToString())
                cmd.CommandText = "select * from Prod where Product_Id=@P_Index and ID=@ID"
                cmd.Parameters.AddWithValue("@P_Index", P_Index)
                cmd.Parameters.AddWithValue("@ID", loadcomp)
                dr = cmd.ExecuteReader

                If (P_Index <= 1) Then
                    B_back.Enabled = False
                End If
                If dr.Read() Then

                    P_Pid.Text = dr("Product_Id").ToString()
                    P_Name.Text = dr("Product_Name").ToString()
                    P_Model.Text = dr("Model_Number").ToString()
                    P_Service.Text = dr("Servicing_Interval").ToString()
                    dr.Close()
                    cmd.Parameters.Clear()
                Else
                    ' MessageBox.Show("Product Id- " + P_Index.ToString + " does not exist")

                    dr.Close()
                    cmd.Parameters.Clear()
                    B_back_Click(sender, e)
                End If



            End If
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
        P_Name.Focus()

    End Sub
    Private Sub B_Next_Click(sender As Object, e As EventArgs) Handles B_Next.Click
        Next_Product(sender, e)
    End Sub
    Private Sub Next_Product(sender As Object, e As EventArgs)
        Try
            If (P_Show_G = True) Then
                Dim i As Integer = 0
                B_back.Enabled = True
                B_Next.Enabled = True
                P_Index = P_Index + 1
                '   MessageBox.Show("i =" + P_Index.ToString())
                cmd.CommandText = "select * from Prod where Product_Id=@P_Index and ID=@ID"
                cmd.Parameters.AddWithValue("@P_Index", P_Index)
                cmd.Parameters.AddWithValue("@ID", loadcomp)
                dr = cmd.ExecuteReader

                If (P_Index >= P_Pidg - 1) Then
                    B_Next.Enabled = False
                End If
                If dr.Read() Then

                    P_Pid.Text = dr("Product_Id").ToString()
                    P_Name.Text = dr("Product_Name").ToString()
                    P_Model.Text = dr("Model_Number").ToString()
                    P_Service.Text = dr("Servicing_Interval").ToString()
                    dr.Close()
                    cmd.Parameters.Clear()
                Else
                    ' MessageBox.Show("Product Id- " + P_Index.ToString + " does not exist")

                    dr.Close()
                    cmd.Parameters.Clear()
                    B_Next_Click(sender, e)
                End If

            End If
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
        P_Name.Focus()

    End Sub
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs)
        Del_Products()
    End Sub
    Private Sub Del_Products()
        If (Not (P_Name.Text.Trim() = "")) Then
            Dim del As New ClsProduct
            del.DelData(P_Name.Text)
            P_Name.Text = ""
            P_Model.Text = ""
            P_Service.Text = ""
            Main2.loadproducts()
            Me.Close()

        End If
    End Sub
    Private Sub Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt And e.KeyCode = Keys.Left And B_back.Enabled = True Then
            Prev_Product(sender, e)
        ElseIf e.Alt And e.KeyCode = Keys.Right And B_Next.Enabled = True Then
            Next_Product(sender, e)
        ElseIf e.Control And e.KeyCode = Keys.N Then
            If cur_canAdd = True Then
                New_Product()
            Else
                MessageBox.Show("You do not have privilages to add products")
            End If
        ElseIf e.Control And e.KeyCode = Keys.L Then
            Main2.loadproducts()
            Me.Close()
        ElseIf e.Shift And e.KeyCode = Keys.Delete Then
            If cur_canAdd = True Then
                Del_Products()
            Else
                MessageBox.Show("You do not have privilages to delete products")
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            '  Remove()
            Main2.loadproducts()
            Me.Close()
        ElseIf e.Control And e.KeyCode = Keys.S And e.Shift Then
            If cur_canAdd = True Then
                SaveMultiple()
            Else
                MessageBox.Show("You do not have privilages to modify products")
            End If
        ElseIf e.Control And e.KeyCode = Keys.S Then
            If cur_canAdd Then
                SaveSingle()
            Else
                MessageBox.Show("You do not have privilages to modify products")

            End If
        End If
    End Sub

   
End Class