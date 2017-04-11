<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRetailerList
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CALSdatabaseDataSet = New AdvVBFinalProject3.CALSdatabaseDataSet()
        Me.RetailerTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetailerTableTableAdapter = New AdvVBFinalProject3.CALSdatabaseDataSetTableAdapters.RetailerTableTableAdapter()
        Me.RetailerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetailerTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(224, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RetailerNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RetailerTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.Size = New System.Drawing.Size(182, 146)
        Me.DataGridView1.TabIndex = 2
        '
        'CALSdatabaseDataSet
        '
        Me.CALSdatabaseDataSet.DataSetName = "CALSdatabaseDataSet"
        Me.CALSdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RetailerTableBindingSource
        '
        Me.RetailerTableBindingSource.DataMember = "RetailerTable"
        Me.RetailerTableBindingSource.DataSource = Me.CALSdatabaseDataSet
        '
        'RetailerTableTableAdapter
        '
        Me.RetailerTableTableAdapter.ClearBeforeFill = True
        '
        'RetailerNameDataGridViewTextBoxColumn
        '
        Me.RetailerNameDataGridViewTextBoxColumn.DataPropertyName = "Retailer_Name"
        Me.RetailerNameDataGridViewTextBoxColumn.HeaderText = "Retailer_Name"
        Me.RetailerNameDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.RetailerNameDataGridViewTextBoxColumn.Name = "RetailerNameDataGridViewTextBoxColumn"
        Me.RetailerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmRetailerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 198)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmRetailerList"
        Me.Text = "Retailer List"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CALSdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetailerTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CALSdatabaseDataSet As CALSdatabaseDataSet
    Friend WithEvents RetailerTableBindingSource As BindingSource
    Friend WithEvents RetailerTableTableAdapter As CALSdatabaseDataSetTableAdapters.RetailerTableTableAdapter
    Friend WithEvents RetailerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
