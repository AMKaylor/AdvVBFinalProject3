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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboRetailer1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboRetailer2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboComparedItem = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblRetailer1 = New System.Windows.Forms.Label()
        Me.lblRetailer2 = New System.Windows.Forms.Label()
        Me.lblPriceDifference = New System.Windows.Forms.Label()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(668, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(666, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "**Go through the steps to find a price comparison between two items from differen" &
    "t retailers.**"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "STEP 1: Pick the first Retailer."
        '
        'cboRetailer1
        '
        Me.cboRetailer1.FormattingEnabled = True
        Me.cboRetailer1.Location = New System.Drawing.Point(64, 103)
        Me.cboRetailer1.Name = "cboRetailer1"
        Me.cboRetailer1.Size = New System.Drawing.Size(121, 21)
        Me.cboRetailer1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "STEP 2: Pick the second Retailer."
        '
        'cboRetailer2
        '
        Me.cboRetailer2.FormattingEnabled = True
        Me.cboRetailer2.Location = New System.Drawing.Point(64, 171)
        Me.cboRetailer2.Name = "cboRetailer2"
        Me.cboRetailer2.Size = New System.Drawing.Size(121, 21)
        Me.cboRetailer2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "STEP 3: Pick the item you want to compare."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Info
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(313, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "**Note: The items in the box are verified that both retailers sale.**"
        '
        'cboComparedItem
        '
        Me.cboComparedItem.FormattingEnabled = True
        Me.cboComparedItem.Location = New System.Drawing.Point(64, 242)
        Me.cboComparedItem.Name = "cboComparedItem"
        Me.cboComparedItem.Size = New System.Drawing.Size(121, 21)
        Me.cboComparedItem.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(384, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "First Retailer Price:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(362, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Second Retailer Price:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(398, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Price Difference:"
        '
        'lblRetailer1
        '
        Me.lblRetailer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRetailer1.Location = New System.Drawing.Point(510, 84)
        Me.lblRetailer1.Name = "lblRetailer1"
        Me.lblRetailer1.Size = New System.Drawing.Size(130, 25)
        Me.lblRetailer1.TabIndex = 13
        '
        'lblRetailer2
        '
        Me.lblRetailer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRetailer2.Location = New System.Drawing.Point(510, 119)
        Me.lblRetailer2.Name = "lblRetailer2"
        Me.lblRetailer2.Size = New System.Drawing.Size(130, 25)
        Me.lblRetailer2.TabIndex = 14
        '
        'lblPriceDifference
        '
        Me.lblPriceDifference.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriceDifference.Location = New System.Drawing.Point(510, 152)
        Me.lblPriceDifference.Name = "lblPriceDifference"
        Me.lblPriceDifference.Size = New System.Drawing.Size(130, 25)
        Me.lblPriceDifference.TabIndex = 15
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(401, 259)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(103, 23)
        Me.btnCompare.TabIndex = 16
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(537, 259)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 23)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmProductPriceComparison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 299)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.lblPriceDifference)
        Me.Controls.Add(Me.lblRetailer2)
        Me.Controls.Add(Me.lblRetailer1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboComparedItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboRetailer2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboRetailer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmProductPriceComparison"
        Me.Text = "Product Price Comparison"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboRetailer1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboRetailer2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboComparedItem As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblRetailer1 As Label
    Friend WithEvents lblRetailer2 As Label
    Friend WithEvents lblPriceDifference As Label
    Friend WithEvents btnCompare As Button
    Friend WithEvents btnReset As Button
End Class
