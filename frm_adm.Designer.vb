<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_adm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_adm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_salesman = New System.Windows.Forms.Button()
        Me.btn_inventory = New System.Windows.Forms.Button()
        Me.btn_copyorder = New System.Windows.Forms.Button()
        Me.btn_seeorders = New System.Windows.Forms.Button()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.btn_salesman)
        Me.Panel1.Controls.Add(Me.btn_inventory)
        Me.Panel1.Controls.Add(Me.btn_copyorder)
        Me.Panel1.Controls.Add(Me.btn_seeorders)
        Me.Panel1.Controls.Add(Me.btn_dashboard)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 460)
        Me.Panel1.TabIndex = 1
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(12, 425)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(75, 23)
        Me.btn_logout.TabIndex = 5
        Me.btn_logout.Text = "Button6"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_salesman
        '
        Me.btn_salesman.Location = New System.Drawing.Point(0, 324)
        Me.btn_salesman.Name = "btn_salesman"
        Me.btn_salesman.Size = New System.Drawing.Size(205, 32)
        Me.btn_salesman.TabIndex = 4
        Me.btn_salesman.Text = "Button5"
        Me.btn_salesman.UseVisualStyleBackColor = True
        '
        'btn_inventory
        '
        Me.btn_inventory.Location = New System.Drawing.Point(0, 276)
        Me.btn_inventory.Name = "btn_inventory"
        Me.btn_inventory.Size = New System.Drawing.Size(205, 32)
        Me.btn_inventory.TabIndex = 3
        Me.btn_inventory.Text = "Button4"
        Me.btn_inventory.UseVisualStyleBackColor = True
        '
        'btn_copyorder
        '
        Me.btn_copyorder.Location = New System.Drawing.Point(0, 228)
        Me.btn_copyorder.Name = "btn_copyorder"
        Me.btn_copyorder.Size = New System.Drawing.Size(205, 32)
        Me.btn_copyorder.TabIndex = 2
        Me.btn_copyorder.Text = "Button3"
        Me.btn_copyorder.UseVisualStyleBackColor = True
        '
        'btn_seeorders
        '
        Me.btn_seeorders.Location = New System.Drawing.Point(0, 180)
        Me.btn_seeorders.Name = "btn_seeorders"
        Me.btn_seeorders.Size = New System.Drawing.Size(205, 32)
        Me.btn_seeorders.TabIndex = 1
        Me.btn_seeorders.Text = "Button2"
        Me.btn_seeorders.UseVisualStyleBackColor = True
        '
        'btn_dashboard
        '
        Me.btn_dashboard.Location = New System.Drawing.Point(0, 132)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(205, 32)
        Me.btn_dashboard.TabIndex = 0
        Me.btn_dashboard.Text = "Button1"
        Me.btn_dashboard.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(205, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(731, 25)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(683, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(707, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frm_adm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(936, 460)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_adm"
        Me.Text = "frm_adm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Panel2 As Windows.Forms.Panel
    Friend WithEvents PictureBox2 As Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents btn_logout As Windows.Forms.Button
    Friend WithEvents btn_salesman As Windows.Forms.Button
    Friend WithEvents btn_inventory As Windows.Forms.Button
    Friend WithEvents btn_copyorder As Windows.Forms.Button
    Friend WithEvents btn_seeorders As Windows.Forms.Button
    Friend WithEvents btn_dashboard As Windows.Forms.Button
End Class
