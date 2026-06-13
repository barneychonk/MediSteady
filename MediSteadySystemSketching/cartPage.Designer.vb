<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cartPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cartPage))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnCheckout = New Button()
        Button2 = New Button()
        Button3 = New Button()
        btnFavItems = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Brand1 = New Label()
        Label1 = New Label()
        Label8 = New Label()
        lblTotalPrice = New Label()
        Label10 = New Label()
        lblPrice = New Label()
        lblDelivery = New Label()
        Label13 = New Label()
        Panel1 = New Panel()
        Button8 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        dgvCart = New DataGridView()
        btnRemove = New Button()
        Panel1.SuspendLayout()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCheckout
        ' 
        btnCheckout.BackColor = Color.Transparent
        btnCheckout.FlatAppearance.BorderSize = 0
        btnCheckout.FlatStyle = FlatStyle.Flat
        btnCheckout.Font = New Font("Tw Cen MT", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheckout.ForeColor = Color.DarkOliveGreen
        btnCheckout.Location = New Point(-5, 552)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(311, 56)
        btnCheckout.TabIndex = 0
        btnCheckout.Text = "CHECKOUT"
        btnCheckout.UseVisualStyleBackColor = False
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
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(191, 93)
        Button3.Name = "Button3"
        Button3.Size = New Size(45, 53)
        Button3.TabIndex = 2
        Button3.UseVisualStyleBackColor = False
        ' 
        ' btnFavItems
        ' 
        btnFavItems.BackColor = Color.Transparent
        btnFavItems.BackgroundImage = CType(resources.GetObject("btnFavItems.BackgroundImage"), Image)
        btnFavItems.BackgroundImageLayout = ImageLayout.Stretch
        btnFavItems.FlatAppearance.BorderSize = 0
        btnFavItems.FlatStyle = FlatStyle.Flat
        btnFavItems.Location = New Point(235, 96)
        btnFavItems.Name = "btnFavItems"
        btnFavItems.Size = New Size(42, 51)
        btnFavItems.TabIndex = 3
        btnFavItems.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(154, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 16)
        Label4.TabIndex = 6
        Label4.Text = "RM00.00"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkOliveGreen
        Label3.Location = New Point(121, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 18)
        Label3.TabIndex = 5
        Label3.Text = "PRODUCT NAME"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Brand1
        ' 
        Brand1.AutoSize = True
        Brand1.BackColor = Color.Olive
        Brand1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Brand1.ForeColor = Color.Honeydew
        Brand1.Location = New Point(139, 171)
        Brand1.Name = "Brand1"
        Brand1.Size = New Size(91, 18)
        Brand1.TabIndex = 4
        Brand1.Text = "Brand Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SaddleBrown
        Label1.Location = New Point(231, 227)
        Label1.Name = "Label1"
        Label1.Size = New Size(38, 25)
        Label1.TabIndex = 7
        Label1.Text = "x 1"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Cursor = Cursors.Hand
        Label8.Font = New Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Honeydew
        Label8.Location = New Point(27, 509)
        Label8.Name = "Label8"
        Label8.Size = New Size(170, 23)
        Label8.TabIndex = 12
        Label8.Text = "TOTAL AMOUNT : "
        Label8.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.AutoSize = True
        lblTotalPrice.BackColor = Color.Transparent
        lblTotalPrice.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalPrice.ForeColor = Color.DarkGreen
        lblTotalPrice.Location = New Point(198, 507)
        lblTotalPrice.MaximumSize = New Size(85, 27)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(84, 24)
        lblTotalPrice.TabIndex = 13
        lblTotalPrice.Text = "RM00.00"
        lblTotalPrice.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Cursor = Cursors.Hand
        Label10.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Italic)
        Label10.ForeColor = Color.DarkOliveGreen
        Label10.Location = New Point(29, 409)
        Label10.Name = "Label10"
        Label10.Size = New Size(101, 20)
        Label10.TabIndex = 14
        Label10.Text = "SUB TOTAL : "
        Label10.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.BackColor = Color.Transparent
        lblPrice.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPrice.ForeColor = Color.DarkGreen
        lblPrice.Location = New Point(188, 408)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(91, 25)
        lblPrice.TabIndex = 15
        lblPrice.Text = "RM00.00"
        lblPrice.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblDelivery
        ' 
        lblDelivery.AutoSize = True
        lblDelivery.BackColor = Color.Transparent
        lblDelivery.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDelivery.ForeColor = Color.DarkGreen
        lblDelivery.Location = New Point(189, 458)
        lblDelivery.Name = "lblDelivery"
        lblDelivery.Size = New Size(91, 25)
        lblDelivery.TabIndex = 17
        lblDelivery.Text = "RM00.00"
        lblDelivery.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Cursor = Cursors.Hand
        Label13.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.DarkOliveGreen
        Label13.Location = New Point(27, 461)
        Label13.Name = "Label13"
        Label13.Size = New Size(159, 20)
        Label13.TabIndex = 16
        Label13.Text = "DELIVERY CHARGES : "
        Label13.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button7)
        Panel1.Location = New Point(123, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(168, 43)
        Panel1.TabIndex = 24
        ' 
        ' Button8
        ' 
        Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), Image)
        Button8.BackgroundImageLayout = ImageLayout.Stretch
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(123, -1)
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
        Button5.Location = New Point(5, 1)
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
        Button6.Location = New Point(41, 0)
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
        Button7.Location = New Point(74, 0)
        Button7.Name = "Button7"
        Button7.Size = New Size(37, 40)
        Button7.TabIndex = 23
        Button7.UseVisualStyleBackColor = True
        ' 
        ' dgvCart
        ' 
        dgvCart.BackgroundColor = Color.DarkSeaGreen
        dgvCart.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkSeaGreen
        DataGridViewCellStyle1.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Ivory
        DataGridViewCellStyle1.SelectionBackColor = Color.Olive
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvCart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = Color.Olive
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvCart.DefaultCellStyle = DataGridViewCellStyle2
        dgvCart.GridColor = Color.DarkOliveGreen
        dgvCart.Location = New Point(29, 155)
        dgvCart.Margin = New Padding(3, 4, 3, 4)
        dgvCart.Name = "dgvCart"
        dgvCart.RowHeadersWidth = 51
        dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCart.Size = New Size(250, 174)
        dgvCart.TabIndex = 25
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.DarkSeaGreen
        btnRemove.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRemove.ForeColor = Color.Honeydew
        btnRemove.Location = New Point(153, 337)
        btnRemove.Margin = New Padding(3, 4, 3, 4)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(126, 31)
        btnRemove.TabIndex = 26
        btnRemove.Text = "REMOVE ITEM"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' cartPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(btnRemove)
        Controls.Add(dgvCart)
        Controls.Add(Panel1)
        Controls.Add(lblDelivery)
        Controls.Add(Label13)
        Controls.Add(lblPrice)
        Controls.Add(Label10)
        Controls.Add(lblTotalPrice)
        Controls.Add(Label8)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Brand1)
        Controls.Add(btnFavItems)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(btnCheckout)
        DoubleBuffered = True
        Name = "cartPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cart n Checkout"
        Panel1.ResumeLayout(False)
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCheckout As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnFavItems As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Brand1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDelivery As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents btnRemove As Button
End Class
