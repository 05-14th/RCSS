Imports MySql.Data.MySqlClient
Public Class frm_placeSettlement
    Private Sub frm_placeSettlement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        Me.Dispose()
    End Sub

    Private Sub tb_amountReceived_TextChanged(sender As Object, e As EventArgs) Handles tb_amountReceived.TextChanged

        Dim value1 As Decimal
        Dim value2 As Decimal


        If Decimal.TryParse(lbl_amountSettle.Text, value1) Then

            If Decimal.TryParse(tb_amountReceived.Text, value2) Then

                Dim result As Decimal = value1 - value2

                Dim formattedText As String = String.Format("{0:#,##0.00}", result)
                lbl_balance.Text = formattedText

            Else

                lbl_balance.Text = "Invalid input"
            End If
        Else
            lbl_balance.Text = "Invalid input"
        End If

    End Sub

    Private Sub tb_amountReceived_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_amountReceived.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_amountReceived_LostFocus(sender As Object, e As EventArgs) Handles tb_amountReceived.LostFocus
        Try
            If tb_amountReceived.Text = "" Or tb_amountReceived.Text = "0.00" Or tb_amountReceived.Text = ".00" Or tb_amountReceived.Text = "0" Then
                tb_amountReceived.Text = "0.00"
            Else
                ' Convert the result to the appropriate datatype
                Dim converttext As Decimal = Convert.ToDecimal(tb_amountReceived.Text)
                Dim formattedText As String = String.Format("{0:#,##0.00}", converttext)
                tb_amountReceived.Text = formattedText

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Dim sum As Decimal = Convert.ToDecimal(lbl_balance.Text)

        Dim formattedSum As String = String.Format("{0:#,##0.00}", sum)


        Dim sum1 As Decimal = Convert.ToDecimal(lbl_amountSettle.Text)

        Dim AmountToSettle As String = String.Format("{0:#,##0.00}", sum1)



        If formattedSum = AmountToSettle Then
            MessageBox.Show("No payment made, Please double check your entry before saving!", "RCSS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf formattedSum > 0 Then

            Try
                cn.Open()
                cm = New MySqlCommand("UPDATE rcss_collection SET col_balance = @col_balance, col_remar_status = @col_remar_status, col_status = @col_status, col_DateOfPayment = @col_DateOfPayment WHERE col_invoice = @col_invoice AND col_idno = @col_idno", cn)
                With cm
                    .Parameters.AddWithValue("@col_balance", lbl_balance.Text)
                    .Parameters.AddWithValue("@col_remar_status", "Collected - Partial")
                    .Parameters.AddWithValue("@col_status", "Collected - Partial")
                    .Parameters.AddWithValue("@col_DateOfPayment", DateTimePicker1.Text)
                    .Parameters.AddWithValue("@col_invoice", lbl_invoiceNo.Text)
                    .Parameters.AddWithValue("@col_idno", lbl_collectionCode.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                frm_collection.LoadCol()
                MessageBox.Show("Partial payment is successfully posted!", "RCSS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frm_settlement.LoadCol()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
                cn.Close()
            End Try

            'FOR REMAR STATUS UPDATE 
            Try
                cn.Open()
                cm = New MySqlCommand("UPDATE rcss_remar SET remar_status = @remar_status WHERE remar_invoice = @remar_invoice AND remar_transid = @remar_transid", cn)
                With cm
                    .Parameters.AddWithValue("@remar_status", "Collected - Partial")
                    .Parameters.AddWithValue("@remar_invoice", lbl_invoiceNo.Text)
                    .Parameters.AddWithValue("@remar_transid", lbl_transaction_Code.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                frm_collection.LoadCol()
                frm_settlement.LoadCol()
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
                cn.Close()
            End Try


        ElseIf formattedSum <= 0 Then

            Try
                cn.Open()
                cm = New MySqlCommand("UPDATE rcss_collection SET col_balance = @col_balance, col_remar_status = @col_remar_status, col_status = @col_status, col_DateOfPayment = @col_DateOfPayment WHERE col_invoice = @col_invoice AND col_idno = @col_idno", cn)
                With cm
                    .Parameters.AddWithValue("@col_balance", lbl_balance.Text)
                    .Parameters.AddWithValue("@col_remar_status", "Collected")
                    .Parameters.AddWithValue("@col_status", "Settled")
                    .Parameters.AddWithValue("@col_DateOfPayment", DateTimePicker1.Text)
                    .Parameters.AddWithValue("@col_invoice", lbl_invoiceNo.Text)
                    .Parameters.AddWithValue("@col_idno", lbl_collectionCode.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                frm_collection.LoadCol()
                MessageBox.Show("Payment is successfully posted!", "RCSS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frm_settlement.LoadCol()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
                cn.Close()
            End Try

            'FOR REMAR STATUS UPDATE 
            Try
                cn.Open()
                cm = New MySqlCommand("UPDATE rcss_remar SET remar_status = @remar_status WHERE remar_invoice = @remar_invoice AND remar_transid = @remar_transid", cn)
                With cm
                    .Parameters.AddWithValue("@remar_status", "Collected")
                    .Parameters.AddWithValue("@remar_invoice", lbl_invoiceNo.Text)
                    .Parameters.AddWithValue("@remar_transid", lbl_transaction_Code.Text)
                    .ExecuteNonQuery()
                End With
                cn.Close()
                frm_collection.LoadCol()
                frm_settlement.LoadCol()
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
                cn.Close()
            End Try



        End If

    End Sub
End Class