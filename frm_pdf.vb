Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element

Public Class frm_pdf

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "SELECT id_order FROM tb_order WHERE id_order = '" & txt_search.Text & "'"
        rs = db.Execute(sql)


    End Sub
End Class