Imports MySql.Data.MySqlClient
Public Class frm_arMonitoringSummary
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub frm_arMonitoringSummary_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadARData()
    End Sub

    Function getRE(dateValue As String) As String
        Dim currentDate As DateTime = DateTime.Now
        Dim dueDate As DateTime = DateTime.Parse(dateValue)

        ' Compare date1 with currentDate
        If dueDate > currentDate Then
            Return "Not Due"
        ElseIf dueDate = currentDate Then
            Return "Due"
        Else
            Return "Overdue"
        End If
    End Function

    Sub updateStats(countQuery As String, totalArQuery As String, totalAmountQuery As String)
        Try
            cn.Open()
            cm = New MySqlCommand(countQuery, cn)
            Dim countResult As Integer = Convert.ToInt32(cm.ExecuteScalar())
            If countResult = 0 Then
                lblCount.Text = $"({countResult}) record found"
            Else
                lblCount.Text = $"({countResult}) records found"
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

        Try
            cn.Open()
            cm = New MySqlCommand(totalArQuery, cn)
            Dim totalArResult As Integer = Convert.ToDecimal(cm.ExecuteScalar())
            lblAR.Text = $"Total AR: {totalArResult}"
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

        Try
            cn.Open()
            cm = New MySqlCommand(totalAmountQuery, cn)
            Dim totalArResult As Integer = Convert.ToDecimal(cm.ExecuteScalar())
            lblTotalDue.Text = $"Total Amount Due: {totalArResult}"
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Sub LoadARData()
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name", cn)
            dr = cm.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("cus_name"), dr.Item("cus_contactno").ToString, dr.Item("cus_address").ToString, 7, dr.Item("remar_date").ToString, dr.Item("remar_transid").ToString, dr.Item("remar_amount").ToString, calculateDaysLeft(DateTime.ParseExact(dr.Item("remar_date").ToString(), "MM/dd/yyyy", Nothing).AddDays(7).ToString("MM/dd/yyyy")), DateTime.ParseExact(dr.Item("remar_date").ToString(), "MM/dd/yyyy", Nothing).AddDays(7).ToString("MM/dd/yyyy"), getRE(DateTime.ParseExact(dr.Item("remar_date").ToString(), "MM/dd/yyyy", Nothing).AddDays(7).ToString("MM/dd/yyyy")), dr.Item("cus_contactperson").ToString, dr.Item("remar_status").ToString, " ")
                'AutoSizeCells()
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

        updateStats($"SELECT COUNT(*) FROM rcss_remar INNER JOIN rcss_customer ON rcss_remar.remar_customer = rcss_customer.cus_name WHERE DATE(remar_date) = {DateTime.Now.Date.ToString("yyyy-MM-dd")}",
                    $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name",
                    $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND CURDATE() >= DATE_ADD(DATE_FORMAT(STR_TO_DATE(remar_date, '%m/%d/%Y'), '%Y-%m-%d'), INTERVAL 7 DAY);")
    End Sub

    Function calculateDaysLeft(daysVal As String) As Integer
        Dim dueDate As DateTime = DateTime.Parse(daysVal)
        Dim curDate As DateTime = DateTime.Now
        Dim numberOfDays As Integer = (curDate - dueDate).Days
        Return numberOfDays
    End Function

    Sub AutoSizeCells()

        For Each column As DataGridViewColumn In DataGridView2.Columns
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            Dim maxWidth As Integer = 0
            For Each row As DataGridViewRow In DataGridView2.Rows
                Dim cellValue As Object = row.Cells(column.Index).Value
                Dim cellWidth As Integer = TextRenderer.MeasureText(cellValue.ToString(), DataGridView2.Font).Width + 20
                If cellWidth > maxWidth Then
                    maxWidth = cellWidth
                End If
            Next


            column.Width = maxWidth
        Next

    End Sub

    Sub togglePanelVisibility(dailyStat As Boolean, weeklyStat As Boolean, monthlyStat As Boolean, yearlyStat As Boolean)
        dailyPanel.Visible = dailyStat
        weeklyPanel.Visible = weeklyStat
        monthlyPanel.Visible = monthlyStat
        yearlyPanel.Visible = yearlyStat
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterSelect.SelectedIndexChanged
        If filterSelect.SelectedItem Is "DAILY" Then
            togglePanelVisibility(True, False, False, False)
        ElseIf filterSelect.SelectedItem Is "WEEKLY" Then
            togglePanelVisibility(False, True, False, False)
        ElseIf filterSelect.SelectedItem Is "MONTHLY" Then
            togglePanelVisibility(False, False, True, False)
        ElseIf filterSelect.SelectedItem Is "YEARLY" Then
            togglePanelVisibility(False, False, False, True)
        End If
    End Sub

    Private Sub lblSum_Click(sender As Object, e As EventArgs) Handles lblAR.Click

    End Sub
End Class