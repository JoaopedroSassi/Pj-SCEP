Public Class frm_seller
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
End Class