Imports Microsoft.Data.SqlClient
Public Class staff_main
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim n As New staff_main()
        Panel2.Controls.Clear()
        waiter_main.TopLevel = False
        waiter_main.Visible = True
        Panel2.Controls.Add(waiter_main)
        waiter_main.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim n As New staff_main()
        Panel2.Controls.Clear()
        cooks_main.TopLevel = False
        cooks_main.Visible = True
        Panel2.Controls.Add(cooks_main)
        cooks_main.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim n As New staff_main()
        Panel2.Controls.Clear()
        security_main.TopLevel = False
        security_main.Visible = True
        Panel2.Controls.Add(security_main)
        security_main.Show()
    End Sub
End Class