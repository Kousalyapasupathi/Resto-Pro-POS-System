<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tablepaytm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tablepaytm))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Label1 = New Label()
        Label4 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrange
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(55, 153)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkOrange
        Panel2.Location = New Point(435, 425)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(55, 153)
        Panel2.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(411, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(79, 79)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(73, 213)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 20)
        Label7.TabIndex = 14
        Label7.Text = "NAME"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(272, 213)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 20)
        Label6.TabIndex = 15
        Label6.Text = "PHONENUMBER"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(58, 296)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 20)
        Label5.TabIndex = 16
        Label5.Text = "DATE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(271, 296)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 20)
        Label8.TabIndex = 17
        Label8.Text = "FROM"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(383, 296)
        Label9.Name = "Label9"
        Label9.Size = New Size(28, 20)
        Label9.TabIndex = 18
        Label9.Text = "TO"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(73, 236)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 19
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(272, 236)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 20
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(272, 319)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(68, 27)
        TextBox3.TabIndex = 21
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(374, 319)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(68, 27)
        TextBox4.TabIndex = 22
        ' 
        ' Guna2DateTimePicker1
        ' 
        Guna2DateTimePicker1.Checked = True
        Guna2DateTimePicker1.CustomizableEdges = CustomizableEdges1
        Guna2DateTimePicker1.FillColor = Color.DarkOrange
        Guna2DateTimePicker1.Font = New Font("Segoe UI", 9F)
        Guna2DateTimePicker1.Format = DateTimePickerFormat.Long
        Guna2DateTimePicker1.Location = New Point(58, 319)
        Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2DateTimePicker1.Size = New Size(181, 27)
        Guna2DateTimePicker1.TabIndex = 23
        Guna2DateTimePicker1.Value = New Date(2025, 2, 20, 10, 7, 27, 358)
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.FillThickness = 2
        Guna2Separator1.Location = New Point(1, 371)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(489, 10)
        Guna2Separator1.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(121, 400)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 20)
        Label1.TabIndex = 25
        Label1.Text = "TABLENO"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(259, 400)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 26
        Label4.Text = "SEATS"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(121, 425)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(77, 27)
        TextBox5.TabIndex = 27
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(259, 425)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(52, 27)
        TextBox6.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(136, 471)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 25)
        Label2.TabIndex = 29
        Label2.Text = "AMOUNT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(244, 471)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 25)
        Label3.TabIndex = 30
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.DarkOrange
        Guna2Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.Location = New Point(124, 499)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(199, 56)
        Guna2Button1.TabIndex = 31
        Guna2Button1.Text = "PAY"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(152, 47)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(171, 125)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 32
        PictureBox2.TabStop = False
        ' 
        ' tablepaytm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(490, 576)
        Controls.Add(PictureBox2)
        Controls.Add(Guna2Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Guna2Separator1)
        Controls.Add(Guna2DateTimePicker1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "tablepaytm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "tablepaytm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
