Public Class log


    Private Sub log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init()
        tb_username.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tb_username.Text = "" Or tb_passwd.Text = "" Then
            MsgBox("用户名或密码为空，请重新输入！")
            tb_username.Focus()
        Else

            Dim password_en As String = MD5(tb_passwd.Text.ToString, 32)
            Dim data_login As New DataTable
            data_login = chaxun_user(tb_username.Text)
            If data_login.Rows.Count > 0 Then
                If MD5(tb_passwd.Text, 32) = data_login.Rows(0)(2) Then
                    Dim win As New count
                    win.Show()
                    Me.Hide()
                Else
                    MsgBox("密码错误，请重新输入！")
                    tb_username.Focus()
                    tb_username.Text = ""
                    tb_passwd.Text = ""
                End If

            Else
                MsgBox("用户名错误，请重新输入！")
                tb_username.Focus()
                tb_username.Text = ""
                tb_passwd.Text = ""
            End If
        End If
    End Sub

    Private Sub tb_passwd_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_passwd.KeyDown
        If e.Control And e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class