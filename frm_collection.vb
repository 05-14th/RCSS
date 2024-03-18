Imports MySql.Data.MySqlClient

Public Class frm_collection
    Private Checkboxheader As CheckBox = New CheckBox()
    Dim countcheck As Integer
    Private Sub frm_collection_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCol()
        Countuncollected()
        CountCollected()
        CountProcessing()
        CountPartial()
        DataGridView1.Sort(DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Sub LoadCol()

        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()

            'cm = New MySqlCommand("SELECT DISTINCT * FROM rcss_remar, rcss_collection, rcss_customer WHERE rcss_collection.col_cusID = rcss_customer.cus_accountno AND rcss_customer.cus_accountno = rcss_remar.remar_cusID AND rcss_remar.remar_invoice = rcss_collection.col_invoice", cn)
            cm = New MySqlCommand("SELECT * FROM rcss_remar a INNER JOIN rcss_collection b ON a.remar_invoice = b.col_invoice INNER JOIN rcss_customer c ON c.cus_accountno = b.col_cusID;", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("col_assignedTo").ToString, dr.Item("remar_transid").ToString, dr.Item("col_refnum").ToString, dr.Item("remar_date").ToString, dr.Item("col_invoice").ToString, String.Format("{0:N2}", dr.Item("remar_amount")), String.Format("{0:N2}", dr.Item("col_balance")), dr.Item("cus_name").ToString, dr.Item("cus_address").ToString)

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Sub Countuncollected()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remar WHERE remar_status = 'Uncollected'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            btnNew.Text = "ADD NEW COLLECTION (" + count + ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Sub CountProcessing()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_collection WHERE col_remar_status = 'Processing'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            LL_Processing.Text = "Processing (" + count + ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Sub CountCollected()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_collection WHERE col_remar_status = 'Collected'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            LL_Collected.Text = "Collected (" + count + ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Sub CountPartial()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_collection WHERE col_remar_status = 'Collected - Partial'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            LL_Partial.Text = "Partial (" + count + ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Public Sub LoadSelectedData(status As String)
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            'cm = New MySqlCommand("SELECT * FROM rcss_remittance inner join rcss_rembd on rcss_remittance.rmt_transid = rcss_rembd.remDB_transid WHERE rcss_rembd.remDB_transid like '%" & tb_search.Text & "%' AND rcss_remittance.rmt_status = 'For Approval' OR rmt_status = 'Checking'", cn)
            'cm = New MySqlCommand("SELECT * FROM rcss_collection, rcss_customer WHERE rcss_collection.col_customer = rcss_customer.cus_name AND rcss_collection.col_remar_status = '" + status + "';", cn)
            'cm = New MySqlCommand("SELECT  * FROM rcss_collection, rcss_customer WHERE rcss_collection.col_cusID = rcss_customer.cus_accountno AND rcss_collection.col_remar_status = '" & status & "'", cn)
            cm = New MySqlCommand("SELECT * FROM rcss_remar a INNER JOIN rcss_collection b ON a.remar_invoice = b.col_invoice INNER JOIN rcss_customer c ON c.cus_accountno = b.col_cusID WHERE b.col_remar_status = '" & status & "'", cn)

            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                'DataGridView1.Rows.Add(i, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("col_transid").ToString, dr.Item("cus_name").ToString, dr.Item("cus_address").ToString, dr.Item("col_refnum").ToString, dr.Item("col_invoice").ToString)
                DataGridView1.Rows.Add(i, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("col_assignedTo").ToString, dr.Item("remar_transid").ToString, dr.Item("col_refnum").ToString, dr.Item("remar_date").ToString, dr.Item("col_invoice").ToString, String.Format("{0:N2}", dr.Item("remar_amount")), String.Format("{0:N2}", dr.Item("col_balance")), dr.Item("cus_name").ToString, dr.Item("cus_address").ToString)

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub
    Private Sub LL_Processing_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_Processing.LinkClicked
        LoadSelectedData("Processing")
    End Sub
    Private Sub LL_Collected_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_Collected.LinkClicked
        LoadSelectedData("Collected")
    End Sub
    Private Sub LL_Partial_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_Partial.LinkClicked
        LoadSelectedData("Collected - Partial")
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
                'cm = New MySqlCommand("SELECT DISTINCT * FROM rcss_customer, rcss_collection WHERE rcss_customer.cus_accountno = rcss_collection.col_cusID AND rcss_collection.col_idno like '%" & tb_search.Text & "%'", cn)
                cm = New MySqlCommand("SELECT * FROM rcss_remar a INNER JOIN rcss_collection b ON a.remar_invoice = b.col_invoice INNER JOIN rcss_customer c ON c.cus_accountno = b.col_cusID WHERE b.col_idno like '%" & tb_search.Text & "%'", cn)

                dr = cm.ExecuteReader
                While dr.Read
                    i += 1
                    DataGridView1.Rows.Add(i, dr.Item("col_remar_status").ToString, dr.Item("col_idno").ToString, dr.Item("col_assignedTo").ToString, dr.Item("remar_transid").ToString, dr.Item("col_refnum").ToString, dr.Item("remar_date").ToString, dr.Item("col_invoice").ToString, String.Format("{0:N2}", dr.Item("remar_amount")), String.Format("{0:N2}", dr.Item("col_balance")), dr.Item("cus_name").ToString, dr.Item("cus_address").ToString)

                End While
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                cn.Close()
            End Try
        End If
    End Sub


    Private Sub LL_Refresh_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_Refresh.LinkClicked
        LoadCol()
        Countuncollected()
        CountCollected()
        CountProcessing()
        CountPartial()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name
            If colname = "col_code" Then

                tb_search.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub btn_ColPrint_Click(sender As Object, e As EventArgs) Handles btn_ColPrint.Click

        Try
            With frm_collectionPrint
                .TopLevel = True
                .tb_PrintcollectionID.Text = tb_search.Text

                .BringToFront()
                .ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            cn.Close()
        End Try
    End Sub


End Class