<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prescriptionpage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prescriptionpage))
        Panel2 = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        btnUploadfile = New Button()
        lstUploadFiles = New ListBox()
        lblStatus = New Label()
        Label2 = New Label()
        btnConfirmUpload = New Button()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Location = New Point(120, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(178, 69)
        Panel2.TabIndex = 4
        ' 
        ' Button6
        ' 
        Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), Image)
        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Location = New Point(49, 23)
        Button6.Name = "Button6"
        Button6.Size = New Size(31, 36)
        Button6.TabIndex = 4
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.BackgroundImageLayout = ImageLayout.Stretch
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(128, 23)
        Button5.Name = "Button5"
        Button5.Size = New Size(31, 36)
        Button5.TabIndex = 2
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(79, 23)
        Button4.Name = "Button4"
        Button4.Size = New Size(31, 36)
        Button4.TabIndex = 1
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(11, 21)
        Button3.Name = "Button3"
        Button3.Size = New Size(31, 36)
        Button3.TabIndex = 0
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnUploadfile
        ' 
        btnUploadfile.BackColor = Color.Transparent
        btnUploadfile.BackgroundImage = CType(resources.GetObject("btnUploadfile.BackgroundImage"), Image)
        btnUploadfile.BackgroundImageLayout = ImageLayout.Stretch
        btnUploadfile.Location = New Point(38, 220)
        btnUploadfile.Margin = New Padding(3, 4, 3, 4)
        btnUploadfile.Name = "btnUploadfile"
        btnUploadfile.Size = New Size(48, 47)
        btnUploadfile.TabIndex = 5
        btnUploadfile.UseVisualStyleBackColor = False
        ' 
        ' lstUploadFiles
        ' 
        lstUploadFiles.BackColor = Color.Honeydew
        lstUploadFiles.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstUploadFiles.FormattingEnabled = True
        lstUploadFiles.Location = New Point(92, 184)
        lstUploadFiles.Margin = New Padding(3, 4, 3, 4)
        lstUploadFiles.Name = "lstUploadFiles"
        lstUploadFiles.Size = New Size(172, 124)
        lstUploadFiles.TabIndex = 6
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.BackColor = Color.Transparent
        lblStatus.Font = New Font("Tw Cen MT", 10.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.Ivory
        lblStatus.Location = New Point(92, 432)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(116, 40)
        lblStatus.TabIndex = 7
        lblStatus.Text = "WAITING FOR" & vbCrLf & "APPROVAL"
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Tw Cen MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkOliveGreen
        Label2.Location = New Point(47, 385)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 27)
        Label2.TabIndex = 8
        Label2.Text = "APPROVAL STATUS:"
        ' 
        ' btnConfirmUpload
        ' 
        btnConfirmUpload.BackColor = Color.DarkSeaGreen
        btnConfirmUpload.Font = New Font("Tw Cen MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirmUpload.ForeColor = Color.DarkOliveGreen
        btnConfirmUpload.Location = New Point(38, 313)
        btnConfirmUpload.Margin = New Padding(3, 4, 3, 4)
        btnConfirmUpload.Name = "btnConfirmUpload"
        btnConfirmUpload.Size = New Size(226, 38)
        btnConfirmUpload.TabIndex = 9
        btnConfirmUpload.Text = "Confirm Upload"
        btnConfirmUpload.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Location = New Point(161, 88)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(47, 53)
        Panel1.TabIndex = 19
        ' 
        ' prescriptionpage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(Panel1)
        Controls.Add(btnConfirmUpload)
        Controls.Add(Label2)
        Controls.Add(lblStatus)
        Controls.Add(lstUploadFiles)
        Controls.Add(btnUploadfile)
        Controls.Add(Panel2)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "prescriptionpage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Prescription Page"
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnUploadfile As Button
    Friend WithEvents lstUploadFiles As ListBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirmUpload As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
End Class
