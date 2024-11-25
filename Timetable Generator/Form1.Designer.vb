<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbTR = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtgDone = New System.Windows.Forms.DataGridView()
        Me.CLASSNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLASSTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CMBSTAFF = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSubjects = New System.Windows.Forms.ComboBox()
        Me.txtLessons = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddSub = New System.Windows.Forms.Button()
        Me.dtgSubj = New System.Windows.Forms.DataGridView()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Teacher = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lessons = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtgDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtgSubj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1281, 106)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(1207, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 42)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "[X]"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(457, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLASS REGISTRATIONS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.cmbTR)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLevel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 150)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLASS DETAIL"
        '
        'cmbTR
        '
        Me.cmbTR.FormattingEnabled = True
        Me.cmbTR.Location = New System.Drawing.Point(193, 45)
        Me.cmbTR.Name = "cmbTR"
        Me.cmbTR.Size = New System.Drawing.Size(188, 24)
        Me.cmbTR.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CLASS TEACHER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LEVEL"
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(193, 89)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.ReadOnly = True
        Me.txtLevel.Size = New System.Drawing.Size(188, 22)
        Me.txtLevel.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(747, 387)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(203, 47)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dtgDone
        '
        Me.dtgDone.AllowUserToAddRows = False
        Me.dtgDone.AllowUserToDeleteRows = False
        Me.dtgDone.AllowUserToResizeColumns = False
        Me.dtgDone.AllowUserToResizeRows = False
        Me.dtgDone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgDone.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgDone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgDone.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgDone.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDone.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLASSNAME, Me.CLASSTR})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDone.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgDone.GridColor = System.Drawing.Color.Maroon
        Me.dtgDone.Location = New System.Drawing.Point(12, 573)
        Me.dtgDone.Name = "dtgDone"
        Me.dtgDone.ReadOnly = True
        Me.dtgDone.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dtgDone.RowHeadersWidth = 51
        Me.dtgDone.RowTemplate.Height = 24
        Me.dtgDone.Size = New System.Drawing.Size(1281, 198)
        Me.dtgDone.TabIndex = 6
        '
        'CLASSNAME
        '
        Me.CLASSNAME.HeaderText = "CLASS"
        Me.CLASSNAME.MinimumWidth = 6
        Me.CLASSNAME.Name = "CLASSNAME"
        Me.CLASSNAME.ReadOnly = True
        '
        'CLASSTR
        '
        Me.CLASSTR.HeaderText = "CLASS TEACHER"
        Me.CLASSTR.MinimumWidth = 6
        Me.CLASSTR.Name = "CLASSTR"
        Me.CLASSTR.ReadOnly = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRefresh.Location = New System.Drawing.Point(548, 387)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(173, 47)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Controls.Add(Me.CMBSTAFF)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmbSubjects)
        Me.GroupBox3.Controls.Add(Me.txtLessons)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnAddSub)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 316)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(493, 212)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Subjects"
        '
        'CMBSTAFF
        '
        Me.CMBSTAFF.FormattingEnabled = True
        Me.CMBSTAFF.Location = New System.Drawing.Point(193, 124)
        Me.CMBSTAFF.Name = "CMBSTAFF"
        Me.CMBSTAFF.Size = New System.Drawing.Size(188, 24)
        Me.CMBSTAFF.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 130)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 18)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "TEACHER:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "LESSONS/WEEK"
        '
        'cmbSubjects
        '
        Me.cmbSubjects.FormattingEnabled = True
        Me.cmbSubjects.Location = New System.Drawing.Point(193, 38)
        Me.cmbSubjects.Name = "cmbSubjects"
        Me.cmbSubjects.Size = New System.Drawing.Size(188, 24)
        Me.cmbSubjects.TabIndex = 4
        '
        'txtLessons
        '
        Me.txtLessons.Location = New System.Drawing.Point(193, 83)
        Me.txtLessons.Name = "txtLessons"
        Me.txtLessons.ReadOnly = True
        Me.txtLessons.Size = New System.Drawing.Size(188, 22)
        Me.txtLessons.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SUBJECT:"
        '
        'btnAddSub
        '
        Me.btnAddSub.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddSub.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btnAddSub.Location = New System.Drawing.Point(249, 164)
        Me.btnAddSub.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddSub.Name = "btnAddSub"
        Me.btnAddSub.Size = New System.Drawing.Size(128, 29)
        Me.btnAddSub.TabIndex = 35
        Me.btnAddSub.Text = "Add"
        Me.btnAddSub.UseVisualStyleBackColor = False
        '
        'dtgSubj
        '
        Me.dtgSubj.AllowUserToAddRows = False
        Me.dtgSubj.AllowUserToResizeColumns = False
        Me.dtgSubj.AllowUserToResizeRows = False
        Me.dtgSubj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgSubj.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtgSubj.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgSubj.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgSubj.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgSubj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgSubj.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Subject, Me.Teacher, Me.Lessons})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgSubj.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgSubj.GridColor = System.Drawing.Color.Maroon
        Me.dtgSubj.Location = New System.Drawing.Point(548, 145)
        Me.dtgSubj.Name = "dtgSubj"
        Me.dtgSubj.ReadOnly = True
        Me.dtgSubj.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dtgSubj.RowHeadersWidth = 51
        Me.dtgSubj.RowTemplate.Height = 24
        Me.dtgSubj.Size = New System.Drawing.Size(560, 196)
        Me.dtgSubj.TabIndex = 51
        '
        'Subject
        '
        Me.Subject.HeaderText = "Subject"
        Me.Subject.MinimumWidth = 6
        Me.Subject.Name = "Subject"
        Me.Subject.ReadOnly = True
        '
        'Teacher
        '
        Me.Teacher.HeaderText = "Teacher"
        Me.Teacher.MinimumWidth = 6
        Me.Teacher.Name = "Teacher"
        Me.Teacher.ReadOnly = True
        '
        'Lessons
        '
        Me.Lessons.HeaderText = "Lessons Per Week"
        Me.Lessons.MinimumWidth = 6
        Me.Lessons.Name = "Lessons"
        Me.Lessons.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(983, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(203, 47)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Print Timetable"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 783)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtgSubj)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dtgDone)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtgDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtgSubj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents cmbTR As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents dtgDone As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents CLASSNAME As DataGridViewTextBoxColumn
    Friend WithEvents CLASSTR As DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As Button
    Friend WithEvents GroupBox3 As GroupBox
    Private WithEvents Label4 As Label
    Friend WithEvents btnAddSub As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSubjects As ComboBox
    Friend WithEvents txtLessons As TextBox
    Friend WithEvents dtgSubj As DataGridView
    Friend WithEvents CMBSTAFF As ComboBox
    Private WithEvents Label6 As Label
    Friend WithEvents Subject As DataGridViewTextBoxColumn
    Friend WithEvents Teacher As DataGridViewTextBoxColumn
    Friend WithEvents Lessons As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
