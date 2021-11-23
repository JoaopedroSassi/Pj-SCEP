Public Class frm_select_order

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Try
            sql = "SELECT * FROM tb_client AS cl JOIN tb_order AS ord ON ord.client_id = cl.id_client JOIN tb_order_product AS ord_prod ON ord_prod.order_id = ord.id_order JOIN tb_products AS prod ON prod.id_prod = ord_prod.prod_id JOIN tb_login AS log ON ord.sellers_id = log.id_login JOIN tb_address AS addr ON cl.address_id = addr.id_address WHERE id_order = '" & txt_search.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                txt_cpf.Text = rs.Fields(1).Value
                txt_first_name.Text = rs.Fields(2).Value
                txt_last_name.Text = rs.Fields(3).Value
                txt_email.Text = rs.Fields(4).Value
                txt_landline_phone.Text = rs.Fields(5).Value
                txt_cell_phone.Text = rs.Fields(6).Value
                txt_date.Text = rs.Fields(9).Value
                cmb_method.SelectedItem = rs.Fields(10).Value
                txt_seller.Text = rs.Fields(25).Value + " " + rs.Fields(26).Value
                txt_cep.Text = rs.Fields(32).Value
                txt_city.Text = rs.Fields(33).Value
                txt_district.Text = rs.Fields(34).Value
                txt_street.Text = rs.Fields(35).Value
                txt_uf.Text = rs.Fields(36).Value
                txt_number.Text = rs.Fields(37).Value
                txt_apartment.Text = rs.Fields(38).Value
                txt_block.Text = rs.Fields(39).Value

                With dgv_prod_order
                    .Rows.Clear()
                    Do While rs.EOF = False
                        .Rows.Add(rs.Fields(18).Value, rs.Fields(19).Value, rs.Fields(20).Value, rs.Fields(14).Value, rs.Fields(22).Value)
                        rs.MoveNext()
                    Loop
                End With

            Else
                MsgBox("Erro | Pedido não encontrado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Busca Pedido!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

End Class