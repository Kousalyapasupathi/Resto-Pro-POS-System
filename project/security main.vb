Imports Microsoft.Data.SqlClient
Public Class security_main
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New security
        a.Show()
    End Sub

    Private Sub security_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim query As String = "SELECT Empno,Name,Phonenumber,Address,Salary FROM securitytb"
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
            Dim query As String = "SELECT Empno,Name,Phonenumber,Address,Salary FROM securitytb WHERE Name LIKE @Name"
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
            Dim security As New security()
            security.TextBox1.Text = selectedrow.Cells("Empno").Value.ToString()
            security.TextBox2.Text = selectedrow.Cells("Name").Value.ToString()
            security.TextBox3.Text = selectedrow.Cells("Phonenumber").Value.ToString()
            security.TextBox4.Text = selectedrow.Cells("Address").Value.ToString()
            security.TextBox5.Text = selectedrow.Cells("Salary").Value.ToString()
            security.ShowDialog()
            LoadData()
        End If
        If e.ColumnIndex = Guna2DataGridView1.Columns("Delete").Index AndAlso e.RowIndex >= 0 Then
            Dim Empno As Integer = Convert.ToInt32(Guna2DataGridView1.Rows(e.RowIndex).Cells("Empno").Value)
            Using connection As New SqlConnection(connectionstring)
                connection.Open()
                Dim query As String = "DELETE FROM securitytb WHERE Empno=@Empno"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Empno", Empno)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadData()
        End If
    End Sub
End Class