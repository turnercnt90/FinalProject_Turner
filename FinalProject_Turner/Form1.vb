Public Class Form1
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
End Class
