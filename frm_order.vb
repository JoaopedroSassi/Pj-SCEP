Imports System.Windows.Forms
Imports iText.IO.Font.Constants
Imports iText.Kernel.Font
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports System.Net.Mail
Imports iText.Kernel.Colors
Imports HorizontalAlignment = System.Windows.Forms.HorizontalAlignment
Imports iText.Layout.Borders

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
                txt_cep.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro | Resgatar endereço pelo cep", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub cmb_cat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cat.SelectedIndexChanged
        Try
            cmb_name.ResetText()
            cmb_name.Items.Clear()
            sql = "SELECT * FROM tb_products WHERE category = '" & cmb_cat.Text & "' AND amount > 0 ORDER BY name ASC"
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
                create_pdf()
                send_email()
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

                sql = "SELECT * FROM tb_products WHERE id_prod = '" & item.Cells(0).Value & "'"
                rs = db.Execute(sql)
                final_amount = rs.Fields(3).Value - item.Cells(3).Value

                sql = "UPDATE tb_products SET amount = '" & final_amount & "' WHERE id_prod = '" & item.Cells(0).Value & "'"
                rs = db.Execute(sql)
            Next
        Catch ex As Exception
            MsgBox("Erro ao processar | Cadastrar items pedido", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub clean_order()
        Try
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
        Catch ex As Exception
            MsgBox("Erro ao processar | Limpar pedido", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Try
            sql = "SELECT * FROM tb_client WHERE cpf = '" & txt_cpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                txt_first_name.Text = rs.Fields(2).Value
                txt_last_name.Text = rs.Fields(3).Value
                txt_email.Text = rs.Fields(4).Value
                txt_landline_phone.Text = rs.Fields(5).Value
                txt_cell_phone.Text = rs.Fields(6).Value
                txt_cep.Focus()
            Else
                txt_first_name.Focus()
            End If
        Catch ex As Exception
            MsgBox("Erro ao processar | Buscar cliente cpf", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub create_pdf()
        Try
            Dim archive = "C:\Users\joaop\Documents\Estudos\Fatec\projetos_fatec\2_semestre\scep\pdf\pedido" & id_order & ".pdf"

            Using wPdf = New PdfWriter(archive, New WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0))
                Dim pdf_document = New PdfDocument(wPdf)

                Dim document = New Document(pdf_document)
                Dim p1 = New Paragraph().SetBold
                p1.SetFontSize(25)
                p1.SetTextAlignment(TextAlignment.CENTER)
                p1.Add("Pedido N°" & id_order)

                document.Add(p1)

                Dim p2 = New Paragraph()
                p2.SetFontSize(18)
                p2.SetTextAlignment(TextAlignment.CENTER)
                p2.Add("Dados do cliente:")
                document.Add(p2)

                document.Add(New Paragraph("CPF: " & txt_cpf.Text))
                document.Add(New Paragraph("Cliente: " & txt_first_name.Text + " " + txt_last_name.Text))
                document.Add(New Paragraph("Email: " & txt_email.Text))
                document.Add(New Paragraph("Telefone residencial: " & txt_landline_phone.Text))
                document.Add(New Paragraph("Telefone celular: " & txt_cell_phone.Text))

                document.Add(New Paragraph(vbNewLine))

                Dim p3 = New Paragraph()
                p3.SetFontSize(18)
                p3.SetTextAlignment(TextAlignment.CENTER)
                p3.Add("Dados do endereço:")
                document.Add(p3)

                document.Add(New Paragraph("CEP: " & txt_cep.Text))
                document.Add(New Paragraph("Cidade: " & txt_city.Text))
                document.Add(New Paragraph("Bairro: " & txt_district.Text))
                document.Add(New Paragraph("Rua: " & txt_street.Text))
                document.Add(New Paragraph("UF: " & txt_uf.Text))
                document.Add(New Paragraph("Número: " & txt_number.Text))
                If txt_apartment.Text.Length > 0 Then
                    document.Add(New Paragraph("Apartamento: " & txt_apartment.Text))
                Else
                    document.Add(New Paragraph("Apartamento: ---"))
                End If
                If txt_block.Text.Length > 0 Then
                    document.Add(New Paragraph("Bloco: " & txt_block.Text))
                Else
                    document.Add(New Paragraph("Bloco: ---"))
                End If

                document.Add(New Paragraph(vbNewLine))

                Dim p4 = New Paragraph()
                p4.SetFontSize(18)
                p4.SetTextAlignment(TextAlignment.CENTER)
                p4.Add("Dados do pedido:")
                document.Add(p4)

                document.Add(New Paragraph("Método de pagamento: " & cmb_method.Text))
                document.Add(New Paragraph("Vendedor: " & name_sell_log))
                document.Add(New Paragraph("Data do pedido: " & DateTime.Now))

                Dim columnWidth As Single() = {10, 40, 30, 10, 20, 20}

                Dim tabela = New Table(UnitValue.CreatePercentArray(columnWidth)).UseAllAvailableWidth()
                tabela.SetHorizontalAlignment(HorizontalAlignment.Center)

                Dim fonte = PdfFontFactory.CreateFont(StandardFonts.HELVETICA)

                tabela.AddHeaderCell(New Cell(1, 6).Add(New Paragraph("Tabela de produtos").SetFont(fonte).SetBorder(Border.NO_BORDER).SetFontSize(19).SetPadding(10).SetFontColor(ColorConstants.WHITE).SetBackgroundColor(ColorConstants.BLUE).SetTextAlignment(TextAlignment.CENTER)))

                tabela.AddHeaderCell(New Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.WHITE).SetFontColor(ColorConstants.BLUE).Add(New Paragraph("Id")))
                tabela.AddHeaderCell(New Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.WHITE).SetFontColor(ColorConstants.BLUE).Add(New Paragraph("Nome")))
                tabela.AddHeaderCell(New Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.WHITE).SetFontColor(ColorConstants.BLUE).Add(New Paragraph("Cateogira")))
                tabela.AddHeaderCell(New Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.WHITE).SetFontColor(ColorConstants.BLUE).Add(New Paragraph("Qtd")))
                tabela.AddHeaderCell(New Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.WHITE).SetFontColor(ColorConstants.BLUE).Add(New Paragraph("Preço - Unit")))
                tabela.AddHeaderCell(New Cell().SetTextAlignment(TextAlignment.CENTER).SetBackgroundColor(ColorConstants.WHITE).SetFontColor(ColorConstants.BLUE).Add(New Paragraph("Preço - Total")))

                For Each item As DataGridViewRow In dgv_prod_order.Rows
                    tabela.AddCell(New Cell().SetTextAlignment(TextAlignment.CENTER).Add(New Paragraph(item.Cells(0).Value.ToString)))

                    tabela.AddCell(New Cell().Add(New Paragraph(item.Cells(1).Value.ToString)))

                    tabela.AddCell(New Cell().Add(New Paragraph(item.Cells(2).Value.ToString)))

                    tabela.AddCell(New Cell().SetTextAlignment(TextAlignment.CENTER).Add(New Paragraph(item.Cells(3).Value.ToString)))

                    tabela.AddCell(New Cell().SetTextAlignment(TextAlignment.LEFT).Add(New Paragraph("R$" & item.Cells(4).Value.ToString)))

                    tabela.AddCell(New Cell().SetTextAlignment(TextAlignment.LEFT).Add(New Paragraph("R$" & final_price.ToString)))
                Next

                document.Add(tabela)

                document.Add(New Paragraph(vbNewLine))

                document.Add(New Paragraph("______________________________________________________________________________").SetFontColor(ColorConstants.YELLOW))

                document.Close()
                pdf_document.Close()
            End Using
        Catch ex As Exception
            MsgBox("Erro ao processar | Gerar pdf", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Sub send_email()
        Try
            Using smtp As New SmtpClient
                Using email As New MailMessage()

                    smtp.Host = "smtp.gmail.com"
                    smtp.UseDefaultCredentials = False
                    smtp.Credentials = New Net.NetworkCredential("pj.scep@gmail.com", "moquidesia")
                    smtp.Port = 587
                    smtp.EnableSsl = True

                    email.From = New MailAddress("pj.scep@gmail.com")
                    email.To.Add(txt_email.Text)
                    email.Subject = "Pedido N°" & id_order
                    email.IsBodyHtml = False
                    email.Body = "Olá! Ficamos muito felizes que tenha feito negócios consoco. Em anexo está a cópia do pedido. Obrigado pela preferência!"
                    email.Attachments.Add(New Attachment("C:\Users\joaop\Documents\Estudos\Fatec\projetos_fatec\2_semestre\scep\pdf\pedido" & id_order & ".pdf"))

                    smtp.Send(email)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Erro ao processar | Enviar email", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Aviso")
        End Try
    End Sub

    Private Sub txt_number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_number.KeyPress
        only_number(sender, e)
    End Sub

    Private Sub txt_qtde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qtde.KeyPress
        only_number(sender, e)
    End Sub

    Private Sub txt_price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_price.KeyPress
        only_number(sender, e)
    End Sub
End Class