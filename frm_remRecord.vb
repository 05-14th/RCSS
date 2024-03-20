Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class frm_remRecord

    Private selectedYear As String
    Private selectedMonth As String
    Private selectedWeek As String
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()

    End Sub

    Sub GetWeeklyRecord()
        GetCollectionValue()
        'CountAndCalculate("SELECT COUNT(*) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_week = @TargetYear", "SELECT SUM(remDB_total) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_week = @TargetYear", selectedWeek)
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance a INNER JOIN rcss_rembd b ON a.rmt_transid = b.remDB_transid AND a.rmt_status = 'Approved' AND a.rmt_week = " & selectedWeek & "", cn)
            dr = cm.ExecuteReader()
            While dr.Read

                DataGridView2.Rows.Add(dr.Item("rmt_date"), dr.Item("rmt_vanno").ToString, dr.Item("rmt_custodian").ToString, CDec(dr.Item("remDB_cash").ToString), CDec(dr.Item("remDB_coins").ToString), CDec(dr.Item("remDB_gcash").ToString), CDec(dr.Item("remDB_online").ToString), CDec(dr.Item("remDB_check").ToString), CDec(dr.Item("remDB_ar").ToString), CDec(dr.Item("remDB_return").ToString), CDec(dr.Item("remDB_bo").ToString), CDec(dr.Item("remDB_discount").ToString), CDec(dr.Item("remDB_expenses").ToString), CDec(dr.Item("remDB_total")))

            End While
            dr.Close()
            cn.Close()
            ComputeRows()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Sub GetMonthlyRecord()
        'CountAndCalculateMonth("SELECT COUNT(*) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_month = @TargetMonth", "SELECT SUM(remDB_total) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_month = @TargetMonth", selectedMonth)
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance a INNER JOIN rcss_rembd b WHERE a.rmt_transid = b.remDB_transid AND a.rmt_status = 'Approved' AND a.rmt_month = '" & selectedMonth & "'", cn)
            dr = cm.ExecuteReader()
            While dr.Read

                DataGridView2.Rows.Add(dr.Item("rmt_date"), dr.Item("rmt_vanno").ToString, dr.Item("rmt_custodian").ToString, CDec(dr.Item("remDB_cash").ToString), CDec(dr.Item("remDB_coins").ToString), CDec(dr.Item("remDB_gcash").ToString), CDec(dr.Item("remDB_online").ToString), CDec(dr.Item("remDB_check").ToString), CDec(dr.Item("remDB_ar").ToString), CDec(dr.Item("remDB_return").ToString), CDec(dr.Item("remDB_bo").ToString), CDec(dr.Item("remDB_discount").ToString), CDec(dr.Item("remDB_expenses").ToString), CDec(dr.Item("remDB_total")))

            End While
            dr.Close()
            cn.Close()
            ComputeRows()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Sub GetYearlyRecord()
        'CountAndCalculate("SELECT COUNT(*) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_year = @TargetYear", "SELECT SUM(remDB_total) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_year = @TargetYear", selectedYear)
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance a INNER JOIN rcss_rembd b ON a.rmt_transid = b.remDB_transid WHERE a.rmt_status = 'Approved' AND a.rmt_year = '" & selectedYear & "'", cn)
            dr = cm.ExecuteReader()
            While dr.Read

                DataGridView2.Rows.Add(dr.Item("rmt_date"), dr.Item("rmt_vanno").ToString, dr.Item("rmt_custodian").ToString, CDec(dr.Item("remDB_cash").ToString), CDec(dr.Item("remDB_coins").ToString), CDec(dr.Item("remDB_gcash").ToString), CDec(dr.Item("remDB_online").ToString), CDec(dr.Item("remDB_check").ToString), CDec(dr.Item("remDB_ar").ToString), CDec(dr.Item("remDB_return").ToString), CDec(dr.Item("remDB_bo").ToString), CDec(dr.Item("remDB_discount").ToString), CDec(dr.Item("remDB_expenses").ToString), CDec(dr.Item("remDB_total")))

            End While
            dr.Close()
            cn.Close()
            ComputeRows()
        Catch ex As Exception
            'MsgBox(ex.Message)
            cn.Close()
        End Try


    End Sub
    Sub calculateTotal()
        Try
            cn.Open()
            Dim query As String = "SELECT SUM(remDB_coins), SUM(remDB_cash), SUM(remDB_gcash), SUM(remDB_online), SUM(remDB_check), SUM(remDB_ar) FROM rcss_rembd a INNER JOIN rcss_remittance b ON b.rmt_transid = a.remDB_transid WHERE b.rmt_status = 'Approved'"

            Using cm As New MySqlCommand(query, cn)
                Dim reader As MySqlDataReader = cm.ExecuteReader()

                If reader.Read() Then
                    Dim sumCoins As Integer = Convert.ToDouble(reader(0))
                    Dim sumCash As Integer = Convert.ToDouble(reader(1))
                    Dim sumGcash As Integer = Convert.ToDouble(reader(2))
                    Dim sumOnline As Integer = Convert.ToDouble(reader(3))
                    Dim sumCheck As Integer = Convert.ToDouble(reader(4))
                    Dim sumAr As Integer = Convert.ToDouble(reader(5))

                    'lbl_totalCash.Text = sumCash.ToString()
                    lbl_totalCash.Text = String.Format("₱{0:#,##0.00}", sumCash)

                    'lbl_totalCoins.Text = sumCoins.ToString()
                    lbl_totalCoins.Text = String.Format("₱{0:#,##0.00}", sumCoins)

                    'lbl_totalGCash.Text = sumGcash.ToString()
                    lbl_totalGCash.Text = String.Format("₱{0:#,##0.00}", sumGcash)

                    'lbl_totalOBanking.Text = sumOnline.ToString()
                    lbl_totalOBanking.Text = String.Format("₱{0:#,##0.00}", sumOnline)

                    'lbl_totalCheck.Text = sumCheck.ToString()
                    lbl_totalCheck.Text = String.Format("₱{0:#,##0.00}", sumCheck)

                    'lbl_totalAR.Text = sumAr.ToString()
                    lbl_totalAR.Text = String.Format("₱{0:#,##0.00}", sumAr)
                End If

                reader.Close()


            End Using
            cn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub
    'Sub CountAndCalculate(countQuery As String, sumQuery As String, Optional yearSelected As String = "2024")
    '    Console.WriteLine(yearSelected)
    '    Try
    '        cn.Open()
    '        Dim query As String = countQuery

    '        Using cm As New MySqlCommand(query, cn)
    '            cm.Parameters.AddWithValue("@TargetYear", yearSelected)

    '            Dim recordCount As Integer = Convert.ToInt32(cm.ExecuteScalar())

    '            If recordCount > 1 Then
    '                lblCount.Text = $"({recordCount}) records found"
    '            Else
    '                lblCount.Text = $"({recordCount}) record found"
    '            End If
    '        End Using
    '        cn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        lblCount.Text = "(0) record found"
    '        cn.Close()
    '    End Try

    '    Try
    '        cn.Open()
    '        Dim query As String = sumQuery
    '        Using cm As New MySqlCommand(query, cn)
    '            cm.Parameters.AddWithValue("@TargetYear", yearSelected)
    '            Dim grandTotal As Integer = 0
    '            Dim result As Object = cm.ExecuteScalar()
    '            If result IsNot DBNull.Value Then
    '                grandTotal = Convert.ToInt32(result)
    '            End If
    '            lblSum.Text = $"Grand Total: {grandTotal}"
    '        End Using
    '        cn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        lblSum.Text = "Grand Total: 0"
    '        cn.Close()
    '    End Try
    'End Sub

    'Sub CountAndCalculateMonth(countQuery As String, sumQuery As String, Optional monthSelected As String = "January")
    '    Try
    '        Dim targetMonth As String = monthSelected
    '        cn.Open()
    '        Dim query As String = countQuery

    '        Using cm As New MySqlCommand(query, cn)
    '            cm.Parameters.AddWithValue("@TargetMonth", targetMonth)

    '            Dim recordCount As Integer = Convert.ToInt32(cm.ExecuteScalar())
    '            If recordCount > 1 Then
    '                lblCount.Text = $"({recordCount}) records found"
    '            Else
    '                lblCount.Text = $"({recordCount}) record found"
    '            End If
    '        End Using
    '        cn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        lblCount.Text = "(0) record found"
    '        cn.Close()
    '    End Try

    '    Try
    '        Dim targetMonth As String = monthSelected
    '        cn.Open()
    '        Dim query As String = sumQuery
    '        Using cm As New MySqlCommand(query, cn)
    '            cm.Parameters.AddWithValue("@TargetMonth", targetMonth)
    '            Dim grandTotal As Integer = 0
    '            Dim result As Object = cm.ExecuteScalar()
    '            If result IsNot DBNull.Value Then
    '                grandTotal = Convert.ToInt32(result)
    '            End If
    '            lblSum.Text = $"Grand Total: {grandTotal}"
    '        End Using
    '        cn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        lblSum.Text = "Grand Total: 0"
    '        cn.Close()
    '    End Try
    'End Sub
    Sub Loadrecord()
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand($"SELECT * FROM rcss_remittance a INNER JOIN rcss_rembd b ON a.rmt_transid = b.remDB_transid WHERE a.rmt_status = 'Approved' AND a.rmt_date = '{DateTimePicker1.Text}'", cn)
            dr = cm.ExecuteReader()
            While dr.Read()

                DataGridView2.Rows.Add(dr.Item("rmt_date"), dr.Item("rmt_vanno").ToString, dr.Item("rmt_custodian").ToString, CDec(dr.Item("remDB_cash").ToString), CDec(dr.Item("remDB_coins").ToString), CDec(dr.Item("remDB_gcash").ToString), CDec(dr.Item("remDB_online").ToString), CDec(dr.Item("remDB_check").ToString), CDec(dr.Item("remDB_ar").ToString), CDec(dr.Item("remDB_return").ToString), CDec(dr.Item("remDB_bo").ToString), CDec(dr.Item("remDB_discount").ToString), CDec(dr.Item("remDB_expenses").ToString), CDec(dr.Item("remDB_total")))

            End While
            dr.Close()
            cn.Close()
            ComputeRows()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
        '    Try
        '        DataGridView2.Rows.Clear()
        '        cn.Open()
        '        cm = New MySqlCommand("SELECT * FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_date = '" & DateTimePicker1.Text & "'", cn)
        '        dr = cm.ExecuteReader()
        '        While dr.Read

        '            DataGridView2.Rows.Add(dr.Item("rmt_date"), dr.Item("rmt_vanno").ToString, dr.Item("rmt_custodian").ToString, CDec(dr.Item("remDB_cash").ToString), CDec(dr.Item("remDB_coins").ToString), CDec(dr.Item("remDB_gcash").ToString), CDec(dr.Item("remDB_online").ToString), CDec(dr.Item("remDB_check").ToString), CDec(dr.Item("remDB_ar").ToString), CDec(dr.Item("remDB_return").ToString), CDec(dr.Item("remDB_bo").ToString), CDec(dr.Item("remDB_discount").ToString), CDec(dr.Item("remDB_expenses").ToString), CDec(dr.Item("remDB_total")))

        '        End While
        '        dr.Close()
        '        cn.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        cn.Close()
        '    End Try
        '    CountAndCalculate($"SELECT COUNT(*) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_date = '{DateTimePicker1.Text}'", $"SELECT SUM(remDB_total) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_date = '{DateTimePicker1.Text}'")

    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
    Sub ComputeRows()
        If (DataGridView2.Rows.Count > 0) Then
            Dim lastIndex As Integer = DataGridView2.Rows.Count - 1
            DataGridView2.Rows.RemoveAt(lastIndex)
        End If

        Dim total1, total2, total3, total4, total5, total6, total7, total8, total9, total10, total11, total12
        For i As Integer = 0 To DataGridView2.RowCount - 1
            'total1 += DataGridView2.Rows(i).Cells(2).Value
            total2 += DataGridView2.Rows(i).Cells(3).Value
            total3 += DataGridView2.Rows(i).Cells(4).Value
            total4 += DataGridView2.Rows(i).Cells(5).Value
            total5 += DataGridView2.Rows(i).Cells(6).Value
            total6 += DataGridView2.Rows(i).Cells(7).Value
            total7 += DataGridView2.Rows(i).Cells(8).Value
            total8 += DataGridView2.Rows(i).Cells(9).Value
            total9 += DataGridView2.Rows(i).Cells(10).Value
            total10 += DataGridView2.Rows(i).Cells(11).Value
            total11 += DataGridView2.Rows(i).Cells(12).Value
            total12 += DataGridView2.Rows(i).Cells(13).Value
        Next
        DataGridView2.Rows.Add(Nothing, "TOTAL", Nothing, total2, total3, total4, total5, total6, total7, total8, total9, total10, total11, total12)
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Index = DataGridView2.Rows.Count - 1 Then
                row.DefaultCellStyle.BackColor = Color.LightGray
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold)

            End If
        Next

        Dim rowCount As Int32 = DataGridView2.Rows.Count
        If rowCount > 0 Then
            lblCount.Text = $"({rowCount - 1}) record found"

        Else
            lblCount.Text = $"({rowCount - 1}) records found"

        End If
        lblSum.Text = $"Grand Total: {total12}"

    End Sub

    Private Sub frm_remRecord_Load(sender As Object, e As EventArgs) Handles Me.Load
        Loadrecord()
        ComputeRows()
        calculateTotal()
        filterSelector.SelectedIndex = 0
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        ' frm_rptRemRecord.ShowDialog()
        Try
            With frm_rptRemRecord
                .TopLevel = False
                frm_dashAdmin.Panel5.Controls.Add(frm_rptRemRecord)
                .BringToFront()
                .Show()
            End With
        Catch ex As Exception

        End Try


    End Sub

    Sub GetCollectionValue()
        If ComboBox3.SelectedItem IsNot Nothing Then

            Dim selectedText As String = ComboBox3.SelectedItem.ToString()
            Dim weekNumber As Integer
            If Integer.TryParse(Regex.Match(selectedText, "\d+").Value, weekNumber) Then
                selectedWeek = weekNumber
            Else
                MessageBox.Show("Unable to determine the week number.")
            End If
        End If
    End Sub

    Private Sub PopulateWeeksComboBox()

        Dim currentYear As Integer = DateTime.Now.Year
        Dim firstDayOfYear As New DateTime(currentYear, 1, 1)

        ComboBox3.Items.Clear()


        For weekNumber As Integer = 1 To 52
            Dim startDate As DateTime = firstDayOfYear.AddDays((weekNumber - 1) * 7)
            Dim endDate As DateTime = startDate.AddDays(6)
            Dim weekText As String = $"Week {weekNumber}: {startDate.ToShortDateString()} - {endDate.ToShortDateString()}"
            ComboBox3.Items.Add(weekText)
        Next

        ComboBox3.SelectedIndex = 0
    End Sub


    Private Sub filterSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterSelector.SelectedIndexChanged
        If filterSelector.SelectedItem Is "DAILY" Then
            dailyPanel.Visible = True
            dailyPanel.BringToFront()
        ElseIf filterSelector.SelectedItem Is "WEEKLY" Then
            PopulateWeeksComboBox()
            weeklyPanel.Visible = True
            weeklyPanel.BringToFront()
        ElseIf filterSelector.SelectedItem Is "MONTHLY" Then
            monthlyPanel.Visible = True
            monthlyPanel.BringToFront()
        ElseIf filterSelector.SelectedItem Is "YEARLY" Then
            yearlyPanel.Visible = True
            yearlyPanel.BringToFront()
        End If
    End Sub


    Private Sub YearInput_TextChanged(sender As Object, e As EventArgs) Handles YearInput.TextChanged
        selectedYear = YearInput.Text
        GetYearlyRecord()
        'ComputeRows()
        DataGridView2.BringToFront()
    End Sub

    Private Sub YearInput_GotFocus(sender As Object, e As EventArgs) Handles YearInput.GotFocus
        If YearInput.Text = "Type a Year..." Then
            YearInput.Text = ""
            YearInput.ForeColor = Color.Black ' Set the text color back to black
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        selectedWeek = (ComboBox3.SelectedIndex + 1).ToString()
        GetWeeklyRecord()

        DataGridView2.BringToFront()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_monthly.SelectedIndexChanged
        selectedMonth = cb_monthly.Text
        GetMonthlyRecord()
        DataGridView2.BringToFront()
    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs)
        Loadrecord()
        DataGridView2.BringToFront()
        'Loadrecord()
        'DataGridView2.BringToFront()
        'ComputeRows()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Loadrecord()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class