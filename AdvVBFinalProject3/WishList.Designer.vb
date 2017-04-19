<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWishList
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
        Me.dgvWishList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboRetailer = New System.Windows.Forms.ComboBox()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.WishlistTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CALSdatabaseDataSet = New AdvVBFinalProject3.CALSdatabaseDataSet()
        Me.WishlistTableTableAdapter = New AdvVBFinalProject3.CALSdatabaseDataSetTableAdapters.WishlistTableTableAdapter()
        Me.ProductIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarineTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExperienceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodDietDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvWishList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.WishlistTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvWishList
        '
        Me.dgvWishList.AllowUserToAddRows = False
        Me.dgvWishList.AllowUserToDeleteRows = False
        Me.dgvWishList.AutoGenerateColumns = False
        Me.dgvWishList.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvWishList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvWishList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvWishList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWishList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIdDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.MarineTypeDataGridViewTextBoxColumn, Me.ExperienceDataGridViewTextBoxColumn, Me.SeasonDataGridViewTextBoxColumn, Me.FoodDietDataGridViewTextBoxColumn, Me.RetailerNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.dgvWishList.DataSource = Me.WishlistTableBindingSource
        Me.dgvWishList.Location = New System.Drawing.Point(12, 63)
        Me.dgvWishList.Name = "dgvWishList"
        Me.dgvWishList.ReadOnly = True
        Me.dgvWishList.Size = New System.Drawing.Size(845, 306)
        Me.dgvWishList.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select a Retailer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 7
        '
        'cboRetailer
        '
        Me.cboRetailer.FormattingEnabled = True
        Me.cboRetailer.Location = New System.Drawing.Point(190, 36)
        Me.cboRetailer.Name = "cboRetailer"
        Me.cboRetailer.Size = New System.Drawing.Size(121, 21)
        Me.cboRetailer.TabIndex = 4
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "Exit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(872, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(373, 32)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(94, 23)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'WishlistTableBindingSource
        '
        Me.WishlistTableBindingSource.DataMember = "WishlistTable"
        Me.WishlistTableBindingSource.DataSource = Me.CALSdatabaseDataSet
        '
        'CALSdatabaseDataSet
        '
        Me.CALSdatabaseDataSet.DataSetName = "CALSdatabaseDataSet"
        Me.CALSdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WishlistTableTableAdapter
        '
        Me.WishlistTableTableAdapter.ClearBeforeFill = True
        '
        'ProductIdDataGridViewTextBoxColumn
        '
        Me.ProductIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId"
        Me.ProductIdDataGridViewTextBoxColumn.HeaderText = "ProductId"
        Me.ProductIdDataGridViewTextBoxColumn.Name = "ProductIdDataGridViewTextBoxColumn"
        Me.ProductIdDataGridViewTextBoxColumn.ReadOnly = True
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
        'frmWishList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 400)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboRetailer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvWishList)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmWishList"
        Me.Text = "Wish List"
        CType(Me.dgvWishList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.WishlistTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvWishList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CALSdatabaseDataSet As CALSdatabaseDataSet
    Friend WithEvents WishlistTableBindingSource As BindingSource
    Friend WithEvents WishlistTableTableAdapter As CALSdatabaseDataSetTableAdapters.WishlistTableTableAdapter
    Friend WithEvents cboRetailer As ComboBox
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnDelete As Button
    Friend WithEvents ProductIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarineTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExperienceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SeasonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodDietDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RetailerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
