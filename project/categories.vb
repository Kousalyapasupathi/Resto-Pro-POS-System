Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.Data.SqlClient
Public Class categories
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim id As String = TextBox1.Text()
        Dim name As String = TextBox2.Text()
        If String.IsNullOrEmpty(id) Or
                String.IsNullOrEmpty(name) Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim query As String = "INSERT INTO categoriestb(id,name)VALUES(@id,@name)"
        Using con As New SqlConnection(connectionstring)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", TextBox1.Text)
                cmd.Parameters.AddWithValue("@name", TextBox2.Text.Trim())
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Clear()
                TextBox2.Clear()
            End Using
        End Using
    End Sub
End Class