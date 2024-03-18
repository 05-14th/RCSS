Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frm_AddRemittance
    Dim table As New DataTable("DataGridView1")
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        If MsgBox("Closing this window whithout saving will disregard your inputs. Do you want to continue?", vbYesNo + vbQuestion) = vbYes Then
            Me.Dispose()
        End If

    End Sub

    Private Sub RANDID()
        Randomize()
        Dim value As Integer = CInt(Int((10000 * Rnd()) + 1))
        'Dim value1 As Integer = CInt(Int((10000 * Rnd()) + 2))
        tb_transID.Text = (DateTime.Now.ToString("MM")) & (DateTime.Now.ToString("dd")) & (DateTime.Now.ToString("yy")) & value

        DateTimePicker1.Value = Date.Today
        DateTimePicker1.Format = DateTimePickerFormat.Custom

        DateTimePicker2.Value = Date.Today
        DateTimePicker2.Format = DateTimePickerFormat.Custom

        DateTimePicker3.Value = Date.Today
        DateTimePicker3.Format = DateTimePickerFormat.Custom

        DateTimePicker4.Value = Date.Today
        DateTimePicker4.Format = DateTimePickerFormat.Custom

    End Sub

    Private Sub frm_AddRemittance_Load(sender As Object, e As EventArgs) Handles Me.Load
        tb_status.TextAlign = HorizontalAlignment.Left

        RANDID()
        LoadVanList()
        tb_salesman.Focus()

    End Sub
    Sub LoadVanList()
        Try
            cb_vanname.Items.Clear()

            cn.Open()
            cm = New MySqlCommand("SELECT * from rcss_van", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cb_vanname.Items.Add(dr.Item("van_number").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub LoadCustomers()
        Try
            cb_customers.Items.Clear()

            cn.Open()
            cm = New MySqlCommand("SELECT * from rcss_customer", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cb_customers.Items.Add(dr.Item("cus_name").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If cb_vanname.SelectedItem = String.Empty Or tb_custodian.Text = String.Empty Or tb_driver.Text = String.Empty Or tb_helper.Text = String.Empty Then
                MessageBox.Show("Fill missing fields", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MsgBox("Do you want to save this record?", vbYesNo + vbQuestion) = vbYes Then

                    'FOR REMITTANCE DETAILS'
                    Try
                        cn.Open()
                        cm = New MySqlCommand("INSERT INTO rcss_remittance (rmt_transid, rmt_date, rmt_month, rmt_day, rmt_year, rmt_time, rmt_vanno, rmt_salesman, rmt_custodian, rmt_driver, rmt_helper, rmt_refsum, rmt_remsum, rmt_remarks, rmt_status, rmt_week) values(@rmt_transid, @rmt_date, @rmt_month, @rmt_day, @rmt_year, @rmt_time, @rmt_vanno, @rmt_salesman, @rmt_custodian, @rmt_driver, @rmt_helper, @rmt_refsum, @rmt_remsum, @rmt_remarks, @rmt_status, @rmt_week)", cn)

                        cm.Parameters.AddWithValue("@rmt_transid", tb_transID.Text)
                        cm.Parameters.AddWithValue("@rmt_date", DateTimePicker1.Text)
                        cm.Parameters.AddWithValue("@rmt_month", dtp_month.Text)
                        cm.Parameters.AddWithValue("@rmt_day", dtp_day.Text)
                        cm.Parameters.AddWithValue("@rmt_year", dtp_year.Text)
                        cm.Parameters.AddWithValue("@rmt_time", frm_dashAdmin.lbl_time.Text)
                        cm.Parameters.AddWithValue("@rmt_vanno", tb_vanchoice.Text)
                        cm.Parameters.AddWithValue("@rmt_salesman", tb_salesman.Text)
                        cm.Parameters.AddWithValue("@rmt_custodian", tb_custodian.Text)
                        cm.Parameters.AddWithValue("@rmt_driver", tb_driver.Text)
                        cm.Parameters.AddWithValue("@rmt_helper", tb_helper.Text)
                        cm.Parameters.AddWithValue("@rmt_refsum", CDec(tb_refsum.Text))
                        cm.Parameters.AddWithValue("@rmt_remsum", CDec(tb_total.Text))
                        cm.Parameters.AddWithValue("@rmt_remarks", tb_remarks.Text & " - " & DateTimePicker1.Text & " - " & frm_dashAdmin.lbl_time.Text & vbLf)
                        cm.Parameters.AddWithValue("@rmt_status", tb_status.Text)
                        cm.Parameters.AddWithValue("@rmt_week", CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTimePicker1.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday))
                        cm.ExecuteNonQuery()
                        cn.Close()

                        tb_salesman.Clear()
                        tb_custodian.Clear()
                        tb_driver.Clear()
                        tb_helper.Clear()
                        tb_remarks.Clear()

                        cb_vanname.SelectedIndex = -1

                        frm_dashAdmin.CountForApproval()
                        frm_dashAdmin.CountRevise()
                        frm_dashAdmin.CountApproved()
                        Console.WriteLine("Hit6")
                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try

                    'FOR REFERENCES DETAILS
                    Try
                        Dim i As Integer
                        For i = 0 To DataGridView1.RowCount - 1
                            cn.Open()
                            cm = New MySqlCommand("INSERT INTO rcss_remref (remref_transid, remref_date, remref_time, remref_references, remref_amount, remref_total) values(@remref_transid, @remref_date, @remref_time, @remref_references, @remref_amount, @remref_total)", cn)

                            cm.Parameters.AddWithValue("@remref_transid", tb_transID.Text)
                            cm.Parameters.AddWithValue("@remref_date", DateTimePicker1.Text)
                            cm.Parameters.AddWithValue("@remref_time", frm_dashAdmin.lbl_time.Text)
                            cm.Parameters.AddWithValue("@remref_references", DataGridView1.Rows(i).Cells(0).Value.ToString)
                            cm.Parameters.AddWithValue("@remref_amount", CDec(DataGridView1.Rows(i).Cells(1).Value.ToString))
                            cm.Parameters.AddWithValue("@remref_total", CDec(tb_refsum.Text))
                            cm.ExecuteNonQuery()
                            cn.Close()
                            Console.WriteLine("Hit5")
                        Next

                        DataGridView1.Rows.Clear()
                        tb_refsum.Clear()


                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try

                    'FOR REMITTANCE BREAKDOWN DETAILS
                    Try


                        cn.Open()
                        cm = New MySqlCommand("INSERT INTO rcss_rembd (remDB_transid, remDB_date, remDB_time, remDB_cash, remDB_coins, remDB_gcash, remDB_online, remDB_check, remDB_ar, remDB_return, remDB_bo, remDB_discount, remDB_expenses, remDB_total) values(@remDB_transid, @remDB_date, @remDB_time, @remDB_cash, @remDB_coins, @remDB_gcash, @remDB_online, @remDB_check, @remDB_ar, @remDB_return, @remDB_bo, @remDB_discount, @remDB_expenses, @remDB_total)", cn)

                        cm.Parameters.AddWithValue("@remDB_transid", tb_transID.Text)
                        cm.Parameters.AddWithValue("@remDB_date", DateTimePicker1.Text)
                        cm.Parameters.AddWithValue("@remDB_time", frm_dashAdmin.lbl_time.Text)
                        cm.Parameters.AddWithValue("@remDB_cash", CDec(tb_cash.Text))
                        cm.Parameters.AddWithValue("@remDB_coins", CDec(tb_coins.Text))
                        cm.Parameters.AddWithValue("@remDB_gcash", CDec(tb_gcash.Text))
                        cm.Parameters.AddWithValue("@remDB_online", CDec(tb_online.Text))
                        cm.Parameters.AddWithValue("@remDB_check", CDec(tb_check.Text))
                        cm.Parameters.AddWithValue("@remDB_ar", CDec(tb_AR.Text))
                        cm.Parameters.AddWithValue("@remDB_return", CDec(tb_return.Text))
                        cm.Parameters.AddWithValue("@remDB_bo", CDec(tb_bo.Text))
                        cm.Parameters.AddWithValue("@remDB_discount", CDec(tb_discount.Text))
                        cm.Parameters.AddWithValue("@remDB_expenses", CDec(tb_expenses.Text))
                        cm.Parameters.AddWithValue("@remDB_total", CDec(tb_total.Text))
                        cm.ExecuteNonQuery()
                        cn.Close()

                        tb_cash.Clear()
                        tb_coins.Clear()
                        tb_gcash.Clear()
                        tb_online.Clear()
                        tb_check.Clear()
                        tb_AR.Clear()
                        tb_return.Clear()
                        tb_bo.Clear()
                        tb_discount.Clear()
                        tb_expenses.Clear()
                        tb_total.Clear()
                        Console.WriteLine("Hit4")
                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try

                    'FOR ONLINE DETAILS
                    Try
                        Dim i As Integer
                        For i = 0 To DataGridView4.RowCount - 1
                            cn.Open()
                            cm = New MySqlCommand("INSERT INTO rcss_remonline (remOnline_transid, remOnline_Orefnum, remOnline_cusID, remOnline_bank, remOnline_refno, remOnline_amount, remOnline_date, remOnline_time) values(@remOnline_transid, @remOnline_Orefnum, @remOnline_cusID, @remOnline_bank, @remOnline_refno, @remOnline_amount, @remOnline_date, @remOnline_time)", cn)

                            cm.Parameters.AddWithValue("@remOnline_transid", tb_transID.Text)
                            cm.Parameters.AddWithValue("@remOnline_Orefnum", DataGridView4.Rows(i).Cells(0).Value.ToString)
                            cm.Parameters.AddWithValue("@remOnline_cusID", DataGridView4.Rows(i).Cells(1).Value.ToString)
                            cm.Parameters.AddWithValue("@remOnline_bank", DataGridView4.Rows(i).Cells(3).Value.ToString)
                            cm.Parameters.AddWithValue("@remOnline_refno", DataGridView4.Rows(i).Cells(4).Value.ToString)
                            cm.Parameters.AddWithValue("@remOnline_amount", CDec(DataGridView4.Rows(i).Cells(5).Value.ToString))
                            'cm.Parameters.AddWithValue("@remOnline_total", CDec(tb_online.Text))
                            cm.Parameters.AddWithValue("@remOnline_date", DataGridView4.Rows(i).Cells(6).Value.ToString)
                            cm.Parameters.AddWithValue("@remOnline_time", frm_dashAdmin.lbl_time.Text)
                            cm.ExecuteNonQuery()
                            cn.Close()
                            Console.WriteLine("Hit3")
                        Next

                        DataGridView4.Rows.Clear()

                    Catch ex As Exception
                        cn.Close()
                        Console.WriteLine("Hit3.1")
                        MsgBox(ex.Message, vbCritical)
                    End Try

                    'FOR CHECK DETAILS
                    Try
                        Dim i As Integer
                        For i = 0 To DataGridView3.RowCount - 1
                            cn.Open()
                            cm = New MySqlCommand("INSERT INTO rcss_remcheck (remcheck_transid , remcheck_refnum, remcheck_cusID, remcheck_bank, remcheck_checkno, remcheck_amount, remcheck_date, remcheck_time) values(@remcheck_transid , @remcheck_refnum, @remcheck_cusID, @remcheck_bank, @remcheck_checkno, @remcheck_amount, @remcheck_date, @remcheck_time)", cn)

                            cm.Parameters.AddWithValue("@remcheck_transid", tb_transID.Text)
                            cm.Parameters.AddWithValue("@remcheck_refnum", DataGridView3.Rows(i).Cells(0).Value.ToString)
                            cm.Parameters.AddWithValue("@remcheck_cusID", DataGridView3.Rows(i).Cells(1).Value.ToString)
                            cm.Parameters.AddWithValue("@remcheck_bank", DataGridView3.Rows(i).Cells(3).Value.ToString)
                            cm.Parameters.AddWithValue("@remcheck_checkno", DataGridView3.Rows(i).Cells(4).Value.ToString)
                            cm.Parameters.AddWithValue("@remcheck_amount", CDec(DataGridView3.Rows(i).Cells(5).Value.ToString))
                            'cm.Parameters.AddWithValue("@remcheck_total", CDec(tb_check.Text))
                            cm.Parameters.AddWithValue("@remcheck_date", DataGridView3.Rows(i).Cells(6).Value.ToString)
                            cm.Parameters.AddWithValue("@remcheck_time", frm_dashAdmin.lbl_time.Text)
                            cm.ExecuteNonQuery()
                            cn.Close()
                            Console.WriteLine("Hit2")
                        Next

                        DataGridView3.Rows.Clear()


                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try


                    'FOR AR DETAILS
                    Try
                        Dim i As Integer
                        For i = 0 To DataGridView2.RowCount - 1
                            cn.Open()
                            cm = New MySqlCommand("INSERT INTO rcss_remar (remar_transid, remar_rmtstatus, remar_date, remar_time, remar_refnum, remar_invoice, remar_cusID, remar_amount, remar_status) values(@remar_transid, @remar_rmtstatus, @remar_date, @remar_time, @remar_refnum, @remar_invoice, @remar_cusID, @remar_amount, @remar_status)", cn)

                            cm.Parameters.AddWithValue("@remar_transid", tb_transID.Text)
                            cm.Parameters.AddWithValue("@remar_rmtstatus", tb_status.Text)
                            cm.Parameters.AddWithValue("@remar_date", DataGridView2.Rows(i).Cells(2).Value.ToString)
                            cm.Parameters.AddWithValue("@remar_time", frm_dashAdmin.lbl_time.Text)
                            cm.Parameters.AddWithValue("@remar_refnum", DataGridView2.Rows(i).Cells(0).Value.ToString)
                            cm.Parameters.AddWithValue("@remar_invoice", DataGridView2.Rows(i).Cells(1).Value.ToString)
                            'cm.Parameters.AddWithValue("@remar_cusID", lbl_CusID.Text)
                            cm.Parameters.AddWithValue("@remar_cusID", DataGridView2.Rows(i).Cells(3).Value.ToString)
                            cm.Parameters.AddWithValue("@remar_amount", CDec(DataGridView2.Rows(i).Cells(5).Value.ToString))
                            cm.Parameters.AddWithValue("@remar_status", "Pending")
                            cm.ExecuteNonQuery()
                            cn.Close()
                            Console.WriteLine("Hit")
                        Next

                        DataGridView2.Rows.Clear()


                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try


                    RANDID()
                    frm_remittance.LoadRemittanceforApproval()
                    frm_remittance.Count()
                    MsgBox("Record successfully saved!", vbInformation)

                End If
            End If
            frm_remittance.CountForApproval()
            Me.Dispose()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            If tb_custodian.Text = String.Empty Or tb_driver.Text = String.Empty Or tb_helper.Text = String.Empty Then
                MessageBox.Show("Fill missing fields", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MsgBox("Do you want to Update this record?", vbYesNo + vbQuestion) = vbYes Then

                    'FOR REMITTANCE DETAILS
                    Try
                        cn.Open()
                        cm = New MySqlCommand("UPDATE rcss_remittance SET rmt_date=@rmt_date, rmt_time=@rmt_time, rmt_vanno=@rmt_vanno, rmt_salesman=@rmt_salesman, rmt_custodian=@rmt_custodian, rmt_driver=@rmt_driver, rmt_helper=@rmt_helper, rmt_refsum=@rmt_refsum, rmt_remsum=@rmt_remsum, rmt_remarks=@rmt_remarks, rmt_status=@rmt_status, rmt_day=@rmt_day, rmt_week=@rmt_week, rmt_month=@rmt_month, rmt_year=@rmt_year WHERE rmt_transid=@rmt_transid", cn)


                        cm.Parameters.AddWithValue("@rmt_date", DateTimePicker1.Text)
                        cm.Parameters.AddWithValue("@rmt_time", frm_dashAdmin.lbl_time.Text)
                        cm.Parameters.AddWithValue("@rmt_vanno", tb_vanchoice.Text)
                        cm.Parameters.AddWithValue("@rmt_salesman", tb_salesman.Text)
                        cm.Parameters.AddWithValue("@rmt_custodian", tb_custodian.Text)
                        cm.Parameters.AddWithValue("@rmt_driver", tb_driver.Text)
                        cm.Parameters.AddWithValue("@rmt_helper", tb_helper.Text)
                        cm.Parameters.AddWithValue("@rmt_refsum", CDec(tb_refsum.Text))
                        cm.Parameters.AddWithValue("@rmt_remsum", CDec(tb_total.Text))
                        cm.Parameters.AddWithValue("@rmt_remarks", tb_remarks.Text & " - " & DateTimePicker1.Text & " - " & frm_dashAdmin.lbl_time.Text & vbLf)
                        'cm.Parameters.AddWithValue("@rmt_status", tb_status.Text)
                        cm.Parameters.AddWithValue("@rmt_status", "For Approval")
                        cm.Parameters.AddWithValue("@rmt_transid", tb_edittransID.Text)
                        cm.Parameters.AddWithValue("@rmt_year", dtp_year.Text)
                        cm.Parameters.AddWithValue("@rmt_month", dtp_month.Text)
                        cm.Parameters.AddWithValue("@rmt_day", dtp_day.Text)
                        cm.Parameters.AddWithValue("@rmt_week", CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTimePicker1.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday))
                        cm.ExecuteNonQuery()
                        cn.Close()

                        frm_dashAdmin.CountForApproval()
                        frm_dashAdmin.CountRevise()
                        frm_dashAdmin.CountApproved()

                        frm_remittance.LoadRemittanceforApproval()
                        frm_remittance.CountForApproval()
                        frm_remittance.CountRevise()
                        frm_remittance.CountApproved()

                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try

                    'FOR REFERENCES DETAILS
                    Try

                        cn.Open()
                        cm = New MySqlCommand("DELETE FROM rcss_remref WHERE remref_transid=@remref_transid", cn)
                        cm.Parameters.AddWithValue("@remref_transid", tb_edittransID.Text)
                        cm.ExecuteNonQuery()
                        cn.Close()

                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try

                    Try
                        Dim i As Integer
                        For i = 0 To DataGridView1.RowCount - 1
                            cn.Open()
                            cm = New MySqlCommand("INSERT INTO rcss_remref (remref_transid, remref_date, remref_time, remref_references, remref_amount, remref_total) values(@remref_transid, @remref_date, @remref_time, @remref_references, @remref_amount, @remref_total)", cn)

                            cm.Parameters.AddWithValue("@remref_transid", tb_edittransID.Text)
                            cm.Parameters.AddWithValue("@remref_date", DateTimePicker1.Text)
                            cm.Parameters.AddWithValue("@remref_time", frm_dashAdmin.lbl_time.Text)
                            cm.Parameters.AddWithValue("@remref_references", DataGridView1.Rows(i).Cells(0).Value.ToString)
                            cm.Parameters.AddWithValue("@remref_amount", CDec(DataGridView1.Rows(i).Cells(1).Value.ToString))
                            cm.Parameters.AddWithValue("@remref_total", CDec(tb_refsum.Text))
                            cm.ExecuteNonQuery()
                            cn.Close()

                        Next

                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try

                    'FOR REMITTANCE BREAKDOWN DETAILS
                    Try

                        cn.Open()
                        cm = New MySqlCommand("UPDATE rcss_rembd SET remDB_date=@remDB_date, remDB_time=@remDB_time, remDB_cash=@remDB_cash, remDB_coins=@remDB_coins, remDB_gcash=@remDB_gcash, remDB_online=@remDB_online, remDB_check=@remDB_check, remDB_ar=@remDB_ar, remDB_return=@remDB_return, remDB_bo=@remDB_bo, remDB_discount=@remDB_discount, remDB_expenses=@remDB_expenses, remDB_total=@remDB_total WHERE remDB_transid=@remDB_transid", cn)

                        cm.Parameters.AddWithValue("@remDB_date", DateTimePicker1.Text)
                        cm.Parameters.AddWithValue("@remDB_time", frm_dashAdmin.lbl_time.Text)
                        cm.Parameters.AddWithValue("@remDB_cash", CDec(tb_cash.Text))
                        cm.Parameters.AddWithValue("@remDB_coins", CDec(tb_coins.Text))
                        cm.Parameters.AddWithValue("@remDB_gcash", CDec(tb_gcash.Text))
                        cm.Parameters.AddWithValue("@remDB_online", CDec(tb_online.Text))
                        cm.Parameters.AddWithValue("@remDB_check", CDec(tb_check.Text))
                        cm.Parameters.AddWithValue("@remDB_ar", CDec(tb_AR.Text))
                        cm.Parameters.AddWithValue("@remDB_return", CDec(tb_return.Text))
                        cm.Parameters.AddWithValue("@remDB_bo", CDec(tb_bo.Text))
                        cm.Parameters.AddWithValue("@remDB_discount", CDec(tb_discount.Text))
                        cm.Parameters.AddWithValue("@remDB_expenses", CDec(tb_expenses.Text))
                        cm.Parameters.AddWithValue("@remDB_total", CDec(tb_total.Text))
                        cm.Parameters.AddWithValue("@remDB_transid", tb_edittransID.Text)
                        cm.ExecuteNonQuery()
                        cn.Close()

                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try


                    'FOR ONLINE DETAILS

                    Try

                        cn.Open()
                        cm = New MySqlCommand("DELETE FROM rcss_remonline WHERE remOnline_transid=@remOnline_transid", cn)
                        cm.Parameters.AddWithValue("@remOnline_transid", tb_edittransID.Text)
                        cm.ExecuteNonQuery()
                        cn.Close()

                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try


                    Try
                        Dim i As Integer
                        For i = 0 To DataGridView4.RowCount - 1
                            cn.Open()
                            cm = New MySqlCommand("INSERT INTO rcss_remonline (remOnline_transid, remOnline_Orefnum, remOnline_cusID, remOnline_bank, remOnline_refno, remOnline_amount, remOnline_date, remOnline_time) values(@remOnline_transid, @remOnline_Orefnum, @remOnline_cusID, @remOnline_bank, @remOnline_refno, @remOnline_amount, @remOnline_date, @remOnline_time)", cn)

                            cm.Parameters.AddWithValue("@remOnline_transid", tb_transID.Text)
                            cm.Parameters.AddWithValue("@remOnline_Orefnum", DataGridView4.Rows(i).Cells(0).Value.ToString)
                            cm.Parameters.AddWithValue("@remOnline_cusID", DataGridView4.Rows(i).Cells(1).Value.ToString)
                            cm.Parameters.AddWithValue("@remOnline_bank", DataGridView4.Rows(i).Cells(3).Value.ToString)
                            cm.Parameters.AddWithValue("@remOnline_refno", DataGridView4.Rows(i).Cells(4).Value.ToString)
                            cm.Parameters.AddWithValue("@remOnline_amount", CDec(DataGridView4.Rows(i).Cells(5).Value.ToString))
                            'cm.Parameters.AddWithValue("@remOnline_total", CDec(tb_online.Text))
                            cm.Parameters.AddWithValue("@remOnline_date", DataGridView4.Rows(i).Cells(6).Value.ToString)
                            cm.Parameters.AddWithValue("@remOnline_time", frm_dashAdmin.lbl_time.Text)
                            cm.ExecuteNonQuery()
                            cn.Close()
                            Console.WriteLine("Hit3")
                        Next

                        Dim Osum As Decimal = 0
                        For i = 0 To DataGridView4.Rows.Count - 1
                            Osum += DataGridView4.Rows(i).Cells(4).Value
                        Next

                        tb_online.Text = Osum
                        tb_online.Text = String.Format("{0:n}", Double.Parse(tb_online.Text))


                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try


                    'FOR CHECK DETAILS

                    Try

                        cn.Open()
                        cm = New MySqlCommand("DELETE FROM rcss_remcheck WHERE remcheck_transid = @remcheck_transid", cn)
                        cm.Parameters.AddWithValue("@remcheck_transid", tb_edittransID.Text)
                        cm.ExecuteNonQuery()
                        cn.Close()

                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try


                    Try
                        Dim i As Integer
                        For i = 0 To DataGridView3.RowCount - 1
                            cn.Open()
                            cm = New MySqlCommand("INSERT INTO rcss_remcheck (remcheck_transid , remcheck_refnum, remcheck_cusID, remcheck_bank, remcheck_checkno, remcheck_amount, remcheck_date, remcheck_time) values(@remcheck_transid , @remcheck_refnum, @remcheck_cusID, @remcheck_bank, @remcheck_checkno, @remcheck_amount, @remcheck_date, @remcheck_time)", cn)

                            cm.Parameters.AddWithValue("@remcheck_transid", tb_transID.Text)
                            cm.Parameters.AddWithValue("@remcheck_refnum", DataGridView3.Rows(i).Cells(0).Value.ToString)
                            cm.Parameters.AddWithValue("@remcheck_cusID", DataGridView3.Rows(i).Cells(1).Value.ToString)
                            cm.Parameters.AddWithValue("@remcheck_bank", DataGridView3.Rows(i).Cells(3).Value.ToString)
                            cm.Parameters.AddWithValue("@remcheck_checkno", DataGridView3.Rows(i).Cells(4).Value.ToString)
                            cm.Parameters.AddWithValue("@remcheck_amount", CDec(DataGridView3.Rows(i).Cells(5).Value.ToString))
                            'cm.Parameters.AddWithValue("@remcheck_total", CDec(tb_check.Text))
                            cm.Parameters.AddWithValue("@remcheck_date", DataGridView3.Rows(i).Cells(6).Value.ToString)
                            cm.Parameters.AddWithValue("@remcheck_time", frm_dashAdmin.lbl_time.Text)
                            cm.ExecuteNonQuery()
                            cn.Close()
                            Console.WriteLine("Hit2")
                        Next

                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try


                    'FOR AR DETAILS
                    Try

                        cn.Open()
                        cm = New MySqlCommand("DELETE FROM rcss_remar WHERE remar_transid=@remar_transid", cn)
                        cm.Parameters.AddWithValue("@remar_transid", tb_edittransID.Text)
                        cm.ExecuteNonQuery()
                        cn.Close()

                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try

                    Try
                        Dim i As Integer
                        For i = 0 To DataGridView2.RowCount - 1
                            cn.Open()
                            cm = New MySqlCommand("INSERT INTO rcss_remar (remar_transid, remar_rmtstatus, remar_date, remar_time, remar_refnum, remar_invoice, remar_cusID, remar_amount, remar_status) values(@remar_transid, @remar_rmtstatus, @remar_date, @remar_time, @remar_refnum, @remar_invoice, @remar_cusID, @remar_amount, @remar_status)", cn)

                            cm.Parameters.AddWithValue("@remar_transid", tb_transID.Text)
                            cm.Parameters.AddWithValue("@remar_rmtstatus", tb_status.Text)
                            cm.Parameters.AddWithValue("@remar_date", DataGridView2.Rows(i).Cells(2).Value.ToString)
                            cm.Parameters.AddWithValue("@remar_time", frm_dashAdmin.lbl_time.Text)
                            cm.Parameters.AddWithValue("@remar_refnum", DataGridView2.Rows(i).Cells(0).Value.ToString)
                            cm.Parameters.AddWithValue("@remar_invoice", DataGridView2.Rows(i).Cells(1).Value.ToString)
                            'cm.Parameters.AddWithValue("@remar_cusID", lbl_CusID.Text)
                            cm.Parameters.AddWithValue("@remar_cusID", DataGridView2.Rows(i).Cells(3).Value.ToString)
                            cm.Parameters.AddWithValue("@remar_amount", CDec(DataGridView2.Rows(i).Cells(5).Value.ToString))
                            cm.Parameters.AddWithValue("@remar_status", "Pending")
                            cm.ExecuteNonQuery()
                            cn.Close()
                            Console.WriteLine("Hit")
                        Next


                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try

                    frm_remittance.LoadRemittanceforApproval()
                    frm_remittance.Count()
                    frm_remApproval.Loadforapproval()
                    MsgBox("Record successfully Updated!", vbInformation)

                End If
            End If


        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

        Me.Dispose()


    End Sub
    Private Sub tb_cash_TextChanged(sender As Object, e As EventArgs) Handles tb_cash.TextChanged
        Try
            Dim cash As Decimal = Decimal.Parse(tb_cash.Text)
            Dim coins As Decimal = Decimal.Parse(tb_coins.Text)
            Dim gcash As Decimal = Decimal.Parse(tb_gcash.Text)
            Dim online As Decimal = Decimal.Parse(tb_online.Text)
            Dim check As Decimal = Decimal.Parse(tb_check.Text)
            Dim ar As Decimal = Decimal.Parse(tb_AR.Text)
            Dim return1 As Decimal = Decimal.Parse(tb_return.Text)
            Dim bo As Decimal = Decimal.Parse(tb_bo.Text)
            Dim discount As Decimal = Decimal.Parse(tb_discount.Text)
            Dim expenses As Decimal = Decimal.Parse(tb_expenses.Text)

            Dim total As Decimal
            total = cash + coins + gcash + online + check + ar + return1 + bo + discount + expenses

            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try


        'Dim sum As Decimal
        'sum = Val(tb_cash.Text) + Val(tb_coins.Text)
        'tb_total.Text = sum
        'tb_total.Text = Format("Php ###,###,###.00", Decimal.Parse(tb_total.Text))

        'Dim sum As Double
        'sum = Convert.ToDouble(Val(tb_cash.Text)) + Val(tb_coins.Text) + Val(tb_gcash.Text) + Val(tb_online.Text) + Val(tb_check.Text) + Val(tb_AR.Text) + Val(tb_return.Text) + Val(tb_bo.Text) + Val(tb_discount.Text) + Val(tb_expenses.Text)
        'tb_total.Text = sum
        'tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

    End Sub
    Private Sub tb_coins_TextChanged(sender As Object, e As EventArgs) Handles tb_coins.TextChanged
        Try
            Dim cash As Decimal = Decimal.Parse(tb_cash.Text)
            Dim coins As Decimal = Decimal.Parse(tb_coins.Text)
            Dim gcash As Decimal = Decimal.Parse(tb_gcash.Text)
            Dim online As Decimal = Decimal.Parse(tb_online.Text)
            Dim check As Decimal = Decimal.Parse(tb_check.Text)
            Dim ar As Decimal = Decimal.Parse(tb_AR.Text)
            Dim return1 As Decimal = Decimal.Parse(tb_return.Text)
            Dim bo As Decimal = Decimal.Parse(tb_bo.Text)
            Dim discount As Decimal = Decimal.Parse(tb_discount.Text)
            Dim expenses As Decimal = Decimal.Parse(tb_expenses.Text)

            Dim total As Decimal
            total = cash + coins + gcash + online + check + ar + return1 + bo + discount + expenses

            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try


        'Dim sum1 As Decimal
        'sum1 = Val(tb_cash.Text) + Val(tb_coins.Text)
        'tb_total.Text = sum1
        'tb_total.Text = Format("Php ###,###,###.00", Decimal.Parse(tb_total.Text))

        'Dim sum As Double
        'sum = Val(tb_cash.Text) + Val(tb_coins.Text) + Val(tb_gcash.Text) + Val(tb_online.Text) + Val(tb_check.Text) + Val(tb_AR.Text) + Val(tb_return.Text) + Val(tb_bo.Text) + Val(tb_discount.Text) + Val(tb_expenses.Text)
        'tb_total.Text = sum
        'tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

    End Sub
    Private Sub tb_gcash_TextChanged(sender As Object, e As EventArgs) Handles tb_gcash.TextChanged
        Try
            Dim cash As Decimal = Decimal.Parse(tb_cash.Text)
            Dim coins As Decimal = Decimal.Parse(tb_coins.Text)
            Dim gcash As Decimal = Decimal.Parse(tb_gcash.Text)
            Dim online As Decimal = Decimal.Parse(tb_online.Text)
            Dim check As Decimal = Decimal.Parse(tb_check.Text)
            Dim ar As Decimal = Decimal.Parse(tb_AR.Text)
            Dim return1 As Decimal = Decimal.Parse(tb_return.Text)
            Dim bo As Decimal = Decimal.Parse(tb_bo.Text)
            Dim discount As Decimal = Decimal.Parse(tb_discount.Text)
            Dim expenses As Decimal = Decimal.Parse(tb_expenses.Text)

            Dim total As Decimal
            total = cash + coins + gcash + online + check + ar + return1 + bo + discount + expenses

            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try
        'Dim sum As Double
        'sum = Val(tb_cash.Text) + Val(tb_coins.Text) + Val(tb_gcash.Text) + Val(tb_online.Text) + Val(tb_check.Text) + Val(tb_AR.Text) + Val(tb_return.Text) + Val(tb_bo.Text) + Val(tb_discount.Text) + Val(tb_expenses.Text)
        'tb_total.Text = Format(sum, "###,###,###.00")

    End Sub
    Private Sub tb_online_TextChanged(sender As Object, e As EventArgs) Handles tb_online.TextChanged
        Try
            Dim cash As Decimal = Decimal.Parse(tb_cash.Text)
            Dim coins As Decimal = Decimal.Parse(tb_coins.Text)
            Dim gcash As Decimal = Decimal.Parse(tb_gcash.Text)
            Dim online As Decimal = Decimal.Parse(tb_online.Text)
            Dim check As Decimal = Decimal.Parse(tb_check.Text)
            Dim ar As Decimal = Decimal.Parse(tb_AR.Text)
            Dim return1 As Decimal = Decimal.Parse(tb_return.Text)
            Dim bo As Decimal = Decimal.Parse(tb_bo.Text)
            Dim discount As Decimal = Decimal.Parse(tb_discount.Text)
            Dim expenses As Decimal = Decimal.Parse(tb_expenses.Text)

            Dim total As Decimal
            total = cash + coins + gcash + online + check + ar + return1 + bo + discount + expenses

            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try
        'Dim sum As Double
        'sum = Val(tb_cash.Text) + Val(tb_coins.Text) + Val(tb_gcash.Text) + Val(tb_online.Text) + Val(tb_check.Text) + Val(tb_AR.Text) + Val(tb_return.Text) + Val(tb_bo.Text) + Val(tb_discount.Text) + Val(tb_expenses.Text)
        'tb_total.Text = Format(sum, "###,###,###.00")

    End Sub
    Private Sub tb_check_TextChanged(sender As Object, e As EventArgs) Handles tb_check.TextChanged
        Try
            Dim cash As Decimal = Decimal.Parse(tb_cash.Text)
            Dim coins As Decimal = Decimal.Parse(tb_coins.Text)
            Dim gcash As Decimal = Decimal.Parse(tb_gcash.Text)
            Dim online As Decimal = Decimal.Parse(tb_online.Text)
            Dim check As Decimal = Decimal.Parse(tb_check.Text)
            Dim ar As Decimal = Decimal.Parse(tb_AR.Text)
            Dim return1 As Decimal = Decimal.Parse(tb_return.Text)
            Dim bo As Decimal = Decimal.Parse(tb_bo.Text)
            Dim discount As Decimal = Decimal.Parse(tb_discount.Text)
            Dim expenses As Decimal = Decimal.Parse(tb_expenses.Text)

            Dim total As Decimal
            total = cash + coins + gcash + online + check + ar + return1 + bo + discount + expenses

            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try
        'Dim sum As Double
        'sum = Val(tb_cash.Text) + Val(tb_coins.Text) + Val(tb_gcash.Text) + Val(tb_online.Text) + Val(tb_check.Text) + Val(tb_AR.Text) + Val(tb_return.Text) + Val(tb_bo.Text) + Val(tb_discount.Text) + Val(tb_expenses.Text)
        'tb_total.Text = Format(sum, "###,###,###.00")

    End Sub
    Private Sub tb_AR_TextChanged(sender As Object, e As EventArgs) Handles tb_AR.TextChanged
        Try
            Dim cash As Decimal = Decimal.Parse(tb_cash.Text)
            Dim coins As Decimal = Decimal.Parse(tb_coins.Text)
            Dim gcash As Decimal = Decimal.Parse(tb_gcash.Text)
            Dim online As Decimal = Decimal.Parse(tb_online.Text)
            Dim check As Decimal = Decimal.Parse(tb_check.Text)
            Dim ar As Decimal = Decimal.Parse(tb_AR.Text)
            Dim return1 As Decimal = Decimal.Parse(tb_return.Text)
            Dim bo As Decimal = Decimal.Parse(tb_bo.Text)
            Dim discount As Decimal = Decimal.Parse(tb_discount.Text)
            Dim expenses As Decimal = Decimal.Parse(tb_expenses.Text)

            Dim total As Decimal
            total = cash + coins + gcash + online + check + ar + return1 + bo + discount + expenses

            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try
        'Dim sum As Double
        'sum = Val(tb_cash.Text) + Val(tb_coins.Text) + Val(tb_gcash.Text) + Val(tb_online.Text) + Val(tb_check.Text) + Val(tb_AR.Text) + Val(tb_return.Text) + Val(tb_bo.Text) + Val(tb_discount.Text) + Val(tb_expenses.Text)
        'tb_total.Text = Format(sum, "###,###,###.00")

    End Sub
    Private Sub tb_return_TextChanged(sender As Object, e As EventArgs) Handles tb_return.TextChanged
        Try
            Dim cash As Decimal = Decimal.Parse(tb_cash.Text)
            Dim coins As Decimal = Decimal.Parse(tb_coins.Text)
            Dim gcash As Decimal = Decimal.Parse(tb_gcash.Text)
            Dim online As Decimal = Decimal.Parse(tb_online.Text)
            Dim check As Decimal = Decimal.Parse(tb_check.Text)
            Dim ar As Decimal = Decimal.Parse(tb_AR.Text)
            Dim return1 As Decimal = Decimal.Parse(tb_return.Text)
            Dim bo As Decimal = Decimal.Parse(tb_bo.Text)
            Dim discount As Decimal = Decimal.Parse(tb_discount.Text)
            Dim expenses As Decimal = Decimal.Parse(tb_expenses.Text)

            Dim total As Decimal
            total = cash + coins + gcash + online + check + ar + return1 + bo + discount + expenses

            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try
        'Dim sum As Double
        'sum = Val(tb_cash.Text) + Val(tb_coins.Text) + Val(tb_gcash.Text) + Val(tb_online.Text) + Val(tb_check.Text) + Val(tb_AR.Text) + Val(tb_return.Text) + Val(tb_bo.Text) + Val(tb_discount.Text) + Val(tb_expenses.Text)
        'tb_total.Text = Format(sum, "###,###,###.00")

    End Sub
    Private Sub tb_bo_TextChanged(sender As Object, e As EventArgs) Handles tb_bo.TextChanged
        Try
            Dim cash As Decimal = Decimal.Parse(tb_cash.Text)
            Dim coins As Decimal = Decimal.Parse(tb_coins.Text)
            Dim gcash As Decimal = Decimal.Parse(tb_gcash.Text)
            Dim online As Decimal = Decimal.Parse(tb_online.Text)
            Dim check As Decimal = Decimal.Parse(tb_check.Text)
            Dim ar As Decimal = Decimal.Parse(tb_AR.Text)
            Dim return1 As Decimal = Decimal.Parse(tb_return.Text)
            Dim bo As Decimal = Decimal.Parse(tb_bo.Text)
            Dim discount As Decimal = Decimal.Parse(tb_discount.Text)
            Dim expenses As Decimal = Decimal.Parse(tb_expenses.Text)

            Dim total As Decimal
            total = cash + coins + gcash + online + check + ar + return1 + bo + discount + expenses

            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try
        'Dim sum As Double
        'sum = Val(tb_cash.Text) + Val(tb_coins.Text) + Val(tb_gcash.Text) + Val(tb_online.Text) + Val(tb_check.Text) + Val(tb_AR.Text) + Val(tb_return.Text) + Val(tb_bo.Text) + Val(tb_discount.Text) + Val(tb_expenses.Text)
        'tb_total.Text = Format(sum, "###,###,###.00")

    End Sub
    Private Sub tb_discount_TextChanged(sender As Object, e As EventArgs) Handles tb_discount.TextChanged
        Try
            Dim cash As Decimal = Decimal.Parse(tb_cash.Text)
            Dim coins As Decimal = Decimal.Parse(tb_coins.Text)
            Dim gcash As Decimal = Decimal.Parse(tb_gcash.Text)
            Dim online As Decimal = Decimal.Parse(tb_online.Text)
            Dim check As Decimal = Decimal.Parse(tb_check.Text)
            Dim ar As Decimal = Decimal.Parse(tb_AR.Text)
            Dim return1 As Decimal = Decimal.Parse(tb_return.Text)
            Dim bo As Decimal = Decimal.Parse(tb_bo.Text)
            Dim discount As Decimal = Decimal.Parse(tb_discount.Text)
            Dim expenses As Decimal = Decimal.Parse(tb_expenses.Text)

            Dim total As Decimal
            total = cash + coins + gcash + online + check + ar + return1 + bo + discount + expenses

            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try
        'Dim sum As Double
        'sum = Val(tb_cash.Text) + Val(tb_coins.Text) + Val(tb_gcash.Text) + Val(tb_online.Text) + Val(tb_check.Text) + Val(tb_AR.Text) + Val(tb_return.Text) + Val(tb_bo.Text) + Val(tb_discount.Text) + Val(tb_expenses.Text)
        'tb_total.Text = Format(sum, "###,###,###.00")

    End Sub
    Private Sub tb_expenses_TextChanged(sender As Object, e As EventArgs) Handles tb_expenses.TextChanged
        Try
            Dim cash As Decimal = Decimal.Parse(tb_cash.Text)
            Dim coins As Decimal = Decimal.Parse(tb_coins.Text)
            Dim gcash As Decimal = Decimal.Parse(tb_gcash.Text)
            Dim online As Decimal = Decimal.Parse(tb_online.Text)
            Dim check As Decimal = Decimal.Parse(tb_check.Text)
            Dim ar As Decimal = Decimal.Parse(tb_AR.Text)
            Dim return1 As Decimal = Decimal.Parse(tb_return.Text)
            Dim bo As Decimal = Decimal.Parse(tb_bo.Text)
            Dim discount As Decimal = Decimal.Parse(tb_discount.Text)
            Dim expenses As Decimal = Decimal.Parse(tb_expenses.Text)

            Dim total As Decimal
            total = cash + coins + gcash + online + check + ar + return1 + bo + discount + expenses

            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try
        'Dim sum As Double
        'sum = Val(tb_cash.Text) + Val(tb_coins.Text) + Val(tb_gcash.Text) + Val(tb_online.Text) + Val(tb_check.Text) + Val(tb_AR.Text) + Val(tb_return.Text) + Val(tb_bo.Text) + Val(tb_discount.Text) + Val(tb_expenses.Text)
        'tb_total.Text = Format(sum, "###,###,###.00")

    End Sub
    Private Sub btn_addref_Click(sender As Object, e As EventArgs) Handles btn_addref.Click
        If tb_refno.Text = String.Empty Or tb_refamount.Text = String.Empty Then
            MessageBox.Show("Fill missing fields", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            DataGridView1.Rows.Add(tb_refno.Text, tb_refamount.Text)
            Dim sum As Decimal = 0
            For i = 0 To DataGridView1.Rows.Count - 1
                sum += DataGridView1.Rows(i).Cells(1).Value
            Next
            tb_refsum.Text = sum
            tb_refsum.Text = String.Format("{0:n}", Double.Parse(tb_refsum.Text))

            tb_refno.Clear()
            tb_refamount.Clear()


        End If


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        LoadCustomers()
        Panel_AR.Visible = True
        Panel_AR.BringToFront()
        lbl_close.Enabled = False


    End Sub
    Private Sub AR_close_Click(sender As Object, e As EventArgs) Handles AR_close.Click

        Panel_AR.Visible = False
        Panel_AR.SendToBack()
        lbl_close.Enabled = True

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Panel_Check.Visible = True
        Panel_Check.BringToFront()
        lbl_close.Enabled = False

        Try
            cb_checkcustomer.Items.Clear()

            cn.Open()
            cm = New MySqlCommand("SELECT * from rcss_customer", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cb_checkcustomer.Items.Add(dr.Item("cus_name").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
    Private Sub Check_close_Click(sender As Object, e As EventArgs) Handles Check_close.Click

        Panel_Check.Visible = False
        Panel_Check.SendToBack()
        lbl_close.Enabled = True

    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Panel_Online.Visible = True
        Panel_Online.BringToFront()
        lbl_close.Enabled = False

        Try
            cb_onlinecustomer.Items.Clear()

            cn.Open()
            cm = New MySqlCommand("SELECT * from rcss_customer", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cb_onlinecustomer.Items.Add(dr.Item("cus_name").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub online_close_Click(sender As Object, e As EventArgs) Handles online_close.Click
        Panel_Online.Visible = False
        Panel_Online.SendToBack()
        lbl_close.Enabled = True
    End Sub
    Private Sub btn_addAR_Click(sender As Object, e As EventArgs) Handles btn_addAR.Click
        If tb_ARsino.Text = String.Empty Or cb_customers.SelectedItem = String.Empty Or tb_ARamount.Text = String.Empty Or tb_ARrefnum.Text = String.Empty Then
            MessageBox.Show("Fill missing fields", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            DataGridView2.Rows.Add(tb_ARrefnum.Text, tb_ARsino.Text, DateTimePicker2.Text, lbl_CusID.Text, cb_customers.SelectedItem, tb_ARamount.Text)
            Dim ARsum As Decimal = 0
            For i = 0 To DataGridView2.Rows.Count - 1
                ARsum += DataGridView2.Rows(i).Cells(5).Value
            Next

            'tb_AR.Text = Format(ARsum, "###,###,###.00")
            tb_AR.Text = ARsum
            tb_AR.Text = String.Format("{0:n}", Double.Parse(tb_AR.Text))

            tb_ARsino.Clear()
            tb_ARcustomer.Clear()
            tb_ARamount.Clear()
            tb_ARrefnum.Clear()

        End If
    End Sub

    Private Sub btn_addCHECK_Click(sender As Object, e As EventArgs) Handles btn_addCHECK.Click
        If cb_checkcustomer.SelectedItem = String.Empty Or tb_CBank.Text = String.Empty Or tb_Cno.Text = String.Empty Or tb_Camount.Text = String.Empty Then
            MessageBox.Show("Fill missing fields", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            DataGridView3.Rows.Add(tb_Crefnum.Text, Lbl_CheckCusID.Text, cb_checkcustomer.SelectedItem, tb_CBank.Text, tb_Cno.Text, tb_Camount.Text, DateTimePicker3.Text)

            Dim Csum As Decimal = 0
            For i = 0 To DataGridView3.Rows.Count - 1
                Csum += DataGridView3.Rows(i).Cells(5).Value
            Next

            'tb_check.Text = Format(Csum, "###,###,###.00")
            tb_check.Text = Csum
            tb_check.Text = String.Format("{0:n}", Double.Parse(tb_check.Text))

            tb_CCustomer.Clear()
            tb_CBank.Clear()
            tb_Cno.Clear()
            tb_Camount.Clear()
            tb_Crefnum.Clear()

        End If
    End Sub

    Private Sub btn_addOnline_Click(sender As Object, e As EventArgs) Handles btn_addOnline.Click
        If cb_onlinecustomer.SelectedItem = String.Empty Or tb_Obank.Text = String.Empty Or tb_Orefno.Text = String.Empty Or tb_Oamount.Text = String.Empty Then
            MessageBox.Show("Fill missing fields", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            DataGridView4.Rows.Add(tb_Orefnum.Text, lbl_OnlineCusID.Text, cb_onlinecustomer.SelectedItem, tb_Obank.Text, tb_Orefno.Text, tb_Oamount.Text, DateTimePicker4.Text)


            Dim Osum As Decimal = 0
            For i = 0 To DataGridView4.Rows.Count - 1
                Osum += DataGridView4.Rows(i).Cells(5).Value
            Next

            tb_online.Text = Osum
            tb_online.Text = String.Format("{0:n}", Double.Parse(tb_online.Text))

            tb_OCustomer.Clear()
            cb_onlinecustomer.SelectedIndex = -1
            tb_Obank.Clear()
            tb_Orefno.Clear()
            tb_Oamount.Clear()
            tb_Orefnum.Clear()

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to clear fields?", vbYesNo + vbQuestion) = vbYes Then

            tb_salesman.Clear()
            tb_custodian.Clear()
            tb_driver.Clear()
            tb_helper.Clear()

            cb_vanname.SelectedIndex = -1

            DataGridView1.Rows.Clear()
            tb_refsum.Text = "0.00"

            tb_cash.Text = "0.00"
            tb_coins.Text = "0.00"
            tb_gcash.Text = "0.00"
            tb_online.Text = "0.00"
            tb_check.Text = "0.00"
            tb_AR.Text = "0.00"
            tb_return.Text = "0.00"
            tb_bo.Text = "0.00"
            tb_discount.Text = "0.00"
            tb_expenses.Text = "0.00"
            tb_total.Text = "0.00"
            tb_remarks.Clear()

            DataGridView4.Rows.Clear()
            DataGridView3.Rows.Clear()
            DataGridView2.Rows.Clear()

            tb_refno.Clear()
            tb_refamount.Clear()

            btnSubmit.Visible = True
            btnUpdate.Visible = False

            tb_edittransID.Clear()
            tb_edittransID.Visible = False
            tb_transID.Visible = True

            lbl_addRemittance.Text = "ADD REMITTANCE"

            tb_status.Text = "For Approval"

            tb_salesman.Focus()
            RANDID()

        End If


    End Sub

    Private Sub tb_status_TextChanged(sender As Object, e As EventArgs) Handles tb_status.TextChanged
        If tb_status.Text = "For Approval" Then
            tb_status.BackColor = Color.Orange
        ElseIf tb_status.Text = "Revise" Then
            tb_status.BackColor = Color.Red
        ElseIf tb_status.Text = "Approved" Then
            tb_status.BackColor = Color.GreenYellow
            btnUpdate.Enabled = False
            tb_remarks.ReadOnly = True

            btnSubmit.Visible = False
            btnUpdate.Visible = False
            btnCancel.Visible = False

            DateTimePicker1.Enabled = False
            cb_vanname.Enabled = False
            tb_salesman.Enabled = False
            tb_custodian.Enabled = False
            tb_driver.Enabled = False
            tb_helper.Enabled = False

            tb_refno.Enabled = False
            tb_refamount.Enabled = False
            DataGridView1.Enabled = False
            btn_addref.Enabled = False
            tb_refsum.Enabled = False

            tb_cash.Enabled = False
            tb_coins.Enabled = False
            tb_gcash.Enabled = False
            'tb_online.Enabled = False
            'tb_check.Enabled = False
            'tb_AR.Enabled = False
            tb_return.Enabled = False
            tb_bo.Enabled = False
            tb_discount.Enabled = False
            tb_expenses.Enabled = False
            tb_total.Enabled = False

            tb_ARsino.Enabled = False
            DateTimePicker2.Enabled = False
            cb_customers.Enabled = False
            tb_ARrefnum.Enabled = False
            tb_ARamount.Enabled = False
            btn_addAR.Enabled = False
            DataGridView2.Enabled = False

            cb_onlinecustomer.Enabled = False
            tb_Obank.Enabled = False
            tb_Orefno.Enabled = False
            DateTimePicker4.Enabled = False
            tb_Orefnum.Enabled = False
            tb_Oamount.Enabled = False
            btn_addOnline.Enabled = False
            DataGridView4.Enabled = False

            cb_checkcustomer.Enabled = False
            tb_CBank.Enabled = False
            tb_Cno.Enabled = False
            DateTimePicker3.Enabled = False
            tb_Crefnum.Enabled = False
            tb_Camount.Enabled = False
            btn_addCHECK.Enabled = False
            DataGridView3.Enabled = False

            lbl_addRemittance.Text = "VIEW REMITTANCE DETAILS"

        End If

    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs)
        LoadVanList()
    End Sub



    Private Sub cb_vanname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_vanname.SelectedIndexChanged
        tb_vanchoice.Text = cb_vanname.SelectedItem
        cb_vanname.SelectedItem = -1
    End Sub


    Private Sub tb_refamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_refamount.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_cash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_cash.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If

        'WORKING
        'If Asc(e.KeyChar) = 8 Then

        'ElseIf Char.IsNumber(e.KeyChar) = False And e.KeyChar <> "." Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub tb_coins_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_coins.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_gcash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_gcash.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_return_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_return.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_bo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_bo.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_discount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_discount.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_expenses_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_expenses.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_refamount_LostFocus(sender As Object, e As EventArgs) Handles tb_refamount.LostFocus
        Try
            If tb_refamount.Text = "" Or tb_refamount.Text = "0.00" Or tb_refamount.Text = ".00" Or tb_refamount.Text = "0" Then
                tb_refamount.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_refamount.Text
                tb_refamount.Text = number1.ToString("###,###,###.00")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_cash_LostFocus(sender As Object, e As EventArgs) Handles tb_cash.LostFocus
        Try
            If tb_cash.Text = "" Or tb_cash.Text = "0.00" Or tb_cash.Text = ".00" Or tb_cash.Text = "0" Then
                tb_cash.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_cash.Text
                tb_cash.Text = number1.ToString("###,###,###.00")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_coins_LostFocus(sender As Object, e As EventArgs) Handles tb_coins.LostFocus
        Try
            If tb_coins.Text = "" Or tb_coins.Text = "0.00" Or tb_coins.Text = ".00" Or tb_coins.Text = "0" Then
                tb_coins.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_coins.Text
                tb_coins.Text = number1.ToString("###,###,###.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_gcash_LostFocus(sender As Object, e As EventArgs) Handles tb_gcash.LostFocus
        Try
            If tb_gcash.Text = "" Or tb_gcash.Text = "0.00" Or tb_gcash.Text = ".00" Or tb_gcash.Text = "0" Then
                tb_gcash.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_gcash.Text
                tb_gcash.Text = number1.ToString("###,###,###.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_return_LostFocus(sender As Object, e As EventArgs) Handles tb_return.LostFocus
        Try
            If tb_return.Text = "" Or tb_return.Text = "0.00" Or tb_return.Text = ".00" Or tb_return.Text = "0" Then
                tb_return.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_return.Text
                tb_return.Text = number1.ToString("###,###,###.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_bo_LostFocus(sender As Object, e As EventArgs) Handles tb_bo.LostFocus
        Try
            If tb_bo.Text = "" Or tb_bo.Text = "0.00" Or tb_bo.Text = ".00" Or tb_bo.Text = "0" Then
                tb_bo.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_bo.Text
                tb_bo.Text = number1.ToString("###,###,###.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_discount_LostFocus(sender As Object, e As EventArgs) Handles tb_discount.LostFocus
        Try
            If tb_discount.Text = "" Or tb_discount.Text = "0.00" Or tb_discount.Text = ".00" Or tb_discount.Text = "0" Then
                tb_discount.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_discount.Text
                tb_discount.Text = number1.ToString("###,###,###.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_expenses_LostFocus(sender As Object, e As EventArgs) Handles tb_expenses.LostFocus
        Try
            If tb_expenses.Text = "" Or tb_expenses.Text = "0.00" Or tb_expenses.Text = ".00" Or tb_expenses.Text = "0" Then
                tb_expenses.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_expenses.Text
                tb_expenses.Text = number1.ToString("###,###,###.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_Oamount_LostFocus(sender As Object, e As EventArgs) Handles tb_Oamount.LostFocus
        Try
            If tb_Oamount.Text = "" Or tb_Oamount.Text = "0.00" Or tb_Oamount.Text = ".00" Or tb_Oamount.Text = "0" Then
                tb_Oamount.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_Oamount.Text
                tb_Oamount.Text = number1.ToString("###,###,###.00")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_ARamount_LostFocus(sender As Object, e As EventArgs) Handles tb_ARamount.LostFocus
        Try
            If tb_ARamount.Text = "" Or tb_ARamount.Text = "0.00" Or tb_ARamount.Text = ".00" Or tb_ARamount.Text = "0" Then
                tb_ARamount.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_ARamount.Text
                tb_ARamount.Text = number1.ToString("###,###,###.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_Camount_LostFocus(sender As Object, e As EventArgs) Handles tb_Camount.LostFocus
        Try
            If tb_Camount.Text = "" Or tb_Camount.Text = "0.00" Or tb_Camount.Text = ".00" Or tb_Camount.Text = "0" Then
                tb_Camount.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_Camount.Text
                tb_Camount.Text = number1.ToString("###,###,###.00")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try

            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
            If colname = "DGV1colRemove" Then
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    If MsgBox("Are you sure you want to remove this?", vbYesNo + vbQuestion) = vbYes Then
                        DataGridView1.Rows.Remove(row)
                    End If
                Next
            End If
            Dim sum As Decimal = 0
            For i = 0 To DataGridView1.Rows.Count - 1
                sum += DataGridView1.Rows(i).Cells(1).Value
            Next
            'tb_refsum.Text = sum
            'tb_refsum.Text = String.Format("{0:n}", Double.Parse(tb_refsum.Text))

            ' Convert the result to the appropriate datatype
            Dim convertsum As Decimal = Convert.ToDecimal(sum)
            Dim formattedSum As String = String.Format("{0:#,##0.00}", convertsum)
            tb_refsum.Text = formattedSum

        Catch ex As Exception

        End Try

    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Try

            Dim colname As String = DataGridView2.Columns(e.ColumnIndex).Name
            If colname = "DGV2colRemove" Then
                For Each row As DataGridViewRow In DataGridView2.SelectedRows
                    If MsgBox("Are you sure you want to remove this?", vbYesNo + vbQuestion) = vbYes Then
                        DataGridView2.Rows.Remove(row)
                    End If
                Next
            End If

            Dim ARsum As Decimal = 0
            For i = 0 To DataGridView2.Rows.Count - 1
                ARsum += DataGridView2.Rows(i).Cells(5).Value
            Next

            'tb_AR.Text = ARsum
            'tb_AR.Text = String.Format("{0:n}", Double.Parse(tb_AR.Text))
            ' Convert the result to the appropriate datatype
            Dim ARconvertsum As Decimal = Convert.ToDecimal(ARsum)
            Dim ARformattedSum As String = String.Format("{0:#,##0.00}", ARconvertsum)
            tb_AR.Text = ARformattedSum

        Catch ex As Exception

        End Try

    End Sub
    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Try

            Dim colname As String = DataGridView3.Columns(e.ColumnIndex).Name
            If colname = "DGV3colRemove" Then
                For Each row As DataGridViewRow In DataGridView3.SelectedRows
                    If MsgBox("Are you sure you want to remove this?", vbYesNo + vbQuestion) = vbYes Then
                        DataGridView3.Rows.Remove(row)
                    End If
                Next
            End If

            Dim Csum As Decimal = 0
                For i = 0 To DataGridView3.Rows.Count - 1
                Csum += DataGridView3.Rows(i).Cells(5).Value
            Next

            'tb_check.Text = Csum
            'tb_check.Text = String.Format("{0:n}", Double.Parse(tb_check.Text))
            ' Convert the result to the appropriate datatype
            Dim Cconvertsum As Decimal = Convert.ToDecimal(Csum)
            Dim CformattedSum As String = String.Format("{0:#,##0.00}", Cconvertsum)
            tb_check.Text = CformattedSum

        Catch ex As Exception

        End Try

    End Sub
    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        Try

            Dim colname As String = DataGridView4.Columns(e.ColumnIndex).Name
            If colname = "DGV4colRemove" Then
                For Each row As DataGridViewRow In DataGridView4.SelectedRows
                    If MsgBox("Are you sure you want to remove this?", vbYesNo + vbQuestion) = vbYes Then
                        DataGridView4.Rows.Remove(row)
                    End If
                Next
            End If
            Dim Osum As Decimal = 0
            For i = 0 To DataGridView4.Rows.Count - 1
                Osum += DataGridView4.Rows(i).Cells(5).Value
            Next

            'tb_online.Text = Osum
            'tb_online.Text = String.Format("{0:n}", Double.Parse(tb_online.Text))
            ' Convert the result to the appropriate datatype
            Dim Oconvertsum As Decimal = Convert.ToDecimal(Osum)
            Dim OformattedSum As String = String.Format("{0:#,##0.00}", Oconvertsum)
            tb_online.Text = OformattedSum

        Catch ex As Exception

        End Try


    End Sub
    Private Sub tb_Oamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Oamount.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_Camount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_Camount.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_ARamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_ARamount.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Panel_AR_Paint(sender As Object, e As PaintEventArgs) Handles Panel_AR.Paint

    End Sub

    Private Sub tb_refno_TextChanged(sender As Object, e As EventArgs) Handles tb_refno.TextChanged

    End Sub

    Private Sub tb_refamount_TextChanged(sender As Object, e As EventArgs) Handles tb_refamount.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        dtp_month.Text = DateTimePicker1.Value.ToString("MMMM")
        dtp_day.Text = DateTimePicker1.Value.Day
        dtp_year.Text = DateTimePicker1.Value.Year
    End Sub

    Private Sub dtp_month_Click(sender As Object, e As EventArgs) Handles dtp_month.Click

    End Sub

    Private Sub cb_customers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_customers.SelectedIndexChanged
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT * from rcss_customer WHERE cus_name = '" & cb_customers.SelectedItem & "' ", cn)
            dr = cm.ExecuteReader
            While dr.Read

                lbl_CusID.Text = dr.Item("cus_accountno").ToString

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

        Dim selecteddate As Date = DateTimePicker2.Value

        Dim duedate As Date = selecteddate.AddDays(7)

        Dim ShowDueDate As String = duedate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)

        Lbl_Duedate.Text = ShowDueDate

    End Sub

    Private Sub tb_ARcustomer_TextChanged(sender As Object, e As EventArgs) Handles tb_ARcustomer.TextChanged

    End Sub

    Private Sub cb_onlinecustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_onlinecustomer.SelectedIndexChanged
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT * from rcss_customer WHERE cus_name = '" & cb_onlinecustomer.SelectedItem & "' ", cn)
            dr = cm.ExecuteReader
            While dr.Read

                lbl_OnlineCusID.Text = dr.Item("cus_accountno").ToString

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cb_checkcustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_checkcustomer.SelectedIndexChanged
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT * from rcss_customer WHERE cus_name = '" & cb_checkcustomer.SelectedIndex & "' ", cn)
            dr = cm.ExecuteReader
            While dr.Read

                Lbl_CheckCusID.Text = dr.Item("cus_accountno").ToString

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Panel_Online_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Online.Paint

    End Sub

    Private Sub cb_vanname_Click(sender As Object, e As EventArgs) Handles cb_vanname.Click
        cb_vanname.Sorted = True


    End Sub
End Class