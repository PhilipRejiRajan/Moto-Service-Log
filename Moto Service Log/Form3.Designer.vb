<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_Invoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Invoice))
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpbox_regdetails = New System.Windows.Forms.GroupBox()
        Me.combox_regno = New System.Windows.Forms.ComboBox()
        Me.txtbox_email = New System.Windows.Forms.TextBox()
        Me.txtbox_yearofmfd = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_regno = New System.Windows.Forms.Label()
        Me.txtbox_model = New System.Windows.Forms.TextBox()
        Me.lbl_yearofmfd = New System.Windows.Forms.Label()
        Me.txtbox_address = New System.Windows.Forms.TextBox()
        Me.txtbox_make = New System.Windows.Forms.TextBox()
        Me.lbl_custname = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.txtbox_custname = New System.Windows.Forms.TextBox()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.lbl_phoneno = New System.Windows.Forms.Label()
        Me.txtbox_phoneno = New System.Windows.Forms.TextBox()
        Me.lbl_make = New System.Windows.Forms.Label()
        Me.grpbox_billdetails = New System.Windows.Forms.GroupBox()
        Me.combox_billid = New System.Windows.Forms.ComboBox()
        Me.txtbox_paymode = New System.Windows.Forms.TextBox()
        Me.txtbox_status = New System.Windows.Forms.TextBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.lbl_paymode = New System.Windows.Forms.Label()
        Me.txtbox_totalamt = New System.Windows.Forms.TextBox()
        Me.lbl_totalamt = New System.Windows.Forms.Label()
        Me.dtpick_billdate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_billdate = New System.Windows.Forms.Label()
        Me.lbl_billid = New System.Windows.Forms.Label()
        Me.grpbox_servdetails = New System.Windows.Forms.GroupBox()
        Me.dgv_services = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.grpbox_regdetails.SuspendLayout()
        Me.grpbox_billdetails.SuspendLayout()
        Me.grpbox_servdetails.SuspendLayout()
        CType(Me.dgv_services, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(284, 1202)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(159, 54)
        Me.btn_print.TabIndex = 5
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(562, 1202)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(159, 54)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.grpbox_servdetails)
        Me.Panel1.Controls.Add(Me.grpbox_billdetails)
        Me.Panel1.Controls.Add(Me.grpbox_regdetails)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1058, 1161)
        Me.Panel1.TabIndex = 7
        '
        'grpbox_regdetails
        '
        Me.grpbox_regdetails.Controls.Add(Me.combox_regno)
        Me.grpbox_regdetails.Controls.Add(Me.txtbox_email)
        Me.grpbox_regdetails.Controls.Add(Me.txtbox_yearofmfd)
        Me.grpbox_regdetails.Controls.Add(Me.lbl_email)
        Me.grpbox_regdetails.Controls.Add(Me.lbl_regno)
        Me.grpbox_regdetails.Controls.Add(Me.txtbox_model)
        Me.grpbox_regdetails.Controls.Add(Me.lbl_yearofmfd)
        Me.grpbox_regdetails.Controls.Add(Me.txtbox_address)
        Me.grpbox_regdetails.Controls.Add(Me.txtbox_make)
        Me.grpbox_regdetails.Controls.Add(Me.lbl_custname)
        Me.grpbox_regdetails.Controls.Add(Me.lbl_address)
        Me.grpbox_regdetails.Controls.Add(Me.txtbox_custname)
        Me.grpbox_regdetails.Controls.Add(Me.lbl_model)
        Me.grpbox_regdetails.Controls.Add(Me.lbl_phoneno)
        Me.grpbox_regdetails.Controls.Add(Me.txtbox_phoneno)
        Me.grpbox_regdetails.Controls.Add(Me.lbl_make)
        Me.grpbox_regdetails.Location = New System.Drawing.Point(29, 18)
        Me.grpbox_regdetails.Name = "grpbox_regdetails"
        Me.grpbox_regdetails.Size = New System.Drawing.Size(985, 403)
        Me.grpbox_regdetails.TabIndex = 4
        Me.grpbox_regdetails.TabStop = False
        Me.grpbox_regdetails.Text = "Customer and Bike Details:"
        '
        'combox_regno
        '
        Me.combox_regno.FormattingEnabled = True
        Me.combox_regno.Location = New System.Drawing.Point(185, 55)
        Me.combox_regno.Name = "combox_regno"
        Me.combox_regno.Size = New System.Drawing.Size(254, 28)
        Me.combox_regno.TabIndex = 16
        '
        'txtbox_email
        '
        Me.txtbox_email.Location = New System.Drawing.Point(659, 338)
        Me.txtbox_email.Name = "txtbox_email"
        Me.txtbox_email.ReadOnly = True
        Me.txtbox_email.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_email.TabIndex = 12
        '
        'txtbox_yearofmfd
        '
        Me.txtbox_yearofmfd.Location = New System.Drawing.Point(185, 269)
        Me.txtbox_yearofmfd.MaxLength = 4
        Me.txtbox_yearofmfd.Name = "txtbox_yearofmfd"
        Me.txtbox_yearofmfd.ReadOnly = True
        Me.txtbox_yearofmfd.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_yearofmfd.TabIndex = 15
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(481, 338)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(52, 20)
        Me.lbl_email.TabIndex = 4
        Me.lbl_email.Text = "Email:"
        '
        'lbl_regno
        '
        Me.lbl_regno.AutoSize = True
        Me.lbl_regno.Location = New System.Drawing.Point(27, 55)
        Me.lbl_regno.Name = "lbl_regno"
        Me.lbl_regno.Size = New System.Drawing.Size(123, 20)
        Me.lbl_regno.TabIndex = 0
        Me.lbl_regno.Text = "Registration No:"
        '
        'txtbox_model
        '
        Me.txtbox_model.Location = New System.Drawing.Point(185, 199)
        Me.txtbox_model.Name = "txtbox_model"
        Me.txtbox_model.ReadOnly = True
        Me.txtbox_model.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_model.TabIndex = 14
        '
        'lbl_yearofmfd
        '
        Me.lbl_yearofmfd.AutoSize = True
        Me.lbl_yearofmfd.Location = New System.Drawing.Point(27, 269)
        Me.lbl_yearofmfd.Name = "lbl_yearofmfd"
        Me.lbl_yearofmfd.Size = New System.Drawing.Size(99, 20)
        Me.lbl_yearofmfd.TabIndex = 7
        Me.lbl_yearofmfd.Text = "Year Of Mfd:"
        '
        'txtbox_address
        '
        Me.txtbox_address.Location = New System.Drawing.Point(659, 199)
        Me.txtbox_address.Multiline = True
        Me.txtbox_address.Name = "txtbox_address"
        Me.txtbox_address.ReadOnly = True
        Me.txtbox_address.Size = New System.Drawing.Size(254, 105)
        Me.txtbox_address.TabIndex = 11
        '
        'txtbox_make
        '
        Me.txtbox_make.Location = New System.Drawing.Point(185, 126)
        Me.txtbox_make.Name = "txtbox_make"
        Me.txtbox_make.ReadOnly = True
        Me.txtbox_make.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_make.TabIndex = 13
        '
        'lbl_custname
        '
        Me.lbl_custname.AutoSize = True
        Me.lbl_custname.Location = New System.Drawing.Point(481, 55)
        Me.lbl_custname.Name = "lbl_custname"
        Me.lbl_custname.Size = New System.Drawing.Size(128, 20)
        Me.lbl_custname.TabIndex = 1
        Me.lbl_custname.Text = "Customer Name:"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Location = New System.Drawing.Point(481, 199)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(72, 20)
        Me.lbl_address.TabIndex = 3
        Me.lbl_address.Text = "Address:"
        '
        'txtbox_custname
        '
        Me.txtbox_custname.Location = New System.Drawing.Point(659, 55)
        Me.txtbox_custname.Name = "txtbox_custname"
        Me.txtbox_custname.ReadOnly = True
        Me.txtbox_custname.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_custname.TabIndex = 9
        '
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.Location = New System.Drawing.Point(27, 199)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(56, 20)
        Me.lbl_model.TabIndex = 6
        Me.lbl_model.Text = "Model:"
        '
        'lbl_phoneno
        '
        Me.lbl_phoneno.AutoSize = True
        Me.lbl_phoneno.Location = New System.Drawing.Point(481, 126)
        Me.lbl_phoneno.Name = "lbl_phoneno"
        Me.lbl_phoneno.Size = New System.Drawing.Size(83, 20)
        Me.lbl_phoneno.TabIndex = 2
        Me.lbl_phoneno.Text = "Phone No:"
        '
        'txtbox_phoneno
        '
        Me.txtbox_phoneno.Location = New System.Drawing.Point(659, 126)
        Me.txtbox_phoneno.MaxLength = 10
        Me.txtbox_phoneno.Name = "txtbox_phoneno"
        Me.txtbox_phoneno.ReadOnly = True
        Me.txtbox_phoneno.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_phoneno.TabIndex = 10
        '
        'lbl_make
        '
        Me.lbl_make.AutoSize = True
        Me.lbl_make.Location = New System.Drawing.Point(27, 126)
        Me.lbl_make.Name = "lbl_make"
        Me.lbl_make.Size = New System.Drawing.Size(52, 20)
        Me.lbl_make.TabIndex = 5
        Me.lbl_make.Text = "Make:"
        '
        'grpbox_billdetails
        '
        Me.grpbox_billdetails.Controls.Add(Me.combox_billid)
        Me.grpbox_billdetails.Controls.Add(Me.txtbox_paymode)
        Me.grpbox_billdetails.Controls.Add(Me.txtbox_status)
        Me.grpbox_billdetails.Controls.Add(Me.lbl_status)
        Me.grpbox_billdetails.Controls.Add(Me.lbl_paymode)
        Me.grpbox_billdetails.Controls.Add(Me.txtbox_totalamt)
        Me.grpbox_billdetails.Controls.Add(Me.lbl_totalamt)
        Me.grpbox_billdetails.Controls.Add(Me.dtpick_billdate)
        Me.grpbox_billdetails.Controls.Add(Me.lbl_billdate)
        Me.grpbox_billdetails.Controls.Add(Me.lbl_billid)
        Me.grpbox_billdetails.Location = New System.Drawing.Point(29, 427)
        Me.grpbox_billdetails.Name = "grpbox_billdetails"
        Me.grpbox_billdetails.Size = New System.Drawing.Size(985, 281)
        Me.grpbox_billdetails.TabIndex = 5
        Me.grpbox_billdetails.TabStop = False
        Me.grpbox_billdetails.Text = "Invoice Details:"
        '
        'combox_billid
        '
        Me.combox_billid.FormattingEnabled = True
        Me.combox_billid.Location = New System.Drawing.Point(185, 58)
        Me.combox_billid.Name = "combox_billid"
        Me.combox_billid.Size = New System.Drawing.Size(254, 28)
        Me.combox_billid.TabIndex = 17
        '
        'txtbox_paymode
        '
        Me.txtbox_paymode.Location = New System.Drawing.Point(639, 138)
        Me.txtbox_paymode.Name = "txtbox_paymode"
        Me.txtbox_paymode.ReadOnly = True
        Me.txtbox_paymode.Size = New System.Drawing.Size(251, 26)
        Me.txtbox_paymode.TabIndex = 24
        '
        'txtbox_status
        '
        Me.txtbox_status.Location = New System.Drawing.Point(185, 221)
        Me.txtbox_status.Name = "txtbox_status"
        Me.txtbox_status.ReadOnly = True
        Me.txtbox_status.Size = New System.Drawing.Size(251, 26)
        Me.txtbox_status.TabIndex = 23
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(27, 221)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(60, 20)
        Me.lbl_status.TabIndex = 22
        Me.lbl_status.Text = "Status:"
        '
        'lbl_paymode
        '
        Me.lbl_paymode.AutoSize = True
        Me.lbl_paymode.Location = New System.Drawing.Point(481, 139)
        Me.lbl_paymode.Name = "lbl_paymode"
        Me.lbl_paymode.Size = New System.Drawing.Size(119, 20)
        Me.lbl_paymode.TabIndex = 21
        Me.lbl_paymode.Text = "Payment Mode:"
        '
        'txtbox_totalamt
        '
        Me.txtbox_totalamt.Location = New System.Drawing.Point(185, 139)
        Me.txtbox_totalamt.Name = "txtbox_totalamt"
        Me.txtbox_totalamt.ReadOnly = True
        Me.txtbox_totalamt.Size = New System.Drawing.Size(250, 26)
        Me.txtbox_totalamt.TabIndex = 20
        '
        'lbl_totalamt
        '
        Me.lbl_totalamt.AutoSize = True
        Me.lbl_totalamt.Location = New System.Drawing.Point(27, 139)
        Me.lbl_totalamt.Name = "lbl_totalamt"
        Me.lbl_totalamt.Size = New System.Drawing.Size(108, 20)
        Me.lbl_totalamt.TabIndex = 19
        Me.lbl_totalamt.Text = "Total Amount:"
        '
        'dtpick_billdate
        '
        Me.dtpick_billdate.Location = New System.Drawing.Point(639, 58)
        Me.dtpick_billdate.Name = "dtpick_billdate"
        Me.dtpick_billdate.Size = New System.Drawing.Size(251, 26)
        Me.dtpick_billdate.TabIndex = 10
        '
        'lbl_billdate
        '
        Me.lbl_billdate.AutoSize = True
        Me.lbl_billdate.Location = New System.Drawing.Point(481, 58)
        Me.lbl_billdate.Name = "lbl_billdate"
        Me.lbl_billdate.Size = New System.Drawing.Size(72, 20)
        Me.lbl_billdate.TabIndex = 9
        Me.lbl_billdate.Text = "Bill Date:"
        '
        'lbl_billid
        '
        Me.lbl_billid.AutoSize = True
        Me.lbl_billid.Location = New System.Drawing.Point(27, 58)
        Me.lbl_billid.Name = "lbl_billid"
        Me.lbl_billid.Size = New System.Drawing.Size(54, 20)
        Me.lbl_billid.TabIndex = 7
        Me.lbl_billid.Text = "Bill ID:"
        '
        'grpbox_servdetails
        '
        Me.grpbox_servdetails.Controls.Add(Me.dgv_services)
        Me.grpbox_servdetails.Location = New System.Drawing.Point(29, 714)
        Me.grpbox_servdetails.Name = "grpbox_servdetails"
        Me.grpbox_servdetails.Size = New System.Drawing.Size(985, 403)
        Me.grpbox_servdetails.TabIndex = 25
        Me.grpbox_servdetails.TabStop = False
        Me.grpbox_servdetails.Text = "Service Details:"
        '
        'dgv_services
        '
        Me.dgv_services.AllowUserToAddRows = False
        Me.dgv_services.AllowUserToDeleteRows = False
        Me.dgv_services.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_services.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_services.Location = New System.Drawing.Point(31, 46)
        Me.dgv_services.Name = "dgv_services"
        Me.dgv_services.ReadOnly = True
        Me.dgv_services.RowHeadersWidth = 62
        Me.dgv_services.RowTemplate.Height = 28
        Me.dgv_services.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_services.Size = New System.Drawing.Size(920, 328)
        Me.dgv_services.TabIndex = 0
        '
        'form_Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1082, 1292)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_print)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_Invoice"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.Panel1.ResumeLayout(False)
        Me.grpbox_regdetails.ResumeLayout(False)
        Me.grpbox_regdetails.PerformLayout()
        Me.grpbox_billdetails.ResumeLayout(False)
        Me.grpbox_billdetails.PerformLayout()
        Me.grpbox_servdetails.ResumeLayout(False)
        CType(Me.dgv_services, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_print As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grpbox_regdetails As GroupBox
    Friend WithEvents combox_regno As ComboBox
    Friend WithEvents txtbox_email As TextBox
    Friend WithEvents txtbox_yearofmfd As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_regno As Label
    Friend WithEvents txtbox_model As TextBox
    Friend WithEvents lbl_yearofmfd As Label
    Friend WithEvents txtbox_address As TextBox
    Friend WithEvents txtbox_make As TextBox
    Friend WithEvents lbl_custname As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents txtbox_custname As TextBox
    Friend WithEvents lbl_model As Label
    Friend WithEvents lbl_phoneno As Label
    Friend WithEvents txtbox_phoneno As TextBox
    Friend WithEvents lbl_make As Label
    Friend WithEvents grpbox_billdetails As GroupBox
    Friend WithEvents combox_billid As ComboBox
    Friend WithEvents txtbox_paymode As TextBox
    Friend WithEvents txtbox_status As TextBox
    Friend WithEvents lbl_status As Label
    Friend WithEvents lbl_paymode As Label
    Friend WithEvents txtbox_totalamt As TextBox
    Friend WithEvents lbl_totalamt As Label
    Friend WithEvents dtpick_billdate As DateTimePicker
    Friend WithEvents lbl_billdate As Label
    Friend WithEvents lbl_billid As Label
    Friend WithEvents grpbox_servdetails As GroupBox
    Friend WithEvents dgv_services As DataGridView
End Class
