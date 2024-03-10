Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class frm_remRecord

    Private selectedYear As String
    Private selectedMonth As String
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()

    End Sub

    Sub GetMonthlyRecord()
        Try
            GetYearlyRecord()
            CountAndCalculate("SELECT COUNT(*) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_year = @TargetYear", "SELECT SUM(remDB_total) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_year = @TargetYear", selectedMonth)
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_month = '" & ComboBox2.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read

                DataGridView2.Rows.Add(dr.Item("remDB_date").ToString, dr.Item("remDB_time").ToString, CDec(dr.Item("remDB_cash").ToString), CDec(dr.Item("remDB_coins").ToString), CDec(dr.Item("remDB_gcash").ToString), CDec(dr.Item("remDB_online").ToString), CDec(dr.Item("remDB_check").ToString), CDec(dr.Item("remDB_ar").ToString), CDec(dr.Item("remDB_return").ToString), CDec(dr.Item("remDB_bo").ToString), CDec(dr.Item("remDB_discount").ToString), CDec(dr.Item("remDB_expenses").ToString), CDec(dr.Item("remDB_total")))

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Sub GetYearlyRecord()
        CountAndCalculate("SELECT COUNT(*) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_year = @TargetYear", "SELECT SUM(remDB_total) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_year = @TargetYear", selectedYear)
        Try
            Dim targetYear As Integer = ComboBox1.Text
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_year = '" & ComboBox1.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read

                DataGridView2.Rows.Add(dr.Item("remDB_date").ToString, dr.Item("remDB_time").ToString, CDec(dr.Item("remDB_cash").ToString), CDec(dr.Item("remDB_coins").ToString), CDec(dr.Item("remDB_gcash").ToString), CDec(dr.Item("remDB_online").ToString), CDec(dr.Item("remDB_check").ToString), CDec(dr.Item("remDB_ar").ToString), CDec(dr.Item("remDB_return").ToString), CDec(dr.Item("remDB_bo").ToString), CDec(dr.Item("remDB_discount").ToString), CDec(dr.Item("remDB_expenses").ToString), CDec(dr.Item("remDB_total")))

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try


    End Sub

    Sub CountAndCalculate(countQuery As String, sumQuery As String, Optional ByVal yearSelected As String = "2024")
        Try

            Dim targetYear As Integer = Integer.Parse(yearSelected)

            cn.Open()
            Dim query As String = countQuery

            Using cm As New MySqlCommand(query, cn)
                Console.WriteLine(targetYear)
                cm.Parameters.AddWithValue("@TargetYear", targetYear)

                Dim recordCount As Integer = Convert.ToInt32(cm.ExecuteScalar())
                Console.WriteLine(recordCount)
                If recordCount > 1 Then
                    lblCount.Text = $"({recordCount}) records found"
                Else
                    lblCount.Text = $"({recordCount}) record found"
                End If
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            lblCount.Text = "(0) record found"
            cn.Close()
        End Try

        Try
            Dim targetYear As Integer = Integer.Parse(yearSelected)
            cn.Open()
            Dim query As String = sumQuery
            Using cm As New MySqlCommand(query, cn)
                cm.Parameters.AddWithValue("@TargetYear", targetYear)
                Dim grandTotal As Integer = 0
                Dim result As Object = cm.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    grandTotal = Convert.ToInt32(result)
                End If
                lblSum.Text = $"Grand Total: {grandTotal}"
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            lblSum.Text = "Grand Total: 0"
            cn.Close()
        End Try
    End Sub

    Sub CountAndCalculateMonth(countQuery As String, sumQuery As String, Optional ByVal monthSelected As String = "January")
        Try

            Dim targetMonth As String = monthSelected

            cn.Open()
            Dim query As String = countQuery

            Using cm As New MySqlCommand(query, cn)
                Console.WriteLine(targetMonth)
                cm.Parameters.AddWithValue("@TargetMonth", targetMonth)

                Dim recordCount As Integer = Convert.ToInt32(cm.ExecuteScalar())
                Console.WriteLine(recordCount)
                If recordCount > 1 Then
                    lblCount.Text = $"({recordCount}) records found"
                Else
                    lblCount.Text = $"({recordCount}) record found"
                End If
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            lblCount.Text = "(0) record found"
            cn.Close()
        End Try

        Try
            Dim targetMonth As String = monthSelected
            cn.Open()
            Dim query As String = sumQuery
            Using cm As New MySqlCommand(query, cn)
                cm.Parameters.AddWithValue("@TargetMonth", targetMonth)
                Dim grandTotal As Integer = 0
                Dim result As Object = cm.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    grandTotal = Convert.ToInt32(result)
                End If
                lblSum.Text = $"Grand Total: {grandTotal}"
            End Using
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            lblSum.Text = "Grand Total: 0"
            cn.Close()
        End Try
    End Sub
    Sub Loadrecord()
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_date = '" & DateTimePicker1.Text & "'", cn)
            dr = cm.ExecuteReader()
            While dr.Read

                DataGridView2.Rows.Add(dr.Item("rmt_vanno").ToString, dr.Item("rmt_custodian").ToString, CDec(dr.Item("remDB_cash").ToString), CDec(dr.Item("remDB_coins").ToString), CDec(dr.Item("remDB_gcash").ToString), CDec(dr.Item("remDB_online").ToString), CDec(dr.Item("remDB_check").ToString), CDec(dr.Item("remDB_ar").ToString), CDec(dr.Item("remDB_return").ToString), CDec(dr.Item("remDB_bo").ToString), CDec(dr.Item("remDB_discount").ToString), CDec(dr.Item("remDB_expenses").ToString), CDec(dr.Item("remDB_total")))

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
        CountAndCalculate($"SELECT COUNT(*) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_date = '{DateTimePicker1.Text}'", $"SELECT SUM(remDB_total) FROM rcss_remittance, rcss_rembd WHERE rcss_remittance.rmt_transid = rcss_rembd.remDB_transid AND rcss_remittance.rmt_status = 'Approved' AND rcss_remittance.rmt_date = '{DateTimePicker1.Text}'")
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
    Sub ComputeRows()
        Dim total1, total2, total3, total4, total5, total6, total7, total8, total9, total10 As Double
        For i As Integer = 0 To DataGridView2.RowCount - 1
            total1 += DataGridView2.Rows(i).Cells(2).Value
            total2 += DataGridView2.Rows(i).Cells(3).Value
            total3 += DataGridView2.Rows(i).Cells(4).Value
            total4 += DataGridView2.Rows(i).Cells(5).Value
            total5 += DataGridView2.Rows(i).Cells(6).Value
            total6 += DataGridView2.Rows(i).Cells(7).Value
            total7 += DataGridView2.Rows(i).Cells(8).Value
            total8 += DataGridView2.Rows(i).Cells(9).Value
            total9 += DataGridView2.Rows(i).Cells(10).Value
            total10 += DataGridView2.Rows(i).Cells(11).Value
        Next
        DataGridView2.Rows.Add(Nothing, "TOTAL", total1, total2, total3, total4, total5, total6, total7, total8, total9, total10)
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Index = DataGridView2.Rows.Count - 1 Then
                row.DefaultCellStyle.BackColor = Color.LightGray
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold)

            End If
        Next


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2.BringToFront()
        Dim currentYear As Integer = DateTime.Now.Year

        For year As Integer = 1950 To currentYear
            ComboBox1.Items.Add(year.ToString())
        Next

        ComboBox1.SelectedItem = currentYear.ToString()
    End Sub

    Private Sub frm_remRecord_Load(sender As Object, e As EventArgs) Handles Me.Load
        Loadrecord()
        ComputeRows()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Loadrecord()
        DataGridView2.BringToFront()
        ComputeRows()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        ' frm_rptRemRecord.ShowDialog()

        With frm_rptRemRecord
            .TopLevel = False
            frm_dashAdmin.Panel5.Controls.Add(frm_rptRemRecord)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        YearSelect.Visible = True
        YearSelect.BringToFront()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Loadrecord()
        DataGridView2.BringToFront()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MonthSelect.Visible = True
        MonthSelect.BringToFront()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles YearSelect.Paint
        selectedYear = ComboBox1.Text
        GetYearlyRecord()
        YearSelect.Visible = False
        DataGridView2.BringToFront()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        YearSelect.Visible = False
    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click
        selectedYear = ComboBox1.Text
        GetYearlyRecord()
        YearSelect.Visible = False
        DataGridView2.BringToFront()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        selectedMonth = ComboBox2.Text
        GetMonthlyRecord()
        MonthSelect.Visible = False
        DataGridView2.BringToFront()
    End Sub
End Class