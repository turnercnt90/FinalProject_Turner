
Option Strict On
Public Class ServiceTypes
    Private adaptor As New _
        EstimateServicesDataSetTableAdapters.ServiceType1TableAdapter
    Public ReadOnly Property items() As DataTable
        Get
            Dim table As DataTable = adaptor.GetData()
            table.DefaultView.Sort = "description"
            Return table
        End Get
    End Property
End Class