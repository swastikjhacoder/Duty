Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing

Namespace DGVColumnSelector
    Class DataGridViewColumnSelector
        Private mDataGridView As System.Windows.Forms.DataGridView = Nothing
        Private mCheckedListBox As CheckedListBox
        Private mPopup As ToolStripDropDown
        Public MaxHeight As Integer = 300
        Public Width As Integer = 200
        Public Property DataGridView() As System.Windows.Forms.DataGridView
            Get
                Return mDataGridView
            End Get
            Set(value As System.Windows.Forms.DataGridView)
                If mDataGridView IsNot Nothing Then
                    RemoveHandler mDataGridView.CellMouseClick, AddressOf mDataGridView_CellMouseClick
                End If
                mDataGridView = value
                If mDataGridView IsNot Nothing Then
                    AddHandler mDataGridView.CellMouseClick, AddressOf mDataGridView_CellMouseClick
                End If
            End Set
        End Property

        Private Sub mDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
            If e.Button = MouseButtons.Right AndAlso e.RowIndex = -1 AndAlso e.ColumnIndex = -1 Then
                mCheckedListBox.Items.Clear()
                For Each c As DataGridViewColumn In mDataGridView.Columns
                    mCheckedListBox.Items.Add(c.HeaderText, c.Visible)
                Next
                Dim PreferredHeight As Integer = (mCheckedListBox.Items.Count * 16) + 7
                mCheckedListBox.Height = If((PreferredHeight < MaxHeight), PreferredHeight, MaxHeight)
                mCheckedListBox.Width = Me.Width
                mPopup.Show(mDataGridView.PointToScreen(New Point(e.X, e.Y)))
            End If
        End Sub

        Public Sub New()
            mCheckedListBox = New CheckedListBox()
            mCheckedListBox.CheckOnClick = True
            AddHandler mCheckedListBox.ItemCheck, AddressOf mCheckedListBox_ItemCheck

            Dim mControlHost As New ToolStripControlHost(mCheckedListBox)
            mControlHost.Padding = Padding.Empty
            mControlHost.Margin = Padding.Empty
            mControlHost.AutoSize = False

            mPopup = New ToolStripDropDown()
            mPopup.Padding = Padding.Empty
            mPopup.Items.Add(mControlHost)
        End Sub

        Public Sub New(dgv As System.Windows.Forms.DataGridView)
            Me.New()
            Me.DataGridView = dgv
        End Sub

        Private Sub mCheckedListBox_ItemCheck(sender As Object, e As ItemCheckEventArgs)
            mDataGridView.Columns(e.Index).Visible = (e.NewValue = CheckState.Checked)
        End Sub
    End Class
End Namespace