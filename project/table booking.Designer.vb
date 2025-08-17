<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class table_booking
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(table_booking))
        Label1 = New Label()
        Label2 = New Label()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Button1 = New Button()
        Guna2vSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Guna2DataGridView2 = New Guna.UI2.WinForms.Guna2DataGridView()
        Tableno = New DataGridViewTextBoxColumn()
        Seats = New DataGridViewTextBoxColumn()
        BookingAmount = New DataGridViewTextBoxColumn()
        Label11 = New Label()
        Label12 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(104, 80)
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
        Label2.Location = New Point(376, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(245, 31)
        Label2.TabIndex = 3
        Label2.Text = "TABLE RESERVATION"
        ' 
        ' Guna2DataGridView1
        ' 
        Guna2DataGridView1.AllowUserToAddRows = False
        Guna2DataGridView1.AllowUserToDeleteRows = False
        Guna2DataGridView1.AllowUserToResizeColumns = False
        Guna2DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.Black
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.DarkGray
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Guna2DataGridView1.BackgroundColor = Color.Black
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.DarkOrange
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeight = 40
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Black
        DataGridViewCellStyle3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.DimGray
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(34, 288)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.RowHeadersWidth = 51
        Guna2DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Guna2DataGridView1.Size = New Size(523, 418)
        Guna2DataGridView1.TabIndex = 4
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.Black
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
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(241, 223)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 15
        Button1.Text = "RESERVE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Guna2vSeparator1
        ' 
        Guna2vSeparator1.BackColor = Color.Transparent
        Guna2vSeparator1.FillColor = Color.White
        Guna2vSeparator1.FillThickness = 3
        Guna2vSeparator1.Location = New Point(579, 104)
        Guna2vSeparator1.Name = "Guna2vSeparator1"
        Guna2vSeparator1.Size = New Size(27, 611)
        Guna2vSeparator1.TabIndex = 22
        ' 
        ' Guna2DataGridView2
        ' 
        Guna2DataGridView2.AllowUserToAddRows = False
        Guna2DataGridView2.AllowUserToDeleteRows = False
        Guna2DataGridView2.AllowUserToResizeColumns = False
        Guna2DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = Color.White
        Guna2DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Guna2DataGridView2.BackgroundColor = Color.Black
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.DarkOrange
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkOrange
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        Guna2DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Guna2DataGridView2.ColumnHeadersHeight = 40
        Guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView2.Columns.AddRange(New DataGridViewColumn() {Tableno, Seats, BookingAmount})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.Black
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = Color.Black
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        Guna2DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Guna2DataGridView2.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView2.Location = New Point(603, 116)
        Guna2DataGridView2.Name = "Guna2DataGridView2"
        Guna2DataGridView2.RowHeadersVisible = False
        Guna2DataGridView2.RowHeadersWidth = 51
        Guna2DataGridView2.Size = New Size(470, 213)
        Guna2DataGridView2.TabIndex = 23
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView2.ThemeStyle.BackColor = Color.Black
        Guna2DataGridView2.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView2.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 40
        Guna2DataGridView2.ThemeStyle.ReadOnly = False
        Guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView2.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView2.ThemeStyle.RowsStyle.Height = 29
        Guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Tableno
        ' 
        Tableno.HeaderText = "Tableno"
        Tableno.MinimumWidth = 6
        Tableno.Name = "Tableno"
        ' 
        ' Seats
        ' 
        Seats.HeaderText = "Seats"
        Seats.MinimumWidth = 6
        Seats.Name = "Seats"
        ' 
        ' BookingAmount
        ' 
        BookingAmount.HeaderText = "BookingAmount"
        BookingAmount.MinimumWidth = 6
        BookingAmount.Name = "BookingAmount"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(743, 354)
        Label11.Name = "Label11"
        Label11.Size = New Size(76, 23)
        Label11.TabIndex = 24
        Label11.Text = "TOTAL : "
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(827, 354)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 25)
        Label12.TabIndex = 25
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(958, 71)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 26
        Button2.Text = "CLEAR"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(1032, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(41, 35)
        Button3.TabIndex = 27
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkOrange
        Button4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(12, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(46, 36)
        Button4.TabIndex = 28
        Button4.Text = "<-"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderColor = Color.DarkOrange
        Guna2Button1.BorderThickness = 4
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Black
        Guna2Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(743, 402)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(180, 56)
        Guna2Button1.TabIndex = 29
        Guna2Button1.Text = "Make payment"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(433, 142)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 20)
        Label5.TabIndex = 7
        Label5.Text = "AMOUNT"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(433, 165)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(77, 27)
        TextBox5.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(256, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 6
        Label4.Text = "SEATS"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(256, 165)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(52, 27)
        TextBox4.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(69, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 5
        Label3.Text = "TABLENO"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(69, 165)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(77, 27)
        TextBox3.TabIndex = 12
        ' 
        ' table_booking
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1085, 737)
        Controls.Add(Guna2Button1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Guna2DataGridView2)
        Controls.Add(Guna2vSeparator1)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Guna2DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "table_booking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "table_booking"
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Guna2vSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2DataGridView2 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Tableno As DataGridViewTextBoxColumn
    Friend WithEvents Seats As DataGridViewTextBoxColumn
    Friend WithEvents BookingAmount As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Public WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
