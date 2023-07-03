Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DirtyTracking
    Public Class ControlDirtyTracker
        Private _control As Control
        Private _cleanValue As String

        ' read only properties
        Public ReadOnly Property Control() As Control
            Get
                Return _control
            End Get
        End Property
        Public ReadOnly Property CleanValue() As String
            Get
                Return _cleanValue
            End Get
        End Property

        ' constructor establishes the control and uses its current value as "clean"
        Public Sub New(ctl As Control)
            ' if the control type is not one that is supported, throw an exception
            If ControlDirtyTracker.IsControlTypeSupported(ctl) Then
                _control = ctl
            Else
                Throw New NotSupportedException(String.Format("The control type for '{0}' is not supported by the ControlDirtyTracker class.", ctl.Name))

            End If
        End Sub


        ' method to establish the the current control value as "clean"
        Public Sub EstablishValueAsClean()
            _cleanValue = GetControlCurrentValue()
        End Sub


        ' determine if the current control value is considered "dirty"; 
        ' i.e. if the current control value is different than the one
        ' remembered as "clean"
        Public Function DetermineIfDirty() As Boolean
            ' compare the remembered "clean value" to the current value;
            ' if they are the same, the control is still clean;
            ' if they are different, the control is considered dirty.
            Return (String.Compare(_cleanValue, GetControlCurrentValue(), False) <> 0)
        End Function

        Public Shared Function IsControlTypeSupported(ctl As Control) As Boolean
            ' list of types supported
            If TypeOf ctl Is TextBox Then
                Return True
            End If
            If TypeOf ctl Is CheckBox Then
                Return True
            End If
            If TypeOf ctl Is ComboBox Then
                Return True
            End If
            If TypeOf ctl Is ListBox Then
                Return True
            End If

            ' ... add additional types as desired ...                       

            ' not a supported type
            Return False
        End Function


        ' private method to determine the current value (as a string) of the control;
        ' if the control is not supported, return a NotSupported exception
        ' developers may modify this to extend support for other types
        Private Function GetControlCurrentValue() As String
            If TypeOf _control Is TextBox Then
                Return TryCast(_control, TextBox).Text
            End If

            If TypeOf _control Is CheckBox Then
                Return TryCast(_control, CheckBox).Checked.ToString()
            End If

            If TypeOf _control Is ComboBox Then
                Return TryCast(_control, ComboBox).Text
            End If

            If TypeOf _control Is ListBox Then
                ' for a listbox, create a list of the selected indexes
                Dim val As New StringBuilder()
                Dim lb As ListBox = TryCast(_control, ListBox)
                Dim coll As ListBox.SelectedIndexCollection = lb.SelectedIndices
                For i As Integer = 0 To coll.Count - 1
                    val.AppendFormat("{0};", coll(i))
                Next

                Return val.ToString()
            End If

            ' ... add additional types as desired ...

            Return ""
        End Function

    End Class
End Namespace