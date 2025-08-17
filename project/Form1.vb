Public Class Form1
    Private Sub ADMIN_Click(sender As Object, e As EventArgs) Handles ADMIN.Click
        Dim b As New Admin_login_page
        b.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c As New user_login_page
        c.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
