<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_crud_products
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_crud_products))
        Me.dgv_prod = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_search_id = New FontAwesome.Sharp.IconPictureBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_search_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.cmb_cat_prod = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_name_prod = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_search_id, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_prod
        '
        Me.dgv_prod.AllowUserToAddRows = False
        Me.dgv_prod.AllowUserToDeleteRows = False
        Me.dgv_prod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_prod.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_prod.BackgroundColor = System.Drawing.Color.White
        Me.dgv_prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_prod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_prod.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_prod.ColumnHeadersHeight = 25
        Me.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_prod.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.name_prod, Me.cat, Me.amount, Me.cost_price})
        Me.dgv_prod.EnableHeadersVisualStyles = False
        Me.dgv_prod.GridColor = System.Drawing.Color.SteelBlue
        Me.dgv_prod.Location = New System.Drawing.Point(2, 79)
        Me.dgv_prod.Name = "dgv_prod"
        Me.dgv_prod.ReadOnly = True
        Me.dgv_prod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_prod.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_prod.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_prod.Size = New System.Drawing.Size(570, 316)
        Me.dgv_prod.TabIndex = 0
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
        'cost_price
        '
        Me.cost_price.HeaderText = "Preço"
        Me.cost_price.Name = "cost_price"
        Me.cost_price.ReadOnly = True
        Me.cost_price.Width = 66
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.btn_search_id)
        Me.Panel1.Controls.Add(Me.txt_price)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txt_search_id)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_amount)
        Me.Panel1.Controls.Add(Me.cmb_cat_prod)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_name_prod)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_id)
        Me.Panel1.Location = New System.Drawing.Point(578, -11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 542)
        Me.Panel1.TabIndex = 2
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
        'txt_price
        '
        Me.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_price.Location = New System.Drawing.Point(118, 192)
        Me.txt_price.Multiline = True
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(92, 21)
        Me.txt_price.TabIndex = 4
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btn_save.FlatAppearance.BorderSize = 2
        Me.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(21, 233)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(268, 28)
        Me.btn_save.TabIndex = 14
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(17, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Preço:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Quantidade:"
        '
        'txt_amount
        '
        Me.txt_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_amount.Location = New System.Drawing.Point(118, 168)
        Me.txt_amount.Multiline = True
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(69, 21)
        Me.txt_amount.TabIndex = 3
        '
        'cmb_cat_prod
        '
        Me.cmb_cat_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_cat_prod.FormattingEnabled = True
        Me.cmb_cat_prod.Items.AddRange(New Object() {"Acoplados", "Cama", "Colchão", "Travesseiro"})
        Me.cmb_cat_prod.Location = New System.Drawing.Point(119, 140)
        Me.cmb_cat_prod.Name = "cmb_cat_prod"
        Me.cmb_cat_prod.Size = New System.Drawing.Size(171, 21)
        Me.cmb_cat_prod.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(17, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Categoria:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nome:"
        '
        'txt_name_prod
        '
        Me.txt_name_prod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name_prod.Location = New System.Drawing.Point(118, 114)
        Me.txt_name_prod.Multiline = True
        Me.txt_name_prod.Name = "txt_name_prod"
        Me.txt_name_prod.Size = New System.Drawing.Size(171, 21)
        Me.txt_name_prod.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(124, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Produtos"
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
        Me.txt_id.Location = New System.Drawing.Point(118, 90)
        Me.txt_id.Multiline = True
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(32, 21)
        Me.txt_id.TabIndex = 0
        '
        'btn_delete
        '
        Me.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_delete.FlatAppearance.BorderSize = 2
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_delete.Location = New System.Drawing.Point(395, 433)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(134, 27)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "Deletar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_edit.FlatAppearance.BorderSize = 2
        Me.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Location = New System.Drawing.Point(41, 433)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(134, 27)
        Me.btn_edit.TabIndex = 3
        Me.btn_edit.Text = "Editar"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Lato", 23.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_date.Location = New System.Drawing.Point(139, 13)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(251, 38)
        Me.lbl_date.TabIndex = 95
        Me.lbl_date.Text = "CRUD | Produtos"
        '
        'frm_crud_products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(880, 472)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_prod)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(896, 511)
        Me.Name = "frm_crud_products"
        Me.Text = "Crud | Pedidos"
        CType(Me.dgv_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_search_id, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_prod As Windows.Forms.DataGridView
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txt_id As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txt_name_prod As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents txt_amount As Windows.Forms.TextBox
    Friend WithEvents cmb_cat_prod As Windows.Forms.ComboBox
    Friend WithEvents btn_save As Windows.Forms.Button
    Friend WithEvents Id As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_prod As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cat As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cost_price As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_price As Windows.Forms.TextBox
    Friend WithEvents btn_search_id As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents txt_search_id As Windows.Forms.TextBox
    Friend WithEvents btn_delete As Windows.Forms.Button
    Friend WithEvents btn_edit As Windows.Forms.Button
    Friend WithEvents lbl_date As Windows.Forms.Label
End Class
