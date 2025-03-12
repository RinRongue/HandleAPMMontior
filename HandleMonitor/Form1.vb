Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim ACount% = 0, BCount% = 0, XCount% = 0, YCount% = 0, StartCount% = 0, BackCount% = 0
    Dim DPAD_UPCount% = 0, DPAD_DOWNCount% = 0, DPAD_LEFTCount% = 0, DPAD_RIGHTCount% = 0
    Dim Left_SH% = 0, Right_SH% = 0, Left_Thumb% = 0, Right_Thumb% = 0, Left_TR% = 0, Right_TR% = 0
    Public SUM% = 0, SUMM% = 0, APM! = 0, APMPER! = 0, APMPER1! = 0, store% = 0, store1% = 0, Minute% = 1, Message$ = ""
    Dim List1 As New List(Of Integer)(60)

    Private Sub Summary()
        SUM = Left_SH + Right_SH + Left_Thumb + Right_Thumb + Left_TR + Right_TR + ACount + BCount + XCount + YCount + StartCount + BackCount + DPAD_UPCount + DPAD_DOWNCount + DPAD_LEFTCount + DPAD_RIGHTCount
    End Sub

    '秒表功能
    ' 创建 Stopwatch 对象
    Private stopwatch As New Stopwatch()
    Dim elapsedSeconds! = stopwatch.Elapsed.TotalSeconds

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' 获取计时器经过的时间
        Dim elapsed As TimeSpan = stopwatch.Elapsed
        ' 格式化时间显示
        Dim formattedTime As String = String.Format("{0:00}:{1:00}:{2:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds)
        ' 更新标签显示
        LabelWatch.Text = formattedTime
        '更新秒表时间
        elapsedSeconds! = stopwatch.Elapsed.TotalSeconds

        If Timer3.Enabled = False And stopwatch.IsRunning = True Then
            Timer3.Enabled = True
        End If
    End Sub



    ' 定义 XInput 相关常量
    Private Const XINPUT_GAMEPAD_A As Integer = &H1000
    Private Const XINPUT_GAMEPAD_B As Integer = &H2000
    Private Const XINPUT_GAMEPAD_X As Integer = &H4000
    Private Const XINPUT_GAMEPAD_Y As Integer = &H8000
    Private Const XINPUT_GAMEPAD_START As Integer = &H10
    Private Const XINPUT_GAMEPAD_BACK As Integer = &H20
    Private Const XINPUT_GAMEPAD_LEFT_THUMB As Integer = &H40
    Private Const XINPUT_GAMEPAD_RIGHT_THUMB As Integer = &H80
    Private Const XINPUT_GAMEPAD_LEFT_SHOULDER As Integer = &H100
    Private Const XINPUT_GAMEPAD_RIGHT_SHOULDER As Integer = &H200
    Private Const XINPUT_GAMEPAD_DPAD_UP As Integer = &H1
    Private Const XINPUT_GAMEPAD_DPAD_DOWN As Integer = &H2
    Private Const XINPUT_GAMEPAD_DPAD_LEFT As Integer = &H4
    Private Const XINPUT_GAMEPAD_DPAD_RIGHT As Integer = &H8
    Private Const XINPUT_GAMEPAD_LEFT_TRIGGER As Integer = &H100000
    Private Const XINPUT_GAMEPAD_RIGHT_TRIGGER As Integer = &H2000000
    Private Const XINPUT_GAMEPAD_GUIDE As Integer = &H400
    Private Const XINPUT_GAMEPAD_SHARE As Integer = &H800

    ' 导入XInput的相关API
    <DllImport("xinput1_4.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function XInputGetState(ByVal dwUserIndex As Integer, ByRef pState As XINPUT_STATE) As Integer
    End Function

    ' 结构体用于保存控制器状态
    <StructLayout(LayoutKind.Sequential)>
    Public Structure XINPUT_STATE
        Public dwPacketNumber As Integer
        Public Gamepad As XINPUT_GAMEPAD
    End Structure

    ' 结构体用于保存手柄的按钮和状态
    <StructLayout(LayoutKind.Sequential)>
    Public Structure XINPUT_GAMEPAD
        Public wButtons As Integer
        Public bLeftTrigger As Byte
        Public bRightTrigger As Byte
        Public sThumbLX As Short
        Public sThumbLY As Short
        Public sThumbRX As Short
        Public sThumbRY As Short
    End Structure

    ' 记录按钮的状态
    Private previousState As Integer = 0
    Private buttonCounts As New Dictionary(Of String, Integer) From {
        {"A", 0},
        {"B", 0},
        {"X", 0},
        {"Y", 0},
        {"Start1", 0},
        {"Back", 0},
        {"DPAD_UP", 0},
        {"DPAD_DOWN", 0},
        {"DPAD_LEFT", 0},
        {"DPAD_RIGHT", 0},
        {"LEFT_SHOULDER", 0},
        {"RIGHT_SHOULDER", 0},
        {"LEFT_THUMB", 0},
        {"RIGHT_THUMB", 0},
        {"LEFT_TRIGGER", 0},
        {"RIGHT_TRIGGER", 0}
    }

    ' 获取手柄的状态
    Private Sub GetControllerState()
        Dim state As New XINPUT_STATE()
        Dim result As Integer = XInputGetState(0, state) ' 0是第一个控制器

        If result = 0 Then
            ' 输出按钮状态的值，用于调试
            Console.WriteLine("Button States: " & Convert.ToString(state.Gamepad.wButtons, 2).PadLeft(16, "0"c))

            ' 检查按钮状态，只有在状态变化时才进行计数
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_A, "A")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_B, "B")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_X, "X")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_Y, "Y")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_START, "Start1")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_BACK, "Back")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_DPAD_UP, "DPAD_UP")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_DPAD_DOWN, "DPAD_DOWN")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_DPAD_LEFT, "DPAD_LEFT")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_DPAD_RIGHT, "DPAD_RIGHT")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_LEFT_SHOULDER, "LEFT_SHOULDER")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_RIGHT_SHOULDER, "RIGHT_SHOULDER")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_LEFT_THUMB, "LEFT_THUMB")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_RIGHT_THUMB, "RIGHT_THUMB")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_LEFT_TRIGGER, "LEFT_TRIGGER")
            CheckButtonState(state.Gamepad.wButtons, XINPUT_GAMEPAD_RIGHT_TRIGGER, "RIGHT_TRIGGER")
        Else
            Console.WriteLine("Controller not connected")
        End If
    End Sub

    ' 为每个按键维护一个单独的 previousState 变量
    Private previousStates As New Dictionary(Of String, Integer) From {
    {"A", 0},
    {"B", 0},
    {"X", 0},
    {"Y", 0},
    {"Start1", 0},
    {"Back", 0},
    {"DPAD_UP", 0},
    {"DPAD_DOWN", 0},
    {"DPAD_LEFT", 0},
    {"DPAD_RIGHT", 0},
    {"LEFT_SHOULDER", 0},
    {"RIGHT_SHOULDER", 0},
    {"LEFT_THUMB", 0},
    {"RIGHT_THUMB", 0},
    {"LEFT_TRIGGER", 0},
    {"RIGHT_TRIGGER", 0}
}

    ' 检查按钮是否按下或松开
    Private Sub CheckButtonState(currentState As Integer, button As Integer, buttonName As String)
        ' 检查按键是否变化
        If (currentState And button) <> 0 AndAlso (previousStates(buttonName) And button) = 0 Then
            ' 按键刚刚被按下
            buttonCounts(buttonName) += 1
            UpdateLabel(buttonName)
            stopwatch.Start() '感觉放这很笨蛋，但是能跑就行
            Label6.Visible = False
        ElseIf (currentState And button) = 0 AndAlso (previousStates(buttonName) And button) <> 0 Then
            ' 按键刚刚被释放
        End If

        ' 更新上一次的状态
        previousStates(buttonName) = currentState
    End Sub



    ' 更新UI标签
    Private Sub UpdateLabel(buttonName As String)
        If buttonName = "A" Then ACount += 1
        If buttonName = "B" Then BCount += 1
        If buttonName = "X" Then XCount += 1
        If buttonName = "Y" Then YCount += 1
        If buttonName = "Start1" Then StartCount += 1
        If buttonName = "Back" Then BackCount += 1
        If buttonName = "DPAD_UP" Then DPAD_UPCount += 1
        If buttonName = "DPAD_DOWN" Then DPAD_DOWNCount += 1
        If buttonName = "DPAD_LEFT" Then DPAD_LEFTCount += 1
        If buttonName = "DPAD_RIGHT" Then DPAD_RIGHTCount += 1
        If buttonName = "LEFT_SHOULDER" Then Left_SH += 1
        If buttonName = "RIGHT_SHOULDER" Then Right_SH += 1
        If buttonName = "LEFT_THUMB" Then Left_Thumb += 1
        If buttonName = "RIGHT_THUMB" Then Right_Thumb += 1
        If buttonName = "LEFT_TRIGGER" Then Left_TR += 1
        If buttonName = "RIGHT_TRIGGER" Then Right_TR += 1
    End Sub

    ' Timer1，检查手柄输入
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GetControllerState()
        LabelA.Text = ACount
        LabelB.Text = BCount
        LabelX.Text = XCount
        LabelY.Text = YCount
        LabelStart.Text = StartCount
        LabelBack.Text = BackCount
        LabelDPAD_UP.Text = DPAD_UPCount
        LabelDPAD_DOWN.Text = DPAD_DOWNCount
        LabelDPAD_LEFT.Text = DPAD_LEFTCount
        LabelDPAD_RIGHT.Text = DPAD_RIGHTCount
        LabelLeft_SH.Text = Left_SH
        LabelRight_SH.Text = Right_SH
        LabelLeft_Thumb.Text = Left_Thumb
        LabelRight_Thumb.Text = Right_Thumb
        LabelLeft_TR.Text = Left_TR
        LabelRight_TR.Text = Right_TR
        Summary()
        LabelSUM.Text = SUM
        APM = SUM / elapsedSeconds * 60
        LabelAPM.Text = Math.Round(APM, 2)
    End Sub



    ' 窗体加载时启动定时器
    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        Timer1.Start() ' 启动定时器，每ms检查手柄状态
        Timer3.Start()
        Timer4.Start()
        DataGridView1.ColumnCount = 2
        DataGridView1.Columns(0).Name = "Minute"
        DataGridView1.Columns(1).Name = "APM"
        For i As Integer = 0 To 59      ' Important: Initialize each element!
            List1.Add(0)               ' Or some other default value
        Next i
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        '更新最新APM
        LabelAPMPer.Text = SUM - store
        DataGridView1.Rows.Add(Minute, SUM - store)
        store = SUM
        Minute += 1

    End Sub

    '复制表格数据
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sb As New System.Text.StringBuilder()

        For Each row As DataGridViewRow In DataGridView1.Rows
            For i As Integer = 0 To row.Cells.Count - 1
                sb.Append(row.Cells(i).Value)
                If i < row.Cells.Count - 1 Then
                    sb.Append(vbTab) ' 使用 Tab 键作为分隔符
                End If
            Next
            sb.AppendLine() ' 添加换行符
        Next
        Clipboard.SetText(sb.ToString())
        MsgBox("APM Data Copy to Clipboard Successfully!" & vbCrLf & "You Can Paste to Excel",, "Successfully!")
    End Sub

    '
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button7.Click
        '创建迷你监视器
        If Form2.Visible = False Then
            Form2.Show()
            Button2.Text = "HideMiniMonitor"
        ElseIf Form2.Visible = True Then
            Form2.Hide()
            Button2.Text = "MiniMonitor(Stickie)"
        End If
        HScrollBar1.Value = Form2.Left
        HScrollBar2.Value = Form2.Top
        Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.StartPosition = FormStartPosition.Manual
        HScrollBar1.Maximum = workingArea.Width - Form2.Width
    End Sub

    '改变迷你监视器窗口位置

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
        Me.StartPosition = FormStartPosition.Manual
        ' 设置 ScrollBar 的最大值和最小值，使其能够覆盖整个屏幕
        HScrollBar1.Minimum = 0
        HScrollBar1.Maximum = workingArea.Width

        HScrollBar2.Minimum = 0
        HScrollBar2.Maximum = workingArea.Height

        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        ' 根据 ScrollBar 的值更新 Form2 的位置
        Form2.Left = HScrollBar1.Value
    End Sub

    Private Sub HScrollBar2_Scrol1(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        ' 根据 ScrollBar 的值更新 Form2 的位置
        Form2.Top = HScrollBar2.Value
    End Sub


    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    Form2.Top -= 40
    'End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    Form2.Top += 40
    'End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    Form2.Left -= 40
    'End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    Form2.Left += 40
    'End Sub

    '重启窗口
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim result As MsgBoxResult = MsgBox("Program will restart and clean all the data!", MsgBoxStyle.OkCancel Or MsgBoxStyle.Exclamation, "Warning!")

        If result = MsgBoxResult.Ok Then
            Application.Restart()
        End If

    End Sub

    Dim a% = 0
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        SUMM = 0
        APMPER1 = SUM - store1
        store1 = SUM

        If a = 59 Then
            a = 0
        Else
            a += 1
        End If

        List1(a) = APMPER1
        For Each item As Integer In List1
            SUMM += item
        Next

    End Sub


End Class
