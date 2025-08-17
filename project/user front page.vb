Imports Microsoft.Data.SqlClient
Public Class user_front_page
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Dim a As New user_login_page
        a.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
        Dim a As New user_main
        a.Show()
    End Sub
End Class