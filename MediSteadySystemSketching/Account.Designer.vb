<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Account))
        btnSignIn = New Button()
        btnLogIn = New Button()
        btnAdmin = New Button()
        SuspendLayout()
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = Color.DarkSeaGreen
        btnSignIn.Font = New Font("Tw Cen MT", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignIn.ForeColor = Color.WhiteSmoke
        btnSignIn.Location = New Point(59, 297)
        btnSignIn.Margin = New Padding(3, 4, 3, 4)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(183, 55)
        btnSignIn.TabIndex = 0
        btnSignIn.Text = "SIGN IN"
        btnSignIn.UseVisualStyleBackColor = False
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.DarkSeaGreen
        btnLogIn.Font = New Font("Tw Cen MT", 12F, FontStyle.Bold)
        btnLogIn.ForeColor = Color.WhiteSmoke
        btnLogIn.Location = New Point(59, 365)
        btnLogIn.Margin = New Padding(3, 4, 3, 4)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(183, 55)
        btnLogIn.TabIndex = 1
        btnLogIn.Text = "LOG IN"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = Color.OliveDrab
        btnAdmin.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdmin.ForeColor = Color.WhiteSmoke
        btnAdmin.Location = New Point(82, 515)
        btnAdmin.Margin = New Padding(3, 4, 3, 4)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(139, 43)
        btnAdmin.TabIndex = 2
        btnAdmin.Text = "ADMIN"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' Account
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(btnAdmin)
        Controls.Add(btnLogIn)
        Controls.Add(btnSignIn)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "Account"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Account"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnSignIn As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnAdmin As Button
End Class
