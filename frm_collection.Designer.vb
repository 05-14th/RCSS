<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_collection
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrint = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_ColPrint = New System.Windows.Forms.Button()
        Me.LL_Refresh = New System.Windows.Forms.LinkLabel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tb_search = New MetroFramework.Controls.MetroTextBox()
        Me.LL_Collected = New System.Windows.Forms.LinkLabel()
        Me.LL_Processing = New System.Windows.Forms.LinkLabel()
        Me.btnNew = New System.Windows.Forms.LinkLabel()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.LL_Partial = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 35)
        Me.Panel1.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 30)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "COLLECTION"
        '
        'lbl_close
        '
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.BackColor = System.Drawing.Color.Transparent
        Me.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_close.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.White
        Me.lbl_close.Location = New System.Drawing.Point(1254, 9)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(17, 16)
        Me.lbl_close.TabIndex = 23
        Me.lbl_close.Text = "X"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(12, 8)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(93, 15)
        Me.lblCount.TabIndex = 0
        Me.lblCount.Text = "(0) record found"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 71)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1280, 503)
        Me.Panel3.TabIndex = 74
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeight = 28
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column20, Me.Column4, Me.col_code, Me.Column10, Me.Column3, Me.Column5, Me.Column8, Me.Column6, Me.Column9, Me.Column11, Me.Column1, Me.Column7, Me.colPrint})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.Gray
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1280, 503)
        Me.DataGridView1.TabIndex = 70
        '
        'Column20
        '
        Me.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column20.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column20.HeaderText = "      #"
        Me.Column20.Name = "Column20"
        Me.Column20.Width = 54
        '
        'Column4
        '
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column4.HeaderText = "STATUS"
        Me.Column4.Name = "Column4"
        '
        'col_code
        '
        Me.col_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_code.FillWeight = 150.0!
        Me.col_code.HeaderText = "COLLECTION CODE"
        Me.col_code.Name = "col_code"
        Me.col_code.Width = 129
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "TO BE COLLECTED BY"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 139
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.FillWeight = 150.0!
        Me.Column3.HeaderText = "TRANSACTION NUMBER"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 155
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.FillWeight = 150.0!
        Me.Column5.HeaderText = "MANIFESTO REFERENCE NUMBER"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 205
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "AR DATE"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 73
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.FillWeight = 150.0!
        Me.Column6.HeaderText = "DELIVERY RECEIPT #"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 134
        '
        'Column9
        '
        Me.Column9.HeaderText = "AR AMOUNT"
        Me.Column9.Name = "Column9"
        '
        'Column11
        '
        Me.Column11.HeaderText = "BALANCE"
        Me.Column11.Name = "Column11"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "CUSTOMER"
        Me.Column1.Name = "Column1"
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "ADDRESS"
        Me.Column7.Name = "Column7"
        '
        'colPrint
        '
        Me.colPrint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.colPrint.DefaultCellStyle = DataGridViewCellStyle9
        Me.colPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.colPrint.HeaderText = ""
        Me.colPrint.Name = "colPrint"
        Me.colPrint.Text = "PRINT"
        Me.colPrint.ToolTipText = "PRINT"
        Me.colPrint.UseColumnTextForButtonValue = True
        Me.colPrint.Visible = False
        Me.colPrint.Width = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.lblCount)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 574)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1280, 30)
        Me.Panel4.TabIndex = 75
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.LL_Partial)
        Me.Panel2.Controls.Add(Me.btn_ColPrint)
        Me.Panel2.Controls.Add(Me.LL_Refresh)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.tb_search)
        Me.Panel2.Controls.Add(Me.LL_Collected)
        Me.Panel2.Controls.Add(Me.LL_Processing)
        Me.Panel2.Controls.Add(Me.btnNew)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1280, 36)
        Me.Panel2.TabIndex = 73
        '
        'btn_ColPrint
        '
        Me.btn_ColPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ColPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btn_ColPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ColPrint.FlatAppearance.BorderSize = 0
        Me.btn_ColPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ColPrint.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ColPrint.ForeColor = System.Drawing.Color.White
        Me.btn_ColPrint.Image = Global.RCSS.My.Resources.Resources.printer
        Me.btn_ColPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ColPrint.Location = New System.Drawing.Point(1202, 5)
        Me.btn_ColPrint.Name = "btn_ColPrint"
        Me.btn_ColPrint.Size = New System.Drawing.Size(72, 27)
        Me.btn_ColPrint.TabIndex = 193
        Me.btn_ColPrint.Text = "PRINT"
        Me.btn_ColPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ColPrint.UseVisualStyleBackColor = False
        '
        'LL_Refresh
        '
        Me.LL_Refresh.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Refresh.AutoSize = True
        Me.LL_Refresh.BackColor = System.Drawing.Color.White
        Me.LL_Refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LL_Refresh.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Refresh.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LL_Refresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LL_Refresh.Image = Global.RCSS.My.Resources.Resources.files16
        Me.LL_Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LL_Refresh.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LL_Refresh.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Refresh.Location = New System.Drawing.Point(821, 11)
        Me.LL_Refresh.Name = "LL_Refresh"
        Me.LL_Refresh.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LL_Refresh.Size = New System.Drawing.Size(68, 15)
        Me.LL_Refresh.TabIndex = 188
        Me.LL_Refresh.TabStop = True
        Me.LL_Refresh.Text = "Refresh"
        Me.LL_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LL_Refresh.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DimGray
        Me.Panel7.Location = New System.Drawing.Point(776, 8)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1, 20)
        Me.Panel7.TabIndex = 187
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.Location = New System.Drawing.Point(591, 8)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1, 20)
        Me.Panel6.TabIndex = 186
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.Location = New System.Drawing.Point(226, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1, 20)
        Me.Panel5.TabIndex = 185
        '
        'tb_search
        '
        Me.tb_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tb_search.CustomButton.Image = Nothing
        Me.tb_search.CustomButton.Location = New System.Drawing.Point(246, 1)
        Me.tb_search.CustomButton.Name = ""
        Me.tb_search.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.tb_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tb_search.CustomButton.TabIndex = 1
        Me.tb_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_search.CustomButton.UseSelectable = True
        Me.tb_search.CustomButton.Visible = False
        Me.tb_search.DisplayIcon = True
        Me.tb_search.Icon = Global.RCSS.My.Resources.Resources.search16
        Me.tb_search.Lines = New String(-1) {}
        Me.tb_search.Location = New System.Drawing.Point(925, 6)
        Me.tb_search.MaxLength = 32767
        Me.tb_search.Name = "tb_search"
        Me.tb_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_search.PromptText = "Search collection ID here"
        Me.tb_search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_search.SelectedText = ""
        Me.tb_search.SelectionLength = 0
        Me.tb_search.SelectionStart = 0
        Me.tb_search.ShortcutsEnabled = True
        Me.tb_search.Size = New System.Drawing.Size(270, 25)
        Me.tb_search.TabIndex = 183
        Me.tb_search.UseSelectable = True
        Me.tb_search.WaterMark = "Search collection ID here"
        Me.tb_search.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_search.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'LL_Collected
        '
        Me.LL_Collected.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Collected.AutoSize = True
        Me.LL_Collected.BackColor = System.Drawing.Color.White
        Me.LL_Collected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LL_Collected.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Collected.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LL_Collected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LL_Collected.Image = Global.RCSS.My.Resources.Resources.files16
        Me.LL_Collected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LL_Collected.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LL_Collected.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Collected.Location = New System.Drawing.Point(636, 11)
        Me.LL_Collected.Name = "LL_Collected"
        Me.LL_Collected.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LL_Collected.Size = New System.Drawing.Size(96, 15)
        Me.LL_Collected.TabIndex = 182
        Me.LL_Collected.TabStop = True
        Me.LL_Collected.Text = "Collected (0)"
        Me.LL_Collected.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LL_Collected.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'LL_Processing
        '
        Me.LL_Processing.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Processing.AutoSize = True
        Me.LL_Processing.BackColor = System.Drawing.Color.White
        Me.LL_Processing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LL_Processing.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Processing.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LL_Processing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LL_Processing.Image = Global.RCSS.My.Resources.Resources.revision16
        Me.LL_Processing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LL_Processing.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LL_Processing.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Processing.Location = New System.Drawing.Point(271, 11)
        Me.LL_Processing.Name = "LL_Processing"
        Me.LL_Processing.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LL_Processing.Size = New System.Drawing.Size(105, 15)
        Me.LL_Processing.TabIndex = 182
        Me.LL_Processing.TabStop = True
        Me.LL_Processing.Text = "Processing (0)"
        Me.LL_Processing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LL_Processing.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'btnNew
        '
        Me.btnNew.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNew.AutoSize = True
        Me.btnNew.BackColor = System.Drawing.Color.White
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNew.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNew.Image = Global.RCSS.My.Resources.Resources.add16
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.btnNew.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNew.Location = New System.Drawing.Point(16, 11)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnNew.Size = New System.Drawing.Size(166, 15)
        Me.btnNew.TabIndex = 182
        Me.btnNew.TabStop = True
        Me.btnNew.Text = "&ADD NEW COLLECTION (0)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.RCSS.My.Resources.Resources.opendetails24
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ToolTipText = "SEE DETAILS"
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
        Me.btn_print.Location = New System.Drawing.Point(66, 6)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(100, 100)
        Me.btn_print.TabIndex = 192
        Me.btn_print.Text = "PRINT"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DimGray
        Me.Panel8.Location = New System.Drawing.Point(420, 8)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1, 20)
        Me.Panel8.TabIndex = 187
        '
        'LL_Partial
        '
        Me.LL_Partial.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Partial.AutoSize = True
        Me.LL_Partial.BackColor = System.Drawing.Color.White
        Me.LL_Partial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LL_Partial.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Partial.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LL_Partial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.LL_Partial.Image = Global.RCSS.My.Resources.Resources.revision16
        Me.LL_Partial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LL_Partial.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LL_Partial.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LL_Partial.Location = New System.Drawing.Point(465, 11)
        Me.LL_Partial.Name = "LL_Partial"
        Me.LL_Partial.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.LL_Partial.Size = New System.Drawing.Size(82, 15)
        Me.LL_Partial.TabIndex = 186
        Me.LL_Partial.TabStop = True
        Me.LL_Partial.Text = "Partial (0)"
        Me.LL_Partial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LL_Partial.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'frm_collection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 604)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_collection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_close As Label
    Friend WithEvents btnNew As LinkLabel
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents lblCount As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tb_search As MetroFramework.Controls.MetroTextBox
    Friend WithEvents LL_Collected As LinkLabel
    Friend WithEvents LL_Processing As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LL_Refresh As LinkLabel
    Friend WithEvents btn_ColPrint As Button
    Friend WithEvents btn_print As Button
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents col_code As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents colPrint As DataGridViewButtonColumn
    Friend WithEvents Panel8 As Panel
    Friend WithEvents LL_Partial As LinkLabel
End Class
