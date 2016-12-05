Option Strict On
Public Class Customers
    Private adaptor As New _
        EstimateServicesDataSetTableAdapters.Customers_TableTableAdapter
    Public ReadOnly Property items() As DataTable
        Get
            Dim table As DataTable = adaptor.GetData()
            table.DefaultView.Sort = "name"
            Return table
        End Get
    End Property
End Class