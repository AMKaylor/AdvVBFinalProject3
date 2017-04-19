Option Explicit On
Option Strict On

Public Class frmWishList
    Private mRetailer As New Retailer
    Private mProducts As New Products
    Private mWishList As New Wish_List
    Private formLoading As Boolean = True

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmWishList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CALSdatabaseDataSet.WishlistTable' table. You can move, or remove it, as needed.
        Me.WishlistTableTableAdapter.Fill(Me.CALSdatabaseDataSet.WishlistTable)

        With cboRetailer
            .DataSource = mRetailer.Retailers()
            .DisplayMember = "Retailer_Name"
            .ValueMember = "RetailerId"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1
        End With

        dgvWishList.DataSource = mWishList.Items()

        formLoading = False

    End Sub

    Private Sub cboRetailer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRetailer.SelectedIndexChanged

        If Not formLoading Then
            Dim RetailerId As Integer = CInt(cboRetailer.SelectedValue)

            dgvWishList.DataSource = mWishList.FilterByRetailer(cboRetailer.SelectedIndex)

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvWishList.SelectedRows.Count > 0 Then

            Dim ProductId As Short = CShort(dgvWishList.SelectedRows(0).Cells(0).Value)

            If mWishList.Delete(ProductId) Then

                dgvWishList.DataSource = mWishList.Items()
                MessageBox.Show("Delete successful.")
            Else

                MessageBox.Show("Unable to delete this item.")

            End If
        End If

    End Sub
End Class