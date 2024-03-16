Imports MySql.Data.MySqlClient
Public Class frm_Login
    Private Sub pb_showpass_Click(sender As Object, e As EventArgs) Handles pb_showpass.Click
        pb_showpass.Visible = False
        pb_hidepass.Visible = True
        tb_password.UseSystemPasswordChar = False

    End Sub

    Private Sub pb_hidepass_Click(sender As Object, e As EventArgs) Handles pb_hidepass.Click


        pb_showpass.Visible = True
        pb_hidepass.Visible = False
        tb_password.UseSystemPasswordChar = True


    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click

        If MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion) = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub lbl_minimize_Click(sender As Object, e As EventArgs) Handles lbl_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()

        dbrefresh()

    End Sub
    Sub dbrefresh()
        If ConnectToDB() = False Then
            MsgBox("Unable to connect to database! " & vbLf & "Please contact your System Administrator!", vbCritical)
            DBStat.BackColor = Color.Red
        Else
            'MsgBox("Connected to database!", vbInformation)
            DBStat.BackColor = Color.PaleTurquoise
        End If


    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim _username As String = ""
        Dim _role As String = ""
        Dim _fullname As String = ""
        Dim _id As String = ""
        Try
            Dim found As Boolean = False
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_users where u_username = @u_username AND u_password = @u_password", cn)

            With cm
                .Parameters.AddWithValue("@u_username", tb_username.Text)
                .Parameters.AddWithValue("@u_password", tb_password.Text)
                dr = cm.ExecuteReader
                dr.Read()

                If (dr.HasRows) Then

                    found = True
                    _username = dr("u_username").ToString()
                    _fullname = dr("u_fullname").ToString()
                    _role = dr("u_role").ToString()
                    _id = dr("u_id").ToString()

                Else
                    found = False
                End If

                dr.Close()
                cn.Close()

            End With

            If found = True Then
                MsgBox("WELCOME " & _fullname.ToUpper & " !", vbInformation)

                tb_username.Clear()
                tb_password.Clear()

                'frm_dashAdmin.Show()
                With frm_dashAdmin
                    .lblName.Text = _role.ToUpper & " | " & _fullname.ToUpper
                    .lbl_user.Text = _fullname.ToUpper
                    .lbl_userID.Text = _id

                    If _role = "Encoder (Settlement)" Then
                        .USERToolStripMenuItem.Enabled = False
                        .VANROUTEToolStripMenuItem.Enabled = False
                        .CUSTOMERToolStripMenuItem.Enabled = False

                        .ARMonitoringSummaryToolStripMenuItem.Enabled = False
                        .REMITTANCERECORDToolStripMenuItem.Enabled = False

                        .REMITTANCEToolStripMenuItem.Enabled = False
                        .COLLECTIONToolStripMenuItem.Enabled = False
                        .SETTLEMENTToolStripMenuItem.Enabled = True

                        .panel_close.Visible = True


                    ElseIf _role = "Encoder (Collection)" Then
                        .USERToolStripMenuItem.Enabled = False
                        .VANROUTEToolStripMenuItem.Enabled = False
                        .CUSTOMERToolStripMenuItem.Enabled = False

                        .ARMonitoringSummaryToolStripMenuItem.Enabled = False
                        .REMITTANCERECORDToolStripMenuItem.Enabled = False

                        .REMITTANCEToolStripMenuItem.Enabled = False
                        .COLLECTIONToolStripMenuItem.Enabled = True
                        .SETTLEMENTToolStripMenuItem.Enabled = False

                        .panel_close.Visible = True

                    ElseIf _role = "Encoder (Remittance)" Then
                        .USERToolStripMenuItem.Enabled = False
                        .VANROUTEToolStripMenuItem.Enabled = False
                        .CUSTOMERToolStripMenuItem.Enabled = False

                        .ARMonitoringSummaryToolStripMenuItem.Enabled = False
                        .REMITTANCERECORDToolStripMenuItem.Enabled = False

                        .REMITTANCEToolStripMenuItem.Enabled = True
                        .COLLECTIONToolStripMenuItem.Enabled = False
                        .SETTLEMENTToolStripMenuItem.Enabled = False

                        .panel_close.Visible = True

                    ElseIf _role = "Manager" Then
                        .USERToolStripMenuItem.Enabled = False
                        .VANROUTEToolStripMenuItem.Enabled = False
                        .CUSTOMERToolStripMenuItem.Enabled = False

                        .ARMonitoringSummaryToolStripMenuItem.Enabled = True
                        .REMITTANCERECORDToolStripMenuItem.Enabled = True

                        .REMITTANCEToolStripMenuItem.Enabled = True
                        .COLLECTIONToolStripMenuItem.Enabled = True
                        .SETTLEMENTToolStripMenuItem.Enabled = True

                        .panel_close.Visible = True

                    Else
                        .USERToolStripMenuItem.Enabled = True
                        .VANROUTEToolStripMenuItem.Enabled = True
                        .CUSTOMERToolStripMenuItem.Enabled = True

                        .ARMonitoringSummaryToolStripMenuItem.Enabled = True
                        .REMITTANCERECORDToolStripMenuItem.Enabled = True

                        .REMITTANCEToolStripMenuItem.Enabled = True
                        .COLLECTIONToolStripMenuItem.Enabled = True
                        .SETTLEMENTToolStripMenuItem.Enabled = True

                        .panel_close.Visible = False

                    End If


                    .Show()
                End With
                Me.Hide()

                'If _role = "INSTRUCTOR" Then
                '    MessageBox.Show("Welcome " & _fullname & "!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information)

                '    frm_dashboard.lbl_EmpID.Text = _idnum
                '    frm_dashboard.lbl_fname.Text = _fname
                '    frm_dashboard.lbl_mname.Text = _mname
                '    frm_dashboard.lbl_lname.Text = _lname
                '    frm_dashboard.lbl_fullname.Text = _fullname

                '    tb_logidnum.Clear()
                '    tb_logpass.Clear()
                '    Me.Hide()
                '    frm_dashboard.Show()

                'End If
            Else
                MessageBox.Show("Invalid username or Password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tb_username.Clear()
                tb_password.Clear()
                tb_username.Focus()
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        If MsgBox("Are you sure you want to exit?", vbYesNo + vbQuestion) = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        dbrefresh()
    End Sub

    Private Sub pb_adminsetting_Click(sender As Object, e As EventArgs) Handles pb_adminsetting.Click

        frm_adminsetting.ShowDialog()

    End Sub
End Class
