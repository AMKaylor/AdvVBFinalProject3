Option Explicit On
Option Strict On

Public Class frmViewAllProducts
    Private mRetailer As New Retailer
    Private mProducts As New Products
    Private formLoading As Boolean = True

    Private Sub frmViewAllProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load Retailers into combobox
        With cboRetailer.ComboBox
            .DataSource = mRetailer.Retailers
            .DisplayMember = "Retailer_Name"
            .ValueMember = "RetailerId"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1
        End With

        'Load Experience into combobox
        cboExperienceLvl.Items.Add("Beginner")
        cboExperienceLvl.Items.Add("Intermediate")
        cboExperienceLvl.Items.Add("Expert")

        'Load Food Diet into combobox
        cboDiet.Items.Add("Carnivore")
        cboDiet.Items.Add("Filtering")
        cboDiet.Items.Add("Herbivore")
        cboDiet.Items.Add("Omnivore")

        'Load Type of Marine Life into combobox
        cboTypeOfLife.Items.Add("Soft Coral")
        cboTypeOfLife.Items.Add("Hard Coral")
        cboTypeOfLife.Items.Add("Fish")

        'Load Seasons into combobox
        cboSeason.Items.Add("Sp")
        cboSeason.Items.Add("Su")
        cboSeason.Items.Add("W")
        cboSeason.Items.Add("SS")
        cboSeason.Items.Add("FW")
        cboSeason.Items.Add("SSF")
        cboSeason.Items.Add("SSFW")

        dgvAllProducts.DataSource = mProducts.Items

        formLoading = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click

        dgvAllProducts.DataSource = mProducts.Items

    End Sub

    Private Sub cboRetailer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRetailer.SelectedIndexChanged

        If Not formLoading Then
            Dim RetailerId As Integer = CInt(cboRetailer.ComboBox.SelectedValue)

            dgvAllProducts.DataSource = mProducts.FilterByRetailer(RetailerId)

        End If
    End Sub
End Class