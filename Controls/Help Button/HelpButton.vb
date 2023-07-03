Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace UIControls.Button
    ''' <summary>
    ''' A help button linked to the application help file (*.chm).
    ''' </summary>
    Partial Public Class HelpButton
        Inherits UserControl
        ''' <summary>
        ''' Path for the help file (*.chm).
        ''' Every help buttons will refer to this file.
        ''' </summary>
        Public Shared Property HelpFile() As String
            Get
                Return helpProvider.HelpNamespace
            End Get
            Set(value As String)
                helpProvider.HelpNamespace = value
            End Set
        End Property
        Shared helpProvider As HelpProvider

        ''' <summary>
        ''' static constructor used to instanciate the help provider.
        ''' </summary>
        Shared Sub New()
            helpProvider = New HelpProvider()
            helpProvider.HelpNamespace = Application.StartupPath + "\help.chm"
        End Sub

        ''' <summary>
        ''' How the help file should be displayed
        ''' and how the Value property should be interpreted.
        ''' </summary>
        <Description("How the help file should be displayed " & vbCr & vbLf & "and how the Value property should be interpreted.")> _
        <DefaultValue(GetType(HelpNavigator), "TopicId")> _
        Public Property Style() As HelpNavigator
            Get
                Return m_Style
            End Get
            Set(value As HelpNavigator)
                m_Style = value
            End Set
        End Property
        Private m_Style As HelpNavigator
        ''' <summary>
        ''' The topic number, file name, or keyword
        ''' depending on the Style value.
        ''' If Style equals TopicId and this value is zero,
        ''' then the chm file is opened without specifying any topic.
        ''' If Style equals TableOfContents, Find, or Index,
        ''' this value is ignored.
        ''' </summary>
        <Description("The topic number, file name, or keyword " & vbCr & vbLf & "depending on the Style value. " & vbCr & vbLf & "If Style equals TopicId and this value is zero, then the chm file is opened without specifying any topic. " & vbCr & vbLf & "If Style equals TableOfContents, Find, or Index, this value is ignored.")> _
        <DefaultValue("0")> _
        Public Property Value() As String
            Get
                Return m_Value
            End Get
            Set(value As String)
                m_Value = value
            End Set
        End Property
        Private m_Value As String

        ''' <summary>
        ''' true to display the 32x32 icon, false to display the 16x16 one.
        ''' </summary>
        <Description("true to display the 32x32 icon, " & vbCr & vbLf & "false to display the 16x16 one.")> _
        Public Property BigSize() As Boolean
            Get
                Return m_bigSize
            End Get
            Set(value As Boolean)
                m_bigSize = value
                If m_bigSize Then
                    pictureBox.Image = Global.Duty.My.Resources.help32
                Else
                    pictureBox.Image = Global.Duty.My.Resources.help16
                End If
                Size = PictureBox.Image.Size
            End Set
        End Property
        Private m_bigSize As Boolean

        ''' <summary>
        ''' Constructor.
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            BigSize = True
            Style = HelpNavigator.TopicId
            Value = "0"
        End Sub

        Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
            ' prevent the control from resizing
            MyBase.SetBoundsCore(x, y, PictureBox.Image.Width, PictureBox.Image.Height, specified)
        End Sub

        Private Sub pictureBox_Click(sender As Object, e As EventArgs)
            If Style = HelpNavigator.TopicId AndAlso Value = "0" Then
                System.Windows.Forms.Help.ShowHelp(Me, helpProvider.HelpNamespace)
            ElseIf Style = HelpNavigator.TableOfContents OrElse Style = HelpNavigator.Find OrElse Style = HelpNavigator.Index Then
                'open the help file and display the requested topic id
                System.Windows.Forms.Help.ShowHelp(Me, helpProvider.HelpNamespace, Style, String.Empty)
            Else
                'open the help file and display the requested topic id
                System.Windows.Forms.Help.ShowHelp(Me, helpProvider.HelpNamespace, Style, Value)
            End If
        End Sub
    End Class
End Namespace