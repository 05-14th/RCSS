Imports MySql.Data.MySqlClient
Public Class frm_rptRemRecord

    Private Sub frm_rptRemRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myrpt As New rpt_Remitance
        Loadrecord()
        myrpt.Database.Tables("rcss_remittance").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt

    End Sub
    Sub Loadrecord()
        Try
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remittance", cn)
            da = New MySqlDataAdapter(cm)
            da.Fill(dt)


            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
End Class