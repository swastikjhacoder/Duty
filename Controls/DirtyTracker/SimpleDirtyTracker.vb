Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DirtyTracking
    Public Class SimpleDirtyTracker
        Private _frmTracked As Form
        Private _isDirty As Boolean

        ' property denoting whether the tracked form is clean or dirty
        Public Property IsDirty() As Boolean
            Get
                Return _isDirty
            End Get
            Set(value As Boolean)
                _isDirty = value
            End Set
        End Property

        ' methods to make dirty or clean
        Public Sub SetAsDirty()
            _isDirty = True
        End Sub

        Public Sub SetAsClean()
            _isDirty = False
        End Sub

        ' initialize in the constructor by assigning event handlers
        Public Sub New(frm As Form)
            _frmTracked = frm
            AssignHandlersForControlCollection(frm.Controls)
        End Sub


        ' recursive routine to inspect each control and assign handlers accordingly
        Private Sub AssignHandlersForControlCollection(coll As Control.ControlCollection)
            For Each c As Control In coll
                If TypeOf c Is TextBox Then
                    AddHandler TryCast(c, TextBox).TextChanged, AddressOf SimpleDirtyTracker_TextChanged
                End If

                If TypeOf c Is CheckBox Then
                    AddHandler TryCast(c, CheckBox).CheckedChanged, AddressOf SimpleDirtyTracker_CheckedChanged
                End If

                ' ... apply for other input types similarly ...

                ' recurively apply to inner collections
                If c.HasChildren Then
                    AssignHandlersForControlCollection(c.Controls)
                End If
            Next
        End Sub

        ' event handlers
        Private Sub SimpleDirtyTracker_TextChanged(sender As Object, e As EventArgs)
            _isDirty = True
        End Sub

        Private Sub SimpleDirtyTracker_CheckedChanged(sender As Object, e As EventArgs)
            _isDirty = True
        End Sub

    End Class
End Namespace