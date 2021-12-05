<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_crud_seller
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_crud_seller))
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_last_name = New System.Windows.Forms.TextBox()
        Me.btn_search_id = New FontAwesome.Sharp.IconPictureBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_search_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_first_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.dgv_sell = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_search_id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_sell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_delete.FlatAppearance.BorderSize = 2
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_delete.Location = New System.Drawing.Point(395, 434)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(134, 27)
        Me.btn_delete.TabIndex = 10
        Me.btn_delete.Text = "Deletar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_edit.FlatAppearance.BorderSize = 2
        Me.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Location = New System.Drawing.Point(41, 434)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(134, 27)
        Me.btn_edit.TabIndex = 9
        Me.btn_edit.Text = "Editar"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txt_cpf)
        Me.Panel1.Controls.Add(Me.cmb_status)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txt_pass)
        Me.Panel1.Controls.Add(Me.lbl_email)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_last_name)
        Me.Panel1.Controls.Add(Me.btn_search_id)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txt_search_id)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_first_name)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_id)
        Me.Panel1.Location = New System.Drawing.Point(562, -10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 542)
        Me.Panel1.TabIndex = 8
        '
        'cmb_status
        '
        Me.cmb_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"Ativo", "Desativado"})
        Me.cmb_status.Location = New System.Drawing.Point(113, 255)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(193, 21)
        Me.cmb_status.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(17, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(17, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Senha:"
        '
        'txt_pass
        '
        Me.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pass.Location = New System.Drawing.Point(113, 225)
        Me.txt_pass.Multiline = True
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_pass.Size = New System.Drawing.Size(193, 21)
        Me.txt_pass.TabIndex = 5
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.White
        Me.lbl_email.Location = New System.Drawing.Point(17, 199)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(52, 20)
        Me.lbl_email.TabIndex = 24
        Me.lbl_email.Text = "Email:"
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Location = New System.Drawing.Point(113, 198)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(193, 21)
        Me.txt_email.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(17, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Cpf:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Sobrenome:"
        '
        'txt_last_name
        '
        Me.txt_last_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_last_name.Location = New System.Drawing.Point(113, 171)
        Me.txt_last_name.Multiline = True
        Me.txt_last_name.Name = "txt_last_name"
        Me.txt_last_name.Size = New System.Drawing.Size(193, 21)
        Me.txt_last_name.TabIndex = 3
        '
        'btn_search_id
        '
        Me.btn_search_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_search_id.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btn_search_id.IconColor = System.Drawing.Color.White
        Me.btn_search_id.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_search_id.IconSize = 20
        Me.btn_search_id.Location = New System.Drawing.Point(217, 419)
        Me.btn_search_id.Name = "btn_search_id"
        Me.btn_search_id.Size = New System.Drawing.Size(27, 20)
        Me.btn_search_id.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_search_id.TabIndex = 18
        Me.btn_search_id.TabStop = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 2
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(22, 301)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(268, 28)
        Me.btn_save.TabIndex = 7
        Me.btn_save.Text = "Salvar"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(17, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Pesquise por ID:"
        '
        'txt_search_id
        '
        Me.txt_search_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search_id.Location = New System.Drawing.Point(158, 419)
        Me.txt_search_id.Name = "txt_search_id"
        Me.txt_search_id.Size = New System.Drawing.Size(53, 20)
        Me.txt_search_id.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nome:"
        '
        'txt_first_name
        '
        Me.txt_first_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_first_name.Location = New System.Drawing.Point(113, 144)
        Me.txt_first_name.Multiline = True
        Me.txt_first_name.Name = "txt_first_name"
        Me.txt_first_name.Size = New System.Drawing.Size(193, 21)
        Me.txt_first_name.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(124, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Vendedores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID:"
        '
        'txt_id
        '
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.Location = New System.Drawing.Point(113, 90)
        Me.txt_id.Multiline = True
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(54, 21)
        Me.txt_id.TabIndex = 0
        '
        'dgv_sell
        '
        Me.dgv_sell.AllowUserToAddRows = False
        Me.dgv_sell.AllowUserToDeleteRows = False
        Me.dgv_sell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_sell.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_sell.BackgroundColor = System.Drawing.Color.White
        Me.dgv_sell.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_sell.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_sell.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_sell.ColumnHeadersHeight = 25
        Me.dgv_sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_sell.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.name_prod, Me.cat, Me.amount, Me.cost_price})
        Me.dgv_sell.EnableHeadersVisualStyles = False
        Me.dgv_sell.GridColor = System.Drawing.Color.SteelBlue
        Me.dgv_sell.Location = New System.Drawing.Point(2, 98)
        Me.dgv_sell.Name = "dgv_sell"
        Me.dgv_sell.ReadOnly = True
        Me.dgv_sell.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_sell.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_sell.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_sell.Size = New System.Drawing.Size(554, 299)
        Me.dgv_sell.TabIndex = 6
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 41
        '
        'name_prod
        '
        Me.name_prod.HeaderText = "Cpf"
        Me.name_prod.Name = "name_prod"
        Me.name_prod.ReadOnly = True
        Me.name_prod.Width = 50
        '
        'cat
        '
        Me.cat.HeaderText = "Nome"
        Me.cat.Name = "cat"
        Me.cat.ReadOnly = True
        Me.cat.Width = 67
        '
        'amount
        '
        Me.amount.HeaderText = "Email"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        Me.amount.Width = 64
        '
        'cost_price
        '
        Me.cost_price.HeaderText = "Status"
        Me.cost_price.Name = "cost_price"
        Me.cost_price.ReadOnly = True
        Me.cost_price.Width = 67
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Lato", 23.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_date.Location = New System.Drawing.Point(144, 25)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(286, 38)
        Me.lbl_date.TabIndex = 96
        Me.lbl_date.Text = "CRUD | Vendedores"
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cpf.Location = New System.Drawing.Point(113, 117)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(84, 20)
        Me.txt_cpf.TabIndex = 29
        '
        'frm_crud_seller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 472)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_sell)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(896, 511)
        Me.Name = "frm_crud_seller"
        Me.Text = "Crud | Vendedores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_search_id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_sell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_delete As Windows.Forms.Button
    Friend WithEvents btn_edit As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btn_search_id As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btn_save As Windows.Forms.Button
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txt_search_id As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txt_first_name As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txt_id As Windows.Forms.TextBox
    Friend WithEvents dgv_sell As Windows.Forms.DataGridView
    Friend WithEvents Id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_prod As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cat As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cost_price As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txt_last_name As Windows.Forms.TextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents txt_pass As Windows.Forms.TextBox
    Friend WithEvents lbl_email As Windows.Forms.Label
    Friend WithEvents txt_email As Windows.Forms.TextBox
    Friend WithEvents cmb_status As Windows.Forms.ComboBox
    Friend WithEvents lbl_date As Windows.Forms.Label
    Friend WithEvents txt_cpf As Windows.Forms.MaskedTextBox
End Class
