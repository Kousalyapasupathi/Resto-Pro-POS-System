Imports Microsoft.Data.SqlClient
Public Class website_customer_main
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"

    Private Sub website_customer_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT username,phonenumber FROM usetb"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            Guna2DataGridView1.DataSource = dataTable
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
    End Sub
    Private Sub SearchData(username As String)
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT username,phonenumber FROM usetb WHERE username LIKE @username"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("username", "%" & username & "%")
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            Guna2DataGridView1.DataSource = dataTable
        End Using
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim searchName As String = TextBox1.Text.Trim()
        SearchData(searchName)
    End Sub
End Class