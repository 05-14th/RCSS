Public Class frm_adminsetting
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Dispose()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        My.Settings.rcssServer = tb_server.Text
        My.Settings.rcssUsername = tb_Username.Text
        My.Settings.rcssPassword = tb_Password.Text
        My.Settings.rcssDBName = tb_DBName.Text
        My.Settings.Save()
        MsgBox("Server Configuration saved!", MsgBoxStyle.Information, MsgBoxResult.Ok)
        Application.Restart()

    End Sub
End Class