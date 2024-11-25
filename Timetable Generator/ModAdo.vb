Imports System.Data.SqlClient
Imports System.IO

Module ModAdo

    ' Public Const cs As String = "Data Source=localhost\ZMDB;Initial Catalog=ERPS_DB Chegutu;Integrated Security=True" '
    Public Const cs As String = "Data Source=DEEPLAB\DEEPLAB;Initial Catalog=Timetable;Integrated Security=True"
    Public loggedUserId As String = ""
    Public loggedUser As String = ""
    Public loggedUserType As String = ""
    Public conn As New SqlConnection(cs)
    Public dateyear As String = DateTime.Now.ToString("yyyy/MM/dd")
    Public thisYear As Integer = Year(dateyear)
    Public currentdatetime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm")
    Dim currentBalance As Double
    Dim operata As String
    Public SyncAccounts As Boolean
    Public Function GetDataFromOneTableWhere(tablename As String, where As String, value As String) As DataTable
        Dim dt, dt2 As New DataTable
        Dim sql As String
        Dim dat As SqlDataAdapter
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        ElseIf conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        End If
        sql = "SELECT * from " & "" & tablename & " where [" & "" & where & "] = '" & "" & value & "'"
        dat = New SqlDataAdapter(sql, conn)
        dat.Fill(dt)
        Return dt
    End Function
End Module