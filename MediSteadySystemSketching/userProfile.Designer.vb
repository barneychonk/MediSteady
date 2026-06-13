<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userProfile))
        Button1 = New Button()
        Label1 = New Label()
        lblUsername = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        btnExit = New Button()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(238, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(54, 60)
        Button1.TabIndex = 8
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(55, 229)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 9
        ' 
        ' lblUsername
        ' 
        lblUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        lblUsername.AutoSize = True
        lblUsername.BackColor = Color.Transparent
        lblUsername.Font = New Font("Tw Cen MT", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblUsername.ForeColor = SystemColors.ButtonFace
        lblUsername.Location = New Point(61, 235)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(116, 33)
        lblUsername.TabIndex = 10
        lblUsername.Text = "username"
        lblUsername.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Cursor = Cursors.Hand
        Label4.Font = New Font("Tw Cen MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkOliveGreen
        Label4.Location = New Point(47, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 16
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button7)
        Panel1.Location = New Point(122, 23)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(168, 65)
        Panel1.TabIndex = 25
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
        Button6.Location = New Point(42, 11)
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Cursor = Cursors.Hand
        Panel2.Location = New Point(55, 321)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(201, 47)
        Panel2.TabIndex = 26
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(Label4)
        Panel4.Cursor = Cursors.Hand
        Panel4.Location = New Point(55, 373)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(201, 50)
        Panel4.TabIndex = 28
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Transparent
        Panel5.Cursor = Cursors.Hand
        Panel5.Location = New Point(56, 429)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(201, 53)
        Panel5.TabIndex = 29
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.DarkSeaGreen
        btnExit.Font = New Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.DarkOliveGreen
        btnExit.Location = New Point(97, 535)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(117, 38)
        btnExit.TabIndex = 30
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' userProfile
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(btnExit)
        Controls.Add(Panel4)
        Controls.Add(lblUsername)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel5)
        DoubleBuffered = True
        Name = "userProfile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Profile"
        TopMost = True
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnExit As Button
End Class
