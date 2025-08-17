Imports Microsoft.Data.SqlClient
Public Class security
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Empno = TextBox1.Text
        Dim Name = TextBox2.Text
        Dim Phonenumber = TextBox3.Text
        Dim Address = TextBox4.Text
        Dim Salary = TextBox5.Text
        If String.IsNullOrEmpty(Empno) Or
                String.IsNullOrEmpty(Name) Or
                String.IsNullOrEmpty(Phonenumber) Or
                String.IsNullOrEmpty(Address) Or
                String.IsNullOrEmpty(Salary) Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim query = "INSERT INTO securitytb(Empno,Name,Phonenumber,Address,Salary)VALUES(@Empno,@Name,@Phonenumber,@Address,@Salary)"
        Using con As New SqlConnection(connectionstring)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Empno", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Name", TextBox2.Text.Trim)
                cmd.Parameters.AddWithValue("@Phonenumber", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Address", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Salary", TextBox5.Text)
                con.Open
                cmd.ExecuteNonQuery
                con.Close
                TextBox1.Clear
                TextBox2.Clear
                TextBox3.Clear
                TextBox4.Clear
                TextBox5.Clear
            End Using
        End Using
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Empno As String = TextBox1.Text()
        Dim Name As String = TextBox2.Text()
        Dim Phonenumber As String = TextBox3.Text()
        Dim Address As String = TextBox4.Text()
        Dim Salary As String = TextBox5.Text
        If String.IsNullOrEmpty(Empno) Or
                String.IsNullOrEmpty(Name) Or
                String.IsNullOrEmpty(Phonenumber) Or
                String.IsNullOrEmpty(Address) Or
                String.IsNullOrEmpty(Salary) Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim query As String = "UPDATE securitytb SET Empno=@Empno,Name=@Name,Phonenumber=@Phonenumber,Address=@Address,Salary=@Salary WHERE Empno=@Empno"
        Using connection As New SqlConnection(connectionstring)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Empno", Empno)
                command.Parameters.AddWithValue("@Name", Name)
                command.Parameters.AddWithValue("@Phonenumber", Phonenumber)
                command.Parameters.AddWithValue("@Address", Address)
                command.Parameters.AddWithValue("Salary", Salary)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
            End Using
        End Using
    End Sub
End Class