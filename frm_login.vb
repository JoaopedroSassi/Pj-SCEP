Public Class frm_login
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_scepDataSet.address' table. You can move, or remove it, as needed.
        Me.AddressTableAdapter.Fill(Me.Db_scepDataSet.address)
        'TODO: This line of code loads data into the 'Db_scepDataSet.ordered' table. You can move, or remove it, as needed.
        Me.OrderedTableAdapter.Fill(Me.Db_scepDataSet.ordered)

    End Sub
End Class