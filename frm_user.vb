Imports MySql.Data.MySqlClient
Public Class frm_user
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If tb_fullname.Text = String.Empty Or tb_username.Text = String.Empty Or tb_password.Text = String.Empty Or cb_role.SelectedItem = String.Empty Then
                MessageBox.Show("Fill missing fields", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MsgBox("Do you want to save this record?", vbYesNo + vbQuestion) = vbYes Then
                    Try
                        cn.Open()
                        cm = New MySqlCommand("INSERT INTO rcss_users (u_fullname, u_username, u_password, u_role) values(@u_fullname, @u_username, @u_password, @u_role)", cn)

                        cm.Parameters.AddWithValue("@u_fullname", tb_fullname.Text)
                        cm.Parameters.AddWithValue("@u_username", tb_username.Text)
                        cm.Parameters.AddWithValue("@u_password", tb_password.Text)
                        cm.Parameters.AddWithValue("@u_role", cb_role.SelectedItem)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        tb_fullname.Clear()
                        tb_username.Clear()
                        tb_password.Clear()
                        cb_role.SelectedIndex = -1
                        tb_fullname.Focus()

                        LoadUser()

                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try
                End If
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub

    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUser()
    End Sub
    Sub LoadUser()
        Try

            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_users", cn)
            dr = cm.ExecuteReader
            While dr.Read

                DataGridView1.Rows.Add(dr.Item("u_id").ToString, dr.Item("u_fullname").ToString, dr.Item("u_username").ToString, dr.Item("u_password").ToString, dr.Item("u_role").ToString)

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
            If colname = "colUpdate" Then

                lbl_userID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                tb_fullname.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                tb_username.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                tb_password.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                cb_role.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString

                btnSubmit.Enabled = False
                btnUpdate.Enabled = True

                lbl_header.Text = "UPDATE USER"

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If MsgBox("Do you want to update this record?", vbYesNo + vbQuestion) = vbYes Then
            Try

                cn.Open()
                cm = New MySqlCommand("UPDATE rcss_users SET u_fullname=@u_fullname, u_username=@u_username, u_password=@u_password, u_role=@u_role WHERE u_id = @u_id", cn)

                cm.Parameters.AddWithValue("@u_fullname", tb_fullname.Text)
                cm.Parameters.AddWithValue("@u_username", tb_username.Text)
                cm.Parameters.AddWithValue("@u_password", tb_password.Text)
                cm.Parameters.AddWithValue("@u_role", cb_role.SelectedItem)
                cm.Parameters.AddWithValue("@u_id", lbl_userID.Text)
                cm.ExecuteNonQuery()
                cn.Close()

                LoadUser()

                MessageBox.Show("Record successfully updated!", "RCSS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message, vbCritical)

            End Try
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tb_fullname.Clear()
        tb_username.Clear()
        tb_password.Clear()
        cb_role.SelectedIndex = -1
        tb_fullname.Focus()
        lbl_header.Text = "ADD USER"
        lbl_userID.Text = "0"
        LoadUser()

        btnSubmit.Enabled = True
        btnUpdate.Enabled = False

    End Sub
End Class