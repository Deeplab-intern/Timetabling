Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Linq

Public Class Subject
    Public Property ClassID As String
    Public Property Name As String
    Public Property StaffID As String
    Public Property MaxHours As Integer
End Class

Public Class TimetableEntry
    Public Property Day As String
    Public Property Subjects As List(Of (Subject As String, StaffID As String)) = New List(Of (String, String))(New(String, String)(9) {})
End Class

Module Program
    Sub Main()

        Dim subjects As New List(Of Subject)()

        ' CLASS 1A
        subjects.Add(New Subject With {.ClassID = "1A", .Name = "History", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1A", .Name = "Geography", .StaffID = "M2002", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1A", .Name = "Mathematics", .StaffID = "M2003", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "1A", .Name = "English", .StaffID = "M2004", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "1A", .Name = "FRS", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1A", .Name = "Combined Science", .StaffID = "M2007", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "1A", .Name = "Shona", .StaffID = "M2008", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "1A", .Name = "GC", .StaffID = "M2004", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "1A", .Name = "Agriculture", .StaffID = "M2009", .MaxHours = 5})

        ' CLASS 1B
        subjects.Add(New Subject With {.ClassID = "1B", .Name = "History", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1B", .Name = "Geography", .StaffID = "M2012", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1B", .Name = "Mathematics", .StaffID = "M2013", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "1B", .Name = "English", .StaffID = "M2014", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "1B", .Name = "FRS", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1B", .Name = "Combined Science", .StaffID = "M2015", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "1B", .Name = "Shona", .StaffID = "M2016", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "1B", .Name = "GC", .StaffID = "M2013", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "1B", .Name = "Agriculture", .StaffID = "M2017", .MaxHours = 5})

        ' CLASS 1C
        subjects.Add(New Subject With {.ClassID = "1C", .Name = "History", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1C", .Name = "Geography", .StaffID = "M2002", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1C", .Name = "Mathematics", .StaffID = "M2003", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "1C", .Name = "English", .StaffID = "M2004", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "1C", .Name = "FRS", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1C", .Name = "Combined Science", .StaffID = "M2007", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "1C", .Name = "Shona", .StaffID = "M2008", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "1C", .Name = "GC", .StaffID = "M2004", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "1C", .Name = "Agriculture", .StaffID = "M2009", .MaxHours = 5})

        ' CLASS 1D
        subjects.Add(New Subject With {.ClassID = "1D", .Name = "History", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1D", .Name = "Geography", .StaffID = "M2012", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1D", .Name = "Mathematics", .StaffID = "M2013", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "1D", .Name = "English", .StaffID = "M2014", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "1D", .Name = "FRS", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "1D", .Name = "Combined Science", .StaffID = "M2015", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "1D", .Name = "Shona", .StaffID = "M2016", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "1D", .Name = "GC", .StaffID = "M2013", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "1D", .Name = "Agriculture", .StaffID = "M2017", .MaxHours = 5})

        ' CLASS 2A
        subjects.Add(New Subject With {.ClassID = "2A", .Name = "History", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2A", .Name = "Geography", .StaffID = "M2002", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2A", .Name = "Mathematics", .StaffID = "M2003", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "2A", .Name = "English", .StaffID = "M2004", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "2A", .Name = "FRS", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2A", .Name = "Combined Science", .StaffID = "M2007", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "2A", .Name = "Shona", .StaffID = "M2008", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "2A", .Name = "GC", .StaffID = "M2004", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "2A", .Name = "Agriculture", .StaffID = "M2009", .MaxHours = 5})

        ' CLASS 2B
        subjects.Add(New Subject With {.ClassID = "2B", .Name = "History", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2B", .Name = "Geography", .StaffID = "M2012", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2B", .Name = "Mathematics", .StaffID = "M2013", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "2B", .Name = "English", .StaffID = "M2014", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "2B", .Name = "FRS", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2B", .Name = "Combined Science", .StaffID = "M2015", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "2B", .Name = "Shona", .StaffID = "M2016", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "2B", .Name = "GC", .StaffID = "M2013", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "2B", .Name = "Agriculture", .StaffID = "M2017", .MaxHours = 5})

        ' CLASS 2C
        subjects.Add(New Subject With {.ClassID = "2C", .Name = "History", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2C", .Name = "Geography", .StaffID = "M2002", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2C", .Name = "Mathematics", .StaffID = "M2003", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "2C", .Name = "English", .StaffID = "M2004", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "2C", .Name = "FRS", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2C", .Name = "Combined Science", .StaffID = "M2007", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "2C", .Name = "Shona", .StaffID = "M2008", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "2C", .Name = "GC", .StaffID = "M2004", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "2C", .Name = "Agriculture", .StaffID = "M2009", .MaxHours = 5})

        ' CLASS 2D
        subjects.Add(New Subject With {.ClassID = "2D", .Name = "History", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2D", .Name = "Geography", .StaffID = "M2012", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2D", .Name = "Mathematics", .StaffID = "M2013", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "2D", .Name = "English", .StaffID = "M2014", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "2D", .Name = "FRS", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "2D", .Name = "Combined Science", .StaffID = "M2015", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "2D", .Name = "Shona", .StaffID = "M2016", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "2D", .Name = "GC", .StaffID = "M2013", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "2D", .Name = "Agriculture", .StaffID = "M2017", .MaxHours = 5})

        ' Class 3A
        subjects.Add(New Subject With {.ClassID = "3A", .Name = "History", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3A", .Name = "Geography", .StaffID = "M2002", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3A", .Name = "Mathematics", .StaffID = "M2003", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "3A", .Name = "English", .StaffID = "M2004", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "3A", .Name = "FRS", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3A", .Name = "Combined Science", .StaffID = "M2007", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "3A", .Name = "Shona", .StaffID = "M2008", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "3A", .Name = "GC", .StaffID = "M2004", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "3A", .Name = "Agriculture", .StaffID = "M2009", .MaxHours = 5})

        ' CLASS 3B
        subjects.Add(New Subject With {.ClassID = "3B", .Name = "History", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3B", .Name = "Geography", .StaffID = "M2012", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3B", .Name = "Mathematics", .StaffID = "M2013", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "3B", .Name = "English", .StaffID = "M2014", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "3B", .Name = "FRS", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3B", .Name = "Combined Science", .StaffID = "M2015", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "3B", .Name = "Shona", .StaffID = "M2016", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "3B", .Name = "GC", .StaffID = "M2013", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "3B", .Name = "Agriculture", .StaffID = "M2017", .MaxHours = 5})

        ' CLASS 3C
        subjects.Add(New Subject With {.ClassID = "3C", .Name = "History", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3C", .Name = "Geography", .StaffID = "M2002", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3C", .Name = "Mathematics", .StaffID = "M2003", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "3C", .Name = "English", .StaffID = "M2004", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "3C", .Name = "FRS", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3C", .Name = "Combined Science", .StaffID = "M2007", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "3C", .Name = "Shona", .StaffID = "M2008", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "3C", .Name = "GC", .StaffID = "M2004", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "3C", .Name = "Agriculture", .StaffID = "M2009", .MaxHours = 5})

        ' CLASS 3D
        subjects.Add(New Subject With {.ClassID = "3D", .Name = "History", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3D", .Name = "Geography", .StaffID = "M2012", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3D", .Name = "Mathematics", .StaffID = "M2013", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "3D", .Name = "English", .StaffID = "M2014", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "3D", .Name = "FRS", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "3D", .Name = "Combined Science", .StaffID = "M2015", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "3D", .Name = "Shona", .StaffID = "M2016", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "3D", .Name = "GC", .StaffID = "M2013", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "3D", .Name = "Agriculture", .StaffID = "M2017", .MaxHours = 5})

        'CLASS 4A
        subjects.Add(New Subject With {.ClassID = "4A", .Name = "History", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "4A", .Name = "Geography", .StaffID = "M2012", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "4A", .Name = "Mathematics", .StaffID = "M2013", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4A", .Name = "English", .StaffID = "M2004", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4A", .Name = "BIOLOGY", .StaffID = "M2020", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4A", .Name = "CHEMISTRY", .StaffID = "M2007", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4A", .Name = "Shona", .StaffID = "M2008", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "4A", .Name = "GC", .StaffID = "M2012", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "4A", .Name = "PHYSICS", .StaffID = "M2018", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4A", .Name = "Agriculture", .StaffID = "M2009", .MaxHours = 4})
        'CLASS 4B
        subjects.Add(New Subject With {.ClassID = "4B", .Name = "History", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "4B", .Name = "Geography", .StaffID = "M2002", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "4B", .Name = "Mathematics", .StaffID = "M2013", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4B", .Name = "English", .StaffID = "M2014", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4B", .Name = "ACCOUNTING", .StaffID = "M2019", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4B", .Name = "ECONOMICS", .StaffID = "M2010", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4B", .Name = "Shona", .StaffID = "M2016", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "4B", .Name = "GC", .StaffID = "M2010", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "4B", .Name = "COMBINED SCI", .StaffID = "M2007", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4B", .Name = "Agriculture", .StaffID = "M2017", .MaxHours = 4})
        'CLASS 4C
        subjects.Add(New Subject With {.ClassID = "4C", .Name = "History", .StaffID = "M2011", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "4C", .Name = "Geography", .StaffID = "M2002", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "4C", .Name = "Mathematics", .StaffID = "M2003", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4C", .Name = "English", .StaffID = "M2004", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4C", .Name = "COMBINED SCI", .StaffID = "M2020", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4C", .Name = "FRS", .StaffID = "M2991", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4C", .Name = "Shona", .StaffID = "M2008", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "4C", .Name = "GC", .StaffID = "M2002", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "4C", .Name = "Agriculture", .StaffID = "M2017", .MaxHours = 4})
        'CLASS 4D
        subjects.Add(New Subject With {.ClassID = "4D", .Name = "History", .StaffID = "M2001", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "4D", .Name = "Geography", .StaffID = "M2012", .MaxHours = 4})
        subjects.Add(New Subject With {.ClassID = "4D", .Name = "Mathematics", .StaffID = "M2003", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4D", .Name = "English", .StaffID = "M2014", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4D", .Name = "COMBINED SCI", .StaffID = "M2007", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4D", .Name = "FRS", .StaffID = "2011", .MaxHours = 5})
        subjects.Add(New Subject With {.ClassID = "4D", .Name = "Shona", .StaffID = "M2016", .MaxHours = 3})
        subjects.Add(New Subject With {.ClassID = "4D", .Name = "GC", .StaffID = "M2017", .MaxHours = 1})
        subjects.Add(New Subject With {.ClassID = "4D", .Name = "Agriculture", .StaffID = "M2017", .MaxHours = 4})



        Dim classIDs = subjects.Select(Function(s) s.ClassID).Distinct()
        Dim teacherAssignments = New Dictionary(Of String, HashSet(Of String))()

        For Each classID In classIDs
            Dim timetable = GenerateTimetable(subjects, classID, teacherAssignments)
            PrintTimetable(timetable, classID)
            SaveTimetableToDatabase(timetable, classID)
        Next

        Console.Read()
    End Sub

    Function GenerateTimetable(subjects As List(Of Subject), classID As String, teacherAssignments As Dictionary(Of String, HashSet(Of String))) As List(Of TimetableEntry)
        Dim days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"}
        Dim timetable = days.Select(Function(day) New TimetableEntry With {.Day = day}).ToList()


        Dim classSubjects = subjects.Where(Function(s) s.ClassID = classID).ToList()
        Dim allocatedHours = New Dictionary(Of String, Integer)()
        Dim random As New Random()

        For Each entry In timetable
            Dim subjectsAssignedToday = New HashSet(Of String)()
            'ma practicals
            ReservePracticals(entry, classID)

            Dim isForm1Or2 = classID.StartsWith("1") OrElse classID.StartsWith("2")

            For period As Integer = 0 To 9
                If entry.Subjects(period).Subject = Nothing Then
                    entry.Subjects(period) = ("Free", "")
                End If

                If entry.Subjects(period).Subject = "Free" Then
                    Dim availableSubjects = classSubjects _
                        .Where(Function(s) (Not allocatedHours.ContainsKey(s.Name) OrElse allocatedHours(s.Name) < s.MaxHours) AndAlso
                                            Not subjectsAssignedToday.Contains(s.Name)).ToList()

                    availableSubjects = availableSubjects.OrderBy(Function(x) random.Next()).ToList()

                    Dim selectedSubject = AssignSubject(availableSubjects, teacherAssignments, entry.Day, period)

                    If selectedSubject IsNot Nothing Then
                        entry.Subjects(period) = selectedSubject.Value
                        subjectsAssignedToday.Add(selectedSubject.Value.Subject)

                        TrackTeacherAssignment(teacherAssignments, selectedSubject.Value.StaffID, entry.Day, period)

                        UpdateAllocatedHours(allocatedHours, selectedSubject.Value.Subject)
                    End If

                    If isForm1Or2 AndAlso random.Next(100) < 20 Then '
                        Dim diverseAvailableSubjects = classSubjects _
                            .Where(Function(s) Not subjectsAssignedToday.Contains(s.Name)).ToList()
                        If diverseAvailableSubjects.Any() Then
                            Dim diverseSubject = diverseAvailableSubjects(random.Next(diverseAvailableSubjects.Count))
                            entry.Subjects(period) = (diverseSubject.Name, diverseSubject.StaffID)
                            subjectsAssignedToday.Add(diverseSubject.Name)
                        End If
                    End If
                End If
            Next
        Next

        ' ma double periods 
        AllocateConsecutivePeriods(timetable, classSubjects, allocatedHours, teacherAssignments, classID)

        Return timetable
    End Function
    Sub AllocateConsecutivePeriods(timetable As List(Of TimetableEntry), subjects As List(Of Subject),
                               allocatedHours As Dictionary(Of String, Integer), teacherAssignments As Dictionary(Of String, HashSet(Of String)), classID As String)
        Dim random As New Random()

        For Each entry In timetable
            For i As Integer = 0 To 8
                If entry.Subjects(i).Subject = "Free" AndAlso entry.Subjects(i + 1).Subject = "Free" Then
                    Dim availableSubjects = GetAvailableSubjects(subjects, allocatedHours, New HashSet(Of String)(), classID)
                    availableSubjects = availableSubjects.OrderBy(Function(x) random.Next()).ToList()

                    Dim selectedSubject = availableSubjects.FirstOrDefault()

                    If selectedSubject IsNot Nothing Then
                        If Not teacherAssignments.ContainsKey(selectedSubject.StaffID) OrElse
                       Not teacherAssignments(selectedSubject.StaffID).Contains($"{entry.Day}_{i}") AndAlso
                       Not teacherAssignments(selectedSubject.StaffID).Contains($"{entry.Day}_{i + 1}") Then

                            entry.Subjects(i) = (selectedSubject.Name, selectedSubject.StaffID)
                            entry.Subjects(i + 1) = (selectedSubject.Name, selectedSubject.StaffID)
                            TrackTeacherAssignment(teacherAssignments, selectedSubject.StaffID, entry.Day, i)
                            TrackTeacherAssignment(teacherAssignments, selectedSubject.StaffID, entry.Day, i + 1)
                            UpdateAllocatedHours(allocatedHours, selectedSubject.Name)
                        End If
                    End If
                End If
            Next
        Next
    End Sub



    Function GetAvailableSubjects(subjects As List(Of Subject), allocatedHours As Dictionary(Of String, Integer),
                                  subjectsAssignedToday As HashSet(Of String), classID As String) As List(Of Subject)
        Return subjects.Where(Function(s) s.ClassID = classID AndAlso
                                          (Not allocatedHours.ContainsKey(s.Name) OrElse allocatedHours(s.Name) < s.MaxHours) AndAlso
                                          Not subjectsAssignedToday.Contains(s.Name)).ToList()
    End Function

    Function AssignSubject(availableSubjects As List(Of Subject), teacherAssignments As Dictionary(Of String, HashSet(Of String)),
                       day As String, period As Integer) As (Subject As String, StaffID As String)?
        For Each subject In availableSubjects
            Dim teacherBusy = teacherAssignments.ContainsKey(subject.StaffID) AndAlso
                          teacherAssignments(subject.StaffID).Any(Function(t) t.StartsWith($"{day}_"))

            If Not teacherBusy Then
                Return (subject.Name, subject.StaffID)
            End If
        Next
        Return Nothing
    End Function



    Sub UpdateAllocatedHours(allocatedHours As Dictionary(Of String, Integer), subject As String)
        If allocatedHours.ContainsKey(subject) Then
            allocatedHours(subject) += 1
        Else
            allocatedHours(subject) = 1
        End If
    End Sub

    Sub ReservePracticals(entry As TimetableEntry, classID As String)
        If entry.Day = "Monday" AndAlso classID.StartsWith("1") Then
            For period As Integer = 0 To 3
                entry.Subjects(period) = ("Practicals", "Prac")
            Next
        ElseIf entry.Day = "Tuesday" AndAlso classID.StartsWith("2") Then
            For period As Integer = 5 To 8
                entry.Subjects(period) = ("Practicals", "Prac")
            Next
        ElseIf entry.Day = "Wednesday" AndAlso classID.StartsWith("3") Then
            For period As Integer = 0 To 3
                entry.Subjects(period) = ("Practicals", "Prac")
            Next
        ElseIf entry.Day = "Friday" AndAlso classID.StartsWith("4") Then
            For period As Integer = 5 To 8
                entry.Subjects(period) = ("Practicals", "Prac")
            Next
        End If
    End Sub

    Sub TrackTeacherAssignment(teacherAssignments As Dictionary(Of String, HashSet(Of String)), staffID As String, day As String, period As Integer)
        If Not teacherAssignments.ContainsKey(staffID) Then
            teacherAssignments(staffID) = New HashSet(Of String)()
        End If

        teacherAssignments(staffID).Add($"{day}_{period}")
    End Sub


    Sub PrintTimetable(timetable As List(Of TimetableEntry), classID As String)
        Console.WriteLine($"Timetable for Class {classID}:")
        Console.WriteLine(New String("-"c, 70))
        Console.WriteLine("Day       | " & String.Join(" | ", Enumerable.Range(1, 10).Select(Function(i) $"Period {i}")))
        Console.WriteLine(New String("-"c, 70))

        For Each entry In timetable
            Dim periods = entry.Subjects.Select(Function(s) If(s.Subject = "Free", "Free", $"{s.Subject} (Staff: {s.StaffID})")).ToList()
            Console.WriteLine($"{entry.Day.PadRight(10)} | {String.Join(" | ", periods.Select(Function(p) p.PadRight(20)))}")
        Next

        Console.WriteLine(New String("-"c, 70))
    End Sub

    Sub SaveTimetableToDatabase(timetable As List(Of TimetableEntry), classID As String)
        Dim connectionString As String = "Server=Deeplab\Deeplab; Database=Timetable; Trusted_Connection=True;"

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            'Dim cmd As New SqlCommand("Delete from Timetable", connection)
            'cmd.ExecuteNonQuery()

            For Each entry In timetable
                Dim commandText = $"IF EXISTS(SELECT * FROM Timetable WHERE ClassID = @ClassID AND Day = @Day) " &
                                  $"BEGIN DELETE FROM Timetable WHERE ClassID = @ClassID AND Day = @Day END; " &
                                  $"INSERT INTO Timetable (ClassID, Day, Period1, Period2, Period3, Period4, Period5, Period6, Period7, Period8, Period9, Period10) " &
                                  $"VALUES (@ClassID, @Day, @Period1, @Period2, @Period3, @Period4, @Period5, @Period6, @Period7, @Period8, @Period9, @Period10);"

                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@ClassID", classID)
                    command.Parameters.AddWithValue("@Day", entry.Day)

                    For i As Integer = 0 To 9
                        command.Parameters.AddWithValue($"@Period{i + 1}", entry.Subjects(i).Subject + "-" + entry.Subjects(i).StaffID)
                    Next

                    command.ExecuteNonQuery()
                End Using
            Next
        End Using
    End Sub
End Module
