Imports MySql.Data.MySqlClient
Public Class frm_remRevise
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()

    End Sub

    Private Sub frm_remRevise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadforRevision()
    End Sub
    Sub LoadforRevision()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance WHERE rmt_status = 'For Revision'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("rmt_status").ToString, dr.Item("rmt_approveddate").ToString, dr.Item("rmt_approvedby").ToString, dr.Item("rmt_transid").ToString, dr.Item("rmt_vanno").ToString, dr.Item("rmt_salesman").ToString, dr.Item("rmt_custodian").ToString, Format(CDec(dr.Item("rmt_remsum").ToString), "###,###,##0.00"))

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class