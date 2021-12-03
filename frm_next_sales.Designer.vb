<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_next_sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_next_sales))
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.dgv_next_sales = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.residencial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delivery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cep = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_city = New System.Windows.Forms.TextBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_search_address = New System.Windows.Forms.Button()
        CType(Me.dgv_next_sales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Lato", 23.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(328, 9)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(261, 38)
        Me.lbl_date.TabIndex = 96
        Me.lbl_date.Text = "Próximas entregas"
        '
        'dgv_next_sales
        '
        Me.dgv_next_sales.AllowUserToAddRows = False
        Me.dgv_next_sales.AllowUserToDeleteRows = False
        Me.dgv_next_sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_next_sales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_next_sales.BackgroundColor = System.Drawing.Color.White
        Me.dgv_next_sales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_next_sales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_next_sales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_next_sales.ColumnHeadersHeight = 25
        Me.dgv_next_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_next_sales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.name_prod, Me.email, Me.residencial, Me.cel, Me.pedido, Me.delivery, Me.cep})
        Me.dgv_next_sales.EnableHeadersVisualStyles = False
        Me.dgv_next_sales.GridColor = System.Drawing.Color.SteelBlue
        Me.dgv_next_sales.Location = New System.Drawing.Point(12, 76)
        Me.dgv_next_sales.Name = "dgv_next_sales"
        Me.dgv_next_sales.ReadOnly = True
        Me.dgv_next_sales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_next_sales.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_next_sales.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_next_sales.Size = New System.Drawing.Size(866, 236)
        Me.dgv_next_sales.TabIndex = 97
        '
        'Id
        '
        Me.Id.HeaderText = "Id - Venda"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 91
        '
        'name_prod
        '
        Me.name_prod.HeaderText = "Nome"
        Me.name_prod.Name = "name_prod"
        Me.name_prod.ReadOnly = True
        Me.name_prod.Width = 67
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 64
        '
        'residencial
        '
        Me.residencial.HeaderText = "Residencial"
        Me.residencial.Name = "residencial"
        Me.residencial.ReadOnly = True
        Me.residencial.Width = 102
        '
        'cel
        '
        Me.cel.HeaderText = "Celular"
        Me.cel.Name = "cel"
        Me.cel.ReadOnly = True
        Me.cel.Width = 72
        '
        'pedido
        '
        Me.pedido.HeaderText = "Data do pedido"
        Me.pedido.Name = "pedido"
        Me.pedido.ReadOnly = True
        Me.pedido.Width = 124
        '
        'delivery
        '
        Me.delivery.HeaderText = "Data de entrega"
        Me.delivery.Name = "delivery"
        Me.delivery.ReadOnly = True
        Me.delivery.Width = 127
        '
        'cep
        '
        Me.cep.HeaderText = "Cep"
        Me.cep.Name = "cep"
        Me.cep.ReadOnly = True
        Me.cep.Width = 55
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Location = New System.Drawing.Point(793, 403)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 109
        Me.Label14.Text = "Bloco"
        '
        'txt_block
        '
        Me.txt_block.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_block.Location = New System.Drawing.Point(796, 419)
        Me.txt_block.Multiline = True
        Me.txt_block.Name = "txt_block"
        Me.txt_block.Size = New System.Drawing.Size(64, 20)
        Me.txt_block.TabIndex = 101
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Location = New System.Drawing.Point(723, 403)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "Apartamento"
        '
        'txt_apartment
        '
        Me.txt_apartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apartment.Location = New System.Drawing.Point(726, 419)
        Me.txt_apartment.Multiline = True
        Me.txt_apartment.Name = "txt_apartment"
        Me.txt_apartment.Size = New System.Drawing.Size(64, 20)
        Me.txt_apartment.TabIndex = 100
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Location = New System.Drawing.Point(634, 403)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Número"
        '
        'txt_number
        '
        Me.txt_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_number.Location = New System.Drawing.Point(637, 419)
        Me.txt_number.Multiline = True
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(83, 20)
        Me.txt_number.TabIndex = 99
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Location = New System.Drawing.Point(592, 403)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "UF"
        '
        'txt_uf
        '
        Me.txt_uf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_uf.Location = New System.Drawing.Point(595, 419)
        Me.txt_uf.Multiline = True
        Me.txt_uf.Name = "txt_uf"
        Me.txt_uf.Size = New System.Drawing.Size(36, 20)
        Me.txt_uf.TabIndex = 113
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Location = New System.Drawing.Point(398, 403)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Rua"
        '
        'txt_street
        '
        Me.txt_street.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_street.Location = New System.Drawing.Point(401, 419)
        Me.txt_street.Multiline = True
        Me.txt_street.Name = "txt_street"
        Me.txt_street.Size = New System.Drawing.Size(188, 20)
        Me.txt_street.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(256, 403)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Bairro"
        '
        'txt_district
        '
        Me.txt_district.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_district.Location = New System.Drawing.Point(259, 419)
        Me.txt_district.Multiline = True
        Me.txt_district.Name = "txt_district"
        Me.txt_district.Size = New System.Drawing.Size(136, 20)
        Me.txt_district.TabIndex = 111
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Location = New System.Drawing.Point(114, 403)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Cidade"
        '
        'txt_city
        '
        Me.txt_city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_city.Location = New System.Drawing.Point(117, 419)
        Me.txt_city.Multiline = True
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(136, 20)
        Me.txt_city.TabIndex = 110
        '
        'txt_cep
        '
        Me.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cep.Location = New System.Drawing.Point(44, 419)
        Me.txt_cep.Mask = "99999-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(59, 20)
        Me.txt_cep.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(41, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Cep"
        '
        'btn_search_address
        '
        Me.btn_search_address.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_search_address.FlatAppearance.BorderSize = 2
        Me.btn_search_address.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search_address.Location = New System.Drawing.Point(382, 318)
        Me.btn_search_address.Name = "btn_search_address"
        Me.btn_search_address.Size = New System.Drawing.Size(137, 29)
        Me.btn_search_address.TabIndex = 114
        Me.btn_search_address.Text = "Buscar"
        Me.btn_search_address.UseVisualStyleBackColor = True
        '
        'frm_next_sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 472)
        Me.Controls.Add(Me.btn_search_address)
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
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_city)
        Me.Controls.Add(Me.txt_cep)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgv_next_sales)
        Me.Controls.Add(Me.lbl_date)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(896, 511)
        Me.MinimumSize = New System.Drawing.Size(896, 511)
        Me.Name = "frm_next_sales"
        Me.Text = "Próximas vendas"
        CType(Me.dgv_next_sales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_date As Windows.Forms.Label
    Friend WithEvents dgv_next_sales As Windows.Forms.DataGridView
    Friend WithEvents Id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_prod As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents residencial As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cel As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pedido As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents delivery As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cep As Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txt_city As Windows.Forms.TextBox
    Friend WithEvents txt_cep As Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents btn_search_address As Windows.Forms.Button
End Class
