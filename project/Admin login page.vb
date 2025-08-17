
Imports Microsoft.Data.SqlClient
Public Class Admin_login_page
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
        Dim adminname As String = ""
        Dim password As String = ""
        Using connection As New SqlConnection(con)
            Dim query As String = "SELECT COUNT(*) FROM admintb WHERE adminname=@adminname AND password=@password"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@adminname", txtAdname.Text)
            command.Parameters.AddWithValue("@password", txtAdpass.Text)
            connection.Open()
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
            If result > 0 Then
                Dim f As New adactivity
                f.Show()
                Hide()
            Else
                MessageBox.Show("Login Error")
            End If

        End Using



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class