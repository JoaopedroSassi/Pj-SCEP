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

    Public Sub ActiveButton(send_btn As Object)
        If send_btn IsNot Nothing Then
            DisableButton()
            current_btn = CType(send_btn, IconButton)
            current_btn.BackColor = Color.FromArgb(49, 0, 168)

            current_btn.TextAlign = ContentAlignment.MiddleCenter
            current_btn.ImageAlign = ContentAlignment.MiddleRight
            current_btn.TextImageRelation = TextImageRelation.TextBeforeImage

            left_border_btn.BackColor = Color.FromArgb(251, 215, 116)
            left_border_btn.Location = New Point(0, current_btn.Location.Y)
            left_border_btn.Visible = True
            left_border_btn.BringToFront()
        End If
    End Sub

    Public Sub DisableButton()
        If current_btn IsNot Nothing Then
            current_btn.BackColor = Color.FromArgb(49, 0, 168)
            current_btn.TextAlign = ContentAlignment.MiddleLeft
            current_btn.ImageAlign = ContentAlignment.MiddleLeft
            current_btn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(child_form As Form)
        If current_child_form IsNot Nothing Then
            current_child_form.Close()
        End If
        current_child_form = child_form

        child_form.TopLevel = False
        child_form.FormBorderStyle = FormBorderStyle.None
        child_form.Dock = DockStyle.Fill
        pnl_content.Controls.Add(child_form)
        pnl_content.Tag = child_form
        child_form.BringToFront()
        child_form.Show()

    End Sub

    Private Sub reset()
        DisableButton()
        left_border_btn.Visible = False
    End Sub
















    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
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
        OpenChildForm(New frm_teste)
    End Sub

    Private Sub btn_check_order_Click(sender As Object, e As EventArgs) Handles btn_check_order.Click
        ActiveButton(sender)
    End Sub

    Private Sub btn_check_prod_Click(sender As Object, e As EventArgs) Handles btn_check_prod.Click
        ActiveButton(sender)
    End Sub

    Private Sub pic_logo_Click(sender As Object, e As EventArgs) Handles pic_logo.Click
        If current_child_form IsNot Nothing Then
            current_child_form.Close()
        End If
        Reset()
    End Sub
End Class