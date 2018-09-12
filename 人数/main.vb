Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports CapabilityCSharpDemo

Public Class main
    Public m_1UserID = -1
    Private m_bInitSDK As Boolean = False
    Private iLaseErr As UInteger = 0
    Private strErr As String
    Private m_dwAbilityType As UInteger = 0
    Private xmlInput As String
    Private data_device As DataTable

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated


    End Sub

    Private Function GetErroeDes(iErrCode As UInteger) As String
        Dim strDes As String = ""
        Select Case iErrCode
            Case 1000
                strDes = "设备不支持该能力节点的获取"
            Case 1001
                strDes = "输出内存不足"
            Case 1002
                strDes = "无法找到对应的本地xml"
            Case 1003
                strDes = "加载本地xml出错"
            Case 1004
                strDes = "设备能力数据格式错误"
            Case 1005
                strDes = "能力集类型错误"
            Case 1006
                strDes = "XML能力节点格式错误"
            Case 1007
                strDes = "输入的能力XML节点值错误"
            Case 1008
                strDes = "XML版本不匹配"

        End Select
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If m_1UserID < 0 Then
            Dim dvripaddress As String = textBoxIP.Text
            Dim dvrportnum As Int16 = Int16.Parse(textBoxPort.Text)
            Dim dvrusername As String = textBoxUserName.Text
            Dim dvrpassword As String = textBoxPassword.Text
            Dim m_strudeviceinfo As New CHCNetSDK.NET_DVR_DEVICEINFO_V30
            m_1UserID = CHCNetSDK.NET_DVR_Login_V30(dvripaddress, dvrportnum, dvrusername, dvrpassword, m_strudeviceinfo)

            If m_1UserID = -1 Then
                iLaseErr = CHCNetSDK.NET_DVR_GetLastError
                strErr = "摄像头登录失败，错误码：" + Str(iLaseErr)
                MessageBox.Show(strErr)
                Return
            Else
                comboBoxCapability.SelectedIndex = 0
                btnGet_Click(sender, e)

            End If
        Else
            If CHCNetSDK.NET_DVR_Logout(m_1UserID) = False Then
                iLaseErr = CHCNetSDK.NET_DVR_GetLastError
                strErr = "摄像头退出失败，错误码：" + Str(iLaseErr)
                MessageBox.Show(strErr)
            Else

                m_1UserID = -1
                comboBoxCapability.SelectedIndex = -1
                comboBoxCapability.Text = ""
                textBoxCapability.Text = ""
            End If
        End If
    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        Dim pinbuf As IntPtr
        Dim nsize As Int32
        If xmlInput Is Nothing Then
            pinbuf = IntPtr.Zero
            nsize = 0
        Else
            nsize = xmlInput.Length
            pinbuf = Marshal.AllocHGlobal(nsize)
            pinbuf = Marshal.StringToHGlobalAnsi(xmlInput)
        End If

        Dim xml_ability_out_len As Integer = 3 * 1024 * 1024
        Dim poutbuf As IntPtr = Marshal.AllocHGlobal(xml_ability_out_len)


        If Not CHCNetSDK.NET_DVR_GetDeviceAbility(m_1UserID, m_dwAbilityType, pinbuf, CUInt(nsize), poutbuf, CUInt(xml_ability_out_len)) Then
            iLaseErr = CHCNetSDK.NET_DVR_GetLastError
            strErr = " 获取设备能力集失败，错误码：" + Str(iLaseErr) & vbCrLf + GetErroeDes(iLaseErr)
            MessageBox.Show(strErr)
        Else
            Dim stroutbuf As String = Marshal.PtrToStringAnsi(poutbuf, xml_ability_out_len)
            stroutbuf = stroutbuf.Replace(">" & vbLf & "<", ">" & vbCrLf & "<")
            textBoxCapability.Text = stroutbuf
            insertdata("INSERT INTO device (ip,port,username,passwd) VALUES ('" + textBoxIP.Text + "','" + textBoxPort.Text + "','" + textBoxUserName.Text + "','" + textBoxPassword.Text + "')")
            data_device.Clear()
            data_device = chaxun_device()
            dg1.DataSource = data_device
        End If

        Marshal.FreeHGlobal(pinbuf)
        Marshal.FreeHGlobal(poutbuf)
    End Sub

    Private Sub comboBoxCapability_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxCapability.SelectedIndexChanged
        Select Case comboBoxCapability.SelectedIndex
            Case 0
                m_dwAbilityType = CHCNetSDK.DEVICE_ABILITY_INFO
                xmlInput = "<VcaChanAbility version='2.0'><channelNO>1</channelNO></VcaChanAbility>"

        End Select
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

    Private Sub dg1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg1.CellMouseClick
        If e.Button = MouseButtons.Right And e.ColumnIndex > -1 And e.RowIndex > -1 Then
            dg1.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True
            cs1.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim chepai As String
        chepai = Me.dg1.CurrentRow.Cells(0).Value
        delchepai(chepai)
        data_device.Clear()
        data_device = chaxun_device()
        dg1.DataSource = data_device
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles Me.Load

        m_bInitSDK = CHCNetSDK.NET_DVR_Init
        If m_bInitSDK = False Then
            MessageBox.Show("初始化失败！")
        End If
        data_device = chaxun_device()
        dg1.DataSource = data_device
    End Sub
End Class
