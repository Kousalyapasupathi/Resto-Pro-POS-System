<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_menus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_menus))
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Guna2vSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.BackColor = Color.Transparent
        FlowLayoutPanel1.Location = New Point(60, 129)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(965, 574)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(99, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(138, 25)
        Label1.TabIndex = 1
        Label1.Text = "The Cozy Plate"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(472, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 31)
        Label2.TabIndex = 2
        Label2.Text = "MENUS"
        ' 
        ' Guna2vSeparator1
        ' 
        Guna2vSeparator1.BackColor = Color.Transparent
        Guna2vSeparator1.FillColor = Color.White
        Guna2vSeparator1.FillThickness = 3
        Guna2vSeparator1.Location = New Point(759, 12)
        Guna2vSeparator1.Name = "Guna2vSeparator1"
        Guna2vSeparator1.Size = New Size(10, 94)
        Guna2vSeparator1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkOrange
        Label3.Location = New Point(775, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(173, 28)
        Label3.TabIndex = 4
        Label3.Text = "DELICIOUS FOOD"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(775, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 28)
        Label4.TabIndex = 5
        Label4.Text = "PURE JOY !"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.DarkOrange
        Label5.Location = New Point(775, 79)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 28)
        Label5.TabIndex = 6
        Label5.Text = "ORDER NOW"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1037, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(36, 32)
        Button1.TabIndex = 7
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkOrange
        Button2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(12, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(46, 36)
        Button2.TabIndex = 21
        Button2.Text = "<-"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' user_menus
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1085, 737)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Guna2vSeparator1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(FlowLayoutPanel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "user_menus"
        StartPosition = FormStartPosition.CenterScreen
        Text = "user_menus"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2vSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
