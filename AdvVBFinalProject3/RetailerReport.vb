Option Strict On
Option Explicit On

Public Class frmRetailerReport
    Private mRetailer As New Retailer
    Private mProducts As New Products
    Private formLoading As Boolean = True

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmRetailerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CALSdatabaseDataSet.ProductTable' table. You can move, or remove it, as needed.
        Me.ProductTableTableAdapter.Fill(Me.CALSdatabaseDataSet.ProductTable)

        'Load retailer combo box with retailers
        With cboRetailer.ComboBox
            .DataSource = mRetailer.Retailers
            .DisplayMember = "Retailer_Name"
            .ValueMember = "RetailerId"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1
        End With

        formLoading = False
    End Sub

    Private Sub cboRetailer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRetailer.SelectedIndexChanged

        If Not formLoading Then
            Dim adapter As New CALSdatabaseDataSetTableAdapters.RetailerReportTableAdapter
            Dim RetailerId As Integer = CInt(cboRetailer.ComboBox.SelectedValue)

            dgvRetailerReport.DataSource = adapter.GetDataByRetailerReport(RetailerId)

        End If

    End Sub
End Class