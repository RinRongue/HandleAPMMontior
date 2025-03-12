Public Class Form2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 窗口默认右上角
        Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.StartPosition = FormStartPosition.Manual
        Dim left As Integer = workingArea.Width - Me.Width
        Dim top As Integer = workingArea.Top
        Me.Left = left
        Me.Top = top

        '置顶窗口
        Me.TopMost = True

        '设置背景透明
        Me.TransparencyKey = Color.White ' 将白色作为透明色
        Me.BackColor = Color.White
    End Sub
    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        Me.FormBorderStyle = FormBorderStyle.None
        MyBase.OnLoad(e)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = "SUM: " & Form1.SUM & "    APM: " & Math.Round(Form1.APM, 2) & " | " & Form1.SUMM
    End Sub
End Class