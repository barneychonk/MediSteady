<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orderStatus))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label10 = New Label()
        Panel1 = New Panel()
        Button8 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        dgvOrderHistory = New DataGridView()
        btnViewOrderDetails = New Button()
        Panel1.SuspendLayout()
        CType(dgvOrderHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(236, 96)
        Button4.Name = "Button4"
        Button4.Size = New Size(42, 51)
        Button4.TabIndex = 6
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(191, 94)
        Button3.Name = "Button3"
        Button3.Size = New Size(45, 53)
        Button3.TabIndex = 5
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(139, 95)
        Button2.Name = "Button2"
        Button2.Size = New Size(50, 53)
        Button2.TabIndex = 4
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(237, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(54, 60)
        Button1.TabIndex = 7
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.DarkGreen
        Label10.Location = New Point(130, 599)
        Label10.Name = "Label10"
        Label10.Size = New Size(59, 16)
        Label10.TabIndex = 17
        Label10.Text = "RM00.00"
        Label10.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button7)
        Panel1.Location = New Point(123, 23)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(168, 65)
        Panel1.TabIndex = 24
        ' 
        ' Button8
        ' 
        Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), Image)
        Button8.BackgroundImageLayout = ImageLayout.Stretch
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(123, 11)
        Button8.Name = "Button8"
        Button8.Size = New Size(37, 40)
        Button8.TabIndex = 26
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(5, 11)
        Button5.Name = "Button5"
        Button5.Size = New Size(37, 40)
        Button5.TabIndex = 25
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), Image)
        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(41, 11)
        Button6.Name = "Button6"
        Button6.Size = New Size(37, 40)
        Button6.TabIndex = 24
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(74, 11)
        Button7.Name = "Button7"
        Button7.Size = New Size(37, 40)
        Button7.TabIndex = 23
        Button7.UseVisualStyleBackColor = True
        ' 
        ' dgvOrderHistory
        ' 
        dgvOrderHistory.BackgroundColor = Color.DarkSeaGreen
        dgvOrderHistory.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkOliveGreen
        DataGridViewCellStyle1.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Ivory
        DataGridViewCellStyle1.SelectionBackColor = Color.Olive
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvOrderHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvOrderHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.Honeydew
        DataGridViewCellStyle2.SelectionForeColor = Color.DarkOliveGreen
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvOrderHistory.DefaultCellStyle = DataGridViewCellStyle2
        dgvOrderHistory.GridColor = Color.OliveDrab
        dgvOrderHistory.Location = New Point(25, 211)
        dgvOrderHistory.Margin = New Padding(3, 4, 3, 4)
        dgvOrderHistory.Name = "dgvOrderHistory"
        dgvOrderHistory.RowHeadersWidth = 51
        dgvOrderHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrderHistory.Size = New Size(258, 333)
        dgvOrderHistory.TabIndex = 25
        ' 
        ' btnViewOrderDetails
        ' 
        btnViewOrderDetails.BackColor = Color.OliveDrab
        btnViewOrderDetails.Font = New Font("Tw Cen MT", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnViewOrderDetails.ForeColor = Color.Ivory
        btnViewOrderDetails.Location = New Point(74, 552)
        btnViewOrderDetails.Margin = New Padding(3, 4, 3, 4)
        btnViewOrderDetails.Name = "btnViewOrderDetails"
        btnViewOrderDetails.Size = New Size(160, 31)
        btnViewOrderDetails.TabIndex = 26
        btnViewOrderDetails.Text = "View Details"
        btnViewOrderDetails.UseVisualStyleBackColor = False
        ' 
        ' orderStatus
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(btnViewOrderDetails)
        Controls.Add(dgvOrderHistory)
        Controls.Add(Panel1)
        Controls.Add(Label10)
        Controls.Add(Button1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        DoubleBuffered = True
        Name = "orderStatus"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Order Status"
        Panel1.ResumeLayout(False)
        CType(dgvOrderHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents dgvOrderHistory As DataGridView
    Friend WithEvents btnViewOrderDetails As Button
End Class
