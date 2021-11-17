<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_seller
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_seller))
        Me.pnl_menu = New System.Windows.Forms.Panel()
        Me.btn_logout = New FontAwesome.Sharp.IconButton()
        Me.btn_check_prod = New FontAwesome.Sharp.IconButton()
        Me.btn_check_order = New FontAwesome.Sharp.IconButton()
        Me.btn_make_order = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_content = New System.Windows.Forms.Panel()
        Me.lbl_day = New System.Windows.Forms.Label()
        Me.lbl_wel = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.pnl_menu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_content.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_menu
        '
        Me.pnl_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.pnl_menu.Controls.Add(Me.btn_logout)
        Me.pnl_menu.Controls.Add(Me.btn_check_prod)
        Me.pnl_menu.Controls.Add(Me.btn_check_order)
        Me.pnl_menu.Controls.Add(Me.btn_make_order)
        Me.pnl_menu.Controls.Add(Me.Panel1)
        Me.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_menu.Location = New System.Drawing.Point(0, 0)
        Me.pnl_menu.Name = "pnl_menu"
        Me.pnl_menu.Size = New System.Drawing.Size(205, 555)
        Me.pnl_menu.TabIndex = 0
        '
        'btn_logout
        '
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btn_logout.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_logout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_logout.IconSize = 36
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.Location = New System.Drawing.Point(0, 495)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_logout.Size = New System.Drawing.Size(205, 60)
        Me.btn_logout.TabIndex = 13
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_check_prod
        '
        Me.btn_check_prod.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_check_prod.FlatAppearance.BorderSize = 0
        Me.btn_check_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_check_prod.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_check_prod.IconChar = FontAwesome.Sharp.IconChar.Bed
        Me.btn_check_prod.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_check_prod.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_check_prod.IconSize = 36
        Me.btn_check_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_check_prod.Location = New System.Drawing.Point(0, 266)
        Me.btn_check_prod.Name = "btn_check_prod"
        Me.btn_check_prod.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_check_prod.Size = New System.Drawing.Size(205, 60)
        Me.btn_check_prod.TabIndex = 12
        Me.btn_check_prod.Text = "Checar estoque"
        Me.btn_check_prod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_check_prod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_check_prod.UseVisualStyleBackColor = True
        '
        'btn_check_order
        '
        Me.btn_check_order.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_check_order.FlatAppearance.BorderSize = 0
        Me.btn_check_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_check_order.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_check_order.IconChar = FontAwesome.Sharp.IconChar.FileAlt
        Me.btn_check_order.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_check_order.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_check_order.IconSize = 36
        Me.btn_check_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_check_order.Location = New System.Drawing.Point(0, 206)
        Me.btn_check_order.Name = "btn_check_order"
        Me.btn_check_order.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_check_order.Size = New System.Drawing.Size(205, 60)
        Me.btn_check_order.TabIndex = 11
        Me.btn_check_order.Text = "Checar pedido"
        Me.btn_check_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_check_order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_check_order.UseVisualStyleBackColor = True
        '
        'btn_make_order
        '
        Me.btn_make_order.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_make_order.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_make_order.FlatAppearance.BorderSize = 0
        Me.btn_make_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_make_order.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_make_order.IconChar = FontAwesome.Sharp.IconChar.File
        Me.btn_make_order.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_make_order.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_make_order.IconSize = 36
        Me.btn_make_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_make_order.Location = New System.Drawing.Point(0, 146)
        Me.btn_make_order.Name = "btn_make_order"
        Me.btn_make_order.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_make_order.Size = New System.Drawing.Size(205, 60)
        Me.btn_make_order.TabIndex = 10
        Me.btn_make_order.Text = "Fazer pedido"
        Me.btn_make_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_make_order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_make_order.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pic_logo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 146)
        Me.Panel1.TabIndex = 8
        '
        'pic_logo
        '
        Me.pic_logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(0, 3)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(205, 143)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 0
        Me.pic_logo.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'pnl_content
        '
        Me.pnl_content.Controls.Add(Me.lbl_day)
        Me.pnl_content.Controls.Add(Me.lbl_wel)
        Me.pnl_content.Controls.Add(Me.lbl_date)
        Me.pnl_content.Controls.Add(Me.lbl_time)
        Me.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_content.Location = New System.Drawing.Point(205, 0)
        Me.pnl_content.Name = "pnl_content"
        Me.pnl_content.Size = New System.Drawing.Size(896, 555)
        Me.pnl_content.TabIndex = 2
        '
        'lbl_day
        '
        Me.lbl_day.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_day.AutoSize = True
        Me.lbl_day.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_day.Location = New System.Drawing.Point(413, 172)
        Me.lbl_day.Name = "lbl_day"
        Me.lbl_day.Size = New System.Drawing.Size(45, 25)
        Me.lbl_day.TabIndex = 11
        Me.lbl_day.Text = "day"
        '
        'lbl_wel
        '
        Me.lbl_wel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_wel.AutoSize = True
        Me.lbl_wel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wel.Location = New System.Drawing.Point(123, 113)
        Me.lbl_wel.Name = "lbl_wel"
        Me.lbl_wel.Size = New System.Drawing.Size(32, 20)
        Me.lbl_wel.TabIndex = 10
        Me.lbl_wel.Text = "wel"
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(356, 210)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(84, 43)
        Me.lbl_date.TabIndex = 9
        Me.lbl_date.Text = "date"
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(356, 282)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(84, 43)
        Me.lbl_time.TabIndex = 8
        Me.lbl_time.Text = "time"
        '
        'frm_seller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1101, 555)
        Me.Controls.Add(Me.pnl_content)
        Me.Controls.Add(Me.pnl_menu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1117, 594)
        Me.Name = "frm_seller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendedor"
        Me.pnl_menu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_content.ResumeLayout(False)
        Me.pnl_content.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_menu As Windows.Forms.Panel
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents btn_logout As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_check_prod As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_check_order As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_make_order As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents pic_logo As Windows.Forms.PictureBox
    Friend WithEvents pnl_content As Windows.Forms.Panel
    Friend WithEvents lbl_day As Windows.Forms.Label
    Friend WithEvents lbl_wel As Windows.Forms.Label
    Friend WithEvents lbl_date As Windows.Forms.Label
    Friend WithEvents lbl_time As Windows.Forms.Label
End Class
