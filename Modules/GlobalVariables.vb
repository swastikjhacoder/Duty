Module GlobalVariables
    Public loadcomp As Integer = -1
    Public showuser As Boolean = False
    Public showusername As String = String.Empty
    Public usercount As Integer = -1
    Public cur_username As String = String.Empty
    Public cur_password As String = String.Empty
    Public cur_isadmin As Boolean = False
    Public cur_canAdd As Boolean = False
    Public cur_canService As Boolean = False
    Public cur_mod_user As Boolean = False
    Public Comp_Show_G As Boolean = False
    Public Comp_Show_ID As Integer = -1
    'variables to connect list products and maintain products (previously new products)
    Public P_Pidg As Integer = 1
    Public P_Name_G As String = ""
    Public P_Model_G As String = ""
    Public P_Service_G As String = ""
    Public P_Show_G As Boolean = False
    Public P_CanUpdate As Boolean = False
    Public P_Index As Integer = -1
    Public P_Count_G As Integer = 0
    Public P_Del_G As Integer = False
    Public C_Count_G As Integer = 0
    Public C_Show_G As Boolean = False
    Public C_Del_G As Integer = False
    Public C_Index As Integer = -1
    Public C_Id As Integer = -1
    Public S_Count_G As Integer = 0
    Public S_Index As Integer = -1
    Public S_CIndex As Integer()
    Public Cid_Changed As New ArrayList

    Public feed_Changed As New ArrayList

    Public Cid_remove As New ArrayList
    Public listOfcontrols As New List(Of Control)
End Module
