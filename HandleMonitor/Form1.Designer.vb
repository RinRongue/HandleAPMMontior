<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Timer1 = New Timer(components)
        LabelA = New Label()
        LabelB = New Label()
        LabelX = New Label()
        LabelY = New Label()
        PictureBox1 = New PictureBox()
        LabelBack = New Label()
        LabelStart = New Label()
        LabelDPAD_UP = New Label()
        Label1 = New Label()
        Label3 = New Label()
        LabelDPAD_LEFT = New Label()
        LabelDPAD_RIGHT = New Label()
        LabelDPAD_DOWN = New Label()
        LabelLeft_SH = New Label()
        LabelRight_SH = New Label()
        LabelLeft_Thumb = New Label()
        LabelRight_Thumb = New Label()
        LabelRight_TR = New Label()
        LabelLeft_TR = New Label()
        LabelSUM = New Label()
        LabelAPM = New Label()
        LabelWatch = New Label()
        Timer2 = New Timer(components)
        LabelAPMPer = New Label()
        Timer3 = New Timer(components)
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Timer4 = New Timer(components)
        HScrollBar1 = New HScrollBar()
        HScrollBar2 = New HScrollBar()
        Button7 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ToolStrip1 = New ToolStrip()
        ToolStripSplitButton1 = New ToolStripSplitButton()
        XInput14ToolStripMenuItem = New ToolStripMenuItem()
        XInput13ToolStripMenuItem = New ToolStripMenuItem()
        XInput12ToolStripMenuItem = New ToolStripMenuItem()
        XInputToolStripMenuItem = New ToolStripMenuItem()
        XInput910ToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1
        ' 
        ' LabelA
        ' 
        LabelA.BackColor = Color.Transparent
        LabelA.Location = New Point(717, 407)
        LabelA.Name = "LabelA"
        LabelA.Size = New Size(67, 24)
        LabelA.TabIndex = 1
        LabelA.Text = "Label1"
        LabelA.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelB
        ' 
        LabelB.BackColor = Color.Transparent
        LabelB.Location = New Point(822, 323)
        LabelB.Name = "LabelB"
        LabelB.Size = New Size(67, 24)
        LabelB.TabIndex = 1
        LabelB.Text = "Label1"
        LabelB.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelX
        ' 
        LabelX.BackColor = Color.Transparent
        LabelX.Location = New Point(608, 323)
        LabelX.Name = "LabelX"
        LabelX.Size = New Size(67, 24)
        LabelX.TabIndex = 1
        LabelX.Text = "Label1"
        LabelX.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LabelY
        ' 
        LabelY.BackColor = Color.Transparent
        LabelY.Location = New Point(717, 238)
        LabelY.Name = "LabelY"
        LabelY.Size = New Size(67, 24)
        LabelY.TabIndex = 1
        LabelY.Text = "Label1"
        LabelY.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.Handle
        PictureBox1.Location = New Point(267, 81)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(662, 553)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' LabelBack
        ' 
        LabelBack.BackColor = Color.Transparent
        LabelBack.Location = New Point(519, 385)
        LabelBack.Name = "LabelBack"
        LabelBack.Size = New Size(67, 24)
        LabelBack.TabIndex = 1
        LabelBack.Text = "Label1"
        LabelBack.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelStart
        ' 
        LabelStart.BackColor = Color.Transparent
        LabelStart.Location = New Point(608, 385)
        LabelStart.Name = "LabelStart"
        LabelStart.Size = New Size(67, 24)
        LabelStart.TabIndex = 1
        LabelStart.Text = "Label1"
        LabelStart.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelDPAD_UP
        ' 
        LabelDPAD_UP.BackColor = Color.Transparent
        LabelDPAD_UP.Location = New Point(341, 423)
        LabelDPAD_UP.Name = "LabelDPAD_UP"
        LabelDPAD_UP.Size = New Size(67, 24)
        LabelDPAD_UP.TabIndex = 1
        LabelDPAD_UP.Text = "Label1"
        LabelDPAD_UP.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 24)
        Label1.TabIndex = 3
        Label1.Text = "SUM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 24)
        Label3.TabIndex = 3
        Label3.Text = "APM"
        ' 
        ' LabelDPAD_LEFT
        ' 
        LabelDPAD_LEFT.BackColor = Color.Transparent
        LabelDPAD_LEFT.Location = New Point(242, 497)
        LabelDPAD_LEFT.Name = "LabelDPAD_LEFT"
        LabelDPAD_LEFT.Size = New Size(67, 24)
        LabelDPAD_LEFT.TabIndex = 1
        LabelDPAD_LEFT.Text = "Label1"
        LabelDPAD_LEFT.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LabelDPAD_RIGHT
        ' 
        LabelDPAD_RIGHT.BackColor = Color.Transparent
        LabelDPAD_RIGHT.Location = New Point(440, 497)
        LabelDPAD_RIGHT.Name = "LabelDPAD_RIGHT"
        LabelDPAD_RIGHT.Size = New Size(67, 24)
        LabelDPAD_RIGHT.TabIndex = 1
        LabelDPAD_RIGHT.Text = "Label1"
        LabelDPAD_RIGHT.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelDPAD_DOWN
        ' 
        LabelDPAD_DOWN.BackColor = Color.Transparent
        LabelDPAD_DOWN.Location = New Point(341, 575)
        LabelDPAD_DOWN.Name = "LabelDPAD_DOWN"
        LabelDPAD_DOWN.Size = New Size(67, 24)
        LabelDPAD_DOWN.TabIndex = 1
        LabelDPAD_DOWN.Text = "Label1"
        LabelDPAD_DOWN.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelLeft_SH
        ' 
        LabelLeft_SH.BackColor = Color.Transparent
        LabelLeft_SH.Location = New Point(316, 163)
        LabelLeft_SH.Name = "LabelLeft_SH"
        LabelLeft_SH.Size = New Size(67, 24)
        LabelLeft_SH.TabIndex = 1
        LabelLeft_SH.Text = "Label1"
        LabelLeft_SH.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LabelRight_SH
        ' 
        LabelRight_SH.BackColor = Color.Transparent
        LabelRight_SH.Location = New Point(822, 163)
        LabelRight_SH.Name = "LabelRight_SH"
        LabelRight_SH.Size = New Size(67, 24)
        LabelRight_SH.TabIndex = 1
        LabelRight_SH.Text = "Label1"
        LabelRight_SH.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelLeft_Thumb
        ' 
        LabelLeft_Thumb.BackColor = Color.Transparent
        LabelLeft_Thumb.Location = New Point(411, 292)
        LabelLeft_Thumb.Name = "LabelLeft_Thumb"
        LabelLeft_Thumb.Size = New Size(67, 24)
        LabelLeft_Thumb.TabIndex = 1
        LabelLeft_Thumb.Text = "Label1"
        LabelLeft_Thumb.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelRight_Thumb
        ' 
        LabelRight_Thumb.BackColor = Color.Transparent
        LabelRight_Thumb.Location = New Point(790, 470)
        LabelRight_Thumb.Name = "LabelRight_Thumb"
        LabelRight_Thumb.Size = New Size(67, 24)
        LabelRight_Thumb.TabIndex = 1
        LabelRight_Thumb.Text = "Label1"
        LabelRight_Thumb.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelRight_TR
        ' 
        LabelRight_TR.BackColor = Color.Transparent
        LabelRight_TR.Location = New Point(822, 100)
        LabelRight_TR.Name = "LabelRight_TR"
        LabelRight_TR.Size = New Size(67, 24)
        LabelRight_TR.TabIndex = 1
        LabelRight_TR.Text = "Label1"
        LabelRight_TR.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LabelLeft_TR
        ' 
        LabelLeft_TR.BackColor = Color.Transparent
        LabelLeft_TR.Location = New Point(316, 100)
        LabelLeft_TR.Name = "LabelLeft_TR"
        LabelLeft_TR.Size = New Size(67, 24)
        LabelLeft_TR.TabIndex = 1
        LabelLeft_TR.Text = "Label1"
        LabelLeft_TR.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LabelSUM
        ' 
        LabelSUM.AutoSize = True
        LabelSUM.Location = New Point(70, 92)
        LabelSUM.Name = "LabelSUM"
        LabelSUM.Size = New Size(51, 24)
        LabelSUM.TabIndex = 3
        LabelSUM.Text = "SUM"
        ' 
        ' LabelAPM
        ' 
        LabelAPM.AutoSize = True
        LabelAPM.Location = New Point(70, 135)
        LabelAPM.Name = "LabelAPM"
        LabelAPM.Size = New Size(51, 24)
        LabelAPM.TabIndex = 3
        LabelAPM.Text = "SUM"
        ' 
        ' LabelWatch
        ' 
        LabelWatch.AutoSize = True
        LabelWatch.Location = New Point(12, 53)
        LabelWatch.Name = "LabelWatch"
        LabelWatch.Size = New Size(84, 24)
        LabelWatch.TabIndex = 3
        LabelWatch.Text = "00:00:00"
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 10
        ' 
        ' LabelAPMPer
        ' 
        LabelAPMPer.AutoSize = True
        LabelAPMPer.Location = New Point(141, 179)
        LabelAPMPer.Name = "LabelAPMPer"
        LabelAPMPer.Size = New Size(38, 24)
        LabelAPMPer.TabIndex = 4
        LabelAPMPer.Text = "NA"
        ' 
        ' Timer3
        ' 
        Timer3.Interval = 60000
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(970, 56)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(370, 620)
        DataGridView1.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 24)
        Label2.TabIndex = 3
        Label2.Text = "APM(NOW)"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 238)
        Button1.Name = "Button1"
        Button1.Size = New Size(210, 52)
        Button1.TabIndex = 7
        Button1.Text = "CopyData"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 323)
        Button2.Name = "Button2"
        Button2.Size = New Size(210, 52)
        Button2.TabIndex = 7
        Button2.Text = "MiniMonitor(Stickie)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Microsoft YaHei UI", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Button3.ForeColor = SystemColors.ControlText
        Button3.Location = New Point(85, 389)
        Button3.Name = "Button3"
        Button3.Size = New Size(60, 60)
        Button3.TabIndex = 8
        Button3.Text = "▵"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Microsoft YaHei UI", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Button4.ForeColor = SystemColors.ControlText
        Button4.Location = New Point(85, 479)
        Button4.Name = "Button4"
        Button4.Size = New Size(60, 60)
        Button4.TabIndex = 8
        Button4.Text = "▿"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Microsoft YaHei UI", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Button5.ForeColor = SystemColors.ControlText
        Button5.Location = New Point(11, 436)
        Button5.Name = "Button5"
        Button5.Size = New Size(60, 60)
        Button5.TabIndex = 8
        Button5.Text = "◃"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Microsoft YaHei UI", 20.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Button6.ForeColor = SystemColors.ControlText
        Button6.Location = New Point(162, 436)
        Button6.Name = "Button6"
        Button6.Size = New Size(60, 60)
        Button6.TabIndex = 8
        Button6.Text = "▹"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Timer4
        ' 
        Timer4.Interval = 1000
        ' 
        ' HScrollBar1
        ' 
        HScrollBar1.LargeChange = 40
        HScrollBar1.Location = New Point(9, 410)
        HScrollBar1.Name = "HScrollBar1"
        HScrollBar1.Size = New Size(239, 39)
        HScrollBar1.TabIndex = 9
        ' 
        ' HScrollBar2
        ' 
        HScrollBar2.LargeChange = 40
        HScrollBar2.Location = New Point(9, 479)
        HScrollBar2.Name = "HScrollBar2"
        HScrollBar2.Size = New Size(239, 39)
        HScrollBar2.TabIndex = 9
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(12, 575)
        Button7.Name = "Button7"
        Button7.Size = New Size(210, 52)
        Button7.TabIndex = 7
        Button7.Text = "ResetData"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 378)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 24)
        Label4.TabIndex = 3
        Label4.Text = "X Axis"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 455)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 24)
        Label5.TabIndex = 3
        Label5.Text = "Y Axis"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft YaHei UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(242, 645)
        Label6.Name = "Label6"
        Label6.Size = New Size(710, 31)
        Label6.TabIndex = 10
        Label6.Text = "Count starts when you use game controllers- by 舒羽 for free"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripSplitButton1})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1352, 33)
        ToolStrip1.TabIndex = 11
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripSplitButton1
        ' 
        ToolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripSplitButton1.DropDownItems.AddRange(New ToolStripItem() {XInput14ToolStripMenuItem, XInput13ToolStripMenuItem, XInput12ToolStripMenuItem, XInputToolStripMenuItem, XInput910ToolStripMenuItem})
        ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), Image)
        ToolStripSplitButton1.ImageTransparentColor = Color.Magenta
        ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        ToolStripSplitButton1.Size = New Size(196, 28)
        ToolStripSplitButton1.Text = "CompatibleVersion"
        ' 
        ' XInput14ToolStripMenuItem
        ' 
        XInput14ToolStripMenuItem.Name = "XInput14ToolStripMenuItem"
        XInput14ToolStripMenuItem.Size = New Size(209, 34)
        XInput14ToolStripMenuItem.Text = "XInput1.4"
        ' 
        ' XInput13ToolStripMenuItem
        ' 
        XInput13ToolStripMenuItem.Name = "XInput13ToolStripMenuItem"
        XInput13ToolStripMenuItem.Size = New Size(209, 34)
        XInput13ToolStripMenuItem.Text = "XInput1.3"
        ' 
        ' XInput12ToolStripMenuItem
        ' 
        XInput12ToolStripMenuItem.Name = "XInput12ToolStripMenuItem"
        XInput12ToolStripMenuItem.Size = New Size(209, 34)
        XInput12ToolStripMenuItem.Text = "XInput1.2"
        ' 
        ' XInputToolStripMenuItem
        ' 
        XInputToolStripMenuItem.Name = "XInputToolStripMenuItem"
        XInputToolStripMenuItem.Size = New Size(209, 34)
        XInputToolStripMenuItem.Text = "XInput1.1"
        ' 
        ' XInput910ToolStripMenuItem
        ' 
        XInput910ToolStripMenuItem.Name = "XInput910ToolStripMenuItem"
        XInput910ToolStripMenuItem.Size = New Size(209, 34)
        XInput910ToolStripMenuItem.Text = "XInput9.1.0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 24.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1352, 744)
        Controls.Add(ToolStrip1)
        Controls.Add(Label6)
        Controls.Add(LabelDPAD_LEFT)
        Controls.Add(HScrollBar2)
        Controls.Add(HScrollBar1)
        Controls.Add(Button6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button7)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(LabelAPMPer)
        Controls.Add(Label3)
        Controls.Add(LabelWatch)
        Controls.Add(LabelAPM)
        Controls.Add(LabelSUM)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(LabelY)
        Controls.Add(LabelX)
        Controls.Add(LabelB)
        Controls.Add(LabelDPAD_DOWN)
        Controls.Add(LabelDPAD_RIGHT)
        Controls.Add(LabelDPAD_UP)
        Controls.Add(LabelRight_Thumb)
        Controls.Add(LabelLeft_TR)
        Controls.Add(LabelRight_TR)
        Controls.Add(LabelRight_SH)
        Controls.Add(LabelStart)
        Controls.Add(LabelLeft_Thumb)
        Controls.Add(LabelLeft_SH)
        Controls.Add(LabelBack)
        Controls.Add(LabelA)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Button5)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "HandleMonitor"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelA As Label
    Friend WithEvents LabelB As Label
    Friend WithEvents LabelX As Label
    Friend WithEvents LabelY As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelBack As Label
    Friend WithEvents LabelStart As Label
    Friend WithEvents LabelDPAD_UP As Label
    Friend WithEvents Label3 As Label
    Private WithEvents Label1 As Label
    Friend WithEvents LabelDPAD_LEFT As Label
    Friend WithEvents LabelDPAD_RIGHT As Label
    Friend WithEvents LabelDPAD_DOWN As Label
    Friend WithEvents LabelLeft_SH As Label
    Friend WithEvents LabelRight_SH As Label
    Friend WithEvents LabelLeft_Thumb As Label
    Friend WithEvents LabelRight_Thumb As Label
    Friend WithEvents LabelRight_TR As Label
    Friend WithEvents LabelLeft_TR As Label
    Private WithEvents LabelSUM As Label
    Private WithEvents LabelAPM As Label
    Private WithEvents LabelWatch As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LabelAPMPer As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Timer4 As Timer
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents Button7 As Button
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents XInput14ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XInput13ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XInput12ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XInputToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XInput910ToolStripMenuItem As ToolStripMenuItem

End Class
