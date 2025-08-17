Public Class adactivity
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim m As New adactivity()
        Panel4.Controls.Clear()
        categories_main.TopLevel = False
        categories_main.Visible = True
        Panel4.Controls.Add(categories_main)
        categories_main.Show()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim n As New adactivity()
        Panel4.Controls.Clear()
        menus_main.TopLevel = False
        menus_main.Visible = True
        Panel4.Controls.Add(menus_main)
        menus_main.Show()
    End Sub


    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim n As New adactivity()
        Panel4.Controls.Clear()
        staff_main.TopLevel = False
        staff_main.Visible = True
        Panel4.Controls.Add(staff_main)
        staff_main.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim n As New adactivity()
        Panel4.Controls.Clear()
        tables_main.TopLevel = False
        tables_main.Visible = True
        Panel4.Controls.Add(tables_main)
        tables_main.Show()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim n As New adactivity()
        Panel4.Controls.Clear()
        customer_main.TopLevel = False
        customer_main.Visible = True
        Panel4.Controls.Add(customer_main)
        customer_main.Show()
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs)
        Close
        Dim a As New Form1
        a.Show
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim a As New adactivity()
        Panel4.Controls.Clear()
        billing_main.TopLevel = False
        billing_main.Visible = True
        Panel4.Controls.Add(billing_main)
        billing_main.Show()
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Dim a As New adactivity
        Panel4.Controls.Clear
        report_main.TopLevel = False
        report_main.Visible = True
        Panel4.Controls.Add(report_main)
        report_main.Show()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Dim a As New adactivity
        Panel4.Controls.Clear
        reservationdetails.TopLevel = False
        reservationdetails.Visible = True
        Panel4.Controls.Add(reservationdetails)
        reservationdetails.Show
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Dim a As New Form1
        a.Show()
    End Sub

    Private Sub Guna2Button9_Click_1(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Dim a As New adactivity
        Panel4.Controls.Clear()
        admin_feedback.TopLevel = False
        admin_feedback.Visible = True
        Panel4.Controls.Add(admin_feedback)
        admin_feedback.Show()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class