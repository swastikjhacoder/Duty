Public Class ClsProduct
    Public addok As Boolean = False
    Public deleteok As Boolean = False
    Public updateok As Boolean = False
    Public Sub SetPId()
        
    End Sub
    Public Sub Addrecord(Product_Id As Integer, Product_Name As String, Model_Number As String, Servicing_Interval As Integer)
        Try
            cmd.CommandText = "insert into Prod(Product_Name,Model_Number,Servicing_Interval,ID) values ('" & Product_Name & "','" & Model_Number & "'," & Servicing_Interval & "," & loadcomp & ")"
            'cmd.Parameters.AddWithValue("@Product_Name", Product_Name)
            'cmd.Parameters.AddWithValue("@Model_Number", Model_Number)
            'cmd.Parameters.AddWithValue("@Servicing_Intervals", Servicing_Interval)
            ''MessageBox.Show("Added")
            'cmd.ExecuteNonQuery()
            'cmd.Parameters.Clear()
            ''dr.Close()
            dr = cmd.ExecuteReader()
            dr.Close()
            addok = True
        Catch ex As Exception
            addok = False
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Public Sub Updaterecord(Product_Id As Integer, Product_Name As String, Model_Number As String, Servicing_Interval As Integer)
        Try
            cmd.CommandText = "update Prod set Product_Name=@Product_Name,Model_Number=@Model_Number,Servicing_Interval=@Servicing_Interval where Product_Id=@Product_Id and ID=@ID"
            cmd.Parameters.AddWithValue("@Product_Name", Product_Name)
            cmd.Parameters.AddWithValue("@Model_Number", Model_Number)
            cmd.Parameters.AddWithValue("@Servicing_Intervals", Servicing_Interval)
            cmd.Parameters.AddWithValue("@Product_Id", Product_Id)
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            dr.Close()
            updateok = True
        Catch ex As Exception
            dr.Close()
            updateok = False
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Public Sub SaveData(Product_Id As Integer, Product_Name As String, Model_Number As String, Servicing_Interval As Integer)
        Try
            cmd.CommandText = "select * from Prod where Product_Id=@Product_Id and ID=@ID"
            cmd.Parameters.AddWithValue("@Product_Id", Product_Id)
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader()
            If (dr.Read()) Then
                dr.Close()
                cmd.Parameters.Clear()
                Updaterecord(Product_Id, Product_Name, Model_Number, Servicing_Interval)
                P_CanUpdate = False
            Else
                dr.Close()
                cmd.Parameters.Clear()
                Addrecord(Product_Id, Product_Name, Model_Number, Servicing_Interval)
            End If


        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Public Sub DelData(Product_Name As String)
        Try
            cmd.CommandText = "delete from Prod where Product_Name=@Product_Name and ID=@ID"
            cmd.Parameters.AddWithValue("@Product_Name", Product_Name)
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader
            cmd.Parameters.Clear()
            MessageBox.Show("Deleted")
            dr.Close()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class
