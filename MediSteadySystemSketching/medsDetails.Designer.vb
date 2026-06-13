<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class medsDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(medsDetails))
        Label1 = New Label()
        lblProductPrice = New Label()
        lblProductName = New Label()
        lblProductID = New Label()
        btnRemoveQty = New Button()
        btnAddQty = New Button()
        btnFav = New Button()
        btnAddCart = New Button()
        Button5 = New Button()
        btnCartPage = New Button()
        Button7 = New Button()
        Button8 = New Button()
        lblQty = New Label()
        pictureBoxProduct = New PictureBox()
        CType(pictureBoxProduct, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkOliveGreen
        Label1.Location = New Point(166, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 40)
        Label1.TabIndex = 8
        Label1.Text = "Pharmacy's" & vbCrLf & "Location" & vbCrLf
        ' 
        ' lblProductPrice
        ' 
        lblProductPrice.AutoSize = True
        lblProductPrice.BackColor = Color.Transparent
        lblProductPrice.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProductPrice.ForeColor = Color.Ivory
        lblProductPrice.Location = New Point(115, 470)
        lblProductPrice.Name = "lblProductPrice"
        lblProductPrice.Size = New Size(75, 20)
        lblProductPrice.TabIndex = 7
        lblProductPrice.Text = "RM00.00"
        lblProductPrice.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblProductName
        ' 
        lblProductName.AutoSize = True
        lblProductName.BackColor = Color.Transparent
        lblProductName.Cursor = Cursors.Hand
        lblProductName.FlatStyle = FlatStyle.Popup
        lblProductName.Font = New Font("Tw Cen MT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblProductName.ForeColor = Color.LemonChiffon
        lblProductName.Location = New Point(107, 396)
        lblProductName.MaximumSize = New Size(114, 67)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(82, 40)
        lblProductName.TabIndex = 6
        lblProductName.Text = "PRODUCT NAME"
        lblProductName.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblProductID
        ' 
        lblProductID.AutoSize = True
        lblProductID.BackColor = Color.Transparent
        lblProductID.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProductID.ForeColor = Color.Honeydew
        lblProductID.Location = New Point(105, 360)
        lblProductID.Name = "lblProductID"
        lblProductID.Size = New Size(97, 20)
        lblProductID.TabIndex = 5
        lblProductID.Text = "Brand Name"
        ' 
        ' btnRemoveQty
        ' 
        btnRemoveQty.BackColor = Color.Transparent
        btnRemoveQty.BackgroundImage = CType(resources.GetObject("btnRemoveQty.BackgroundImage"), Image)
        btnRemoveQty.BackgroundImageLayout = ImageLayout.Stretch
        btnRemoveQty.FlatAppearance.BorderSize = 0
        btnRemoveQty.FlatStyle = FlatStyle.Flat
        btnRemoveQty.Location = New Point(46, 512)
        btnRemoveQty.Name = "btnRemoveQty"
        btnRemoveQty.Size = New Size(21, 32)
        btnRemoveQty.TabIndex = 10
        btnRemoveQty.UseVisualStyleBackColor = False
        ' 
        ' btnAddQty
        ' 
        btnAddQty.BackColor = Color.Transparent
        btnAddQty.BackgroundImage = CType(resources.GetObject("btnAddQty.BackgroundImage"), Image)
        btnAddQty.BackgroundImageLayout = ImageLayout.Stretch
        btnAddQty.FlatAppearance.BorderSize = 0
        btnAddQty.FlatStyle = FlatStyle.Flat
        btnAddQty.Location = New Point(101, 516)
        btnAddQty.Name = "btnAddQty"
        btnAddQty.Size = New Size(22, 23)
        btnAddQty.TabIndex = 11
        btnAddQty.UseVisualStyleBackColor = False
        ' 
        ' btnFav
        ' 
        btnFav.BackColor = Color.Transparent
        btnFav.BackgroundImage = CType(resources.GetObject("btnFav.BackgroundImage"), Image)
        btnFav.BackgroundImageLayout = ImageLayout.Stretch
        btnFav.FlatAppearance.BorderSize = 0
        btnFav.FlatStyle = FlatStyle.Flat
        btnFav.Location = New Point(242, 512)
        btnFav.Name = "btnFav"
        btnFav.Size = New Size(21, 32)
        btnFav.TabIndex = 12
        btnFav.UseVisualStyleBackColor = False
        ' 
        ' btnAddCart
        ' 
        btnAddCart.BackColor = Color.Transparent
        btnAddCart.Cursor = Cursors.Hand
        btnAddCart.FlatAppearance.BorderSize = 0
        btnAddCart.FlatStyle = FlatStyle.Flat
        btnAddCart.Font = New Font("Tw Cen MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddCart.ForeColor = SystemColors.ButtonHighlight
        btnAddCart.Location = New Point(129, 507)
        btnAddCart.Name = "btnAddCart"
        btnAddCart.Size = New Size(107, 41)
        btnAddCart.TabIndex = 13
        btnAddCart.Text = "Add to Cart"
        btnAddCart.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(247, 35)
        Button5.Name = "Button5"
        Button5.Size = New Size(34, 36)
        Button5.TabIndex = 17
        Button5.UseVisualStyleBackColor = False
        ' 
        ' btnCartPage
        ' 
        btnCartPage.BackColor = Color.Transparent
        btnCartPage.BackgroundImage = CType(resources.GetObject("btnCartPage.BackgroundImage"), Image)
        btnCartPage.BackgroundImageLayout = ImageLayout.Stretch
        btnCartPage.FlatAppearance.BorderSize = 0
        btnCartPage.FlatStyle = FlatStyle.Flat
        btnCartPage.Location = New Point(198, 35)
        btnCartPage.Name = "btnCartPage"
        btnCartPage.Size = New Size(32, 36)
        btnCartPage.TabIndex = 16
        btnCartPage.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.BackgroundImageLayout = ImageLayout.Stretch
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(166, 35)
        Button7.Name = "Button7"
        Button7.Size = New Size(34, 36)
        Button7.TabIndex = 15
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), Image)
        Button8.BackgroundImageLayout = ImageLayout.Stretch
        Button8.FlatAppearance.BorderSize = 0
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Location = New Point(129, 35)
        Button8.Name = "Button8"
        Button8.Size = New Size(35, 40)
        Button8.TabIndex = 14
        Button8.UseVisualStyleBackColor = False
        ' 
        ' lblQty
        ' 
        lblQty.AutoSize = True
        lblQty.BackColor = Color.Transparent
        lblQty.Font = New Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblQty.ForeColor = Color.DarkOliveGreen
        lblQty.Location = New Point(72, 513)
        lblQty.Name = "lblQty"
        lblQty.Size = New Size(26, 29)
        lblQty.TabIndex = 19
        lblQty.Text = "1"
        ' 
        ' pictureBoxProduct
        ' 
        pictureBoxProduct.BackColor = Color.Transparent
        pictureBoxProduct.Location = New Point(93, 166)
        pictureBoxProduct.Margin = New Padding(3, 4, 3, 4)
        pictureBoxProduct.Name = "pictureBoxProduct"
        pictureBoxProduct.Size = New Size(115, 164)
        pictureBoxProduct.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBoxProduct.TabIndex = 20
        pictureBoxProduct.TabStop = False
        ' 
        ' medsDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(pictureBoxProduct)
        Controls.Add(lblQty)
        Controls.Add(Button5)
        Controls.Add(btnCartPage)
        Controls.Add(Button7)
        Controls.Add(Button8)
        Controls.Add(btnAddCart)
        Controls.Add(btnFav)
        Controls.Add(btnAddQty)
        Controls.Add(btnRemoveQty)
        Controls.Add(Label1)
        Controls.Add(lblProductPrice)
        Controls.Add(lblProductName)
        Controls.Add(lblProductID)
        DoubleBuffered = True
        Name = "medsDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Medicine Details"
        CType(pictureBoxProduct, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents btnRemoveQty As Button
    Friend WithEvents btnAddQty As Button
    Friend WithEvents btnFav As Button
    Friend WithEvents btnAddCart As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnCartPage As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents lblQty As Label
    Friend WithEvents pictureBoxProduct As PictureBox
End Class
