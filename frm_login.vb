﻿Public Class frm_login
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pic_close.Click
        Me.Close()
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conect_db()
        txt_email.Clear()
        txt_password.Clear()
        txt_email.Focus()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            sql = "SELECT * FROM tb_sys_users WHERE email = '" & txt_email.Text & "'"
            rs = db.Execute(sql)
            If (rs.EOF = True) Then
                MsgBox("ERRO! Usuário não encontrado", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                txt_email.Clear()
                txt_password.Clear()
                txt_email.Focus()
            Else
                If (txt_password.Text = rs.Fields(5).Value) Then
                    If (rs.Fields(6).Value = "seller") Then
                        MsgBox("Vendedor logado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                        Me.Hide()
                        Dim frm_sel = New frm_seller()
                        frm_sel.ShowDialog()
                        Me.Close()
                    Else
                        MsgBox("Admin logado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Atenção")
                    End If
                Else
                    MsgBox("ERRO! Senha não confere", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                    txt_password.Clear()
                    txt_password.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao conectar! | Conexão para login", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
End Class