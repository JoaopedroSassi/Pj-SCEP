Public Class frm_next_sales
    Private Sub frm_next_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_orders()
    End Sub

    Sub load_orders()
        Try
            sql = "SELECT ord.id_order, CONCAT(cl.first_name, ' ', cl.last_name) as 'Full name', cl.email, cl.landline_phone, cl.cell_phone, ord.order_date, ord.delivery_date, adr.cep FROM tb_order AS ord JOIN tb_client AS cl ON ord.client_id = cl.id_client JOIN tb_address AS adr ON cl.address_id = adr.id_address ORDER BY delivery_date"
            rs = db.Execute(sql)
            With dgv_next_sales
                .Rows.Clear()
                Do While rs.EOF = False
                    Dim today As Date = rs.Fields(6).Value
                    If today.ToString("yyyy-MM-dd") >= Date.Now.ToString("yyyy-MM-dd") Then
                        .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value)
                    End If
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar | Load Sellers!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub btn_search_address_Click(sender As Object, e As EventArgs) Handles btn_search_address.Click
        Try
            If IsNothing(dgv_next_sales.SelectedRows) Then
                MsgBox("Erro | Nenhum item selecionado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
            Else
                id_tmp = dgv_next_sales.CurrentRow.Cells(0).Value
                sql = "SELECT adr.* FROM tb_address AS adr JOIN tb_client AS cl ON adr.id_address = cl.address_id JOIN tb_order AS ord ON ord.client_id = cl.id_client WHERE ord.id_order = '" & id_tmp & "';"
                rs = db.Execute(sql)
                txt_cep.Text = rs.Fields(1).Value
                txt_city.Text = rs.Fields(2).Value
                txt_district.Text = rs.Fields(3).Value
                txt_street.Text = rs.Fields(4).Value
                txt_uf.Text = rs.Fields(5).Value
                txt_number.Text = rs.Fields(6).Value
                txt_apartment.Text = rs.Fields(7).Value
                txt_block.Text = rs.Fields(8).Value
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Buscar endereço", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
End Class