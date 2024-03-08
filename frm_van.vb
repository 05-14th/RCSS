Imports MySql.Data.MySqlClient
Public Class frm_van
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub
    Private Sub frm_van_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVan()
    End Sub
    Sub LoadVan()
        Try

            DataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_van", cn)
            dr = cm.ExecuteReader
            While dr.Read

                DataGridView1.Rows.Add(dr.Item("van_id").ToString, dr.Item("van_number").ToString, dr.Item("van_plateno").ToString, dr.Item("van_route").ToString)

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If tb_vanno.Text = String.Empty Or tb_plateno.Text = String.Empty Or tb_route.Text = String.Empty Then
                MessageBox.Show("Fill missing fields", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tb_vanno.Select()

            Else
                If MsgBox("Do you want to save this record?", vbYesNo + vbQuestion) = vbYes Then
                    Try
                        cn.Open()
                        cm = New MySqlCommand("INSERT INTO rcss_van (van_number, van_plateno, van_route) values(@van_number, @van_plateno, @van_route)", cn)

                        cm.Parameters.AddWithValue("@van_number", tb_vanno.Text)
                        cm.Parameters.AddWithValue("@van_plateno", tb_plateno.Text)
                        cm.Parameters.AddWithValue("@van_route", tb_route.Text)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        tb_vanno.Clear()
                        tb_plateno.Clear()
                        tb_route.Clear()
                        tb_vanno.Focus()

                        LoadVan()
                        frm_AddRemittance.LoadVanList()

                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try
                End If
            End If

        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        btnUpdate.Visible = True
        btnSubmit.Visible = False

        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "colUpdate" Then

            lbl_vanID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            tb_vanno.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            tb_plateno.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            tb_route.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            btnSubmit.Enabled = False
            btnUpdate.Enabled = True
            lbl_header.Text = "UPDATE VAN # / ROUTE"

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If MsgBox("Do you want to update this record?", vbYesNo + vbQuestion) = vbYes Then
            Try

                cn.Open()
                cm = New MySqlCommand("UPDATE rcss_van SET van_number=@van_number, van_plateno=@van_plateno, van_route=@van_route WHERE van_id = @van_id", cn)
                With cm
                    .Parameters.AddWithValue("@van_number", tb_vanno.Text)
                    .Parameters.AddWithValue("@van_plateno", tb_plateno.Text)
                    .Parameters.AddWithValue("@van_route", tb_route.Text)
                    .Parameters.AddWithValue("@van_id", lbl_vanID.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()

                LoadVan()
                frm_AddRemittance.LoadVanList()
                MessageBox.Show("Record successfully updated!", "RCSS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                cn.Close()
                MsgBox(ex.Message, vbCritical)

            End Try
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        btnSubmit.Visible = True
        btnUpdate.Visible = False


        tb_vanno.Clear()
        tb_plateno.Clear()
        tb_route.Clear()
        tb_vanno.Focus()
        lbl_vanID.Text = "0"
        btnSubmit.Enabled = True
        btnUpdate.Enabled = False
        lbl_header.Text = "ADD VAN # / ROUTE"
        LoadVan()
    End Sub
End Class