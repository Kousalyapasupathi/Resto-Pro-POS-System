<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_front_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_front_page))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Label4 = New Label()
        Button1 = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(444, 58)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(209, 195)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Script MT Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(358, 269)
        Label1.Name = "Label1"
        Label1.Size = New Size(391, 41)
        Label1.TabIndex = 1
        Label1.Text = "Welcome to The Cozy Plate"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(375, 349)
        Label3.Name = "Label3"
        Label3.Size = New Size(343, 200)
        Label3.TabIndex = 3
        Label3.Text = resources.GetString("Label3.Text")
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(783, 79)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(275, 231)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(27, 459)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(284, 240)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrange
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(116, 227)
        Panel1.TabIndex = 6
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.DarkOrange
        Guna2Button1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.Location = New Point(873, 630)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(185, 56)
        Guna2Button1.TabIndex = 7
        Guna2Button1.Text = "Next >>"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(392, 583)
        Label4.Name = "Label4"
        Label4.Size = New Size(316, 28)
        Label4.TabIndex = 8
        Label4.Text = "Open Time: 9:00 AM - 12:00 PM"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOrange
        Button1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(144, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(46, 36)
        Button1.TabIndex = 9
        Button1.Text = "<-"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.White
        Label6.Location = New Point(375, 650)
        Label6.Name = "Label6"
        Label6.Size = New Size(359, 20)
        Label6.TabIndex = 11
        Label6.Text = "64, Velavan's complex,Niran hospital opposite,palani."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.White
        Label5.Location = New Point(425, 670)
        Label5.Name = "Label5"
        Label5.Size = New Size(228, 20)
        Label5.TabIndex = 12
        Label5.Text = "contact: 9835674338,9456373455"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.ForeColor = Color.White
        Label7.Location = New Point(411, 690)
        Label7.Name = "Label7"
        Label7.Size = New Size(276, 20)
        Label7.TabIndex = 13
        Label7.Text = "E-Mail: thecozyrestaurant12@gmail.com"
        ' 
        ' user_front_page
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1085, 737)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Guna2Button1)
        Controls.Add(Panel1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "user_front_page"
        StartPosition = FormStartPosition.CenterScreen
        Text = "user_front_page"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
