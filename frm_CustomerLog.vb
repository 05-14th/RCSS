Imports MySql.Data.MySqlClient
Public Class frm_CustomerLog
    'Private Shared _instance As frm_CustomerLog
    'Private Sub New()
    '    InitializeComponent()
    'End Sub

    'Public Shared Function GetInstance() As frm_CustomerLog
    '    If _instance Is Nothing Then
    '        _instance = New frm_CustomerLog()
    '    End If
    '    Return _instance
    'End Function

    Private Sub frm_CustomerLog_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Hide()
    End Sub

    Public Sub LoadData()
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remar a INNER JOIN rcss_customer c ON c.cus_accountno = a.remar_cusID  WHERE a.remar_customer = '" & tb_accountNum.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("remar_transid").ToString, dr.Item("remar_date").ToString, dr.Item("remar_amount").ToString, dr.Item("remar_invoice").ToString, dr.Item("remar_refnum").ToString)
            End While
            'accountNum.Text = dr.Item("cus_accountno").ToString
            'cusName.Text = dr.Item("cus_name").ToString
            'cusAddress.Text = dr.Item("cus_address").ToString
            'contactPerson.Text = dr.Item("cus_contactperson").ToString
            'contactNum.Text = dr.Item("cus_contactno").ToString
            'TextBox6.Text = dr.Item("cus_terms").ToString

            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

        updateStats($"SELECT COUNT(*) FROM rcss_remar a INNER JOIN rcss_customer c ON c.cus_accountno = a.remar_cusID  WHERE c.cus_accountno = '{tb_accountNum.Text}'",
                   $"SELECT SUM(remar_amount) FROM rcss_remar a INNER JOIN rcss_customer c ON c.cus_accountno = a.remar_cusID  WHERE c.cus_accountno  = '{tb_accountNum.Text}'")
    End Sub

    Public Sub LoadTableData(query1 As String)
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand(query1, cn)
            dr = cm.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("remar_transid").ToString, dr.Item("remar_date").ToString, dr.Item("remar_amount").ToString, dr.Item("remar_invoice").ToString, dr.Item("remar_refnum").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try


    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles tb_contactPerson.TextChanged

    End Sub

    Sub updateStats(countQuery As String, totalArQuery As String)
        Try
            Dim totalRows As Integer = DataGridView2.RowCount

            If totalRows = 0 Then
                lbl_totalRecord.Text = $"({totalRows}) record found"
            Else
                lbl_totalRecord.Text = $"({totalRows}) records found"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

        Try

            Dim totalSum As Double = 0

            For Each row As DataGridViewRow In DataGridView2.Rows
                If Not row.IsNewRow AndAlso IsNumeric(row.Cells("amountCol").Value) Then
                    totalSum += CDbl(row.Cells("amountCol").Value)
                End If
            Next


            lbl_totalAmount.Text = $"Total Amount: {totalSum.ToString()}"
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        LoadTableData($"SELECT * FROM rcss_remar a INNER JOIN rcss_customer c ON c.cus_accountno = a.remar_cusID  WHERE a.remar_transid LIKE '%{search.Text}%' AND cus_accountno = '{tb_accountNum.Text}'")
        updateStats($"SELECT COUNT(*) FROM rcss_remar a INNER JOIN rcss_customer c ON c.cus_accountno = a.remar_cusID  WHERE a.remar_transid LIKE '%{search.Text}%' AND cus_accountno = '{tb_accountNum.Text}'",
                    $"SELECT SUM(remar_amount) FROM rcss_remar a INNER JOIN rcss_customer c ON c.cus_accountno = a.remar_cusID  WHERE a.remar_transid LIKE '%{search.Text}%' AND cus_accountno = '{tb_accountNum.Text}'")
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        If search.Text = "Search Transaction #" Then
            search.Text = ""
        End If
    End Sub

    Private Sub search_LostFocus(sender As Object, e As EventArgs) Handles search.LostFocus
        search.Text = "Search Transaction #"
    End Sub
End Class