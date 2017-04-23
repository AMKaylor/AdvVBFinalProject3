<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductPriceComparison
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPriceDifference = New System.Windows.Forms.Label()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.dgvPriceComparison = New System.Windows.Forms.DataGridView()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CALSdatabaseDataSet = New AdvVBFinalProject3.CALSdatabaseDataSet()
        Me.ProductTableTableAdapter = New AdvVBFinalProject3.CALSdatabaseDataSetTableAdapters.ProductTableTableAdapter()
        Me.lblPrice1 = New System.Windows.Forms.Label()
        Me.lblPrice2 = New System.Windows.Forms.Label()
        Me.btnPrice1 = New System.Windows.Forms.Button()
        Me.btnPrice2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvPriceComparison, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(387, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(49, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Price Difference:"
        '
        'lblPriceDifference
        '
        Me.lblPriceDifference.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPriceDifference.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriceDifference.Location = New System.Drawing.Point(161, 381)
        Me.lblPriceDifference.Name = "lblPriceDifference"
        Me.lblPriceDifference.Size = New System.Drawing.Size(130, 25)
        Me.lblPriceDifference.TabIndex = 15
        Me.lblPriceDifference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(52, 428)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(103, 23)
        Me.btnCompare.TabIndex = 16
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(223, 428)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 23)
        Me.btnReset.TabIndex = 24
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'dgvPriceComparison
        '
        Me.dgvPriceComparison.AllowUserToAddRows = False
        Me.dgvPriceComparison.AllowUserToDeleteRows = False
        Me.dgvPriceComparison.AutoGenerateColumns = False
        Me.dgvPriceComparison.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvPriceComparison.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPriceComparison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPriceComparison.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_Name, Me.RetailerNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.dgvPriceComparison.DataSource = Me.ProductTableBindingSource
        Me.dgvPriceComparison.Location = New System.Drawing.Point(23, 42)
        Me.dgvPriceComparison.Name = "dgvPriceComparison"
        Me.dgvPriceComparison.ReadOnly = True
        Me.dgvPriceComparison.Size = New System.Drawing.Size(348, 241)
        Me.dgvPriceComparison.TabIndex = 25
        '
        'Product_Name
        '
        Me.Product_Name.DataPropertyName = "Product_Name"
        Me.Product_Name.HeaderText = "Product_Name"
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.ReadOnly = True
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
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
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
        'lblPrice1
        '
        Me.lblPrice1.BackColor = System.Drawing.SystemColors.Info
        Me.lblPrice1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice1.Location = New System.Drawing.Point(55, 297)
        Me.lblPrice1.Name = "lblPrice1"
        Me.lblPrice1.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice1.TabIndex = 26
        Me.lblPrice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice2
        '
        Me.lblPrice2.BackColor = System.Drawing.SystemColors.Info
        Me.lblPrice2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice2.Location = New System.Drawing.Point(238, 297)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(100, 23)
        Me.lblPrice2.TabIndex = 27
        Me.lblPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrice1
        '
        Me.btnPrice1.Location = New System.Drawing.Point(54, 323)
        Me.btnPrice1.Name = "btnPrice1"
        Me.btnPrice1.Size = New System.Drawing.Size(103, 23)
        Me.btnPrice1.TabIndex = 28
        Me.btnPrice1.Text = "Get Price 1:"
        Me.btnPrice1.UseVisualStyleBackColor = True
        '
        'btnPrice2
        '
        Me.btnPrice2.Location = New System.Drawing.Point(236, 323)
        Me.btnPrice2.Name = "btnPrice2"
        Me.btnPrice2.Size = New System.Drawing.Size(103, 23)
        Me.btnPrice2.TabIndex = 29
        Me.btnPrice2.Text = "Get Price 2:"
        Me.btnPrice2.UseVisualStyleBackColor = True
        '
        'frmProductPriceComparison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 465)
        Me.Controls.Add(Me.btnPrice2)
        Me.Controls.Add(Me.btnPrice1)
        Me.Controls.Add(Me.lblPrice2)
        Me.Controls.Add(Me.lblPrice1)
        Me.Controls.Add(Me.dgvPriceComparison)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.lblPriceDifference)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmProductPriceComparison"
        Me.Text = "Product Price Comparison"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvPriceComparison, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPriceDifference As Label
    Friend WithEvents btnCompare As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents dgvPriceComparison As DataGridView
    Friend WithEvents CALSdatabaseDataSet As CALSdatabaseDataSet
    Friend WithEvents ProductTableBindingSource As BindingSource
    Friend WithEvents ProductTableTableAdapter As CALSdatabaseDataSetTableAdapters.ProductTableTableAdapter
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents RetailerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblPrice1 As Label
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents btnPrice1 As Button
    Friend WithEvents btnPrice2 As Button
End Class
