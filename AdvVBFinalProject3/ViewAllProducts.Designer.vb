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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewAllProducts))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cboTypeOfLife = New System.Windows.Forms.ComboBox()
        Me.cboSeason = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnWishlist = New System.Windows.Forms.Button()
        Me.CALSdatabaseDataSet = New AdvVBFinalProject3.CALSdatabaseDataSet()
        Me.ProductTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableTableAdapter = New AdvVBFinalProject3.CALSdatabaseDataSetTableAdapters.ProductTableTableAdapter()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarineTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExperienceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodDietDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboRetailer = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cboExperienceLvl = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDiet = New System.Windows.Forms.ToolStripComboBox()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductNameDataGridViewTextBoxColumn, Me.MarineTypeDataGridViewTextBoxColumn, Me.ExperienceDataGridViewTextBoxColumn, Me.SeasonDataGridViewTextBoxColumn, Me.FoodDietDataGridViewTextBoxColumn, Me.RetailerNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(783, 274)
        Me.DataGridView1.TabIndex = 1
        '
        'cboTypeOfLife
        '
        Me.cboTypeOfLife.BackColor = System.Drawing.SystemColors.Window
        Me.cboTypeOfLife.FormattingEnabled = True
        Me.cboTypeOfLife.Location = New System.Drawing.Point(148, 40)
        Me.cboTypeOfLife.Name = "cboTypeOfLife"
        Me.cboTypeOfLife.Size = New System.Drawing.Size(122, 21)
        Me.cboTypeOfLife.TabIndex = 5
        '
        'cboSeason
        '
        Me.cboSeason.BackColor = System.Drawing.SystemColors.Window
        Me.cboSeason.FormattingEnabled = True
        Me.cboSeason.Location = New System.Drawing.Point(381, 40)
        Me.cboSeason.Name = "cboSeason"
        Me.cboSeason.Size = New System.Drawing.Size(122, 21)
        Me.cboSeason.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Type of Marine Life:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(323, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Season:"
        '
        'btnWishlist
        '
        Me.btnWishlist.Location = New System.Drawing.Point(577, 38)
        Me.btnWishlist.Name = "btnWishlist"
        Me.btnWishlist.Size = New System.Drawing.Size(100, 23)
        Me.btnWishlist.TabIndex = 9
        Me.btnWishlist.Text = "Add to Wishlist"
        Me.btnWishlist.UseVisualStyleBackColor = True
        '
        'CALSdatabaseDataSet
        '
        Me.CALSdatabaseDataSet.DataSetName = "CALSdatabaseDataSet"
        Me.CALSdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableBindingSource
        '
        Me.ProductTableBindingSource.DataMember = "ProductTable"
        Me.ProductTableBindingSource.DataSource = Me.CALSdatabaseDataSet
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Info
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(369, 46)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Su -Summer,  Sp -Spring,  W -Winter,  SS - Spring/Summer,  FW -Fall/Winter,  SSF " &
    "- Spring/Summer/Fall,  SSFW -Spring/Summer/Fall/Winter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(18, 392)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Legend:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExit, Me.ToolStripLabel1, Me.cboRetailer, Me.ToolStripLabel2, Me.cboExperienceLvl, Me.ToolStripLabel3, Me.cboDiet})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(818, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripLabel2.Text = "Experience Level:"
        '
        'cboExperienceLvl
        '
        Me.cboExperienceLvl.Name = "cboExperienceLvl"
        Me.cboExperienceLvl.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel3.Text = "Food Diet:"
        '
        'cboDiet
        '
        Me.cboDiet.Name = "cboDiet"
        Me.cboDiet.Size = New System.Drawing.Size(121, 25)
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
        'frmViewAllProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 473)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnWishlist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSeason)
        Me.Controls.Add(Me.cboTypeOfLife)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmViewAllProducts"
        Me.Text = "View All Products"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cboTypeOfLife As ComboBox
    Friend WithEvents cboSeason As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnWishlist As Button
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cboRetailer As ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents cboExperienceLvl As ToolStripComboBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents cboDiet As ToolStripComboBox
    Friend WithEvents btnExit As ToolStripButton
End Class
