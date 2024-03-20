<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddRemIn
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtp_year = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_day = New System.Windows.Forms.Label()
        Me.dtp_month = New System.Windows.Forms.Label()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.tb_IHtransID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tb_total = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_price = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_customer = New System.Windows.Forms.ComboBox()
        Me.tb_qty = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_customer = New System.Windows.Forms.TextBox()
        Me.btn_AddItem = New System.Windows.Forms.Button()
        Me.tb_item = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_status = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_GrandTotal = New System.Windows.Forms.Label()
        Me.lbl_counterItemDisplay = New System.Windows.Forms.Label()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.lbl_counter = New System.Windows.Forms.Label()
        Me.lbl_couterItem = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_remarks = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.dtp_year)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtp_day)
        Me.Panel1.Controls.Add(Me.dtp_month)
        Me.Panel1.Controls.Add(Me.lbl_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 35)
        Me.Panel1.TabIndex = 70
        '
        'dtp_year
        '
        Me.dtp_year.AutoSize = True
        Me.dtp_year.ForeColor = System.Drawing.Color.White
        Me.dtp_year.Location = New System.Drawing.Point(497, 15)
        Me.dtp_year.Name = "dtp_year"
        Me.dtp_year.Size = New System.Drawing.Size(29, 13)
        Me.dtp_year.TabIndex = 118
        Me.dtp_year.Text = "Year"
        Me.dtp_year.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 30)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "INHOUSE REMITTANCE"
        '
        'dtp_day
        '
        Me.dtp_day.AutoSize = True
        Me.dtp_day.ForeColor = System.Drawing.Color.White
        Me.dtp_day.Location = New System.Drawing.Point(398, 15)
        Me.dtp_day.Name = "dtp_day"
        Me.dtp_day.Size = New System.Drawing.Size(26, 13)
        Me.dtp_day.TabIndex = 117
        Me.dtp_day.Text = "Day"
        Me.dtp_day.Visible = False
        '
        'dtp_month
        '
        Me.dtp_month.AutoSize = True
        Me.dtp_month.ForeColor = System.Drawing.Color.White
        Me.dtp_month.Location = New System.Drawing.Point(287, 15)
        Me.dtp_month.Name = "dtp_month"
        Me.dtp_month.Size = New System.Drawing.Size(37, 13)
        Me.dtp_month.TabIndex = 116
        Me.dtp_month.Text = "Month"
        Me.dtp_month.Visible = False
        '
        'lbl_close
        '
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.BackColor = System.Drawing.Color.Transparent
        Me.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_close.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.White
        Me.lbl_close.Location = New System.Drawing.Point(996, 9)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(17, 16)
        Me.lbl_close.TabIndex = 23
        Me.lbl_close.Text = "X"
        '
        'tb_IHtransID
        '
        Me.tb_IHtransID.BackColor = System.Drawing.Color.White
        Me.tb_IHtransID.Enabled = False
        Me.tb_IHtransID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_IHtransID.Location = New System.Drawing.Point(149, 68)
        Me.tb_IHtransID.Name = "tb_IHtransID"
        Me.tb_IHtransID.ReadOnly = True
        Me.tb_IHtransID.Size = New System.Drawing.Size(269, 27)
        Me.tb_IHtransID.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(32, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Transaction No."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tb_total)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tb_price)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cb_customer)
        Me.GroupBox1.Controls.Add(Me.tb_qty)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tb_customer)
        Me.GroupBox1.Controls.Add(Me.btn_AddItem)
        Me.GroupBox1.Controls.Add(Me.tb_item)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tb_status)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tb_IHtransID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 353)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        '
        'tb_total
        '
        Me.tb_total.BackColor = System.Drawing.Color.White
        Me.tb_total.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_total.ForeColor = System.Drawing.Color.Maroon
        Me.tb_total.Location = New System.Drawing.Point(149, 266)
        Me.tb_total.Name = "tb_total"
        Me.tb_total.ReadOnly = True
        Me.tb_total.Size = New System.Drawing.Size(269, 27)
        Me.tb_total.TabIndex = 112
        Me.tb_total.Text = "0.00"
        Me.tb_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(32, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 20)
        Me.Label8.TabIndex = 111
        Me.Label8.Text = "Total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_price
        '
        Me.tb_price.BackColor = System.Drawing.Color.White
        Me.tb_price.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_price.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_price.Location = New System.Drawing.Point(149, 200)
        Me.tb_price.Name = "tb_price"
        Me.tb_price.Size = New System.Drawing.Size(269, 27)
        Me.tb_price.TabIndex = 3
        Me.tb_price.Text = "0.00"
        Me.tb_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(32, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 20)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Price"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_customer
        '
        Me.cb_customer.BackColor = System.Drawing.Color.White
        Me.cb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_customer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_customer.FormattingEnabled = True
        Me.cb_customer.Location = New System.Drawing.Point(149, 1)
        Me.cb_customer.Name = "cb_customer"
        Me.cb_customer.Size = New System.Drawing.Size(269, 28)
        Me.cb_customer.TabIndex = 105
        Me.cb_customer.Visible = False
        '
        'tb_qty
        '
        Me.tb_qty.BackColor = System.Drawing.Color.White
        Me.tb_qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_qty.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_qty.Location = New System.Drawing.Point(149, 233)
        Me.tb_qty.Name = "tb_qty"
        Me.tb_qty.Size = New System.Drawing.Size(269, 27)
        Me.tb_qty.TabIndex = 4
        Me.tb_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(32, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_customer
        '
        Me.tb_customer.BackColor = System.Drawing.Color.White
        Me.tb_customer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_customer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_customer.Location = New System.Drawing.Point(149, 134)
        Me.tb_customer.Name = "tb_customer"
        Me.tb_customer.Size = New System.Drawing.Size(269, 27)
        Me.tb_customer.TabIndex = 1
        '
        'btn_AddItem
        '
        Me.btn_AddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_AddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AddItem.FlatAppearance.BorderSize = 0
        Me.btn_AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddItem.ForeColor = System.Drawing.Color.White
        Me.btn_AddItem.Location = New System.Drawing.Point(304, 299)
        Me.btn_AddItem.Name = "btn_AddItem"
        Me.btn_AddItem.Size = New System.Drawing.Size(114, 37)
        Me.btn_AddItem.TabIndex = 5
        Me.btn_AddItem.Text = "ADD ITEM  >>"
        Me.btn_AddItem.UseVisualStyleBackColor = False
        '
        'tb_item
        '
        Me.tb_item.BackColor = System.Drawing.Color.White
        Me.tb_item.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_item.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_item.Location = New System.Drawing.Point(149, 167)
        Me.tb_item.Name = "tb_item"
        Me.tb_item.Size = New System.Drawing.Size(269, 27)
        Me.tb_item.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Ordered Item/s"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_status
        '
        Me.tb_status.BackColor = System.Drawing.Color.White
        Me.tb_status.Enabled = False
        Me.tb_status.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_status.Location = New System.Drawing.Point(149, 35)
        Me.tb_status.Name = "tb_status"
        Me.tb_status.ReadOnly = True
        Me.tb_status.Size = New System.Drawing.Size(269, 27)
        Me.tb_status.TabIndex = 101
        Me.tb_status.Text = "For Approval"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Status"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(32, 137)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 20)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "Ordered By"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(149, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(269, 27)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(32, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 20)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(6, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(495, 263)
        Me.Panel2.TabIndex = 97
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 28
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.cusName, Me.Column6, Me.Column3, Me.Column2, Me.colDelete})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.Gray
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(495, 263)
        Me.DataGridView1.TabIndex = 9
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "#"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 36
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.FillWeight = 317.8082!
        Me.Column1.HeaderText = "ORDERED BY"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 97
        '
        'cusName
        '
        Me.cusName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cusName.HeaderText = "ORDERED ITEM"
        Me.cusName.Name = "cusName"
        Me.cusName.Width = 111
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column6.HeaderText = "PRICE"
        Me.Column6.Name = "Column6"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "QUANTITY"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 84
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "TOTAL PRICE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 96
        '
        'colDelete
        '
        Me.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDelete.HeaderText = ""
        Me.colDelete.Image = Global.RCSS.My.Resources.Resources.delete16_2_
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ToolTipText = "SEE DETAILS"
        Me.colDelete.Width = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Location = New System.Drawing.Point(494, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(507, 310)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.lbl_GrandTotal)
        Me.Panel3.Controls.Add(Me.lbl_counterItemDisplay)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 282)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(501, 25)
        Me.Panel3.TabIndex = 98
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(231, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 25)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Grand Total"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_GrandTotal
        '
        Me.lbl_GrandTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_GrandTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GrandTotal.Location = New System.Drawing.Point(354, 0)
        Me.lbl_GrandTotal.Name = "lbl_GrandTotal"
        Me.lbl_GrandTotal.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.lbl_GrandTotal.Size = New System.Drawing.Size(147, 25)
        Me.lbl_GrandTotal.TabIndex = 113
        Me.lbl_GrandTotal.Text = "0.00"
        Me.lbl_GrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_counterItemDisplay
        '
        Me.lbl_counterItemDisplay.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_counterItemDisplay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_counterItemDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_counterItemDisplay.Location = New System.Drawing.Point(0, 0)
        Me.lbl_counterItemDisplay.Name = "lbl_counterItemDisplay"
        Me.lbl_counterItemDisplay.Size = New System.Drawing.Size(167, 25)
        Me.lbl_counterItemDisplay.TabIndex = 113
        Me.lbl_counterItemDisplay.Text = "(0) Item/s found"
        Me.lbl_counterItemDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Save.FlatAppearance.BorderSize = 0
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Location = New System.Drawing.Point(878, 370)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(123, 37)
        Me.btn_Save.TabIndex = 7
        Me.btn_Save.Text = "SAVE"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Silver
        Me.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.White
        Me.btn_clear.Location = New System.Drawing.Point(749, 370)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(123, 37)
        Me.btn_clear.TabIndex = 8
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'lbl_counter
        '
        Me.lbl_counter.AutoSize = True
        Me.lbl_counter.Location = New System.Drawing.Point(478, 76)
        Me.lbl_counter.Name = "lbl_counter"
        Me.lbl_counter.Size = New System.Drawing.Size(13, 13)
        Me.lbl_counter.TabIndex = 114
        Me.lbl_counter.Text = "1"
        Me.lbl_counter.Visible = False
        '
        'lbl_couterItem
        '
        Me.lbl_couterItem.AutoSize = True
        Me.lbl_couterItem.Location = New System.Drawing.Point(478, 343)
        Me.lbl_couterItem.Name = "lbl_couterItem"
        Me.lbl_couterItem.Size = New System.Drawing.Size(13, 13)
        Me.lbl_couterItem.TabIndex = 115
        Me.lbl_couterItem.Text = "0"
        Me.lbl_couterItem.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(494, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Remarks"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tb_remarks
        '
        Me.tb_remarks.BackColor = System.Drawing.Color.White
        Me.tb_remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_remarks.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_remarks.Location = New System.Drawing.Point(557, 370)
        Me.tb_remarks.Multiline = True
        Me.tb_remarks.Name = "tb_remarks"
        Me.tb_remarks.Size = New System.Drawing.Size(186, 37)
        Me.tb_remarks.TabIndex = 6
        '
        'frm_AddRemIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1022, 425)
        Me.ControlBox = False
        Me.Controls.Add(Me.tb_remarks)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_couterItem)
        Me.Controls.Add(Me.lbl_counter)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_AddRemIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_close As Label
    Friend WithEvents tb_IHtransID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents tb_status As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tb_item As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_AddItem As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents cb_customer As ComboBox
    Friend WithEvents tb_customer As TextBox
    Friend WithEvents tb_total As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_price As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_qty As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_counterItemDisplay As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_GrandTotal As Label
    Friend WithEvents lbl_counter As Label
    Friend WithEvents lbl_couterItem As Label
    Friend WithEvents dtp_year As Label
    Friend WithEvents dtp_day As Label
    Friend WithEvents dtp_month As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tb_remarks As TextBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents cusName As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents colDelete As DataGridViewImageColumn
End Class
