<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_image
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu_image))
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Guna2ShadowPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Black
        Guna2ShadowPanel1.Controls.Add(Panel1)
        Guna2ShadowPanel1.Controls.Add(PictureBox1)
        Guna2ShadowPanel1.FillColor = Color.Black
        Guna2ShadowPanel1.Location = New Point(0, 6)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = Color.Black
        Guna2ShadowPanel1.Size = New Size(225, 215)
        Guna2ShadowPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Guna2Separator1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 172)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(225, 43)
        Panel1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(152, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 20)
        Label3.TabIndex = 4
        Label3.Text = "Rs."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(174, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 20)
        Label2.TabIndex = 3
        Label2.Text = "100"
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.Location = New Point(-2, -4)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(230, 10)
        Guna2Separator1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 20)
        Label1.TabIndex = 2
        Label1.Text = "Chapathi"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(219, 163)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' menu_image
        ' 
        AutoScaleMode = AutoScaleMode.None
        Controls.Add(Guna2ShadowPanel1)
        Name = "menu_image"
        Size = New Size(228, 224)
        Guna2ShadowPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label

End Class
