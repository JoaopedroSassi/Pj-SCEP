Imports System.Drawing
Imports System.Windows.Forms
Imports FontAwesome.Sharp

Public Class frm_seller

    Public Sub New()
        InitializeComponent()

        left_border_btn = New Panel()
        left_border_btn.Size = New Size(7, 60)
        pnl_menu.Controls.Add(left_border_btn)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_time.Text = TimeOfDay
        lbl_date.Text = Date.Today
        day = Date.UtcNow.DayOfWeek

        Select Case day
            Case "0"
                lbl_day.Text = "Domingo"
            Case "1"
                lbl_day.Text = "Segunda-feira"
            Case "2"
                lbl_day.Text = "Terça-feira"
            Case "3"
                lbl_day.Text = "Quarta-feira"
            Case "4"
                lbl_day.Text = "Quinta-feira"
            Case "5"
                lbl_day.Text = "Sexta-feira"
            Case "6"
                lbl_day.Text = "Sabado"
            Case Else
                lbl_day.Text = "Erro! Dia inválido!"
        End Select
    End Sub

    Private Sub frm_seller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_wel.Text = "Olá! Seja bem vindo/vinda | Vendedor(a): " & rs.Fields(2).Value & ""
    End Sub

    Private Sub btn_make_order_Click(sender As Object, e As EventArgs) Handles btn_make_order.Click
        ActiveButton(sender)
        OpenChildForm(New frm_teste, pnl_content)
    End Sub

    Private Sub btn_check_order_Click(sender As Object, e As EventArgs) Handles btn_check_order.Click
        ActiveButton(sender)
    End Sub

    Private Sub btn_check_prod_Click(sender As Object, e As EventArgs) Handles btn_check_prod.Click
        ActiveButton(sender)
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

    Private Sub pnl_content_Paint(sender As Object, e As PaintEventArgs) Handles pnl_content.Paint

    End Sub
End Class