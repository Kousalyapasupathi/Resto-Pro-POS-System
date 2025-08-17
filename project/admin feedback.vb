Imports Microsoft.Data.SqlClient
Public Class admin_feedback
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
    Dim con As New SqlConnection("Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True")
    Private Sub admin_feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()
        LoadData("")
    End Sub
    Public Sub LoadCategories()
        Dim query As String = "SELECT * FROM feedbackstb"
        Using con As New SqlConnection(connectionstring)
            Dim cmd As New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            Guna2DataGridView1.DataSource = dt
        End Using
    End Sub
    Private Sub LoadData(filter As String)
        Dim query As String = "SELECT * FROM feedbackstb"
        If filter <> "" Then
            query &= " WHERE Ratings=@Ratings"
        End If
        Dim cmd As New SqlCommand(query, con)
        If filter <> "" Then
            cmd.Parameters.AddWithValue("@Ratings", filter)
        End If
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        Guna2DataGridView1.DataSource = dt
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        LoadData("★★★★★")
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        LoadData("★★★★")
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        LoadData("★★★")
    End Sub

    Private Sub Guna2CircleButton4_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton4.Click
        LoadData("★★")
    End Sub

    Private Sub Guna2CircleButton5_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton5.Click
        LoadData("★")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadData("")
    End Sub
End Class