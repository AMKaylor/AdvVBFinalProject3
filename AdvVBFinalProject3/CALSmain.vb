Public Class CALSmain
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub YourWishListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YourWishListToolStripMenuItem.Click
        frmWishList.ShowDialog()
    End Sub

    Private Sub ViewAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllToolStripMenuItem.Click
        frmRetailerList.ShowDialog()
    End Sub

    Private Sub RetailerProductListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetailerProductListToolStripMenuItem.Click
        frmRetailProductList.ShowDialog()
    End Sub

    Private Sub ViewAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewAllToolStripMenuItem1.Click
        frmViewAllProducts.ShowDialog()
    End Sub

    Private Sub PriceComparisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PriceComparisonToolStripMenuItem.Click
        frmProductPriceComparison.ShowDialog()
    End Sub

    Private Sub CALSmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
