<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignInPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignInPage))
        txtusername = New TextBox()
        Button1 = New Button()
        txtcontact = New TextBox()
        txtpassword = New TextBox()
        txtconfirm = New TextBox()
        txtemail = New TextBox()
        lblLogIn = New Label()
        SuspendLayout()
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.DarkSeaGreen
        txtusername.Cursor = Cursors.IBeam
        txtusername.Font = New Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtusername.ForeColor = Color.Ivory
        txtusername.Location = New Point(77, 310)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "Username"
        txtusername.Size = New Size(167, 29)
        txtusername.TabIndex = 2
        txtusername.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Honeydew
        Button1.Font = New Font("Tw Cen MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.DarkOliveGreen
        Button1.Location = New Point(56, 497)
        Button1.Name = "Button1"
        Button1.Size = New Size(195, 37)
        Button1.TabIndex = 12
        Button1.Text = "SUBMIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtcontact
        ' 
        txtcontact.BackColor = Color.DarkSeaGreen
        txtcontact.Cursor = Cursors.IBeam
        txtcontact.Font = New Font("Tw Cen MT", 12F)
        txtcontact.ForeColor = Color.Ivory
        txtcontact.Location = New Point(77, 382)
        txtcontact.Name = "txtcontact"
        txtcontact.PlaceholderText = "Contact Number"
        txtcontact.Size = New Size(167, 29)
        txtcontact.TabIndex = 14
        txtcontact.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtpassword
        ' 
        txtpassword.BackColor = Color.DarkSeaGreen
        txtpassword.Cursor = Cursors.IBeam
        txtpassword.Font = New Font("Tw Cen MT", 12F)
        txtpassword.ForeColor = Color.Ivory
        txtpassword.Location = New Point(77, 418)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.PlaceholderText = "Password"
        txtpassword.Size = New Size(167, 29)
        txtpassword.TabIndex = 15
        txtpassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtconfirm
        ' 
        txtconfirm.BackColor = Color.DarkSeaGreen
        txtconfirm.Cursor = Cursors.IBeam
        txtconfirm.Font = New Font("Tw Cen MT", 12F)
        txtconfirm.ForeColor = Color.Ivory
        txtconfirm.Location = New Point(77, 454)
        txtconfirm.Name = "txtconfirm"
        txtconfirm.PasswordChar = "*"c
        txtconfirm.PlaceholderText = "Confirm Password"
        txtconfirm.Size = New Size(167, 29)
        txtconfirm.TabIndex = 16
        txtconfirm.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtemail
        ' 
        txtemail.BackColor = Color.DarkSeaGreen
        txtemail.Cursor = Cursors.IBeam
        txtemail.Font = New Font("Tw Cen MT", 12F)
        txtemail.ForeColor = Color.White
        txtemail.Location = New Point(77, 346)
        txtemail.Name = "txtemail"
        txtemail.PlaceholderText = "E-Mail"
        txtemail.Size = New Size(167, 29)
        txtemail.TabIndex = 13
        txtemail.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblLogIn
        ' 
        lblLogIn.AutoSize = True
        lblLogIn.BackColor = Color.Transparent
        lblLogIn.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblLogIn.ForeColor = SystemColors.ButtonHighlight
        lblLogIn.Location = New Point(64, 537)
        lblLogIn.Name = "lblLogIn"
        lblLogIn.Size = New Size(180, 20)
        lblLogIn.TabIndex = 22
        lblLogIn.Text = "Already have an account?" & vbCrLf
        ' 
        ' SignInPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(lblLogIn)
        Controls.Add(txtconfirm)
        Controls.Add(txtpassword)
        Controls.Add(txtcontact)
        Controls.Add(txtemail)
        Controls.Add(txtusername)
        Controls.Add(Button1)
        DoubleBuffered = True
        Name = "SignInPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign In Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtconfirm As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents lblLogIn As Label

End Class
