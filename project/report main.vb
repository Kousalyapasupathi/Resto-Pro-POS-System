Imports Microsoft.Data.SqlClient
Public Class report_main
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
    Private Sub report_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT SNO,Dates,Total FROM billtb"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            Guna2DataGridView1.DataSource = dataTable
        End Using
    End Sub
    Private Sub SearchData(Dates As String)
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT SNO,Dates,Total FROM billtb WHERE Dates LIKE @Dates"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("Dates", "%" & Dates & "%")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
    End Sub
End Class