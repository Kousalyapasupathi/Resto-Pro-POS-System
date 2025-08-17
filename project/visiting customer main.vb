Imports Microsoft.Data.SqlClient
Public Class visiting_customer_main
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New visiting_customer
        a.Show()
    End Sub

    Private Sub visiting_customer_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT Name,Phonenumber FROM vcustomertb"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            Guna2DataGridView1.DataSource = dataTable
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData()
    End Sub
    Private Sub SearchData(Name As String)
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT Name,Phonenumber FROM vcustomertb WHERE Name LIKE @Name"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("Name", "%" & Name & "%")
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