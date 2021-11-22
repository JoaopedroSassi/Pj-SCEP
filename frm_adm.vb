Imports System.Drawing
Imports System.Windows.Forms

Public Class frm_adm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub New()
        InitializeComponent()

        left_border_btn = New Panel()
        left_border_btn.Size = New Size(7, 60)
        pnl_menu.Controls.Add(left_border_btn)
    End Sub

    Private Sub btn_prod_Click(sender As Object, e As EventArgs) Handles btn_prod.Click
        ActiveButton(sender)
        OpenChildForm(New frm_crud_products, pnl_content)
    End Sub

    Private Sub btn_seller_Click(sender As Object, e As EventArgs) Handles btn_seller.Click
        ActiveButton(sender)
        OpenChildForm(New frm_crud_seller, pnl_content)
    End Sub

    Private Sub pic_logo_Click(sender As Object, e As EventArgs) Handles pic_logo.Click
        home_form()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        resp = MsgBox("Deseja realmente sair?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso")
        If resp = MsgBoxResult.Yes Then
            Me.Hide()
            Dim frm_log = New frm_login()
            frm_log.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub frm_adm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_scepDataSet.tb_products' table. You can move, or remove it, as needed.
        Me.Tb_productsTableAdapter.test(Me.Db_scepDataSet.tb_products)

    End Sub
End Class