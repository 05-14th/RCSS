Imports MySql.Data.MySqlClient
Public Class frm_rptRemRecord

    Private Sub frm_rptRemRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadrecord()
    End Sub
    Sub Loadrecord()
        Try
            dt.Clear()
            cn.Open()
            da.SelectCommand = New MySqlCommand("SELECT rmt_vanno, rmt_custodian, remDB_cash FROM rcss_remittance, rcss_rembd", cn)
            da.Fill(ds, "DataTable1")

            Dim rpt As New rpt_RemRecord
            rpt.Load(Application.StartupPath & "\Reports\rpt_RemRecord.rpt")
            rpt.SetDataSource(ds.Tables("DataTable1"))


            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
End Class