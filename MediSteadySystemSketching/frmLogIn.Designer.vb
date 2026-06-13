<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        btnEnter = New Button()
        Panel4 = New Panel()
        PictureBox4 = New PictureBox()
        txtpass = New TextBox()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        txtusername = New TextBox()
        btnBack = New Button()
        Panel4.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.DarkOliveGreen
        btnEnter.Font = New Font("Tw Cen MT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEnter.ForeColor = SystemColors.ButtonFace
        btnEnter.Location = New Point(46, 395)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(203, 37)
        btnEnter.TabIndex = 25
        btnEnter.Text = "ENTER"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Honeydew
        Panel4.Controls.Add(PictureBox4)
        Panel4.Controls.Add(txtpass)
        Panel4.Location = New Point(46, 348)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(203, 29)
        Panel4.TabIndex = 27
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(22, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(19, 27)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' txtpass
        ' 
        txtpass.BackColor = Color.Honeydew
        txtpass.BorderStyle = BorderStyle.None
        txtpass.Cursor = Cursors.IBeam
        txtpass.Font = New Font("Tw Cen MT", 12F)
        txtpass.ForeColor = Color.DarkOliveGreen
        txtpass.Location = New Point(39, 1)
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.PlaceholderText = "Password"
        txtpass.Size = New Size(149, 22)
        txtpass.TabIndex = 15
        txtpass.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Honeydew
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(txtusername)
        Panel1.Location = New Point(46, 309)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(203, 29)
        Panel1.TabIndex = 26
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(21, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(19, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 17
        PictureBox2.TabStop = False
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.Honeydew
        txtusername.BorderStyle = BorderStyle.None
        txtusername.Cursor = Cursors.IBeam
        txtusername.Font = New Font("Tw Cen MT", 12F)
        txtusername.ForeColor = Color.DarkOliveGreen
        txtusername.Location = New Point(40, 3)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "Username"
        txtusername.Size = New Size(149, 22)
        txtusername.TabIndex = 2
        txtusername.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DarkSeaGreen
        btnBack.Font = New Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.ForeColor = SystemColors.ButtonFace
        btnBack.Location = New Point(77, 549)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(144, 37)
        btnBack.TabIndex = 28
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' frmLogIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(btnBack)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        Controls.Add(btnEnter)
        DoubleBuffered = True
        Name = "frmLogIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log In Page"
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnBack As Button
End Class
