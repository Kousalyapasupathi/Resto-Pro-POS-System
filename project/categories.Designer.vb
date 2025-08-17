<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class categories
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
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(categories))
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Label1 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Guna2Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.DarkOrange
        Guna2Panel1.Controls.Add(Label1)
        Guna2Panel1.Controls.Add(Button1)
        Guna2Panel1.Controls.Add(PictureBox1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.Dock = DockStyle.Top
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(451, 99)
        Guna2Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(109, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 28)
        Label1.TabIndex = 2
        Label1.Text = "Add Category"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(410, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(38, 35)
        Button1.TabIndex = 1
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(103, 99)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.DarkOrange
        Guna2Panel2.Controls.Add(Guna2Button1)
        Guna2Panel2.CustomizableEdges = CustomizableEdges5
        Guna2Panel2.Dock = DockStyle.Bottom
        Guna2Panel2.Location = New Point(0, 299)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2Panel2.Size = New Size(451, 67)
        Guna2Panel2.TabIndex = 1
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BackColor = Color.Black
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Black
        Guna2Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(166, 15)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(102, 40)
        Guna2Button1.TabIndex = 0
        Guna2Button1.Text = "Save"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(40, 213)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 2
        Label2.Text = "NAME"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 151)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(72, 27)
        TextBox1.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(40, 158)
        Label3.Name = "Label3"
        Label3.Size = New Size(25, 20)
        Label3.TabIndex = 6
        Label3.Text = "ID"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(117, 210)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(151, 27)
        TextBox2.TabIndex = 7
        ' 
        ' categories
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(451, 366)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Guna2Panel2)
        Controls.Add(Guna2Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "categories"
        StartPosition = FormStartPosition.CenterScreen
        Text = "categories"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Public WithEvents Button1 As Button
    Public WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Public WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
