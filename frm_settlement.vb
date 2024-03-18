Imports MySql.Data.MySqlClient
Public Class frm_settlement

    Private Sub frm_settlement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCol()
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub lbl_close_Click_1(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
    Sub LoadCol()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()

            cm = New MySqlCommand("SELECT * FROM rcss_remar a INNER JOIN rcss_collection b ON a.remar_invoice = b.col_invoice INNER JOIN rcss_customer c ON c.cus_accountno = b.col_cusID;", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("remar_transid").ToString, dr.Item("remar_date").ToString, dr.Item("cus_accountno").ToString, dr.Item("cus_name").ToString, dr.Item("cus_address").ToString, dr.Item("col_refnum").ToString, dr.Item("col_invoice").ToString, String.Format("{0:N2}", dr.Item("remar_amount")), dr.Item("col_status").ToString, String.Format("{0:N2}", dr.Item("col_balance")))

            End While
            DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Private Sub btnNew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        With frm_AddSettlement
            .ShowDialog()
        End With
    End Sub

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs)
        If tb_search.Text = "" Then
            LoadCol()
        Else
            Try
                Dim i As Integer = 0
                DataGridView1.Rows.Clear()
                cn.Open()
                cm = New MySqlCommand("SELECT * FROM rcss_remar a INNER JOIN rcss_collection b ON a.remar_invoice = b.col_invoice INNER JOIN rcss_customer c ON c.cus_accountno = b.col_cusID;", cn)

                dr = cm.ExecuteReader
                While dr.Read
                    i += 1
                    DataGridView1.Rows.Add(i, dr.Item("col_remar_status").ToString, dr.Item("col_status").ToString, dr.Item("col_idno").ToString, dr.Item("remar_transid").ToString, dr.Item("remar_date").ToString, dr.Item("cus_accountno").ToString, dr.Item("cus_name").ToString, dr.Item("cus_address").ToString, dr.Item("col_refnum").ToString, dr.Item("col_invoice").ToString, String.Format("{0:N2}", dr.Item("remar_amount")), String.Format("{0:N2}", dr.Item("col_balance")))
                End While
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
            If DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString = "Settled" Then
                MessageBox.Show("Transaction already settled!", "RCSS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString = "" Then

                If colname = "DGV1_colsettle" Then
                    With frm_placeSettlement
                        .lbl_collectionCode.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                        .lbl_transaction_Code.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                        .lbl_customerID.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                        .lbl_customerName.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                        .lbl_invoiceNo.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
                        .lbl_amountSettle.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString
                        .ShowDialog()
                    End With
                End If
            ElseIf DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString = "Collected - Partial" Then

                If colname = "DGV1_colsettle" Then
                    With frm_placeSettlement
                        .lbl_collectionCode.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                        .lbl_transaction_Code.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                        .lbl_customerID.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                        .lbl_customerName.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                        .lbl_invoiceNo.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString
                        .lbl_amountSettle.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString
                        .ShowDialog()
                    End With
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

End Class