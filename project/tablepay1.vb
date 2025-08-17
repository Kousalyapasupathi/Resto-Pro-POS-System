Public Class tablepay1
    Public Shared passedtext As String
    Public Shared text3 As String
    Public Shared text4 As String
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
        Dim a As New tablegpay
        a.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Close()
        Dim a As New tablepaytm
        a.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Close()
        Dim a As New tablephonepe
        a.Show()
    End Sub
End Class