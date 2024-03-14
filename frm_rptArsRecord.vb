Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class frm_rptArsRecord

    Private Sub frm_rptArsRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Clear()
        Dim myrpt1 As New rpt_ArMonitoring
        Loadrecord()
        myrpt1.Database.Tables("ar_monitoring").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt1
    End Sub
    Sub Loadrecord()
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_customer INNER JOIN rcss_remar ON rcss_remar.remar_cusID = rcss_customer.cus_accountno INNER JOIN rcss_remittance ON rcss_remittance.rmt_transid = rcss_remar.remar_transid INNER JOIN rcss_van ON rcss_van.van_number = rcss_remittance.rmt_vanno", cn)
            da = New MySqlDataAdapter(cm)
            da.Fill(dt)

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

End Class
