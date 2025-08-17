Imports System.Security.Permissions
Imports System.Drawing.Printing
Imports Microsoft.Data.SqlClient
Public Class billing_main
    Private printfont As Font
    Private printdocument As New PrintDocument()
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"

    Private Sub billing_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        Using connection As New SqlConnection(connectionstring)
            Dim query As String = "SELECT Idno,Name,Price FROM menutb"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            Guna2DataGridView1.DataSource = dataTable
        End Using
    End Sub

    Private Sub Guna2DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedrow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            TextBox3.Text = selectedrow.Cells("Name").Value.ToString()
            TextBox4.Text = selectedrow.Cells("Price").Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Itemname As String = TextBox3.Text
        Dim Price As String = Convert.ToDecimal(TextBox4.Text)
        Dim Quantity As String = Convert.ToInt32(TextBox5.Text)
        Dim Total As Decimal = Price * Quantity
        Dim rowindex As Integer = Guna2DataGridView2.Rows.Add()
        Guna2DataGridView2.Rows(rowindex).Cells("Itemname").Value = Itemname
        Guna2DataGridView2.Rows(rowindex).Cells("Price").Value = Price
        Guna2DataGridView2.Rows(rowindex).Cells("Quantity").Value = Quantity
        Guna2DataGridView2.Rows(rowindex).Cells("Total").Value = Total
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        UpdateTotalamount()
    End Sub
    Private Sub UpdateTotalamount()
        Dim totalamount As Decimal = 0
        For Each row As DataGridViewRow In Guna2DataGridView2.Rows
            If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("Total").Value) Then
                totalamount += Convert.ToDecimal(row.Cells("Total").Value)
            End If
        Next
        Label1.Text = "" & totalamount.ToString("0.00")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim printpreview As New PrintPreviewDialog()
        printpreview.Document = PrintDocument1
        printpreview.ShowDialog()
        Dim Dat As Date = Guna2DateTimePicker1.Value.Date
        Dim Total As Decimal = Label1.Text
        Dim query As String = "INSERT INTO billtb (Dates,Total)VALUES(@Dates,@Total)"
        Using con As New SqlConnection(connectionstring)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@Dates", Guna2DateTimePicker1.Value.Date)
                cmd.Parameters.AddWithValue("@Total", Label1.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
        Guna2DataGridView2.Rows.Clear()
        Label1.Text = ""
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("THE COZY PLATE", New Font("Arial", 34, FontStyle.Bold), Brushes.Black, 230, 31)
        e.Graphics.DrawString("64, Velavan's complex,Niran hospital opposite,palani.", New Font("Arial", 23), Brushes.Black, 50, 100)
        e.Graphics.DrawString("------------------------------------------------------", New Font("Arial", 34, FontStyle.Bold), Brushes.Black, 0, 130)
        e.Graphics.DrawString("***Your Bill***", New Font("Arial", 28), Brushes.Black, 300, 180)

        Dim x As Integer = 100
        Dim y As Integer = 250
        Dim rowheight As Integer = 40
        Dim columnwidths As Integer() = {210, 210, 210, 210}
        printfont = New Font("Arial", 20, FontStyle.Bold)
        For i As Integer = 0 To Guna2DataGridView2.Columns.Count - 1
            e.Graphics.DrawString(Guna2DataGridView2.Columns(i).HeaderText, printfont, Brushes.Black, x, y)
            x += columnwidths(i)
        Next
        y += rowheight
        x = 100
        For Each row As DataGridViewRow In Guna2DataGridView2.Rows
            If row.IsNewRow Then Continue For
            For i As Integer = 0 To Guna2DataGridView2.Columns.Count - 1
                e.Graphics.DrawString(row.Cells(i).Value.ToString(), printfont, Brushes.Black, x, y)
                x += columnwidths(i)
            Next
            y += rowheight
            x = 100
        Next
        e.Graphics.DrawString("------------------------------------------------------", New Font("Arial", 34, FontStyle.Bold), Brushes.Black, 0, 600)
        e.Graphics.DrawString("Date: " + Guna2DateTimePicker1.Value.Date.ToString("dd-MM-yyyy"), New Font("Arial", 21, FontStyle.Bold), Brushes.Black, 10, 660)
        e.Graphics.DrawString("Total amount: " + Label1.Text.ToString(), New Font("Arial", 21, FontStyle.Bold), Brushes.Black, 530, 660)
        e.Graphics.DrawString("**********THANK YOU**********", New Font("Arial", 18), Brushes.Crimson, 230, 720)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Guna2DataGridView2.Rows.Clear()
        Label1.Text = ""
    End Sub
End Class