Public Class Appointmentsform
    Private mappointments As New Appointments
    Private mcustomers As New Customers
    Private formloading As Boolean = True
    Private Sub Appointmentsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EstimateServicesDataSet.Appointment1' table. You can move, or remove it, as needed.
        Me.Appointment1TableAdapter.Fill(Me.EstimateServicesDataSet.Appointment1)
        'TODO: This line of code loads data into the 'RepairServicesDataSet.Appointments' table. You can move, or remove it, as needed.
        ' Me.AppointmentsTableAdapter.Fill(Me.RepairServicesDataSet.Appointments)
        With cboCustomer.ComboBox
            .DataSource = mcustomers.items
            .DisplayMember = "name"
            .ValueMember = "id"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1
        End With
        formloading = False
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        dgvappointments.DataSource = mappointments.items
    End Sub

    Private Sub cboCustomer_selectedindexchanged() _
        Handles cboCustomer.SelectedIndexChanged
        If Not formloading Then
            Dim custid As Short =
                CShort(cboCustomer.ComboBox.SelectedValue)
            dgvappointments.DataSource = mappointments.getbycustomerid(custid)

        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If dgvappointments.SelectedRows.Count > 0 Then
            Dim apptid As Short = CShort(dgvappointments.SelectedRows(0).Cells(0).Value)
            Dim frm As New NewAppointmentForm
            frm. =
            frm.ShowDialog()
            dgvappointments.DataSource = mappointments.items
        Else
            MessageBox.Show("please select the appointment to edit")

        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgvappointments.SelectedRows.Count > 0 Then
            Dim apptid As Short = CShort(dgvappointments.SelectedRows(0).Cells(0).Value)
            If mappointments.delete(apptid) Then
                dgvappointments.DataSource = mappointments.items
            Else
                MessageBox.Show("unable to delete this appointment")
            End If
        End If
    End Sub
End Class