Public Class Retailer_Report
    Private adapter As New CALSdatabaseDataSetTableAdapters.RetailerReportTableAdapter

    Function GetDataByRetailerReport(ByVal RetailerId As Integer) As DataTable

        Try
            Dim table As DataTable = adapter.GetDataByRetailerReport(RetailerId)
            Return table
        Catch ex As Exception

        End Try
    End Function
End Class
