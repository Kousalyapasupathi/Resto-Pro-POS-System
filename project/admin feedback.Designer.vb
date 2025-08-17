<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_feedback
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2CircleButton3 = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2CircleButton4 = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2CircleButton5 = New Guna.UI2.WinForms.Guna2CircleButton()
        Button2 = New Button()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2DataGridView1
        ' 
        Guna2DataGridView1.AllowUserToAddRows = False
        Guna2DataGridView1.AllowUserToDeleteRows = False
        Guna2DataGridView1.AllowUserToResizeColumns = False
        Guna2DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.DarkOrange
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeight = 40
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.White
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(12, 162)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.RowHeadersWidth = 51
        Guna2DataGridView1.Size = New Size(845, 521)
        Guna2DataGridView1.TabIndex = 0
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Guna2CircleButton1
        ' 
        Guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton1.FillColor = Color.DarkOrange
        Guna2CircleButton1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2CircleButton1.ForeColor = Color.White
        Guna2CircleButton1.Location = New Point(59, 31)
        Guna2CircleButton1.Name = "Guna2CircleButton1"
        Guna2CircleButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton1.Size = New Size(82, 76)
        Guna2CircleButton1.TabIndex = 8
        Guna2CircleButton1.Text = "5 ★ Ratings"
        ' 
        ' Guna2CircleButton2
        ' 
        Guna2CircleButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton2.FillColor = Color.DarkOrange
        Guna2CircleButton2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2CircleButton2.ForeColor = Color.White
        Guna2CircleButton2.Location = New Point(220, 31)
        Guna2CircleButton2.Name = "Guna2CircleButton2"
        Guna2CircleButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton2.Size = New Size(82, 76)
        Guna2CircleButton2.TabIndex = 9
        Guna2CircleButton2.Text = "4 ★ Ratings"
        ' 
        ' Guna2CircleButton3
        ' 
        Guna2CircleButton3.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton3.FillColor = Color.DarkOrange
        Guna2CircleButton3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2CircleButton3.ForeColor = Color.White
        Guna2CircleButton3.Location = New Point(382, 31)
        Guna2CircleButton3.Name = "Guna2CircleButton3"
        Guna2CircleButton3.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        Guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton3.Size = New Size(82, 76)
        Guna2CircleButton3.TabIndex = 10
        Guna2CircleButton3.Text = "3 ★ Ratings"
        ' 
        ' Guna2CircleButton4
        ' 
        Guna2CircleButton4.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton4.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton4.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton4.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton4.FillColor = Color.DarkOrange
        Guna2CircleButton4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2CircleButton4.ForeColor = Color.White
        Guna2CircleButton4.Location = New Point(545, 31)
        Guna2CircleButton4.Name = "Guna2CircleButton4"
        Guna2CircleButton4.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton4.Size = New Size(82, 76)
        Guna2CircleButton4.TabIndex = 11
        Guna2CircleButton4.Text = "2 ★ Ratings"
        ' 
        ' Guna2CircleButton5
        ' 
        Guna2CircleButton5.DisabledState.BorderColor = Color.DarkGray
        Guna2CircleButton5.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2CircleButton5.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2CircleButton5.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2CircleButton5.FillColor = Color.DarkOrange
        Guna2CircleButton5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2CircleButton5.ForeColor = Color.White
        Guna2CircleButton5.Location = New Point(703, 31)
        Guna2CircleButton5.Name = "Guna2CircleButton5"
        Guna2CircleButton5.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        Guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleButton5.Size = New Size(82, 76)
        Guna2CircleButton5.TabIndex = 12
        Guna2CircleButton5.Text = "1 ★ Ratings"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(763, 127)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 13
        Button2.Text = "Refresh"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' admin_feedback
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(869, 695)
        Controls.Add(Button2)
        Controls.Add(Guna2CircleButton5)
        Controls.Add(Guna2CircleButton4)
        Controls.Add(Guna2CircleButton3)
        Controls.Add(Guna2CircleButton2)
        Controls.Add(Guna2CircleButton1)
        Controls.Add(Guna2DataGridView1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "admin_feedback"
        StartPosition = FormStartPosition.CenterScreen
        Text = "admin_feedback"
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton3 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton4 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton5 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Button2 As Button
End Class
