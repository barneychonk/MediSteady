<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orderHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orderHistory))
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        dgvOrderDetails = New DataGridView()
        Label11 = New Label()
        Label12 = New Label()
        lbladdress = New Label()
        lblTotal = New Label()
        lblContact = New Label()
        Label13 = New Label()
        Button5 = New Button()
        Panel1.SuspendLayout()
        CType(dgvOrderDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Honeydew
        Label2.Location = New Point(112, 275)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 29)
        Label2.TabIndex = 11
        Label2.Text = "#000001"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkOliveGreen
        Label1.Location = New Point(82, 247)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 29)
        Label1.TabIndex = 10
        Label1.Text = "ORDER STATUS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Honeydew
        Label3.Location = New Point(182, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 20)
        Label3.TabIndex = 12
        Label3.Text = "COMPLETED"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(240, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(50, 53)
        Button1.TabIndex = 21
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(123, 32)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(168, 43)
        Panel1.TabIndex = 22
        ' 
        ' Button4
        ' 
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(5, 1)
        Button4.Name = "Button4"
        Button4.Size = New Size(37, 40)
        Button4.TabIndex = 25
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(41, 1)
        Button3.Name = "Button3"
        Button3.Size = New Size(37, 40)
        Button3.TabIndex = 24
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(73, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(37, 40)
        Button2.TabIndex = 23
        Button2.UseVisualStyleBackColor = True
        ' 
        ' dgvOrderDetails
        ' 
        dgvOrderDetails.BackgroundColor = Color.DarkSeaGreen
        dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOrderDetails.Location = New Point(14, 192)
        dgvOrderDetails.Margin = New Padding(3, 4, 3, 4)
        dgvOrderDetails.Name = "dgvOrderDetails"
        dgvOrderDetails.RowHeadersWidth = 51
        dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrderDetails.Size = New Size(277, 220)
        dgvOrderDetails.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.DarkOliveGreen
        Label11.Location = New Point(14, 435)
        Label11.Name = "Label11"
        Label11.Size = New Size(81, 20)
        Label11.TabIndex = 25
        Label11.Text = "ADDRESS:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.DarkOliveGreen
        Label12.Location = New Point(56, 530)
        Label12.Name = "Label12"
        Label12.Size = New Size(61, 20)
        Label12.TabIndex = 26
        Label12.Text = "TOTAL:"
        ' 
        ' lbladdress
        ' 
        lbladdress.AutoSize = True
        lbladdress.BackColor = Color.Transparent
        lbladdress.Font = New Font("Tw Cen MT", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbladdress.Location = New Point(101, 437)
        lbladdress.Name = "lbladdress"
        lbladdress.Size = New Size(40, 17)
        lbladdress.TabIndex = 27
        lbladdress.Text = "Label"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.Transparent
        lblTotal.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.DarkGreen
        lblTotal.Location = New Point(208, 530)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(40, 20)
        lblTotal.TabIndex = 28
        lblTotal.Text = "total"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.BackColor = Color.Transparent
        lblContact.Font = New Font("Tw Cen MT", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblContact.Location = New Point(103, 484)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(40, 17)
        lblContact.TabIndex = 29
        lblContact.Text = "Label"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold)
        Label13.ForeColor = Color.DarkOliveGreen
        Label13.Location = New Point(14, 482)
        Label13.Name = "Label13"
        Label13.Size = New Size(86, 20)
        Label13.TabIndex = 30
        Label13.Text = "CONTACT:"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.DarkSeaGreen
        Button5.Font = New Font("Tw Cen MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(197, 579)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 31
        Button5.Text = "Back"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' orderHistory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(Button5)
        Controls.Add(Label13)
        Controls.Add(lblContact)
        Controls.Add(lblTotal)
        Controls.Add(lbladdress)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(dgvOrderDetails)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "orderHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Order History"
        Panel1.ResumeLayout(False)
        CType(dgvOrderDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dgvOrderDetails As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button5 As Button
End Class
