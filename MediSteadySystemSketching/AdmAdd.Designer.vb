<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdmAdd))
        txtProductName = New TextBox()
        txtProductPrice = New TextBox()
        Panel1 = New Panel()
        panelAdd = New Panel()
        Panel6 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel3 = New Panel()
        Panel7 = New Panel()
        pbProductImage = New PictureBox()
        txtProductID = New TextBox()
        Panel4.SuspendLayout()
        CType(pbProductImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtProductName
        ' 
        txtProductName.BackColor = Color.DarkSeaGreen
        txtProductName.Font = New Font("Tw Cen MT Condensed", 10.2F)
        txtProductName.Location = New Point(158, 286)
        txtProductName.Margin = New Padding(3, 4, 3, 4)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(108, 26)
        txtProductName.TabIndex = 1
        ' 
        ' txtProductPrice
        ' 
        txtProductPrice.BackColor = Color.DarkSeaGreen
        txtProductPrice.Font = New Font("Tw Cen MT Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtProductPrice.Location = New Point(158, 321)
        txtProductPrice.Margin = New Padding(3, 4, 3, 4)
        txtProductPrice.Name = "txtProductPrice"
        txtProductPrice.Size = New Size(108, 26)
        txtProductPrice.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Location = New Point(44, 388)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(87, 43)
        Panel1.TabIndex = 3
        ' 
        ' panelAdd
        ' 
        panelAdd.BackColor = Color.Transparent
        panelAdd.Location = New Point(108, 487)
        panelAdd.Margin = New Padding(3, 4, 3, 4)
        panelAdd.Name = "panelAdd"
        panelAdd.Size = New Size(87, 43)
        panelAdd.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Transparent
        Panel6.Location = New Point(230, 566)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(51, 45)
        Panel6.TabIndex = 20
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(Panel5)
        Panel4.Location = New Point(164, 566)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(51, 45)
        Panel4.TabIndex = 19
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Transparent
        Panel5.Location = New Point(51, 0)
        Panel5.Margin = New Padding(3, 4, 3, 4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(51, 45)
        Panel5.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Location = New Point(93, 564)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(51, 45)
        Panel3.TabIndex = 18
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Transparent
        Panel7.Location = New Point(27, 564)
        Panel7.Margin = New Padding(3, 4, 3, 4)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(49, 45)
        Panel7.TabIndex = 17
        ' 
        ' pbProductImage
        ' 
        pbProductImage.BackColor = Color.Transparent
        pbProductImage.BackgroundImageLayout = ImageLayout.Stretch
        pbProductImage.Location = New Point(164, 367)
        pbProductImage.Margin = New Padding(3, 4, 3, 4)
        pbProductImage.Name = "pbProductImage"
        pbProductImage.Size = New Size(88, 96)
        pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage
        pbProductImage.TabIndex = 21
        pbProductImage.TabStop = False
        ' 
        ' txtProductID
        ' 
        txtProductID.BackColor = Color.DarkSeaGreen
        txtProductID.Font = New Font("Tw Cen MT Condensed", 10.2F)
        txtProductID.Location = New Point(158, 252)
        txtProductID.Margin = New Padding(3, 4, 3, 4)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(108, 26)
        txtProductID.TabIndex = 0
        ' 
        ' AdmAdd
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(pbProductImage)
        Controls.Add(Panel6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel7)
        Controls.Add(panelAdd)
        Controls.Add(Panel1)
        Controls.Add(txtProductPrice)
        Controls.Add(txtProductName)
        Controls.Add(txtProductID)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdmAdd"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel4.ResumeLayout(False)
        CType(pbProductImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelAdd As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents pbProductImage As PictureBox
    Friend WithEvents txtProductID As TextBox
End Class
