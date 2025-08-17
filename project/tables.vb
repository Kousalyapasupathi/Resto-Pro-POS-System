Imports Microsoft.Data.SqlClient
Public Class tables
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Tableno As Integer = Convert.ToInt32(TextBox1.Text)
        Dim Seats As Integer = Convert.ToInt32(TextBox2.Text)
        Dim Amount As Integer = Convert.ToInt32(TextBox3.Text)
        Dim Status As Boolean = Guna2ToggleSwitch1.Checked
        If String.IsNullOrEmpty(Tableno) Or
                String.IsNullOrEmpty(Seats) Or
                String.IsNullOrEmpty(Amount) Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim query As String = "INSERT INTO tabletb (Tableno,Seats,Status,BookingAmount)VALUES(@Tableno,@Seats,@Status,@BookingAmount)"
        Using connection As New SqlConnection(connectionstring)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Tableno", Tableno)
                command.Parameters.AddWithValue("@Seats", Seats)
                command.Parameters.AddWithValue("@Status", Status)
                command.Parameters.AddWithValue("@BookingAmount", Amount)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Tableno As Integer = Convert.ToInt32(TextBox1.Text)
        Dim Seats As Integer = Convert.ToInt32(TextBox2.Text)
        Dim Amount As Integer = Convert.ToInt32(TextBox3.Text)
        Dim Status As Boolean = Guna2ToggleSwitch1.Checked
        If String.IsNullOrEmpty(Tableno) Or
                String.IsNullOrEmpty(Seats) Or
                String.IsNullOrEmpty(Amount) Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim query As String = "UPDATE tabletb SET Seats=@Seats,Status=@Status,BookingAmount=@BookingAmount WHERE Tableno=@Tableno"
        Using connection As New SqlConnection(connectionstring)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Seats", Seats)
                command.Parameters.AddWithValue("@Status", Status)
                command.Parameters.AddWithValue("@BookingAmount", Amount)
                command.Parameters.AddWithValue("@Tableno", Tableno)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
            End Using
        End Using
    End Sub
End Class