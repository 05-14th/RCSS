<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AddCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_cadd = New System.Windows.Forms.Label()
        Me.lbl_close = New System.Windows.Forms.Label()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tb_accountno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_address = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_conperson = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_contactno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_limit = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lbl_CustomerID = New System.Windows.Forms.Label()
        Me.tb_accountnoEdit = New System.Windows.Forms.TextBox()
        Me.tb_terms = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_cadd)
        Me.Panel1.Controls.Add(Me.lbl_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(503, 35)
        Me.Panel1.TabIndex = 69
        '
        'lbl_cadd
        '
        Me.lbl_cadd.AutoSize = True
        Me.lbl_cadd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cadd.ForeColor = System.Drawing.Color.White
        Me.lbl_cadd.Location = New System.Drawing.Point(11, 7)
        Me.lbl_cadd.Name = "lbl_cadd"
        Me.lbl_cadd.Size = New System.Drawing.Size(125, 20)
        Me.lbl_cadd.TabIndex = 72
        Me.lbl_cadd.Text = "ADD CUSTOMER"
        '
        'lbl_close
        '
        Me.lbl_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_close.AutoSize = True
        Me.lbl_close.BackColor = System.Drawing.Color.Transparent
        Me.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_close.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_close.ForeColor = System.Drawing.Color.White
        Me.lbl_close.Location = New System.Drawing.Point(477, 9)
        Me.lbl_close.Name = "lbl_close"
        Me.lbl_close.Size = New System.Drawing.Size(17, 16)
        Me.lbl_close.TabIndex = 23
        Me.lbl_close.Text = "X"
        '
        'tb_name
        '
        Me.tb_name.BackColor = System.Drawing.Color.White
        Me.tb_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_name.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name.Location = New System.Drawing.Point(149, 87)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(324, 27)
        Me.tb_name.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(29, 90)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 20)
        Me.Label20.TabIndex = 93
        Me.Label20.Text = "Customer Name"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_accountno
        '
        Me.tb_accountno.BackColor = System.Drawing.Color.White
        Me.tb_accountno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_accountno.Enabled = False
        Me.tb_accountno.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_accountno.Location = New System.Drawing.Point(149, 54)
        Me.tb_accountno.Name = "tb_accountno"
        Me.tb_accountno.ReadOnly = True
        Me.tb_accountno.Size = New System.Drawing.Size(324, 27)
        Me.tb_accountno.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(29, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Account Number"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(29, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Address"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_address
        '
        Me.tb_address.BackColor = System.Drawing.Color.White
        Me.tb_address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_address.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_address.Location = New System.Drawing.Point(149, 120)
        Me.tb_address.Multiline = True
        Me.tb_address.Name = "tb_address"
        Me.tb_address.Size = New System.Drawing.Size(324, 91)
        Me.tb_address.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(29, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Contact Person"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_conperson
        '
        Me.tb_conperson.BackColor = System.Drawing.Color.White
        Me.tb_conperson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_conperson.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_conperson.Location = New System.Drawing.Point(149, 217)
        Me.tb_conperson.Name = "tb_conperson"
        Me.tb_conperson.Size = New System.Drawing.Size(324, 27)
        Me.tb_conperson.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(29, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Contact Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_contactno
        '
        Me.tb_contactno.BackColor = System.Drawing.Color.White
        Me.tb_contactno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_contactno.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_contactno.Location = New System.Drawing.Point(149, 250)
        Me.tb_contactno.Name = "tb_contactno"
        Me.tb_contactno.Size = New System.Drawing.Size(324, 27)
        Me.tb_contactno.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(29, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 20)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Credit Limit"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_limit
        '
        Me.tb_limit.BackColor = System.Drawing.Color.White
        Me.tb_limit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_limit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_limit.Location = New System.Drawing.Point(149, 283)
        Me.tb_limit.Name = "tb_limit"
        Me.tb_limit.Size = New System.Drawing.Size(324, 27)
        Me.tb_limit.TabIndex = 4
        Me.tb_limit.Text = "0.00"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(387, 351)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 27)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "CLEAR"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(268, 351)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(115, 27)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "SAVE"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(268, 349)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(115, 27)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        Me.btnUpdate.Visible = False
        '
        'lbl_CustomerID
        '
        Me.lbl_CustomerID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CustomerID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_CustomerID.Location = New System.Drawing.Point(477, 57)
        Me.lbl_CustomerID.Name = "lbl_CustomerID"
        Me.lbl_CustomerID.Size = New System.Drawing.Size(24, 20)
        Me.lbl_CustomerID.TabIndex = 92
        Me.lbl_CustomerID.Text = "0"
        Me.lbl_CustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_CustomerID.Visible = False
        '
        'tb_accountnoEdit
        '
        Me.tb_accountnoEdit.BackColor = System.Drawing.Color.White
        Me.tb_accountnoEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_accountnoEdit.Enabled = False
        Me.tb_accountnoEdit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_accountnoEdit.Location = New System.Drawing.Point(149, 54)
        Me.tb_accountnoEdit.Name = "tb_accountnoEdit"
        Me.tb_accountnoEdit.ReadOnly = True
        Me.tb_accountnoEdit.Size = New System.Drawing.Size(324, 27)
        Me.tb_accountnoEdit.TabIndex = 94
        Me.tb_accountnoEdit.Visible = False
        '
        'tb_terms
        '
        Me.tb_terms.BackColor = System.Drawing.Color.White
        Me.tb_terms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_terms.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_terms.Location = New System.Drawing.Point(149, 316)
        Me.tb_terms.Name = "tb_terms"
        Me.tb_terms.Size = New System.Drawing.Size(324, 27)
        Me.tb_terms.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(29, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Payment Terms"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(503, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.tb_terms)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tb_accountnoEdit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.tb_limit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_contactno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_conperson)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_address)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_name)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tb_accountno)
        Me.Controls.Add(Me.lbl_CustomerID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_AddCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_cadd As Label
    Friend WithEvents lbl_close As Label
    Friend WithEvents tb_name As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tb_accountno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_address As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_conperson As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_contactno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_limit As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lbl_CustomerID As Label
    Friend WithEvents tb_accountnoEdit As TextBox
    Friend WithEvents tb_terms As TextBox
    Friend WithEvents Label5 As Label
End Class
