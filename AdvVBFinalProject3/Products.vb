Public Class Products

    Private adapter As New CALSdatabaseDataSetTableAdapters.ProductTableTableAdapter

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

    Public Function FilterByExperienceB() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByExperienceB()
            Return table
        Catch ex As Exception

        End Try

    End Function

    Public Function FilterByExperienceI() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByExperienceI()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterByExperienceE() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByExperienceE()
            Return table
        Catch ex As Exception

        End Try
    End Function

End Class
