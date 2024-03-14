Imports MySql.Data.MySqlClient
Public Class frm_arMonitoringSummary
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub frm_arMonitoringSummary_Load(sender As Object, e As EventArgs) Handles Me.Load
        computeTotal_AR()
        LoadARData($"SELECT * FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid WHERE remar_date = '{dailyPicker.Text}'")
        populateSelections()
    End Sub
    Sub computeTotal_AR()

        Try

            cn.Open()
            cm = New MySqlCommand("SELECT SUM(remar_amount) FROM rcss_remar", cn)
            Dim result As Object = cm.ExecuteScalar()
            ' Check if the result is not null
            If result IsNot DBNull.Value Then
                ' Convert the result to the appropriate data type
                Dim sum As Decimal = Convert.ToDecimal(result)
                Dim formattedSum As String = String.Format("₱{0:#,##0.00}", sum)
                ' Alternatively, you can use string interpolation:
                ' Dim formattedSum As String = $"{sum:0.00}"
                Lbl_Total_AR.Text = formattedSum

            Else
                MessageBox.Show("No Record Found", "RCSS - Message!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Function getRE(termValue As Integer, daysValue As Integer) As String

        If daysValue >= termValue Then
            Return "Due"
        Else
            Return " "
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
                Dim convertedDate As Date = Date.ParseExact(dr.Item("remar_date"), "MM/dd/yyyy", Nothing).AddDays(7)
                Dim dateString As String = convertedDate.ToString("MM/dd/yyyy")
                DataGridView2.Rows.Add(dr.Item("cus_name"), dr.Item("cus_contactno").ToString, dr.Item("van_route").ToString, 7, dr.Item("remar_date").ToString, dr.Item("remar_transid").ToString, dr.Item("remar_amount").ToString, calculateDaysLeft(convertedDate), dateString, getRE(7, calculateDaysLeft(convertedDate)), dr.Item("rmt_salesman").ToString, dr.Item("remar_status").ToString, " ")
                'AutoSizeCells()
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Sub populateSelections()
        Dim query As String = "SELECT DISTINCT van_route FROM rcss_van"


        Using command As New MySqlCommand(query, cn)
            cn.Open()

            Using reader As MySqlDataReader = command.ExecuteReader()
                While reader.Read()
                    areaSelect.Items.Add(reader("van_route").ToString())
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
        Dim dueDate As DateTime
        If DateTime.TryParse(daysVal, dueDate) Then
            Dim curDate As DateTime = DateTime.Now.Date
            Dim numberOfDays As Integer = (curDate - dueDate.Date).Days
            Return numberOfDays
        End If
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
            LoadARData("SELECT * FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno")
            updateStats($"SELECT COUNT(*) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno",
                    $"SELECT SUM(remar_amount) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno",
                    $"SELECT SUM(remar_amount) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE CURDATE() >= DATE_ADD(DATE_FORMAT(STR_TO_DATE(remar_date, '%m/%d/%Y'), '%Y-%m-%d'), INTERVAL 7 DAY)")
        End If
    End Sub

    Private Sub lblSum_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dailyPicker_ValueChanged(sender As Object, e As EventArgs) Handles dailyPicker.ValueChanged
        LoadARData($"SELECT * FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE remar_date = '{dailyPicker.Text}'")
        updateStats($"SELECT COUNT(*) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE remar_date = '{dailyPicker.Text}'",
                    $"SELECT SUM(remar_amount) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE remar_date = '{dailyPicker.Text}'",
                    $"SELECT SUM(remar_amount) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE CURDATE() >= DATE_ADD(DATE_FORMAT(STR_TO_DATE(remar_date, '%m/%d/%Y'), '%Y-%m-%d'), INTERVAL 7 DAY) AND remar_date = '{dailyPicker.Text}'")
    End Sub

    Private Sub areaSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles areaSelect.SelectedIndexChanged
        LoadARData($"SELECT * FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE rcss_van.van_route = '{areaSelect.Text}'")
        updateStats($"SELECT COUNT(*) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE rcss_van.van_route = '{areaSelect.Text}'",
                    $"SELECT SUM(remar_amount) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE rcss_van.van_route = '{areaSelect.Text}'",
                    $"SELECT SUM(remar_amount) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE CURDATE() >= DATE_ADD(DATE_FORMAT(STR_TO_DATE(remar_date, '%m/%d/%Y'), '%Y-%m-%d'), INTERVAL 7 DAY) AND rcss_van.van_route = '{areaSelect.Text}'")
    End Sub

    Private Sub cusName_TextChanged(sender As Object, e As EventArgs)
        'LoadARData($"SELECT * FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND remar_date = '{yearText.Text}'")
        ' updateStats($"SELECT COUNT(*) FROM rcss_remar INNER JOIN rcss_customer ON rcss_remar.remar_customer = rcss_customer.cus_name WHERE remar_date = '{yearText.Text}'",
        ' $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND remar_date = '{yearText.Text}'",
        ' $"SELECT SUM(remar_amount) FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name AND CURDATE() >= DATE_ADD(DATE_FORMAT(STR_TO_DATE(remar_date, '%m/%d/%Y'), '%Y-%m-%d'), INTERVAL 7 DAY) AND remar_date = '{yearText.Text}';")
    End Sub

    Private Sub cusSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cusSelect.SelectedIndexChanged
        LoadARData($"SELECT * FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE cus_name = '{cusSelect.Text}'")
        updateStats($"SELECT COUNT(*) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE cus_name = '{cusSelect.Text}'",
                    $"SELECT SUM(remar_amount) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE cus_name = '{cusSelect.Text}'",
                    $"SELECT SUM(remar_amount) FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno WHERE CURDATE() >= DATE_ADD(DATE_FORMAT(STR_TO_DATE(remar_date, '%m/%d/%Y'), '%Y-%m-%d'), INTERVAL 7 DAY) AND cus_name = '{cusSelect.Text}'")
    End Sub

    Private Sub areaPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        With frm_rptArsRecord
            .TopLevel = False
            frm_dashAdmin.Panel5.Controls.Add(frm_rptArsRecord)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class