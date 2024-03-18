Imports MySql.Data.MySqlClient
Public Class frm_remApproval
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub frm_remApproval_Load(sender As Object, e As EventArgs) Handles Me.Load
        Loadforapproval()
        Count()
    End Sub
    Sub Loadforapproval()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance WHERE rmt_status = 'For Approval' OR rmt_status = 'Checking'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, String.Format("{0:N2}", dr.Item("rmt_remsum")))

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Sub Count()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remittance WHERE rmt_status = 'For Approval' OR rmt_status = 'Checking'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            lblCount.Text = "(" & count & ") record/s found"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "colview" Then
            With frm_remDecide

                '.tb_status.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString

                Try
                    cn.Open()
                    cm = New MySqlCommand("UPDATE rcss_remittance SET rmt_status=@rmt_status WHERE rmt_transid=@rmt_transid", cn)

                    cm.Parameters.AddWithValue("@rmt_status", "Checking")
                    cm.Parameters.AddWithValue("@rmt_transid", DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString)
                    cm.ExecuteNonQuery()
                    cn.Close()

                    frm_dashAdmin.CountForApproval()
                    frm_dashAdmin.CountRevise()
                    frm_dashAdmin.CountApproved()
                    frm_remittance.LoadRemittanceforApproval()
                    Loadforapproval()

                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message, vbCritical)
                End Try

                .tb_transID.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

                Try

                    cn.Open()
                    cm = New MySqlCommand("SELECT * from rcss_rembd, rcss_remref, rcss_remittance WHERE remDB_transid = '" & .tb_transID.Text & "' AND remref_transid = '" & .tb_transID.Text & "' AND rmt_transid = '" & .tb_transID.Text & "'", cn)
                    dr = cm.ExecuteReader
                    While dr.Read
                        .tb_status.Text = dr.Item("rmt_status").ToString
                        '.tb_cash.Text = Format(CDec(dr.Item("remDB_cash").ToString), "###,###,##0.00")
                        .tb_cash.Text = String.Format("{0:N2}", dr.Item("remDB_cash"))
                        '.tb_coins.Text = Format(CDec(dr.Item("remDB_coins").ToString), "###,###,##0.00")
                        .tb_coins.Text = String.Format("{0:N2}", dr.Item("remDB_coins"))
                        '.tb_gcash.Text = Format(CDec(dr.Item("remDB_gcash").ToString), "###,###,##0.00")
                        .tb_gcash.Text = String.Format("{0:N2}", dr.Item("remDB_gcash"))
                        '.tb_online.Text = Format(CDec(dr.Item("remDB_online").ToString), "###,###,##0.00")
                        .tb_online.Text = String.Format("{0:N2}", dr.Item("remDB_online"))
                        '.tb_check.Text = Format(CDec(dr.Item("remDB_check").ToString), "###,###,##0.00")
                        .tb_check.Text = String.Format("{0:N2}", dr.Item("remDB_check"))
                        '.tb_AR.Text = Format(CDec(dr.Item("remDB_AR").ToString), "###,###,##0.00")
                        .tb_AR.Text = String.Format("{0:N2}", dr.Item("remDB_AR"))
                        '.tb_return.Text = Format(CDec(dr.Item("remDB_return").ToString), "###,###,##0.00")
                        .tb_return.Text = String.Format("{0:N2}", dr.Item("remDB_return"))
                        '.tb_bo.Text = Format(CDec(dr.Item("remDB_bo").ToString), "###,###,##0.00")
                        .tb_bo.Text = String.Format("{0:N2}", dr.Item("remDB_bo"))
                        '.tb_discount.Text = Format(CDec(dr.Item("remDB_discount").ToString), "###,###,##0.00")
                        .tb_discount.Text = String.Format("{0:N2}", dr.Item("remDB_discount"))
                        '.tb_expenses.Text = Format(CDec(dr.Item("remDB_expenses").ToString), "###,###,##0.00")
                        .tb_expenses.Text = String.Format("{0:N2}", dr.Item("remDB_expenses"))
                        '.tb_total.Text = Format(CDec(dr.Item("remDB_total").ToString), "###,###,##0.00")
                        .tb_total.Text = String.Format("{0:N2}", dr.Item("remDB_total"))

                        .tb_remarks.Text = dr.Item("rmt_remarks").ToString
                        .tb_comment.Text = dr.Item("rmt_comment").ToString

                        '.DataGridView1.Rows.Add(dr.Item("remref_references").ToString, Format(CDec(dr.Item("remref_amount").ToString)), "###,###,##0.00")
                        .DataGridView1.Rows.Add(dr.Item("remref_references").ToString, String.Format("{0:N2}", dr.Item("remref_amount")))

                        .tb_refsum.Text = String.Format("{0:N2}", dr.Item("remref_total"))

                    End While
                    dr.Close()
                    cn.Close()
                Catch ex As Exception
                    cn.Close()
                    MsgBox(ex.Message, vbCritical)
                End Try



                .ShowDialog()
                '.Show()
            End With

        End If
    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click


        Me.Dispose()

    End Sub

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        If tb_search.Text = "" Then
            Loadforapproval()
        Else
            Try
                Dim i As Integer = 0
                DataGridView1.Rows.Clear()
                cn.Open()
                cm = New MySqlCommand("SELECT * FROM rcss_remittance WHERE rmt_transid like '%" & tb_search.Text & "%' AND rmt_status = 'For Approval' OR rmt_status = 'Checking'", cn)
                dr = cm.ExecuteReader
                While dr.Read
                    i += 1
                    DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, String.Format("{0:N2}", dr.Item("rmt_remsum")))

                End While
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                cn.Close()
            End Try
        End If

    End Sub
End Class