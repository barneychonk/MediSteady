<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkoutPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checkoutPage))
        lblPrice = New Label()
        Label8 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        Button8 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        btnPlaceOrder = New Button()
        txtAddress = New TextBox()
        txtContact = New TextBox()
        pcbPhoto = New PictureBox()
        Button1 = New Button()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(pcbPhoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.BackColor = Color.Transparent
        lblPrice.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPrice.ForeColor = Color.DarkGreen
        lblPrice.Location = New Point(110, 249)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(91, 25)
        lblPrice.TabIndex = 15
        lblPrice.Text = "RM00.00"
        lblPrice.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Cursor = Cursors.Hand
        Label8.Font = New Font("Tw Cen MT", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Honeydew
        Label8.Location = New Point(74, 223)
        Label8.Name = "Label8"
        Label8.Size = New Size(184, 27)
        Label8.TabIndex = 14
        Label8.Text = "TOTAL AMOUNT : "
        Label8.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Tw Cen MT Condensed Extra Bold", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkOliveGreen
        Label2.Location = New Point(36, 299)
        Label2.Name = "Label2"
        Label2.Size = New Size(10, 21)
        Label2.TabIndex = 16
        Label2.Text = vbCrLf
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Honeydew
        Label3.Location = New Point(119, 479)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 17
        Label3.TextAlign = ContentAlignment.TopCenter
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
        Button4.TabIndex = 21
        Button4.UseVisualStyleBackColor = False
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
        Button3.TabIndex = 20
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(139, 94)
        Button2.Name = "Button2"
        Button2.Size = New Size(50, 53)
        Button2.TabIndex = 19
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button7)
        Panel1.Location = New Point(123, 33)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(168, 43)
        Panel1.TabIndex = 23
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
        ' btnPlaceOrder
        ' 
        btnPlaceOrder.BackColor = Color.DarkOliveGreen
        btnPlaceOrder.Font = New Font("Tw Cen MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPlaceOrder.ForeColor = Color.LightYellow
        btnPlaceOrder.Location = New Point(65, 563)
        btnPlaceOrder.Margin = New Padding(3, 4, 3, 4)
        btnPlaceOrder.Name = "btnPlaceOrder"
        btnPlaceOrder.Size = New Size(193, 46)
        btnPlaceOrder.TabIndex = 24
        btnPlaceOrder.Text = "PLACE ORDER"
        btnPlaceOrder.UseVisualStyleBackColor = False
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.LightYellow
        txtAddress.Font = New Font("Tw Cen MT", 10.2F)
        txtAddress.Location = New Point(70, 524)
        txtAddress.Margin = New Padding(3, 4, 3, 4)
        txtAddress.Name = "txtAddress"
        txtAddress.PlaceholderText = "Address"
        txtAddress.Size = New Size(219, 26)
        txtAddress.TabIndex = 25
        ' 
        ' txtContact
        ' 
        txtContact.BackColor = Color.LightYellow
        txtContact.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContact.Location = New Point(69, 470)
        txtContact.Margin = New Padding(3, 4, 3, 4)
        txtContact.Name = "txtContact"
        txtContact.PlaceholderText = "Contact Number"
        txtContact.Size = New Size(220, 26)
        txtContact.TabIndex = 26
        ' 
        ' pcbPhoto
        ' 
        pcbPhoto.BackColor = Color.Transparent
        pcbPhoto.Location = New Point(155, 299)
        pcbPhoto.Name = "pcbPhoto"
        pcbPhoto.Size = New Size(136, 105)
        pcbPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        pcbPhoto.TabIndex = 27
        pcbPhoto.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(148, 408)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(34, 37)
        Button1.TabIndex = 28
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Tw Cen MT", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LightGoldenrodYellow
        Label1.Location = New Point(183, 408)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 34)
        Label1.TabIndex = 29
        Label1.Text = "CLICK BUTTON TO" & vbCrLf & "ATTACH RECEIPT"
        ' 
        ' checkoutPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(pcbPhoto)
        Controls.Add(txtContact)
        Controls.Add(txtAddress)
        Controls.Add(btnPlaceOrder)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblPrice)
        Controls.Add(Label8)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "checkoutPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Checkout Page"
        Panel1.ResumeLayout(False)
        CType(pcbPhoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents pcbPhoto As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
