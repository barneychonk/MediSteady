<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogIn))
        txtpassword = New TextBox()
        btnEnter = New Button()
        txtusername = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtpassword
        ' 
        txtpassword.BackColor = Color.Honeydew
        txtpassword.Cursor = Cursors.IBeam
        txtpassword.Font = New Font("Tw Cen MT", 12F)
        txtpassword.ForeColor = Color.DarkOliveGreen
        txtpassword.Location = New Point(81, 366)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.PlaceholderText = "Password"
        txtpassword.Size = New Size(160, 29)
        txtpassword.TabIndex = 15
        txtpassword.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnEnter
        ' 
        btnEnter.BackColor = Color.DarkOliveGreen
        btnEnter.Font = New Font("Tw Cen MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEnter.ForeColor = SystemColors.ButtonFace
        btnEnter.Location = New Point(44, 425)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(203, 42)
        btnEnter.TabIndex = 28
        btnEnter.Text = "ENTER"
        btnEnter.UseVisualStyleBackColor = False
        ' 
        ' txtusername
        ' 
        txtusername.BackColor = Color.Honeydew
        txtusername.Cursor = Cursors.IBeam
        txtusername.Font = New Font("Tw Cen MT", 12F)
        txtusername.ForeColor = Color.DarkOliveGreen
        txtusername.Location = New Point(81, 315)
        txtusername.Name = "txtusername"
        txtusername.PlaceholderText = "Username"
        txtusername.Size = New Size(160, 29)
        txtusername.TabIndex = 2
        txtusername.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOliveGreen
        Button1.Font = New Font("Tw Cen MT", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(81, 553)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 37)
        Button1.TabIndex = 29
        Button1.Text = "BACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' AdminLogIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(Button1)
        Controls.Add(txtusername)
        Controls.Add(txtpassword)
        Controls.Add(btnEnter)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdminLogIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Button1 As Button
End Class
