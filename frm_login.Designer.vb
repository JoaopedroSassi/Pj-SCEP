<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pic_minimize = New System.Windows.Forms.PictureBox()
        Me.pic_close = New System.Windows.Forms.PictureBox()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(35, 440)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(321, 43)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.pic_minimize)
        Me.Panel1.Controls.Add(Me.pic_close)
        Me.Panel1.Controls.Add(Me.pic_logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(385, 161)
        Me.Panel1.TabIndex = 5
        '
        'pic_minimize
        '
        Me.pic_minimize.BackColor = System.Drawing.Color.Transparent
        Me.pic_minimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_minimize.Image = CType(resources.GetObject("pic_minimize.Image"), System.Drawing.Image)
        Me.pic_minimize.Location = New System.Drawing.Point(329, 0)
        Me.pic_minimize.Name = "pic_minimize"
        Me.pic_minimize.Size = New System.Drawing.Size(26, 26)
        Me.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_minimize.TabIndex = 2
        Me.pic_minimize.TabStop = False
        '
        'pic_close
        '
        Me.pic_close.BackColor = System.Drawing.Color.Transparent
        Me.pic_close.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_close.Cursor = System.Windows.Forms.Cursors.Default
        Me.pic_close.Image = CType(resources.GetObject("pic_close.Image"), System.Drawing.Image)
        Me.pic_close.Location = New System.Drawing.Point(356, 0)
        Me.pic_close.Name = "pic_close"
        Me.pic_close.Size = New System.Drawing.Size(26, 26)
        Me.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_close.TabIndex = 1
        Me.pic_close.TabStop = False
        '
        'pic_logo
        '
        Me.pic_logo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_logo.BackColor = System.Drawing.Color.Transparent
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(67, 0)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Padding = New System.Windows.Forms.Padding(10)
        Me.pic_logo.Size = New System.Drawing.Size(256, 174)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic_logo.TabIndex = 0
        Me.pic_logo.TabStop = False
        '
        'txt_email
        '
        Me.txt_email.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.8!)
        Me.txt_email.Location = New System.Drawing.Point(36, 257)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(321, 23)
        Me.txt_email.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(150, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 29)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Login"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Location = New System.Drawing.Point(0, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(315, 1)
        Me.Panel4.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(0, 76)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(315, 1)
        Me.Panel6.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel7.Location = New System.Drawing.Point(0, 87)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(315, 1)
        Me.Panel7.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Location = New System.Drawing.Point(0, 119)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(315, 0)
        Me.Panel3.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Location = New System.Drawing.Point(0, 76)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(315, 1)
        Me.Panel5.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel8.Location = New System.Drawing.Point(0, 87)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(315, 1)
        Me.Panel8.TabIndex = 7
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel9.Location = New System.Drawing.Point(0, 87)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(315, 1)
        Me.Panel9.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(36, 295)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 1)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Senha"
        '
        'txt_password
        '
        Me.txt_password.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_password.BackColor = System.Drawing.Color.White
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.8!)
        Me.txt_password.Location = New System.Drawing.Point(35, 357)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_password.Size = New System.Drawing.Size(321, 23)
        Me.txt_password.TabIndex = 2
        '
        'Panel18
        '
        Me.Panel18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Panel18.Controls.Add(Me.Panel19)
        Me.Panel18.Controls.Add(Me.Panel23)
        Me.Panel18.Controls.Add(Me.Panel25)
        Me.Panel18.Location = New System.Drawing.Point(35, 395)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(321, 1)
        Me.Panel18.TabIndex = 17
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Controls.Add(Me.Panel22)
        Me.Panel19.Location = New System.Drawing.Point(0, 119)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(315, 0)
        Me.Panel19.TabIndex = 9
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel20.Controls.Add(Me.Panel21)
        Me.Panel20.Location = New System.Drawing.Point(0, 76)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(315, 1)
        Me.Panel20.TabIndex = 8
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel21.Location = New System.Drawing.Point(0, 87)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(315, 1)
        Me.Panel21.TabIndex = 7
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel22.Location = New System.Drawing.Point(0, 87)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(315, 1)
        Me.Panel22.TabIndex = 7
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Location = New System.Drawing.Point(0, 76)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(315, 1)
        Me.Panel23.TabIndex = 8
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel24.Location = New System.Drawing.Point(0, 87)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(315, 1)
        Me.Panel24.TabIndex = 7
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel25.Location = New System.Drawing.Point(0, 87)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(315, 1)
        Me.Panel25.TabIndex = 7
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(385, 501)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_login"
        Me.Text = "frm_login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_login As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents txt_email As Windows.Forms.TextBox
    Friend WithEvents pic_logo As Windows.Forms.PictureBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents pic_close As Windows.Forms.PictureBox
    Friend WithEvents Panel4 As Windows.Forms.Panel
    Friend WithEvents Panel6 As Windows.Forms.Panel
    Friend WithEvents Panel7 As Windows.Forms.Panel
    Friend WithEvents Panel3 As Windows.Forms.Panel
    Friend WithEvents Panel5 As Windows.Forms.Panel
    Friend WithEvents Panel8 As Windows.Forms.Panel
    Friend WithEvents Panel9 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txt_password As Windows.Forms.TextBox
    Friend WithEvents Panel18 As Windows.Forms.Panel
    Friend WithEvents Panel19 As Windows.Forms.Panel
    Friend WithEvents Panel20 As Windows.Forms.Panel
    Friend WithEvents Panel21 As Windows.Forms.Panel
    Friend WithEvents Panel22 As Windows.Forms.Panel
    Friend WithEvents Panel23 As Windows.Forms.Panel
    Friend WithEvents Panel24 As Windows.Forms.Panel
    Friend WithEvents Panel25 As Windows.Forms.Panel
    Friend WithEvents pic_minimize As Windows.Forms.PictureBox
End Class
