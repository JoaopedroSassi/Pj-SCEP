Public Class frm_next_sales
    Private Sub frm_next_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_orders()
    End Sub

    Sub load_orders()
        Try
            sql = "SELECT ord.id_order, CONCAT(cl.first_name, ' ', cl.last_name) as 'Full name', cl.email, cl.landline_phone, cl.cell_phone, ord.order_date, ord.delivery_date, adr.cep FROM tb_order AS ord JOIN tb_client AS cl ON ord.client_id = cl.id_client JOIN tb_address AS adr ON cl.address_id = adr.id_address;"
            rs = db.Execute(sql)
            With dgv_orders
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar | Load Sellers!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub
End Class