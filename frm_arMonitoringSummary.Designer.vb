<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_arMonitoringSummary
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.cus_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.term = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ar_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.arNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.re = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salesman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.settlement_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_addRemittance = New System.Windows.Forms.Label()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dailyPicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.filterSelect = New System.Windows.Forms.ComboBox()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.dailyPanel = New System.Windows.Forms.Panel()
        Me.monthlyPanel = New System.Windows.Forms.Panel()
        Me.weeklyPanel = New System.Windows.Forms.Panel()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.yearlyPanel = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAR = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.dailyPanel.SuspendLayout()
        Me.monthlyPanel.SuspendLayout()
        Me.weeklyPanel.SuspendLayout()
        Me.yearlyPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeight = 28
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cus_name, Me.cus_number, Me.area, Me.term, Me.ar_date, Me.arNum, Me.amount, Me.Column1, Me.days, Me.re, Me.salesman, Me.Column4, Me.settlement_date})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.Gray
        Me.DataGridView2.Location = New System.Drawing.Point(0, 69)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 30
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1249, 342)
        Me.DataGridView2.TabIndex = 74
        '
        'cus_name
        '
        Me.cus_name.HeaderText = "CUSTOMER NAME"
        Me.cus_name.Name = "cus_name"
        Me.cus_name.Width = 110
        '
        'cus_number
        '
        Me.cus_number.HeaderText = "CUSTOMER NUMBER"
        Me.cus_number.Name = "cus_number"
        Me.cus_number.Width = 109
        '
        'area
        '
        Me.area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.area.DefaultCellStyle = DataGridViewCellStyle2
        Me.area.HeaderText = "AREA"
        Me.area.Name = "area"
        Me.area.Width = 57
        '
        'term
        '
        Me.term.HeaderText = "TERM"
        Me.term.Name = "term"
        Me.term.Width = 110
        '
        'ar_date
        '
        Me.ar_date.HeaderText = "AR DATE"
        Me.ar_date.Name = "ar_date"
        Me.ar_date.Width = 110
        '
        'arNum
        '
        Me.arNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.arNum.FillWeight = 150.0!
        Me.arNum.HeaderText = "AR NUMBER"
        Me.arNum.Name = "arNum"
        Me.arNum.Width = 94
        '
        'amount
        '
        Me.amount.HeaderText = "AMOUNT"
        Me.amount.Name = "amount"
        Me.amount.Width = 109
        '
        'Column1
        '
        Me.Column1.HeaderText = "DAYS"
        Me.Column1.Name = "Column1"
        '
        'days
        '
        Me.days.HeaderText = "DUE DATE"
        Me.days.Name = "days"
        Me.days.Width = 110
        '
        're
        '
        Me.re.HeaderText = "REMARKS"
        Me.re.Name = "re"
        Me.re.Width = 110
        '
        'salesman
        '
        Me.salesman.HeaderText = "SALESMAN"
        Me.salesman.Name = "salesman"
        Me.salesman.Width = 110
        '
        'Column4
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "STATUS"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 109
        '
        'settlement_date
        '
        Me.settlement_date.HeaderText = "DATE"
        Me.settlement_date.Name = "settlement_date"
        Me.settlement_date.Width = 110
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_addRemittance)
        Me.Panel2.Controls.Add(Me.lbl_close)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1249, 32)
        Me.Panel2.TabIndex = 73
        '
        'lbl_addRemittance
        '
        Me.lbl_addRemittance.AutoSize = True
        Me.lbl_addRemittance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addRemittance.ForeColor = System.Drawing.Color.White
        Me.lbl_addRemittance.Location = New System.Drawing.Point(10, 7)
        Me.lbl_addRemittance.Name = "lbl_addRemittance"
        Me.lbl_addRemittance.Size = New System.Drawing.Size(214, 20)
        Me.lbl_addRemittance.TabIndex = 73
        Me.lbl_addRemittance.Text = "AR MONITORING SUMMARY"
        '
        'lbl_close
        '
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.BackColor = System.Drawing.Color.Transparent
        Me.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_close.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.White
        Me.lbl_close.Location = New System.Drawing.Point(1220, 7)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(17, 16)
        Me.lbl_close.TabIndex = 24
        Me.lbl_close.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "FILTER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dailyPicker
        '
        Me.dailyPicker.CalendarFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dailyPicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dailyPicker.CustomFormat = "MM/dd/yyyy"
        Me.dailyPicker.Dock = System.Windows.Forms.DockStyle.Top
        Me.dailyPicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dailyPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dailyPicker.Location = New System.Drawing.Point(0, 0)
        Me.dailyPicker.Name = "dailyPicker"
        Me.dailyPicker.Size = New System.Drawing.Size(200, 25)
        Me.dailyPicker.TabIndex = 190
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.filterSelect)
        Me.Panel3.Controls.Add(Me.yearlyPanel)
        Me.Panel3.Controls.Add(Me.btn_print)
        Me.Panel3.Controls.Add(Me.monthlyPanel)
        Me.Panel3.Controls.Add(Me.weeklyPanel)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.dailyPanel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1249, 37)
        Me.Panel3.TabIndex = 72
        '
        'filterSelect
        '
        Me.filterSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterSelect.FormattingEnabled = True
        Me.filterSelect.Items.AddRange(New Object() {"DAILY", "WEEKLY", "MONTHLY", "YEARLY"})
        Me.filterSelect.Location = New System.Drawing.Point(63, 7)
        Me.filterSelect.Name = "filterSelect"
        Me.filterSelect.Size = New System.Drawing.Size(169, 21)
        Me.filterSelect.TabIndex = 193
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
        Me.btn_print.Location = New System.Drawing.Point(1173, 5)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(69, 27)
        Me.btn_print.TabIndex = 192
        Me.btn_print.Text = "PRINT"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBox2.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 194
        '
        'dailyPanel
        '
        Me.dailyPanel.Controls.Add(Me.dailyPicker)
        Me.dailyPanel.Location = New System.Drawing.Point(238, 7)
        Me.dailyPanel.Name = "dailyPanel"
        Me.dailyPanel.Size = New System.Drawing.Size(200, 30)
        Me.dailyPanel.TabIndex = 75
        '
        'monthlyPanel
        '
        Me.monthlyPanel.Controls.Add(Me.ComboBox2)
        Me.monthlyPanel.Location = New System.Drawing.Point(649, 3)
        Me.monthlyPanel.Name = "monthlyPanel"
        Me.monthlyPanel.Size = New System.Drawing.Size(200, 30)
        Me.monthlyPanel.TabIndex = 76
        Me.monthlyPanel.Visible = False
        '
        'weeklyPanel
        '
        Me.weeklyPanel.Controls.Add(Me.ComboBox3)
        Me.weeklyPanel.Location = New System.Drawing.Point(459, 10)
        Me.weeklyPanel.Name = "weeklyPanel"
        Me.weeklyPanel.Size = New System.Drawing.Size(200, 30)
        Me.weeklyPanel.TabIndex = 77
        Me.weeklyPanel.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBox3.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox3.TabIndex = 195
        '
        'yearlyPanel
        '
        Me.yearlyPanel.Controls.Add(Me.TextBox1)
        Me.yearlyPanel.Location = New System.Drawing.Point(477, 7)
        Me.yearlyPanel.Name = "yearlyPanel"
        Me.yearlyPanel.Size = New System.Drawing.Size(200, 30)
        Me.yearlyPanel.TabIndex = 78
        Me.yearlyPanel.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblTotalDue)
        Me.Panel1.Controls.Add(Me.lblAR)
        Me.Panel1.Controls.Add(Me.lblCount)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 381)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1249, 30)
        Me.Panel1.TabIndex = 80
        '
        'lblAR
        '
        Me.lblAR.AutoSize = True
        Me.lblAR.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAR.Location = New System.Drawing.Point(456, 8)
        Me.lblAR.Name = "lblAR"
        Me.lblAR.Size = New System.Drawing.Size(64, 15)
        Me.lblAR.TabIndex = 1
        Me.lblAR.Text = "Total AR: 0"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(7, 8)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(93, 15)
        Me.lblCount.TabIndex = 0
        Me.lblCount.Text = "(0) record found"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotalDue.Location = New System.Drawing.Point(961, 8)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(116, 15)
        Me.lblTotalDue.TabIndex = 2
        Me.lblTotalDue.Text = "Total Amount Due: 0"
        '
        'frm_arMonitoringSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 411)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_arMonitoringSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.dailyPanel.ResumeLayout(False)
        Me.monthlyPanel.ResumeLayout(False)
        Me.weeklyPanel.ResumeLayout(False)
        Me.yearlyPanel.ResumeLayout(False)
        Me.yearlyPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_addRemittance As Label
    Friend WithEvents lbl_close As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dailyPicker As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_print As Button
    Friend WithEvents filterSelect As ComboBox
    Friend WithEvents cus_name As DataGridViewTextBoxColumn
    Friend WithEvents cus_number As DataGridViewTextBoxColumn
    Friend WithEvents area As DataGridViewTextBoxColumn
    Friend WithEvents term As DataGridViewTextBoxColumn
    Friend WithEvents ar_date As DataGridViewTextBoxColumn
    Friend WithEvents arNum As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents days As DataGridViewTextBoxColumn
    Friend WithEvents re As DataGridViewTextBoxColumn
    Friend WithEvents salesman As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents settlement_date As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents dailyPanel As Panel
    Friend WithEvents weeklyPanel As Panel
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents monthlyPanel As Panel
    Friend WithEvents yearlyPanel As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblAR As Label
    Friend WithEvents lblCount As Label
End Class
