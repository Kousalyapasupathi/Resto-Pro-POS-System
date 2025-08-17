Imports Microsoft.Data.SqlClient
Public Class tablegpay
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
    Private Sub tablegpay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = tablepay1.passedtext
        TextBox1.Text = tablepay1.text3
        TextBox2.Text = tablepay1.text4
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Name As String = TextBox3.Text
        Dim PhoneNumber As String = TextBox4.Text
        Dim Dates As Date = Guna2DateTimePicker1.Value.Date
        Dim TimeFrom As String = TextBox5.Text
        Dim TimeTo As String = TextBox6.Text
        Dim Tableno As Integer = TextBox1.Text
        Dim Seats As Integer = TextBox2.Text
        Dim Total As Decimal = Label3.Text
        Dim query As String = "INSERT INTO tablebookingtb (Name,PhoneNumber,Dates,TimeFrom,TimeTo,Tableno,Seats,Total)VALUES(@Name,@PhoneNumber,@Dates,@TimeFrom,@TimeTo,@Tableno,@Seats,@Total)"
        Using con As New SqlConnection(connectionstring)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Name", TextBox3.Text)
                cmd.Parameters.AddWithValue("@PhoneNumber", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Dates", Guna2DateTimePicker1.Value.Date)
                cmd.Parameters.AddWithValue("@TimeFrom", TextBox5.Text)
                cmd.Parameters.AddWithValue("@TimeTo", TextBox6.Text)
                cmd.Parameters.AddWithValue("@Tableno", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Seats", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Total", Label3.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        tableload.Timer1.Start()
        tableload.Show()
        Close()
    End Sub
End Class