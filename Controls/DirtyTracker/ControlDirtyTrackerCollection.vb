Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DirtyTracking
    Public Class ControlDirtyTrackerCollection
        Inherits List(Of ControlDirtyTracker)

        ' constructors
        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub New(ByVal frm As Form)
            MyBase.New()
            ' initialize to the controls on the passed in form
            AddControlsFromForm(frm)
        End Sub


        ' utility method to add the controls from a Form to this collection
        Public Sub AddControlsFromForm(ByVal frm As Form)
            AddControlsFromCollection(frm.Controls)
        End Sub

        ' recursive routine to inspect each control and add to the collection accordingly
        Public Sub AddControlsFromCollection(coll As Control.ControlCollection)
            For Each c As Control In coll
                ' if the control is supported for dirty tracking, add it
                If ControlDirtyTracker.IsControlTypeSupported(c) Then
                    Me.Add(New ControlDirtyTracker(c))
                End If

                ' recurively apply to inner collections
                If c.HasChildren Then
                    AddControlsFromCollection(c.Controls)
                End If
            Next
        End Sub

        ' loop through all controls and return a list of those that are dirty
        Public Function GetListOfDirtyControls() As List(Of Control)
            Dim list As New List(Of Control)()

            For Each c As ControlDirtyTracker In Me
                If c.DetermineIfDirty() Then
                    list.Add(c.Control)
                End If
            Next

            Return list
        End Function


        ' mark all the tracked controls as clean
        Public Sub MarkAllControlsAsClean()
            For Each c As ControlDirtyTracker In Me
                c.EstablishValueAsClean()
            Next
        End Sub

    End Class
End Namespace