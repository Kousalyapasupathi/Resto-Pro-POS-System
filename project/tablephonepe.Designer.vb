<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tablephonepe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tablephonepe))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label7 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label5 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Label1 = New Label()
        Label4 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
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
        Panel1.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkOrange
        Panel2.Location = New Point(436, 424)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(55, 153)
        Panel2.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(412, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(79, 79)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(134, 61)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(208, 128)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(76, 220)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 20)
        Label7.TabIndex = 15
        Label7.Text = "NAME"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(275, 220)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 20)
        Label6.TabIndex = 16
        Label6.Text = "PHONENUMBER"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(76, 243)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 17
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(275, 243)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(41, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 20)
        Label5.TabIndex = 19
        Label5.Text = "DATE"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(259, 295)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 20)
        Label8.TabIndex = 20
        Label8.Text = "FROM"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(372, 295)
        Label9.Name = "Label9"
        Label9.Size = New Size(28, 20)
        Label9.TabIndex = 21
        Label9.Text = "TO"
        ' 
        ' Guna2DateTimePicker1
        ' 
        Guna2DateTimePicker1.Checked = True
        Guna2DateTimePicker1.CustomizableEdges = CustomizableEdges1
        Guna2DateTimePicker1.FillColor = Color.DarkOrange
        Guna2DateTimePicker1.Font = New Font("Segoe UI", 9F)
        Guna2DateTimePicker1.Format = DateTimePickerFormat.Long
        Guna2DateTimePicker1.Location = New Point(41, 318)
        Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2DateTimePicker1.Size = New Size(179, 29)
        Guna2DateTimePicker1.TabIndex = 22
        Guna2DateTimePicker1.Value = New Date(2025, 2, 20, 11, 43, 45, 501)
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(259, 318)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(84, 27)
        TextBox3.TabIndex = 23
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(372, 318)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(83, 27)
        TextBox4.TabIndex = 24
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.FillThickness = 2
        Guna2Separator1.Location = New Point(2, 365)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(489, 10)
        Guna2Separator1.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(115, 403)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 20)
        Label1.TabIndex = 26
        Label1.Text = "TABLENO"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(259, 403)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 27
        Label4.Text = "SEATS"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(115, 426)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(86, 27)
        TextBox5.TabIndex = 28
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(259, 424)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(65, 27)
        TextBox6.TabIndex = 29
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(134, 481)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 25)
        Label2.TabIndex = 30
        Label2.Text = "AMOUNT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(246, 481)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 25)
        Label3.TabIndex = 31
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
        Guna2Button1.Location = New Point(134, 509)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(199, 56)
        Guna2Button1.TabIndex = 32
        Guna2Button1.Text = "PAY"
        ' 
        ' tablephonepe
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(490, 576)
        Controls.Add(Guna2Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Guna2Separator1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Guna2DateTimePicker1)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "tablephonepe"
        StartPosition = FormStartPosition.CenterScreen
        Text = "tablephonepe"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
