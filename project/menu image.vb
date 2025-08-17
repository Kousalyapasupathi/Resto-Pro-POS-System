Public Class menu_image
    Public Property Nam As String
        Get
            Return Label1.Text
        End Get
        Set(value As String)
            Label1.Text = value
        End Set
    End Property
    Public Property Pictures As Image
        Get
            Return PictureBox1.Image
        End Get
        Set(value As Image)
            PictureBox1.Image = value
        End Set
    End Property

    Public Property Pri As Integer
        Get
            Return Label2.Text
        End Get
        Set(value As Integer)
            Label2.Text = value
        End Set
    End Property
End Class
