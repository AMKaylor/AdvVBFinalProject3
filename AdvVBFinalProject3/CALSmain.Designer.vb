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
        Me.RetailerInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ViewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetailerProductListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YourWishListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriceComparisonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AccountInfoToolStripMenuItem, Me.RetailerInformationToolStripMenuItem, Me.ProductInfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(765, 24)
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RetailerInformationToolStripMenuItem
        '
        Me.RetailerInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllToolStripMenuItem, Me.RetailerProductListToolStripMenuItem})
        Me.RetailerInformationToolStripMenuItem.Name = "RetailerInformationToolStripMenuItem"
        Me.RetailerInformationToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.RetailerInformationToolStripMenuItem.Text = "Retailer Info"
        '
        'AccountInfoToolStripMenuItem
        '
        Me.AccountInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YourWishListToolStripMenuItem, Me.CreateNewUserToolStripMenuItem})
        Me.AccountInfoToolStripMenuItem.Name = "AccountInfoToolStripMenuItem"
        Me.AccountInfoToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.AccountInfoToolStripMenuItem.Text = "Account Info"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 415)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(765, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'ViewAllToolStripMenuItem
        '
        Me.ViewAllToolStripMenuItem.Name = "ViewAllToolStripMenuItem"
        Me.ViewAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewAllToolStripMenuItem.Text = "View All"
        '
        'RetailerProductListToolStripMenuItem
        '
        Me.RetailerProductListToolStripMenuItem.Name = "RetailerProductListToolStripMenuItem"
        Me.RetailerProductListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RetailerProductListToolStripMenuItem.Text = "Product List"
        '
        'ProductInfoToolStripMenuItem
        '
        Me.ProductInfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllToolStripMenuItem1, Me.PriceComparisonToolStripMenuItem})
        Me.ProductInfoToolStripMenuItem.Name = "ProductInfoToolStripMenuItem"
        Me.ProductInfoToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ProductInfoToolStripMenuItem.Text = "Product Info"
        '
        'YourWishListToolStripMenuItem
        '
        Me.YourWishListToolStripMenuItem.Name = "YourWishListToolStripMenuItem"
        Me.YourWishListToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.YourWishListToolStripMenuItem.Text = "Your Wish List"
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
        'CreateNewUserToolStripMenuItem
        '
        Me.CreateNewUserToolStripMenuItem.Name = "CreateNewUserToolStripMenuItem"
        Me.CreateNewUserToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CreateNewUserToolStripMenuItem.Text = "Create New User"
        '
        'CALSmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 437)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CALSmain"
        Me.Text = "Collector of Aquatic Life Supplier"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetailerInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RetailerProductListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YourWishListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PriceComparisonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateNewUserToolStripMenuItem As ToolStripMenuItem
End Class
