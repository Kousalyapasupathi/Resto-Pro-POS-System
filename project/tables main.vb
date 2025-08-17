Imports Microsoft.Data.SqlClient
Public Class tables_main
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New tables
        a.Show()
    End Sub

    Private Sub tables_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Dim editbutton As New DataGridViewButtonColumn()
        editbutton.HeaderText = "Action"
        editbutton.Name = "Edit"
        editbutton.Text = "Edit"
        editbutton.UseColumnTextForButtonValue = True
        Guna2DataGridView1.Columns.Add(editbutton)
        Dim deleteButton As New DataGridViewButtonColumn()
        deleteButton.Name = "Delete"
        deleteButton.HeaderText = "Action"
        deleteButton.Text = "Delete"
        deleteButton.UseColumnTextForButtonValue = True
        Guna2DataGridView1.Columns.Add(deleteButton)
    End Sub
    Private Sub LoadData()
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT Tableno,Seats,BookingAmount,CASE WHEN Status=1 THEN 'Inactive' ELSE 'Active' END AS Status FROM tabletb"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            Guna2DataGridView1.DataSource = dataTable
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData()
    End Sub
    Private Sub SearchData(Tableno As Integer)
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT Tableno,Seats,Status,BookingAmount FROM tabletb WHERE Tableno LIKE @Tableno"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("Tableno", "%" & Tableno & "%")
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
        If e.ColumnIndex = Guna2DataGridView1.Columns("Edit").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedrow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            Dim tables As New tables()
            tables.TextBox1.Text = selectedrow.Cells("Tableno").Value.ToString()
            tables.TextBox2.Text = selectedrow.Cells("Seats").Value.ToString()
            tables.TextBox3.Text = selectedrow.Cells("BookingAmount").Value.ToString()
            tables.ShowDialog()
            LoadData()
        End If
        If e.ColumnIndex = Guna2DataGridView1.Columns("Delete").Index AndAlso e.RowIndex >= 0 Then
            Dim Tableno As Integer = Convert.ToInt32(Guna2DataGridView1.Rows(e.RowIndex).Cells("Tableno").Value)
            Using connection As New SqlConnection(connectionstring)
                connection.Open()
                Dim query As String = "DELETE FROM tabletb WHERE Tableno=@Tableno"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Tableno", Tableno)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadData()
        End If
    End Sub
End Class