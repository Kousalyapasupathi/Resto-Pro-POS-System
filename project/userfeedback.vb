Imports Guna.UI2.WinForms
Imports Microsoft.Data.SqlClient
Public Class userfeedback
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As String = TextBox1.Text()
        Dim EmailID As String = TextBox2.Text()
        Dim Ratings As String = ComboBox1.Text()
        Dim Feedback As String = TextBox3.Text()
        If String.IsNullOrEmpty(Name) Or
               String.IsNullOrEmpty(EmailID) Or
               String.IsNullOrEmpty(Ratings) Or
               String.IsNullOrEmpty(Feedback) Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim query As String = "INSERT INTO feedbackstb(Name,EmailID,Ratings,Feedback)VALUES(@Name,@EmailID,@Ratings,@Feedback)"
        Using con As New SqlConnection(connectionstring)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Name", TextBox1.Text)
                cmd.Parameters.AddWithValue("@EmailID", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Ratings", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@Feedback", TextBox3.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Dim a As New user_main
        a.Show()
    End Sub
End Class