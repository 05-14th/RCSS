Imports MySql.Data.MySqlClient
Public Class frm_collectionPrint

    Private Sub frm_collectionPrint_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadToPrint()
    End Sub
    Public Sub LoadToPrint()
        Try
            cn.Open()
            Dim ds As New DataSetPrintCollection
            Dim da As New MySqlDataAdapter
            da.SelectCommand = New MySqlCommand("SELECT * FROM rcss_remar a INNER JOIN rcss_collection b ON a.remar_invoice = b.col_invoice INNER JOIN rcss_customer c ON c.cus_accountno = b.col_cusID WHERE b.col_idno like '%" & tb_PrintcollectionID.Text & "%'", cn)
            da.Fill(ds, "DSCollection")

            Dim rpt1 As New rptPrintCollection
            rpt1.Load(Application.StartupPath & "\Reports\rptPrintCollection.rpt")
            rpt1.SetDataSource(ds.Tables("DSCollection"))
            rpt1.SetParameterValue(0, frm_dashAdmin.lbl_user.Text)
            rpt1.SetParameterValue(1, frm_dashAdmin.lbl_role.Text)
            CrystalReportViewer1.ReportSource = rpt1
            CrystalReportViewer1.RefreshReport()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub
End Class