Public Class frmViewAllProducts

    Private Sub frmViewAllProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CALSdatabaseDataSet.ProductTable' table. You can move, or remove it, as needed.
        Me.ProductTableTableAdapter.Fill(Me.CALSdatabaseDataSet.ProductTable)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class