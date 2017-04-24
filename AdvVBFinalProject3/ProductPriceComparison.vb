Option Explicit On
Option Strict On

Public Class frmProductPriceComparison

    Private mRetailer As New Retailer
    Private mProducts As New Products
    Private formLoading As Boolean = True

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frmProductPriceComparison_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CALSdatabaseDataSet.ProductTable' table. You can move, or remove it, as needed.
        Me.ProductTableTableAdapter.Fill(Me.CALSdatabaseDataSet.ProductTable)



        formLoading = False

    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click

        If lblPrice1.Text = "" Then
            MessageBox.Show("Please select a price for an item.")

        ElseIf lblPrice2.Text = "" Then
            MessageBox.Show("Please select a price for an item.")
        Else

            Dim Price1 As Integer = CInt(lblPrice1.Text)
            Dim Price2 As Integer = CInt(lblPrice2.Text)
            Dim total As Integer

            If Price1 > Price2 Then

                total = Price1 - Price2
                lblPriceDifference.Text = total.ToString("c")
            Else

                total = (-1 * (Price1 - Price2))
                lblPriceDifference.Text = total.ToString("c")
            End If
        End If


    End Sub

    Private Sub btnPrice1_Click(sender As Object, e As EventArgs) Handles btnPrice1.Click

        Dim FirstValue As Boolean = True
        Dim cell As DataGridViewCell
        For Each cell In dgvPriceComparison.SelectedCells
            If Not FirstValue Then
                lblPrice1.Text = " "
            End If
            lblPrice1.Text = cell.Value.ToString()
            FirstValue = False
        Next

        If lblPrice1.Text = lblPrice1.Text.ToString() Then
            Try
                Dim Price1 As Integer = CInt(lblPrice1.Text)
            Catch ex As Exception
                MessageBox.Show("Please select a price from the Price column.")
            End Try
        End If

    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        'House cleaning

        lblPriceDifference.Text = ""
        lblPrice1.Text = ""
        lblPrice2.Text = ""

    End Sub

    Private Sub btnPrice2_Click(sender As Object, e As EventArgs) Handles btnPrice2.Click

        Dim FirstValue As Boolean = True
        Dim cell As DataGridViewCell
        For Each cell In dgvPriceComparison.SelectedCells
            If Not FirstValue Then
                lblPrice2.Text = " "
            End If
            lblPrice2.Text = cell.Value.ToString()
            FirstValue = False
        Next

        If lblPrice2.Text = lblPrice2.Text.ToString() Then
            Try
                Dim Price2 As Integer = CInt(lblPrice2.Text)
            Catch ex As Exception
                MessageBox.Show("Please select a price from the Price column.")
            End Try
        End If

    End Sub
End Class