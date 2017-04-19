Option Explicit On
Option Strict On

Public Class frmViewAllProducts
    Private mRetailer As New Retailer
    Private mProducts As New Products
    Private mWishList As New Wish_List
    Private formLoading As Boolean = True

    Private Sub frmViewAllProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CALSdatabaseDataSet1.ProductTable' table. You can move, or remove it, as needed.
        Me.ProductTableTableAdapter.Fill(Me.CALSdatabaseDataSet1.ProductTable)

        'Load Retailers into combobox
        With cboRetailer.ComboBox
            .DataSource = mRetailer.Retailers
            .DisplayMember = "Retailer_Name"
            .ValueMember = "RetailerId"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1
        End With

        'Load Experience into combobox
        cboExperience.Items.Add("Beginner")
        cboExperience.Items.Add("Intermediate")
        cboExperience.Items.Add("Expert")

        'Load Food Diet into combobox
        cboFoodDiet.Items.Add("Carnivore")
        cboFoodDiet.Items.Add("Filtering")
        cboFoodDiet.Items.Add("Herbivore")
        cboFoodDiet.Items.Add("Omnivore")

        'Load Type of Marine Life into combobox
        cboTypeOfLife.Items.Add("Soft Coral")
        cboTypeOfLife.Items.Add("Hard Coral")
        cboTypeOfLife.Items.Add("Fish")

        'Load Seasons into combobox
        cboSeason.Items.Add("Spring")
        cboSeason.Items.Add("Summer")
        cboSeason.Items.Add("Winter")
        cboSeason.Items.Add("Spring/Summer")
        cboSeason.Items.Add("Fall/Winter")
        cboSeason.Items.Add("Spring/Summer/Fall")
        cboSeason.Items.Add("All Year")

        dgvAllProducts.DataSource = mProducts.Items

        formLoading = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboRetailer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRetailer.SelectedIndexChanged

        If Not formLoading Then
            Dim RetailerId As Integer = CInt(cboRetailer.ComboBox.SelectedValue)

            dgvAllProducts.DataSource = mProducts.FilterByRetailer(RetailerId)

        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        'Loops through the combobox text and picks which sql statement to run depending on what is selected.

        If cboExperience.Text = "Beginner" Then
            dgvAllProducts.DataSource = mProducts.FilterByExperienceB()
        ElseIf cboExperience.Text = "Intermediate" Then
            dgvAllProducts.DataSource = mProducts.FilterByExperienceI()
        ElseIf cboExperience.Text = "Expert" Then
            dgvAllProducts.DataSource = mProducts.FilterByExperienceE()
        Else
            dgvAllProducts.DataSource = mProducts.Items()
        End If


    End Sub

    Private Sub btnSearchDiet_Click(sender As Object, e As EventArgs) Handles btnSearchDiet.Click

        'Loops through the combobox text and picks which sql statement to run depending on what is selected.

        If cboFoodDiet.Text = "Filtering" Then
            dgvAllProducts.DataSource = mProducts.FilterByDietF()
        ElseIf cboFoodDiet.Text = "Carnivore" Then
            dgvAllProducts.DataSource = mProducts.FilterByDietC()
        ElseIf cboFoodDiet.Text = "Herbivore" Then
            dgvAllProducts.DataSource = mProducts.FilterByDietH()
        ElseIf cboFoodDiet.Text = "Omnivore" Then
            dgvAllProducts.DataSource = mProducts.FilterByDietO()
        Else
            dgvAllProducts.DataSource = mProducts.Items()
        End If

    End Sub

    Private Sub btnSearchSeason_Click(sender As Object, e As EventArgs) Handles btnSearchSeason.Click

        'Loops through the combobox text and picks which sql statement to run depending on what is selected.

        If cboSeason.Text = "Spring" Then
            dgvAllProducts.DataSource = mProducts.FilterBySeasonSP()
        ElseIf cboSeason.Text = "Summer" Then
            dgvAllProducts.DataSource = mProducts.FilterBySeasonSU()
        ElseIf cboSeason.Text = "Winter" Then
            dgvAllProducts.DataSource = mProducts.FilterBySeasonW()
        ElseIf cboSeason.Text = "Spring/Summer" Then
            dgvAllProducts.DataSource = mProducts.FilterBySeasonSS()
        ElseIf cboSeason.Text = "Fall/Winter" Then
            dgvAllProducts.DataSource = mProducts.FilterBySeasonFW()
        ElseIf cboSeason.Text = "Spring/Summer/Fall" Then
            dgvAllProducts.DataSource = mProducts.FilterBySeasonSSF()
        ElseIf cboSeason.Text = "All Year" Then
            dgvAllProducts.DataSource = mProducts.FilterBySeasonAll()
        Else
            dgvAllProducts.DataSource = mProducts.Items()
        End If

    End Sub

    Private Sub btnSearchMarineLife_Click(sender As Object, e As EventArgs) Handles btnSearchMarineLife.Click

        'Loops through the combobox text and picks which sql statement to run depending on what is selected.

        If cboTypeOfLife.Text = "Soft Coral" Then
            dgvAllProducts.DataSource = mProducts.FilterByMarineLifeS()
        ElseIf cboTypeOfLife.Text = "Hard Coral" Then
            dgvAllProducts.DataSource = mProducts.FilterByMarineLifeH()
        ElseIf cboTypeOfLife.Text = "Fish" Then
            dgvAllProducts.DataSource = mProducts.FilterByMarineLifeF()
        Else
            dgvAllProducts.DataSource = mProducts.Items()
        End If

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click

        dgvAllProducts.DataSource = mProducts.Items()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        If dgvAllProducts.SelectedRows.Count > 0 Then

            Dim ProductId As Short = CShort(dgvAllProducts.SelectedRows(0).Cells(0).Value)
            Dim adapter As New CALSdatabaseDataSetTableAdapters.WishlistTableTableAdapter

            If CBool(adapter.InsertQueryToWishlist(ProductId)) Then

                MessageBox.Show("Product added to Wishlist.")

            Else

                MessageBox.Show("Unable to add Product.")

            End If
        End If

    End Sub
End Class