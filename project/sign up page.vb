Imports Microsoft.Data.SqlClient
Public Class sign_up_page
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Dim i As New user_login_page()
        i.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = txtUs.Text
        Dim password As String = txtPa.Text
        Dim phonenumber As String = txtPh.Text
        If String.IsNullOrEmpty(username) Or
                String.IsNullOrEmpty(phonenumber) Or
                String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please Fill All Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim con As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Trust Server Certificate=True"
        Using connection As New SqlConnection(con),
            cmd As New SqlCommand("INSERT INTO usetb(username,password,phonenumber)VALUES(@u,@p,@ph)", connection)
            cmd.Parameters.AddWithValue("@u", txtUs.Text)
            cmd.Parameters.AddWithValue("@p", txtPa.Text)
            cmd.Parameters.AddWithValue("@ph", txtPh.Text)
            connection.Open()
            Dim res As Integer = Convert.ToInt32(cmd.ExecuteNonQuery())
            If res > 0 Then
                Dim j As New user_letlogin_page
                j.Show()
                Hide()
            Else
                MessageBox.Show("Login Error")
            End If
        End Using
    End Sub


End Class