Imports MySql.Data.MySqlClient

Public Class frm_collection
    Private Checkboxheader As CheckBox = New CheckBox()
    Dim countcheck As Integer
    Private Sub frm_collection_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCol()
        CountCollected()
        CountProcessing()
        Countuncollected()
    End Sub

    Sub LoadCol()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_collection, rcss_customer WHERE rcss_collection.col_customer = rcss_customer.cus_name", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("col_transid").ToString, dr.Item("cus_name").ToString, dr.Item("cus_address").ToString, dr.Item("col_refnum").ToString, dr.Item("col_invoice").ToString)

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
        'Try
        '    Dim i As Integer = 0
        '    DataGridView1.Rows.Clear()
        '    cn.Open()
        '    cm = New MySqlCommand("SELECT * FROM rcss_collection ORDER BY col_id DESC ", cn)
        '    dr = cm.ExecuteReader
        '    While dr.Read
        '        i += 1
        '        DataGridView1.Rows.Add(i, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("col_transid").ToString, dr.Item("col_refnum").ToString, dr.Item("col_invoice").ToString)

        '    End While
        '    dr.Close()
        '    cn.Close()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    cn.Close()
        'End Try

    End Sub

    Sub Countuncollected()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remar WHERE remar_status = 'Uncollected'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            LL_forApproval.Text = "Uncollected (" + count + ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Sub CountProcessing()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remar WHERE remar_status = 'Processing'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            LL_revise.Text = "Processing (" + count + ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Sub CountCollected()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remar WHERE remar_status = 'Collected'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            LL_approved.Text = "Collected (" + count + ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Private Sub LoadSelectedData(status As String)
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            'cm = New MySqlCommand("SELECT * FROM rcss_remittance inner join rcss_rembd on rcss_remittance.rmt_transid = rcss_rembd.remDB_transid WHERE rcss_rembd.remDB_transid like '%" & tb_search.Text & "%' AND rcss_remittance.rmt_status = 'For Approval' OR rmt_status = 'Checking'", cn)
            cm = New MySqlCommand("SELECT * FROM rcss_collection, rcss_customer WHERE rcss_collection.col_customer = rcss_customer.cus_name AND rcss_collection.col_remar_status = '" + status + "';", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("col_transid").ToString, dr.Item("cus_name").ToString, dr.Item("cus_address").ToString, dr.Item("col_refnum").ToString, dr.Item("col_invoice").ToString)

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
        With frm_AddCollection
            .ShowDialog()
        End With
    End Sub


    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        If tb_search.Text = "" Then
            LoadCol()
        Else
            Try
                Dim i As Integer = 0
                DataGridView1.Rows.Clear()
                cn.Open()
                'cm = New MySqlCommand("SELECT * FROM rcss_remittance inner join rcss_rembd on rcss_remittance.rmt_transid = rcss_rembd.remDB_transid WHERE rcss_rembd.remDB_transid Like '%" & tb_search.Text & "%' AND rcss_remittance.rmt_status = 'For Approval' OR rmt_status = 'Checking'", cn)
            cm = New MySqlCommand("SELECT * FROM rcss_customer, rcss_collection WHERE rcss_customer.cus_name = rcss_collection.col_customer AND rcss_collection.col_idno like '%" & tb_search.Text & "%'", cn)

                dr = cm.ExecuteReader
                While dr.Read
                    i += 1
                    DataGridView1.Rows.Add(i, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("col_transid").ToString, dr.Item("cus_name").ToString, dr.Item("cus_address").ToString, dr.Item("col_refnum").ToString, dr.Item("col_invoice").ToString)

                End While
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub LL_approved_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_approved.LinkClicked
        LoadSelectedData("Collected")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LL_revise_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_revise.LinkClicked
        LoadSelectedData("Processing")
    End Sub

    Private Sub LL_forApproval_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_forApproval.LinkClicked
        LoadSelectedData("Uncollected")
    End Sub
End Class