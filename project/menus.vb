Imports System.IO
Imports Microsoft.Data.SqlClient
Public Class menus
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"

    Private Sub menus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategories()

    End Sub
    Private Sub LoadCategories()
        Using conn As New SqlConnection(connectionstring)
            conn.Open()
            Dim query As String = "SELECT DISTINCT name FROM categoriestb"
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    ComboBox1.Items.Clear()
                    While reader.Read()
                        ComboBox1.Items.Add(reader("name").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Idno As String = TextBox3.Text()
        Dim Name As String = TextBox1.Text()
        Dim Price As String = TextBox2.Text()
        Dim Category As String = ComboBox1.Text()
        If String.IsNullOrEmpty(Idno) Or
                String.IsNullOrEmpty(Name) Or
                String.IsNullOrEmpty(Price) Or
                String.IsNullOrEmpty(Category) Or
                Guna2PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim Pictures As Byte()
        Using ms As New MemoryStream()
            Guna2PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Pictures = ms.ToArray()
        End Using
        Dim query As String = "INSERT INTO menutb(Idno,Name,Price,Category,Pictures)VALUES(@Idno,@Name,@Price,@Category,@Pictures)"
        Using con As New SqlConnection(connectionstring)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Idno", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Name", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Price", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Category", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@Pictures", Pictures)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                Guna2PictureBox1.Image = Nothing
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openfiledialog As New OpenFileDialog()
        openfiledialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp"
        If openfiledialog.ShowDialog() = DialogResult.OK Then
            Guna2PictureBox1.Image = Image.FromFile(openfiledialog.FileName)
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Idno As String = TextBox3.Text()
        Dim Name As String = TextBox1.Text()
        Dim Price As String = TextBox2.Text()
        Dim Category As String = ComboBox1.Text()
        If String.IsNullOrEmpty(Idno) Or
                String.IsNullOrEmpty(Name) Or
                String.IsNullOrEmpty(Price) Or
                String.IsNullOrEmpty(Category) Or
                Guna2PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim Pictures As Byte()
        Using ms As New MemoryStream()
            Guna2PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Pictures = ms.ToArray()
        End Using
        Dim query As String = "UPDATE menutb SET Name=@Name,Price=@Price,Category=@Category,Pictures=@Pictures WHERE Idno=@Idno"
        Using connection As New SqlConnection(connectionstring)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Name", Name)
                command.Parameters.AddWithValue("@Price", Price)
                command.Parameters.AddWithValue("@Category", Category)
                command.Parameters.AddWithValue("@Pictures", Pictures)
                command.Parameters.AddWithValue("@Idno", Idno)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                Guna2PictureBox1.Image = Nothing
            End Using
        End Using
    End Sub
End Class