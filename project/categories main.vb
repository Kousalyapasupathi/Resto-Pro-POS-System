Imports System.DirectoryServices
Imports System.Drawing.Text
Imports Microsoft.Data.SqlClient
Public Class categories_main
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"

    Private Sub categories_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
    End Sub

    Public Sub LoadCategories()
        Dim query As String = "SELECT * FROM categoriestb"
        Using con As New SqlConnection(connectionstring)
            Dim cmd As New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            Guna2DataGridView1.DataSource = dt
        End Using
        If Not Guna2DataGridView1.Columns.Contains("Delete") Then
            Dim deletebutton As New DataGridViewButtonColumn()
            deletebutton.HeaderText = "Action"
            deletebutton.Text = "Delete"
            deletebutton.UseColumnTextForButtonValue = True
            deletebutton.Name = "Delete"
            Guna2DataGridView1.Columns.Add(deletebutton)
        End If
        Guna2DataGridView1.Columns("id").DisplayIndex = 0
        Guna2DataGridView1.Columns("name").DisplayIndex = 1
        Guna2DataGridView1.Columns("Delete").DisplayIndex = 2
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim l As New categories
        l.Show()

    End Sub
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        If e.ColumnIndex = Guna2DataGridView1.Columns("Delete").Index AndAlso e.RowIndex >= 0 Then
            Dim id As Integer = Convert.ToInt32(Guna2DataGridView1.Rows(e.RowIndex).Cells("id").Value)
            DeleteFromDatabase(id)
            Guna2DataGridView1.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub
    Private Sub DeleteFromDatabase(id As Integer)
        Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
        Using connection As New SqlConnection(connectionstring)
            connection.Open()
            Dim query As String = "DELETE FROM categoriestb WHERE id=@id"
            Using Command As New SqlCommand(query, connection)
                Command.Parameters.AddWithValue("@id", id)
                Command.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadCategories()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim name As String = Guna2TextBox1.Text
        SearchCategory(name)
    End Sub
    Private Sub SearchCategory(name As String)
        Dim query As String = "SELECT id,name FROM categoriestb WHERE name LIKE @name"
        Using conn As New SqlConnection(connectionstring)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", "%" & name & "%")
                Try
                    conn.Open()
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Guna2DataGridView1.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show("Search not found")
                End Try
            End Using
        End Using
    End Sub
End Class