Imports System.Net.Mail

Public Class company

    Private Sub newCompany_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            'If Comp_Name.Text.Trim() = "" Then
            '    If MessageBox.Show("Please enter the Company Name!!!", "Roster Advance - Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning) = DialogResult.OK Then
            '        Comp_Name.Focus()
            '    End If
            'Else
            '    Try
            '        cmd.CommandText = "insert into Company(Comp_Name) values (@Comp_Name)"
            '        cmd.Parameters.AddWithValue("@Comp_Name", Comp_Name.Text)
            '        cmd.ExecuteNonQuery()
            '        cmd.Parameters.Clear()
            '        MessageBox.Show("New Company Saved")
            '        loadCompany.loadcompany()
            '        Me.Close()
            '    Catch ex As Exception
            '        dr.Close()
            '        cmd.Parameters.Clear()
            '        MsgBox(ex.Message.ToString)
            '    End Try
            'End If
            If Comp_Show_G = False Then
                SaveComp()
            Else
                UpdateComp()
                Comp_Show_G = False
                Comp_Show_ID = -1
            End If
        ElseIf e.Shift And e.KeyCode = Keys.Delete Then
            Dim del As New ClsCompany
            del.delCompany(Convert.ToInt32(Comp_Id.Text))
            loadCompany.loadcompany()
            Me.Close()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub SaveComp()
        Dim Save As New ClsCompany
        If (Comp_Name.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Company Name", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Comp_Name.Focus()
            End If

        ElseIf (Comp_Address.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customer Name.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Comp_Address.Focus()
            End If

        ElseIf (Comp_Phone.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Date of Purchase", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Comp_Phone.Focus()
            End If
        ElseIf (Comp_Email.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Date of Instalation.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Comp_Email.Focus()
            End If
        ElseIf isvalidEmail(Comp_Email.Text.Trim) = False Then
            If MessageBox.Show("Please Enter Proper Email Address.", "Duty: Incorrect Value", MessageBoxButtons.OK, MessageBoxIcon.Error) = DialogResult.OK Then
                Comp_Email.Focus()
            End If
        ElseIf (Comp_Web.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customer Address.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Comp_Web.Focus()
            End If
        ElseIf isvalidWebsite(Comp_Web.Text.Trim) = False Then
            If MessageBox.Show("Please Enter Proper WebSite.", "Duty: Incorrect Value", MessageBoxButtons.OK, MessageBoxIcon.Error) = DialogResult.OK Then
                Comp_Email.Focus()
            End If
        Else
            If MessageBox.Show("Accept all these ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                Save.AddComp(Comp_Name.Text.Trim, Comp_Address.Text.Trim, Comp_Phone.Text.Trim, Comp_Email.Text.Trim, Comp_Web.Text.Trim)
                'Save.setnext(Convert.ToInt32(C_inv.Text), C_Name.Text, C_Prod.Text, C_dop.Value.Date, C_Doi.Value.Date, C_Adr.Text, C_Ph.Text, C_Ph1.Text)

                MessageBox.Show("Saved Successfully")
                loadCompany.loadcompany()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub UpdateComp()
        Dim Save As New ClsCompany
        If (Comp_Name.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Company Name", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Comp_Name.Focus()
            End If

        ElseIf (Comp_Address.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customer Name.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Comp_Address.Focus()
            End If

        ElseIf (Comp_Phone.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Date of Purchase", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Comp_Phone.Focus()
            End If
        ElseIf (Comp_Email.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Date of Instalation.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Comp_Email.Focus()
            End If
        ElseIf isvalidEmail(Comp_Email.Text.Trim) = False Then
            If MessageBox.Show("Please Enter Proper Email Address.", "Duty: Incorrect Value", MessageBoxButtons.OK, MessageBoxIcon.Error) = DialogResult.OK Then
                Comp_Email.Focus()
            End If
        ElseIf (Comp_Web.Text.Trim() = "") Then
            If MessageBox.Show("Please enter Customer Address.", "Duty: Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) = DialogResult.OK Then
                Comp_Web.Focus()
            End If
        ElseIf isvalidWebsite(Comp_Web.Text.Trim) = False Then
            If MessageBox.Show("Please Enter Proper WebSite.", "Duty: Incorrect Value", MessageBoxButtons.OK, MessageBoxIcon.Error) = DialogResult.OK Then
                Comp_Email.Focus()
            End If
        Else
            If MessageBox.Show("Accept all these ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then

                Save.updateCompany(Comp_Name.Text.Trim, Comp_Address.Text.Trim, Comp_Phone.Text.Trim, Comp_Email.Text.Trim, Comp_Web.Text.Trim)
                'Save.setnext(Convert.ToInt32(C_inv.Text), C_Name.Text, C_Prod.Text, C_dop.Value.Date, C_Doi.Value.Date, C_Adr.Text, C_Ph.Text, C_Ph1.Text)

                MessageBox.Show("Updated Successfully")
                loadCompany.loadcompany()
                Me.Close()
            End If
        End If
    End Sub
    Function isvalidEmail(ByVal S As String) As Boolean
        Try
            'Dim A As System .Net.Mail .MailAddress (S)
            Dim m As New MailAddress(S)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Function isvalidWebsite(ByVal S As String) As Boolean
        Try
            Dim m As New Uri(S)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Private Sub newCompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Comp_Name.Focus()
        Comp_Name.CharacterCasing = CharacterCasing.Upper
        Dim counter As Integer = 0
        Try
            cmd.CommandText = "select MAX(ID) as Cid from Company"
            dr = cmd.ExecuteReader()
            If (dr.Read()) Then
                counter = Convert.ToInt32(dr("Cid").ToString())
            End If
            dr.Close()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
        counter = counter + 1
        Comp_Id.Text = (counter).ToString()
        ' MessageBox.Show(counter.ToString())
        If (Comp_Show_G = True) Then


            Dim i As Integer = 0


            Try

                ' MessageBox.Show("i =" + C_Index.ToString())
                cmd.CommandText = "select Comp_Name,Comp_Addr,Comp_Ph,Comp_Email,Comp_Web from Company where ID=@ID"
                cmd.Parameters.AddWithValue("@ID", Comp_Show_ID)
                dr = cmd.ExecuteReader

                If dr.Read() Then

                    Comp_Id.Text = Comp_Show_ID.ToString
                    Comp_Name.Text = dr("Comp_Name").ToString
                    Comp_Address.Text = dr("Comp_Addr").ToString
                    Comp_Phone.Text = dr("Comp_Ph").ToString
                    Comp_Email.Text = dr("Comp_Email").ToString
                    Comp_Web.Text = dr("Comp_Web").ToString

                End If

                dr.Close()
                cmd.Parameters.Clear()
            Catch ex As Exception
                dr.Close()
                cmd.Parameters.Clear()
                MsgBox(ex.Message.ToString())
            End Try
        End If
    End Sub






    Private Sub Comp_Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Comp_Phone.KeyPress
        If Asc(e.KeyChar) < 32 Then Exit Sub
        If Not (Asc(e.KeyChar) >= 47 And Asc(e.KeyChar) <= 58) Then
            e.KeyChar = ChrW(CInt(0))
        End If
        If Asc(e.KeyChar) = 32 Then
            e.Handled = True
        End If
    End Sub
End Class