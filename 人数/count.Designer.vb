<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class count
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_num = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.textBoxListenPort = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.textBoxListenIP = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.listViewAlarmInfo = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listViewDevice = New System.Windows.Forms.ListView()
        Me.ColumnNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnIP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("楷体", 36.18848!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(624, 97)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "当前场馆人数"
        '
        'lb_num
        '
        Me.lb_num.AutoSize = True
        Me.lb_num.Font = New System.Drawing.Font("楷体", 36.18848!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lb_num.Location = New System.Drawing.Point(751, 48)
        Me.lb_num.Name = "lb_num"
        Me.lb_num.Size = New System.Drawing.Size(287, 97)
        Me.lb_num.TabIndex = 1
        Me.lb_num.Text = "00000"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 669)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 56)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "摄像头设置"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(341, 669)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 56)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "屏幕设置"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(615, 669)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(195, 56)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "重置数字"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(893, 669)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(195, 56)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "退出"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'textBoxListenPort
        '
        Me.textBoxListenPort.Location = New System.Drawing.Point(550, 757)
        Me.textBoxListenPort.Margin = New System.Windows.Forms.Padding(6)
        Me.textBoxListenPort.Name = "textBoxListenPort"
        Me.textBoxListenPort.Size = New System.Drawing.Size(196, 35)
        Me.textBoxListenPort.TabIndex = 57
        Me.textBoxListenPort.Text = "7200"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(54, 763)
        Me.label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(151, 25)
        Me.label10.TabIndex = 54
        Me.label10.Text = "监听IP地址:"
        '
        'textBoxListenIP
        '
        Me.textBoxListenIP.Location = New System.Drawing.Point(202, 757)
        Me.textBoxListenIP.Margin = New System.Windows.Forms.Padding(6)
        Me.textBoxListenIP.Name = "textBoxListenIP"
        Me.textBoxListenIP.Size = New System.Drawing.Size(194, 35)
        Me.textBoxListenIP.TabIndex = 56
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(434, 763)
        Me.label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(125, 25)
        Me.label11.TabIndex = 55
        Me.label11.Text = "监听端口:"
        '
        'listViewAlarmInfo
        '
        Me.listViewAlarmInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.columnHeader3})
        Me.listViewAlarmInfo.FullRowSelect = True
        Me.listViewAlarmInfo.GridLines = True
        Me.listViewAlarmInfo.Location = New System.Drawing.Point(59, 167)
        Me.listViewAlarmInfo.Margin = New System.Windows.Forms.Padding(6)
        Me.listViewAlarmInfo.MultiSelect = False
        Me.listViewAlarmInfo.Name = "listViewAlarmInfo"
        Me.listViewAlarmInfo.Size = New System.Drawing.Size(989, 468)
        Me.listViewAlarmInfo.TabIndex = 58
        Me.listViewAlarmInfo.TabStop = False
        Me.listViewAlarmInfo.UseCompatibleStateImageBehavior = False
        Me.listViewAlarmInfo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "上报时间"
        Me.ColumnHeader1.Width = 140
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "上报设备"
        Me.ColumnHeader2.Width = 114
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "上报信息"
        Me.columnHeader3.Width = 246
        '
        'listViewDevice
        '
        Me.listViewDevice.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listViewDevice.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnNumber, Me.ColumnIP, Me.ColumnStatus})
        Me.listViewDevice.FullRowSelect = True
        Me.listViewDevice.GridLines = True
        Me.listViewDevice.HideSelection = False
        Me.listViewDevice.Location = New System.Drawing.Point(1111, 31)
        Me.listViewDevice.Margin = New System.Windows.Forms.Padding(6)
        Me.listViewDevice.Name = "listViewDevice"
        Me.listViewDevice.Size = New System.Drawing.Size(444, 716)
        Me.listViewDevice.TabIndex = 59
        Me.listViewDevice.TabStop = False
        Me.listViewDevice.UseCompatibleStateImageBehavior = False
        Me.listViewDevice.View = System.Windows.Forms.View.Details
        '
        'ColumnNumber
        '
        Me.ColumnNumber.Text = "UserID"
        Me.ColumnNumber.Width = 50
        '
        'ColumnIP
        '
        Me.ColumnIP.Text = "设备IP地址"
        Me.ColumnIP.Width = 90
        '
        'ColumnStatus
        '
        Me.ColumnStatus.Text = "状态"
        Me.ColumnStatus.Width = 160
        '
        'count
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1969, 832)
        Me.Controls.Add(Me.listViewDevice)
        Me.Controls.Add(Me.listViewAlarmInfo)
        Me.Controls.Add(Me.textBoxListenPort)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.textBoxListenIP)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lb_num)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "count"
        Me.Text = "人员统计"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lb_num As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Private WithEvents textBoxListenPort As TextBox
    Private WithEvents label10 As Label
    Private WithEvents textBoxListenIP As TextBox
    Private WithEvents label11 As Label
    Private WithEvents listViewAlarmInfo As ListView
    Private WithEvents ColumnHeader1 As ColumnHeader
    Private WithEvents ColumnHeader2 As ColumnHeader
    Private WithEvents columnHeader3 As ColumnHeader
    Private WithEvents listViewDevice As ListView
    Private WithEvents ColumnNumber As ColumnHeader
    Private WithEvents ColumnIP As ColumnHeader
    Private WithEvents ColumnStatus As ColumnHeader
End Class
