Imports MySql.Data.MySqlClient
Public Class frm_AddCollection
    'Private Checkboxheader As CheckBox = New CheckBox()
    Dim countcheck As Integer
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()

    End Sub
    Private Sub frm_AddCollection_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadAR()
        RANDID()

        'Dim headercelllocation As Point = Me.DataGridView1.GetCellDisplayRectangle(0, -1, True).Location
        ''this place the header location
        'Checkboxheader.Location = New Point(headercelllocation.X + 5, headercelllocation.Y + 5)
        'Checkboxheader.Size = New Size(18, 18)
        'Checkboxheader.BackColor = Color.FromArgb(64, 64, 64)

        'DataGridView1.Controls.Add(Checkboxheader)

        'AddHandler Checkboxheader.Click, AddressOf headercheckbox_click
        'AddHandler DataGridView1.CellContentClick, AddressOf datagridview_Cellclick
    End Sub
    Private Sub RANDID()
        Randomize()
        Dim value As Integer = CInt(Int((10000 * Rnd()) + 1))
        'Dim value1 As Integer = CInt(Int((10000 * Rnd()) + 2))
        tb_collectionID.Text = "CLN" & (DateTime.Now.ToString("MM")) & (DateTime.Now.ToString("dd")) & (DateTime.Now.ToString("yy")) & value

    End Sub
    Sub LoadAR()

        Try
            'Dim i As Integer = 0
            DataGridView2.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT * FROM rcss_remar inner join rcss_remittance on rcss_remar.remar_transid = rcss_remittance.rmt_transid WHERE remar_rmtstatus = 'Approved' AND remar_status = 'Uncollected'", cn)
            dr = cm.ExecuteReader
            While dr.Read

                DataGridView2.Rows.Add(0, dr.Item("remar_status").ToString, dr.Item("rmt_vanno").ToString, dr.Item("remar_transid").ToString, dr.Item("remar_date").ToString, dr.Item("remar_refnum").ToString, dr.Item("remar_invoice").ToString, dr.Item("remar_cusID").ToString, dr.Item("remar_customer").ToString, Format(CDec(dr.Item("remar_amount").ToString), "###,###,##0.00"))

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try


        'Dim checkboxcol As New DataGridViewCheckBoxColumn
        'checkboxcol.Width = 40
        'checkboxcol.Name = "cb_column"
        'checkboxcol.HeaderText = ""
        'DataGridView1.Columns.Insert(0, checkboxcol)


    End Sub
    Private Sub headercheckbox_click(ByVal sender As Object, ByVal e As EventArgs)
        '    DataGridView1.EndEdit()

        '    'this will loop for select and unselect the rows
        '    For Each row As DataGridViewRow In DataGridView1.Rows
        '        Dim chk As DataGridViewCheckBoxCell = TryCast(row.Cells("CheckBoxCol"), DataGridViewCheckBoxCell)
        '        chk.Value = Checkboxheader.Checked
        '    Next
    End Sub
    Private Sub datagridview_Cellclick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        '    If e.RowIndex >= 0 Then
        '        Dim ischecked As Boolean = True

        '        For Each row As DataGridViewRow In DataGridView1.Rows
        '            If Convert.ToBoolean(row.Cells("CheckBoxCol").EditedFormattedValue) = False Then
        '                ischecked = False


        '                Exit For

        '            End If
        '        Next
        '        Checkboxheader.Checked = ischecked
        '    End If

    End Sub
    Private Sub DataGridView2_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView2.CurrentCellDirtyStateChanged
        If DataGridView2.IsCurrentCellDirty Then
            DataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit)

        End If

    End Sub
    Private Sub DataGridView2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellValueChanged
        If e.RowIndex < 0 Then Return
        Dim ischecked As Boolean = CBool(DataGridView2.Rows(e.RowIndex).Cells(0).Value)
        'MsgBox(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        If ischecked Then
            countcheck += 1

        Else
            countcheck -= 1

        End If
        lblSelectedCount.Text = "(" & countcheck & ") record selected"



        Dim compute As Decimal = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb_column").Value)
            If isSelected Then

                'Message &= Environment.NewLine
                'Message &= row.Cells("TotalAR").Value.ToString()

                compute += row.Cells("TotalAR").Value

            End If
        Next
        lbl_TotalAR.Text = compute
        lbl_TotalAR.Text = String.Format("{0:n}", Double.Parse(lbl_TotalAR.Text))

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If MsgBox("Do you want to save this selection?", vbYesNo + vbQuestion) = vbYes Then

                For Each row As DataGridViewRow In DataGridView2.Rows
                    Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("cb_column").Value)

                    If isSelected = True Then
                        'SAVE TO COLLECTION
                        cn.Open()
                        'cm = New MySqlCommand("INSERT INTO rcss_collection (col_remar_status, col_idno, col_transid, col_refnum, col_invoice, col_cusID) values(@col_remar_status, @col_idno, @col_transid, @col_refnum, @col_invoice, @col_cusID)", cn)
                        cm = New MySqlCommand("INSERT INTO rcss_collection (col_remar_status, col_idno, col_refnum, col_invoice, col_cusID) values(@col_remar_status, @col_idno, @col_refnum, @col_invoice, @col_cusID)", cn)
                        cm.Parameters.AddWithValue("@col_remar_status", "Processing")
                        cm.Parameters.AddWithValue("@col_idno", tb_collectionID.Text)
                        'cm.Parameters.AddWithValue("@col_transid", row.Cells(3).Value.ToString())
                        cm.Parameters.AddWithValue("@col_refnum", row.Cells(5).Value.ToString())
                        cm.Parameters.AddWithValue("@col_invoice", row.Cells(6).Value.ToString())
                        cm.Parameters.AddWithValue("@col_cusID", row.Cells(7).Value.ToString())

                        cm.ExecuteNonQuery()
                        cn.Close()

                        'UPDATE FOR AR DETAILS

                        cn.Open()
                        cm = New MySqlCommand("UPDATE rcss_remar SET remar_status=@remar_status WHERE remar_transid=@remar_transid AND remar_invoice=@remar_invoice", cn)

                        cm.Parameters.AddWithValue("@remar_status", "Processing")
                        cm.Parameters.AddWithValue("@remar_transid", row.Cells(3).Value.ToString)
                        cm.Parameters.AddWithValue("@remar_invoice", row.Cells(6).Value.ToString)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        'SAVE TO COLLECTION ID

                        cn.Open()
                        cm = New MySqlCommand("INSERT INTO rcss_collectionid (collection_number, collection_TOTAL) values(@collection_number, @collection_TOTAL)", cn)
                        cm.Parameters.AddWithValue("@collection_number", tb_collectionID.Text)
                        cm.Parameters.AddWithValue("@collection_TOTAL", CDec(lbl_TotalAR.Text))

                        cm.ExecuteNonQuery()
                        cn.Close()

                        'END SAVE TO COLLECTION ID

                        LoadAR()
                        RANDID()
                        frm_collection.LoadCol()
                        countcheck = 0
                        lbl_TotalAR.Text = "0.00"
                        lblSelectedCount.Text = "(" & countcheck & ") record selected"

                        frm_collection.Countuncollected()
                        frm_collection.CountProcessing()
                        frm_collection.CountCollected()

                    End If

                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try


        'Checkboxheader.CheckState = False
        'For Each row As DataGridViewRow In DataGridView1.Rows()
        '    If row.Cells(0).Value = True Then


        '        'MsgBox(row.Cells(3).Value.ToString())

        '        'SAVE TO COLLECTION
        '        cn.Open()
        '        cm = New MySqlCommand("INSERT INTO rcss_collection (col_transid, col_refnum, col_invoice) values(@col_transid, @col_refnum, @col_invoice)", cn)
        '        'cm.Parameters.AddWithValue("col_idno", tb_collectionID.Text)
        '        cm.Parameters.AddWithValue("col_transid", row.Cells(3).Value)
        '        cm.Parameters.AddWithValue("col_refnum", row.Cells(5).Value)
        '        cm.Parameters.AddWithValue("col_invoice", row.Cells(6).Value)
        '        cm.ExecuteNonQuery()
        '        cn.Close()

        '        LoadAR()
        '        RANDID()
        '        frm_collection.LoadAR()
        '        countcheck = 0
        '        lbl_TotalAR.Text = "0.00"
        '        lblSelectedCount.Text = "(" & countcheck & ") record selected"
        '    End If
        'Next


        ''Try
        'If countcheck > 0 Then
        '    'If MsgBox("Do you want to save this record?", vbYesNo + vbQuestion) = vbYes Then
        '    For Each row As DataGridViewRow In DataGridView1.Rows
        '        Dim select1 As Boolean = Convert.ToBoolean(row.Cells("checkboxcol").Value)
        '        If select1 Then

        '            'SAVE TO COLLECTION

        '            cm = New MySqlCommand("INSERT INTO rcss_collection (col_transid, col_refnum, col_invoice) values(@col_transid, @col_refnum, @col_invoice)", cn)

        '            'cm.Parameters.AddWithValue("col_idno", tb_collectionID.Text)
        '            cm.Parameters.AddWithValue("col_transid", row.Cells(3).Value)
        '            cm.Parameters.AddWithValue("col_refnum", row.Cells(5).Value)
        '            cm.Parameters.AddWithValue("col_invoice", row.Cells(6).Value)
        '            cn.Open()
        '            cm.ExecuteNonQuery()
        '            cn.Close()

        '            LoadAR()
        '            RANDID()
        '            frm_collection.LoadAR()
        '            countcheck = 0
        '            lbl_TotalAR.Text = "0.00"
        '            lblSelectedCount.Text = "(" & countcheck & ") record selected"
        '            'Checkboxheader.CheckState = False

        '        End If

        '    Next
        '    'End If
        '    MessageBox.Show("Record successfully recorded!", "RCSS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Else
        '    MessageBox.Show("Please select data!", "RCSS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        'Catch ex As Exception
        '    cn.Close()
        '    MsgBox(ex.Message, vbCritical)
        'End Try





    End Sub
    Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseClick
        Try
            If DataGridView2.SelectedRows(0).Cells(0).Value = False Then
                DataGridView2.SelectedRows(0).Cells(0).Value = True
            Else
                DataGridView2.SelectedRows(0).Cells(0).Value = False
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class