Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class frm_AddRemIn
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub
    Private Sub frm_AddRemIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb_customer.Focus()

        RANDID()

        DateTimePicker1.Value = Date.Today
        DateTimePicker1.Format = DateTimePickerFormat.Custom

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
        Try
            If DataGridView1.Rows.Count = 0 Then
                MessageBox.Show("No remittance available!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If MsgBox("Do you want to save this record?", vbYesNo + vbQuestion) = vbYes Then

                    'FOR REMITTANCE IH DETAILS'
                    Try
                        Dim i As Integer
                        For i = 0 To DataGridView1.RowCount - 1
                            cn.Open()
                            cm = New MySqlCommand("INSERT INTO rcss_remittanceIH(IHrmt_transid, IHrmt_date, IHrmt_month, IHrmt_day, IHrmt_year, IHrmt_week, IHrmt_time, IHrmt_orderedBy, IHrmt_item, IHrmt_price, IHrmt_qty, IHrmt_remarks, IHrmt_status) values(@IHrmt_transid, @IHrmt_date, @IHrmt_month, @IHrmt_day, @IHrmt_year, @IHrmt_week, @IHrmt_time, @IHrmt_orderedBy, @IHrmt_item, @IHrmt_price, @IHrmt_qty, @IHrmt_remarks, @IHrmt_status)", cn)

                            cm.Parameters.AddWithValue("@IHrmt_transid", tb_IHtransID.Text)
                            cm.Parameters.AddWithValue("@IHrmt_date", DateTimePicker1.Text)
                            cm.Parameters.AddWithValue("@IHrmt_month", dtp_month.Text)
                            cm.Parameters.AddWithValue("@IHrmt_day", dtp_day.Text)
                            cm.Parameters.AddWithValue("@IHrmt_year", dtp_year.Text)
                            cm.Parameters.AddWithValue("@IHrmt_week", CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTimePicker1.Value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday))
                            cm.Parameters.AddWithValue("@IHrmt_time", frm_dashAdmin.lbl_time.Text)

                            cm.Parameters.AddWithValue("@IHrmt_orderedBy", DataGridView1.Rows(i).Cells(1).Value.ToString)
                            cm.Parameters.AddWithValue("@IHrmt_item", DataGridView1.Rows(i).Cells(2).Value.ToString)
                            cm.Parameters.AddWithValue("@IHrmt_price", CDec(DataGridView1.Rows(i).Cells(3).Value.ToString))
                            cm.Parameters.AddWithValue("@IHrmt_qty", DataGridView1.Rows(i).Cells(4).Value.ToString)
                            cm.Parameters.AddWithValue("@IHrmt_remarks", tb_remarks.Text)
                            cm.Parameters.AddWithValue("@IHrmt_status", tb_status.Text)
                            cm.ExecuteNonQuery()
                            cn.Close()
                        Next

                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try

                    'FOR REMITTANCE  DETAILS'
                    Try
                        cn.Open()
                        cm1 = New MySqlCommand("INSERT INTO rcss_remittance(rmt_transid, rmt_date, rmt_month, rmt_day, rmt_year, rmt_week, rmt_remarks, rmt_status, rmt_remsum) values(@rmt_transid, @rmt_date, @rmt_remarks, @rmt_status, @rmt_remsum)", cn)
                        cm1.Parameters.AddWithValue("@rmt_transid", tb_IHtransID.Text)

                        cm1.Parameters.AddWithValue("@rmt_date", DateTimePicker1.Text)
                        cm1.Parameters.AddWithValue("@rmt_remarks", tb_remarks.Text)
                        cm1.Parameters.AddWithValue("@rmt_status", tb_status.Text)
                        cm1.Parameters.AddWithValue("@rmt_remsum", CDec(lbl_GrandTotal.Text))
                        cm1.ExecuteNonQuery()
                        cn.Close()
                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try

                    frm_dashAdmin.CountForApproval()
                    frm_dashAdmin.CountRevise()
                    frm_dashAdmin.CountApproved()
                    frm_remittance.CountFetchIHRem()
                    frm_remittance.FetchIHRemittance()


                    RANDID()
                    frm_remittance.LoadRemittanceforApproval()
                    frm_remittance.Count()
                    MsgBox("Remittance successfully saved!", vbInformation)

                End If
            End If
            frm_remittance.CountForApproval()
            Me.Dispose()

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        dtp_month.Text = DateTimePicker1.Value.ToString("MMMM")
        dtp_day.Text = DateTimePicker1.Value.Day
        dtp_year.Text = DateTimePicker1.Value.Year
    End Sub
End Class