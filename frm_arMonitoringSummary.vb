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

    Sub LoadARData()

        Try
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remar, rcss_customer WHERE rcss_remar.remar_customer = rcss_customer.cus_name", cn)
            dr = cm.ExecuteReader
            While dr.Read

                DataGridView2.Rows.Add(0, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("col_transid").ToString, dr.Item("cus_name").ToString, dr.Item("cus_address").ToString, dr.Item("col_refnum").ToString, dr.Item("col_invoice").ToString)

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub


End Class