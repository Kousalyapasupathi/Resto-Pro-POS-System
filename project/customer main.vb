Imports Microsoft.Data.SqlClient
Public Class customer_main
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim n As New customer_main()
        Panel2.Controls.Clear()
        visiting_customer_main.TopLevel = False
        visiting_customer_main.Visible = True
        Panel2.Controls.Add(visiting_customer_main)
        visiting_customer_main.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim n As New customer_main()
        Panel2.Controls.Clear()
        website_customer_main.TopLevel = False
        website_customer_main.Visible = True
        Panel2.Controls.Add(website_customer_main)
        website_customer_main.Show()
    End Sub
End Class