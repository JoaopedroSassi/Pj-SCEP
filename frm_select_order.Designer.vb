<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_select_order
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_select_order))
        Me.dgv_prod_order = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_cell_phone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_landline_phone = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_last_name = New System.Windows.Forms.TextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_first_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_search = New FontAwesome.Sharp.IconButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_block = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_apartment = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_uf = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_street = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_district = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmb_method = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_seller = New System.Windows.Forms.TextBox()
        Me.txt_date = New System.Windows.Forms.TextBox()
        CType(Me.dgv_prod_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_prod_order
        '
        Me.dgv_prod_order.AllowUserToAddRows = False
        Me.dgv_prod_order.AllowUserToDeleteRows = False
        Me.dgv_prod_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_prod_order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_prod_order.BackgroundColor = System.Drawing.Color.White
        Me.dgv_prod_order.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_prod_order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_prod_order.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_prod_order.ColumnHeadersHeight = 25
        Me.dgv_prod_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_prod_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.name_prod, Me.cat, Me.amount, Me.preco})
        Me.dgv_prod_order.EnableHeadersVisualStyles = False
        Me.dgv_prod_order.GridColor = System.Drawing.Color.SteelBlue
        Me.dgv_prod_order.Location = New System.Drawing.Point(391, 209)
        Me.dgv_prod_order.Name = "dgv_prod_order"
        Me.dgv_prod_order.ReadOnly = True
        Me.dgv_prod_order.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_prod_order.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_prod_order.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_prod_order.Size = New System.Drawing.Size(481, 251)
        Me.dgv_prod_order.TabIndex = 55
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
        Me.name_prod.HeaderText = "Nome"
        Me.name_prod.Name = "name_prod"
        Me.name_prod.ReadOnly = True
        Me.name_prod.Width = 67
        '
        'cat
        '
        Me.cat.HeaderText = "Categoria"
        Me.cat.Name = "cat"
        Me.cat.ReadOnly = True
        Me.cat.Width = 89
        '
        'amount
        '
        Me.amount.HeaderText = "Quantidade"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'preco
        '
        Me.preco.HeaderText = "Preço"
        Me.preco.Name = "preco"
        Me.preco.ReadOnly = True
        Me.preco.Width = 66
        '
        'txt_cell_phone
        '
        Me.txt_cell_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cell_phone.Location = New System.Drawing.Point(336, 185)
        Me.txt_cell_phone.Mask = "(99) 99999-9999"
        Me.txt_cell_phone.Name = "txt_cell_phone"
        Me.txt_cell_phone.ReadOnly = True
        Me.txt_cell_phone.Size = New System.Drawing.Size(89, 20)
        Me.txt_cell_phone.TabIndex = 62
        '
        'txt_landline_phone
        '
        Me.txt_landline_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_landline_phone.Location = New System.Drawing.Point(226, 185)
        Me.txt_landline_phone.Mask = "(99) 9999-9999"
        Me.txt_landline_phone.Name = "txt_landline_phone"
        Me.txt_landline_phone.ReadOnly = True
        Me.txt_landline_phone.Size = New System.Drawing.Size(83, 20)
        Me.txt_landline_phone.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(333, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Telefone celular"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(223, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Telefone residencial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(11, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Email"
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Location = New System.Drawing.Point(14, 185)
        Me.txt_email.Multiline = True
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = True
        Me.txt_email.Size = New System.Drawing.Size(198, 20)
        Me.txt_email.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(248, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Sobrenome"
        '
        'txt_last_name
        '
        Me.txt_last_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_last_name.Location = New System.Drawing.Point(251, 136)
        Me.txt_last_name.Multiline = True
        Me.txt_last_name.Name = "txt_last_name"
        Me.txt_last_name.ReadOnly = True
        Me.txt_last_name.Size = New System.Drawing.Size(134, 20)
        Me.txt_last_name.TabIndex = 58
        '
        'txt_cpf
        '
        Me.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cpf.Location = New System.Drawing.Point(14, 136)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.ReadOnly = True
        Me.txt_cpf.Size = New System.Drawing.Size(89, 20)
        Me.txt_cpf.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(106, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Nome"
        '
        'txt_first_name
        '
        Me.txt_first_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_first_name.Location = New System.Drawing.Point(109, 136)
        Me.txt_first_name.Multiline = True
        Me.txt_first_name.Name = "txt_first_name"
        Me.txt_first_name.ReadOnly = True
        Me.txt_first_name.Size = New System.Drawing.Size(136, 20)
        Me.txt_first_name.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(11, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Cpf"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.btn_search)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txt_search)
        Me.Panel1.Location = New System.Drawing.Point(27, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 32)
        Me.Panel1.TabIndex = 69
        '
        'btn_search
        '
        Me.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btn_search.IconColor = System.Drawing.Color.White
        Me.btn_search.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_search.IconSize = 26
        Me.btn_search.Location = New System.Drawing.Point(224, 3)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(47, 26)
        Me.btn_search.TabIndex = 93
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(13, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Pesquisa:"
        '
        'txt_search
        '
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Location = New System.Drawing.Point(97, 6)
        Me.txt_search.Multiline = True
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(129, 20)
        Me.txt_search.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Location = New System.Drawing.Point(82, 351)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Bloco"
        '
        'txt_block
        '
        Me.txt_block.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_block.Location = New System.Drawing.Point(85, 367)
        Me.txt_block.Multiline = True
        Me.txt_block.Name = "txt_block"
        Me.txt_block.ReadOnly = True
        Me.txt_block.Size = New System.Drawing.Size(64, 20)
        Me.txt_block.TabIndex = 73
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Location = New System.Drawing.Point(12, 351)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 79
        Me.Label13.Text = "Apartamento"
        '
        'txt_apartment
        '
        Me.txt_apartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apartment.Location = New System.Drawing.Point(15, 367)
        Me.txt_apartment.Multiline = True
        Me.txt_apartment.Name = "txt_apartment"
        Me.txt_apartment.ReadOnly = True
        Me.txt_apartment.Size = New System.Drawing.Size(64, 20)
        Me.txt_apartment.TabIndex = 72
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Location = New System.Drawing.Point(248, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Número"
        '
        'txt_number
        '
        Me.txt_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_number.Location = New System.Drawing.Point(251, 315)
        Me.txt_number.Multiline = True
        Me.txt_number.Name = "txt_number"
        Me.txt_number.ReadOnly = True
        Me.txt_number.Size = New System.Drawing.Size(83, 20)
        Me.txt_number.TabIndex = 71
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Location = New System.Drawing.Point(206, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "UF"
        '
        'txt_uf
        '
        Me.txt_uf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_uf.Location = New System.Drawing.Point(209, 315)
        Me.txt_uf.Multiline = True
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.ReadOnly = True
        Me.txt_uf.Size = New System.Drawing.Size(36, 20)
        Me.txt_uf.TabIndex = 84
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Location = New System.Drawing.Point(11, 299)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Rua"
        '
        'txt_street
        '
        Me.txt_street.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_street.Location = New System.Drawing.Point(14, 315)
        Me.txt_street.Multiline = True
        Me.txt_street.Name = "txt_street"
        Me.txt_street.ReadOnly = True
        Me.txt_street.Size = New System.Drawing.Size(188, 20)
        Me.txt_street.TabIndex = 83
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(224, 252)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Bairro"
        '
        'txt_district
        '
        Me.txt_district.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_district.Location = New System.Drawing.Point(227, 268)
        Me.txt_district.Multiline = True
        Me.txt_district.Name = "txt_district"
        Me.txt_district.ReadOnly = True
        Me.txt_district.Size = New System.Drawing.Size(136, 20)
        Me.txt_district.TabIndex = 82
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Location = New System.Drawing.Point(82, 252)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Cidade"
        '
        'txt_city
        '
        Me.txt_city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_city.Location = New System.Drawing.Point(85, 268)
        Me.txt_city.Multiline = True
        Me.txt_city.Name = "txt_city"
        Me.txt_city.ReadOnly = True
        Me.txt_city.Size = New System.Drawing.Size(136, 20)
        Me.txt_city.TabIndex = 81
        '
        'txt_cep
        '
        Me.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cep.Location = New System.Drawing.Point(12, 268)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.ReadOnly = True
        Me.txt_cep.Size = New System.Drawing.Size(67, 20)
        Me.txt_cep.TabIndex = 70
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Location = New System.Drawing.Point(9, 252)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 85
        Me.Label16.Text = "Cep"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Location = New System.Drawing.Point(659, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(114, 13)
        Me.Label17.TabIndex = 87
        Me.Label17.Text = "Método de pagamento"
        '
        'cmb_method
        '
        Me.cmb_method.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_method.FormattingEnabled = True
        Me.cmb_method.Items.AddRange(New Object() {"Boleto", "Cartão de Crédito", "Cartão de Débito", "Dinheiro", "PIX"})
        Me.cmb_method.Location = New System.Drawing.Point(661, 41)
        Me.cmb_method.Name = "cmb_method"
        Me.cmb_method.Size = New System.Drawing.Size(121, 21)
        Me.cmb_method.TabIndex = 86
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Location = New System.Drawing.Point(657, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "Data da compra"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Location = New System.Drawing.Point(658, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 13)
        Me.Label19.TabIndex = 91
        Me.Label19.Text = "Vendedor"
        '
        'txt_seller
        '
        Me.txt_seller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_seller.Location = New System.Drawing.Point(661, 136)
        Me.txt_seller.Multiline = True
        Me.txt_seller.Name = "txt_seller"
        Me.txt_seller.ReadOnly = True
        Me.txt_seller.Size = New System.Drawing.Size(198, 20)
        Me.txt_seller.TabIndex = 90
        '
        'txt_date
        '
        Me.txt_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_date.Location = New System.Drawing.Point(660, 81)
        Me.txt_date.Multiline = True
        Me.txt_date.Name = "txt_date"
        Me.txt_date.ReadOnly = True
        Me.txt_date.Size = New System.Drawing.Size(198, 20)
        Me.txt_date.TabIndex = 92
        '
        'frm_select_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 472)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txt_seller)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmb_method)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_block)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_apartment)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_number)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_uf)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_street)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_district)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_city)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_cell_phone)
        Me.Controls.Add(Me.txt_landline_phone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_last_name)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_first_name)
        Me.Controls.Add(Me.dgv_prod_order)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(896, 511)
        Me.MinimumSize = New System.Drawing.Size(896, 511)
        Me.Name = "frm_select_order"
        Me.Text = "Search order"
        CType(Me.dgv_prod_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_prod_order As Windows.Forms.DataGridView
    Friend WithEvents Id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_prod As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cat As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preco As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_cell_phone As Windows.Forms.MaskedTextBox
    Friend WithEvents txt_landline_phone As Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txt_email As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txt_last_name As Windows.Forms.TextBox
    Friend WithEvents txt_cpf As Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txt_first_name As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txt_search As Windows.Forms.TextBox
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents txt_block As Windows.Forms.TextBox
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents txt_apartment As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents txt_number As Windows.Forms.TextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txt_uf As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents txt_street As Windows.Forms.TextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents txt_district As Windows.Forms.TextBox
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents txt_city As Windows.Forms.TextBox
    Friend WithEvents txt_cep As Windows.Forms.MaskedTextBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents cmb_method As Windows.Forms.ComboBox
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents txt_seller As Windows.Forms.TextBox
    Friend WithEvents txt_date As Windows.Forms.TextBox
    Friend WithEvents btn_search As FontAwesome.Sharp.IconButton
End Class
