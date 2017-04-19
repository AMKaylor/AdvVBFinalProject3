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

    Public Function FilterByDietF() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByDietF()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterByDietH() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByDietH()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterByDietC() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByDietC()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterByDietO() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByDietO()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterBySeasonSU() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataBySeasonSU()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterBySeasonW() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataBySeasonW()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterBySeasonAll() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataBySeasonSSFW()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterBySeasonSSF() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataBySeasonSSF()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterBySeasonSS() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataBySeasonSS()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterBySeasonSP() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataBySeasonSP()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterBySeasonFW() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataBySeasonFW()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterByMarineLifeF() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByMarineTypeF()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterByMarineLifeH() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByMarineTypeH()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function FilterByMarineLifeS() As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByMarineTypeS()
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function GetDataByRetailerForComparison(ByVal pRetailerId As Integer) As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByRetailerForComparison(pRetailerId)
            Return table
        Catch ex As Exception

        End Try
    End Function

    Public Function GetDataByComparedPrice(ByVal pProductId As Integer) As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByComparedPrice(pProductId)
            Return table
        Catch ex As Exception

        End Try
    End Function
End Class
