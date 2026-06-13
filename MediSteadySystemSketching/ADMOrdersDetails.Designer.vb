<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMOrdersDetails
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvOrdersDetails = New DataGridView()
        Panel6 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel3 = New Panel()
        Panel7 = New Panel()
        btnBack = New Button()
        CType(dgvOrdersDetails, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvOrdersDetails
        ' 
        dgvOrdersDetails.BackgroundColor = Color.DarkSeaGreen
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkOliveGreen
        DataGridViewCellStyle1.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Ivory
        DataGridViewCellStyle1.SelectionBackColor = Color.Ivory
        DataGridViewCellStyle1.SelectionForeColor = Color.DarkOliveGreen
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvOrdersDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvOrdersDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New Font("Tw Cen MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.Ivory
        DataGridViewCellStyle2.SelectionForeColor = Color.DarkOliveGreen
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvOrdersDetails.DefaultCellStyle = DataGridViewCellStyle2
        dgvOrdersDetails.GridColor = Color.DarkOliveGreen
        dgvOrdersDetails.Location = New Point(12, 219)
        dgvOrdersDetails.Margin = New Padding(3, 4, 3, 4)
        dgvOrdersDetails.Name = "dgvOrdersDetails"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.OliveDrab
        DataGridViewCellStyle3.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Ivory
        DataGridViewCellStyle3.SelectionForeColor = Color.DarkOliveGreen
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvOrdersDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvOrdersDetails.RowHeadersWidth = 51
        dgvOrdersDetails.Size = New Size(278, 241)
        dgvOrdersDetails.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Transparent
        Panel6.Location = New Point(232, 564)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(51, 45)
        Panel6.TabIndex = 24
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(Panel5)
        Panel4.Location = New Point(166, 564)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(51, 45)
        Panel4.TabIndex = 23
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
        Panel3.Location = New Point(95, 562)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(51, 45)
        Panel3.TabIndex = 22
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Transparent
        Panel7.Location = New Point(29, 562)
        Panel7.Margin = New Padding(3, 4, 3, 4)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(49, 45)
        Panel7.TabIndex = 21
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DarkSeaGreen
        btnBack.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(183, 471)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 25
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' ADMOrdersDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.orders_admin
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(btnBack)
        Controls.Add(Panel6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel7)
        Controls.Add(dgvOrdersDetails)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "ADMOrdersDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ADMOrdersDetails"
        CType(dgvOrdersDetails, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvOrdersDetails As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnBack As Button
End Class
