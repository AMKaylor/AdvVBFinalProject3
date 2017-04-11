Public Class frmRetailerList

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmRetailerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CALSdatabaseDataSet.RetailerTable' table. You can move, or remove it, as needed.
        Me.RetailerTableTableAdapter.Fill(Me.CALSdatabaseDataSet.RetailerTable)

    End Sub
End Class