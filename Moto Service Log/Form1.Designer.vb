<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Login))
        Me.lbl_uname = New System.Windows.Forms.Label()
        Me.lbl_pword = New System.Windows.Forms.Label()
        Me.txtbox_uname = New System.Windows.Forms.TextBox()
        Me.txtbox_pword = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_uname
        '
        Me.lbl_uname.AutoSize = True
        Me.lbl_uname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_uname.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_uname.ForeColor = System.Drawing.Color.White
        Me.lbl_uname.Location = New System.Drawing.Point(299, 82)
        Me.lbl_uname.Name = "lbl_uname"
        Me.lbl_uname.Size = New System.Drawing.Size(154, 29)
        Me.lbl_uname.TabIndex = 0
        Me.lbl_uname.Text = "Username:"
        '
        'lbl_pword
        '
        Me.lbl_pword.AutoSize = True
        Me.lbl_pword.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pword.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pword.ForeColor = System.Drawing.Color.White
        Me.lbl_pword.Location = New System.Drawing.Point(299, 211)
        Me.lbl_pword.Name = "lbl_pword"
        Me.lbl_pword.Size = New System.Drawing.Size(147, 29)
        Me.lbl_pword.TabIndex = 1
        Me.lbl_pword.Text = "Password:"
        '
        'txtbox_uname
        '
        Me.txtbox_uname.BackColor = System.Drawing.Color.MistyRose
        Me.txtbox_uname.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_uname.Location = New System.Drawing.Point(303, 126)
        Me.txtbox_uname.Multiline = True
        Me.txtbox_uname.Name = "txtbox_uname"
        Me.txtbox_uname.Size = New System.Drawing.Size(262, 41)
        Me.txtbox_uname.TabIndex = 2
        '
        'txtbox_pword
        '
        Me.txtbox_pword.BackColor = System.Drawing.Color.MistyRose
        Me.txtbox_pword.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_pword.Location = New System.Drawing.Point(303, 268)
        Me.txtbox_pword.Multiline = True
        Me.txtbox_pword.Name = "txtbox_pword"
        Me.txtbox_pword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_pword.Size = New System.Drawing.Size(262, 41)
        Me.txtbox_pword.TabIndex = 3
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.MistyRose
        Me.btn_login.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(222, 390)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(164, 56)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.MistyRose
        Me.btn_clear.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Location = New System.Drawing.Point(472, 390)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(164, 56)
        Me.btn_clear.TabIndex = 5
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(45, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(878, 544)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txtbox_pword)
        Me.Controls.Add(Me.txtbox_uname)
        Me.Controls.Add(Me.lbl_pword)
        Me.Controls.Add(Me.lbl_uname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSL Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_uname As Label
    Friend WithEvents lbl_pword As Label
    Friend WithEvents txtbox_uname As TextBox
    Friend WithEvents txtbox_pword As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
