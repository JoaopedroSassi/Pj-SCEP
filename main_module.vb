Imports System.Drawing
Imports System.Windows.Forms
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient

Module main_module
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, day, resp, aux_cmb, name_sell_log As String
    Public cont, date_system, id_tmp, id_sell_log, id_address, id_client, id_order, final_price, final_amount As Integer
    Public current_btn As IconButton
    Public left_border_btn As Panel
    Public current_child_form As Form

    Sub conect_db()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;PORT=3306;Database=db_scep;User=root;Password=123456")
            MsgBox("Conexão com a base de dados executado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao conectar! | Conexão base de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub ActiveButton(send_btn As Object)
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

    Sub DisableButton()
        If current_btn IsNot Nothing Then
            current_btn.BackColor = Color.FromArgb(49, 0, 168)
            current_btn.TextAlign = ContentAlignment.MiddleLeft
            current_btn.ImageAlign = ContentAlignment.MiddleLeft
            current_btn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Sub OpenChildForm(child_form As Form, pnl As Panel)
        If current_child_form IsNot Nothing Then
            current_child_form.Close()
        End If
        current_child_form = child_form

        child_form.TopLevel = False
        child_form.FormBorderStyle = FormBorderStyle.None
        child_form.Dock = DockStyle.Fill
        pnl.Controls.Add(child_form)
        pnl.Tag = child_form
        child_form.BringToFront()
        child_form.Show()
    End Sub

    Sub reset()
        DisableButton()
        left_border_btn.Visible = False
    End Sub

    Sub home_form()
        If current_child_form IsNot Nothing Then
            current_child_form.Close()
        End If
        reset()
    End Sub


End Module

