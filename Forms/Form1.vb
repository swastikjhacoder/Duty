Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ProgressBar1.PositionMax = 100
        'ProgressBar1.PositionMin = 0
        'For i = 0 To 100000
        '    ProgressBar1.Position = i / 1000
        'Next
        'Dim l As New loadCompany
        'l.Show()
        ' Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim c1 As Integer = ProgressBar1.Position
        'ProgressBar1.Position = c1
        If c1 < 100 Then
            c1 += 1
            ProgressBar1.Position = c1
            ProgressBar1.Text = c1.ToString() + "%"
        Else
            Me.Timer1.Enabled = False
        End If
    End Sub
End Class