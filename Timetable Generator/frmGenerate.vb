Imports System.Data.SqlClient
Imports System.Text

Public Class frmGenerate
    Dim dtp As New DataTable
    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        ' getSubjects()
        Dim subjects As List(Of Subject) = GetSubjectsFromDatabase()
        Dim schedule As String = GenerateScheduleN(subjects)
        RichTextBox1.Text = schedule
    End Sub
    Public Class Subject
        Public Property Name As String
        Public Property MaxHours As Integer
        Public Property Teacher As String
        Public Property ClassID As String
        Public Property Schedule As New List(Of TimeSlot)

    End Class
    Public Class TimeSlot
        Public Property Day As Integer
        Public Property StartTime As Integer
        Public Property EndTime As Integer
    End Class
    ' ... (Existing code for Subject and TimeSlot classes)

    ' Function to generate a schedule with periods
    ' ... (Existing code for Subject, TimeSlot classes)

    ' Function to generate a schedule with unique periods
    Public Function GetOrAddElse(Of TKey, TValue)(dict As Dictionary(Of TKey, TValue), key As TKey, valueFactory As Func(Of TKey, TValue)) As TValue
        If Not dict.ContainsKey(key) Then
            dict.Add(key, valueFactory(key))
        End If
        Return dict(key)
    End Function


    ' ... (Existing code for GetRandomWeekdayIndex, GetWeekdayName, Shuffle functions)


    ' ... (Existing code for GetRandomWeekdayIndex, GetWeekdayName, Shuffle functions)

    Public Function GenerateScheduleN(subjects As List(Of Subject)) As String
        Dim scheduleBuilder As New StringBuilder()
        Dim usedPeriods As New Dictionary(Of String, List(Of Integer)) ' Track used periods per day (class)

        For Each subject In subjects
            ' Track used periods for this class
            Dim classUsedPeriods = GetOrAddElse(usedPeriods, subject.ClassID, Function() New List(Of Integer))

            ' Generate random days based on MaxHours
            Dim availableDays = Enumerable.Range(1, 5).ToList()  ' 1-5 represents weekdays
            Shuffle(availableDays)
            Dim selectedDays = availableDays.Take(subject.MaxHours).ToList()  ' Select random days (up to MaxHours)

            For Each day In selectedDays
                Dim availablePeriods = Enumerable.Range(1, 13).Except(classUsedPeriods).ToList()  ' Find unused periods

                ' Check if any periods are available (handle if needed)
                If availablePeriods.Count = 0 Then
                    '... (Implement logic for handling conflicts)
                    Exit For  ' Skip to next day for this subject
                End If

                Dim randomPeriod = availablePeriods(New Random().Next(availablePeriods.Count))
                classUsedPeriods.Add(randomPeriod)

                subject.Schedule.Add(New TimeSlot With {
                .Day = day,
                .StartTime = randomPeriod,
                .EndTime = randomPeriod + 1  ' Assuming single period duration
            })
            Next

            ' Format and display schedule for the subject
            For Each timeSlot In subject.Schedule
                Dim dayName = GetWeekdayName(timeSlot.Day)
                scheduleBuilder.AppendLine(String.Format("{0}: {1} ({2}) - Period {3} ({4}) - {5}",
                                                  subject.Name,
                                                  subject.Teacher,
                                                  subject.ClassID,
                                                  timeSlot.StartTime,
                                                  dayName,
                                                  subject.ClassID))
            Next
            scheduleBuilder.AppendLine()
        Next

        Return scheduleBuilder.ToString()
    End Function

    ' ... (Existing code for GetRandomWeekdayIndex, GetWeekdayName, Shuffle functions)


    ' ... (Existing code for GetRandomWeekdayIndex, GetWeekdayName, Shuffle functions)

    Public Function GenerateScheduleNow(subjects As List(Of Subject)) As String
        Dim scheduleBuilder As New StringBuilder()

        For Each subject In subjects
            ' Assign periods based on MaxHours
            For i As Integer = 1 To subject.MaxHours
                subject.Schedule.Add(New TimeSlot With {
                .Day = GetRandomWeekdayIndex(),  ' Use index for weekday selection
                .StartTime = i,
                .EndTime = i + 1  ' End period is next period (assuming single period duration)
            })
            Next

            ' Format and display schedule for the subject
            For Each timeSlot In subject.Schedule
                Dim dayName = GetWeekdayName(timeSlot.Day)
                scheduleBuilder.AppendLine(String.Format("{0}: {1} ({2}) - Period {3} ({4}) - {5}",
                                                  subject.Name,
                                                  subject.Teacher,
                                                  subject.ClassID,
                                                  timeSlot.StartTime,
                                                  dayName,
                                                  subject.ClassID))
            Next
            scheduleBuilder.AppendLine()
        Next

        Return scheduleBuilder.ToString()
    End Function

    ' Function to get a random weekday index (1-5)
    Private Function GetRandomWeekdayIndex() As Integer
        Dim weekdays = Enumerable.Range(1, 5).ToList()
        Shuffle(weekdays)
        Return weekdays(0)
    End Function

    ' Function to get weekday name based on index
    Private Function GetWeekdayName(dayIndex As Integer) As String
        Select Case dayIndex
            Case 1
                Return "Monday"
            Case 2
                Return "Tuesday"
            Case 3
                Return "Wednesday"
            Case 4
                Return "Thursday"
            Case 5
                Return "Friday"


        End Select
    End Function

    ' ... (Existing code for Shuffle function)

    Function GetRandomWeekday() As String
        Dim weekdays() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"}
        Dim randomIndex As Integer = New Random().Next(weekdays.Length)
        Return weekdays(randomIndex)
    End Function



    Private Sub Shuffle(list As List(Of Integer))
        Dim random As New Random()
        For i As Integer = list.Count - 1 To 1 Step -1
            Dim j As Integer = random.Next(i + 1)
            Dim temp As Integer = list(i)
            list(i) = list(j)
            list(j) = temp
        Next
    End Sub

    Public Function GetSubjectsFromDatabase() As List(Of Subject)

        Dim subjects As New List(Of Subject)

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        Dim query As String = "SELECT * from [Statistics]"
        Dim command As New SqlCommand(query, conn)

        Using reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                subjects.Add(New Subject With {
                    .Name = reader.GetString(1),
                    .MaxHours = reader.GetInt32(3),
                    .Teacher = reader.GetString(2),
                    .ClassID = reader.GetString(0)
                })
            End While
        End Using

        Return subjects
    End Function
    Private Sub getSubjects()
        Dim dt, dt2 As New DataTable
        Dim sql As String
        Dim dat As SqlDataAdapter
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        ElseIf conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        End If
        sql = "SELECT distinct ClassID from [Statistics]"
        dat = New SqlDataAdapter(sql, conn)
        dat.Fill(dt)
        dtgDone.DataSource = dt
        If dt.Rows.Count > 0 Then
            getPeriods(dt)
        End If
    End Sub

    Private Sub getPeriods(dr As DataTable)

        dtp.Columns.Add("Class")
        For i = 0 To 59
            dtp.Columns.Add(i)
        Next
        For Each row As DataRow In dr.Rows
            dtp.Rows.Add(row(0).ToString)
        Next
        fillSubjects(getTeaachers())
        dtgDone.DataSource = dtp

    End Sub
    Private Sub fillSubjects(dr As DataTable)
        Dim klass As Integer = 0
        For Each drow In dtp.Rows
            For Each row As DataRow In dr.Rows
                If (row("ClassID") = drow("Class")) Then
                    If (Convert.ToInt32(row("MaxHours")) > 0) Then
                        drow(klass) = row("StaffID").ToString
                        row("MaxHours") = Convert.ToInt32(row("MaxHours")) - 1
                    End If
                End If

            Next
        Next


    End Sub
    Private Function getTeaachers() As DataTable
        Dim dt, dt2 As New DataTable
        Dim sql As String
        Dim dat As SqlDataAdapter
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        ElseIf conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        End If
        sql = "SELECT * from [Statistics]"
        dat = New SqlDataAdapter(sql, conn)
        dat.Fill(dt)
        Return dt
    End Function
End Class