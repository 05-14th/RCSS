<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddSettlement
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
        Me.lbl_addRemittance = New System.Windows.Forms.Label()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tb_collectionID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.tb_search = New MetroFramework.Controls.MetroTextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cb_column = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_transid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_refnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_invoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_addRemittance)
        Me.Panel1.Controls.Add(Me.lbl_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1076, 35)
        Me.Panel1.TabIndex = 70
        '
        'lbl_addRemittance
        '
        Me.lbl_addRemittance.AutoSize = True
        Me.lbl_addRemittance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_addRemittance.ForeColor = System.Drawing.Color.White
        Me.lbl_addRemittance.Location = New System.Drawing.Point(11, 7)
        Me.lbl_addRemittance.Name = "lbl_addRemittance"
        Me.lbl_addRemittance.Size = New System.Drawing.Size(139, 20)
        Me.lbl_addRemittance.TabIndex = 72
        Me.lbl_addRemittance.Text = "ADD SETTLEMENT"
        '
        'lbl_close
        '
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.BackColor = System.Drawing.Color.Transparent
        Me.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_close.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.White
        Me.lbl_close.Location = New System.Drawing.Point(1050, 9)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(17, 16)
        Me.lbl_close.TabIndex = 23
        Me.lbl_close.Text = "X"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.tb_collectionID)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.tb_search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1076, 36)
        Me.Panel2.TabIndex = 79
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(396, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 25)
        Me.Panel3.TabIndex = 187
        '
        'tb_collectionID
        '
        Me.tb_collectionID.BackColor = System.Drawing.Color.White
        Me.tb_collectionID.Enabled = False
        Me.tb_collectionID.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_collectionID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_collectionID.Location = New System.Drawing.Point(96, 7)
        Me.tb_collectionID.Name = "tb_collectionID"
        Me.tb_collectionID.ReadOnly = True
        Me.tb_collectionID.Size = New System.Drawing.Size(274, 23)
        Me.tb_collectionID.TabIndex = 186
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(10, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "Settlement No."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(937, 5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(136, 27)
        Me.btn_save.TabIndex = 184
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'tb_search
        '
        '
        '
        '
        Me.tb_search.CustomButton.Image = Nothing
        Me.tb_search.CustomButton.Location = New System.Drawing.Point(250, 1)
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
        Me.tb_search.Location = New System.Drawing.Point(423, 6)
        Me.tb_search.MaxLength = 32767
        Me.tb_search.Name = "tb_search"
        Me.tb_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_search.PromptText = "Search transaction #"
        Me.tb_search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_search.SelectedText = ""
        Me.tb_search.SelectionLength = 0
        Me.tb_search.SelectionStart = 0
        Me.tb_search.ShortcutsEnabled = True
        Me.tb_search.Size = New System.Drawing.Size(274, 25)
        Me.tb_search.TabIndex = 183
        Me.tb_search.UseSelectable = True
        Me.tb_search.WaterMark = "Search transaction #"
        Me.tb_search.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_search.WaterMarkFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cb_column, Me.Column4, Me.Column1, Me.col_transid, Me.Column2, Me.col_refnum, Me.col_invoice, Me.Column6, Me.TotalAR})
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
        Me.DataGridView1.Location = New System.Drawing.Point(0, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1076, 498)
        Me.DataGridView1.TabIndex = 80
        '
        'cb_column
        '
        Me.cb_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cb_column.HeaderText = ""
        Me.cb_column.Name = "cb_column"
        Me.cb_column.ReadOnly = True
        Me.cb_column.Width = 5
        '
        'Column4
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column4.HeaderText = "AR STATUS"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.FillWeight = 150.0!
        Me.Column1.HeaderText = "VAN DETAILS"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 95
        '
        'col_transid
        '
        Me.col_transid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.col_transid.FillWeight = 150.0!
        Me.col_transid.HeaderText = "TRANSACTION NO."
        Me.col_transid.Name = "col_transid"
        Me.col_transid.ReadOnly = True
        Me.col_transid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.col_transid.Width = 128
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.FillWeight = 150.0!
        Me.Column2.HeaderText = "DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 56
        '
        'col_refnum
        '
        Me.col_refnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_refnum.FillWeight = 150.0!
        Me.col_refnum.HeaderText = "REFERENCE NUMBER"
        Me.col_refnum.Name = "col_refnum"
        Me.col_refnum.ReadOnly = True
        '
        'col_invoice
        '
        Me.col_invoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_invoice.FillWeight = 150.0!
        Me.col_invoice.HeaderText = "INVOICE"
        Me.col_invoice.Name = "col_invoice"
        Me.col_invoice.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.FillWeight = 150.0!
        Me.Column6.HeaderText = "CUSTOMER"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'TotalAR
        '
        Me.TotalAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TotalAR.DefaultCellStyle = DataGridViewCellStyle3
        Me.TotalAR.HeaderText = "TOTAL AR AMOUNT"
        Me.TotalAR.Name = "TotalAR"
        Me.TotalAR.ReadOnly = True
        Me.TotalAR.Width = 131
        '
        'frm_AddSettlement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 569)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_AddSettlement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_addRemittance As Label
    Friend WithEvents lbl_close As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tb_collectionID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents tb_search As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cb_column As DataGridViewCheckBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents col_transid As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents col_refnum As DataGridViewTextBoxColumn
    Friend WithEvents col_invoice As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents TotalAR As DataGridViewTextBoxColumn
End Class
