Imports Microsoft.Data.SqlClient
Public Class reservationdetails
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    Private Sub reservationdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.Name = "Delete"
        deleteButton.HeaderText = "Action"
        deleteButton.Text = "Delete"
        deleteButton.UseColumnTextForButtonValue = True
        Guna2DataGridView1.Columns.Add(deleteButton)
    End Sub
    Private Sub LoadData()
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT SNO,Name,PhoneNumber,Dates,TimeFrom,TimeTo,Tableno,Seats,Total FROM tablebookingtb"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            Guna2DataGridView1.DataSource = dataTable
        End Using
    End Sub
    Private Sub SearchData(Dates As Integer)
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT SNO,Name,PhoneNumber,Dates,TimeFrom,TimeTo,Tableno,Seats,Total FROM tablebookingtb WHERE Dates LIKE @Dates"
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

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        If e.ColumnIndex = Guna2DataGridView1.Columns("Delete").Index AndAlso e.RowIndex >= 0 Then
            Dim SNO As Integer = Convert.ToInt32(Guna2DataGridView1.Rows(e.RowIndex).Cells("SNO").Value)
            Using connection As New SqlConnection(connectionstring)
                connection.Open()
                Dim query As String = "DELETE FROM tablebookingtb WHERE SNO=@SNO"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@SNO", SNO)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadData()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData()
    End Sub
End Class