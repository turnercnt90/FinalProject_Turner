Public Class Appointment_List
    Private Sub dgvappointments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvappointments.CellContentClick

    End Sub
    Private Sub form_load() Handles MyBase.Load
        Dim mappointments As New Appointments
        dgvappointments.DataSource = mappointments.appointmentlist
    End Sub


End Class