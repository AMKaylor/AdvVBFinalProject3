<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewAllProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewAllProducts))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAllProducts = New System.Windows.Forms.DataGridView()
        Me.ProductTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CALSdatabaseDataSet1 = New AdvVBFinalProject3.CALSdatabaseDataSet()
        Me.cboTypeOfLife = New System.Windows.Forms.ComboBox()
        Me.cboSeason = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboRetailer = New System.Windows.Forms.ToolStripComboBox()
        Me.btnAddToWishlist = New System.Windows.Forms.ToolStripButton()
        Me.cboFoodDiet = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboExperience = New System.Windows.Forms.ComboBox()
        Me.Legend = New System.Windows.Forms.GroupBox()
        Me.grpExperience = New System.Windows.Forms.GroupBox()
        Me.btnSearchDiet = New System.Windows.Forms.Button()
        Me.grpFoodDiet = New System.Windows.Forms.GroupBox()
        Me.btnSearchSeason = New System.Windows.Forms.Button()
        Me.btnSearchMarineLife = New System.Windows.Forms.Button()
        Me.grpSeason = New System.Windows.Forms.GroupBox()
        Me.grpMarineLife = New System.Windows.Forms.GroupBox()
        Me.CALSdatabaseDataSet = New AdvVBFinalProject3.CALSdatabaseDataSet()
        Me.ProductTableTableAdapter = New AdvVBFinalProject3.CALSdatabaseDataSetTableAdapters.ProductTableTableAdapter()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarineTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExperienceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodDietDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvAllProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CALSdatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Legend.SuspendLayout()
        Me.grpExperience.SuspendLayout()
        Me.grpFoodDiet.SuspendLayout()
        Me.grpSeason.SuspendLayout()
        Me.grpMarineLife.SuspendLayout()
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAllProducts
        '
        Me.dgvAllProducts.AllowUserToAddRows = False
        Me.dgvAllProducts.AllowUserToDeleteRows = False
        Me.dgvAllProducts.AutoGenerateColumns = False
        Me.dgvAllProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvAllProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductNameDataGridViewTextBoxColumn, Me.MarineTypeDataGridViewTextBoxColumn, Me.ExperienceDataGridViewTextBoxColumn, Me.SeasonDataGridViewTextBoxColumn, Me.FoodDietDataGridViewTextBoxColumn, Me.RetailerNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.dgvAllProducts.DataSource = Me.ProductTableBindingSource
        Me.dgvAllProducts.Location = New System.Drawing.Point(43, 149)
        Me.dgvAllProducts.Name = "dgvAllProducts"
        Me.dgvAllProducts.ReadOnly = True
        Me.dgvAllProducts.Size = New System.Drawing.Size(783, 289)
        Me.dgvAllProducts.TabIndex = 1
        '
        'ProductTableBindingSource
        '
        Me.ProductTableBindingSource.DataMember = "ProductTable"
        Me.ProductTableBindingSource.DataSource = Me.CALSdatabaseDataSet1
        '
        'CALSdatabaseDataSet1
        '
        Me.CALSdatabaseDataSet1.DataSetName = "CALSdatabaseDataSet"
        Me.CALSdatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboTypeOfLife
        '
        Me.cboTypeOfLife.BackColor = System.Drawing.SystemColors.Window
        Me.cboTypeOfLife.FormattingEnabled = True
        Me.cboTypeOfLife.Location = New System.Drawing.Point(10, 23)
        Me.cboTypeOfLife.Name = "cboTypeOfLife"
        Me.cboTypeOfLife.Size = New System.Drawing.Size(122, 23)
        Me.cboTypeOfLife.TabIndex = 5
        '
        'cboSeason
        '
        Me.cboSeason.BackColor = System.Drawing.SystemColors.Window
        Me.cboSeason.FormattingEnabled = True
        Me.cboSeason.Location = New System.Drawing.Point(15, 20)
        Me.cboSeason.Name = "cboSeason"
        Me.cboSeason.Size = New System.Drawing.Size(122, 23)
        Me.cboSeason.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Info
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(434, 46)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Su -Summer,  Sp -Spring,  W -Winter,  SS - Spring/Summer,  FW -Fall/Winter,  SSF " &
    "- Spring/Summer/Fall,  SSFW -Spring/Summer/Fall/Winter"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExit, Me.btnAll, Me.ToolStripLabel1, Me.cboRetailer, Me.btnAddToWishlist})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(895, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(29, 22)
        Me.btnExit.Text = "Exit"
        '
        'btnAll
        '
        Me.btnAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAll.Image = CType(resources.GetObject("btnAll.Image"), System.Drawing.Image)
        Me.btnAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(89, 22)
        Me.btnAll.Text = "Show All Items"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel1.Text = "Specific Retailer:"
        '
        'cboRetailer
        '
        Me.cboRetailer.Name = "cboRetailer"
        Me.cboRetailer.Size = New System.Drawing.Size(121, 25)
        '
        'btnAddToWishlist
        '
        Me.btnAddToWishlist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAddToWishlist.Image = CType(resources.GetObject("btnAddToWishlist.Image"), System.Drawing.Image)
        Me.btnAddToWishlist.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddToWishlist.Name = "btnAddToWishlist"
        Me.btnAddToWishlist.Size = New System.Drawing.Size(91, 22)
        Me.btnAddToWishlist.Text = "Add to Wishlist"
        '
        'cboFoodDiet
        '
        Me.cboFoodDiet.FormattingEnabled = True
        Me.cboFoodDiet.Location = New System.Drawing.Point(13, 19)
        Me.cboFoodDiet.Name = "cboFoodDiet"
        Me.cboFoodDiet.Size = New System.Drawing.Size(121, 23)
        Me.cboFoodDiet.TabIndex = 16
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(37, 50)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cboExperience
        '
        Me.cboExperience.FormattingEnabled = True
        Me.cboExperience.Location = New System.Drawing.Point(14, 21)
        Me.cboExperience.Name = "cboExperience"
        Me.cboExperience.Size = New System.Drawing.Size(121, 23)
        Me.cboExperience.TabIndex = 19
        '
        'Legend
        '
        Me.Legend.Controls.Add(Me.Label3)
        Me.Legend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Legend.Location = New System.Drawing.Point(13, 456)
        Me.Legend.Name = "Legend"
        Me.Legend.Size = New System.Drawing.Size(451, 77)
        Me.Legend.TabIndex = 20
        Me.Legend.TabStop = False
        Me.Legend.Text = "Legend"
        '
        'grpExperience
        '
        Me.grpExperience.Controls.Add(Me.cboExperience)
        Me.grpExperience.Controls.Add(Me.btnSearch)
        Me.grpExperience.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpExperience.Location = New System.Drawing.Point(440, 39)
        Me.grpExperience.Name = "grpExperience"
        Me.grpExperience.Size = New System.Drawing.Size(152, 84)
        Me.grpExperience.TabIndex = 21
        Me.grpExperience.TabStop = False
        Me.grpExperience.Text = "Experience"
        '
        'btnSearchDiet
        '
        Me.btnSearchDiet.Location = New System.Drawing.Point(35, 48)
        Me.btnSearchDiet.Name = "btnSearchDiet"
        Me.btnSearchDiet.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchDiet.TabIndex = 22
        Me.btnSearchDiet.Text = "Search"
        Me.btnSearchDiet.UseVisualStyleBackColor = True
        '
        'grpFoodDiet
        '
        Me.grpFoodDiet.Controls.Add(Me.btnSearchDiet)
        Me.grpFoodDiet.Controls.Add(Me.cboFoodDiet)
        Me.grpFoodDiet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFoodDiet.Location = New System.Drawing.Point(623, 41)
        Me.grpFoodDiet.Name = "grpFoodDiet"
        Me.grpFoodDiet.Size = New System.Drawing.Size(147, 81)
        Me.grpFoodDiet.TabIndex = 23
        Me.grpFoodDiet.TabStop = False
        Me.grpFoodDiet.Text = "Food Diet"
        '
        'btnSearchSeason
        '
        Me.btnSearchSeason.Location = New System.Drawing.Point(38, 48)
        Me.btnSearchSeason.Name = "btnSearchSeason"
        Me.btnSearchSeason.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchSeason.TabIndex = 23
        Me.btnSearchSeason.Text = "Search"
        Me.btnSearchSeason.UseVisualStyleBackColor = True
        '
        'btnSearchMarineLife
        '
        Me.btnSearchMarineLife.Location = New System.Drawing.Point(33, 50)
        Me.btnSearchMarineLife.Name = "btnSearchMarineLife"
        Me.btnSearchMarineLife.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchMarineLife.TabIndex = 24
        Me.btnSearchMarineLife.Text = "Search"
        Me.btnSearchMarineLife.UseVisualStyleBackColor = True
        '
        'grpSeason
        '
        Me.grpSeason.Controls.Add(Me.btnSearchSeason)
        Me.grpSeason.Controls.Add(Me.cboSeason)
        Me.grpSeason.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSeason.Location = New System.Drawing.Point(253, 41)
        Me.grpSeason.Name = "grpSeason"
        Me.grpSeason.Size = New System.Drawing.Size(150, 81)
        Me.grpSeason.TabIndex = 25
        Me.grpSeason.TabStop = False
        Me.grpSeason.Text = "Season"
        '
        'grpMarineLife
        '
        Me.grpMarineLife.Controls.Add(Me.btnSearchMarineLife)
        Me.grpMarineLife.Controls.Add(Me.cboTypeOfLife)
        Me.grpMarineLife.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMarineLife.Location = New System.Drawing.Point(63, 41)
        Me.grpMarineLife.Name = "grpMarineLife"
        Me.grpMarineLife.Size = New System.Drawing.Size(145, 83)
        Me.grpMarineLife.TabIndex = 26
        Me.grpMarineLife.TabStop = False
        Me.grpMarineLife.Text = "Type of Marine Life"
        '
        'CALSdatabaseDataSet
        '
        Me.CALSdatabaseDataSet.DataSetName = "CALSdatabaseDataSet"
        Me.CALSdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableTableAdapter
        '
        Me.ProductTableTableAdapter.ClearBeforeFill = True
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarineTypeDataGridViewTextBoxColumn
        '
        Me.MarineTypeDataGridViewTextBoxColumn.DataPropertyName = "Marine_Type"
        Me.MarineTypeDataGridViewTextBoxColumn.HeaderText = "Marine_Type"
        Me.MarineTypeDataGridViewTextBoxColumn.Name = "MarineTypeDataGridViewTextBoxColumn"
        Me.MarineTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExperienceDataGridViewTextBoxColumn
        '
        Me.ExperienceDataGridViewTextBoxColumn.DataPropertyName = "Experience"
        Me.ExperienceDataGridViewTextBoxColumn.HeaderText = "Experience"
        Me.ExperienceDataGridViewTextBoxColumn.Name = "ExperienceDataGridViewTextBoxColumn"
        Me.ExperienceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SeasonDataGridViewTextBoxColumn
        '
        Me.SeasonDataGridViewTextBoxColumn.DataPropertyName = "Season"
        Me.SeasonDataGridViewTextBoxColumn.HeaderText = "Season"
        Me.SeasonDataGridViewTextBoxColumn.Name = "SeasonDataGridViewTextBoxColumn"
        Me.SeasonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FoodDietDataGridViewTextBoxColumn
        '
        Me.FoodDietDataGridViewTextBoxColumn.DataPropertyName = "Food_Diet"
        Me.FoodDietDataGridViewTextBoxColumn.HeaderText = "Food_Diet"
        Me.FoodDietDataGridViewTextBoxColumn.Name = "FoodDietDataGridViewTextBoxColumn"
        Me.FoodDietDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RetailerNameDataGridViewTextBoxColumn
        '
        Me.RetailerNameDataGridViewTextBoxColumn.DataPropertyName = "Retailer_Name"
        Me.RetailerNameDataGridViewTextBoxColumn.HeaderText = "Retailer_Name"
        Me.RetailerNameDataGridViewTextBoxColumn.Name = "RetailerNameDataGridViewTextBoxColumn"
        Me.RetailerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmViewAllProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 545)
        Me.Controls.Add(Me.grpMarineLife)
        Me.Controls.Add(Me.grpSeason)
        Me.Controls.Add(Me.grpFoodDiet)
        Me.Controls.Add(Me.grpExperience)
        Me.Controls.Add(Me.Legend)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvAllProducts)
        Me.Name = "frmViewAllProducts"
        Me.Text = "View All Products"
        CType(Me.dgvAllProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CALSdatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Legend.ResumeLayout(False)
        Me.grpExperience.ResumeLayout(False)
        Me.grpFoodDiet.ResumeLayout(False)
        Me.grpSeason.ResumeLayout(False)
        Me.grpMarineLife.ResumeLayout(False)
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAllProducts As DataGridView
    Friend WithEvents cboTypeOfLife As ComboBox
    Friend WithEvents cboSeason As ComboBox
    Friend WithEvents CALSdatabaseDataSet As CALSdatabaseDataSet
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cboRetailer As ToolStripComboBox
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents btnAll As ToolStripButton
    Friend WithEvents btnAddToWishlist As ToolStripButton
    Friend WithEvents cboFoodDiet As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents CALSdatabaseDataSet1 As CALSdatabaseDataSet
    Friend WithEvents ProductTableBindingSource As BindingSource
    Friend WithEvents ProductTableTableAdapter As CALSdatabaseDataSetTableAdapters.ProductTableTableAdapter
    Friend WithEvents cboExperience As ComboBox
    Friend WithEvents Legend As GroupBox
    Friend WithEvents grpExperience As GroupBox
    Friend WithEvents btnSearchDiet As Button
    Friend WithEvents grpFoodDiet As GroupBox
    Friend WithEvents btnSearchSeason As Button
    Friend WithEvents btnSearchMarineLife As Button
    Friend WithEvents grpSeason As GroupBox
    Friend WithEvents grpMarineLife As GroupBox
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarineTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExperienceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodDietDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RetailerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
