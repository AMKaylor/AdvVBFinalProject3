Public Class Products

    Private adapter As New CALSdatabaseDataSetTableAdapters.ProductTableTableAdapter

    Public ReadOnly Property Items() As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property

    Public Function FilterByRetailer(ByVal RetailerId As Integer) As DataTable
        Dim table As DataTable = adapter.GetData()

        table.DefaultView.RowFilter = "RetailerId = " & RetailerId

        Return table
    End Function
End Class
