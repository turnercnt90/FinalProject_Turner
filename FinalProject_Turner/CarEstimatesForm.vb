Public Class CarEstimatesForm
    Private Sub ChkFamilyDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFamilyDiscount.CheckedChanged

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim response As MsgBoxResult
        response = MsgBox("Do you want to close form?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub

        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtFindCustomer.Clear()
        ChkFamilyDiscount.Checked = False
        ChkStudentDiscount.Checked = False
        ListBox1.ClearSelected()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NewAppointmentForm.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Appointmentsform.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        CustomersForm.ShowDialog()
    End Sub

    Private Sub AppointmentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppointmentListToolStripMenuItem.Click
        Appointment_List.ShowDialog()
    End Sub
End Class
