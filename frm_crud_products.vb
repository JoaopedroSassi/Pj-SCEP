Public Class frm_crud_products
    Private Sub frm_crud_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_prod()
    End Sub

    Sub load_prod()
        Try
            sql = "SELECT * FROM tb_products ORDER BY id_prod"
            rs = db.Execute(sql)
            With dgv_prod
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar | Load produtos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub clean_prod()
        Try
            txt_id.Clear()
            txt_name_prod.Clear()
            cmb_cat_prod.ResetText()
            txt_amount.Clear()
            txt_price.Clear()
            txt_search_id.Clear()
            txt_name_prod.Focus()
        Catch ex As Exception
            MsgBox("Erro ao processar | Limpar campos produto", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub return_combo_box()
        cmb_cat_prod.SelectedIndex = 0
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txt_name_prod.Text = "" Or
               cmb_cat_prod.Text = "" Or
               txt_amount.Text = "" Or
               txt_price.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
                txt_name_prod.Focus()
            Else
                sql = "SELECT * FROM tb_products WHERE id_prod = '" & txt_id.Text & "'"
                rs = db.Execute(sql)
                If rs.EOF = False Then
                    sql = "UPDATE tb_products SET name = '" & txt_name_prod.Text & "', category = '" & cmb_cat_prod.SelectedItem & "', amount = '" & txt_amount.Text & "', cost_price = '" & txt_price.Text & "' WHERE id_prod = " & txt_id.Text & ""
                    rs = db.Execute(sql)
                    MsgBox("Produto atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    clean_prod()
                Else
                    sql = "INSERT INTO tb_products VALUES (default, '" & txt_name_prod.Text & "', '" & cmb_cat_prod.SelectedItem & "', '" & txt_amount.Text & "', '" & txt_price.Text & "')"
                    rs = db.Execute(sql)
                    MsgBox("Produto cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                End If
                clean_prod()
                load_prod()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Create/Update", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If IsNothing(dgv_prod.SelectedRows) Then
                MsgBox("Erro | Nenhum item selecionado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            Else
                id_tmp = dgv_prod.CurrentRow.Cells(0).Value
                resp = MsgBox("Deseja realmente excluir o registro de id: " & id_tmp & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Aviso")
                If resp = MsgBoxResult.Yes Then
                    sql = "DELETE FROM tb_products WHERE id_prod = " & id_tmp & ""
                    rs = db.Execute(sql)
                    MsgBox("Produto excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
                    load_prod()
                    clean_prod()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Deletar produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            If IsNothing(dgv_prod.SelectedRows) Then
                MsgBox("Erro | Nenhum item selecionado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            Else
                return_combo_box()
                id_tmp = dgv_prod.CurrentRow.Cells(0).Value
                sql = "SELECT * FROM tb_products WHERE id_prod = " & id_tmp & ""
                rs = db.Execute(sql)
                txt_id.Text = rs.Fields(0).Value
                txt_name_prod.Text = rs.Fields(1).Value
                cmb_cat_prod.SelectedItem = rs.Fields(2).Value
                txt_amount.Text = rs.Fields(3).Value
                txt_price.Text = rs.Fields(4).Value
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Editar produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_search_id_Click(sender As Object, e As EventArgs) Handles btn_search_id.Click
        Try
            sql = "SELECT * FROM tb_products WHERE id_prod = " & txt_search_id.Text & ""
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_id.Text = rs.Fields(0).Value
                txt_name_prod.Text = rs.Fields(1).Value
                cmb_cat_prod.SelectedItem = rs.Fields(2).Value
                txt_amount.Text = rs.Fields(3).Value
                txt_price.Text = rs.Fields(4).Value
            Else
                MsgBox("Erro | Produto com id: " & txt_search_id.Text & " não encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                clean_prod()
                txt_search_id.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Busca produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub txt_amount_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txt_amount.KeyPress
        only_number(sender, e)
    End Sub

    Private Sub txt_price_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txt_price.KeyPress
        only_number(sender, e)
    End Sub
End Class