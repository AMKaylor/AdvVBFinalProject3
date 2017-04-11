Option Explicit On
Option Strict On

Public Class Retailer

    Private adapter As New CALSdatabaseDataSetTableAdapters.RetailerTableTableAdapter

    Public ReadOnly Property Retailers() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()

            table.DefaultView.Sort = "Retailer_Name"

            Return table
        End Get
    End Property
End Class
