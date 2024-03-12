Imports MySql.Data.MySqlClient
Public Class frm_dashAdmin
    Private Sub frm_dashAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        CountForApproval()
        CountRevise()
        CountApproved()
        Timer1.Start()
        lbl_date.Text = (DateTime.Now.ToString("D")) & "        |"

    End Sub
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub

    Private Sub lbl_minimize_Click(sender As Object, e As EventArgs) Handles lbl_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Sub CountForApproval()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remittance WHERE rmt_status = 'For Approval' OR rmt_status = 'Checking'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            btn_approval.Text = "FOR APPROVAL" & vbLf & "(" & count & ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Sub CountRevise()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remittance WHERE rmt_status = 'For Revision'", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            btn_revision.Text = "FOR REVISION" & vbLf & "(" & count & ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Sub CountApproved()
        Try

            cn.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM rcss_remittance WHERE rmt_status = 'Approved' ", cn)
            Dim count As String
            count = cm.ExecuteScalar().ToString()
            btn_approved.Text = "APPROVED" & vbLf & "(" & count & ")"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub
    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        If MsgBox("Do you want to logout?", vbYesNo + vbQuestion) = vbYes Then
            frm_Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub REMITTANCEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REMITTANCEToolStripMenuItem.Click
        With frm_remittance
            .TopLevel = False
            Panel5.Controls.Add(frm_remittance)
            '.LoadRecords()
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub

    Private Sub CUSTOMERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERToolStripMenuItem.Click
        With frm_customer
            .TopLevel = False
            Panel5.Controls.Add(frm_customer)
            .LoadCustomer()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub VANROUTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VANROUTEToolStripMenuItem.Click
        frm_van.ShowDialog()

    End Sub

    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        frm_user.ShowDialog()

    End Sub

    Private Sub btn_approval_Click(sender As Object, e As EventArgs) Handles btn_approval.Click

        'frm_remApproval.ShowDialog()


        With frm_remApproval
            .TopLevel = False
            PanelDock.Controls.Add(frm_remApproval)

            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click

        'frm_remApproved.ShowDialog()


        With frm_remApproved
            .TopLevel = False
            PanelDock.Controls.Add(frm_remApproved)

            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_revision_Click(sender As Object, e As EventArgs) Handles btn_revision.Click

        'frm_remRevise.ShowDialog()

        With frm_remRevise
            .TopLevel = False
            PanelDock.Controls.Add(frm_remRevise)

            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub COLLECTIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLLECTIONToolStripMenuItem.Click
        With frm_collection
            .TopLevel = False
            Panel5.Controls.Add(frm_collection)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub SETTLEMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SETTLEMENTToolStripMenuItem.Click
        With frm_settlement
            .TopLevel = False
            Panel5.Controls.Add(frm_settlement)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub REMITTANCERECORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REMITTANCERECORDToolStripMenuItem.Click
        With frm_remRecord
            .TopLevel = False
            Panel5.Controls.Add(frm_remRecord)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ARCollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ARCollectionToolStripMenuItem.Click
        With frm_arcollectionRecord
            .TopLevel = False
            Panel5.Controls.Add(frm_arcollectionRecord)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ARMonitoringSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ARMonitoringSummaryToolStripMenuItem.Click
        With frm_arMonitoringSummary
            .TopLevel = False
            Panel5.Controls.Add(frm_arMonitoringSummary)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ColletionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColletionsToolStripMenuItem.Click
        With frm_collectionRecord
            .TopLevel = False
            Panel5.Controls.Add(frm_collectionRecord)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub REPORTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTSToolStripMenuItem.Click

    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs) Handles Panel10.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class