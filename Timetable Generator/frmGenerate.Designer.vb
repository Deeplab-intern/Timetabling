<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGenerate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgDone = New System.Windows.Forms.DataGridView()
        Me.btnGen = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.dtgDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgDone.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgDone.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgDone.GridColor = System.Drawing.Color.Maroon
        Me.dtgDone.Location = New System.Drawing.Point(0, 628)
        Me.dtgDone.Name = "dtgDone"
        Me.dtgDone.ReadOnly = True
        Me.dtgDone.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dtgDone.RowHeadersWidth = 51
        Me.dtgDone.RowTemplate.Height = 24
        Me.dtgDone.Size = New System.Drawing.Size(1323, 99)
        Me.dtgDone.TabIndex = 7
        '
        'btnGen
        '
        Me.btnGen.BackColor = System.Drawing.Color.SteelBlue
        Me.btnGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGen.Location = New System.Drawing.Point(361, 47)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(203, 47)
        Me.btnGen.TabIndex = 8
        Me.btnGen.Text = "GENERATE"
        Me.btnGen.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(54, 134)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1225, 451)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'frmGenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 727)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnGen)
        Me.Controls.Add(Me.dtgDone)
        Me.Name = "frmGenerate"
        Me.Text = "frmGenerate"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtgDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgDone As DataGridView
    Friend WithEvents btnGen As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
