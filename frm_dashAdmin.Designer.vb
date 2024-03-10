<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_dashAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_dashAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_minimize = New System.Windows.Forms.Label()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.lbl_userID = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PanelDock = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REMITTANCEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COLLECTIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETTLEMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REMITTANCERECORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARMonitoringSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColletionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SETTINGSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VANROUTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_approval = New System.Windows.Forms.Button()
        Me.btn_approved = New System.Windows.Forms.Button()
        Me.btn_revision = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 75)
        Me.Panel1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(370, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RCSS"
        Me.Label1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(583, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 75)
        Me.Panel2.TabIndex = 29
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.SETTINGSToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(441, 75)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.SeaShell
        Me.lblName.Location = New System.Drawing.Point(86, 40)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(250, 17)
        Me.lblName.TabIndex = 28
        Me.lblName.Text = "REMITTANCE, COLLECTION, SETTLEMENT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(85, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "R.C.S. MONITORING SYSTEM"
        '
        'lbl_minimize
        '
        Me.lbl_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_minimize.AutoSize = True
        Me.lbl_minimize.BackColor = System.Drawing.Color.Transparent
        Me.lbl_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_minimize.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minimize.ForeColor = System.Drawing.Color.Black
        Me.lbl_minimize.Location = New System.Drawing.Point(964, 691)
        Me.lbl_minimize.Name = "lbl_minimize"
        Me.lbl_minimize.Size = New System.Drawing.Size(17, 23)
        Me.lbl_minimize.TabIndex = 24
        Me.lbl_minimize.Text = "-"
        Me.lbl_minimize.Visible = False
        '
        'lbl_close
        '
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.BackColor = System.Drawing.Color.Transparent
        Me.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_close.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.Black
        Me.lbl_close.Location = New System.Drawing.Point(995, 695)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(17, 16)
        Me.lbl_close.TabIndex = 25
        Me.lbl_close.Text = "X"
        Me.lbl_close.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1024, 2)
        Me.Panel3.TabIndex = 27
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lbl_user)
        Me.Panel4.Controls.Add(Me.lbl_userID)
        Me.Panel4.Controls.Add(Me.lbl_date)
        Me.Panel4.Controls.Add(Me.lbl_time)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 681)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1024, 39)
        Me.Panel4.TabIndex = 28
        '
        'lbl_user
        '
        Me.lbl_user.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_user.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.Gold
        Me.lbl_user.Location = New System.Drawing.Point(59, 0)
        Me.lbl_user.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(270, 39)
        Me.lbl_user.TabIndex = 29
        Me.lbl_user.Text = "Username"
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_user.Visible = False
        '
        'lbl_userID
        '
        Me.lbl_userID.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_userID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_userID.ForeColor = System.Drawing.Color.Gold
        Me.lbl_userID.Location = New System.Drawing.Point(0, 0)
        Me.lbl_userID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_userID.Name = "lbl_userID"
        Me.lbl_userID.Size = New System.Drawing.Size(59, 39)
        Me.lbl_userID.TabIndex = 28
        Me.lbl_userID.Text = "User ID"
        Me.lbl_userID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_userID.Visible = False
        '
        'lbl_date
        '
        Me.lbl_date.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_date.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(435, 0)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(440, 39)
        Me.lbl_date.TabIndex = 10
        Me.lbl_date.Text = "Monday, June 15, 1992"
        Me.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_time
        '
        Me.lbl_time.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_time.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.ForeColor = System.Drawing.Color.White
        Me.lbl_time.Location = New System.Drawing.Point(875, 0)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(149, 39)
        Me.lbl_time.TabIndex = 9
        Me.lbl_time.Text = "00:00:00 am"
        Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.PanelDock)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(0, 77)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1024, 604)
        Me.Panel5.TabIndex = 29
        '
        'PanelDock
        '
        Me.PanelDock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDock.AutoScroll = True
        Me.PanelDock.Location = New System.Drawing.Point(323, 21)
        Me.PanelDock.Name = "PanelDock"
        Me.PanelDock.Size = New System.Drawing.Size(689, 562)
        Me.PanelDock.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Panel10)
        Me.Panel6.Location = New System.Drawing.Point(24, 21)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(293, 562)
        Me.Panel6.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel10.Controls.Add(Me.Panel7)
        Me.Panel10.Controls.Add(Me.Panel9)
        Me.Panel10.Controls.Add(Me.Panel8)
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(297, 562)
        Me.Panel10.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Panel7.Controls.Add(Me.btn_approval)
        Me.Panel7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel7.Location = New System.Drawing.Point(11, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(274, 106)
        Me.Panel7.TabIndex = 3
        '
        'Panel9
        '
        Me.Panel9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel9.Controls.Add(Me.btn_approved)
        Me.Panel9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel9.Location = New System.Drawing.Point(11, 248)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(274, 106)
        Me.Panel9.TabIndex = 3
        '
        'Panel8
        '
        Me.Panel8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Panel8.Controls.Add(Me.btn_revision)
        Me.Panel8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel8.Location = New System.Drawing.Point(11, 124)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(274, 106)
        Me.Panel8.TabIndex = 3
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RCSS.My.Resources.Resources.RCS_Logo_3
        Me.PictureBox1.Location = New System.Drawing.Point(18, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REMITTANCEToolStripMenuItem, Me.COLLECTIONToolStripMenuItem, Me.SETTLEMENTToolStripMenuItem})
        Me.MENUToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENUToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MENUToolStripMenuItem.Image = Global.RCSS.My.Resources.Resources.files64white
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(85, 71)
        Me.MENUToolStripMenuItem.Text = "     &FILE     "
        '
        'REMITTANCEToolStripMenuItem
        '
        Me.REMITTANCEToolStripMenuItem.Name = "REMITTANCEToolStripMenuItem"
        Me.REMITTANCEToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.REMITTANCEToolStripMenuItem.Text = "&REMITTANCE"
        '
        'COLLECTIONToolStripMenuItem
        '
        Me.COLLECTIONToolStripMenuItem.Name = "COLLECTIONToolStripMenuItem"
        Me.COLLECTIONToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.COLLECTIONToolStripMenuItem.Text = "&COLLECTION"
        '
        'SETTLEMENTToolStripMenuItem
        '
        Me.SETTLEMENTToolStripMenuItem.Name = "SETTLEMENTToolStripMenuItem"
        Me.SETTLEMENTToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SETTLEMENTToolStripMenuItem.Text = "&SETTLEMENT"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REMITTANCERECORDToolStripMenuItem, Me.ARCollectionToolStripMenuItem, Me.ARMonitoringSummaryToolStripMenuItem, Me.ColletionsToolStripMenuItem})
        Me.REPORTSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.REPORTSToolStripMenuItem.Image = Global.RCSS.My.Resources.Resources.analytics64white
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(111, 71)
        Me.REPORTSToolStripMenuItem.Text = "     &REPORTS     "
        '
        'REMITTANCERECORDToolStripMenuItem
        '
        Me.REMITTANCERECORDToolStripMenuItem.Name = "REMITTANCERECORDToolStripMenuItem"
        Me.REMITTANCERECORDToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.REMITTANCERECORDToolStripMenuItem.Text = "REMITTANCE RECORD"
        '
        'ARCollectionToolStripMenuItem
        '
        Me.ARCollectionToolStripMenuItem.Name = "ARCollectionToolStripMenuItem"
        Me.ARCollectionToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ARCollectionToolStripMenuItem.Text = "AR COLLECTION"
        '
        'ARMonitoringSummaryToolStripMenuItem
        '
        Me.ARMonitoringSummaryToolStripMenuItem.Name = "ARMonitoringSummaryToolStripMenuItem"
        Me.ARMonitoringSummaryToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ARMonitoringSummaryToolStripMenuItem.Text = "AR MONITORING SUMMARY"
        '
        'ColletionsToolStripMenuItem
        '
        Me.ColletionsToolStripMenuItem.Name = "ColletionsToolStripMenuItem"
        Me.ColletionsToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ColletionsToolStripMenuItem.Text = "COLLECTION"
        '
        'SETTINGSToolStripMenuItem
        '
        Me.SETTINGSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERToolStripMenuItem, Me.VANROUTEToolStripMenuItem, Me.CUSTOMERToolStripMenuItem})
        Me.SETTINGSToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SETTINGSToolStripMenuItem.Image = Global.RCSS.My.Resources.Resources.settings64white
        Me.SETTINGSToolStripMenuItem.Name = "SETTINGSToolStripMenuItem"
        Me.SETTINGSToolStripMenuItem.Size = New System.Drawing.Size(117, 71)
        Me.SETTINGSToolStripMenuItem.Text = "      &SETTINGS     "
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.USERToolStripMenuItem.Text = "USER"
        '
        'VANROUTEToolStripMenuItem
        '
        Me.VANROUTEToolStripMenuItem.Name = "VANROUTEToolStripMenuItem"
        Me.VANROUTEToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.VANROUTEToolStripMenuItem.Text = "VAN / ROUTE"
        '
        'CUSTOMERToolStripMenuItem
        '
        Me.CUSTOMERToolStripMenuItem.Name = "CUSTOMERToolStripMenuItem"
        Me.CUSTOMERToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CUSTOMERToolStripMenuItem.Text = "CUSTOMER"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LOGOUTToolStripMenuItem.Image = Global.RCSS.My.Resources.Resources.logout64white
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(108, 71)
        Me.LOGOUTToolStripMenuItem.Text = "     LOG&OUT     "
        '
        'btn_approval
        '
        Me.btn_approval.FlatAppearance.BorderSize = 0
        Me.btn_approval.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_approval.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_approval.ForeColor = System.Drawing.Color.White
        Me.btn_approval.Image = Global.RCSS.My.Resources.Resources.Icon_128_x_128_px__3_
        Me.btn_approval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_approval.Location = New System.Drawing.Point(0, 13)
        Me.btn_approval.Name = "btn_approval"
        Me.btn_approval.Size = New System.Drawing.Size(264, 81)
        Me.btn_approval.TabIndex = 0
        Me.btn_approval.Text = "FOR APPROVAL"
        Me.btn_approval.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_approval.UseVisualStyleBackColor = True
        '
        'btn_approved
        '
        Me.btn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approved.FlatAppearance.BorderSize = 0
        Me.btn_approved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_approved.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_approved.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_approved.Image = Global.RCSS.My.Resources.Resources.Icon_128_x_128_px
        Me.btn_approved.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_approved.Location = New System.Drawing.Point(0, 13)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(264, 81)
        Me.btn_approved.TabIndex = 2
        Me.btn_approved.Text = "APPROVED"
        Me.btn_approved.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_approved.UseVisualStyleBackColor = True
        '
        'btn_revision
        '
        Me.btn_revision.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_revision.FlatAppearance.BorderSize = 0
        Me.btn_revision.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_revision.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_revision.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_revision.Image = Global.RCSS.My.Resources.Resources.Icon_128_x_128_px__2_
        Me.btn_revision.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_revision.Location = New System.Drawing.Point(0, 13)
        Me.btn_revision.Name = "btn_revision"
        Me.btn_revision.Size = New System.Drawing.Size(264, 81)
        Me.btn_revision.TabIndex = 1
        Me.btn_revision.Text = "FOR REVISION"
        Me.btn_revision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_revision.UseVisualStyleBackColor = True
        '
        'frm_dashAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_close)
        Me.Controls.Add(Me.lbl_minimize)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_dashAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_close As Label
    Friend WithEvents lbl_minimize As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SETTINGSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REMITTANCEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COLLECTIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SETTLEMENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ARCollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ARMonitoringSummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColletionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_time As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents USERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VANROUTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUSTOMERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_date As Label
    Friend WithEvents btn_approved As Button
    Friend WithEvents btn_revision As Button
    Friend WithEvents btn_approval As Button
    Friend WithEvents lbl_userID As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PanelDock As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_user As Label
    Friend WithEvents REMITTANCERECORDToolStripMenuItem As ToolStripMenuItem
End Class
