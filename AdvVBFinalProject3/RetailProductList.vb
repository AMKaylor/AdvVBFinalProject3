Option Explicit On
Option Strict On

Public Class frmRetailProductList
    Private mRetailer As New Retailer
    Private mProducts As New Products
    Private formLoading As Boolean = True

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmRetailProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load Retailers into combobox
        With cboRetailer.ComboBox
            .DataSource = mRetailer.Retailers
            .DisplayMember = "Retailer_Name"
            .ValueMember = "RetailerId"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1
        End With

        dgvRetailer.DataSource = mProducts.Items()

        formLoading = False

    End Sub

    Private Sub cboRetailer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRetailer.SelectedIndexChanged

        If Not formLoading Then
            Dim RetailerId As Integer = CInt(cboRetailer.ComboBox.SelectedValue)

            dgvRetailer.DataSource = mProducts.FilterByRetailer(RetailerId)

        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If dgvRetailer.SelectedRows.Count > 0 Then

            Dim ProductId As Short = CShort(dgvRetailer.SelectedRows(0).Cells(0).Value)
            Dim adapter As New CALSdatabaseDataSetTableAdapters.WishlistTableTableAdapter

            If CBool(adapter.InsertQueryToWishlist(ProductId)) Then

                MessageBox.Show("Product added to Wishlist.")

            Else

                MessageBox.Show("Unable to add Product.")

            End If
        End If

    End Sub
End Class