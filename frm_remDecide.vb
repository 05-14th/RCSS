Imports MySql.Data.MySqlClient
Public Class frm_remDecide
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click

        Try
            cn.Open()
            cm1 = New MySqlCommand("UPDATE rcss_remittance SET rmt_status=@rmt_status WHERE rmt_transid=@rmt_transid", cn)

            cm1.Parameters.AddWithValue("@rmt_status", "For Approval")
            cm1.Parameters.AddWithValue("@rmt_transid", tb_transID.Text)
            cm1.ExecuteNonQuery()
            cn.Close()

            frm_dashAdmin.CountForApproval()
            frm_dashAdmin.CountRevise()
            frm_dashAdmin.CountApproved()
            frm_remittance.LoadRemittanceforApproval()
            frm_remApproval.Loadforapproval()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

        Me.Dispose()

    End Sub

    Private Sub frm_remDecide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Today
        DateTimePicker1.Format = DateTimePickerFormat.Custom

    End Sub

    Private Sub tb_status_TextChanged(sender As Object, e As EventArgs) Handles tb_status.TextChanged
        If tb_status.Text = "For Approval" Then
            tb_status.BackColor = Color.Orange
        ElseIf tb_status.Text = "Revise" Then
            tb_status.BackColor = Color.Red
        ElseIf tb_status.Text = "Approved" Then
            tb_status.BackColor = Color.Green
        ElseIf tb_status.Text = "Checking" Then
            tb_status.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Panel2.Visible = False
        Panel2.SendToBack()
        lbl_close.Enabled = True

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Panel2.Visible = True
        Panel2.BringToFront()
        lbl_close.Enabled = False

        Try
            Dim i As Integer = 0
            DataGridView4.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remonline WHERE remOnline_transid = '" & tb_transID.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView4.Rows.Add(i, dr.Item("remOnline_Orefnum").ToString, dr.Item("remOnline_customer").ToString, dr.Item("remOnline_bank").ToString, dr.Item("remOnline_refno").ToString, Format(CDec(dr.Item("remOnline_amount").ToString)), dr.Item("remOnline_date").ToString)
                Dim Osum As Decimal = 0
                For i = 0 To DataGridView4.Rows.Count - 1
                    Osum += DataGridView4.Rows(i).Cells(4).Value
                Next

                tb_onlinesum.Text = "TOTAL     " & Format(Osum, "0.00")

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel3.Visible = True
        Panel3.BringToFront()
        lbl_close.Enabled = False
        Try
            Dim i As Integer = 0
            DataGridView3.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remcheck WHERE remcheck_transid = '" & tb_transID.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView3.Rows.Add(i, dr.Item("remcheck_refnum").ToString, dr.Item("remcheck_customer").ToString, dr.Item("remcheck_bank").ToString, dr.Item("remcheck_checkno").ToString, Format(CDec(dr.Item("remcheck_amount").ToString)), dr.Item("remcheck_date").ToString)
                Dim Osum As Decimal = 0
                For i = 0 To DataGridView3.Rows.Count - 1
                    Osum += DataGridView3.Rows(i).Cells(4).Value
                Next

                tb_checksum.Text = "TOTAL     " & Format(Osum, "0.00")


            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub btnCheckclose_Click(sender As Object, e As EventArgs) Handles btnCheckclose.Click
        Panel3.Visible = False
        Panel3.SendToBack()
        lbl_close.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel4.Visible = True
        Panel4.BringToFront()
        lbl_close.Enabled = False
        Try
            Dim i As Integer = 0
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remar WHERE remar_transid = '" & tb_transID.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView2.Rows.Add(i, dr.Item("remar_refnum").ToString, dr.Item("remar_invoice").ToString, dr.Item("remar_date").ToString, dr.Item("remar_customer").ToString, Format(CDec(dr.Item("remar_amount").ToString)))
                Dim Osum As Decimal = 0
                For i = 0 To DataGridView2.Rows.Count - 1
                    Osum += DataGridView2.Rows(i).Cells(5).Value
                Next

                tb_ARsum.Text = "TOTAL     " & Format(Osum, "0.00")


            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub btnARclose_Click(sender As Object, e As EventArgs) Handles btnARclose.Click
        Panel4.Visible = False
        Panel4.SendToBack()
        lbl_close.Enabled = True
    End Sub

    Private Sub btnApproved_Click(sender As Object, e As EventArgs) Handles btnApproved.Click
        If MsgBox("Is this transaction approved?", vbYesNo + vbQuestion) = vbYes Then
            Try
                cn.Open()
                cm = New MySqlCommand("UPDATE rcss_remittance SET rmt_status=@rmt_status, rmt_comment=@rmt_comment, rmt_approvedby=@rmt_approvedby, rmt_approveddate=@rmt_approveddate, rmt_approvedtime=@rmt_approvedtime WHERE rmt_transid = '" & tb_transID.Text & "'", cn)

                cm.Parameters.AddWithValue("@rmt_status", "Approved")
                cm.Parameters.AddWithValue("@rmt_comment", tb_comment.Text)
                cm.Parameters.AddWithValue("@rmt_approvedby", frm_dashAdmin.lbl_userID.Text)
                cm.Parameters.AddWithValue("@rmt_approveddate", DateTimePicker1.Text)
                cm.Parameters.AddWithValue("@rmt_approvedtime", frm_dashAdmin.lbl_time.Text)
                cm.ExecuteNonQuery()
                cn.Close()

                frm_remApproval.Loadforapproval()
                frm_remApproval.Count()
                frm_remApproved.Loadapproved()
                frm_remApproved.Count()
                frm_dashAdmin.CountForApproval()
                frm_dashAdmin.CountRevise()
                frm_dashAdmin.CountApproved()

            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message, vbCritical)
            End Try


            Try
                cn.Open()
                cm = New MySqlCommand("UPDATE rcss_remar SET remar_rmtstatus = @remar_rmtstatus WHERE remar_transid = '" & tb_transID.Text & "'", cn)

                cm.Parameters.AddWithValue("@remar_rmtstatus", "Approved")
                cm.ExecuteNonQuery()
                cn.Close()

            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message, vbCritical)
            End Try


            Me.Dispose()

        End If
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub
End Class