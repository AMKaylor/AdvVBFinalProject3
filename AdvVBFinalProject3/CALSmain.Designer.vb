<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CALSmain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YourWishListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetailerInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetailerProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetailerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceComparisonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picCALSLogo = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picCALSLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AccountInfoToolStripMenuItem, Me.RetailerInformationToolStripMenuItem, Me.ProductInfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AccountInfoToolStripMenuItem
        '
        Me.AccountInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YourWishListToolStripMenuItem})
        Me.AccountInfoToolStripMenuItem.Name = "AccountInfoToolStripMenuItem"
        Me.AccountInfoToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.AccountInfoToolStripMenuItem.Text = "Account Info"
        '
        'YourWishListToolStripMenuItem
        '
        Me.YourWishListToolStripMenuItem.Name = "YourWishListToolStripMenuItem"
        Me.YourWishListToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.YourWishListToolStripMenuItem.Text = "Your Wish List"
        '
        'RetailerInformationToolStripMenuItem
        '
        Me.RetailerInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllToolStripMenuItem, Me.RetailerProductsToolStripMenuItem, Me.RetailerReportToolStripMenuItem})
        Me.RetailerInformationToolStripMenuItem.Name = "RetailerInformationToolStripMenuItem"
        Me.RetailerInformationToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.RetailerInformationToolStripMenuItem.Text = "Retailer Info"
        '
        'ViewAllToolStripMenuItem
        '
        Me.ViewAllToolStripMenuItem.Name = "ViewAllToolStripMenuItem"
        Me.ViewAllToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ViewAllToolStripMenuItem.Text = "View All"
        '
        'RetailerProductsToolStripMenuItem
        '
        Me.RetailerProductsToolStripMenuItem.Name = "RetailerProductsToolStripMenuItem"
        Me.RetailerProductsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RetailerProductsToolStripMenuItem.Text = "Retailer Products"
        '
        'RetailerReportToolStripMenuItem
        '
        Me.RetailerReportToolStripMenuItem.Name = "RetailerReportToolStripMenuItem"
        Me.RetailerReportToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.RetailerReportToolStripMenuItem.Text = "Retailer Report"
        '
        'ProductInfoToolStripMenuItem
        '
        Me.ProductInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllToolStripMenuItem1, Me.PriceComparisonToolStripMenuItem})
        Me.ProductInfoToolStripMenuItem.Name = "ProductInfoToolStripMenuItem"
        Me.ProductInfoToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ProductInfoToolStripMenuItem.Text = "Product Info"
        '
        'ViewAllToolStripMenuItem1
        '
        Me.ViewAllToolStripMenuItem1.Name = "ViewAllToolStripMenuItem1"
        Me.ViewAllToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.ViewAllToolStripMenuItem1.Text = "View All"
        '
        'PriceComparisonToolStripMenuItem
        '
        Me.PriceComparisonToolStripMenuItem.Name = "PriceComparisonToolStripMenuItem"
        Me.PriceComparisonToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.PriceComparisonToolStripMenuItem.Text = "Price Comparison"
        '
        'picCALSLogo
        '
        Me.picCALSLogo.Image = Global.AdvVBFinalProject3.My.Resources.Resources.CALS_Logo2_Resized
        Me.picCALSLogo.Location = New System.Drawing.Point(6, 29)
        Me.picCALSLogo.Name = "picCALSLogo"
        Me.picCALSLogo.Size = New System.Drawing.Size(600, 450)
        Me.picCALSLogo.TabIndex = 2
        Me.picCALSLogo.TabStop = False
        '
        'CALSmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(611, 483)
        Me.Controls.Add(Me.picCALSLogo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CALSmain"
        Me.Text = "Collector of Aquatic Life Supplier"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picCALSLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetailerInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YourWishListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PriceComparisonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetailerProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetailerReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picCALSLogo As PictureBox
End Class
