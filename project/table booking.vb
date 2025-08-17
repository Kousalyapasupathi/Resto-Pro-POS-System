Imports Microsoft.Data.SqlClient
Public Class table_booking
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    Public Sub cleartextboxes()
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Label12.Text = ""
        Guna2DataGridView2.DataSource = Nothing
        Guna2DataGridView2.Rows.Clear()
    End Sub
    Private Sub table_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT Tableno,Seats,BookingAmount FROM tabletb"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            Guna2DataGridView1.DataSource = dataTable
        End Using
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedrow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            TextBox3.Text = selectedrow.Cells("Tableno").Value.ToString()
            TextBox4.Text = selectedrow.Cells("Seats").Value.ToString()
            TextBox5.Text = selectedrow.Cells("BookingAmount").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Tableno = TextBox3.Text
        Dim Seats As String = Convert.ToInt32(TextBox4.Text)
        Dim BookingAmount = Convert.ToDecimal(TextBox5.Text)
        Dim rowindex = Guna2DataGridView2.Rows.Add
        Guna2DataGridView2.Rows(rowindex).Cells("Tableno").Value = Tableno
        Guna2DataGridView2.Rows(rowindex).Cells("Seats").Value = Seats
        Guna2DataGridView2.Rows(rowindex).Cells("BookingAmount").Value = BookingAmount
        UpdateTotalamount()
    End Sub
    Private Sub UpdateTotalamount()
        Dim totalamount As Decimal = 0
        For Each row As DataGridViewRow In Guna2DataGridView2.Rows
            If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("BookingAmount").Value) Then
                totalamount += Convert.ToDecimal(row.Cells("BookingAmount").Value)
            End If
        Next
        Label12.Text = "" & totalamount.ToString("0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Guna2DataGridView2.Rows.Clear()
        Label12.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        Dim a As New user_main
        a.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        tablepay1.passedtext = Label12.Text
        tablepay1.text3 = TextBox3.Text
        tablepay1.text4 = TextBox4.Text
        Dim a As New tablepay1
        a.Show()
    End Sub
End Class