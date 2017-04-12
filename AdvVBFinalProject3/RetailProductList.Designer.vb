<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRetailProductList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetailerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboRetailer = New System.Windows.Forms.ToolStripComboBox()
        Me.AddToWishlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.dgvRetailer = New System.Windows.Forms.DataGridView()
        Me.ProductTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CALSdatabaseDataSet = New AdvVBFinalProject3.CALSdatabaseDataSet()
        Me.ProductTableTableAdapter = New AdvVBFinalProject3.CALSdatabaseDataSetTableAdapters.ProductTableTableAdapter()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarineTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExperienceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodDietDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvRetailer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.RetailerToolStripMenuItem, Me.cboRetailer, Me.AddToWishlistToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(778, 27)
        Me.MenuStrip1.TabIndex = 0
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RetailerToolStripMenuItem
        '
        Me.RetailerToolStripMenuItem.Name = "RetailerToolStripMenuItem"
        Me.RetailerToolStripMenuItem.Size = New System.Drawing.Size(61, 23)
        Me.RetailerToolStripMenuItem.Text = "Retailer:"
        '
        'cboRetailer
        '
        Me.cboRetailer.Name = "cboRetailer"
        Me.cboRetailer.Size = New System.Drawing.Size(121, 23)
        '
        'AddToWishlistToolStripMenuItem
        '
        Me.AddToWishlistToolStripMenuItem.Name = "AddToWishlistToolStripMenuItem"
        Me.AddToWishlistToolStripMenuItem.Size = New System.Drawing.Size(99, 23)
        Me.AddToWishlistToolStripMenuItem.Text = "Add to Wishlist"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 397)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(778, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'dgvRetailer
        '
        Me.dgvRetailer.AllowUserToAddRows = False
        Me.dgvRetailer.AllowUserToDeleteRows = False
        Me.dgvRetailer.AutoGenerateColumns = False
        Me.dgvRetailer.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvRetailer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRetailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRetailer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductNameDataGridViewTextBoxColumn, Me.MarineTypeDataGridViewTextBoxColumn, Me.ExperienceDataGridViewTextBoxColumn, Me.SeasonDataGridViewTextBoxColumn, Me.FoodDietDataGridViewTextBoxColumn, Me.RetailerNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.dgvRetailer.DataSource = Me.ProductTableBindingSource
        Me.dgvRetailer.Location = New System.Drawing.Point(12, 54)
        Me.dgvRetailer.Name = "dgvRetailer"
        Me.dgvRetailer.ReadOnly = True
        Me.dgvRetailer.Size = New System.Drawing.Size(738, 322)
        Me.dgvRetailer.TabIndex = 2
        '
        'ProductTableBindingSource
        '
        Me.ProductTableBindingSource.DataMember = "ProductTable"
        Me.ProductTableBindingSource.DataSource = Me.CALSdatabaseDataSet
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
        'frmRetailProductList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 419)
        Me.Controls.Add(Me.dgvRetailer)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRetailProductList"
        Me.Text = "Retail Product List"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvRetailer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents dgvRetailer As DataGridView
    Friend WithEvents AddToWishlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetailerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboRetailer As ToolStripComboBox
    Friend WithEvents CALSdatabaseDataSet As CALSdatabaseDataSet
    Friend WithEvents ProductTableBindingSource As BindingSource
    Friend WithEvents ProductTableTableAdapter As CALSdatabaseDataSetTableAdapters.ProductTableTableAdapter
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarineTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExperienceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodDietDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RetailerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
