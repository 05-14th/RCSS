Imports MySql.Data.MySqlClient
Public Class frm_arcollectionRecord
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()

    End Sub
    Sub Loadrecord()
        Try
            Dim i As Integer = 0
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_collection, rcss_customer WHERE rcss_collection.col_customer = rcss_customer.cus_name", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView2.Rows.Add(i, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("col_transid").ToString, dr.Item("cus_name").ToString, dr.Item("cus_address").ToString, dr.Item("col_refnum").ToString, dr.Item("col_invoice").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

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
    Private Sub frm_remRecord_Load(sender As Object, e As EventArgs) Handles Me.Load
        Loadrecord()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        Loadrecord()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class