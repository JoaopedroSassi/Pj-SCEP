Public Class frm_crud_seller
    Private Sub frm_crud_seller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_sell()
    End Sub

    Sub load_sell()
        Try
            sql = "SELECT * FROM tb_login WHERE NOT type = 'admin' ORDER BY id_login"
            rs = db.Execute(sql)
            With dgv_sell
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value + " " + rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(7).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar | Load Sellers!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub clean_sell()
        Try
            txt_id.Clear()
            txt_cpf.Clear()
            txt_first_name.Clear()
            txt_last_name.Clear()
            txt_email.Clear()
            txt_pass.Clear()
            cmb_status.Text = " "
            txt_search_id.Clear()
            txt_cpf.Focus()
        Catch ex As Exception
            MsgBox("Erro ao processar | Limpar campos produto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_cpf.Text = "" Or
               txt_first_name.Text = "" Or
               txt_last_name.Text = "" Or
               txt_email.Text = "" Or
               txt_pass.Text = "" Or
               cmb_status.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_cpf.Focus()
            Else
                sql = "SELECT * FROM tb_login WHERE id_login = '" & txt_id.Text & "'"
                rs = db.Execute(sql)
                status()
                If rs.EOF = False Then
                    sql = "UPDATE tb_login SET cpf = '" & txt_cpf.Text & "', first_name = '" & txt_first_name.Text & "', last_name = '" & txt_last_name.Text & "', email = '" & txt_email.Text & "', password = '" & txt_pass.Text & "', status = '" & aux_cmb & "' WHERE id_login = " & txt_id.Text & ""
                    rs = db.Execute(sql)
                    MsgBox("Vendedor atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    clean_sell()
                Else
                    sql = "INSERT INTO tb_login VALUES (default, '" & txt_cpf.Text & "', '" & txt_first_name.Text & "', '" & txt_last_name.Text & "', '" & txt_email.Text & "', '" & txt_pass.Text & "', 'seller', '" & aux_cmb & "')"
                    rs = db.Execute(sql)
                    MsgBox("Vendedor cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                End If
                clean_sell()
                load_sell()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Create/Update", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub status()
        If cmb_status.SelectedIndex = 0 Then
            aux_cmb = "active"
        Else
            aux_cmb = "disabled"
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            If IsNothing(dgv_sell.SelectedRows) Then
                MsgBox("Erro | Nenhum item selecionado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            Else
                id_tmp = dgv_sell.CurrentRow.Cells(0).Value
                sql = "SELECT * FROM tb_login WHERE id_login = " & id_tmp & ""
                rs = db.Execute(sql)
                txt_id.Text = rs.Fields(0).Value
                txt_cpf.Text = rs.Fields(1).Value
                txt_first_name.Text = rs.Fields(2).Value
                txt_last_name.Text = rs.Fields(3).Value
                txt_email.Text = rs.Fields(4).Value
                txt_pass.Text = rs.Fields(5).Value
                If rs.Fields(7).Value = "active" Then
                    cmb_status.SelectedItem = "Ativo"
                Else
                    cmb_status.SelectedItem = "Desativado"
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Editar produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If IsNothing(dgv_sell.SelectedRows) Then
                MsgBox("Erro | Nenhum item selecionado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            Else
                id_tmp = dgv_sell.CurrentRow.Cells(0).Value
                resp = MsgBox("Deseja realmente excluir o registro de id: " & id_tmp & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso")
                If resp = MsgBoxResult.Yes Then
                    sql = "DELETE FROM tb_login WHERE id_login = " & id_tmp & ""
                    rs = db.Execute(sql)
                    MsgBox("Produto excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    load_sell()
                    clean_sell()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Deletar produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_search_id_Click(sender As Object, e As EventArgs) Handles btn_search_id.Click
        Try
            sql = "SELECT * FROM tb_login WHERE id_login = " & txt_search_id.Text & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_id.Text = rs.Fields(0).Value
                txt_cpf.Text = rs.Fields(1).Value
                txt_first_name.Text = rs.Fields(2).Value
                txt_last_name.Text = rs.Fields(3).Value
                txt_email.Text = rs.Fields(4).Value
                txt_pass.Text = rs.Fields(5).Value
                If rs.Fields(7).Value = "active" Then
                    cmb_status.SelectedIndex = 0
                Else
                    cmb_status.SelectedIndex = 1
                End If
            Else
                MsgBox("Erro | Produto com id: " & txt_search_id.Text & " não encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                clean_sell()
                txt_search_id.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Busca produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
End Class