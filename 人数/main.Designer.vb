<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Me.textBoxCapability = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.textBoxPassword = New System.Windows.Forms.TextBox()
        Me.textBoxUserName = New System.Windows.Forms.TextBox()
        Me.textBoxPort = New System.Windows.Forms.TextBox()
        Me.textBoxIP = New System.Windows.Forms.TextBox()
        Me.comboBoxCapability = New System.Windows.Forms.ComboBox()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.cs1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cs1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textBoxCapability
        '
        Me.textBoxCapability.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.textBoxCapability.Location = New System.Drawing.Point(136, 800)
        Me.textBoxCapability.Margin = New System.Windows.Forms.Padding(6)
        Me.textBoxCapability.Multiline = True
        Me.textBoxCapability.Name = "textBoxCapability"
        Me.textBoxCapability.ReadOnly = True
        Me.textBoxCapability.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBoxCapability.Size = New System.Drawing.Size(416, 307)
        Me.textBoxCapability.TabIndex = 47
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(822, 23)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(148, 62)
        Me.btnLogin.TabIndex = 35
        Me.btnLogin.Text = "添加设备"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(32, 11)
        Me.label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(134, 20)
        Me.label1.TabIndex = 39
        Me.label1.Text = "Device IP"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(30, 93)
        Me.label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(124, 30)
        Me.label2.TabIndex = 38
        Me.label2.Text = "User Name"
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(438, 93)
        Me.label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(126, 32)
        Me.label3.TabIndex = 41
        Me.label3.Text = "Password"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(438, 11)
        Me.label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(158, 30)
        Me.label4.TabIndex = 40
        Me.label4.Text = "Device Port"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(32, 41)
        Me.label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(88, 25)
        Me.label5.TabIndex = 42
        Me.label5.Text = "设备IP"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(440, 41)
        Me.label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(112, 25)
        Me.label6.TabIndex = 43
        Me.label6.Text = "设备端口"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(32, 125)
        Me.label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(87, 25)
        Me.label7.TabIndex = 44
        Me.label7.Text = "用户名"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(440, 125)
        Me.label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(62, 25)
        Me.label8.TabIndex = 45
        Me.label8.Text = "密码"
        '
        'textBoxPassword
        '
        Me.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textBoxPassword.Location = New System.Drawing.Point(598, 101)
        Me.textBoxPassword.Margin = New System.Windows.Forms.Padding(6)
        Me.textBoxPassword.Name = "textBoxPassword"
        Me.textBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxPassword.Size = New System.Drawing.Size(196, 35)
        Me.textBoxPassword.TabIndex = 34
        Me.textBoxPassword.Text = "Admin@1234"
        '
        'textBoxUserName
        '
        Me.textBoxUserName.Location = New System.Drawing.Point(172, 101)
        Me.textBoxUserName.Margin = New System.Windows.Forms.Padding(6)
        Me.textBoxUserName.Name = "textBoxUserName"
        Me.textBoxUserName.Size = New System.Drawing.Size(224, 35)
        Me.textBoxUserName.TabIndex = 33
        Me.textBoxUserName.Text = "admin"
        '
        'textBoxPort
        '
        Me.textBoxPort.Location = New System.Drawing.Point(598, 23)
        Me.textBoxPort.Margin = New System.Windows.Forms.Padding(6)
        Me.textBoxPort.Name = "textBoxPort"
        Me.textBoxPort.Size = New System.Drawing.Size(196, 35)
        Me.textBoxPort.TabIndex = 32
        Me.textBoxPort.Text = "8000"
        '
        'textBoxIP
        '
        Me.textBoxIP.Location = New System.Drawing.Point(170, 23)
        Me.textBoxIP.Margin = New System.Windows.Forms.Padding(6)
        Me.textBoxIP.Name = "textBoxIP"
        Me.textBoxIP.Size = New System.Drawing.Size(224, 35)
        Me.textBoxIP.TabIndex = 31
        Me.textBoxIP.Text = "192.168.1.64"
        '
        'comboBoxCapability
        '
        Me.comboBoxCapability.FormattingEnabled = True
        Me.comboBoxCapability.Items.AddRange(New Object() {"DEVICE_SOFTHARDWARE_ABILITY", "DEVICE_ABILITY_INFO_EventAbility"})
        Me.comboBoxCapability.Location = New System.Drawing.Point(288, 756)
        Me.comboBoxCapability.Margin = New System.Windows.Forms.Padding(6)
        Me.comboBoxCapability.Name = "comboBoxCapability"
        Me.comboBoxCapability.Size = New System.Drawing.Size(682, 32)
        Me.comboBoxCapability.TabIndex = 36
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(516, 800)
        Me.btnGet.Margin = New System.Windows.Forms.Padding(6)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(120, 42)
        Me.btnGet.TabIndex = 37
        Me.btnGet.Text = "获取能力集"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Location = New System.Drawing.Point(20, -21)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.groupBox1.Size = New System.Drawing.Size(1038, 190)
        Me.groupBox1.TabIndex = 46
        Me.groupBox1.TabStop = False
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(20, 221)
        Me.dg1.MultiSelect = False
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.RowTemplate.Height = 37
        Me.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg1.Size = New System.Drawing.Size(1038, 455)
        Me.dg1.TabIndex = 48
        '
        'cs1
        '
        Me.cs1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.cs1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.cs1.Name = "cs1"
        Me.cs1.Size = New System.Drawing.Size(141, 40)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(140, 36)
        Me.ToolStripMenuItem1.Text = "删除"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 700)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.textBoxCapability)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.textBoxPassword)
        Me.Controls.Add(Me.textBoxUserName)
        Me.Controls.Add(Me.textBoxPort)
        Me.Controls.Add(Me.textBoxIP)
        Me.Controls.Add(Me.comboBoxCapability)
        Me.Controls.Add(Me.groupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "人员统计"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cs1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBoxCapability As TextBox
    Private WithEvents btnLogin As Button
    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents label6 As Label
    Private WithEvents label7 As Label
    Private WithEvents label8 As Label
    Private WithEvents textBoxPassword As TextBox
    Private WithEvents textBoxUserName As TextBox
    Private WithEvents textBoxPort As TextBox
    Private WithEvents textBoxIP As TextBox
    Private WithEvents comboBoxCapability As ComboBox
    Private WithEvents btnGet As Button
    Private WithEvents groupBox1 As GroupBox
    Friend WithEvents dg1 As DataGridView
    Friend WithEvents cs1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
