#Region "Imports..."
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Collections
#End Region
#Region "mGlobalConnection..."
Module mGlobalConnection
#Region "Declarations..."
    Public conn As New OleDbConnection
    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader
    Public dc As OleDbDataReader

    Public da As OleDbDataAdapter                   'new
    Public ds As DataSet                            'new
    Public tables As DataTableCollection            'new
#End Region
#Region "Methods..."
    Public Sub Connect()
        Try
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\db.mdb" + ";Persist Security Info=False;Jet OLEDB:Database Password=123"
            cmd.Connection = conn
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Public Sub Disconnect()
        conn.Close()
    End Sub
#End Region
End Module
#End Region