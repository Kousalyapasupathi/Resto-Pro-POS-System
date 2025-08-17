Public Class tableconfirmation
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
        For Each frm As Form In Application.OpenForms
            If TypeOf frm Is table_booking Then
                DirectCast(frm, table_booking).cleartextboxes()
                Exit For
            End If
        Next
    End Sub
End Class