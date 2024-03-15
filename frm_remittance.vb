Imports MySql.Data.MySqlClient
Public Class frm_remittance
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()

    End Sub

    Private Sub btnNew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnNew.LinkClicked
        With frm_AddRemittance
            '.btnUpdate.Enabled = False
            .tb_salesman.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub frm_dash_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadRemittanceforApproval()
        Count()
        CountForApproval()
        CountRevise()
        CountApproved()
        CountAll()
    End Sub

    Sub LoadRemittanceforApproval()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance inner join rcss_rembd on rcss_remittance.rmt_transid = rcss_rembd.remDB_transid WHERE rcss_remittance.rmt_status = 'For Approval' OR rcss_remittance.rmt_status = 'Checking'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, Format(CDec(dr.Item("remDB_cash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_coins").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_gcash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_online").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_check").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_ar").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_return").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_bo").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_discount").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_expenses").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_total").ToString), "###,###,##0.00"), dr.Item("rmt_remarks").ToString)

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
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remittance WHERE rcss_remittance.rmt_status = 'For Approval' OR rmt_status = 'Checking'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            lblCount.Text = "(" & count & ") record/s found"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Sub CountForApproval()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remittance WHERE rmt_status = 'For Approval' OR rmt_status = 'Checking'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            LL_forApproval.Text = "For Approval/Checking (" & count & ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Sub CountRevise()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remittance WHERE rmt_status = 'For Revision'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            LL_revise.Text = "For Revision (" & count & ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Sub CountApproved()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remittance WHERE rmt_status = 'Approved'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            LL_approved.Text = "Approved (" & count & ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Sub CountAll()
        Try

            cn.Open()
            'cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remittance", cn)
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remittance inner join rcss_rembd on rcss_remittance.rmt_transid = rcss_rembd.remDB_transid", cn)

            Dim count As String
            count = cm.ExecuteScalar().ToString()
            LL_ViewAll.Text = "View All (" & count & ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString = "Checking" Then

                MessageBox.Show("Unable to edit this transaction while it's being reviewed.", "RCSS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

                If colname = "colUpdate" Then
                    With frm_AddRemittance
                        .lbl_addRemittance.Text = "EDIT REMITTANCE"
                        .btnSubmit.Visible = False
                        .btnUpdate.Visible = True

                        .tb_status.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                        .tb_edittransID.Visible = True
                        .tb_transID.Visible = False
                        .tb_edittransID.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

                        .tb_vanchoice.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString

                        .DateTimePicker1.CustomFormat = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                        .tb_salesman.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                        .tb_custodian.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString

                        .tb_cash.Text = Format(CDec(DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString), "###,###,##0.00")
                        .tb_coins.Text = Format(CDec(DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString), "###,###,##0.00")
                        .tb_gcash.Text = Format(CDec(DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString), "###,###,##0.00")
                        '.tb_online.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString
                        '.tb_check.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString
                        '.tb_AR.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString
                        .tb_return.Text = Format(CDec(DataGridView1.Rows(e.RowIndex).Cells(13).Value.ToString), "###,###,##0.00")
                        .tb_bo.Text = Format(CDec(DataGridView1.Rows(e.RowIndex).Cells(14).Value.ToString), "###,###,##0.00")
                        .tb_discount.Text = Format(CDec(DataGridView1.Rows(e.RowIndex).Cells(15).Value.ToString), "###,###,##0.00")
                        .tb_expenses.Text = Format(CDec(DataGridView1.Rows(e.RowIndex).Cells(16).Value.ToString), "###,###,##0.00")

                        '.tb_total.Text = Format(CDec(DataGridView1.Rows(e.RowIndex).Cells(17).Value.ToString), "###,###,##0.00")

                        '.tb_remarks.Text = DataGridView1.Rows(e.RowIndex).Cells(18).Value.ToString



                        'FOR Remittance Remarks
                        Try
                            .tb_remarks.Clear()
                            cn.Open()
                            cm = New MySqlCommand("SELECT * from rcss_remittance WHERE rmt_transid = '" & DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString & "'", cn)
                            dr = cm.ExecuteReader
                            While dr.Read
                                .tb_remarks.Text = dr("rmt_remarks").ToString()
                            End While

                            dr.Close()
                            cn.Close()
                        Catch ex As Exception
                            cn.Close()
                            MsgBox(ex.Message, vbCritical)
                        End Try



                        'FOR TOTAL.TEXT
                        With frm_AddRemittance
                            Try
                                Dim cash As Decimal = Decimal.Parse(.tb_cash.Text)
                                Dim coins As Decimal = Decimal.Parse(.tb_coins.Text)
                                Dim gcash As Decimal = Decimal.Parse(.tb_gcash.Text)
                                Dim online As Decimal = Decimal.Parse(.tb_online.Text)
                                Dim check As Decimal = Decimal.Parse(.tb_check.Text)
                                Dim ar As Decimal = Decimal.Parse(.tb_AR.Text)
                                Dim return1 As Decimal = Decimal.Parse(.tb_return.Text)
                                Dim bo As Decimal = Decimal.Parse(.tb_bo.Text)
                                Dim discount As Decimal = Decimal.Parse(.tb_discount.Text)
                                Dim expenses As Decimal = Decimal.Parse(.tb_expenses.Text)

                                Dim total As Decimal
                                total = cash + coins + gcash + online + check + ar + return1 + bo + discount + expenses

                                .tb_total.Text = Decimal.Parse(total)
                                .tb_total.Text = String.Format("{0:n}", Double.Parse(.tb_total.Text))

                            Catch ex As Exception

                            End Try
                        End With


                        'FOR REFERENCE #s AND AMOUNT
                        Try
                            .DataGridView1.Rows.Clear()
                            cn.Open()
                            cm = New MySqlCommand("SELECT * from rcss_remref WHERE remref_transid = '" & .tb_edittransID.Text & "'", cn)
                            dr = cm.ExecuteReader
                            While dr.Read

                                .DataGridView1.Rows.Add(dr.Item("remref_references").ToString, Format(CDec(dr.Item("remref_amount").ToString), "###,###,##0.00"))
                                Dim sum As Decimal = 0
                                For i = 0 To .DataGridView1.Rows.Count - 1
                                    sum += .DataGridView1.Rows(i).Cells(1).Value
                                Next
                                .tb_refsum.Text = Format(CDec(sum), "###,###,##0.00")
                            End While

                            dr.Close()
                            cn.Close()

                        Catch ex As Exception
                            cn.Close()
                            MsgBox(ex.Message, vbCritical)
                        End Try


                        'FOR DRIVER AND HELPER
                        Try

                            cn.Open()
                            cm = New MySqlCommand("SELECT * from rcss_remittance WHERE rmt_transid  = '" & .tb_edittransID.Text & "'", cn)
                            dr = cm.ExecuteReader
                            While dr.Read

                                .tb_driver.Text = dr.Item("rmt_driver").ToString
                                .tb_helper.Text = dr.Item("rmt_helper").ToString

                            End While
                            dr.Close()
                            cn.Close()
                        Catch ex As Exception
                            cn.Close()
                            MsgBox(ex.Message, vbCritical)
                        End Try



                        'FOR ONLINE REFERENCES
                        Try
                            .DataGridView4.Rows.Clear()
                            cn.Open()
                            cm = New MySqlCommand("SELECT * from rcss_remonline WHERE remOnline_transid = '" & .tb_edittransID.Text & "'", cn)
                            dr = cm.ExecuteReader
                            While dr.Read

                                .DataGridView4.Rows.Add(dr.Item("remOnline_Orefnum").ToString, dr.Item("remOnline_customer").ToString, dr.Item("remOnline_bank").ToString, dr.Item("remOnline_refno").ToString, Format(CDec(dr.Item("remOnline_amount").ToString), "###,###,##0.00"), dr.Item("remOnline_date").ToString)
                                Dim Osum As Decimal = 0
                                For i = 0 To .DataGridView4.Rows.Count - 1
                                    Osum += .DataGridView4.Rows(i).Cells(4).Value
                                Next

                                .tb_online.Text = Format(CDec(Osum), "###,###,##0.00")

                            End While
                            dr.Close()
                            cn.Close()
                        Catch ex As Exception
                            cn.Close()
                            MsgBox(ex.Message, vbCritical)
                        End Try


                        'FOR CHECK REFERENCES
                        Try
                            .DataGridView3.Rows.Clear()
                            cn.Open()
                            cm = New MySqlCommand("SELECT * from rcss_remcheck WHERE remcheck_transid = '" & DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString & "'", cn)
                            dr = cm.ExecuteReader
                            While dr.Read

                                .DataGridView3.Rows.Add(dr.Item("remcheck_refnum").ToString, dr.Item("remcheck_customer").ToString, dr.Item("remcheck_bank").ToString, dr.Item("remcheck_checkno").ToString, Format(CDec(dr.Item("remcheck_amount").ToString), "###,###,##0.00"), dr.Item("remcheck_date").ToString)
                                Dim Csum As Decimal = 0
                                For i = 0 To .DataGridView3.Rows.Count - 1
                                    Csum += .DataGridView3.Rows(i).Cells(4).Value
                                Next

                                .tb_check.Text = Format(CDec(Csum), "###,###,##0.00")

                            End While
                            dr.Close()
                            cn.Close()
                        Catch ex As Exception
                            cn.Close()
                            MsgBox(ex.Message, vbCritical)
                        End Try



                        'FOR AR REFERENCES
                        Try
                            .DataGridView2.Rows.Clear()
                            cn.Open()
                            cm = New MySqlCommand("SELECT * from rcss_remar WHERE remar_transid = '" & .tb_edittransID.Text & "'", cn)
                            dr = cm.ExecuteReader
                            While dr.Read

                                .DataGridView2.Rows.Add(dr.Item("remar_refnum").ToString, dr.Item("remar_invoice").ToString, dr.Item("remar_date").ToString, dr.Item("remar_customer").ToString, Format(CDec(dr.Item("remar_amount").ToString), "###,###,##0.00"))
                                Dim ARsum As Decimal = 0
                                For i = 0 To .DataGridView2.Rows.Count - 1
                                    ARsum += .DataGridView2.Rows(i).Cells(4).Value
                                Next

                                .tb_AR.Text = Format(CDec(ARsum), "###,###,##0.00")

                            End While
                            dr.Close()
                            cn.Close()
                        Catch ex As Exception
                            cn.Close()
                            MsgBox(ex.Message, vbCritical)
                        End Try



                        .ShowDialog()

                    End With

                End If
            End If

        Catch ex As Exception
            'cn.Close()
            'MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    Private Sub LL_approved_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_approved.LinkClicked

        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance inner join rcss_rembd on rcss_remittance.rmt_transid = rcss_rembd.remDB_transid WHERE rcss_remittance.rmt_status = 'Approved'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                'DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, dr.Item("remDB_cash").ToString, dr.Item("remDB_coins").ToString, dr.Item("remDB_gcash").ToString, dr.Item("remDB_online").ToString, dr.Item("remDB_check").ToString, dr.Item("remDB_ar").ToString, dr.Item("remDB_return").ToString, dr.Item("remDB_bo").ToString, dr.Item("remDB_discount").ToString, dr.Item("remDB_expenses").ToString, dr.Item("remDB_total").ToString, dr.Item("rmt_remarks").ToString)
                DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, Format(CDec(dr.Item("remDB_cash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_coins").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_gcash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_online").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_check").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_ar").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_return").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_bo").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_discount").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_expenses").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_total").ToString), "###,###,##0.00"), dr.Item("rmt_comment").ToString)
                DataGridView1.Columns("Column19").HeaderText = "COMMENT/S"
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Private Sub LL_revise_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_revise.LinkClicked
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance inner join rcss_rembd on rcss_remittance.rmt_transid = rcss_rembd.remDB_transid WHERE rcss_remittance.rmt_status = 'For Revision'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1

                'DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, dr.Item("remDB_cash").ToString, dr.Item("remDB_coins").ToString, dr.Item("remDB_gcash").ToString, dr.Item("remDB_online").ToString, dr.Item("remDB_check").ToString, dr.Item("remDB_ar").ToString, dr.Item("remDB_return").ToString, dr.Item("remDB_bo").ToString, dr.Item("remDB_discount").ToString, dr.Item("remDB_expenses").ToString, dr.Item("remDB_total").ToString, dr.Item("rmt_comment").ToString)
                DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, Format(CDec(dr.Item("remDB_cash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_coins").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_gcash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_online").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_check").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_ar").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_return").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_bo").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_discount").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_expenses").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_total").ToString), "###,###,##0.00"), dr.Item("rmt_comment").ToString)
                DataGridView1.Columns("Column19").HeaderText = "COMMENT/S"
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub LL_forApproval_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_forApproval.LinkClicked
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance inner join rcss_rembd on rcss_remittance.rmt_transid = rcss_rembd.remDB_transid WHERE rcss_remittance.rmt_status = 'For Approval'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, Format(CDec(dr.Item("remDB_cash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_coins").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_gcash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_online").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_check").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_ar").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_return").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_bo").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_discount").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_expenses").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_total").ToString), "###,###,##0.00"), dr.Item("rmt_remarks").ToString)
                DataGridView1.Columns("Column19").HeaderText = "REMARKS"
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub tb_search_Click(sender As Object, e As EventArgs) Handles tb_search.Click

    End Sub

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        If tb_search.Text = "" Then
            Try
                Dim i As Integer = 0
                DataGridView1.Rows.Clear()
                cn.Open()
                cm = New MySqlCommand("SELECT * FROM rcss_remittance inner join rcss_rembd on rcss_remittance.rmt_transid = rcss_rembd.remDB_transid WHERE rcss_remittance.rmt_status = 'For Approval' OR rcss_remittance.rmt_status = 'Checking'", cn)
                dr = cm.ExecuteReader
                While dr.Read
                    i += 1
                    DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, Format(CDec(dr.Item("remDB_cash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_coins").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_gcash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_online").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_check").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_ar").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_return").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_bo").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_discount").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_expenses").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_total").ToString), "###,###,##0.00"), dr.Item("rmt_remarks").ToString)

                End While
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                cn.Close()
            End Try
        Else
            Try
                Dim i As Integer = 0
                DataGridView1.Rows.Clear()
                cn.Open()
                cm = New MySqlCommand("SELECT * FROM rcss_remittance inner join rcss_rembd on rcss_remittance.rmt_transid = rcss_rembd.remDB_transid WHERE rcss_remittance.rmt_status = 'For Approval' OR rcss_remittance.rmt_status = 'Checking' OR rcss_remittance.rmt_status = 'For Revision' AND rcss_remittance.rmt_transid like '%" & tb_search.Text & "%'", cn)

                dr = cm.ExecuteReader
                While dr.Read
                    i += 1
                    DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, Format(CDec(dr.Item("remDB_cash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_coins").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_gcash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_online").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_check").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_ar").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_return").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_bo").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_discount").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_expenses").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_total").ToString), "###,###,##0.00"), dr.Item("rmt_remarks").ToString)

                End While
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            cn.Close()
            End Try
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub LL_ViewAll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_ViewAll.LinkClicked

        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance inner join rcss_rembd on rcss_remittance.rmt_transid = rcss_rembd.remDB_transid", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                'DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, dr.Item("remDB_cash").ToString, dr.Item("remDB_coins").ToString, dr.Item("remDB_gcash").ToString, dr.Item("remDB_online").ToString, dr.Item("remDB_check").ToString, dr.Item("remDB_ar").ToString, dr.Item("remDB_return").ToString, dr.Item("remDB_bo").ToString, dr.Item("remDB_discount").ToString, dr.Item("remDB_expenses").ToString, dr.Item("remDB_total").ToString, dr.Item("rmt_remarks").ToString)
                DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_date").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, Format(CDec(dr.Item("remDB_cash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_coins").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_gcash").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_online").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_check").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_ar").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_return").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_bo").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_discount").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_expenses").ToString), "###,###,##0.00"), Format(CDec(dr.Item("remDB_total").ToString), "###,###,##0.00"), dr.Item("rmt_comment").ToString)
                DataGridView1.Columns("Column19").HeaderText = "COMMENT/S"
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

End Class