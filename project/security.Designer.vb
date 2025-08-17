<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class security
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrange
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(755, 84)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(705, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(50, 38)
        Button1.TabIndex = 1
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(14, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 25)
        Label1.TabIndex = 0
        Label1.Text = "Add Security"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkOrange
        Panel2.Controls.Add(Guna2Button2)
        Panel2.Controls.Add(Guna2Button1)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 351)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(755, 75)
        Panel2.TabIndex = 1
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Black
        Guna2Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(221, 13)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(79, 36)
        Guna2Button1.TabIndex = 0
        Guna2Button1.Text = "Save"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(71, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 20)
        Label2.TabIndex = 2
        Label2.Text = "EMPNO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(221, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 3
        Label3.Text = "NAME"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(461, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 20)
        Label4.TabIndex = 4
        Label4.Text = "PHONE NUMBER"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(113, 236)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 5
        Label5.Text = "ADDRESS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(432, 236)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 20)
        Label6.TabIndex = 6
        Label6.Text = "SALARY"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(71, 164)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(88, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(221, 164)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(195, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(461, 164)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(185, 27)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(113, 259)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(283, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(432, 259)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(119, 27)
        TextBox5.TabIndex = 11
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges1
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Black
        Guna2Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(388, 13)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button2.Size = New Size(79, 36)
        Guna2Button2.TabIndex = 1
        Guna2Button2.Text = "Edit"
        ' 
        ' security
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(755, 426)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "security"
        StartPosition = FormStartPosition.CenterScreen
        Text = "security"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
