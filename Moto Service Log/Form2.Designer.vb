<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_dashboard
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
        Me.tabcontrol_dashboard = New System.Windows.Forms.TabControl()
        Me.TabPage_Reg = New System.Windows.Forms.TabPage()
        Me.btn_reg_editrow = New System.Windows.Forms.Button()
        Me.btn_reg_deleterow = New System.Windows.Forms.Button()
        Me.btn_reg_viewdetails = New System.Windows.Forms.Button()
        Me.dgv_regtab = New System.Windows.Forms.DataGridView()
        Me.panel_regtab = New System.Windows.Forms.Panel()
        Me.btn_reg_clear = New System.Windows.Forms.Button()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.txtbox_yearofmfd = New System.Windows.Forms.TextBox()
        Me.txtbox_model = New System.Windows.Forms.TextBox()
        Me.txtbox_make = New System.Windows.Forms.TextBox()
        Me.txtbox_email = New System.Windows.Forms.TextBox()
        Me.txtbox_address = New System.Windows.Forms.TextBox()
        Me.txtbox_phoneno = New System.Windows.Forms.TextBox()
        Me.txtbox_custname = New System.Windows.Forms.TextBox()
        Me.txtbox_regno = New System.Windows.Forms.TextBox()
        Me.lbl_yearofmfd = New System.Windows.Forms.Label()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.lbl_make = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lbl_phoneno = New System.Windows.Forms.Label()
        Me.lbl_custname = New System.Windows.Forms.Label()
        Me.lbl_regno = New System.Windows.Forms.Label()
        Me.TabPage_Serv = New System.Windows.Forms.TabPage()
        Me.btn_serv_deleterow = New System.Windows.Forms.Button()
        Me.btn_serv_editrow = New System.Windows.Forms.Button()
        Me.btn_serv_viewdetails = New System.Windows.Forms.Button()
        Me.dgv_servtab = New System.Windows.Forms.DataGridView()
        Me.panel_servtab = New System.Windows.Forms.Panel()
        Me.btn_serv_clear = New System.Windows.Forms.Button()
        Me.btn_addservice = New System.Windows.Forms.Button()
        Me.txtbox_servcost = New System.Windows.Forms.TextBox()
        Me.txtbox_servname = New System.Windows.Forms.TextBox()
        Me.txtbox_serviceid = New System.Windows.Forms.TextBox()
        Me.lbl_servcost = New System.Windows.Forms.Label()
        Me.lbl_servname = New System.Windows.Forms.Label()
        Me.lbl_serviceid = New System.Windows.Forms.Label()
        Me.TabPage_Mech = New System.Windows.Forms.TabPage()
        Me.btn_mech_deleterow = New System.Windows.Forms.Button()
        Me.btn_mech_editrow = New System.Windows.Forms.Button()
        Me.btn_mech_viewdetails = New System.Windows.Forms.Button()
        Me.dgv_mechtab = New System.Windows.Forms.DataGridView()
        Me.panel_mechtab = New System.Windows.Forms.Panel()
        Me.btn_mech_clear = New System.Windows.Forms.Button()
        Me.btn_addmechanic = New System.Windows.Forms.Button()
        Me.txtbox_expertise = New System.Windows.Forms.TextBox()
        Me.txtbox_mech_phoneno = New System.Windows.Forms.TextBox()
        Me.txtbox_mechname = New System.Windows.Forms.TextBox()
        Me.txtbox_mechanicid = New System.Windows.Forms.TextBox()
        Me.lbl_expertise = New System.Windows.Forms.Label()
        Me.lbl_mech_phoneno = New System.Windows.Forms.Label()
        Me.lbl_mechname = New System.Windows.Forms.Label()
        Me.lbl_mechanicid = New System.Windows.Forms.Label()
        Me.TabPage_Assig = New System.Windows.Forms.TabPage()
        Me.btn_assign_deleterow = New System.Windows.Forms.Button()
        Me.btn_assign_editrow = New System.Windows.Forms.Button()
        Me.btn_assign_viewdetails = New System.Windows.Forms.Button()
        Me.dgv_servassigntab = New System.Windows.Forms.DataGridView()
        Me.panel_assigtab = New System.Windows.Forms.Panel()
        Me.btn_getservcost = New System.Windows.Forms.Button()
        Me.combox_assign_status = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker_assigtab = New System.Windows.Forms.DateTimePicker()
        Me.btn_assign_clear = New System.Windows.Forms.Button()
        Me.btn_assignserv = New System.Windows.Forms.Button()
        Me.txtbox_assign_servcost = New System.Windows.Forms.TextBox()
        Me.combox_assign_mechid = New System.Windows.Forms.ComboBox()
        Me.combox_assign_servid = New System.Windows.Forms.ComboBox()
        Me.combox_assign_regno = New System.Windows.Forms.ComboBox()
        Me.txtbox_servassignid = New System.Windows.Forms.TextBox()
        Me.lbl_assign_servcost = New System.Windows.Forms.Label()
        Me.lbl_servstatus = New System.Windows.Forms.Label()
        Me.lbl_servdate = New System.Windows.Forms.Label()
        Me.lbl_assign_mechanicid = New System.Windows.Forms.Label()
        Me.lbl_assign_serviceid = New System.Windows.Forms.Label()
        Me.lbl_assign_regno = New System.Windows.Forms.Label()
        Me.lbl_servassignid = New System.Windows.Forms.Label()
        Me.TabPage_Bills = New System.Windows.Forms.TabPage()
        Me.btn_bills_deleterow = New System.Windows.Forms.Button()
        Me.btn_bills_editrow = New System.Windows.Forms.Button()
        Me.btn_bills_viewdetails = New System.Windows.Forms.Button()
        Me.dgv_billstab = New System.Windows.Forms.DataGridView()
        Me.panel_billstab = New System.Windows.Forms.Panel()
        Me.btn_gen_invoice = New System.Windows.Forms.Button()
        Me.btn_bills_clear = New System.Windows.Forms.Button()
        Me.btn_addbill = New System.Windows.Forms.Button()
        Me.combox_bills_status = New System.Windows.Forms.ComboBox()
        Me.combox_paymode = New System.Windows.Forms.ComboBox()
        Me.btn_totalamt = New System.Windows.Forms.Button()
        Me.txtbox_totalamt = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_billstab = New System.Windows.Forms.DateTimePicker()
        Me.combox_bills_regno = New System.Windows.Forms.ComboBox()
        Me.txtbox_billid = New System.Windows.Forms.TextBox()
        Me.lbl_bills_status = New System.Windows.Forms.Label()
        Me.lbl_paymode = New System.Windows.Forms.Label()
        Me.lbl_totalamt = New System.Windows.Forms.Label()
        Me.lbl_billdate = New System.Windows.Forms.Label()
        Me.lbl_bills_regno = New System.Windows.Forms.Label()
        Me.lbl_billid = New System.Windows.Forms.Label()
        Me.tabcontrol_dashboard.SuspendLayout()
        Me.TabPage_Reg.SuspendLayout()
        CType(Me.dgv_regtab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_regtab.SuspendLayout()
        Me.TabPage_Serv.SuspendLayout()
        CType(Me.dgv_servtab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_servtab.SuspendLayout()
        Me.TabPage_Mech.SuspendLayout()
        CType(Me.dgv_mechtab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_mechtab.SuspendLayout()
        Me.TabPage_Assig.SuspendLayout()
        CType(Me.dgv_servassigntab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_assigtab.SuspendLayout()
        Me.TabPage_Bills.SuspendLayout()
        CType(Me.dgv_billstab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_billstab.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabcontrol_dashboard
        '
        Me.tabcontrol_dashboard.Controls.Add(Me.TabPage_Reg)
        Me.tabcontrol_dashboard.Controls.Add(Me.TabPage_Serv)
        Me.tabcontrol_dashboard.Controls.Add(Me.TabPage_Mech)
        Me.tabcontrol_dashboard.Controls.Add(Me.TabPage_Assig)
        Me.tabcontrol_dashboard.Controls.Add(Me.TabPage_Bills)
        Me.tabcontrol_dashboard.ItemSize = New System.Drawing.Size(200, 55)
        Me.tabcontrol_dashboard.Location = New System.Drawing.Point(12, 12)
        Me.tabcontrol_dashboard.Multiline = True
        Me.tabcontrol_dashboard.Name = "tabcontrol_dashboard"
        Me.tabcontrol_dashboard.SelectedIndex = 0
        Me.tabcontrol_dashboard.Size = New System.Drawing.Size(1793, 938)
        Me.tabcontrol_dashboard.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabcontrol_dashboard.TabIndex = 0
        '
        'TabPage_Reg
        '
        Me.TabPage_Reg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage_Reg.Controls.Add(Me.btn_reg_editrow)
        Me.TabPage_Reg.Controls.Add(Me.btn_reg_deleterow)
        Me.TabPage_Reg.Controls.Add(Me.btn_reg_viewdetails)
        Me.TabPage_Reg.Controls.Add(Me.dgv_regtab)
        Me.TabPage_Reg.Controls.Add(Me.panel_regtab)
        Me.TabPage_Reg.Location = New System.Drawing.Point(4, 59)
        Me.TabPage_Reg.Name = "TabPage_Reg"
        Me.TabPage_Reg.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Reg.Size = New System.Drawing.Size(1785, 875)
        Me.TabPage_Reg.TabIndex = 0
        Me.TabPage_Reg.Text = "Registration"
        Me.TabPage_Reg.UseVisualStyleBackColor = True
        '
        'btn_reg_editrow
        '
        Me.btn_reg_editrow.Location = New System.Drawing.Point(1152, 703)
        Me.btn_reg_editrow.Name = "btn_reg_editrow"
        Me.btn_reg_editrow.Size = New System.Drawing.Size(167, 49)
        Me.btn_reg_editrow.TabIndex = 20
        Me.btn_reg_editrow.Text = "Edit Row"
        Me.btn_reg_editrow.UseVisualStyleBackColor = True
        '
        'btn_reg_deleterow
        '
        Me.btn_reg_deleterow.Location = New System.Drawing.Point(1426, 703)
        Me.btn_reg_deleterow.Name = "btn_reg_deleterow"
        Me.btn_reg_deleterow.Size = New System.Drawing.Size(167, 49)
        Me.btn_reg_deleterow.TabIndex = 19
        Me.btn_reg_deleterow.Text = "Delete Row"
        Me.btn_reg_deleterow.UseVisualStyleBackColor = True
        '
        'btn_reg_viewdetails
        '
        Me.btn_reg_viewdetails.Location = New System.Drawing.Point(876, 703)
        Me.btn_reg_viewdetails.Name = "btn_reg_viewdetails"
        Me.btn_reg_viewdetails.Size = New System.Drawing.Size(167, 49)
        Me.btn_reg_viewdetails.TabIndex = 18
        Me.btn_reg_viewdetails.Text = "View Details"
        Me.btn_reg_viewdetails.UseVisualStyleBackColor = True
        '
        'dgv_regtab
        '
        Me.dgv_regtab.AllowUserToAddRows = False
        Me.dgv_regtab.AllowUserToDeleteRows = False
        Me.dgv_regtab.AllowUserToResizeColumns = False
        Me.dgv_regtab.AllowUserToResizeRows = False
        Me.dgv_regtab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_regtab.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_regtab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_regtab.Location = New System.Drawing.Point(636, 22)
        Me.dgv_regtab.Name = "dgv_regtab"
        Me.dgv_regtab.RowHeadersWidth = 62
        Me.dgv_regtab.RowTemplate.Height = 28
        Me.dgv_regtab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_regtab.Size = New System.Drawing.Size(1105, 602)
        Me.dgv_regtab.TabIndex = 1
        '
        'panel_regtab
        '
        Me.panel_regtab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_regtab.Controls.Add(Me.btn_reg_clear)
        Me.panel_regtab.Controls.Add(Me.btn_register)
        Me.panel_regtab.Controls.Add(Me.txtbox_yearofmfd)
        Me.panel_regtab.Controls.Add(Me.txtbox_model)
        Me.panel_regtab.Controls.Add(Me.txtbox_make)
        Me.panel_regtab.Controls.Add(Me.txtbox_email)
        Me.panel_regtab.Controls.Add(Me.txtbox_address)
        Me.panel_regtab.Controls.Add(Me.txtbox_phoneno)
        Me.panel_regtab.Controls.Add(Me.txtbox_custname)
        Me.panel_regtab.Controls.Add(Me.txtbox_regno)
        Me.panel_regtab.Controls.Add(Me.lbl_yearofmfd)
        Me.panel_regtab.Controls.Add(Me.lbl_model)
        Me.panel_regtab.Controls.Add(Me.lbl_make)
        Me.panel_regtab.Controls.Add(Me.lbl_email)
        Me.panel_regtab.Controls.Add(Me.lbl_address)
        Me.panel_regtab.Controls.Add(Me.lbl_phoneno)
        Me.panel_regtab.Controls.Add(Me.lbl_custname)
        Me.panel_regtab.Controls.Add(Me.lbl_regno)
        Me.panel_regtab.Location = New System.Drawing.Point(26, 22)
        Me.panel_regtab.Name = "panel_regtab"
        Me.panel_regtab.Size = New System.Drawing.Size(565, 787)
        Me.panel_regtab.TabIndex = 0
        '
        'btn_reg_clear
        '
        Me.btn_reg_clear.Location = New System.Drawing.Point(311, 680)
        Me.btn_reg_clear.Name = "btn_reg_clear"
        Me.btn_reg_clear.Size = New System.Drawing.Size(167, 49)
        Me.btn_reg_clear.TabIndex = 17
        Me.btn_reg_clear.Text = "Clear"
        Me.btn_reg_clear.UseVisualStyleBackColor = True
        '
        'btn_register
        '
        Me.btn_register.Location = New System.Drawing.Point(75, 680)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(167, 49)
        Me.btn_register.TabIndex = 16
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'txtbox_yearofmfd
        '
        Me.txtbox_yearofmfd.Location = New System.Drawing.Point(184, 575)
        Me.txtbox_yearofmfd.MaxLength = 4
        Me.txtbox_yearofmfd.Name = "txtbox_yearofmfd"
        Me.txtbox_yearofmfd.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_yearofmfd.TabIndex = 15
        '
        'txtbox_model
        '
        Me.txtbox_model.Location = New System.Drawing.Point(184, 520)
        Me.txtbox_model.Name = "txtbox_model"
        Me.txtbox_model.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_model.TabIndex = 14
        '
        'txtbox_make
        '
        Me.txtbox_make.Location = New System.Drawing.Point(184, 453)
        Me.txtbox_make.Name = "txtbox_make"
        Me.txtbox_make.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_make.TabIndex = 13
        '
        'txtbox_email
        '
        Me.txtbox_email.Location = New System.Drawing.Point(184, 389)
        Me.txtbox_email.Name = "txtbox_email"
        Me.txtbox_email.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_email.TabIndex = 12
        '
        'txtbox_address
        '
        Me.txtbox_address.Location = New System.Drawing.Point(184, 249)
        Me.txtbox_address.Multiline = True
        Me.txtbox_address.Name = "txtbox_address"
        Me.txtbox_address.Size = New System.Drawing.Size(254, 105)
        Me.txtbox_address.TabIndex = 11
        '
        'txtbox_phoneno
        '
        Me.txtbox_phoneno.Location = New System.Drawing.Point(184, 178)
        Me.txtbox_phoneno.MaxLength = 10
        Me.txtbox_phoneno.Name = "txtbox_phoneno"
        Me.txtbox_phoneno.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_phoneno.TabIndex = 10
        '
        'txtbox_custname
        '
        Me.txtbox_custname.Location = New System.Drawing.Point(184, 110)
        Me.txtbox_custname.Name = "txtbox_custname"
        Me.txtbox_custname.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_custname.TabIndex = 9
        '
        'txtbox_regno
        '
        Me.txtbox_regno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbox_regno.Location = New System.Drawing.Point(184, 44)
        Me.txtbox_regno.Name = "txtbox_regno"
        Me.txtbox_regno.Size = New System.Drawing.Size(254, 26)
        Me.txtbox_regno.TabIndex = 8
        '
        'lbl_yearofmfd
        '
        Me.lbl_yearofmfd.AutoSize = True
        Me.lbl_yearofmfd.Location = New System.Drawing.Point(26, 575)
        Me.lbl_yearofmfd.Name = "lbl_yearofmfd"
        Me.lbl_yearofmfd.Size = New System.Drawing.Size(99, 20)
        Me.lbl_yearofmfd.TabIndex = 7
        Me.lbl_yearofmfd.Text = "Year Of Mfd:"
        '
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.Location = New System.Drawing.Point(26, 520)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(56, 20)
        Me.lbl_model.TabIndex = 6
        Me.lbl_model.Text = "Model:"
        '
        'lbl_make
        '
        Me.lbl_make.AutoSize = True
        Me.lbl_make.Location = New System.Drawing.Point(26, 453)
        Me.lbl_make.Name = "lbl_make"
        Me.lbl_make.Size = New System.Drawing.Size(52, 20)
        Me.lbl_make.TabIndex = 5
        Me.lbl_make.Text = "Make:"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Location = New System.Drawing.Point(26, 389)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(52, 20)
        Me.lbl_email.TabIndex = 4
        Me.lbl_email.Text = "Email:"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Location = New System.Drawing.Point(26, 249)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(72, 20)
        Me.lbl_address.TabIndex = 3
        Me.lbl_address.Text = "Address:"
        '
        'lbl_phoneno
        '
        Me.lbl_phoneno.AutoSize = True
        Me.lbl_phoneno.Location = New System.Drawing.Point(26, 178)
        Me.lbl_phoneno.Name = "lbl_phoneno"
        Me.lbl_phoneno.Size = New System.Drawing.Size(83, 20)
        Me.lbl_phoneno.TabIndex = 2
        Me.lbl_phoneno.Text = "Phone No:"
        '
        'lbl_custname
        '
        Me.lbl_custname.AutoSize = True
        Me.lbl_custname.Location = New System.Drawing.Point(26, 110)
        Me.lbl_custname.Name = "lbl_custname"
        Me.lbl_custname.Size = New System.Drawing.Size(128, 20)
        Me.lbl_custname.TabIndex = 1
        Me.lbl_custname.Text = "Customer Name:"
        '
        'lbl_regno
        '
        Me.lbl_regno.AutoSize = True
        Me.lbl_regno.Location = New System.Drawing.Point(26, 44)
        Me.lbl_regno.Name = "lbl_regno"
        Me.lbl_regno.Size = New System.Drawing.Size(123, 20)
        Me.lbl_regno.TabIndex = 0
        Me.lbl_regno.Text = "Registration No:"
        '
        'TabPage_Serv
        '
        Me.TabPage_Serv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage_Serv.Controls.Add(Me.btn_serv_deleterow)
        Me.TabPage_Serv.Controls.Add(Me.btn_serv_editrow)
        Me.TabPage_Serv.Controls.Add(Me.btn_serv_viewdetails)
        Me.TabPage_Serv.Controls.Add(Me.dgv_servtab)
        Me.TabPage_Serv.Controls.Add(Me.panel_servtab)
        Me.TabPage_Serv.Location = New System.Drawing.Point(4, 59)
        Me.TabPage_Serv.Name = "TabPage_Serv"
        Me.TabPage_Serv.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Serv.Size = New System.Drawing.Size(1785, 875)
        Me.TabPage_Serv.TabIndex = 1
        Me.TabPage_Serv.Text = "Services"
        Me.TabPage_Serv.UseVisualStyleBackColor = True
        '
        'btn_serv_deleterow
        '
        Me.btn_serv_deleterow.Location = New System.Drawing.Point(1426, 703)
        Me.btn_serv_deleterow.Name = "btn_serv_deleterow"
        Me.btn_serv_deleterow.Size = New System.Drawing.Size(167, 49)
        Me.btn_serv_deleterow.TabIndex = 9
        Me.btn_serv_deleterow.Text = "Delete Row"
        Me.btn_serv_deleterow.UseVisualStyleBackColor = True
        '
        'btn_serv_editrow
        '
        Me.btn_serv_editrow.Location = New System.Drawing.Point(1152, 703)
        Me.btn_serv_editrow.Name = "btn_serv_editrow"
        Me.btn_serv_editrow.Size = New System.Drawing.Size(167, 49)
        Me.btn_serv_editrow.TabIndex = 8
        Me.btn_serv_editrow.Text = "Edit Row"
        Me.btn_serv_editrow.UseVisualStyleBackColor = True
        '
        'btn_serv_viewdetails
        '
        Me.btn_serv_viewdetails.Location = New System.Drawing.Point(876, 703)
        Me.btn_serv_viewdetails.Name = "btn_serv_viewdetails"
        Me.btn_serv_viewdetails.Size = New System.Drawing.Size(167, 49)
        Me.btn_serv_viewdetails.TabIndex = 7
        Me.btn_serv_viewdetails.Text = "View Details"
        Me.btn_serv_viewdetails.UseVisualStyleBackColor = True
        '
        'dgv_servtab
        '
        Me.dgv_servtab.AllowUserToAddRows = False
        Me.dgv_servtab.AllowUserToDeleteRows = False
        Me.dgv_servtab.AllowUserToResizeColumns = False
        Me.dgv_servtab.AllowUserToResizeRows = False
        Me.dgv_servtab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_servtab.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_servtab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_servtab.Location = New System.Drawing.Point(636, 22)
        Me.dgv_servtab.Name = "dgv_servtab"
        Me.dgv_servtab.RowHeadersWidth = 62
        Me.dgv_servtab.RowTemplate.Height = 28
        Me.dgv_servtab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_servtab.Size = New System.Drawing.Size(1105, 602)
        Me.dgv_servtab.TabIndex = 1
        '
        'panel_servtab
        '
        Me.panel_servtab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_servtab.Controls.Add(Me.btn_serv_clear)
        Me.panel_servtab.Controls.Add(Me.btn_addservice)
        Me.panel_servtab.Controls.Add(Me.txtbox_servcost)
        Me.panel_servtab.Controls.Add(Me.txtbox_servname)
        Me.panel_servtab.Controls.Add(Me.txtbox_serviceid)
        Me.panel_servtab.Controls.Add(Me.lbl_servcost)
        Me.panel_servtab.Controls.Add(Me.lbl_servname)
        Me.panel_servtab.Controls.Add(Me.lbl_serviceid)
        Me.panel_servtab.Location = New System.Drawing.Point(26, 22)
        Me.panel_servtab.Name = "panel_servtab"
        Me.panel_servtab.Size = New System.Drawing.Size(565, 787)
        Me.panel_servtab.TabIndex = 0
        '
        'btn_serv_clear
        '
        Me.btn_serv_clear.Location = New System.Drawing.Point(290, 285)
        Me.btn_serv_clear.Name = "btn_serv_clear"
        Me.btn_serv_clear.Size = New System.Drawing.Size(167, 49)
        Me.btn_serv_clear.TabIndex = 6
        Me.btn_serv_clear.Text = "Clear"
        Me.btn_serv_clear.UseVisualStyleBackColor = True
        '
        'btn_addservice
        '
        Me.btn_addservice.Location = New System.Drawing.Point(53, 285)
        Me.btn_addservice.Name = "btn_addservice"
        Me.btn_addservice.Size = New System.Drawing.Size(167, 49)
        Me.btn_addservice.TabIndex = 5
        Me.btn_addservice.Text = "Add Service"
        Me.btn_addservice.UseVisualStyleBackColor = True
        '
        'txtbox_servcost
        '
        Me.txtbox_servcost.Location = New System.Drawing.Point(184, 193)
        Me.txtbox_servcost.Name = "txtbox_servcost"
        Me.txtbox_servcost.Size = New System.Drawing.Size(243, 26)
        Me.txtbox_servcost.TabIndex = 4
        '
        'txtbox_servname
        '
        Me.txtbox_servname.Location = New System.Drawing.Point(184, 116)
        Me.txtbox_servname.Name = "txtbox_servname"
        Me.txtbox_servname.Size = New System.Drawing.Size(243, 26)
        Me.txtbox_servname.TabIndex = 3
        '
        'txtbox_serviceid
        '
        Me.txtbox_serviceid.Location = New System.Drawing.Point(184, 44)
        Me.txtbox_serviceid.Name = "txtbox_serviceid"
        Me.txtbox_serviceid.ReadOnly = True
        Me.txtbox_serviceid.Size = New System.Drawing.Size(243, 26)
        Me.txtbox_serviceid.TabIndex = 1
        '
        'lbl_servcost
        '
        Me.lbl_servcost.AutoSize = True
        Me.lbl_servcost.Location = New System.Drawing.Point(26, 193)
        Me.lbl_servcost.Name = "lbl_servcost"
        Me.lbl_servcost.Size = New System.Drawing.Size(102, 20)
        Me.lbl_servcost.TabIndex = 2
        Me.lbl_servcost.Text = "Service Cost:"
        '
        'lbl_servname
        '
        Me.lbl_servname.AutoSize = True
        Me.lbl_servname.Location = New System.Drawing.Point(26, 116)
        Me.lbl_servname.Name = "lbl_servname"
        Me.lbl_servname.Size = New System.Drawing.Size(111, 20)
        Me.lbl_servname.TabIndex = 1
        Me.lbl_servname.Text = "Service Name:"
        '
        'lbl_serviceid
        '
        Me.lbl_serviceid.AutoSize = True
        Me.lbl_serviceid.Location = New System.Drawing.Point(26, 44)
        Me.lbl_serviceid.Name = "lbl_serviceid"
        Me.lbl_serviceid.Size = New System.Drawing.Size(86, 20)
        Me.lbl_serviceid.TabIndex = 0
        Me.lbl_serviceid.Text = "Service ID:"
        '
        'TabPage_Mech
        '
        Me.TabPage_Mech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage_Mech.Controls.Add(Me.btn_mech_deleterow)
        Me.TabPage_Mech.Controls.Add(Me.btn_mech_editrow)
        Me.TabPage_Mech.Controls.Add(Me.btn_mech_viewdetails)
        Me.TabPage_Mech.Controls.Add(Me.dgv_mechtab)
        Me.TabPage_Mech.Controls.Add(Me.panel_mechtab)
        Me.TabPage_Mech.Location = New System.Drawing.Point(4, 59)
        Me.TabPage_Mech.Name = "TabPage_Mech"
        Me.TabPage_Mech.Size = New System.Drawing.Size(1785, 875)
        Me.TabPage_Mech.TabIndex = 2
        Me.TabPage_Mech.Text = "Mechanics"
        Me.TabPage_Mech.UseVisualStyleBackColor = True
        '
        'btn_mech_deleterow
        '
        Me.btn_mech_deleterow.Location = New System.Drawing.Point(1426, 703)
        Me.btn_mech_deleterow.Name = "btn_mech_deleterow"
        Me.btn_mech_deleterow.Size = New System.Drawing.Size(167, 49)
        Me.btn_mech_deleterow.TabIndex = 12
        Me.btn_mech_deleterow.Text = "Delete Row"
        Me.btn_mech_deleterow.UseVisualStyleBackColor = True
        '
        'btn_mech_editrow
        '
        Me.btn_mech_editrow.Location = New System.Drawing.Point(1152, 703)
        Me.btn_mech_editrow.Name = "btn_mech_editrow"
        Me.btn_mech_editrow.Size = New System.Drawing.Size(167, 49)
        Me.btn_mech_editrow.TabIndex = 11
        Me.btn_mech_editrow.Text = "Edit Row"
        Me.btn_mech_editrow.UseVisualStyleBackColor = True
        '
        'btn_mech_viewdetails
        '
        Me.btn_mech_viewdetails.Location = New System.Drawing.Point(876, 703)
        Me.btn_mech_viewdetails.Name = "btn_mech_viewdetails"
        Me.btn_mech_viewdetails.Size = New System.Drawing.Size(167, 49)
        Me.btn_mech_viewdetails.TabIndex = 10
        Me.btn_mech_viewdetails.Text = "View Details"
        Me.btn_mech_viewdetails.UseVisualStyleBackColor = True
        '
        'dgv_mechtab
        '
        Me.dgv_mechtab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mechtab.Location = New System.Drawing.Point(636, 22)
        Me.dgv_mechtab.Name = "dgv_mechtab"
        Me.dgv_mechtab.RowHeadersWidth = 62
        Me.dgv_mechtab.RowTemplate.Height = 28
        Me.dgv_mechtab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_mechtab.Size = New System.Drawing.Size(1105, 602)
        Me.dgv_mechtab.TabIndex = 1
        '
        'panel_mechtab
        '
        Me.panel_mechtab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_mechtab.Controls.Add(Me.btn_mech_clear)
        Me.panel_mechtab.Controls.Add(Me.btn_addmechanic)
        Me.panel_mechtab.Controls.Add(Me.txtbox_expertise)
        Me.panel_mechtab.Controls.Add(Me.txtbox_mech_phoneno)
        Me.panel_mechtab.Controls.Add(Me.txtbox_mechname)
        Me.panel_mechtab.Controls.Add(Me.txtbox_mechanicid)
        Me.panel_mechtab.Controls.Add(Me.lbl_expertise)
        Me.panel_mechtab.Controls.Add(Me.lbl_mech_phoneno)
        Me.panel_mechtab.Controls.Add(Me.lbl_mechname)
        Me.panel_mechtab.Controls.Add(Me.lbl_mechanicid)
        Me.panel_mechtab.Location = New System.Drawing.Point(26, 22)
        Me.panel_mechtab.Name = "panel_mechtab"
        Me.panel_mechtab.Size = New System.Drawing.Size(565, 787)
        Me.panel_mechtab.TabIndex = 0
        '
        'btn_mech_clear
        '
        Me.btn_mech_clear.Location = New System.Drawing.Point(278, 461)
        Me.btn_mech_clear.Name = "btn_mech_clear"
        Me.btn_mech_clear.Size = New System.Drawing.Size(167, 49)
        Me.btn_mech_clear.TabIndex = 9
        Me.btn_mech_clear.Text = "Clear"
        Me.btn_mech_clear.UseVisualStyleBackColor = True
        '
        'btn_addmechanic
        '
        Me.btn_addmechanic.Location = New System.Drawing.Point(61, 461)
        Me.btn_addmechanic.Name = "btn_addmechanic"
        Me.btn_addmechanic.Size = New System.Drawing.Size(167, 49)
        Me.btn_addmechanic.TabIndex = 8
        Me.btn_addmechanic.Text = "Add Mechanic"
        Me.btn_addmechanic.UseVisualStyleBackColor = True
        '
        'txtbox_expertise
        '
        Me.txtbox_expertise.Location = New System.Drawing.Point(184, 268)
        Me.txtbox_expertise.Multiline = True
        Me.txtbox_expertise.Name = "txtbox_expertise"
        Me.txtbox_expertise.Size = New System.Drawing.Size(247, 105)
        Me.txtbox_expertise.TabIndex = 7
        '
        'txtbox_mech_phoneno
        '
        Me.txtbox_mech_phoneno.Location = New System.Drawing.Point(184, 195)
        Me.txtbox_mech_phoneno.MaxLength = 10
        Me.txtbox_mech_phoneno.Name = "txtbox_mech_phoneno"
        Me.txtbox_mech_phoneno.Size = New System.Drawing.Size(247, 26)
        Me.txtbox_mech_phoneno.TabIndex = 6
        '
        'txtbox_mechname
        '
        Me.txtbox_mechname.Location = New System.Drawing.Point(184, 117)
        Me.txtbox_mechname.Name = "txtbox_mechname"
        Me.txtbox_mechname.Size = New System.Drawing.Size(247, 26)
        Me.txtbox_mechname.TabIndex = 5
        '
        'txtbox_mechanicid
        '
        Me.txtbox_mechanicid.Location = New System.Drawing.Point(184, 44)
        Me.txtbox_mechanicid.Name = "txtbox_mechanicid"
        Me.txtbox_mechanicid.Size = New System.Drawing.Size(247, 26)
        Me.txtbox_mechanicid.TabIndex = 4
        '
        'lbl_expertise
        '
        Me.lbl_expertise.AutoSize = True
        Me.lbl_expertise.Location = New System.Drawing.Point(26, 268)
        Me.lbl_expertise.Name = "lbl_expertise"
        Me.lbl_expertise.Size = New System.Drawing.Size(79, 20)
        Me.lbl_expertise.TabIndex = 3
        Me.lbl_expertise.Text = "Expertise:"
        '
        'lbl_mech_phoneno
        '
        Me.lbl_mech_phoneno.AutoSize = True
        Me.lbl_mech_phoneno.Location = New System.Drawing.Point(26, 195)
        Me.lbl_mech_phoneno.Name = "lbl_mech_phoneno"
        Me.lbl_mech_phoneno.Size = New System.Drawing.Size(83, 20)
        Me.lbl_mech_phoneno.TabIndex = 2
        Me.lbl_mech_phoneno.Text = "Phone No:"
        '
        'lbl_mechname
        '
        Me.lbl_mechname.AutoSize = True
        Me.lbl_mechname.Location = New System.Drawing.Point(26, 117)
        Me.lbl_mechname.Name = "lbl_mechname"
        Me.lbl_mechname.Size = New System.Drawing.Size(127, 20)
        Me.lbl_mechname.TabIndex = 1
        Me.lbl_mechname.Text = "Mechanic Name:"
        '
        'lbl_mechanicid
        '
        Me.lbl_mechanicid.AutoSize = True
        Me.lbl_mechanicid.Location = New System.Drawing.Point(26, 44)
        Me.lbl_mechanicid.Name = "lbl_mechanicid"
        Me.lbl_mechanicid.Size = New System.Drawing.Size(102, 20)
        Me.lbl_mechanicid.TabIndex = 0
        Me.lbl_mechanicid.Text = "Mechanic ID:"
        '
        'TabPage_Assig
        '
        Me.TabPage_Assig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage_Assig.Controls.Add(Me.btn_assign_deleterow)
        Me.TabPage_Assig.Controls.Add(Me.btn_assign_editrow)
        Me.TabPage_Assig.Controls.Add(Me.btn_assign_viewdetails)
        Me.TabPage_Assig.Controls.Add(Me.dgv_servassigntab)
        Me.TabPage_Assig.Controls.Add(Me.panel_assigtab)
        Me.TabPage_Assig.Location = New System.Drawing.Point(4, 59)
        Me.TabPage_Assig.Name = "TabPage_Assig"
        Me.TabPage_Assig.Size = New System.Drawing.Size(1785, 875)
        Me.TabPage_Assig.TabIndex = 3
        Me.TabPage_Assig.Text = "Service Assignments"
        Me.TabPage_Assig.UseVisualStyleBackColor = True
        '
        'btn_assign_deleterow
        '
        Me.btn_assign_deleterow.Location = New System.Drawing.Point(1426, 703)
        Me.btn_assign_deleterow.Name = "btn_assign_deleterow"
        Me.btn_assign_deleterow.Size = New System.Drawing.Size(167, 49)
        Me.btn_assign_deleterow.TabIndex = 15
        Me.btn_assign_deleterow.Text = "Delete Row"
        Me.btn_assign_deleterow.UseVisualStyleBackColor = True
        '
        'btn_assign_editrow
        '
        Me.btn_assign_editrow.Location = New System.Drawing.Point(1152, 703)
        Me.btn_assign_editrow.Name = "btn_assign_editrow"
        Me.btn_assign_editrow.Size = New System.Drawing.Size(167, 49)
        Me.btn_assign_editrow.TabIndex = 14
        Me.btn_assign_editrow.Text = "Edit Row"
        Me.btn_assign_editrow.UseVisualStyleBackColor = True
        '
        'btn_assign_viewdetails
        '
        Me.btn_assign_viewdetails.Location = New System.Drawing.Point(876, 703)
        Me.btn_assign_viewdetails.Name = "btn_assign_viewdetails"
        Me.btn_assign_viewdetails.Size = New System.Drawing.Size(167, 49)
        Me.btn_assign_viewdetails.TabIndex = 13
        Me.btn_assign_viewdetails.Text = "View Details"
        Me.btn_assign_viewdetails.UseVisualStyleBackColor = True
        '
        'dgv_servassigntab
        '
        Me.dgv_servassigntab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_servassigntab.Location = New System.Drawing.Point(636, 22)
        Me.dgv_servassigntab.Name = "dgv_servassigntab"
        Me.dgv_servassigntab.RowHeadersWidth = 62
        Me.dgv_servassigntab.RowTemplate.Height = 28
        Me.dgv_servassigntab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_servassigntab.Size = New System.Drawing.Size(1105, 602)
        Me.dgv_servassigntab.TabIndex = 2
        '
        'panel_assigtab
        '
        Me.panel_assigtab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_assigtab.Controls.Add(Me.btn_getservcost)
        Me.panel_assigtab.Controls.Add(Me.combox_assign_status)
        Me.panel_assigtab.Controls.Add(Me.DateTimePicker_assigtab)
        Me.panel_assigtab.Controls.Add(Me.btn_assign_clear)
        Me.panel_assigtab.Controls.Add(Me.btn_assignserv)
        Me.panel_assigtab.Controls.Add(Me.txtbox_assign_servcost)
        Me.panel_assigtab.Controls.Add(Me.combox_assign_mechid)
        Me.panel_assigtab.Controls.Add(Me.combox_assign_servid)
        Me.panel_assigtab.Controls.Add(Me.combox_assign_regno)
        Me.panel_assigtab.Controls.Add(Me.txtbox_servassignid)
        Me.panel_assigtab.Controls.Add(Me.lbl_assign_servcost)
        Me.panel_assigtab.Controls.Add(Me.lbl_servstatus)
        Me.panel_assigtab.Controls.Add(Me.lbl_servdate)
        Me.panel_assigtab.Controls.Add(Me.lbl_assign_mechanicid)
        Me.panel_assigtab.Controls.Add(Me.lbl_assign_serviceid)
        Me.panel_assigtab.Controls.Add(Me.lbl_assign_regno)
        Me.panel_assigtab.Controls.Add(Me.lbl_servassignid)
        Me.panel_assigtab.Location = New System.Drawing.Point(26, 22)
        Me.panel_assigtab.Name = "panel_assigtab"
        Me.panel_assigtab.Size = New System.Drawing.Size(565, 787)
        Me.panel_assigtab.TabIndex = 0
        '
        'btn_getservcost
        '
        Me.btn_getservcost.Location = New System.Drawing.Point(317, 557)
        Me.btn_getservcost.Name = "btn_getservcost"
        Me.btn_getservcost.Size = New System.Drawing.Size(229, 49)
        Me.btn_getservcost.TabIndex = 17
        Me.btn_getservcost.Text = "Get Service Cost"
        Me.btn_getservcost.UseVisualStyleBackColor = True
        '
        'combox_assign_status
        '
        Me.combox_assign_status.FormattingEnabled = True
        Me.combox_assign_status.Location = New System.Drawing.Point(184, 427)
        Me.combox_assign_status.Name = "combox_assign_status"
        Me.combox_assign_status.Size = New System.Drawing.Size(250, 28)
        Me.combox_assign_status.TabIndex = 16
        '
        'DateTimePicker_assigtab
        '
        Me.DateTimePicker_assigtab.Location = New System.Drawing.Point(184, 348)
        Me.DateTimePicker_assigtab.Name = "DateTimePicker_assigtab"
        Me.DateTimePicker_assigtab.Size = New System.Drawing.Size(250, 26)
        Me.DateTimePicker_assigtab.TabIndex = 1
        '
        'btn_assign_clear
        '
        Me.btn_assign_clear.Location = New System.Drawing.Point(304, 679)
        Me.btn_assign_clear.Name = "btn_assign_clear"
        Me.btn_assign_clear.Size = New System.Drawing.Size(167, 49)
        Me.btn_assign_clear.TabIndex = 15
        Me.btn_assign_clear.Text = "Clear"
        Me.btn_assign_clear.UseVisualStyleBackColor = True
        '
        'btn_assignserv
        '
        Me.btn_assignserv.Location = New System.Drawing.Point(81, 679)
        Me.btn_assignserv.Name = "btn_assignserv"
        Me.btn_assignserv.Size = New System.Drawing.Size(167, 49)
        Me.btn_assignserv.TabIndex = 14
        Me.btn_assignserv.Text = "Assign Service"
        Me.btn_assignserv.UseVisualStyleBackColor = True
        '
        'txtbox_assign_servcost
        '
        Me.txtbox_assign_servcost.Location = New System.Drawing.Point(30, 568)
        Me.txtbox_assign_servcost.Name = "txtbox_assign_servcost"
        Me.txtbox_assign_servcost.ReadOnly = True
        Me.txtbox_assign_servcost.Size = New System.Drawing.Size(250, 26)
        Me.txtbox_assign_servcost.TabIndex = 13
        '
        'combox_assign_mechid
        '
        Me.combox_assign_mechid.FormattingEnabled = True
        Me.combox_assign_mechid.Location = New System.Drawing.Point(184, 269)
        Me.combox_assign_mechid.Name = "combox_assign_mechid"
        Me.combox_assign_mechid.Size = New System.Drawing.Size(250, 28)
        Me.combox_assign_mechid.TabIndex = 10
        '
        'combox_assign_servid
        '
        Me.combox_assign_servid.FormattingEnabled = True
        Me.combox_assign_servid.Location = New System.Drawing.Point(184, 194)
        Me.combox_assign_servid.Name = "combox_assign_servid"
        Me.combox_assign_servid.Size = New System.Drawing.Size(250, 28)
        Me.combox_assign_servid.TabIndex = 9
        '
        'combox_assign_regno
        '
        Me.combox_assign_regno.FormattingEnabled = True
        Me.combox_assign_regno.Location = New System.Drawing.Point(184, 117)
        Me.combox_assign_regno.Name = "combox_assign_regno"
        Me.combox_assign_regno.Size = New System.Drawing.Size(250, 28)
        Me.combox_assign_regno.TabIndex = 8
        '
        'txtbox_servassignid
        '
        Me.txtbox_servassignid.Location = New System.Drawing.Point(188, 44)
        Me.txtbox_servassignid.Name = "txtbox_servassignid"
        Me.txtbox_servassignid.Size = New System.Drawing.Size(250, 26)
        Me.txtbox_servassignid.TabIndex = 7
        '
        'lbl_assign_servcost
        '
        Me.lbl_assign_servcost.AutoSize = True
        Me.lbl_assign_servcost.Location = New System.Drawing.Point(26, 505)
        Me.lbl_assign_servcost.Name = "lbl_assign_servcost"
        Me.lbl_assign_servcost.Size = New System.Drawing.Size(102, 20)
        Me.lbl_assign_servcost.TabIndex = 6
        Me.lbl_assign_servcost.Text = "Service Cost:"
        '
        'lbl_servstatus
        '
        Me.lbl_servstatus.AutoSize = True
        Me.lbl_servstatus.Location = New System.Drawing.Point(26, 430)
        Me.lbl_servstatus.Name = "lbl_servstatus"
        Me.lbl_servstatus.Size = New System.Drawing.Size(60, 20)
        Me.lbl_servstatus.TabIndex = 5
        Me.lbl_servstatus.Text = "Status:"
        '
        'lbl_servdate
        '
        Me.lbl_servdate.AutoSize = True
        Me.lbl_servdate.Location = New System.Drawing.Point(26, 348)
        Me.lbl_servdate.Name = "lbl_servdate"
        Me.lbl_servdate.Size = New System.Drawing.Size(104, 20)
        Me.lbl_servdate.TabIndex = 4
        Me.lbl_servdate.Text = "Service Date:"
        '
        'lbl_assign_mechanicid
        '
        Me.lbl_assign_mechanicid.AutoSize = True
        Me.lbl_assign_mechanicid.Location = New System.Drawing.Point(26, 269)
        Me.lbl_assign_mechanicid.Name = "lbl_assign_mechanicid"
        Me.lbl_assign_mechanicid.Size = New System.Drawing.Size(102, 20)
        Me.lbl_assign_mechanicid.TabIndex = 3
        Me.lbl_assign_mechanicid.Text = "Mechanic ID:"
        '
        'lbl_assign_serviceid
        '
        Me.lbl_assign_serviceid.AutoSize = True
        Me.lbl_assign_serviceid.Location = New System.Drawing.Point(26, 194)
        Me.lbl_assign_serviceid.Name = "lbl_assign_serviceid"
        Me.lbl_assign_serviceid.Size = New System.Drawing.Size(86, 20)
        Me.lbl_assign_serviceid.TabIndex = 2
        Me.lbl_assign_serviceid.Text = "Service ID:"
        '
        'lbl_assign_regno
        '
        Me.lbl_assign_regno.AutoSize = True
        Me.lbl_assign_regno.Location = New System.Drawing.Point(26, 117)
        Me.lbl_assign_regno.Name = "lbl_assign_regno"
        Me.lbl_assign_regno.Size = New System.Drawing.Size(123, 20)
        Me.lbl_assign_regno.TabIndex = 1
        Me.lbl_assign_regno.Text = "Registration No:"
        '
        'lbl_servassignid
        '
        Me.lbl_servassignid.AutoSize = True
        Me.lbl_servassignid.Location = New System.Drawing.Point(8, 44)
        Me.lbl_servassignid.Name = "lbl_servassignid"
        Me.lbl_servassignid.Size = New System.Drawing.Size(174, 20)
        Me.lbl_servassignid.TabIndex = 0
        Me.lbl_servassignid.Text = "Service Assignment ID:"
        '
        'TabPage_Bills
        '
        Me.TabPage_Bills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage_Bills.Controls.Add(Me.btn_bills_deleterow)
        Me.TabPage_Bills.Controls.Add(Me.btn_bills_editrow)
        Me.TabPage_Bills.Controls.Add(Me.btn_bills_viewdetails)
        Me.TabPage_Bills.Controls.Add(Me.dgv_billstab)
        Me.TabPage_Bills.Controls.Add(Me.panel_billstab)
        Me.TabPage_Bills.Location = New System.Drawing.Point(4, 59)
        Me.TabPage_Bills.Name = "TabPage_Bills"
        Me.TabPage_Bills.Size = New System.Drawing.Size(1785, 875)
        Me.TabPage_Bills.TabIndex = 4
        Me.TabPage_Bills.Text = "Billing"
        Me.TabPage_Bills.UseVisualStyleBackColor = True
        '
        'btn_bills_deleterow
        '
        Me.btn_bills_deleterow.Location = New System.Drawing.Point(1426, 703)
        Me.btn_bills_deleterow.Name = "btn_bills_deleterow"
        Me.btn_bills_deleterow.Size = New System.Drawing.Size(167, 49)
        Me.btn_bills_deleterow.TabIndex = 18
        Me.btn_bills_deleterow.Text = "Delete Row"
        Me.btn_bills_deleterow.UseVisualStyleBackColor = True
        '
        'btn_bills_editrow
        '
        Me.btn_bills_editrow.Location = New System.Drawing.Point(1152, 703)
        Me.btn_bills_editrow.Name = "btn_bills_editrow"
        Me.btn_bills_editrow.Size = New System.Drawing.Size(167, 49)
        Me.btn_bills_editrow.TabIndex = 17
        Me.btn_bills_editrow.Text = "Edit Row"
        Me.btn_bills_editrow.UseVisualStyleBackColor = True
        '
        'btn_bills_viewdetails
        '
        Me.btn_bills_viewdetails.Location = New System.Drawing.Point(876, 703)
        Me.btn_bills_viewdetails.Name = "btn_bills_viewdetails"
        Me.btn_bills_viewdetails.Size = New System.Drawing.Size(167, 49)
        Me.btn_bills_viewdetails.TabIndex = 16
        Me.btn_bills_viewdetails.Text = "View Details"
        Me.btn_bills_viewdetails.UseVisualStyleBackColor = True
        '
        'dgv_billstab
        '
        Me.dgv_billstab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_billstab.Location = New System.Drawing.Point(636, 22)
        Me.dgv_billstab.Name = "dgv_billstab"
        Me.dgv_billstab.RowHeadersWidth = 62
        Me.dgv_billstab.RowTemplate.Height = 28
        Me.dgv_billstab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_billstab.Size = New System.Drawing.Size(1105, 602)
        Me.dgv_billstab.TabIndex = 3
        '
        'panel_billstab
        '
        Me.panel_billstab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_billstab.Controls.Add(Me.btn_gen_invoice)
        Me.panel_billstab.Controls.Add(Me.btn_bills_clear)
        Me.panel_billstab.Controls.Add(Me.btn_addbill)
        Me.panel_billstab.Controls.Add(Me.combox_bills_status)
        Me.panel_billstab.Controls.Add(Me.combox_paymode)
        Me.panel_billstab.Controls.Add(Me.btn_totalamt)
        Me.panel_billstab.Controls.Add(Me.txtbox_totalamt)
        Me.panel_billstab.Controls.Add(Me.DateTimePicker_billstab)
        Me.panel_billstab.Controls.Add(Me.combox_bills_regno)
        Me.panel_billstab.Controls.Add(Me.txtbox_billid)
        Me.panel_billstab.Controls.Add(Me.lbl_bills_status)
        Me.panel_billstab.Controls.Add(Me.lbl_paymode)
        Me.panel_billstab.Controls.Add(Me.lbl_totalamt)
        Me.panel_billstab.Controls.Add(Me.lbl_billdate)
        Me.panel_billstab.Controls.Add(Me.lbl_bills_regno)
        Me.panel_billstab.Controls.Add(Me.lbl_billid)
        Me.panel_billstab.Location = New System.Drawing.Point(26, 22)
        Me.panel_billstab.Name = "panel_billstab"
        Me.panel_billstab.Size = New System.Drawing.Size(565, 787)
        Me.panel_billstab.TabIndex = 0
        '
        'btn_gen_invoice
        '
        Me.btn_gen_invoice.Location = New System.Drawing.Point(156, 696)
        Me.btn_gen_invoice.Name = "btn_gen_invoice"
        Me.btn_gen_invoice.Size = New System.Drawing.Size(212, 49)
        Me.btn_gen_invoice.TabIndex = 24
        Me.btn_gen_invoice.Text = "Generate Invoice"
        Me.btn_gen_invoice.UseVisualStyleBackColor = True
        '
        'btn_bills_clear
        '
        Me.btn_bills_clear.Location = New System.Drawing.Point(289, 608)
        Me.btn_bills_clear.Name = "btn_bills_clear"
        Me.btn_bills_clear.Size = New System.Drawing.Size(167, 49)
        Me.btn_bills_clear.TabIndex = 23
        Me.btn_bills_clear.Text = "Clear"
        Me.btn_bills_clear.UseVisualStyleBackColor = True
        '
        'btn_addbill
        '
        Me.btn_addbill.Location = New System.Drawing.Point(66, 608)
        Me.btn_addbill.Name = "btn_addbill"
        Me.btn_addbill.Size = New System.Drawing.Size(167, 49)
        Me.btn_addbill.TabIndex = 22
        Me.btn_addbill.Text = "Add Bill"
        Me.btn_addbill.UseVisualStyleBackColor = True
        '
        'combox_bills_status
        '
        Me.combox_bills_status.FormattingEnabled = True
        Me.combox_bills_status.Location = New System.Drawing.Point(184, 503)
        Me.combox_bills_status.Name = "combox_bills_status"
        Me.combox_bills_status.Size = New System.Drawing.Size(251, 28)
        Me.combox_bills_status.TabIndex = 21
        '
        'combox_paymode
        '
        Me.combox_paymode.FormattingEnabled = True
        Me.combox_paymode.Location = New System.Drawing.Point(184, 429)
        Me.combox_paymode.Name = "combox_paymode"
        Me.combox_paymode.Size = New System.Drawing.Size(251, 28)
        Me.combox_paymode.TabIndex = 20
        '
        'btn_totalamt
        '
        Me.btn_totalamt.Location = New System.Drawing.Point(317, 317)
        Me.btn_totalamt.Name = "btn_totalamt"
        Me.btn_totalamt.Size = New System.Drawing.Size(229, 49)
        Me.btn_totalamt.TabIndex = 19
        Me.btn_totalamt.Text = "Calculate"
        Me.btn_totalamt.UseVisualStyleBackColor = True
        '
        'txtbox_totalamt
        '
        Me.txtbox_totalamt.Location = New System.Drawing.Point(30, 328)
        Me.txtbox_totalamt.Name = "txtbox_totalamt"
        Me.txtbox_totalamt.ReadOnly = True
        Me.txtbox_totalamt.Size = New System.Drawing.Size(250, 26)
        Me.txtbox_totalamt.TabIndex = 18
        '
        'DateTimePicker_billstab
        '
        Me.DateTimePicker_billstab.Location = New System.Drawing.Point(184, 184)
        Me.DateTimePicker_billstab.Name = "DateTimePicker_billstab"
        Me.DateTimePicker_billstab.Size = New System.Drawing.Size(251, 26)
        Me.DateTimePicker_billstab.TabIndex = 8
        '
        'combox_bills_regno
        '
        Me.combox_bills_regno.FormattingEnabled = True
        Me.combox_bills_regno.Location = New System.Drawing.Point(184, 113)
        Me.combox_bills_regno.Name = "combox_bills_regno"
        Me.combox_bills_regno.Size = New System.Drawing.Size(251, 28)
        Me.combox_bills_regno.TabIndex = 7
        '
        'txtbox_billid
        '
        Me.txtbox_billid.Location = New System.Drawing.Point(184, 44)
        Me.txtbox_billid.Name = "txtbox_billid"
        Me.txtbox_billid.Size = New System.Drawing.Size(251, 26)
        Me.txtbox_billid.TabIndex = 6
        '
        'lbl_bills_status
        '
        Me.lbl_bills_status.AutoSize = True
        Me.lbl_bills_status.Location = New System.Drawing.Point(26, 503)
        Me.lbl_bills_status.Name = "lbl_bills_status"
        Me.lbl_bills_status.Size = New System.Drawing.Size(60, 20)
        Me.lbl_bills_status.TabIndex = 5
        Me.lbl_bills_status.Text = "Status:"
        '
        'lbl_paymode
        '
        Me.lbl_paymode.AutoSize = True
        Me.lbl_paymode.Location = New System.Drawing.Point(26, 429)
        Me.lbl_paymode.Name = "lbl_paymode"
        Me.lbl_paymode.Size = New System.Drawing.Size(119, 20)
        Me.lbl_paymode.TabIndex = 4
        Me.lbl_paymode.Text = "Payment Mode:"
        '
        'lbl_totalamt
        '
        Me.lbl_totalamt.AutoSize = True
        Me.lbl_totalamt.Location = New System.Drawing.Point(26, 258)
        Me.lbl_totalamt.Name = "lbl_totalamt"
        Me.lbl_totalamt.Size = New System.Drawing.Size(108, 20)
        Me.lbl_totalamt.TabIndex = 3
        Me.lbl_totalamt.Text = "Total Amount:"
        '
        'lbl_billdate
        '
        Me.lbl_billdate.AutoSize = True
        Me.lbl_billdate.Location = New System.Drawing.Point(26, 184)
        Me.lbl_billdate.Name = "lbl_billdate"
        Me.lbl_billdate.Size = New System.Drawing.Size(72, 20)
        Me.lbl_billdate.TabIndex = 2
        Me.lbl_billdate.Text = "Bill Date:"
        '
        'lbl_bills_regno
        '
        Me.lbl_bills_regno.AutoSize = True
        Me.lbl_bills_regno.Location = New System.Drawing.Point(26, 113)
        Me.lbl_bills_regno.Name = "lbl_bills_regno"
        Me.lbl_bills_regno.Size = New System.Drawing.Size(123, 20)
        Me.lbl_bills_regno.TabIndex = 1
        Me.lbl_bills_regno.Text = "Registration No:"
        '
        'lbl_billid
        '
        Me.lbl_billid.AutoSize = True
        Me.lbl_billid.Location = New System.Drawing.Point(26, 44)
        Me.lbl_billid.Name = "lbl_billid"
        Me.lbl_billid.Size = New System.Drawing.Size(54, 20)
        Me.lbl_billid.TabIndex = 0
        Me.lbl_billid.Text = "Bill ID:"
        '
        'form_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.tabcontrol_dashboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "form_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSL Dashboard"
        Me.tabcontrol_dashboard.ResumeLayout(False)
        Me.TabPage_Reg.ResumeLayout(False)
        CType(Me.dgv_regtab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_regtab.ResumeLayout(False)
        Me.panel_regtab.PerformLayout()
        Me.TabPage_Serv.ResumeLayout(False)
        CType(Me.dgv_servtab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_servtab.ResumeLayout(False)
        Me.panel_servtab.PerformLayout()
        Me.TabPage_Mech.ResumeLayout(False)
        CType(Me.dgv_mechtab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_mechtab.ResumeLayout(False)
        Me.panel_mechtab.PerformLayout()
        Me.TabPage_Assig.ResumeLayout(False)
        CType(Me.dgv_servassigntab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_assigtab.ResumeLayout(False)
        Me.panel_assigtab.PerformLayout()
        Me.TabPage_Bills.ResumeLayout(False)
        CType(Me.dgv_billstab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_billstab.ResumeLayout(False)
        Me.panel_billstab.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabcontrol_dashboard As TabControl
    Friend WithEvents TabPage_Reg As TabPage
    Friend WithEvents TabPage_Serv As TabPage
    Friend WithEvents TabPage_Mech As TabPage
    Friend WithEvents TabPage_Assig As TabPage
    Friend WithEvents TabPage_Bills As TabPage
    Friend WithEvents panel_regtab As Panel
    Friend WithEvents txtbox_phoneno As TextBox
    Friend WithEvents txtbox_custname As TextBox
    Friend WithEvents txtbox_regno As TextBox
    Friend WithEvents lbl_yearofmfd As Label
    Friend WithEvents lbl_model As Label
    Friend WithEvents lbl_make As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_address As Label
    Friend WithEvents lbl_phoneno As Label
    Friend WithEvents lbl_custname As Label
    Friend WithEvents lbl_regno As Label
    Friend WithEvents btn_reg_clear As Button
    Friend WithEvents btn_register As Button
    Friend WithEvents txtbox_yearofmfd As TextBox
    Friend WithEvents txtbox_model As TextBox
    Friend WithEvents txtbox_make As TextBox
    Friend WithEvents txtbox_email As TextBox
    Friend WithEvents txtbox_address As TextBox
    Friend WithEvents dgv_regtab As DataGridView
    Friend WithEvents btn_reg_deleterow As Button
    Friend WithEvents btn_reg_viewdetails As Button
    Friend WithEvents btn_reg_editrow As Button
    Friend WithEvents panel_servtab As Panel
    Friend WithEvents lbl_servcost As Label
    Friend WithEvents lbl_servname As Label
    Friend WithEvents lbl_serviceid As Label
    Friend WithEvents btn_serv_clear As Button
    Friend WithEvents btn_addservice As Button
    Friend WithEvents txtbox_servcost As TextBox
    Friend WithEvents txtbox_servname As TextBox
    Friend WithEvents txtbox_serviceid As TextBox
    Friend WithEvents dgv_servtab As DataGridView
    Friend WithEvents btn_serv_deleterow As Button
    Friend WithEvents btn_serv_editrow As Button
    Friend WithEvents btn_serv_viewdetails As Button
    Friend WithEvents panel_mechtab As Panel
    Friend WithEvents lbl_expertise As Label
    Friend WithEvents lbl_mech_phoneno As Label
    Friend WithEvents lbl_mechname As Label
    Friend WithEvents lbl_mechanicid As Label
    Friend WithEvents txtbox_mechanicid As TextBox
    Friend WithEvents txtbox_expertise As TextBox
    Friend WithEvents txtbox_mech_phoneno As TextBox
    Friend WithEvents txtbox_mechname As TextBox
    Friend WithEvents dgv_mechtab As DataGridView
    Friend WithEvents btn_mech_clear As Button
    Friend WithEvents btn_addmechanic As Button
    Friend WithEvents btn_mech_deleterow As Button
    Friend WithEvents btn_mech_editrow As Button
    Friend WithEvents btn_mech_viewdetails As Button
    Friend WithEvents panel_assigtab As Panel
    Friend WithEvents lbl_servdate As Label
    Friend WithEvents lbl_assign_mechanicid As Label
    Friend WithEvents lbl_assign_serviceid As Label
    Friend WithEvents lbl_assign_regno As Label
    Friend WithEvents lbl_servassignid As Label
    Friend WithEvents btn_assign_clear As Button
    Friend WithEvents btn_assignserv As Button
    Friend WithEvents txtbox_assign_servcost As TextBox
    Friend WithEvents combox_assign_mechid As ComboBox
    Friend WithEvents combox_assign_servid As ComboBox
    Friend WithEvents combox_assign_regno As ComboBox
    Friend WithEvents txtbox_servassignid As TextBox
    Friend WithEvents lbl_assign_servcost As Label
    Friend WithEvents lbl_servstatus As Label
    Friend WithEvents DateTimePicker_assigtab As DateTimePicker
    Friend WithEvents btn_getservcost As Button
    Friend WithEvents combox_assign_status As ComboBox
    Friend WithEvents dgv_servassigntab As DataGridView
    Friend WithEvents btn_assign_deleterow As Button
    Friend WithEvents btn_assign_editrow As Button
    Friend WithEvents btn_assign_viewdetails As Button
    Friend WithEvents panel_billstab As Panel
    Friend WithEvents lbl_totalamt As Label
    Friend WithEvents lbl_billdate As Label
    Friend WithEvents lbl_bills_regno As Label
    Friend WithEvents lbl_billid As Label
    Friend WithEvents combox_bills_status As ComboBox
    Friend WithEvents combox_paymode As ComboBox
    Friend WithEvents btn_totalamt As Button
    Friend WithEvents txtbox_totalamt As TextBox
    Friend WithEvents DateTimePicker_billstab As DateTimePicker
    Friend WithEvents combox_bills_regno As ComboBox
    Friend WithEvents txtbox_billid As TextBox
    Friend WithEvents lbl_bills_status As Label
    Friend WithEvents lbl_paymode As Label
    Friend WithEvents btn_gen_invoice As Button
    Friend WithEvents btn_bills_clear As Button
    Friend WithEvents btn_addbill As Button
    Friend WithEvents dgv_billstab As DataGridView
    Friend WithEvents btn_bills_deleterow As Button
    Friend WithEvents btn_bills_editrow As Button
    Friend WithEvents btn_bills_viewdetails As Button
End Class
