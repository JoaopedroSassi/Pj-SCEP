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
            dgv_prod_order.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, txt_qtde.Text)
            clean_prod()
        Catch ex As Exception
            MsgBox("Erro | Adicionar produtos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub dgv_prod_order_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_prod_order.CellDoubleClick
        'Try
        If IsNothing(dgv_prod_order.SelectedRows) Then
                MsgBox("Erro | Nenhum item selecionado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            Else
                With dgv_prod_order
                    cmb_cat.SelectedItem = .SelectedCells(1).Value
                    txt_qtde = .SelectedCells(2).Value
                    cmb_name.SelectedItem = .SelectedCells(3).Value
                End With
            End If
            'Catch ex As Exception
        '   MsgBox("Erro | Editar item!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        'End Try
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
        cmb_cat.Focus()
    End Sub
End Class