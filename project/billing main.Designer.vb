<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billing_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(billing_main))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button1 = New Button()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2vSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Guna2DataGridView2 = New Guna.UI2.WinForms.Guna2DataGridView()
        Itemname = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        Total = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label2 = New Label()
        Label7 = New Label()
        Button3 = New Button()
        Label8 = New Label()
        Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Button2 = New Button()
        Panel2.SuspendLayout()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrange
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.DarkOrange
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(869, 12)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkOrange
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(TextBox5)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(38, 92)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(349, 188)
        Panel2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(117, 149)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 29)
        Button1.TabIndex = 10
        Button1.Text = "Add to Bill"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(164, 100)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(55, 27)
        TextBox5.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(185, 50)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(20, 50)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(86, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 4
        Label5.Text = "Quantity"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(185, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 20)
        Label4.TabIndex = 3
        Label4.Text = "Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(20, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 2
        Label3.Text = "Item Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(154, 300)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 25)
        Label6.TabIndex = 2
        Label6.Text = "ITEMS LIST"
        ' 
        ' Guna2DataGridView1
        ' 
        Guna2DataGridView1.AllowUserToAddRows = False
        Guna2DataGridView1.AllowUserToDeleteRows = False
        Guna2DataGridView1.AllowUserToResizeColumns = False
        Guna2DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
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
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.DarkGray
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(12, 339)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.RowHeadersWidth = 51
        Guna2DataGridView1.Size = New Size(399, 330)
        Guna2DataGridView1.TabIndex = 3
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
        ' Guna2vSeparator1
        ' 
        Guna2vSeparator1.Location = New Point(417, 18)
        Guna2vSeparator1.Name = "Guna2vSeparator1"
        Guna2vSeparator1.Size = New Size(12, 673)
        Guna2vSeparator1.TabIndex = 4
        ' 
        ' Guna2DataGridView2
        ' 
        Guna2DataGridView2.AllowUserToAddRows = False
        Guna2DataGridView2.AllowUserToResizeColumns = False
        Guna2DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = Color.White
        Guna2DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.DarkOrange
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkOrange
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        Guna2DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Guna2DataGridView2.ColumnHeadersHeight = 22
        Guna2DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView2.Columns.AddRange(New DataGridViewColumn() {Itemname, Price, Quantity, Total})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.White
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        Guna2DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Guna2DataGridView2.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView2.Location = New Point(435, 78)
        Guna2DataGridView2.Name = "Guna2DataGridView2"
        Guna2DataGridView2.RowHeadersVisible = False
        Guna2DataGridView2.RowHeadersWidth = 51
        Guna2DataGridView2.Size = New Size(422, 393)
        Guna2DataGridView2.TabIndex = 6
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView2.ThemeStyle.BackColor = Color.White
        Guna2DataGridView2.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView2.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 22
        Guna2DataGridView2.ThemeStyle.ReadOnly = False
        Guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView2.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView2.ThemeStyle.RowsStyle.Height = 29
        Guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Itemname
        ' 
        Itemname.HeaderText = "Items"
        Itemname.MinimumWidth = 6
        Itemname.Name = "Itemname"
        ' 
        ' Price
        ' 
        Price.HeaderText = "Price"
        Price.MinimumWidth = 6
        Price.Name = "Price"
        ' 
        ' Quantity
        ' 
        Quantity.HeaderText = "Quantity"
        Quantity.MinimumWidth = 6
        Quantity.Name = "Quantity"
        ' 
        ' Total
        ' 
        Total.HeaderText = "Total"
        Total.MinimumWidth = 6
        Total.Name = "Total"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(631, 474)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 28)
        Label1.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(596, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 25)
        Label2.TabIndex = 8
        Label2.Text = "BILLING"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(561, 477)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 25)
        Label7.TabIndex = 9
        Label7.Text = "Total"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(596, 614)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 10
        Button3.Text = "Print"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(12, 38)
        Label8.Name = "Label8"
        Label8.Size = New Size(47, 20)
        Label8.TabIndex = 12
        Label8.Text = "DATE"
        ' 
        ' Guna2DateTimePicker1
        ' 
        Guna2DateTimePicker1.Checked = True
        Guna2DateTimePicker1.CustomizableEdges = CustomizableEdges1
        Guna2DateTimePicker1.FillColor = Color.DarkOrange
        Guna2DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2DateTimePicker1.ForeColor = Color.White
        Guna2DateTimePicker1.Format = DateTimePickerFormat.Long
        Guna2DateTimePicker1.Location = New Point(65, 34)
        Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2DateTimePicker1.Size = New Size(211, 29)
        Guna2DateTimePicker1.TabIndex = 13
        Guna2DateTimePicker1.Value = New Date(2025, 2, 10, 21, 23, 12, 382)
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(785, 38)
        Button2.Name = "Button2"
        Button2.Size = New Size(62, 29)
        Button2.TabIndex = 14
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' billing_main
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(869, 695)
        Controls.Add(Button2)
        Controls.Add(Guna2DateTimePicker1)
        Controls.Add(Label8)
        Controls.Add(Button3)
        Controls.Add(Label7)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Guna2DataGridView2)
        Controls.Add(Guna2vSeparator1)
        Controls.Add(Guna2DataGridView1)
        Controls.Add(Label6)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "billing_main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "billing_main"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2vSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Guna2DataGridView2 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Itemname As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Button2 As Button
End Class
