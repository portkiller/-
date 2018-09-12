Imports System
Imports System.Data.SQLite
Imports System.Data
Imports System.ComponentModel
Module sql
    Dim str As String = Application.StartupPath & "\myche.db"
    Dim constr As String = "data source= " & str & ""
    Public SQLconn As New Data.SQLite.SQLiteConnection '定义数据库链接  
    Dim sqlcmd As New SQLite.SQLiteCommand '定义查询操作  
    Dim ds As New DataSet
    Dim salda As New SQLite.SQLiteDataAdapter
    Public Sub init()
        SQLconn.ConnectionString = constr '链接数据库  
        SQLconn.Open()
        'MessageBox.Show("123")
    End Sub

    Public Function chaxun_user(ByVal datestring As String)
        Try
            ds.Tables.Clear()
            sqlcmd = New SQLiteCommand
            sqlcmd.Connection = SQLconn
            sqlcmd.CommandText = "select * from user where name = '" + datestring + "'"
            Dim sqlreader As SQLite.SQLiteDataReader = sqlcmd.ExecuteReader
            salda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SQLconn)
            salda.Fill(ds, 0)
            chaxun_user = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not (sqlcmd Is Nothing) Then sqlcmd.Dispose()
            sqlcmd = Nothing
            If Not (salda Is Nothing) Then salda.Dispose()
            salda = Nothing
        End Try
    End Function
    Public Function chaxun_device()
        Try
            ds.Tables.Clear()
            sqlcmd = New SQLiteCommand
            sqlcmd.Connection = SQLconn
            sqlcmd.CommandText = "select * from device"
            Dim sqlreader As SQLite.SQLiteDataReader = sqlcmd.ExecuteReader
            salda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SQLconn)
            salda.Fill(ds, 0)
            chaxun_device = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not (sqlcmd Is Nothing) Then sqlcmd.Dispose()
            sqlcmd = Nothing
            If Not (salda Is Nothing) Then salda.Dispose()
            salda = Nothing
        End Try
    End Function
    Public Function chaxun_screen()
        Try
            ds.Tables.Clear()
            sqlcmd = New SQLiteCommand
            sqlcmd.Connection = SQLconn
            sqlcmd.CommandText = "select * from screen"
            Dim sqlreader As SQLite.SQLiteDataReader = sqlcmd.ExecuteReader
            salda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SQLconn)
            salda.Fill(ds, 0)
            chaxun_screen = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not (sqlcmd Is Nothing) Then sqlcmd.Dispose()
            sqlcmd = Nothing
            If Not (salda Is Nothing) Then salda.Dispose()
            salda = Nothing
        End Try
    End Function
    Public Sub insertchepai(chepai As String)
        ds.Tables.Clear()
        sqlcmd = New SQLite.SQLiteCommand
        sqlcmd.Connection = SQLconn
        sqlcmd.CommandText = "INSERT INTO whitelist (chepai) VALUES ('" + chepai.ToString + "')"
        Dim sqlreader As SQLite.SQLiteDataReader = sqlcmd.ExecuteReader
        salda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SQLconn)
        If Not (sqlcmd Is Nothing) Then sqlcmd.Dispose()
        sqlcmd = Nothing
        If Not (salda Is Nothing) Then salda.Dispose()
        salda = Nothing
    End Sub
    Public Sub delchepai(chepai As String)
        ds.Tables.Clear()
        sqlcmd = New SQLiteCommand
        sqlcmd.Connection = SQLconn
        sqlcmd.CommandText = " DELETE FROM device WHERE ID =  " + chepai.ToString
        Dim sqlreader As SQLite.SQLiteDataReader = sqlcmd.ExecuteReader
        salda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SQLconn)
        If Not (sqlcmd Is Nothing) Then sqlcmd.Dispose()
        sqlcmd = Nothing
        If Not (salda Is Nothing) Then salda.Dispose()
        salda = Nothing
    End Sub

    Public Function chaxun()
        Try
            ds.Tables.Clear()
            sqlcmd = New SQLiteCommand
            sqlcmd.Connection = SQLconn
            sqlcmd.CommandText = "select * from list where unixtime>" + datetimeint(Now.Date).ToString
            Dim sqlreader As SQLite.SQLiteDataReader = sqlcmd.ExecuteReader
            salda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SQLconn)
            salda.Fill(ds, 0)
            chaxun = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not (sqlcmd Is Nothing) Then sqlcmd.Dispose()
            sqlcmd = Nothing
            If Not (salda Is Nothing) Then salda.Dispose()
            salda = Nothing
        End Try
    End Function

    Public Sub insertdata(ByVal command As String)
        Try
            sqlcmd = New SQLiteCommand
            sqlcmd.Connection = SQLconn
            sqlcmd.CommandText = command
            Dim sqlreader As SQLite.SQLiteDataReader = sqlcmd.ExecuteReader
            salda = New SQLite.SQLiteDataAdapter(sqlcmd.CommandText, SQLconn)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not (sqlcmd Is Nothing) Then sqlcmd.Dispose()
            sqlcmd = Nothing
            If Not (salda Is Nothing) Then salda.Dispose()
            salda = Nothing
        End Try
    End Sub
    Public Function intdatetime(d As Double)
        Dim time As DateTime = DateTime.MinValue
        Dim starttime As DateTime = TimeZone.CurrentTimeZone.ToLocalTime(New DateTime(1970, 1, 1))
        time = starttime.AddMilliseconds(d)
        intdatetime = time
    End Function
    Public Function datetimeint(time As DateTime)
        Dim starttime = TimeZone.CurrentTimeZone.ToLocalTime(New DateTime(1970, 1, 1, 0, 0, 0, 0))
        Dim t As Long = (time.Ticks - starttime.Ticks) / 10000000
        datetimeint = t

    End Function
End Module
