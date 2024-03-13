Imports MySql.Data.MySqlClient
Public Class frm_customer

    Private Sub frm_customer_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCustomer()
        Count()

    End Sub
    Sub Count()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_customer", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            lblCount.Text = "(" & count & ") record/s found"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Sub LoadCustomer()
        Try

            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_customer", cn)
            dr = cm.ExecuteReader
            While dr.Read

                DataGridView1.Rows.Add(dr.Item("cus_id").ToString, dr.Item("cus_accountno").ToString, dr.Item("cus_name").ToString, dr.Item("cus_address").ToString, dr.Item("cus_contactperson").ToString, dr.Item("cus_contactno").ToString, Format(CDec(dr.Item("cus_limit").ToString), "###,###,##0.00"), dr.Item("cus_terms").ToString)

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub

    Private Sub btnNew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnNew.LinkClicked
        With frm_AddCustomer
            '.btnUpdate.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "colUpdate" Then
            With frm_AddCustomer
                .lbl_CustomerID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .tb_accountnoEdit.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .tb_accountno.Visible = False
                .tb_accountnoEdit.Visible = True
                .tb_name.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .tb_address.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .tb_conperson.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .tb_contactno.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .tb_limit.Text = Format(CDec(DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString), "###,###,##0.00")
                .tb_terms.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                .btnSubmit.Visible = False
                .btnUpdate.Visible = True
                .lbl_cadd.Text = "UPDATE CUSTOMER"
                .ShowDialog()
            End With

        End If
    End Sub
End Class