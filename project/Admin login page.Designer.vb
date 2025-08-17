<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_login_page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_login_page))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtAdname = New TextBox()
        txtAdpass = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label8 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(180, 175)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(287, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(538, 31)
        Label1.TabIndex = 1
        Label1.Text = "YOUR DEDICATION MAKES ALL THE DIFFERENCE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(330, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 28)
        Label2.TabIndex = 2
        Label2.Text = "ADMIN NAME"
        ' 
        ' txtAdname
        ' 
        txtAdname.BorderStyle = BorderStyle.FixedSingle
        txtAdname.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAdname.Location = New Point(518, 139)
        txtAdname.Name = "txtAdname"
        txtAdname.Size = New Size(211, 30)
        txtAdname.TabIndex = 3
        ' 
        ' txtAdpass
        ' 
        txtAdpass.BorderStyle = BorderStyle.FixedSingle
        txtAdpass.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAdpass.Location = New Point(518, 198)
        txtAdpass.Name = "txtAdpass"
        txtAdpass.PasswordChar = "•"c
        txtAdpass.Size = New Size(211, 30)
        txtAdpass.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(330, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 28)
        Label3.TabIndex = 5
        Label3.Text = "PASSWORD"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.White
        Label4.Location = New Point(12, 642)
        Label4.Name = "Label4"
        Label4.Size = New Size(359, 20)
        Label4.TabIndex = 6
        Label4.Text = "64, Velavan's complex,Niran hospital opposite,palani."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 685)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 20)
        Label5.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.White
        Label6.Location = New Point(12, 662)
        Label6.Name = "Label6"
        Label6.Size = New Size(228, 20)
        Label6.TabIndex = 8
        Label6.Text = "contact: 9835674338,9456373455"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.White
        Label7.Location = New Point(12, 682)
        Label7.Name = "Label7"
        Label7.Size = New Size(276, 20)
        Label7.TabIndex = 9
        Label7.Text = "E-Mail: thecozyrestaurant12@gmail.com"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(462, 265)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 43)
        Button1.TabIndex = 10
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(198, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(42, 35)
        Button2.TabIndex = 11
        Button2.Text = "<--"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(1022, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(41, 35)
        Button3.TabIndex = 12
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.White
        Label8.Location = New Point(12, 702)
        Label8.Name = "Label8"
        Label8.Size = New Size(162, 20)
        Label8.TabIndex = 13
        Label8.Text = "www.thecozyplate.com"
        ' 
        ' Admin_login_page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1085, 735)
        Controls.Add(Label8)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtAdpass)
        Controls.Add(txtAdname)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "Admin_login_page"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin_login_page"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdname As TextBox
    Friend WithEvents txtAdpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
End Class
