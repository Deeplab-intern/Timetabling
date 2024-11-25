Imports System.Data.SqlClient
Imports System.Text

Public Class frmGenerate
    Dim dtp As New DataTable
    Private Sub btnGen_Click(sender As Object, e As EventArgs) Handles btnGen.Click
        ' getSubjects())
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

End Class