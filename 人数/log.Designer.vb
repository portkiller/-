<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class log
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_passwd = New System.Windows.Forms.TextBox()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 13.94764!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 37)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "密  码"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 13.94764!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "用户名"
        '
        'tb_passwd
        '
        Me.tb_passwd.Font = New System.Drawing.Font("黑体", 15.07854!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tb_passwd.Location = New System.Drawing.Point(309, 178)
        Me.tb_passwd.Name = "tb_passwd"
        Me.tb_passwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_passwd.Size = New System.Drawing.Size(286, 53)
        Me.tb_passwd.TabIndex = 2
        '
        'tb_username
        '
        Me.tb_username.Font = New System.Drawing.Font("黑体", 15.07854!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.tb_username.Location = New System.Drawing.Point(309, 82)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(286, 53)
        Me.tb_username.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("宋体", 13.94764!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(488, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(158, 59)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "退出"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 13.94764!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(154, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 59)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "登录"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_passwd)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "log"
        Me.Text = "log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_passwd As TextBox
    Friend WithEvents tb_username As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
