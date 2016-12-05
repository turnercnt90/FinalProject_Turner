'Option Strict On
Option Explicit On
Public Class Appointments
    Private adapter As New _
        EstimateServicesDataSetTableAdapters.Appointment1TableAdapter
    Public Shared Property lasterror As String
    Public Function insert(Id As Integer, ByVal description As String, ByVal scheduled As DateTime) As Boolean
        Try
            lasterror = String.Empty
            adapter.Insert(Id, description, scheduled)
            Return True
        Catch ex As Exception
            lasterror = ex.Message
            Return False
        End Try
    End Function
    Public Shared Function combinedDateTime(ByVal adate As DateTime, ByVal atime As DateTime) As DateTime
        Dim ts As New TimeSpan(atime.Hour, atime.Minute, 0)
        Return adate.Add(ts)
    End Function

    Friend Function insert(id As Short, text As String, Optional p As Object = Nothing) As Boolean
        Throw New NotImplementedException()
    End Function

    Public ReadOnly Property items As DataTable
        Get
            Return adapter.GetData


        End Get
    End Property

    Public Function getbycustomerid(ByVal custid As Short) As DataTable
        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "custid = " & custid
        Return table
    End Function
    Public Function update(ByVal customer As Short, ByVal description As String, ByVal scheduled As DateTime, ByVal id As Integer) As Boolean
        Try
            adapter.Update(customer, scheduled, id, description)
            Return True

        Catch ex As Exception
            lasterror = ex.Message
            Return False

        End Try
    End Function
    Public Function findbyid(ByVal id As Short) _
        As EstimateServicesDataSetTableAdapters.Appointment1TableAdapter
        Dim table As EstimateServicesDataSet.Appointment1DataTable
        table = adapter.GetData()
        Return table.FindByCustomer(Customer:=)
    End Function
    Public Function delete(ByVal id As Integer) As Boolean
        Dim rowsaffected As Integer = adapter.Delete(id)
        Return rowsaffected > 0
    End Function
    Public ReadOnly Property appointmentlist As DataTable
        Get
            Dim listadapter As New EstimateServicesDataSetTableAdapters.Appointment1TableAdapter
            Return listadapter.GetData()

        End Get
    End Property
End Class
