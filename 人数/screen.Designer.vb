<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class screen
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.label6 = New System.Windows.Forms.Label()
        Me.tb_time = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.button4 = New System.Windows.Forms.Button()
        Me.tb_port = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.tb_ip = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(762, 136)
        Me.label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(37, 25)
        Me.label6.TabIndex = 9
        Me.label6.Text = "秒"
        '
        'tb_time
        '
        Me.tb_time.Location = New System.Drawing.Point(676, 130)
        Me.tb_time.Margin = New System.Windows.Forms.Padding(6)
        Me.tb_time.Name = "tb_time"
        Me.tb_time.Size = New System.Drawing.Size(70, 35)
        Me.tb_time.TabIndex = 8
        Me.tb_time.Text = "10"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(477, 139)
        Me.label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(187, 25)
        Me.label7.TabIndex = 7
        Me.label7.Text = "网络的超时时间"
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(784, 48)
        Me.button4.Margin = New System.Windows.Forms.Padding(6)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(150, 46)
        Me.button4.TabIndex = 6
        Me.button4.Text = "添加"
        Me.button4.UseVisualStyleBackColor = True
        '
        'tb_port
        '
        Me.tb_port.Location = New System.Drawing.Point(547, 55)
        Me.tb_port.Margin = New System.Windows.Forms.Padding(6)
        Me.tb_port.Name = "tb_port"
        Me.tb_port.Size = New System.Drawing.Size(130, 35)
        Me.tb_port.TabIndex = 3
        Me.tb_port.Text = "5005"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(463, 59)
        Me.label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(62, 25)
        Me.label9.TabIndex = 2
        Me.label9.Text = "端口"
        '
        'tb_ip
        '
        Me.tb_ip.Location = New System.Drawing.Point(176, 55)
        Me.tb_ip.Margin = New System.Windows.Forms.Padding(6)
        Me.tb_ip.Name = "tb_ip"
        Me.tb_ip.Size = New System.Drawing.Size(222, 35)
        Me.tb_ip.TabIndex = 1
        Me.tb_ip.Text = "192.168.2.69"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(58, 61)
        Me.label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(113, 25)
        Me.label10.TabIndex = 0
        Me.label10.Text = "控制卡IP"
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Location = New System.Drawing.Point(38, 204)
        Me.dg1.MultiSelect = False
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.RowTemplate.Height = 37
        Me.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg1.Size = New System.Drawing.Size(885, 548)
        Me.dg1.TabIndex = 49
        '
        'comboBox2
        '
        Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox2.FormattingEnabled = True
        Me.comboBox2.Items.AddRange(New Object() {"任意", "BX_5K1", "BX_5K2", "BX_5MK1", "BX_5MK2", "BX_5K1Q_YY", "BX_6K1", "BX_6K2", "BX_6K3", "BX_6K1_YY", "BX_6K2_YY", "BX_6K3_YY"})
        Me.comboBox2.Location = New System.Drawing.Point(188, 132)
        Me.comboBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(210, 32)
        Me.comboBox2.TabIndex = 50
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(39, 135)
        Me.label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(137, 25)
        Me.label8.TabIndex = 51
        Me.label8.Text = "控制器类型"
        '
        'screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 767)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.comboBox2)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.tb_time)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.tb_ip)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.tb_port)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "screen"
        Me.Text = "屏幕设置"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label6 As Label
    Private WithEvents tb_time As TextBox
    Private WithEvents label7 As Label
    Private WithEvents button4 As Button
    Private WithEvents tb_port As TextBox
    Private WithEvents label9 As Label
    Private WithEvents tb_ip As TextBox
    Private WithEvents label10 As Label
    Friend WithEvents dg1 As DataGridView
    Private WithEvents comboBox2 As ComboBox
    Private WithEvents label8 As Label
End Class
