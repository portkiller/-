Imports ONNONLed5KSDKD
Public Class screen
    Private m_dwCurHand As UInteger
    Public type As Integer
    Public Function sum(ByVal type As Integer) As Integer
        Return type
    End Function
    Private data_screen As DataTable
    Private Sub screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'init()
        data_screen = chaxun_screen()
        dg1.DataSource = data_screen
        comboBox2.SelectedIndex = 3
        Led5kSDK.InitSdk(2, 2)
    End Sub
    Dim card_type_list As Byte() = New Byte(11) {}
    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Dim led_ip As Byte() = System.Text.Encoding.ASCII.GetBytes(tb_ip.Text)
        Dim led_port As UInteger = Convert.ToUInt32(tb_port.Text)

        card_type_list(0) = &HFE
        card_type_list(1) = &H51
        card_type_list(2) = &H58
        card_type_list(3) = &H54
        card_type_list(4) = &H53
        card_type_list(5) = &H5C
        card_type_list(6) = &H61
        card_type_list(7) = &H62
        card_type_list(8) = &H63
        card_type_list(9) = &H64
        card_type_list(10) = &H65
        card_type_list(11) = &H66
        Dim t As Integer = comboBox2.SelectedIndex
        type = t
        Dim hand As UInteger = ONNONLed5KSDKD.Led5kSDK.CreateClient(led_ip, led_port, CType(card_type_list(t), Led5kSDK.bx_5k_card_type), 1, 1, Nothing)
        m_dwCurHand = hand

        If hand = 0 Then
            MessageBox.Show("连接控制器失败")
            Return
        Else
            Try
                Dim nTime As UInteger = Convert.ToUInt32(tb_time.Text)
                ONNONLed5KSDKD.Led5kSDK.SetTimeout(m_dwCurHand, nTime)
                insertdata("INSERT INTO device (ip,port,kind) VALUES ('" + tb_ip.Text + "','" + tb_port.Text + "','" + card_type_list(t) + "')")
            Catch __unusedException1__ As Exception
                MessageBox.Show("请输入网络的超时时间")
            End Try
        End If
        Led5kSDK.Destroy(m_dwCurHand)
    End Sub

End Class