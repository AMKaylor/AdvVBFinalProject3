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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboRetailer1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboRetailer2 = New System.Windows.Forms.ComboBox()
        Me.cboComparedItem = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPriceDifference = New System.Windows.Forms.Label()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpRetailers = New System.Windows.Forms.GroupBox()
        Me.grpProduct = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboComparedItem2 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.grpRetailers.SuspendLayout()
        Me.grpProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "1:"
        '
        'cboRetailer1
        '
        Me.cboRetailer1.FormattingEnabled = True
        Me.cboRetailer1.Location = New System.Drawing.Point(37, 22)
        Me.cboRetailer1.Name = "cboRetailer1"
        Me.cboRetailer1.Size = New System.Drawing.Size(121, 23)
        Me.cboRetailer1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "2:"
        '
        'cboRetailer2
        '
        Me.cboRetailer2.FormattingEnabled = True
        Me.cboRetailer2.Location = New System.Drawing.Point(37, 57)
        Me.cboRetailer2.Name = "cboRetailer2"
        Me.cboRetailer2.Size = New System.Drawing.Size(121, 23)
        Me.cboRetailer2.TabIndex = 6
        '
        'cboComparedItem
        '
        Me.cboComparedItem.Enabled = False
        Me.cboComparedItem.FormattingEnabled = True
        Me.cboComparedItem.Location = New System.Drawing.Point(37, 24)
        Me.cboComparedItem.Name = "cboComparedItem"
        Me.cboComparedItem.Size = New System.Drawing.Size(181, 23)
        Me.cboComparedItem.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(247, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Price Difference:"
        '
        'lblPriceDifference
        '
        Me.lblPriceDifference.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPriceDifference.Location = New System.Drawing.Point(359, 82)
        Me.lblPriceDifference.Name = "lblPriceDifference"
        Me.lblPriceDifference.Size = New System.Drawing.Size(130, 25)
        Me.lblPriceDifference.TabIndex = 15
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(386, 152)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(103, 23)
        Me.btnCompare.TabIndex = 16
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(386, 206)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(103, 23)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'grpRetailers
        '
        Me.grpRetailers.Controls.Add(Me.cboRetailer2)
        Me.grpRetailers.Controls.Add(Me.Label3)
        Me.grpRetailers.Controls.Add(Me.cboRetailer1)
        Me.grpRetailers.Controls.Add(Me.Label2)
        Me.grpRetailers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRetailers.Location = New System.Drawing.Point(15, 44)
        Me.grpRetailers.Name = "grpRetailers"
        Me.grpRetailers.Size = New System.Drawing.Size(179, 104)
        Me.grpRetailers.TabIndex = 18
        Me.grpRetailers.TabStop = False
        Me.grpRetailers.Text = "Retailer Selection"
        '
        'grpProduct
        '
        Me.grpProduct.Controls.Add(Me.Label5)
        Me.grpProduct.Controls.Add(Me.Label4)
        Me.grpProduct.Controls.Add(Me.cboComparedItem2)
        Me.grpProduct.Controls.Add(Me.cboComparedItem)
        Me.grpProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProduct.Location = New System.Drawing.Point(15, 179)
        Me.grpProduct.Name = "grpProduct"
        Me.grpProduct.Size = New System.Drawing.Size(245, 92)
        Me.grpProduct.TabIndex = 19
        Me.grpProduct.TabStop = False
        Me.grpProduct.Text = "Product Selection"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "1:"
        '
        'cboComparedItem2
        '
        Me.cboComparedItem2.Enabled = False
        Me.cboComparedItem2.FormattingEnabled = True
        Me.cboComparedItem2.Location = New System.Drawing.Point(37, 59)
        Me.cboComparedItem2.Name = "cboComparedItem2"
        Me.cboComparedItem2.Size = New System.Drawing.Size(181, 23)
        Me.cboComparedItem2.TabIndex = 10
        '
        'frmProductPriceComparison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 299)
        Me.Controls.Add(Me.grpProduct)
        Me.Controls.Add(Me.grpRetailers)
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
        Me.grpRetailers.ResumeLayout(False)
        Me.grpRetailers.PerformLayout()
        Me.grpProduct.ResumeLayout(False)
        Me.grpProduct.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents cboRetailer1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboRetailer2 As ComboBox
    Friend WithEvents cboComparedItem As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPriceDifference As Label
    Friend WithEvents btnCompare As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents grpRetailers As GroupBox
    Friend WithEvents grpProduct As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboComparedItem2 As ComboBox
End Class
