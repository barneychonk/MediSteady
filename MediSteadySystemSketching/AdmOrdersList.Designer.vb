<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmOrdersList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdmOrdersList))
        Panel6 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        dgvAllOrders = New DataGridView()
        btnViewDetails = New Button()
        Panel4.SuspendLayout()
        CType(dgvAllOrders, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Transparent
        Panel6.Location = New Point(229, 563)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(61, 45)
        Panel6.TabIndex = 8
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Controls.Add(Panel5)
        Panel4.Location = New Point(165, 563)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(51, 45)
        Panel4.TabIndex = 7
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
        Panel3.Location = New Point(94, 563)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(51, 45)
        Panel3.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Location = New Point(21, 563)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(60, 45)
        Panel2.TabIndex = 5
        ' 
        ' dgvAllOrders
        ' 
        dgvAllOrders.BackgroundColor = Color.DarkSeaGreen
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkOliveGreen
        DataGridViewCellStyle1.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.Ivory
        DataGridViewCellStyle1.SelectionForeColor = Color.DarkOliveGreen
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAllOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAllOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New Font("Tw Cen MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.Olive
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvAllOrders.DefaultCellStyle = DataGridViewCellStyle2
        dgvAllOrders.GridColor = Color.DarkOliveGreen
        dgvAllOrders.Location = New Point(12, 219)
        dgvAllOrders.Margin = New Padding(3, 4, 3, 4)
        dgvAllOrders.Name = "dgvAllOrders"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.DarkOliveGreen
        DataGridViewCellStyle3.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Ivory
        DataGridViewCellStyle3.SelectionBackColor = Color.Ivory
        DataGridViewCellStyle3.SelectionForeColor = Color.DarkOliveGreen
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvAllOrders.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvAllOrders.RowHeadersWidth = 51
        dgvAllOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAllOrders.Size = New Size(278, 241)
        dgvAllOrders.TabIndex = 9
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.BackColor = Color.DarkOliveGreen
        btnViewDetails.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewDetails.ForeColor = Color.Ivory
        btnViewDetails.Location = New Point(77, 467)
        btnViewDetails.Margin = New Padding(3, 4, 3, 4)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(156, 38)
        btnViewDetails.TabIndex = 10
        btnViewDetails.Text = "View Order"
        btnViewDetails.UseVisualStyleBackColor = False
        ' 
        ' AdmOrdersList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(btnViewDetails)
        Controls.Add(dgvAllOrders)
        Controls.Add(Panel6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdmOrdersList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel4.ResumeLayout(False)
        CType(dgvAllOrders, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvAllOrders As DataGridView
    Friend WithEvents btnViewDetails As Button
End Class
