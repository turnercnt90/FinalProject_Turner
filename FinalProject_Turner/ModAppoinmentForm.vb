Public Class ModAppointmentForm
    Private mAppointments As New Appointments
    Private mservicetype As New ServiceTypes
    Private mcustomers As New Customers
    Public Property appointmentid As Short
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' mAppointments.insert(2, "fix disposal", False, 1020, #10/5/2015 9:00 AM#)
        'Appointmentsform.ShowDialog() '
        Dim Scheduledat As DateTime
        Try
            Scheduledat = Appointments.combinedDateTime(dtpdate.Value.Date, CDate(txttime.Text))
        Catch
            errprovider.SetError(txttime, "please enter a valid appointment time")
            Return

        End Try
        Dim typeid As Short = CShort(cborepairtype.SelectedValue)
        Dim custid As Short = CShort(cbocustomer.SelectedValue)
        Dim licensed As Boolean = chklicensed.Checked
        If mAppointments.update(typeid, txtdescription.Text, licensed, custid, Scheduledat, appointmentid) Then
            Me.Close()
        Else
            lblstatus.Text = "cannot update appointment." _
                & Appointments.lasterror

        End If
    End Sub

    Private Sub NewAppointmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fill the repair types combo box

        cborepairtype.DataSource = mrepairtypes.items
        cborepairtype.DisplayMember = "description"
        cborepairtype.ValueMember = "typeid"


        cbocustomer.DataSource = mcustomers.items
        cbocustomer.DisplayMember = "name"
        cbocustomer.ValueMember = "custid"
        Dim row As RepairServicesDataSet.AppointmentsRow
        row = mAppointments.findbyapptid(appointmentid)
        dtpdate.Value = row.Scheduled.Date
        txttime.Text = row.Scheduled.TimeOfDay.ToString
        chklicensed.Checked = row.Licensed
        txtdescription.Text = row.Description
        cborepairtype.SelectedValue = row.TypeId
        cbocustomer.SelectedValue = row.CustId

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

End Class
