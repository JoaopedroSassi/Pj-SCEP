Public Class frm_select_prod
    Private Sub frm_selec_prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_prod()
        cmb_cat.SelectedIndex = 0
    End Sub

    Sub load_prod()
        Try
            sql = "SELECT * FROM tb_products ORDER BY id_prod"
            rs = db.Execute(sql)
            With dgv_prod
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar | Load produtos!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try
            load_category()
            sql = "SELECT * FROM tb_products WHERE " & aux_cmb & " LIKE '" & txt_search.Text & "%' ORDER BY id_prod ASC"
            rs = db.Execute(sql)
            With dgv_prod
                cont = 1
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                    cont += 1
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar | Busca produtos!!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub load_category()
        If cmb_cat.SelectedIndex = 0 Then
            aux_cmb = "id_prod"
        ElseIf cmb_cat.SelectedIndex = 1 Then
            aux_cmb = "name"
        Else
            aux_cmb = "category"
        End If
    End Sub
End Class