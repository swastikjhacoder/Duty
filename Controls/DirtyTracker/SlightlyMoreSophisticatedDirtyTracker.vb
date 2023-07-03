Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DirtyTracking
    Public Class SlightlyMoreSophisticatedDirtyTracker
        Private _frmTracked As Form
        Private _controlsTracked As ControlDirtyTrackerCollection

        ' property denoting whether the tracked form is clean or dirty;
        ' used if the full list of dirty controls isn't necessary
        Public ReadOnly Property IsDirty() As Boolean
            Get
                Dim dirtyControls As List(Of Control) = _controlsTracked.GetListOfDirtyControls()

                Return (dirtyControls.Count > 0)
            End Get
        End Property


        ' public method for accessing the list of currently
        ' "dirty" controls
        Public Function GetListOfDirtyControls() As List(Of Control)
            Return _controlsTracked.GetListOfDirtyControls()
        End Function


        ' establish the form as "clean" with whatever current
        ' control values exist
        Public Sub MarkAsClean()
            _controlsTracked.MarkAllControlsAsClean()
        End Sub


        ' initialize in the constructor by assigning controls to track
        Public Sub New(ByVal frm As Form)
            _frmTracked = frm
            _controlsTracked = New ControlDirtyTrackerCollection(frm)
        End Sub


    End Class
End Namespace