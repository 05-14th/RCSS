Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class frm_rptArsRecord
<<<<<<< HEAD
    Private Sub frm_rptRemRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Clear()
        dt1.Clear()
        Dim myrpt1 As New rpt_Remitance
        Loadrecord()
        myrpt1.Database.Tables("rcss_remittance").SetDataSource(dt)
        myrpt1.Database.Tables("rcss_rembd").SetDataSource(dt1)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt1

    End Sub
    Sub Loadrecord()
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT rmt_transid, rmt_vanno, rmt_custodian FROM rcss_remittance LIMIT 1", cn)
            da = New MySqlDataAdapter(cm)
            da.Fill(dt)
            cm = New MySqlCommand("SELECT remDB_cash, remDB_gcash, remDB_online, remDB_check, remDB_ar, remDB_return, remDB_bo, remDB_discount, remDB_expenses, remDB_total FROM rcss_rembd", cn)
            da = New MySqlDataAdapter(cm)
            da.Fill(dt1)

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
=======
    Private Sub frm_rptArsRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
>>>>>>> refs/remotes/origin/master
End Class
