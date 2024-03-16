Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class frm_rptArsRecord

    Private Sub frm_rptArsRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub LoadReport(dataQuery As String)
        Try
            cn.Open()
            Dim ds As New DataSetARMonitoring
            Dim da As New MySqlDataAdapter
            da.SelectCommand = New MySqlCommand(dataQuery, cn)
            da.Fill(ds, "ARMonitoring")

            Dim rpt As New rptARMonitoring
            rpt.Load(Application.StartupPath & "\Reports\rptARMonitoring.rpt")
            rpt.SetDataSource(ds.Tables("ARMonitoring"))

            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.RefreshReport()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub
    'Sub LoadReport1()
    '    Try
    '        cn.Open()
    '        Dim ds As New DataSetARMonitoring
    '        Dim da As New MySqlDataAdapter
    '        da.SelectCommand = New MySqlCommand("'" & lbl_toQuery.Text & "'", cn)
    '        da.Fill(ds, "ARMonitoring")

    '        Dim rpt As New rptARMonitoring
    '        rpt.Load(Application.StartupPath & "\Reports\rptARMonitoring.rpt")
    '        rpt.SetDataSource(ds.Tables("ARMonitoring"))

    '        CrystalReportViewer1.ReportSource = rpt
    '        CrystalReportViewer1.RefreshReport()
    '        cn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        cn.Close()
    '    End Try
    'End Sub
End Class
