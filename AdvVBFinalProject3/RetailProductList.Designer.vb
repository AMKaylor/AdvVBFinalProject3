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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeOfMarineLifeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboTypeOfLife = New System.Windows.Forms.ToolStripComboBox()
        Me.BySeasonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboSeason = New System.Windows.Forms.ToolStripComboBox()
        Me.AddToWishlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.TypeOfMarineLifeToolStripMenuItem, Me.cboTypeOfLife, Me.BySeasonToolStripMenuItem, Me.cboSeason, Me.AddToWishlistToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 27)
        Me.MenuStrip1.TabIndex = 0
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TypeOfMarineLifeToolStripMenuItem
        '
        Me.TypeOfMarineLifeToolStripMenuItem.Name = "TypeOfMarineLifeToolStripMenuItem"
        Me.TypeOfMarineLifeToolStripMenuItem.Size = New System.Drawing.Size(123, 23)
        Me.TypeOfMarineLifeToolStripMenuItem.Text = "Type of Marine Life:"
        '
        'cboTypeOfLife
        '
        Me.cboTypeOfLife.Name = "cboTypeOfLife"
        Me.cboTypeOfLife.Size = New System.Drawing.Size(121, 23)
        '
        'BySeasonToolStripMenuItem
        '
        Me.BySeasonToolStripMenuItem.Name = "BySeasonToolStripMenuItem"
        Me.BySeasonToolStripMenuItem.Size = New System.Drawing.Size(75, 23)
        Me.BySeasonToolStripMenuItem.Text = "By Season:"
        '
        'cboSeason
        '
        Me.cboSeason.Name = "cboSeason"
        Me.cboSeason.Size = New System.Drawing.Size(121, 23)
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
        Me.StatusStrip1.Size = New System.Drawing.Size(596, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(572, 322)
        Me.DataGridView1.TabIndex = 2
        '
        'frmRetailProductList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 419)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRetailProductList"
        Me.Text = "Retail Product List"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TypeOfMarineLifeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboTypeOfLife As ToolStripComboBox
    Friend WithEvents BySeasonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboSeason As ToolStripComboBox
    Friend WithEvents AddToWishlistToolStripMenuItem As ToolStripMenuItem
End Class
