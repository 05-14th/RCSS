Imports MySql.Data.MySqlClient
Public Class frm_AddCustomer

    Private Sub frm_AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RANDID()
    End Sub
    Private Sub lbl_close_Click(sender As Object, e As EventArgs) Handles lbl_close.Click
        If MsgBox("Closing this window whithout saving will disregard your inputs. Do you want to continue?", vbYesNo + vbQuestion) = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If tb_accountno.Text = String.Empty Or tb_name.Text = String.Empty Or tb_address.Text = String.Empty Or tb_conperson.Text = String.Empty Or tb_contactno.Text = String.Empty Or tb_limit.Text = String.Empty Then
                MessageBox.Show("Fill missing fields", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tb_name.Select()

            Else
                If MsgBox("Do you want to save this record?", vbYesNo + vbQuestion) = vbYes Then
                    Try
                        cn.Open()
                        cm = New MySqlCommand("INSERT INTO rcss_customer (cus_accountno , cus_name, cus_address, cus_contactperson, cus_contactno, cus_limit, cus_terms) values(@cus_accountno , @cus_name, @cus_address, @cus_contactperson, @cus_contactno, @cus_limit, @cus_terms)", cn)

                        cm.Parameters.AddWithValue("@cus_accountno", tb_accountno.Text)
                        cm.Parameters.AddWithValue("@cus_name", tb_name.Text)
                        cm.Parameters.AddWithValue("@cus_address", tb_address.Text)
                        cm.Parameters.AddWithValue("@cus_contactperson", tb_conperson.Text)
                        cm.Parameters.AddWithValue("@cus_contactno", tb_contactno.Text)
                        cm.Parameters.AddWithValue("@cus_limit", CDec(tb_limit.Text))
                        cm.Parameters.AddWithValue("@cus_terms", tb_terms.Text)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        tb_name.Clear()
                        tb_address.Clear()
                        tb_conperson.Clear()
                        tb_contactno.Clear()
                        tb_limit.Clear()
                        tb_terms.Clear()

                        tb_name.Focus()

                        RANDID()

                        frm_customer.LoadCustomer()
                        frm_customer.Count()


                    Catch ex As Exception
                        cn.Close()
                        MsgBox(ex.Message, vbCritical)
                    End Try
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            cn.Open()
            cm = New MySqlCommand("UPDATE rcss_customer SET cus_accountno=@cus_accountno, cus_name=@cus_name, cus_address=@cus_address, cus_contactperson=@cus_contactperson, cus_contactno=@cus_contactno, cus_limit=@cus_limit, cus_terms=@cus_terms WHERE cus_id = @cus_id", cn)
            With cm
                .Parameters.AddWithValue("@cus_accountno", tb_accountnoEdit.Text)
                .Parameters.AddWithValue("@cus_name", tb_name.Text)
                .Parameters.AddWithValue("@cus_address", tb_address.Text)
                .Parameters.AddWithValue("@cus_contactperson", tb_conperson.Text)
                .Parameters.AddWithValue("@cus_contactno", tb_contactno.Text)
                .Parameters.AddWithValue("@cus_limit", CDec(tb_limit.Text))
                .Parameters.AddWithValue("@cus_terms", tb_terms.Text)
                .Parameters.AddWithValue("@cus_id", lbl_CustomerID.Text)

                .ExecuteNonQuery()
            End With
            cn.Close()

            tb_name.Clear()
            tb_address.Clear()
            tb_conperson.Clear()
            tb_contactno.Clear()
            tb_limit.Clear()
            tb_terms.Clear()
            tb_name.Focus()

            RANDID()

            frm_customer.LoadCustomer()
            frm_customer.Count()

            MessageBox.Show("Record successfully updated!", "RCSS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()


        Catch ex As Exception

            MsgBox(ex.Message, vbCritical)
            cn.Close()
        End Try
    End Sub

    Private Sub RANDID()
        Randomize()
        Dim value As Integer
        Dim random As New Random
        value = random.Next(1000, 10000)

        'tb_accountno.Text = (DateTime.Now.ToString("MM")) & (DateTime.Now.ToString("dd")) & (DateTime.Now.ToString("yy")) & value
        tb_accountno.Text = "C-" & (DateTime.Now.ToString("MM")) & (DateTime.Now.ToString("dd")) & (DateTime.Now.ToString("yy")) & value
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        tb_accountno.Visible = True
        tb_accountnoEdit.Visible = False
        tb_name.Clear()
        tb_address.Clear()
        tb_conperson.Clear()
        tb_contactno.Clear()
        tb_limit.Clear()
        tb_terms.Clear()
        btnSubmit.Visible = True
        btnUpdate.Visible = False
        lbl_CustomerID.Text = "0"
        lbl_cadd.Text = "ADD CUSTOMER"
        frm_customer.LoadCustomer()
        RANDID()
        tb_name.Select()

    End Sub

    Private Sub tb_contactno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_contactno.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub


    Private Sub tb_limit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_limit.KeyPress
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub tb_limit_TextChanged(sender As Object, e As EventArgs) Handles tb_limit.TextChanged

    End Sub

    Private Sub tb_limit_LostFocus(sender As Object, e As EventArgs) Handles tb_limit.LostFocus
        Try
            If tb_limit.Text = "" Or tb_limit.Text = "0.00" Or tb_limit.Text = ".00" Or tb_limit.Text = "0" Then
                tb_limit.Text = "0.00"
            Else
                Dim number1 As Decimal = tb_limit.Text
                tb_limit.Text = number1.ToString("###,###,###.00")
                'tb_limit.Text = String.Format("{0:n}", Double.Parse(tb_limit.Text))
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class