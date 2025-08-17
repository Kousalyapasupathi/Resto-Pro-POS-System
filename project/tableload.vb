Public Class tableload
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        tableconfirmation.Show()
        Timer1.Stop()
    End Sub
End Class