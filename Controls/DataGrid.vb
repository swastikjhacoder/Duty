Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports System.Collections

Namespace DGV_Empty
    Public Class DataGrid
        Inherits ESAR_Controls.UIControls.DataGridView.eDataGridViewSummary
        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
            Using grfx As Graphics = e.Graphics
                'Getting the size Height and Width of text to be displayed on Gird. (e.g. No Records Found!) 
                Dim textSize As SizeF = grfx.MeasureString(Me.EmptyDataText, SystemFonts.DefaultFont)
                Dim x As Single = 0
                Dim y As Single = 0

                'Setting Y axis acording to selected option of Vertical Alignment 
                Select Case EmptyDataTextVerticalAlign
                    Case VerticalAlign.Top
                        y = 0
                        Exit Select
                    Case VerticalAlign.Middle
                        y = (Height - textSize.Height) / 2
                        Exit Select
                    Case VerticalAlign.Bottom
                        y = Height - textSize.Height
                        Exit Select
                End Select
                'Setting X axis acording to selected option of Horizontal Alignment 
                Select Case EmptyDataTextHorizontalAlign
                    Case HorizontalAlign.Left
                        x = 0
                        Exit Select
                    Case HorizontalAlign.Center
                        x = (Width - textSize.Width) / 2
                        Exit Select
                    Case HorizontalAlign.Right
                        x = Width - textSize.Width


                        Exit Select
                End Select

                'If user would like to set customized location.
                'I assumed if LocationX and LocationY dose not have zero (0) value then 
                'I set Location X and Y based on property value.
                If EmptyDataTextLocationX <> 0 AndAlso EmptyDataTextLocationY <> 0 Then
                    x = EmptyDataTextLocationX
                    y = EmptyDataTextLocationY
                End If

                'Finaly after setting up location X and Y then print Lable at specified lication 
                'write text acoording to selected value of VerticalAlign and HorizontalAlign on the DataGrid
                grfx.DrawString(Me.EmptyDataText, SystemFonts.DefaultFont, Brushes.Black, x, y)
            End Using
        End Sub

        <EditorBrowsable(EditorBrowsableState.Always)> _
        <Browsable(True)> _
        Public Property EmptyDataText() As String
            Get
                Return MyBase.Text
            End Get
            Set(value As String)
                MyBase.Text = value
                Refresh()
            End Set
        End Property

        Public Enum VerticalAlign
            Top
            Middle
            Bottom
        End Enum
        <Category("Vertical Align")> _
        <Description("Emplty data text vertical alignment")> _
        <DefaultValue(VerticalAlign.Middle)> _
        Private vAlign As VerticalAlign
        Public Property EmptyDataTextVerticalAlign() As VerticalAlign
            Get
                Return vAlign
            End Get
            Set(value As VerticalAlign)
                vAlign = value
            End Set
        End Property

        Public Enum HorizontalAlign
            Left
            Center
            Right
        End Enum
        <Category("Horizontal Align")> _
        <Description("Emplty data text horizontal alignment")> _
        <DefaultValue(HorizontalAlign.Center)> _
        Private hAlign As HorizontalAlign
        Public Property EmptyDataTextHorizontalAlign() As HorizontalAlign
            Get
                Return hAlign
            End Get
            Set(value As HorizontalAlign)
                hAlign = value
            End Set
        End Property

        <Category("Location X")> _
        <Description("User specific location of X coordinate")> _
        <DefaultValue(0)> _
        Private locationX As Single
        Public Property EmptyDataTextLocationX() As Single
            Get
                Return locationX
            End Get
            Set(value As Single)
                locationX = value
            End Set
        End Property

        <Category("Location Y")> _
        <Description("User specific location of Y coordinate")> _
        <DefaultValue(0)> _
        Private locationY As Single
        Public Property EmptyDataTextLocationY() As Single
            Get
                Return locationY
            End Get
            Set(value As Single)
                locationY = value
            End Set
        End Property
    End Class
End Namespace