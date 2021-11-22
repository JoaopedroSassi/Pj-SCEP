<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_adm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adm))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.btn_prod = New FontAwesome.Sharp.IconButton()
        Me.btn_seller = New FontAwesome.Sharp.IconButton()
        Me.btn_make_order = New FontAwesome.Sharp.IconButton()
        Me.pnl_menu = New System.Windows.Forms.Panel()
        Me.btn_logout = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_content = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbproductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_scepDataSet = New scep.db_scepDataSet()
        Me.Tb_productsTableAdapter = New scep.db_scepDataSetTableAdapters.tb_productsTableAdapter()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_menu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl_content.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbproductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_scepDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_logo
        '
        Me.pic_logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(0, 0)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(205, 146)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 0
        Me.pic_logo.TabStop = False
        '
        'btn_prod
        '
        Me.btn_prod.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_prod.FlatAppearance.BorderSize = 0
        Me.btn_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prod.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_prod.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed
        Me.btn_prod.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_prod.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_prod.IconSize = 36
        Me.btn_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_prod.Location = New System.Drawing.Point(0, 266)
        Me.btn_prod.Name = "btn_prod"
        Me.btn_prod.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_prod.Size = New System.Drawing.Size(205, 60)
        Me.btn_prod.TabIndex = 12
        Me.btn_prod.Text = "CRUD | Estoque"
        Me.btn_prod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_prod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_prod.UseVisualStyleBackColor = True
        '
        'btn_seller
        '
        Me.btn_seller.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_seller.FlatAppearance.BorderSize = 0
        Me.btn_seller.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_seller.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_seller.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btn_seller.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_seller.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_seller.IconSize = 36
        Me.btn_seller.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seller.Location = New System.Drawing.Point(0, 206)
        Me.btn_seller.Name = "btn_seller"
        Me.btn_seller.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_seller.Size = New System.Drawing.Size(205, 60)
        Me.btn_seller.TabIndex = 11
        Me.btn_seller.Text = "CRUD | Vendedores"
        Me.btn_seller.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seller.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_seller.UseVisualStyleBackColor = True
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
        'pnl_menu
        '
        Me.pnl_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.pnl_menu.Controls.Add(Me.btn_logout)
        Me.pnl_menu.Controls.Add(Me.btn_prod)
        Me.pnl_menu.Controls.Add(Me.btn_seller)
        Me.pnl_menu.Controls.Add(Me.btn_make_order)
        Me.pnl_menu.Controls.Add(Me.Panel1)
        Me.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_menu.Location = New System.Drawing.Point(0, 0)
        Me.pnl_menu.Name = "pnl_menu"
        Me.pnl_menu.Size = New System.Drawing.Size(205, 511)
        Me.pnl_menu.TabIndex = 16
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
        Me.btn_logout.Location = New System.Drawing.Point(0, 451)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_logout.Size = New System.Drawing.Size(205, 60)
        Me.btn_logout.TabIndex = 13
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = True
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
        'pnl_content
        '
        Me.pnl_content.Controls.Add(Me.Label1)
        Me.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_content.Location = New System.Drawing.Point(205, 0)
        Me.pnl_content.Name = "pnl_content"
        Me.pnl_content.Size = New System.Drawing.Size(896, 511)
        Me.pnl_content.TabIndex = 17
        '
        'Chart1
        '
        ChartArea1.AxisX.Title = "Produtos"
        ChartArea1.AxisY.Title = "Quantidade"
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.TbproductsBindingSource
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(412, 146)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.BackImageTransparentColor = System.Drawing.Color.White
        Series1.BackSecondaryColor = System.Drawing.Color.White
        Series1.BorderColor = System.Drawing.Color.White
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn
        Series1.Color = System.Drawing.Color.White
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Series1.IsValueShownAsLabel = True
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.LabelBorderColor = System.Drawing.Color.Transparent
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.White
        Series1.MarkerColor = System.Drawing.Color.White
        Series1.Name = "Series1"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale
        Series1.XValueMember = "name"
        Series1.YValueMembers = "amount"
        Series1.YValuesPerPoint = 2
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(473, 278)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "admin"
        '
        'TbproductsBindingSource
        '
        Me.TbproductsBindingSource.DataMember = "tb_products"
        Me.TbproductsBindingSource.DataSource = Me.Db_scepDataSet
        '
        'Db_scepDataSet
        '
        Me.Db_scepDataSet.DataSetName = "db_scepDataSet"
        Me.Db_scepDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_productsTableAdapter
        '
        Me.Tb_productsTableAdapter.ClearBeforeFill = True
        '
        'frm_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1101, 511)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.pnl_content)
        Me.Controls.Add(Me.pnl_menu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_adm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_menu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnl_content.ResumeLayout(False)
        Me.pnl_content.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbproductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_scepDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic_logo As Windows.Forms.PictureBox
    Friend WithEvents btn_prod As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_seller As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_make_order As FontAwesome.Sharp.IconButton
    Friend WithEvents pnl_menu As Windows.Forms.Panel
    Friend WithEvents btn_logout As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents pnl_content As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Chart1 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Db_scepDataSet As db_scepDataSet
    Friend WithEvents TbproductsBindingSource As Windows.Forms.BindingSource
    Friend WithEvents Tb_productsTableAdapter As db_scepDataSetTableAdapters.tb_productsTableAdapter
End Class
