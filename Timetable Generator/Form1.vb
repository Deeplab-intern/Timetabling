Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillTR()
        ' fillTRs()
        getDone()
    End Sub
    Private Sub fillTR()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim adp As New SqlDataAdapter()
            Dim ds As New DataSet
            Dim dt As New DataTable
            adp.SelectCommand = New SqlCommand("SELECT distinct (Name) FROM Staff Where not Class is null", conn)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dt = ds.Tables(0)
            cmbTR.Items.Clear()
            For Each drow As DataRow In dt.Rows
                cmbTR.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub fillTRs()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim adp As New SqlDataAdapter()
            Dim ds As New DataSet
            Dim dt As New DataTable
            adp.SelectCommand = New SqlCommand("SELECT distinct (Name) FROM Staff Where Subjects='" & "" & cmbSubjects.Text & "' OR SecSub='" & "" & cmbSubjects.Text & "' OR ThirdSub='" & "" & cmbSubjects.Text & "' ", conn)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dt = ds.Tables(0)
            CMBSTAFF.Items.Clear()
            For Each drow As DataRow In dt.Rows
                CMBSTAFF.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub fillSub()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim adp As New SqlDataAdapter()
            Dim ds As New DataSet
            Dim dt As New DataTable
            adp.SelectCommand = New SqlCommand("SELECT distinct (Name) FROM Subjects ", conn)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dt = ds.Tables(0)
            cmbSubjects.Items.Clear()
            For Each drow As DataRow In dt.Rows
                cmbSubjects.Items.Add(drow(0).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbTR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTR.SelectedIndexChanged
        Dim dtb As New DataTable
        dtb = GetDataFromOneTableWhere("Staff", "Name", cmbTR.Text)
        If dtb.Rows.Count > 0 Then
            txtLevel.Text = dtb.Rows(0)("Class").ToString
            fillSub()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmbSubjects_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubjects.SelectedIndexChanged
        Dim dtb As New DataTable
        Dim subid As String
        dtb = GetDataFromOneTableWhere("Subjects", "Name", cmbSubjects.Text)
        If dtb.Rows.Count > 0 Then
            subid = dtb.Rows(0)("SubjectID").ToString
        End If
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim adp As New SqlDataAdapter()
            Dim ds As New DataSet
            Dim dt As New DataTable
            adp.SelectCommand = New SqlCommand("SELECT MaxPeriods FROM SubjectBreakdown Where ClassID Like '" & "" & txtLevel.Text.ToCharArray(0, 1) & "%' and SubjectID='" & "" & subid & "' ", conn)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dt = ds.Tables(0)
            If dt.Rows.Count > 0 Then
                txtLessons.Text = dt.Rows(0)(0).ToString
            End If
            cmbTR.Enabled = False
            fillTRs()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddSub_Click(sender As Object, e As EventArgs) Handles btnAddSub.Click
        If Not txtLessons.Text = "" Then
            If Not CMBSTAFF.Text = "" Then
                dtgSubj.Rows.Add(cmbSubjects.Text, CMBSTAFF.Text, txtLessons.Text)
                txtLessons.Text = ""
                cmbSubjects.Items.Remove(cmbSubjects.Text)
                cmbSubjects.Text = ""
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            For i As Integer = 0 To dtgSubj.Rows.Count - 1
                Dim df As New DataTable
                df = GetDataFromOneTableWhere("Staff", "Name", dtgSubj.Rows(i).Cells("Teacher").Value)
                If df.Rows.Count > 0 Then
                    Dim com As New SqlCommand("Insert into [Statistics]([ClassID],[Subject],[StaffID],[MaxHours]) Values(@d1,@d2,@d3,@d4)", conn)
                    com.Parameters.AddWithValue("d1", txtLevel.Text)
                    com.Parameters.AddWithValue("d2", dtgSubj.Rows(i).Cells("Subject").Value)
                    com.Parameters.AddWithValue("d3", df.Rows(0)("StaffID").ToString)
                    com.Parameters.AddWithValue("d4", dtgSubj.Rows(i).Cells("Lessons").Value)
                    com.ExecuteNonQuery()
                End If
            Next
            MsgBox("Saved")
            resetAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub resetAll()
        dtgSubj.Rows.Clear()
        txtLessons.Text = ""
        txtLevel.Text = ""
        cmbSubjects.Text = ""
        CMBSTAFF.Text = ""
        cmbTR.Text = ""
        getDone()
    End Sub
    Private Sub getDone()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            Dim adp As New SqlDataAdapter()
            Dim ds As New DataSet
            Dim dt As New DataTable
            adp.SelectCommand = New SqlCommand("SELECT * FROM [Statistics]", conn)
            ds = New DataSet("ds")
            adp.Fill(ds)
            dt = ds.Tables(0)
            dtgDone.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        resetAll()
        cmbTR.Enabled = True
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Program.Main()
        conn = New SqlConnection(cs)
        conn.Open()
        Dim cmd = New SqlCommand("SELECT * from Timetable", conn)
        Dim adp = New SqlDataAdapter(cmd)
        Dim ds As New DataTable
        adp.Fill(ds)
        Dim rRep As New crpTimetable
        rRep.SetDataSource(ds)
        repo.CrystalReportViewer1.ReportSource = rRep
        repo.Show()
    End Sub
End Class
