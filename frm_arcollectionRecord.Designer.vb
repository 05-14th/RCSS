<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_arcollectionRecord
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.lbl_addRemittance = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1265, 32)
        Me.Panel1.TabIndex = 0
        '
        'lbl_close
        '
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.BackColor = System.Drawing.Color.Transparent
        Me.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_close.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.White
        Me.lbl_close.Location = New System.Drawing.Point(1236, 7)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(17, 16)
        Me.lbl_close.TabIndex = 24
        Me.lbl_close.Text = "X"
        '
        'lbl_addRemittance
        '
        Me.lbl_addRemittance.AutoSize = True
        Me.lbl_addRemittance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addRemittance.ForeColor = System.Drawing.Color.White
        Me.lbl_addRemittance.Location = New System.Drawing.Point(10, 7)
        Me.lbl_addRemittance.Name = "lbl_addRemittance"
        Me.lbl_addRemittance.Size = New System.Drawing.Size(187, 20)
        Me.lbl_addRemittance.TabIndex = 73
        Me.lbl_addRemittance.Text = "AR COLLECTION RECORD"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_addRemittance)
        Me.Panel2.Controls.Add(Me.lbl_close)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1265, 32)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 18)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "DATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(56, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(165, 25)
        Me.DateTimePicker1.TabIndex = 190
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_print)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1265, 37)
        Me.Panel3.TabIndex = 1
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.FillWeight = 150.0!
        Me.Column6.HeaderText = "INVOICE"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.FillWeight = 150.0!
        Me.Column5.HeaderText = "REFERENCE NUMBER"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "ADDRESS"
        Me.Column7.Name = "Column7"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "CUSTOMER"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.FillWeight = 150.0!
        Me.Column3.HeaderText = "TRANSACTION NUMBER"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 155
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.FillWeight = 150.0!
        Me.Column2.HeaderText = "COLLECTION CODE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 129
        '
        'Column4
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.HeaderText = "STATUS"
        Me.Column4.Name = "Column4"
        '
        'Column20
        '
        Me.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column20.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column20.HeaderText = "      #"
        Me.Column20.Name = "Column20"
        Me.Column20.Width = 54
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView2.ColumnHeadersHeight = 28
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column20, Me.Column4, Me.Column2, Me.Column3, Me.Column1, Me.Column7, Me.Column5, Me.Column6})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.Gray
        Me.DataGridView2.Location = New System.Drawing.Point(0, 69)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 30
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1265, 381)
        Me.DataGridView2.TabIndex = 71
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_print.FlatAppearance.BorderSize = 0
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.White
        Me.btn_print.Image = Global.RCSS.My.Resources.Resources.printer
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print.Location = New System.Drawing.Point(1189, 5)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(69, 27)
        Me.btn_print.TabIndex = 191
        Me.btn_print.Text = "PRINT"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'frm_arcollectionRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 450)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_arcollectionRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_arcollectionRecord"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_addRemittance As Label
    Friend WithEvents lbl_close As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btn_print As Button
End Class
