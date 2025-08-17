<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_login_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_login_page))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label6 = New Label()
        Button2 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Label10 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Historic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(333, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 31)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME TO"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(189, 187)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Historic", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(243, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(344, 50)
        Label2.TabIndex = 2
        Label2.Text = """THE COZY PLATE"""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(243, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(361, 28)
        Label3.TabIndex = 3
        Label3.Text = "FLAVOURS THAT BRINGS US TOGETHER"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(102, 315)
        Label4.Name = "Label4"
        Label4.Size = New Size(123, 28)
        Label4.TabIndex = 4
        Label4.Text = "USERNAME"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(102, 382)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 28)
        Label5.TabIndex = 5
        Label5.Text = "PASSWORD"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(277, 316)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(181, 30)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(277, 382)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "•"c
        TextBox2.Size = New Size(181, 30)
        TextBox2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.White
        Button1.Location = New Point(198, 451)
        Button1.Name = "Button1"
        Button1.Size = New Size(114, 41)
        Button1.TabIndex = 8
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(105, 545)
        Label6.Name = "Label6"
        Label6.Size = New Size(197, 25)
        Label6.TabIndex = 9
        Label6.Text = "Don't have an account?"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(321, 541)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 10
        Button2.Text = "Sign Up"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.White
        Label7.Location = New Point(12, 642)
        Label7.Name = "Label7"
        Label7.Size = New Size(359, 20)
        Label7.TabIndex = 11
        Label7.Text = "64, Velavan's complex,Niran hospital opposite,palani."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = Color.White
        Label8.Location = New Point(12, 662)
        Label8.Name = "Label8"
        Label8.Size = New Size(228, 20)
        Label8.TabIndex = 12
        Label8.Text = "contact: 9835674338,9456373455"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.ForeColor = Color.White
        Label9.Location = New Point(12, 682)
        Label9.Name = "Label9"
        Label9.Size = New Size(276, 20)
        Label9.TabIndex = 13
        Label9.Text = "E-Mail: thecozyrestaurant12@gmail.com"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(208, 27)
        Button3.Name = "Button3"
        Button3.Size = New Size(42, 35)
        Button3.TabIndex = 14
        Button3.Text = "<-"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(1031, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(42, 35)
        Button4.TabIndex = 15
        Button4.Text = "X"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.ForeColor = Color.White
        Label10.Location = New Point(12, 702)
        Label10.Name = "Label10"
        Label10.Size = New Size(162, 20)
        Label10.TabIndex = 16
        Label10.Text = "www.thecozyplate.com"
        ' 
        ' user_login_page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1085, 735)
        Controls.Add(Label10)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button2)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "user_login_page"
        StartPosition = FormStartPosition.CenterScreen
        Text = "user_login_page"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label10 As Label
End Class
