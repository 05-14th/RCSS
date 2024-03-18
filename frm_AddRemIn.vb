Imports MySql.Data.MySqlClient
Public Class frm_AddRemIn
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub
    Private Sub frm_AddRemIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb_customer.Focus()

        RANDID()

        ' Set up AutoComplete properties
        tb_item.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tb_item.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub
    Sub RANDID()
        Randomize()
        Dim rand As Integer = CInt(Int((10000 * Rnd()) + 1))
        tb_IHtransID.Text = "IH-" & (DateTime.Now.ToString("MM")) & (DateTime.Now.ToString("dd")) & (DateTime.Now.ToString("yy")) & rand

    End Sub
    Sub FetchCustomer()
        Try
            cb_customer.Items.Clear()

            cn.Open()
            cm = New MySqlCommand("SELECT * from rcss_customer", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cb_customer.Items.Add(dr.Item("cus_name").ToString)
                cb_customer.Sorted = True

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub tb_qty_TextChanged(sender As Object, e As EventArgs) Handles tb_qty.TextChanged
        Try
            Dim qty As Decimal = Decimal.Parse(tb_qty.Text)
            Dim price As Decimal = Decimal.Parse(tb_price.Text)

            Dim total As Decimal
            total = qty * price
            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_qty.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub
    Private Sub tb_price_TextChanged(sender As Object, e As EventArgs) Handles tb_price.TextChanged
        Try
            Dim qty As Decimal = Decimal.Parse(tb_qty.Text)
            Dim price As Decimal = Decimal.Parse(tb_price.Text)

            Dim total As Decimal
            total = qty * price
            tb_total.Text = Decimal.Parse(total)
            tb_total.Text = String.Format("{0:n}", Double.Parse(tb_total.Text))

        Catch ex As Exception

        End Try
    End Sub
    Private Sub tb_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_price.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub
    Private Sub tb_price_LostFocus(sender As Object, e As EventArgs) Handles tb_price.LostFocus
        Try
            If tb_price.Text = "" Or tb_price.Text = "0.00" Or tb_price.Text = ".00" Or tb_price.Text = "0" Then
                tb_price.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_price.Text
                tb_price.Text = String.Format("{0:#,##0.00}", number1)
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub btn_AddItem_Click(sender As Object, e As EventArgs) Handles btn_AddItem.Click
        Try
            If tb_customer.Text = String.Empty Or tb_item.Text = String.Empty Or tb_qty.Text = String.Empty Then
                MessageBox.Show("Fill missing field/s", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tb_customer.Focus()

            Else
                Dim counter As Integer = lbl_counter.Text
                Dim counterItem As Integer = lbl_couterItem.Text

                DataGridView1.Rows.Add(lbl_counter.Text, tb_customer.Text, tb_item.Text, tb_price.Text, tb_qty.Text, tb_total.Text)

                counter += 1
                counterItem += 1

                lbl_counter.Text = counter
                lbl_couterItem.Text = counterItem

                lbl_counterItemDisplay.Text = "(" & lbl_couterItem.Text & ") Item/s found"

                Dim sum As Decimal = 0
                For i = 0 To DataGridView1.Rows.Count - 1
                    sum += DataGridView1.Rows(i).Cells(5).Value
                Next


                lbl_GrandTotal.Text = String.Format("{0:#,##0.00}", sum)

                tb_customer.Clear()
                tb_item.Clear()
                tb_price.Text = "0.00"
                tb_qty.Clear()
                tb_customer.Focus()


            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try

            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
            If colname = "colDelete" Then
                For Each row As DataGridViewRow In DataGridView1.SelectedRows
                    If MsgBox("Are you sure you want to remove this?", vbYesNo + vbQuestion) = vbYes Then
                        DataGridView1.Rows.Remove(row)

                        Dim delsum As Decimal = 0
                        For i = 0 To DataGridView1.Rows.Count - 1
                            delsum += DataGridView1.Rows(i).Cells(5).Value
                        Next

                        Dim convertdelsum As Decimal = Convert.ToDecimal(delsum)
                        Dim formattedSum As String = String.Format("{0:#,##0.00}", convertdelsum)
                        lbl_GrandTotal.Text = formattedSum

                        tb_customer.Focus()

                        Dim counterItem As Integer = lbl_couterItem.Text
                        Dim counter As Integer = lbl_counter.Text

                        counter -= 1
                        counterItem -= 1

                        lbl_counter.Text = counter
                        lbl_couterItem.Text = counterItem

                        lbl_counterItemDisplay.Text = "(" & lbl_couterItem.Text & ") Item/s found"




                    End If
                Next
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        If MsgBox("Are you sure you want to clear this?", vbYesNo + vbQuestion) = vbYes Then
            RANDID()
            tb_customer.Clear()
            tb_item.Clear()
            tb_price.Text = "0.00"
            tb_qty.Clear()
            DataGridView1.Rows.Clear()
            tb_customer.Focus()

            lbl_counter.Text = "1"
            lbl_couterItem.Text = "0"

        End If


    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        'Try
        '    If DataGridView1.Rows.Count = 0 Then
        '        MessageBox.Show("No remittance available!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Else
        '        If MsgBox("Do you want to save this record?", vbYesNo + vbQuestion) = vbYes Then

        '            'FOR REMITTANCE DETAILS'
        '            Try
        '                cn.Open()
        '                cm = New MySqlCommand("INSERT INTO rcss_remittanceIH (IHrmt_transid, rmt_date, rmt_month, rmt_day, rmt_year, rmt_time, rmt_vanno, rmt_salesman, rmt_custodian, rmt_driver, rmt_helper, rmt_refsum, rmt_remsum, rmt_remarks, rmt_status, rmt_week) values(@rmt_transid, @rmt_date, @rmt_month, @rmt_day, @rmt_year, @rmt_time, @rmt_vanno, @rmt_salesman, @rmt_custodian, @rmt_driver, @rmt_helper, @rmt_refsum, @rmt_remsum, @rmt_remarks, @rmt_status, @rmt_week)", cn)

        '                cm.Parameters.AddWithValue("@rmt_transid", tb_transID.Text)
        '                cm.Parameters.AddWithValue("@rmt_date", DateTimePicker1.Text)
        '                cm.Parameters.AddWithValue("@rmt_month", dtp_month.Text)
        '                cm.Parameters.AddWithValue("@rmt_day", dtp_day.Text)
        '                cm.Parameters.AddWithValue("@rmt_year", dtp_year.Text)
        '                cm.Parameters.AddWithValue("@rmt_time", frm_dashAdmin.lbl_time.Text)
        '                cm.Parameters.AddWithValue("@rmt_vanno", tb_vanchoice.Text)
        '                cm.Parameters.AddWithValue("@rmt_salesman", tb_salesman.Text)
        '                cm.Parameters.AddWithValue("@rmt_custodian", tb_custodian.Text)
        '                cm.Parameters.AddWithValue("@rmt_driver", tb_driver.Text)
        '                cm.Parameters.AddWithValue("@rmt_helper", tb_helper.Text)
        '                cm.Parameters.AddWithValue("@rmt_refsum", CDec(tb_refsum.Text))
        '                cm.Parameters.AddWithValue("@rmt_remsum", CDec(tb_total.Text))
        '                cm.Parameters.AddWithValue("@rmt_remarks", tb_remarks.Text & " - " & DateTimePicker1.Text & " - " & frm_dashAdmin.lbl_time.Text & vbLf)
        '                cm.Parameters.AddWithValue("@rmt_status", tb_status.Text)
        '                cm.Parameters.AddWithValue("@rmt_week", CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTimePicker1.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday))
        '                cm.ExecuteNonQuery()
        '                cn.Close()

        '                cb_vanname.SelectedIndex = -1

        '                frm_dashAdmin.CountForApproval()
        '                frm_dashAdmin.CountRevise()
        '                frm_dashAdmin.CountApproved()
        '            Catch ex As Exception
        '                cn.Close()
        '                MsgBox(ex.Message, vbCritical)
        '            End Try

        '            'FOR REFERENCES DETAILS
        '            Try
        '                Dim i As Integer
        '                For i = 0 To DataGridView1.RowCount - 1
        '                    cn.Open()
        '                    cm = New MySqlCommand("INSERT INTO rcss_remref (remref_transid, remref_date, remref_time, remref_references, remref_amount, remref_total) values(@remref_transid, @remref_date, @remref_time, @remref_references, @remref_amount, @remref_total)", cn)

        '                    cm.Parameters.AddWithValue("@remref_transid", tb_transID.Text)
        '                    cm.Parameters.AddWithValue("@remref_date", DateTimePicker1.Text)
        '                    cm.Parameters.AddWithValue("@remref_time", frm_dashAdmin.lbl_time.Text)
        '                    cm.Parameters.AddWithValue("@remref_references", DataGridView1.Rows(i).Cells(0).Value.ToString)
        '                    cm.Parameters.AddWithValue("@remref_amount", CDec(DataGridView1.Rows(i).Cells(1).Value.ToString))
        '                    cm.Parameters.AddWithValue("@remref_total", CDec(tb_refsum.Text))
        '                    cm.ExecuteNonQuery()
        '                    cn.Close()
        '                    Console.WriteLine("Hit5")
        '                Next

        '                DataGridView1.Rows.Clear()
        '                tb_refsum.Clear()


        '            Catch ex As Exception
        '                cn.Close()
        '                MsgBox(ex.Message, vbCritical)
        '            End Try



        '            RANDID()
        '            frm_remittance.LoadRemittanceforApproval()
        '            frm_remittance.Count()
        '            MsgBox("Remittance successfully saved!", vbInformation)

        '        End If
        '    End If
        '    frm_remittance.CountForApproval()
        '    Me.Dispose()

        'Catch ex As Exception
        '    cn.Close()
        '    MsgBox(ex.Message, vbCritical)
        'End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        dtp_month.Text = DateTimePicker1.Value.ToString("MMMM")
        dtp_day.Text = DateTimePicker1.Value.Day
        dtp_year.Text = DateTimePicker1.Value.Year
    End Sub
End Class