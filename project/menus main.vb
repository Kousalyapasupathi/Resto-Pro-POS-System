Imports Microsoft.Data.SqlClient
Public Class menus_main
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o As New menus
        o.Show()
    End Sub

    Private Sub menus_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim query As String = "SELECT Idno,Name,Price,Category FROM menutb"
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
            Dim query As String = "SELECT Idno,Name,Price,Category FROM menutb WHERE Name LIKE @Name"
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

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        If e.ColumnIndex = Guna2DataGridView1.Columns("Edit").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedrow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            Dim menus As New menus()
            menus.TextBox3.Text = selectedrow.Cells("Idno").Value.ToString()
            menus.TextBox1.Text = selectedrow.Cells("Name").Value.ToString()
            menus.TextBox2.Text = selectedrow.Cells("Price").Value.ToString()
            menus.ComboBox1.Text = selectedrow.Cells("Category").Value.ToString()
            menus.ShowDialog()
            LoadData()
        End If
        If e.ColumnIndex = Guna2DataGridView1.Columns("Delete").Index AndAlso e.RowIndex >= 0 Then
            Dim Idno As Integer = Convert.ToInt32(Guna2DataGridView1.Rows(e.RowIndex).Cells("Idno").Value)
            Using connection As New SqlConnection(connectionstring)
                connection.Open()
                Dim query As String = "DELETE FROM menutb WHERE Idno=@Idno"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Idno", Idno)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadData()
        End If
    End Sub
End Class