<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staff_main
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staff_main))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrange
        Panel1.Controls.Add(Guna2Button3)
        Panel1.Controls.Add(Guna2Button2)
        Panel1.Controls.Add(Guna2Button1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(869, 119)
        Panel1.TabIndex = 0
        ' 
        ' Guna2Button3
        ' 
        Guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Guna2Button3.CheckedState.FillColor = Color.Black
        Guna2Button3.CustomizableEdges = CustomizableEdges1
        Guna2Button3.DisabledState.BorderColor = Color.DarkGray
        Guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button3.FillColor = Color.DarkOrange
        Guna2Button3.Font = New Font("Segoe UI", 9F)
        Guna2Button3.ForeColor = Color.White
        Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), Image)
        Guna2Button3.ImageSize = New Size(50, 50)
        Guna2Button3.Location = New Point(558, 0)
        Guna2Button3.Name = "Guna2Button3"
        Guna2Button3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button3.Size = New Size(143, 119)
        Guna2Button3.TabIndex = 2
        Guna2Button3.Text = "SECURITY"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Guna2Button2.CheckedState.FillColor = Color.Black
        Guna2Button2.CustomizableEdges = CustomizableEdges3
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Transparent
        Guna2Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), Image)
        Guna2Button2.ImageSize = New Size(50, 50)
        Guna2Button2.Location = New Point(348, 0)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button2.Size = New Size(143, 119)
        Guna2Button2.TabIndex = 1
        Guna2Button2.Text = "COOKS"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderStyle = Drawing2D.DashStyle.DashDotDot
        Guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Guna2Button1.CheckedState.FillColor = Color.Black
        Guna2Button1.CheckedState.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold)
        Guna2Button1.CheckedState.Image = CType(resources.GetObject("resource.Image"), Image)
        Guna2Button1.CustomizableEdges = CustomizableEdges5
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.DarkOrange
        Guna2Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), Image)
        Guna2Button1.ImageSize = New Size(50, 50)
        Guna2Button1.Location = New Point(140, 0)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Button1.Size = New Size(143, 119)
        Guna2Button1.TabIndex = 0
        Guna2Button1.Text = "WAITER"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 119)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(869, 576)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(241, 453)
        Label1.Name = "Label1"
        Label1.Size = New Size(339, 28)
        Label1.TabIndex = 1
        Label1.Text = "Every staff member is a key to success"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(152, 84)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(532, 352)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' staff_main
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(869, 695)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "staff_main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "staff_main"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
