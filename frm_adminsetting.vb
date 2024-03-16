Imports MySql.Data.MySqlClient
Public Class frm_adminsetting
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        If MsgBox("Do you want to save configuration?", vbYesNo + vbQuestion) = vbYes Then
            config()
        Else
            Me.Dispose()
        End If

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        config()
    End Sub
    Sub config()
        My.Settings.rcssServer = tb_server.Text
        My.Settings.rcssUsername = tb_Username.Text
        My.Settings.rcssPassword = tb_Password.Text
        My.Settings.rcssDBName = tb_DBName.Text
        My.Settings.Save()
        MsgBox("Server Configuration saved!", MsgBoxStyle.Information, MsgBoxResult.Ok)
        Application.Restart()
    End Sub

    Private Sub frm_adminsetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        tb_SAusername.Focus()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim _fullname As String = ""
        Try
            Dim found As Boolean = False
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM superadmin_tb where sa_username = @sa_username AND sa_password = @sa_password", cn)

            With cm
                .Parameters.AddWithValue("@sa_username", tb_SAusername.Text)
                .Parameters.AddWithValue("@sa_password", tb_SApassword.Text)
                dr = cm.ExecuteReader
                dr.Read()

                If (dr.HasRows) Then

                    found = True
                    _fullname = dr("sa_fullname").ToString()

                Else
                    found = False
                End If

                dr.Close()
                cn.Close()

            End With

            If found = True Then
                MsgBox("WELCOME BACK " & _fullname.ToUpper & " !", vbInformation)

                tb_SAusername.Clear()
                tb_SApassword.Clear()
                panelLogin.Visible = False

            Else
                MessageBox.Show("Invalid username or Password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tb_SAusername.Clear()
                tb_SApassword.Clear()
                tb_SAusername.Focus()
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()

    End Sub
End Class