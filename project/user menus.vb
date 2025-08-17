Imports Microsoft.Data.SqlClient
Imports System.IO
Public Class user_menus
    Dim connectionstring As String = "Data Source=LAPTOP-JS2OTVSB\SQLEXPRESS;Initial Catalog=admindbs;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    Private Sub loadmenuitems()
        Try
            Dim query As String = "SELECT Name,Pictures,Price FROM menutb"
            Using con As New SqlConnection(connectionstring)
                Using cmd As New SqlCommand(query, con)
                    con.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim menuitem As New menu_image()
                            menuitem.Nam = reader("Name").ToString()
                            menuitem.Pri = reader("Price").ToString()
                            Dim imagedata As Byte() = TryCast(reader("Pictures"), Byte())
                            If imagedata IsNot Nothing Then
                                Using ms As New MemoryStream(imagedata)
                                    menuitem.Pictures = Image.FromStream(ms)
                                End Using
                            End If
                            FlowLayoutPanel1.Controls.Add(menuitem)
                        End While
                        reader.Close()
                        con.Close()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        End Try
    End Sub

    Private Sub user_menus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadmenuitems()
    End Sub
    Public Class bufferedflowlayoutpanel
        Inherits FlowLayoutPanel
        Public Sub New()
            Me.DoubleBuffered = True
        End Sub
    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Dim a As New user_main
        a.Show()
    End Sub
End Class