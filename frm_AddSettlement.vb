Imports MySql.Data.MySqlClient
Public Class frm_AddSettlement
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

    End Sub

    Private Sub frm_AddCollection_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadAR()

    End Sub

    Sub LoadAR()

        Try
            'Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_collection, rcss_customer WHERE rcss_collection.col_customer = rcss_customer.cus_name AND rcss_collection.col_remar_status = 'Processing'", cn)
            dr = cm.ExecuteReader
            While dr.Read

                DataGridView1.Rows.Add(0, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("col_transid").ToString, dr.Item("cus_name").ToString, dr.Item("cus_address").ToString, dr.Item("col_refnum").ToString, dr.Item("col_invoice").ToString)

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try


        'Dim checkboxcol As New DataGridViewCheckBoxColumn
        'checkboxcol.Width = 40
        'checkboxcol.Name = "cb_column"
        'checkboxcol.HeaderText = ""
        'DataGridView1.Columns.Insert(0, checkboxcol)


    End Sub

    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class