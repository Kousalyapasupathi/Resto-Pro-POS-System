Imports Microsoft.Data.SqlClient
Public Class user_letlogin_page

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
        Dim username As String = ""
        Dim password As String = ""
        Using connection As New SqlConnection(con)
            Dim query As String = "SELECT COUNT(*) FROM usetb WHERE username=@u AND password=@p"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@u", TextBox1.Text)
            command.Parameters.AddWithValue("@p", TextBox2.Text)
            connection.Open()
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
            If result > 0 Then
                Dim j As New user_front_page
                j.Show()
                Hide()
            Else
                MessageBox.Show("Re-Enter properly")
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Dim k As New sign_up_page
        k.Show()
    End Sub
End Class