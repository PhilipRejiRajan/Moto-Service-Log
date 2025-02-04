<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Login
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
        Me.lbl_uname = New System.Windows.Forms.Label()
        Me.lbl_pword = New System.Windows.Forms.Label()
        Me.txtbox_uname = New System.Windows.Forms.TextBox()
        Me.txtbox_pword = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_uname
        '
        Me.lbl_uname.AutoSize = True
        Me.lbl_uname.Location = New System.Drawing.Point(204, 128)
        Me.lbl_uname.Name = "lbl_uname"
        Me.lbl_uname.Size = New System.Drawing.Size(87, 20)
        Me.lbl_uname.TabIndex = 0
        Me.lbl_uname.Text = "Username:"
        '
        'lbl_pword
        '
        Me.lbl_pword.AutoSize = True
        Me.lbl_pword.Location = New System.Drawing.Point(204, 219)
        Me.lbl_pword.Name = "lbl_pword"
        Me.lbl_pword.Size = New System.Drawing.Size(82, 20)
        Me.lbl_pword.TabIndex = 1
        Me.lbl_pword.Text = "Password:"
        '
        'txtbox_uname
        '
        Me.txtbox_uname.Location = New System.Drawing.Point(374, 128)
        Me.txtbox_uname.Multiline = True
        Me.txtbox_uname.Name = "txtbox_uname"
        Me.txtbox_uname.Size = New System.Drawing.Size(262, 41)
        Me.txtbox_uname.TabIndex = 2
        '
        'txtbox_pword
        '
        Me.txtbox_pword.Location = New System.Drawing.Point(374, 216)
        Me.txtbox_pword.Multiline = True
        Me.txtbox_pword.Name = "txtbox_pword"
        Me.txtbox_pword.Size = New System.Drawing.Size(262, 41)
        Me.txtbox_pword.TabIndex = 3
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(247, 352)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(164, 56)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(452, 352)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(164, 56)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(878, 544)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txtbox_pword)
        Me.Controls.Add(Me.txtbox_uname)
        Me.Controls.Add(Me.lbl_pword)
        Me.Controls.Add(Me.lbl_uname)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSL Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_uname As Label
    Friend WithEvents lbl_pword As Label
    Friend WithEvents txtbox_uname As TextBox
    Friend WithEvents txtbox_pword As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_clear As Button
End Class
