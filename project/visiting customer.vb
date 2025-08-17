Imports Microsoft.Data.SqlClient
Public Class visiting_customer
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Name As String = TextBox1.Text()
        Dim Phonenumber As String = TextBox2.Text()
        If String.IsNullOrEmpty(Name) Or
                String.IsNullOrEmpty(Phonenumber) Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim query As String = "INSERT INTO vcustomertb(Name,Phonenumber)VALUES(@Name,@Phonenumber)"
        Using con As New SqlConnection(connectionstring)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Name", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Phonenumber", TextBox2.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Clear()
                TextBox2.Clear()
            End Using
        End Using
    End Sub
End Class