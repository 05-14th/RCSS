<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adminsetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adminsetting))
        Me.pb_adminsetting = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_DBName = New System.Windows.Forms.TextBox()
        Me.tb_Password = New System.Windows.Forms.TextBox()
        Me.tb_Username = New System.Windows.Forms.TextBox()
        Me.tb_server = New System.Windows.Forms.TextBox()
        CType(Me.pb_adminsetting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_adminsetting
        '
        Me.pb_adminsetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_adminsetting.Image = Global.RCSS.My.Resources.Resources.admin_setting1
        Me.pb_adminsetting.Location = New System.Drawing.Point(142, 10)
        Me.pb_adminsetting.Name = "pb_adminsetting"
        Me.pb_adminsetting.Size = New System.Drawing.Size(164, 177)
        Me.pb_adminsetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_adminsetting.TabIndex = 72
        Me.pb_adminsetting.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(45, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Password :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(45, 310)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 18)
        Me.Label20.TabIndex = 106
        Me.Label20.Text = "Username :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Server :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(402, 29)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "ADMINISTRATOR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Location = New System.Drawing.Point(24, 249)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 1)
        Me.Panel2.TabIndex = 191
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(45, 410)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 193
        Me.Label4.Text = "Database Name :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(230, 465)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(173, 29)
        Me.btn_save.TabIndex = 197
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Gainsboro
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Location = New System.Drawing.Point(48, 465)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(173, 29)
        Me.btn_close.TabIndex = 198
        Me.btn_close.Text = "CLOSE"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(21, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 20)
        Me.Label5.TabIndex = 199
        Me.Label5.Text = "Welcome Christian!"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_DBName
        '
        Me.tb_DBName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.RCSS.My.MySettings.Default, "rcssDBName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tb_DBName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_DBName.Location = New System.Drawing.Point(48, 431)
        Me.tb_DBName.Name = "tb_DBName"
        Me.tb_DBName.Size = New System.Drawing.Size(355, 26)
        Me.tb_DBName.TabIndex = 4
        Me.tb_DBName.Text = Global.RCSS.My.MySettings.Default.rcssDBName
        '
        'tb_Password
        '
        Me.tb_Password.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.RCSS.My.MySettings.Default, "rcssPassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tb_Password.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Password.Location = New System.Drawing.Point(48, 381)
        Me.tb_Password.Name = "tb_Password"
        Me.tb_Password.Size = New System.Drawing.Size(355, 26)
        Me.tb_Password.TabIndex = 3
        Me.tb_Password.Text = Global.RCSS.My.MySettings.Default.rcssPassword
        '
        'tb_Username
        '
        Me.tb_Username.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.RCSS.My.MySettings.Default, "rcssUsername", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tb_Username.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Username.Location = New System.Drawing.Point(48, 331)
        Me.tb_Username.Name = "tb_Username"
        Me.tb_Username.Size = New System.Drawing.Size(355, 26)
        Me.tb_Username.TabIndex = 2
        Me.tb_Username.Text = Global.RCSS.My.MySettings.Default.rcssUsername
        '
        'tb_server
        '
        Me.tb_server.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.RCSS.My.MySettings.Default, "rcssServer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tb_server.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_server.Location = New System.Drawing.Point(48, 281)
        Me.tb_server.Name = "tb_server"
        Me.tb_server.Size = New System.Drawing.Size(355, 26)
        Me.tb_server.TabIndex = 1
        Me.tb_server.Text = Global.RCSS.My.MySettings.Default.rcssServer
        '
        'frm_adminsetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(449, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.tb_DBName)
        Me.Controls.Add(Me.tb_Password)
        Me.Controls.Add(Me.tb_Username)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_server)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb_adminsetting)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_adminsetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pb_adminsetting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_adminsetting As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tb_server As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_Username As TextBox
    Friend WithEvents tb_DBName As TextBox
    Friend WithEvents tb_Password As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents Label5 As Label
End Class
