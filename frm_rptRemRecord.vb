Imports MySql.Data.MySqlClient
Public Class frm_rptRemRecord

    Private Sub frm_rptRemRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadrecord()
    End Sub
    Sub Loadrecord()
        Try



            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
End Class