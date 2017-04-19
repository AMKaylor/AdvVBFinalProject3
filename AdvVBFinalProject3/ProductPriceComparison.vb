Option Explicit On
Option Strict On

Public Class frmProductPriceComparison

    Private mRetailer As New Retailer
    Private mProducts As New Products
    Private formLoading As Boolean = True

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmProductPriceComparison_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load retailer names into combo boxes (1st box)
        With cboRetailer1
            .DataSource = mRetailer.Retailers
            .DisplayMember = "Retailer_Name"
            .ValueMember = "RetailerId"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1
        End With

        'Load retailer names into combo boxes (2nd box)
        With cboRetailer2
            .DataSource = mRetailer.Retailers
            .DisplayMember = "Retailer_Name"
            .ValueMember = "RetailerId"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1
        End With

        formLoading = False

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'House cleaning

        lblPriceDifference.Text = ""

        cboRetailer1.SelectedIndex = -1
        cboRetailer2.SelectedIndex = -1
        cboComparedItem.SelectedIndex = -1
        cboComparedItem.Enabled = False
        cboComparedItem2.SelectedIndex = -1
        cboComparedItem2.Enabled = False

    End Sub

    Private Sub cboRetailer2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRetailer2.SelectedIndexChanged

        If cboRetailer2.SelectedIndex > -1 Then
            cboComparedItem2.Enabled = True

            With cboComparedItem2
                .DataSource = mProducts.GetDataByRetailerForComparison(cboRetailer2.SelectedIndex)
                .DisplayMember = "Product_Name"
                .ValueMember = "ProductId"
                .DropDownStyle = ComboBoxStyle.DropDownList
                .SelectedIndex = -1
            End With

        Else
            cboComparedItem2.Enabled = False
        End If


    End Sub

    Private Sub cboRetailer1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRetailer1.SelectedIndexChanged

        If cboRetailer1.SelectedIndex > -1 Then
            cboComparedItem.Enabled = True

            With cboComparedItem
                .DataSource = mProducts.GetDataByRetailerForComparison(cboRetailer1.SelectedIndex)
                .DisplayMember = "Product_Name"
                .ValueMember = "ProductId"
                .DropDownStyle = ComboBoxStyle.DropDownList
                .SelectedIndex = -1
            End With

        Else
            cboComparedItem.Enabled = False
        End If

    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click

        Dim total As Decimal
        Dim compared1 As Decimal
        Dim compared2 As Decimal

        'compared1 = mProducts.GetDataByComparedPrice(cboComparedItem.SelectedIndex)
        'compared2 = mProducts.GetDataByComparedPrice(cboComparedItem2.SelectedIndex)

        total = compared1 - compared2


    End Sub
End Class