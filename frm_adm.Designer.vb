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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.btn_prod = New FontAwesome.Sharp.IconButton()
        Me.btn_seller = New FontAwesome.Sharp.IconButton()
        Me.btn_report = New FontAwesome.Sharp.IconButton()
        Me.pnl_menu = New System.Windows.Forms.Panel()
        Me.btn_logout = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_content = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Db_scepDataSet = New scep.db_scepDataSet()
        Me.TbprecoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_precoTableAdapter = New scep.db_scepDataSetTableAdapters.tb_precoTableAdapter()
        Me.TbvendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_vendedorTableAdapter = New scep.db_scepDataSetTableAdapters.tb_vendedorTableAdapter()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_menu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl_content.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_scepDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbprecoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbvendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btn_report
        '
        Me.btn_report.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_report.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_report.FlatAppearance.BorderSize = 0
        Me.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_report.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_report.IconChar = FontAwesome.Sharp.IconChar.FileInvoice
        Me.btn_report.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_report.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_report.IconSize = 36
        Me.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_report.Location = New System.Drawing.Point(0, 146)
        Me.btn_report.Name = "btn_report"
        Me.btn_report.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btn_report.Size = New System.Drawing.Size(205, 60)
        Me.btn_report.TabIndex = 10
        Me.btn_report.Text = "Gerar relatório"
        Me.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_report.UseVisualStyleBackColor = False
        '
        'pnl_menu
        '
        Me.pnl_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.pnl_menu.Controls.Add(Me.btn_logout)
        Me.pnl_menu.Controls.Add(Me.btn_prod)
        Me.pnl_menu.Controls.Add(Me.btn_seller)
        Me.pnl_menu.Controls.Add(Me.btn_report)
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
        Me.pnl_content.Controls.Add(Me.Chart2)
        Me.pnl_content.Controls.Add(Me.Chart1)
        Me.pnl_content.Controls.Add(Me.Label3)
        Me.pnl_content.Controls.Add(Me.Label2)
        Me.pnl_content.Controls.Add(Me.Label1)
        Me.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_content.Location = New System.Drawing.Point(205, 0)
        Me.pnl_content.Name = "pnl_content"
        Me.pnl_content.Size = New System.Drawing.Size(896, 511)
        Me.pnl_content.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(567, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Relação de vendas por vendedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Relação de métodos de pagamento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seja bem vindo Admin"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.DataSource = Me.TbprecoBindingSource
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(6, 81)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series2.ChartArea = "ChartArea1"
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.Name = "N° de pedidos"
        Series2.XValueMember = "payment_method"
        Series2.YValueMembers = "Quantidade"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(479, 300)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        '
        'Chart2
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea1)
        Me.Chart2.DataSource = Me.TbvendedorBindingSource
        Legend1.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend1)
        Me.Chart2.Location = New System.Drawing.Point(430, 188)
        Me.Chart2.Name = "Chart2"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "N° de vendas"
        Series1.XValueMember = "Full_name"
        Series1.YValueMembers = "Qtde_vendas"
        Me.Chart2.Series.Add(Series1)
        Me.Chart2.Size = New System.Drawing.Size(492, 300)
        Me.Chart2.TabIndex = 6
        Me.Chart2.Text = "Chart2"
        '
        'Db_scepDataSet
        '
        Me.Db_scepDataSet.DataSetName = "db_scepDataSet"
        Me.Db_scepDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbprecoBindingSource
        '
        Me.TbprecoBindingSource.DataMember = "tb_preco"
        Me.TbprecoBindingSource.DataSource = Me.Db_scepDataSet
        '
        'Tb_precoTableAdapter
        '
        Me.Tb_precoTableAdapter.ClearBeforeFill = True
        '
        'TbvendedorBindingSource
        '
        Me.TbvendedorBindingSource.DataMember = "tb_vendedor"
        Me.TbvendedorBindingSource.DataSource = Me.Db_scepDataSet
        '
        'Tb_vendedorTableAdapter
        '
        Me.Tb_vendedorTableAdapter.ClearBeforeFill = True
        '
        'frm_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1101, 511)
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
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_scepDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbprecoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbvendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic_logo As Windows.Forms.PictureBox
    Friend WithEvents btn_prod As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_seller As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_report As FontAwesome.Sharp.IconButton
    Friend WithEvents pnl_menu As Windows.Forms.Panel
    Friend WithEvents btn_logout As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents pnl_content As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Chart2 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Db_scepDataSet As db_scepDataSet
    Friend WithEvents TbprecoBindingSource As Windows.Forms.BindingSource
    Friend WithEvents Tb_precoTableAdapter As db_scepDataSetTableAdapters.tb_precoTableAdapter
    Friend WithEvents TbvendedorBindingSource As Windows.Forms.BindingSource
    Friend WithEvents Tb_vendedorTableAdapter As db_scepDataSetTableAdapters.tb_vendedorTableAdapter
End Class
