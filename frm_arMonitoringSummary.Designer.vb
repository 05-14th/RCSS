<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_arMonitoringSummary
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_addRemittance = New System.Windows.Forms.Label()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dailyPicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Refresh = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_Total_AR = New System.Windows.Forms.Label()
        Me.Lbl_TotalAR = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.areaPanel = New System.Windows.Forms.Panel()
        Me.areaSelect = New System.Windows.Forms.ComboBox()
        Me.filterSelect = New System.Windows.Forms.ComboBox()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.cus_namePanel = New System.Windows.Forms.Panel()
        Me.cusSelect = New System.Windows.Forms.ComboBox()
        Me.dailyPanel = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblAR = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
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
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btn_Refresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.areaPanel.SuspendLayout()
        Me.cus_namePanel.SuspendLayout()
        Me.dailyPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_addRemittance)
        Me.Panel2.Controls.Add(Me.lbl_close)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1024, 32)
        Me.Panel2.TabIndex = 73
        '
        'lbl_addRemittance
        '
        Me.lbl_addRemittance.AutoSize = True
        Me.lbl_addRemittance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addRemittance.ForeColor = System.Drawing.Color.White
        Me.lbl_addRemittance.Location = New System.Drawing.Point(10, 7)
        Me.lbl_addRemittance.Name = "lbl_addRemittance"
        Me.lbl_addRemittance.Size = New System.Drawing.Size(308, 20)
        Me.lbl_addRemittance.TabIndex = 73
        Me.lbl_addRemittance.Text = "AR COLLECTION MONITORING SUMMARY"
        '
        'lbl_close
        '
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.BackColor = System.Drawing.Color.Transparent
        Me.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_close.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.White
        Me.lbl_close.Location = New System.Drawing.Point(995, 7)
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
        Me.Label2.Location = New System.Drawing.Point(567, 21)
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
        Me.dailyPicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dailyPicker.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dailyPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dailyPicker.Location = New System.Drawing.Point(0, 0)
        Me.dailyPicker.Name = "dailyPicker"
        Me.dailyPicker.Size = New System.Drawing.Size(205, 22)
        Me.dailyPicker.TabIndex = 190
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btn_Refresh)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Lbl_Total_AR)
        Me.Panel3.Controls.Add(Me.Lbl_TotalAR)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.areaPanel)
        Me.Panel3.Controls.Add(Me.filterSelect)
        Me.Panel3.Controls.Add(Me.btn_print)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cus_namePanel)
        Me.Panel3.Controls.Add(Me.dailyPanel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1024, 60)
        Me.Panel3.TabIndex = 72
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Refresh.Image = Global.RCSS.My.Resources.Resources.pngs
<<<<<<< HEAD
        Me.btn_Refresh.Location = New System.Drawing.Point(485, 15)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(30, 30)
=======
        Me.btn_Refresh.Location = New System.Drawing.Point(482, 14)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(34, 34)
>>>>>>> 2a06ca07a91931f18383c5584ae23eb9c9cae76c
        Me.btn_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_Refresh.TabIndex = 203
        Me.btn_Refresh.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.Location = New System.Drawing.Point(544, 13)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1, 35)
        Me.Panel6.TabIndex = 202
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Location = New System.Drawing.Point(451, 13)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 35)
        Me.Panel4.TabIndex = 201
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.Location = New System.Drawing.Point(248, 13)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 35)
        Me.Panel5.TabIndex = 200
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(346, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 198
        Me.Label3.Text = "0.00"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(334, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 199
        Me.Label4.Text = "Total AR due"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Total_AR
        '
        Me.Lbl_Total_AR.AutoSize = True
        Me.Lbl_Total_AR.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Total_AR.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_Total_AR.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total_AR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_Total_AR.Location = New System.Drawing.Point(81, 30)
        Me.Lbl_Total_AR.Name = "Lbl_Total_AR"
        Me.Lbl_Total_AR.Size = New System.Drawing.Size(32, 17)
        Me.Lbl_Total_AR.TabIndex = 84
        Me.Lbl_Total_AR.Text = "0.00"
        Me.Lbl_Total_AR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_TotalAR
        '
        Me.Lbl_TotalAR.AutoSize = True
        Me.Lbl_TotalAR.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_TotalAR.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_TotalAR.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lbl_TotalAR.Location = New System.Drawing.Point(69, 8)
        Me.Lbl_TotalAR.Name = "Lbl_TotalAR"
        Me.Lbl_TotalAR.Size = New System.Drawing.Size(150, 20)
        Me.Lbl_TotalAR.TabIndex = 84
        Me.Lbl_TotalAR.Text = "Total Amount of AR"
        Me.Lbl_TotalAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RCSS.My.Resources.Resources._2
        Me.PictureBox2.Location = New System.Drawing.Point(282, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 197
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RCSS.My.Resources.Resources._1
        Me.PictureBox1.Location = New System.Drawing.Point(10, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 196
        Me.PictureBox1.TabStop = False
        '
        'areaPanel
        '
        Me.areaPanel.Controls.Add(Me.areaSelect)
        Me.areaPanel.Location = New System.Drawing.Point(737, 21)
        Me.areaPanel.Name = "areaPanel"
        Me.areaPanel.Size = New System.Drawing.Size(205, 27)
        Me.areaPanel.TabIndex = 195
        Me.areaPanel.Visible = False
        '
        'areaSelect
        '
        Me.areaSelect.Dock = System.Windows.Forms.DockStyle.Top
        Me.areaSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.areaSelect.FormattingEnabled = True
        Me.areaSelect.Location = New System.Drawing.Point(0, 0)
        Me.areaSelect.Name = "areaSelect"
        Me.areaSelect.Size = New System.Drawing.Size(205, 21)
        Me.areaSelect.TabIndex = 194
        '
        'filterSelect
        '
        Me.filterSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.filterSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterSelect.FormattingEnabled = True
        Me.filterSelect.Items.AddRange(New Object() {"VIEW ALL", "DAILY", "AREA", "CUSTOMER"})
        Me.filterSelect.Location = New System.Drawing.Point(629, 21)
        Me.filterSelect.Name = "filterSelect"
        Me.filterSelect.Size = New System.Drawing.Size(102, 21)
        Me.filterSelect.TabIndex = 193
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_print.FlatAppearance.BorderSize = 0
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.White
        Me.btn_print.Image = Global.RCSS.My.Resources.Resources.printer
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print.Location = New System.Drawing.Point(948, 6)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(69, 49)
        Me.btn_print.TabIndex = 192
        Me.btn_print.Text = "PRINT"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'cus_namePanel
        '
        Me.cus_namePanel.Controls.Add(Me.cusSelect)
<<<<<<< HEAD
        Me.cus_namePanel.Location = New System.Drawing.Point(737, 21)
        Me.cus_namePanel.Name = "cus_namePanel"
        Me.cus_namePanel.Size = New System.Drawing.Size(205, 27)
=======
        Me.cus_namePanel.Location = New System.Drawing.Point(797, 21)
        Me.cus_namePanel.Name = "cus_namePanel"
        Me.cus_namePanel.Size = New System.Drawing.Size(145, 27)
>>>>>>> 2a06ca07a91931f18383c5584ae23eb9c9cae76c
        Me.cus_namePanel.TabIndex = 79
        Me.cus_namePanel.Visible = False
        '
        'cusSelect
        '
        Me.cusSelect.Dock = System.Windows.Forms.DockStyle.Top
        Me.cusSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cusSelect.FormattingEnabled = True
        Me.cusSelect.Location = New System.Drawing.Point(0, 0)
        Me.cusSelect.Name = "cusSelect"
<<<<<<< HEAD
        Me.cusSelect.Size = New System.Drawing.Size(205, 21)
=======
        Me.cusSelect.Size = New System.Drawing.Size(145, 21)
>>>>>>> 2a06ca07a91931f18383c5584ae23eb9c9cae76c
        Me.cusSelect.TabIndex = 0
        '
        'dailyPanel
        '
        Me.dailyPanel.Controls.Add(Me.dailyPicker)
        Me.dailyPanel.Location = New System.Drawing.Point(737, 21)
        Me.dailyPanel.Name = "dailyPanel"
        Me.dailyPanel.Size = New System.Drawing.Size(205, 27)
        Me.dailyPanel.TabIndex = 75
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
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
        Me.Panel1.Size = New System.Drawing.Size(1024, 30)
        Me.Panel1.TabIndex = 81
        '
        'lblTotalDue
        '
        Me.lblTotalDue.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTotalDue.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotalDue.Location = New System.Drawing.Point(661, 0)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(198, 30)
        Me.lblTotalDue.TabIndex = 2
        Me.lblTotalDue.Text = "Total Amount Due: 0"
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAR
        '
        Me.lblAR.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblAR.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAR.Location = New System.Drawing.Point(859, 0)
        Me.lblAR.Name = "lblAR"
        Me.lblAR.Size = New System.Drawing.Size(165, 30)
        Me.lblAR.TabIndex = 1
        Me.lblAR.Text = "Total AR: 0"
        Me.lblAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
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
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.Gray
        Me.DataGridView2.Location = New System.Drawing.Point(0, 92)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 30
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1024, 289)
        Me.DataGridView2.TabIndex = 83
        '
        'cus_name
        '
        Me.cus_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cus_name.HeaderText = "CUSTOMER NAME"
        Me.cus_name.Name = "cus_name"
        Me.cus_name.ReadOnly = True
        '
        'cus_number
        '
        Me.cus_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cus_number.HeaderText = "CUSTOMER NUMBER"
        Me.cus_number.Name = "cus_number"
        Me.cus_number.ReadOnly = True
        Me.cus_number.Width = 140
        '
        'area
        '
        Me.area.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.area.DefaultCellStyle = DataGridViewCellStyle2
        Me.area.HeaderText = "AREA"
        Me.area.Name = "area"
        Me.area.ReadOnly = True
        '
        'term
        '
        Me.term.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.term.HeaderText = "TERM"
        Me.term.Name = "term"
        Me.term.ReadOnly = True
        Me.term.Width = 60
        '
        'ar_date
        '
        Me.ar_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ar_date.HeaderText = "AR DATE"
        Me.ar_date.Name = "ar_date"
        Me.ar_date.ReadOnly = True
        Me.ar_date.Width = 73
        '
        'arNum
        '
        Me.arNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.arNum.FillWeight = 150.0!
        Me.arNum.HeaderText = "AR NUMBER"
        Me.arNum.Name = "arNum"
        Me.arNum.ReadOnly = True
        Me.arNum.Width = 94
        '
        'amount
        '
        Me.amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.amount.DefaultCellStyle = DataGridViewCellStyle3
        Me.amount.HeaderText = "AMOUNT"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Width = 79
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "DAYS"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 56
        '
        'days
        '
        Me.days.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.days.HeaderText = "DUE DATE"
        Me.days.Name = "days"
        Me.days.ReadOnly = True
        Me.days.Width = 81
        '
        're
        '
        Me.re.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.re.HeaderText = "REMARKS"
        Me.re.Name = "re"
        Me.re.ReadOnly = True
        '
        'salesman
        '
        Me.salesman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.salesman.HeaderText = "SALESMAN"
        Me.salesman.Name = "salesman"
        Me.salesman.ReadOnly = True
        Me.salesman.Width = 86
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "STATUS"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 67
        '
        'settlement_date
        '
        Me.settlement_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.settlement_date.HeaderText = "DATE"
        Me.settlement_date.Name = "settlement_date"
        Me.settlement_date.ReadOnly = True
        Me.settlement_date.Width = 56
        '
        'frm_arMonitoringSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 411)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_arMonitoringSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.btn_Refresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.areaPanel.ResumeLayout(False)
        Me.cus_namePanel.ResumeLayout(False)
        Me.dailyPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_addRemittance As Label
    Friend WithEvents lbl_close As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dailyPicker As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_print As Button
    Friend WithEvents filterSelect As ComboBox
    Friend WithEvents dailyPanel As Panel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents cus_namePanel As Panel
    Friend WithEvents areaPanel As Panel
    Friend WithEvents areaSelect As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblAR As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents cusSelect As ComboBox
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_Total_AR As Label
    Friend WithEvents Lbl_TotalAR As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_Refresh As PictureBox
    Friend WithEvents Panel6 As Panel
End Class
