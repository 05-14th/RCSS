Imports MySql.Data.MySqlClient
Public Class frm_arMonitoringSummary
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub frm_arMonitoringSummary_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadARData($"SELECT * FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND  remar_date = '{dailyPicker.Text}'")
        populateSelections()
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
            Dim totalArResult As Decimal = 0.0
            cn.Open()
            cm = New MySqlCommand(totalArQuery, cn)
            If cm.ExecuteScalar() IsNot Nothing AndAlso cm.ExecuteScalar() IsNot DBNull.Value Then
                totalArResult = Convert.ToDecimal(cm.ExecuteScalar())
            End If
            lblAR.Text = $"Total AR: {totalArResult}"
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

        Try
            Dim totalArResult As Decimal = 0.0
            cn.Open()
            cm = New MySqlCommand(totalAmountQuery, cn)
            If cm.ExecuteScalar() IsNot Nothing AndAlso cm.ExecuteScalar() IsNot DBNull.Value Then
                totalArResult = Convert.ToDecimal(cm.ExecuteScalar())
            End If
            lblTotalDue.Text = $"Total Amount Due: {totalArResult}"
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Sub LoadARData(dataQuery As String)
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand(dataQuery, cn)
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

    Sub populateSelections()
        Dim query As String = "SELECT DISTINCT cus_address FROM rcss_customer"


        Using command As New MySqlCommand(query, cn)
            cn.Open()

            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    areaSelect.Items.Add(reader("cus_address").ToString())
                End While
            End Using
            cn.Close()
        End Using

        Dim stringQuery As String = "SELECT DISTINCT cus_name FROM rcss_customer"


        Using command As New MySqlCommand(stringQuery, cn)
            cn.Open()

            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    cusSelect.Items.Add(reader("cus_name").ToString())
                End While
            End Using
            cn.Close()
        End Using
    End Sub

    Function calculateDaysLeft(daysVal As String) As Integer
        Dim dueDate As DateTime = DateTime.Parse(daysVal)
        Dim curDate As DateTime = DateTime.Now
        Dim numberOfDays As Integer = (curDate - dueDate).Days
        Return numberOfDays - 1
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

    Sub togglePanelVisibility(dailyStat As Boolean, cusStat As Boolean, areaStat As Boolean)
        dailyPanel.Visible = dailyStat
        cus_namePanel.Visible = cusStat
        areaPanel.Visible = areaStat
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterSelect.SelectedIndexChanged
        If filterSelect.SelectedItem Is "DAILY" Then
            togglePanelVisibility(True, False, False)
        ElseIf filterSelect.SelectedItem Is "CUSTOMER" Then
            togglePanelVisibility(False, True, False)
        ElseIf filterSelect.SelectedItem Is "AREA" Then
            togglePanelVisibility(False, False, True)
        ElseIf filterSelect.SelectedItem Is "VIEW ALL" Then
            togglePanelVisibility(False, False, False)
            LoadARData($"SELECT * FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name")
            updateStats($"SELECT COUNT(*) FROM rcss_remar INNER JOIN rcss_customer ON rcss_remar.remar_customer = rcss_customer.cus_name",
                        $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name",
                        $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND CURDATE() >= DATE_ADD(DATE_FORMAT(STR_TO_DATE(remar_date, '%m/%d/%Y'), '%Y-%m-%d'), INTERVAL 7 DAY);")
        End If
    End Sub

    Private Sub lblSum_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dailyPicker_ValueChanged(sender As Object, e As EventArgs) Handles dailyPicker.ValueChanged
        LoadARData($"SELECT * FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND remar_date = '{dailyPicker.Text}'")
        updateStats($"SELECT COUNT(*) FROM rcss_remar INNER JOIN rcss_customer ON rcss_remar.remar_customer = rcss_customer.cus_name WHERE remar_date = '{dailyPicker.Text}'",
                    $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND remar_date = '{dailyPicker.Text}'",
                    $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND CURDATE() >= DATE_ADD(DATE_FORMAT(STR_TO_DATE(remar_date, '%m/%d/%Y'), '%Y-%m-%d'), INTERVAL 7 DAY) AND remar_date = '{dailyPicker.Text}';")
    End Sub

    Private Sub areaSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles areaSelect.SelectedIndexChanged
        LoadARData($"SELECT * FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND cus_address = '{areaSelect.Text}'")
        updateStats($"SELECT COUNT(*) FROM rcss_remar INNER JOIN rcss_customer ON rcss_remar.remar_customer = rcss_customer.cus_name WHERE cus_address = '{areaSelect.Text}'",
             $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND cus_address = '{areaSelect.Text}'",
             $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND CURDATE() >= DATE_ADD(DATE_FORMAT(STR_TO_DATE(remar_date, '%m/%d/%Y'), '%Y-%m-%d'), INTERVAL 7 DAY) AND cus_address = '{areaSelect.Text}';")
    End Sub

    Private Sub cusName_TextChanged(sender As Object, e As EventArgs)
        'LoadARData($"SELECT * FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND remar_date = '{yearText.Text}'")
        ' updateStats($"SELECT COUNT(*) FROM rcss_remar INNER JOIN rcss_customer ON rcss_remar.remar_customer = rcss_customer.cus_name WHERE remar_date = '{yearText.Text}'",
        ' $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND remar_date = '{yearText.Text}'",
        ' $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND CURDATE() >= DATE_ADD(DATE_FORMAT(STR_TO_DATE(remar_date, '%m/%d/%Y'), '%Y-%m-%d'), INTERVAL 7 DAY) AND remar_date = '{yearText.Text}';")
    End Sub

    Private Sub cusSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cusSelect.SelectedIndexChanged
        LoadARData($"SELECT * FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND cus_name = '{cusSelect.Text}'")
        updateStats($"SELECT COUNT(*) FROM rcss_remar INNER JOIN rcss_customer ON rcss_remar.remar_customer = rcss_customer.cus_name WHERE cus_name = '{cusSelect.Text}'",
             $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND cus_name = '{cusSelect.Text}'",
             $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND CURDATE() >= DATE_ADD(DATE_FORMAT(STR_TO_DATE(remar_date, '%m/%d/%Y'), '%Y-%m-%d'), INTERVAL 7 DAY) AND cus_name = '{cusSelect.Text}';")
    End Sub

    Private Sub areaPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class