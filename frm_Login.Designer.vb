<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.lbl_minimize = New System.Windows.Forms.Label()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.DBStat = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pb_adminsetting = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tb_password = New MetroFramework.Controls.MetroTextBox()
        Me.tb_username = New MetroFramework.Controls.MetroTextBox()
        Me.pb_showpass = New System.Windows.Forms.PictureBox()
        Me.pb_hidepass = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_adminsetting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_showpass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_hidepass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_minimize
        '
        Me.lbl_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_minimize.AutoSize = True
        Me.lbl_minimize.BackColor = System.Drawing.Color.Transparent
        Me.lbl_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_minimize.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minimize.ForeColor = System.Drawing.Color.White
        Me.lbl_minimize.Location = New System.Drawing.Point(293, 5)
        Me.lbl_minimize.Name = "lbl_minimize"
        Me.lbl_minimize.Size = New System.Drawing.Size(17, 23)
        Me.lbl_minimize.TabIndex = 22
        Me.lbl_minimize.Text = "-"
        '
        'lbl_close
        '
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.BackColor = System.Drawing.Color.Transparent
        Me.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_close.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.White
        Me.lbl_close.Location = New System.Drawing.Point(324, 9)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(17, 16)
        Me.lbl_close.TabIndex = 23
        Me.lbl_close.Text = "X"
        '
        'DBStat
        '
        Me.DBStat.BackColor = System.Drawing.Color.White
        Me.DBStat.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DBStat.Location = New System.Drawing.Point(0, 477)
        Me.DBStat.Name = "DBStat"
        Me.DBStat.Size = New System.Drawing.Size(350, 10)
        Me.DBStat.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(41, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 117)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "RCSS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(30, 397)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(290, 27)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CLOSE"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(30, 362)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(290, 27)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_close)
        Me.Panel1.Controls.Add(Me.lbl_minimize)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 35)
        Me.Panel1.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(99, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 17)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "USER AUTHENTICATION"
        '
        'pb_adminsetting
        '
        Me.pb_adminsetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_adminsetting.Image = Global.RCSS.My.Resources.Resources.admin_setting1
        Me.pb_adminsetting.Location = New System.Drawing.Point(162, 440)
        Me.pb_adminsetting.Name = "pb_adminsetting"
        Me.pb_adminsetting.Size = New System.Drawing.Size(27, 25)
        Me.pb_adminsetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_adminsetting.TabIndex = 71
        Me.pb_adminsetting.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.RCSS.My.Resources.Resources.information
        Me.PictureBox2.Location = New System.Drawing.Point(30, 440)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 70
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'tb_password
        '
        Me.tb_password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tb_password.CustomButton.Image = Nothing
        Me.tb_password.CustomButton.Location = New System.Drawing.Point(265, 1)
        Me.tb_password.CustomButton.Name = ""
        Me.tb_password.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.tb_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tb_password.CustomButton.TabIndex = 1
        Me.tb_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_password.CustomButton.UseSelectable = True
        Me.tb_password.CustomButton.Visible = False
        Me.tb_password.DisplayIcon = True
        Me.tb_password.Icon = Global.RCSS.My.Resources.Resources.passkey16
        Me.tb_password.Lines = New String(-1) {}
        Me.tb_password.Location = New System.Drawing.Point(30, 331)
        Me.tb_password.MaxLength = 32767
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tb_password.PromptText = "Password"
        Me.tb_password.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_password.SelectedText = ""
        Me.tb_password.SelectionLength = 0
        Me.tb_password.SelectionStart = 0
        Me.tb_password.ShortcutsEnabled = True
        Me.tb_password.Size = New System.Drawing.Size(289, 25)
        Me.tb_password.Style = MetroFramework.MetroColorStyle.Teal
        Me.tb_password.TabIndex = 1
        Me.tb_password.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_password.UseSelectable = True
        Me.tb_password.UseSystemPasswordChar = True
        Me.tb_password.WaterMark = "Password"
        Me.tb_password.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_password.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tb_username
        '
        Me.tb_username.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tb_username.CustomButton.Image = Nothing
        Me.tb_username.CustomButton.Location = New System.Drawing.Point(265, 1)
        Me.tb_username.CustomButton.Name = ""
        Me.tb_username.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.tb_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tb_username.CustomButton.TabIndex = 1
        Me.tb_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_username.CustomButton.UseSelectable = True
        Me.tb_username.CustomButton.Visible = False
        Me.tb_username.DisplayIcon = True
        Me.tb_username.Icon = Global.RCSS.My.Resources.Resources.user16gray
        Me.tb_username.Lines = New String(-1) {}
        Me.tb_username.Location = New System.Drawing.Point(30, 300)
        Me.tb_username.MaxLength = 32767
        Me.tb_username.Name = "tb_username"
        Me.tb_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_username.PromptText = "Username"
        Me.tb_username.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tb_username.SelectedText = ""
        Me.tb_username.SelectionLength = 0
        Me.tb_username.SelectionStart = 0
        Me.tb_username.ShortcutsEnabled = True
        Me.tb_username.Size = New System.Drawing.Size(289, 25)
        Me.tb_username.Style = MetroFramework.MetroColorStyle.Teal
        Me.tb_username.TabIndex = 0
        Me.tb_username.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tb_username.UseSelectable = True
        Me.tb_username.WaterMark = "Username"
        Me.tb_username.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tb_username.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pb_showpass
        '
        Me.pb_showpass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_showpass.Image = Global.RCSS.My.Resources.Resources.showpass
        Me.pb_showpass.Location = New System.Drawing.Point(323, 336)
        Me.pb_showpass.Name = "pb_showpass"
        Me.pb_showpass.Size = New System.Drawing.Size(16, 16)
        Me.pb_showpass.TabIndex = 21
        Me.pb_showpass.TabStop = False
        Me.pb_showpass.Visible = False
        '
        'pb_hidepass
        '
        Me.pb_hidepass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_hidepass.Image = Global.RCSS.My.Resources.Resources.hidepass
        Me.pb_hidepass.Location = New System.Drawing.Point(323, 336)
        Me.pb_hidepass.Name = "pb_hidepass"
        Me.pb_hidepass.Size = New System.Drawing.Size(16, 16)
        Me.pb_hidepass.TabIndex = 20
        Me.pb_hidepass.TabStop = False
        Me.pb_hidepass.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.RCSS.My.Resources.Resources.RCS_Logo_2
        Me.PictureBox1.Location = New System.Drawing.Point(36, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 216)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(30, 264)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(290, 23)
        Me.TextBox1.TabIndex = 72
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(350, 487)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.pb_adminsetting)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DBStat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pb_showpass)
        Me.Controls.Add(Me.pb_hidepass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pb_adminsetting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_showpass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_hidepass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pb_showpass As PictureBox
    Friend WithEvents pb_hidepass As PictureBox
    Friend WithEvents lbl_minimize As Label
    Friend WithEvents lbl_close As Label
    Friend WithEvents DBStat As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_username As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tb_password As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pb_adminsetting As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
