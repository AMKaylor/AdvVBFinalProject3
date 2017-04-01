<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewAllProducts
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SpecificRetailerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboRetailer = New System.Windows.Forms.ToolStripComboBox()
        Me.ExperienceLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboExperienceLvl = New System.Windows.Forms.ToolStripComboBox()
        Me.FoodDietToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboFoodDiet = New System.Windows.Forms.ToolStripComboBox()
        Me.cboTypeOfLife = New System.Windows.Forms.ComboBox()
        Me.cboSeason = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnWishlist = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.SpecificRetailerToolStripMenuItem, Me.cboRetailer, Me.ExperienceLevelToolStripMenuItem, Me.cboExperienceLvl, Me.FoodDietToolStripMenuItem, Me.cboFoodDiet})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(689, 274)
        Me.DataGridView1.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 380)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(713, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SpecificRetailerToolStripMenuItem
        '
        Me.SpecificRetailerToolStripMenuItem.Name = "SpecificRetailerToolStripMenuItem"
        Me.SpecificRetailerToolStripMenuItem.Size = New System.Drawing.Size(105, 23)
        Me.SpecificRetailerToolStripMenuItem.Text = "Specific Retailer:"
        '
        'cboRetailer
        '
        Me.cboRetailer.Name = "cboRetailer"
        Me.cboRetailer.Size = New System.Drawing.Size(121, 23)
        '
        'ExperienceLevelToolStripMenuItem
        '
        Me.ExperienceLevelToolStripMenuItem.Name = "ExperienceLevelToolStripMenuItem"
        Me.ExperienceLevelToolStripMenuItem.Size = New System.Drawing.Size(108, 23)
        Me.ExperienceLevelToolStripMenuItem.Text = "Experience Level:"
        '
        'cboExperienceLvl
        '
        Me.cboExperienceLvl.Name = "cboExperienceLvl"
        Me.cboExperienceLvl.Size = New System.Drawing.Size(121, 23)
        '
        'FoodDietToolStripMenuItem
        '
        Me.FoodDietToolStripMenuItem.Name = "FoodDietToolStripMenuItem"
        Me.FoodDietToolStripMenuItem.Size = New System.Drawing.Size(73, 23)
        Me.FoodDietToolStripMenuItem.Text = "Food Diet:"
        '
        'cboFoodDiet
        '
        Me.cboFoodDiet.Name = "cboFoodDiet"
        Me.cboFoodDiet.Size = New System.Drawing.Size(121, 23)
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
        'frmViewAllProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 402)
        Me.Controls.Add(Me.btnWishlist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSeason)
        Me.Controls.Add(Me.cboTypeOfLife)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmViewAllProducts"
        Me.Text = "View All Products"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SpecificRetailerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboRetailer As ToolStripComboBox
    Friend WithEvents ExperienceLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboExperienceLvl As ToolStripComboBox
    Friend WithEvents FoodDietToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cboFoodDiet As ToolStripComboBox
    Friend WithEvents cboTypeOfLife As ComboBox
    Friend WithEvents cboSeason As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnWishlist As Button
End Class
