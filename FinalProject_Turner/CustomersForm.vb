Public Class CustomersForm
    Private Sub CustomersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EstimateServicesDataSet.Customers_Table' table. You can move, or remove it, as needed.
        Me.Customers_TableTableAdapter.Fill(Me.EstimateServicesDataSet.Customers_Table)


    End Sub
End Class