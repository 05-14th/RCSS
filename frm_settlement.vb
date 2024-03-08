Imports MySql.Data.MySqlClient
Public Class frm_settlement

    Private Sub frm_settlement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCol()
    End Sub

    Private Sub lbl_close_Click_1(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub
    Sub LoadCol()
        Try
            Dim i As Integer = 0
            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_collectionid", cn)
            dr = cm.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("collection_id").ToString, dr.Item("collection_number").ToString, dr.Item("collection_TOTAL").ToString)

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnNew_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnNew.LinkClicked
        With frm_AddSettlement
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

                cm = New MySqlCommand("SELECT * FROM rcss_collectionid WHERE collection_number LIKE '%" + tb_search.Text + "%' OR collection_TOTAL LIKE '%" & tb_search.Text & "%'", cn)

                dr = cm.ExecuteReader
                While dr.Read
                    i += 1
                    DataGridView1.Rows.Add(i, dr.Item("collection_id").ToString, dr.Item("collection_number").ToString, dr.Item("collection_TOTAL").ToString)


                End While
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                cn.Close()
            End Try
        End If
    End Sub
End Class