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
        Me.Dispose()
    End Sub

    Public Sub LoadData(query As String)
        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand(query, cn)
            dr = cm.ExecuteReader
            While dr.Read
                DataGridView2.Rows.Add(dr.Item("remar_transid").ToString, dr.Item("remar_date").ToString, dr.Item("remar_amount").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_salesman").ToString,
                                       dr.Item("rmt_custodian").ToString, dr.Item("rmt_driver").ToString, dr.Item("rmt_helper").ToString, dr.Item("remar_status").ToString)
            End While
            accountNum.Text = dr.Item("cus_accountno").ToString
            Label1.Text = dr.Item("cus_name").ToString
            cusAddress.Text = dr.Item("cus_address").ToString
            contactNum.Text = dr.Item("cus_contactperson").ToString
            contactNum.Text = dr.Item("cus_contactno").ToString
            TextBox6.Text = dr.Item("cus_terms").ToString

            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles contactPerson.TextChanged

    End Sub
End Class