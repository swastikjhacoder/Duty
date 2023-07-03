Public Class ClsCompany
    Public Sub AddComp(Comp_Name As String, Comp_Addr As String, Comp_Ph As Integer, Comp_Email As String, Comp_Web As String)
        Try

            cmd.CommandText = "insert into Company(Comp_Name,Comp_Addr,Comp_Ph,Comp_Email,Comp_Web) values (@Comp_Name,@Comp_Addr,@Comp_Ph,@Comp_Email,@Comp_Web)"
            cmd.Parameters.AddWithValue("@Comp_Name", Comp_Name)
            cmd.Parameters.AddWithValue("@Comp_Addr", Comp_Addr)
            cmd.Parameters.AddWithValue("@Comp_Ph", Comp_Ph)
            cmd.Parameters.AddWithValue("@Comp_Email", Comp_Email)

            cmd.Parameters.AddWithValue("@Comp_Web", Comp_Web)
           


            cmd.ExecuteNonQuery()

            cmd.Parameters.Clear()

        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try

    End Sub
    Public Sub updateCompany(Comp_Name As String, Comp_Addr As String, Comp_Ph As Integer, Comp_Email As String, Comp_Web As String)

        Try
            cmd.CommandText = "update Company set Comp_Name=@Comp_Name,Comp_Addr=@Comp_Addr,Comp_Ph=@Comp_Ph,Comp_Email=@Comp_Email,Comp_Web=@Comp_Webs where ID=@ID"


            cmd.Parameters.AddWithValue("@Comp_Name", Comp_Name)
            cmd.Parameters.AddWithValue("@Comp_Addr", Comp_Addr)
            cmd.Parameters.AddWithValue("@Comp_Ph", Comp_Ph)
            cmd.Parameters.AddWithValue("@Comp_Email", Comp_Email)

            cmd.Parameters.AddWithValue("@Comp_Web", Comp_Web)
            cmd.Parameters.AddWithValue("@ID", Comp_Show_ID)
            ' Customer_Name
            ' Product_Name
            'DOP()
            '  DOI()
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()

            'MessageBox.Show("Updated")
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try

    End Sub
    Public Sub delCompany(Comp_Id As Integer)
        Try
            cmd.CommandText = "delete from Company where ID=@ID"
            cmd.Parameters.AddWithValue("@ID", Comp_Id)

            cmd.ExecuteNonQuery()
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
