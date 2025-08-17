<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer_main))
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrange
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Guna2Button2)
        Panel1.Controls.Add(Guna2Button1)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(869, 127)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(599, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(270, 127)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(135, 127)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Guna2Button2.CheckedState.FillColor = Color.Black
        Guna2Button2.CustomizableEdges = CustomizableEdges17
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.DarkOrange
        Guna2Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), Image)
        Guna2Button2.ImageAlign = HorizontalAlignment.Left
        Guna2Button2.ImageSize = New Size(40, 40)
        Guna2Button2.Location = New Point(382, 19)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Guna2Button2.Size = New Size(154, 108)
        Guna2Button2.TabIndex = 1
        Guna2Button2.Text = "WEBSITE LOGINNERS DETAILS"
        Guna2Button2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackgroundImageLayout = ImageLayout.Center
        Guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Guna2Button1.CheckedState.FillColor = Color.Black
        Guna2Button1.CustomizableEdges = CustomizableEdges19
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.DarkOrange
        Guna2Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), Image)
        Guna2Button1.ImageAlign = HorizontalAlignment.Left
        Guna2Button1.ImageSize = New Size(40, 40)
        Guna2Button1.Location = New Point(191, 19)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        Guna2Button1.Size = New Size(152, 108)
        Guna2Button1.TabIndex = 0
        Guna2Button1.Text = "VISITING CUSTOMER DETAILS"
        Guna2Button1.TextAlign = HorizontalAlignment.Right
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 127)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(869, 568)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImageLayout = ImageLayout.None
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(157, 88)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(533, 360)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(274, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 25)
        Label1.TabIndex = 1
        Label1.Text = "Savor the flavor, enjoy the moment"
        ' 
        ' customer_main
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(869, 695)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "customer_main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "customer_main"
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
End Class
