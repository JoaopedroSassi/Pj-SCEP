Public Class frm_login
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conect_db()
        txt_email.Clear()
        txt_password.Clear()
        txt_email.Focus()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'Try
        sql = "SELECT * FROM tb_login WHERE email = '" & txt_email.Text & "'"
            rs = db.Execute(sql)
            If (rs.EOF = True) Then
                MsgBox("ERRO! Usuário não encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                clear_login()
            Else
                If (txt_password.Text = rs.Fields(5).Value) Then
                    If rs.Fields(7).Value = "disabled" Then
                        MsgBox("ERRO! Usuário desabilitado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                        clear_login()
                    Else
                        If (rs.Fields(6).Value = "seller") Then
                            id_sell_log = rs.Fields(0).Value
                            MsgBox("Vendedor logado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                            Me.Hide()
                            Dim frm_sel = New frm_seller()
                            frm_sel.ShowDialog()
                            Me.Close()
                        Else
                            MsgBox("Admin logado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                            Me.Hide()
                            Dim frm_admin = New frm_adm()
                            frm_admin.ShowDialog()
                            Me.Close()
                        End If
                    End If
                Else
                    MsgBox("ERRO! Senha não confere", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                    txt_password.Clear()
                    txt_password.Focus()
                End If
            End If
        ' Catch ex As Exception
        'MsgBox("Erro ao conectar! | Conexão para login", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        'End Try
    End Sub

    Sub clear_login()
        txt_email.Clear()
        txt_password.Clear()
        txt_email.Focus()
    End Sub
End Class