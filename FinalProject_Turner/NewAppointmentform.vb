Public Class NewAppointmentForm
    Private mAppointments As New Appointments
    Private mservicetypes As New ServiceTypes
    Private mcustomers As New CustomersForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' mAppointments.insert(2, "fix disposal", False, 1020, #10/5/2015 9:00 AM#)
        'Appointmentsform.ShowDialog() '
        Dim Scheduled As DateTime
        Try
            Scheduled = Appointments.combinedDateTime(dtpdate.Value.Date, CDate(txttime.Text))
        Catch
            errprovider.SetError(txttime, "please enter a valid appointment time")
            Return

        End Try
        Dim id As Short = CShort(cbocustomer.SelectedValue)
        'Dim custid As Short = CShort(cbocustomer.SelectedValue)
        'Dim licensed As Boolean = chklicensed.Checked
        If mAppointments.insert(id, txtdescription.Text,) Then
            Me.Close()
        Else
            lblstatus.Text = "cannot add appointment." _
                & Appointments.lasterror

        End If
    End Sub

    Private Sub NewAppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill the repair types combo box
        cborepairtype.DataSource = mservicetypes.items
        cborepairtype.DisplayMember = "description"
        cborepairtype.ValueMember = "id"


        cbocustomer.DataSource = mcustomers
        cbocustomer.DisplayMember = "name"
        cbocustomer.ValueMember = "id"
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

End Class