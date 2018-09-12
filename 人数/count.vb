Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.IO
Imports AlarmCSharpDemo
Imports ONNONLed5KSDKD

Public Class count
    Private m_lUserID As Int32 = -1
    Private m_lAlarmHandle As Int32() = New Int32(199) {}
    Private iListenHandle As Int32 = -1
    Private iDeviceNumber As Integer = 0
    Private iLastErr As UInteger = 0
    Private strErr As String
    Private m_falarmData As CHCNetSDK.MSGCallBack = Nothing
    Public Delegate Sub UpdateListBoxCallback(ByVal strAlarmTime As String, ByVal strDevIP As String, ByVal strAlarmMsg As String, ByVal innum As String, ByVal outnum As String)
    Private m_struTraversePlane As CHCNetSDK.NET_VCA_TRAVERSE_PLANE = New CHCNetSDK.NET_VCA_TRAVERSE_PLANE()
    Private m_struVcaArea As CHCNetSDK.NET_VCA_AREA = New CHCNetSDK.NET_VCA_AREA()
    Private m_struIntrusion As CHCNetSDK.NET_VCA_INTRUSION = New CHCNetSDK.NET_VCA_INTRUSION()
    Private m_struStatFrame As CHCNetSDK.UNION_STATFRAME = New CHCNetSDK.UNION_STATFRAME()
    Private m_struStatTime As CHCNetSDK.UNION_STATTIME = New CHCNetSDK.UNION_STATTIME()
    Private subnum As Integer = 0
    Dim win As New main
    Dim win_screen As New screen
    Dim data_device As New DataTable
    Dim data_screen As New DataTable
    Private m_dwCurHand As New List(Of UInteger)
    Private bx_5k As Led5kSDK.bx_5k_area_header
    Private AreaText As Byte()
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        main.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim str As Integer = InputBox("请输入开始的数字", Title:="重置数字")
            lb_num.Text = String.Format("{0:D5}", str)
            subnum = str
        Catch
        End Try
    End Sub

    Private Sub count_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m_bInitSDK As Boolean = CHCNetSDK.NET_DVR_Init()

        If m_bInitSDK = False Then
            MessageBox.Show("初始化失败！")
            Return
        Else
            Dim strIP As Byte() = New Byte(255) {}
            Dim dwValidNum As UInteger = 0
            Dim bEnableBind As Boolean = False

            If CHCNetSDK.NET_DVR_GetLocalIP(strIP, dwValidNum, bEnableBind) Then

                If dwValidNum > 0 Then
                    textBoxListenIP.Text = System.Text.Encoding.UTF8.GetString(strIP, 0, 16)
                End If
            End If

            For i As Integer = 0 To 200 - 1
                m_lAlarmHandle(i) = -1
            Next

            m_falarmData = New CHCNetSDK.MSGCallBack(AddressOf MsgCallback)
            CHCNetSDK.NET_DVR_SetDVRMessageCallBack_V30(m_falarmData, IntPtr.Zero)
        End If
        Login(sender, e)
    End Sub



    Public Sub MsgCallback(ByVal lCommand As Integer, ByRef pAlarmer As CHCNetSDK.NET_DVR_ALARMER, ByVal pAlarmInfo As IntPtr, ByVal dwBufLen As UInteger, ByVal pUser As IntPtr)
        Select Case lCommand
            Case CHCNetSDK.COMM_ALARM_PDC
                ProcessCommAlarm_PDC(pAlarmer, pAlarmInfo, dwBufLen, pUser)
            Case Else
        End Select
    End Sub

    Private Sub ProcessCommAlarm_PDC(ByRef pAlarmer As CHCNetSDK.NET_DVR_ALARMER, ByVal pAlarmInfo As IntPtr, ByVal dwBufLen As UInteger, ByVal pUser As IntPtr)
        Dim struPDCInfo As CHCNetSDK.NET_DVR_PDC_ALRAM_INFO = New CHCNetSDK.NET_DVR_PDC_ALRAM_INFO()
        Dim dwSize As UInteger = CUInt(Marshal.SizeOf(struPDCInfo))
        struPDCInfo = CType(Marshal.PtrToStructure(pAlarmInfo, GetType(CHCNetSDK.NET_DVR_PDC_ALRAM_INFO)), CHCNetSDK.NET_DVR_PDC_ALRAM_INFO)
        Dim stringAlarm As String = "客流量统计，进入人数：" & struPDCInfo.dwEnterNum.ToString & "，离开人数：" + struPDCInfo.dwLeaveNum.ToString
        ''Dim dwUnionSize As UInteger = CUInt(Marshal.SizeOf(struPDCInfo.uStatModeParam))
        Dim dwUnionSize As UInteger = CUInt(Marshal.SizeOf(struPDCInfo.uStatModeParam))
        Dim ptrPDCUnion As IntPtr = Marshal.AllocHGlobal(CType(dwUnionSize, Int32))
        Marshal.StructureToPtr(struPDCInfo.uStatModeParam, ptrPDCUnion, False)

        If struPDCInfo.byMode = 0 Then
            m_struStatFrame = CType(Marshal.PtrToStructure(ptrPDCUnion, GetType(CHCNetSDK.UNION_STATFRAME)), CHCNetSDK.UNION_STATFRAME)
            stringAlarm = stringAlarm & "，单帧统计，相对时标：" & m_struStatFrame.dwRelativeTime & "，绝对时标：" + m_struStatFrame.dwAbsTime
        End If

        If struPDCInfo.byMode = 1 Then
            m_struStatTime = CType(Marshal.PtrToStructure(ptrPDCUnion, GetType(CHCNetSDK.UNION_STATTIME)), CHCNetSDK.UNION_STATTIME)
            Dim strStartTime As String = String.Format("{0:D4}", m_struStatTime.tmStart.dwYear) & String.Format("{0:D2}", m_struStatTime.tmStart.dwMonth) & String.Format("{0:D2}", m_struStatTime.tmStart.dwDay) & " " & String.Format("{0:D2}", m_struStatTime.tmStart.dwHour) & ":" & String.Format("{0:D2}", m_struStatTime.tmStart.dwMinute) & ":" & String.Format("{0:D2}", m_struStatTime.tmStart.dwSecond)
            Dim strEndTime As String = String.Format("{0:D4}", m_struStatTime.tmEnd.dwYear) & String.Format("{0:D2}", m_struStatTime.tmEnd.dwMonth) & String.Format("{0:D2}", m_struStatTime.tmEnd.dwDay) & " " & String.Format("{0:D2}", m_struStatTime.tmEnd.dwHour) & ":" & String.Format("{0:D2}", m_struStatTime.tmEnd.dwMinute) & ":" & String.Format("{0:D2}", m_struStatTime.tmEnd.dwSecond)
            stringAlarm = stringAlarm & "，最小时间段统计，开始时间：" & strStartTime & "，结束时间：" & strEndTime
        End If

        Marshal.FreeHGlobal(ptrPDCUnion)
        Dim strIP As String = pAlarmer.sDeviceIP

        If InvokeRequired Then
            Dim paras As Object() = New Object(4) {}
            paras(0) = DateTime.Now.ToString()
            paras(1) = strIP
            paras(2) = stringAlarm
            paras(3) = struPDCInfo.dwEnterNum.ToString
            paras(4) = struPDCInfo.dwLeaveNum.ToString

            listViewAlarmInfo.BeginInvoke(New UpdateListBoxCallback(AddressOf UpdateClientList), paras)

        Else
            UpdateClientList(DateTime.Now.ToString(), strIP, stringAlarm, struPDCInfo.dwEnterNum, struPDCInfo.dwLeaveNum)

        End If
    End Sub


    Public Sub UpdateClientList(ByVal strAlarmTime As String, ByVal strDevIP As String, ByVal strAlarmMsg As String, ByVal innum As String, ByVal outnum As String)
        listViewAlarmInfo.Items.Insert(0, New ListViewItem(New String() {strAlarmTime, strDevIP, strAlarmMsg}))
        Try
            If listViewAlarmInfo.Items.Count > 16 Then
                For i = 0 To data_device.Rows.Count - 1
                    listViewAlarmInfo.Items.RemoveAt(listViewAlarmInfo.Items.Count - 1 - i)
                Next
            End If
        Catch e As Exception
            MessageBox.Show(e.ToString)
        End Try
        subnum = subnum + innum - outnum
        If subnum < 0 Then
            subnum = 0
        End If
        Dim number As String = String.Format("{0:D5}", subnum)
        lb_num.Text = number
        upclient(number)
    End Sub

    Private Sub Login(ByVal sender As Object, ByVal e As EventArgs)

        Dim DVRIPAddress As String
        Dim DVRPortNumber As Int16
        Dim DVRUserName As String
        Dim DVRPassword As String
        Dim DeviceInfo As CHCNetSDK.NET_DVR_DEVICEINFO_V30

        Dim led_ip As Byte()
        Dim led_port As UInteger
        Dim card_type As Byte
        Dim hand As UInteger

        data_device = chaxun_device()
        data_screen = chaxun_screen()

        For i = 0 To data_device.Rows.Count - 1
            DVRIPAddress = data_device.Rows(i)(1)
            DVRPortNumber = data_device.Rows(i)(2)
            DVRUserName = data_device.Rows(i)(3)
            DVRPassword = data_device.Rows(i)(4)
            DeviceInfo = New CHCNetSDK.NET_DVR_DEVICEINFO_V30()
            m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, DeviceInfo)
            If m_lUserID < 0 Then
                iLastErr = CHCNetSDK.NET_DVR_GetLastError()
                strErr = "设备登录失败，错误代码：" & iLastErr
                MessageBox.Show(strErr)
                Return
            Else
                iDeviceNumber += 1
                Dim str1 As String = "" & m_lUserID
                listViewDevice.Items.Insert(0, New ListViewItem(New String() {str1, DVRIPAddress, "未布防"}))
            End If
        Next

        For i = 0 To data_screen.Rows.Count - 1
            led_ip = System.Text.Encoding.ASCII.GetBytes(data_screen.Rows(i)(1))
            led_port = Convert.ToUInt32(data_screen.Rows(i)(2))
            card_type = CType(data_screen.Rows(i)(3), Byte)
            hand = Led5kSDK.CreateClient(led_ip, led_port, CType(card_type, Led5kSDK.bx_5k_card_type), 1, 1, Nothing)
            If hand <> 0 Then
                m_dwCurHand.Add(hand)
            End If
        Next

        SetAlarm(sender, e)
        StartListen(sender, e)
    End Sub
    Private Sub upclient(ByVal num As String)
        AreaText = System.Text.Encoding.Default.GetBytes("场内人数: " + num)
        bx_5k.DynamicAreaLoc = Convert.ToByte(0)
        bx_5k.DataLen = AreaText.Length
        bx_5k.AreaType = &H6
        bx_5k.AreaX = 0 / 8
        bx_5k.AreaY = 16
        bx_5k.AreaWidth = 16 / 8
        bx_5k.AreaHeight = 16
        bx_5k.Lines_sizes = Convert.ToByte("0")
        bx_5k.RunMode = 0
        bx_5k.Timeout = Convert.ToInt16(2)
        bx_5k.Reserved1 = 0
        bx_5k.Reserved2 = 0
        bx_5k.Reserved3 = 0
        bx_5k.SingleLine = &H1
        bx_5k.NewLine = &H1
        bx_5k.DisplayMode = &H1
        bx_5k.ExitMode = &H0
        bx_5k.Speed = Convert.ToByte(0)
        bx_5k.StayTime = Convert.ToByte(10)

        For i = 0 To m_dwCurHand.Count - 1
            Try
                Dim x As Integer = ONNONLed5KSDKD.Led5kSDK.SCREEN_SendDynamicArea(m_dwCurHand(i), bx_5k, CUShort(bx_5k.DataLen), AreaText)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
    End Sub
    Private Sub SetAlarm(ByVal sender As Object, ByVal e As EventArgs)
        Dim struAlarmParam As CHCNetSDK.NET_DVR_SETUPALARM_PARAM = New CHCNetSDK.NET_DVR_SETUPALARM_PARAM()
        struAlarmParam.dwSize = CUInt(Marshal.SizeOf(struAlarmParam))
        struAlarmParam.byLevel = 1
        struAlarmParam.byAlarmInfoType = 1

        For i As Integer = 0 To iDeviceNumber - 1
            m_lUserID = Int32.Parse(listViewDevice.Items(i).SubItems(0).Text)
            m_lAlarmHandle(m_lUserID) = CHCNetSDK.NET_DVR_SetupAlarmChan_V41(m_lUserID, struAlarmParam)

            If m_lAlarmHandle(m_lUserID) < 0 Then
                iLastErr = CHCNetSDK.NET_DVR_GetLastError()
                strErr = "布防失败，错误号：" & iLastErr
                listViewDevice.Items(i).SubItems(2).Text = strErr
            Else
                listViewDevice.Items(i).SubItems(2).Text = "布防成功"
            End If
        Next
    End Sub

    Private Sub StartListen(ByVal sender As Object, ByVal e As EventArgs)
        Dim sLocalIP As String = textBoxListenIP.Text
        Dim wLocalPort As UShort = UShort.Parse(textBoxListenPort.Text)
        iListenHandle = CHCNetSDK.NET_DVR_StartListen_V30(sLocalIP, wLocalPort, m_falarmData, IntPtr.Zero)

        If iListenHandle < 0 Then
            iLastErr = CHCNetSDK.NET_DVR_GetLastError()
            strErr = "启动监听失败，错误号：" & iLastErr
            MessageBox.Show(strErr)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        win_screen.Show()
    End Sub
End Class