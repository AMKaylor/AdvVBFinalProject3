Public Class Wish_List

    Private adapter As New CALSdatabaseDataSetTableAdapters.WishlistTableTableAdapter

    Public ReadOnly Property Items() As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function FilterByRetailer(ByVal pRetailerId As Integer) As DataTable
        Dim table As DataTable = adapter.GetData()

        table.DefaultView.RowFilter = "RetailerId = " & pRetailerId

        Return table
    End Function

    Public Function Delete(ByVal pProductId As Integer) As Boolean

        Dim rowsAffected As Integer = adapter.Delete(pProductId)

        Return rowsAffected > 0

    End Function

    Public Function Update(ByVal pProductId As Integer, ByVal pProduct_Name As String, ByVal pMarine_Type As String, ByVal pExperience As String, ByVal pSeason As String, ByVal pFood_Diet As String,
                           ByVal pRetailerId As Integer, ByVal pRetailer_Name As String, ByVal pPrice As Decimal) As Boolean

        Try

            adapter.Update(pProduct_Name, pMarine_Type, pExperience, pSeason, pFood_Diet, pRetailerId, pRetailer_Name, pPrice, pProductId)

            Return True

        Catch ex As Exception

            MessageBox.Show("Error to Updating table and database.")
            Return False

        End Try

    End Function
End Class
