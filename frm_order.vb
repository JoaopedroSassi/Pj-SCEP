Imports System.Windows.Forms

Public Class frm_order

    Private Sub txt_cep_LostFocus(sender As Object, e As EventArgs) Handles txt_cep.LostFocus
        Try
            sql = "SELECT * FROM tb_cep WHERE cep = '" & txt_cep.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_street.Text = rs.Fields(1).Value
                txt_city.Text = rs.Fields(2).Value
                txt_district.Text = rs.Fields(3).Value
                txt_uf.Text = rs.Fields(4).Value
                txt_number.Focus()
            Else
                MsgBox("CEP: " & txt_cep.Text & "não localizado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Erro | Resgatar endereço pelo cep", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub cmb_cat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cat.SelectedIndexChanged
        Try
            cmb_name.ResetText()
            cmb_name.Items.Clear()
            sql = "SELECT * FROM tb_products WHERE category = '" & cmb_cat.Text & "' ORDER BY name ASC"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                cmb_name.Items.Add(rs.Fields(1).Value)
                rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Erro | Carregar produtos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            sql = "SELECT * FROM tb_products WHERE id_prod = '" & id_tmp & "'"
            rs = db.Execute(sql)
            If txt_qtde.Text > rs.Fields(3).Value Then
                MsgBox("Erro | Quantidade no pedido maior do que disponível!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                txt_qtde.Clear()
                txt_qtde.Focus()
            Else
                If dgv_prod_order.RowCount = 0 Then
                    insert_dgv()
                Else
                    For Each item As DataGridViewRow In dgv_prod_order.Rows
                        If item.Cells(0).Value = id_tmp Then
                            item.Cells(3).Value = txt_qtde.Text
                            item.Cells(4).Value = txt_price.Text
                            clean_prod()
                            Exit Sub
                        End If
                    Next
                    insert_dgv()
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro | Adicionar produtos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub insert_dgv()
        sql = "SELECT * FROM tb_products WHERE id_prod = '" & id_tmp & "'"
        rs = db.Execute(sql)
        dgv_prod_order.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, txt_qtde.Text, txt_price.Text)
        clean_prod()
    End Sub

    Private Sub cmb_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_name.SelectedIndexChanged
        Try
            sql = "SELECT * FROM tb_products WHERE name = '" & cmb_name.Text & "'"
            rs = db.Execute(sql)
            id_tmp = rs.Fields(0).Value
        Catch ex As Exception
            MsgBox("Erro | Trocar ID!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub clean_prod()
        cmb_cat.ResetText()
        txt_qtde.Clear()
        cmb_name.ResetText()
        txt_price.Clear()
        cmb_cat.Focus()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Try
            If IsNothing(dgv_prod_order.SelectedRows) Then
                MsgBox("Erro | Nenhum item selecionado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            Else
                return_combo_box()
                With dgv_prod_order
                    cmb_cat.SelectedItem = .CurrentRow.Cells(2).Value
                    txt_qtde.Text = .CurrentRow.Cells(3).Value
                    cmb_name.SelectedItem = .CurrentRow.Cells(1).Value
                    txt_price.Text = .CurrentRow.Cells(4).Value
                    txt_qtde.Focus()
                End With
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Editar produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If IsNothing(dgv_prod_order.SelectedRows) Then
                MsgBox("Erro | Nenhum item selecionado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            Else
                dgv_prod_order.Rows.Remove(dgv_prod_order.CurrentRow)
                clean_prod()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Deletar produtos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub return_combo_box()
        cmb_cat.SelectedIndex = 0
        cmb_name.SelectedIndex = 0
    End Sub

    Private Sub btn_save_order_Click(sender As Object, e As EventArgs) Handles btn_save_order.Click
        Try
            If txt_cpf.Text = "" Or
           txt_first_name.Text = "" Or
           txt_last_name.Text = "" Or
           txt_email.Text = "" Or
           txt_landline_phone.Text = "" Or
           txt_cell_phone.Text = "" Or
           txt_cep.Text = "" Or
           txt_city.Text = "" Or
           txt_district.Text = "" Or
           txt_street.Text = "" Or
           txt_uf.Text = "" Or
           txt_number.Text = "" Or
           dgv_prod_order.RowCount = 0 Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
                txt_cpf.Focus()
            Else
                create_address()
                create_client()
                create_order()
                create_products_order()
                clean_order()
                MsgBox("Pedido cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Criar pedido", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub create_client()
        Try
            sql = "INSERT INTO tb_client VALUES (default, '" & txt_cpf.Text & "', '" & txt_first_name.Text & "', '" & txt_last_name.Text & "', '" & txt_email.Text & "', '" & txt_landline_phone.Text & "', '" & txt_cell_phone.Text & "', '" & id_address & "')"
            rs = db.Execute(sql)

            sql = "SELECT MAX(id_client) FROM tb_client"
            rs = db.Execute(sql)
            id_client = rs.Fields(0).Value
        Catch ex As Exception
            MsgBox("Erro ao processar | Cadastrar cliente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub create_address()
        Try
            sql = "INSERT INTO tb_address VALUES (default, '" & txt_cep.Text & "', '" & txt_city.Text & "', '" & txt_district.Text & "', '" & txt_street.Text & "', '" & txt_uf.Text & "', '" & txt_number.Text & "', '" & txt_apartment.Text & "', '" & txt_block.Text & "')"
            rs = db.Execute(sql)

            sql = "SELECT MAX(id_address) FROM tb_address"
            rs = db.Execute(sql)
            id_address = rs.Fields(0).Value
        Catch ex As Exception
            MsgBox("Erro ao processar | Cadastrar endereco", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub create_order()
        Try
            date_system = DateTime.Now.ToString("yyyyMMdd")
            sql = "INSERT INTO tb_order VALUES (default, '" & date_system & "', '" & cmb_method.Text & "', '" & id_client & "', '" & id_sell_log & "')"
            rs = db.Execute(sql)

            sql = "SELECT MAX(id_order) FROM tb_order"
            rs = db.Execute(sql)
            id_order = rs.Fields(0).Value
        Catch ex As Exception
            MsgBox("Erro ao processar | Cadastrar pedido", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub create_products_order()
        Try
            For Each item As DataGridViewRow In dgv_prod_order.Rows
                final_price = item.Cells(3).Value * item.Cells(4).Value
                sql = "INSERT INTO tb_order_product VALUES (default, '" & item.Cells(3).Value & "', '" & final_price & "', '" & id_order & "', '" & item.Cells(0).Value & "')"
                rs = db.Execute(sql)
            Next
        Catch ex As Exception
            MsgBox("Erro ao processar | Cadastrar items pedido", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub clean_order()
        txt_cpf.Clear()
        txt_first_name.Clear()
        txt_last_name.Clear()
        txt_email.Clear()
        txt_landline_phone.Clear()
        txt_cell_phone.Clear()
        txt_cep.Clear()
        txt_city.Clear()
        txt_district.Clear()
        txt_street.Clear()
        txt_uf.Clear()
        txt_number.Clear()
        txt_apartment.Clear()
        txt_block.Clear()
        cmb_method.ResetText()
        txt_cpf.Focus()
        dgv_prod_order.Rows.Clear()
    End Sub
End Class