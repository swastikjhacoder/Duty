Public Class ClsCustomer
    ' Public addcustomer As Boolean
    Public Sub Addrecord(Customer_Id As Integer, Customer_Name As String, Product_Name As String, Model_Number As String, DOP As Date, DOI As Date, Customer_Address As String, Phone_Number As String, Alt_Phone_Number As String)

        Try

            cmd.CommandText = "insert into Cust(Customer_Id,Customer_Name,Product_Name,Model_Number,DOP,DOI,Customer_Address,Phone_Number,Alt_Phone_Number,Service_Count,ID) values (@Customer_Id,@Customer_Name,@Product_Name,@Model_Number,@DOP,@DOI,@Customer_Address,@Phone_Number,@Alt_Phone_Number,0,@ID)"
            cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id)
            cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name)
            cmd.Parameters.AddWithValue("@Product_Name", Product_Name)
            cmd.Parameters.AddWithValue("@Model_Number", Model_Number)

            cmd.Parameters.AddWithValue("@DOP", DOP)
            cmd.Parameters.AddWithValue("@DOI", DOI)
            cmd.Parameters.AddWithValue("@Customer_Address", Customer_Address)
            cmd.Parameters.AddWithValue("@Phone_Number", Phone_Number)
            cmd.Parameters.AddWithValue("@Alt_Phone_Number", Alt_Phone_Number)
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            'cmd.Parameters.AddWithValue("@Service_Count", 0)

            cmd.ExecuteNonQuery()
            ' MessageBox.Show("data saved")
            cmd.Parameters.Clear()
            'MessageBox.Show("data is being saved")

        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
        Try
            cmd.CommandText = "update Cust INNER JOIN Prod on Cust.Product_Name=Prod.Product_Name and Cust.Model_Number=Prod.Model_Number set Cust.Service_Interval=Prod.Servicing_Interval"
            'cmd.Parameters.AddWithValue("@Product_Name", Product_Name)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Public Sub updaterecord(Customer_Id As Integer, Customer_Name As String, Product_Name As String, Model_Number As String, DOP As Date, DOI As Date, Customer_Address As String, Phone_Number As String, Alt_Phone_Number As String)

        Try
            cmd.CommandText = "update Cust set Customer_Name=@Customer_Name,Product_Name=@Product_Name,Model_Number=@Model_Number,DOP=@DOP,DOI=@DOI,Customer_Address=@Customer_Address,Phone_Number=@Phone_Number,Alt_Phone_Number=@Alt_Phone_Number where Customer_Id=@Customer_Id and ID=@ID"


            cmd.Parameters.AddWithValue("@Customer_Name", Customer_Name)
            cmd.Parameters.AddWithValue("@Product_Name", Product_Name)
            cmd.Parameters.AddWithValue("@Model_Number", Model_Number)
            cmd.Parameters.AddWithValue("@DOP", DOP)
            cmd.Parameters.AddWithValue("@DOI", DOI)

            cmd.Parameters.AddWithValue("@Customer_Address", Customer_Address)
            cmd.Parameters.AddWithValue("@Phone_Number", Phone_Number)
            cmd.Parameters.AddWithValue("@Alt_Phone_Number", Alt_Phone_Number)
            cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id)
            ' Customer_Name
            ' Product_Name
            'DOP()
            '  DOI()
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()

            'MessageBox.Show("Updated")
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try

        Try
            cmd.CommandText = "update Cust INNER JOIN Prod on Prod.Product_Name=Cust.Product_Name and Cust.Model_Number=Prod.Model_Number set Cust.Service_Interval=Prod.Servicing_Interval"
            'cmd.Parameters.AddWithValue("@Product_Name", Product_Name)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Public Sub SaveData(Customer_Id As Integer, Customer_Name As String, Product_Name As String, Model_Number As String, DOP As Date, DOI As Date, Customer_Address As String, Phone_Number As String, Alt_Phone_Number As String)
        Try
            cmd.CommandText = "select * from Cust where Customer_Id=@Customer_Id and ID=@ID"
            cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id)
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader()
            If (dr.Read()) Then
                dr.Close()
                cmd.Parameters.Clear()
                '   MessageBox.Show("data is present")
                updaterecord(Customer_Id, Customer_Name, Product_Name, Model_Number, DOP, DOI, Customer_Address, Phone_Number, Alt_Phone_Number)
                setnext(Customer_Id)
            Else
                dr.Close()
                cmd.Parameters.Clear()
                'MessageBox.Show("data is being saved")
                Addrecord(Customer_Id, Customer_Name, Product_Name, Model_Number, DOP, DOI, Customer_Address, Phone_Number, Alt_Phone_Number)
                setnext(Customer_Id)
            End If


        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
    Public Sub DelData(Customer_Id As Integer)
        Try
            cmd.CommandText = "delete from Cust where Customer_Id=@Customer_Id and ID=@ID"
            cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id)
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
    Public Sub setnext(Customer_Id As Integer)
        Dim interval As Integer
        Dim d_temp As Date
        '  loadservice()

        Try
            cmd.CommandText = "select Service_Interval,DOI from Cust where Customer_Id=@Customer_Id and ID=@ID"
            cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id)
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                interval = Convert.ToInt32(dr("Service_Interval").ToString())
                d_temp = CDate(dr("DOI").ToString()).ToShortDateString()
            End If
            'MessageBox.Show(interval.ToString() + "  " + d_temp.ToString())
            dr.Close()
            cmd.Parameters.Clear()

        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
        d_temp = d_temp.AddMonths(interval)
        Try
            cmd.CommandText = "update Cust set Next_Service=@d_temp where Customer_Id=@Customer_Id and ID=@ID"
            cmd.Parameters.AddWithValue("@d_temp", d_temp)
            ' cmd.Parameters.AddWithValue("@Feedback", String.Empty)
            cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id)
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
    Public Sub setnextnext(Customer_Id As Integer)
        Dim interval As Integer
        Dim count As Integer = 0
        Dim d_temp As Date
        '  loadservice()

        Try
            cmd.CommandText = "select Service_Interval,Next_Service,Service_Count from Cust where Customer_Id=@Customer_Id and ID=@ID"                '
            cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id)
            cmd.Parameters.AddWithValue("@ID", loadcomp)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                interval = Convert.ToInt32(dr("Service_Interval").ToString())
                d_temp = CDate(dr("Next_Service").ToString()).ToShortDateString()
                count = Convert.ToInt32(dr("Service_Count").ToString())
                'MessageBox.Show(count.ToString)
            End If
            'MessageBox.Show(interval.ToString() + "  " + d_temp.ToString())
            dr.Close()
            cmd.Parameters.Clear()

        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
        'If count + 1 >= 3 Then
        '    Try
        '        cmd.CommandText = "Delete from Cust where Customer_Id=@Customer_Id"
        '        cmd.Parameters.AddWithValue("Customer_Id", Customer_Id)
        '        cmd.ExecuteNonQuery()
        '        cmd.Parameters.Clear()
        '    Catch ex As Exception
        '        dr.Close()
        '        cmd.Parameters.Clear()
        '        MsgBox(ex.Message.ToString())
        '    End Try
        'Else
        d_temp = d_temp.AddMonths(interval)
            'MessageBox.Show(d_temp.ToString())
            Try
            cmd.CommandText = "update Cust set Next_Service=@d_temp,Serviced=false,Service_Count=@Service_Count where Customer_Id=@Customer_Id and ID=@ID"
                cmd.Parameters.AddWithValue("@d_temp", d_temp)
                cmd.Parameters.AddWithValue("@Service_Count", count + 1)

            cmd.Parameters.AddWithValue("@Customer_Id", Customer_Id)
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
    'Public Sub loadservice()
    '    'Dim arr(C_Count_G) As Integer
    '    'Try
    '    '    cmd.CommandText = "select Servicing_Interval from Prod order by Product_Id"
    '    '    dr = cmd.ExecuteReader()
    '    '    Dim i As Integer = 0
    '    '    While dr.Read()
    '    '        arr(i) = Convert.ToInt32(dr("Servicing_Interval").ToString())
    '    '        i = i + 1
    '    '    End While
    '    '    dr.Close()
    '    'Catch ex As Exception
    '    '    dr.Close()
    '    '    cmd.Parameters.Clear()
    '    '    MsgBox(ex.Message.ToString())
    '    'End Try
    '    Try
    '        cmd.CommandText = "update Cust set Cust.Service_Interval=Prod.Servicing_Interval from Prod inner join Cust on Prod.Product_Name=Cust.Product_Name "
    '        cmd.ExecuteNonQuery()
    '        cmd.Parameters.Clear()
    '    Catch ex As Exception
    '        dr.Close()
    '        cmd.Parameters.Clear()
    '        MsgBox(ex.Message.ToString())
    '    End Try
    'End Sub
    Public Sub DelCache()
        Try
            cmd.CommandText = "delete from Cust where Service_Count>3"
            dr = cmd.ExecuteReader
            cmd.Parameters.Clear()
            '
            dr.Close()
        Catch ex As Exception
            dr.Close()
            cmd.Parameters.Clear()
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class
