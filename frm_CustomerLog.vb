Imports MySql.Data.MySqlClient
Public Class frm_CustomerLog
    Private Shared _instance As frm_CustomerLog
    Private Sub New()
        InitializeComponent()
    End Sub

    Public Shared Function GetInstance() As frm_CustomerLog
        If _instance Is Nothing Then
            _instance = New frm_CustomerLog()
        End If
        Return _instance
    End Function

    Private Sub frm_CustomerLog_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Hide()
    End Sub

    Public Sub LoadData(query As String)
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand(query, cn)
            dr = cm.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("remar_transid").ToString, dr.Item("remar_date").ToString, dr.Item("remar_amount").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_salesman").ToString,
                                       dr.Item("rmt_custodian").ToString, dr.Item("rmt_driver").ToString, dr.Item("rmt_helper").ToString, dr.Item("remar_status").ToString)
            End While
            accountNum.Text = dr.Item("cus_accountno").ToString
            cusName.Text = dr.Item("cus_name").ToString
            cusAddress.Text = dr.Item("cus_address").ToString
            contactPerson.Text = dr.Item("cus_contactperson").ToString
            contactNum.Text = dr.Item("cus_contactno").ToString
            TextBox6.Text = dr.Item("cus_terms").ToString

            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

        updateStats($"SELECT COUNT(*) FROM rcss_remar a INNER JOIN rcss_remittance b ON a.remar_transid = b.rmt_transid INNER JOIN rcss_customer c ON c.cus_accountno = a.remar_cusID  WHERE c.cus_accountno = '{accountNum.Text}'",
                   $"SELECT SUM(remar_amount) FROM rcss_remar a INNER JOIN rcss_remittance b ON a.remar_transid = b.rmt_transid INNER JOIN rcss_customer c ON c.cus_accountno = a.remar_cusID  WHERE c.cus_accountno  = '{accountNum.Text}'")
    End Sub

    Public Sub LoadTableData(query As String)
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand(query, cn)
            dr = cm.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("remar_transid").ToString, dr.Item("remar_date").ToString, dr.Item("remar_amount").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_salesman").ToString,
                                       dr.Item("rmt_custodian").ToString, dr.Item("rmt_driver").ToString, dr.Item("rmt_helper").ToString, dr.Item("remar_status").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles contactPerson.TextChanged

    End Sub

    Sub updateStats(countQuery As String, totalArQuery As String)
        Try
            cn.Open()
            cm = New MySqlCommand(countQuery, cn)
            Dim countResult As Integer = Convert.ToInt32(cm.ExecuteScalar())
            If countResult = 0 Then
                lbl_totalRecord.Text = $"({countResult}) record found"
            Else
                lbl_totalRecord.Text = $"({countResult}) records found"
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
            lbl_totalAmount.Text = $"Total Amount: {totalArResult}"
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        LoadTableData($"SELECT * FROM rcss_remar a INNER JOIN rcss_remittance b ON a.remar_transid = b.rmt_transid INNER JOIN rcss_customer c ON c.cus_accountno = a.remar_cusID  WHERE a.remar_transid LIKE '%{search.Text}%' AND cus_accountno LIKE '%{accountNum.Text}%'")
        updateStats($"SELECT COUNT(*) FROM rcss_remar a INNER JOIN rcss_remittance b ON a.remar_transid = b.rmt_transid INNER JOIN rcss_customer c ON c.cus_accountno = a.remar_cusID  WHERE a.remar_transid LIKE '%{search.Text}%' AND cus_accountno = '{accountNum.Text}'",
                    $"SELECT SUM(remar_amount) FROM rcss_remar a INNER JOIN rcss_remittance b ON a.remar_transid = b.rmt_transid INNER JOIN rcss_customer c ON c.cus_accountno = a.remar_cusID  WHERE a.remar_transid LIKE '%{search.Text}%' AND cus_accountno = '{accountNum.Text}'")
    End Sub

    Private Sub TextBox_Click(sender As Object, e As EventArgs) Handles search.Click
        If search.Text = "Search Transaction #" Then
            search.Text = ""
        End If
    End Sub
End Class