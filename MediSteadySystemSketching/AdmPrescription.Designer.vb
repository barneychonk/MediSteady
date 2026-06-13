<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmPrescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdmPrescription))
        Panel6 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        dgvPrescriptions = New DataGridView()
        Button1 = New Button()
        CType(dgvPrescriptions, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Transparent
        Panel6.Location = New Point(227, 562)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(63, 56)
        Panel6.TabIndex = 12
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.Location = New Point(152, 562)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(69, 56)
        Panel4.TabIndex = 11
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.Location = New Point(95, 562)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(51, 56)
        Panel3.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Location = New Point(22, 562)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(67, 56)
        Panel2.TabIndex = 9
        ' 
        ' dgvPrescriptions
        ' 
        dgvPrescriptions.BackgroundColor = Color.DarkSeaGreen
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkOliveGreen
        DataGridViewCellStyle1.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Ivory
        DataGridViewCellStyle1.SelectionBackColor = Color.Ivory
        DataGridViewCellStyle1.SelectionForeColor = Color.DarkOliveGreen
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvPrescriptions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.DarkSeaGreen
        DataGridViewCellStyle2.Font = New Font("Tw Cen MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = Color.Ivory
        DataGridViewCellStyle2.SelectionForeColor = Color.DarkOliveGreen
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvPrescriptions.DefaultCellStyle = DataGridViewCellStyle2
        dgvPrescriptions.Location = New Point(12, 218)
        dgvPrescriptions.Margin = New Padding(3, 4, 3, 4)
        dgvPrescriptions.Name = "dgvPrescriptions"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.DarkOliveGreen
        DataGridViewCellStyle3.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Ivory
        DataGridViewCellStyle3.SelectionBackColor = Color.Ivory
        DataGridViewCellStyle3.SelectionForeColor = Color.DarkOliveGreen
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvPrescriptions.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvPrescriptions.RowHeadersWidth = 51
        dgvPrescriptions.Size = New Size(278, 276)
        dgvPrescriptions.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkOliveGreen
        Button1.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Ivory
        Button1.Location = New Point(107, 517)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 14
        Button1.Text = "EXIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' AdmPrescription
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(Button1)
        Controls.Add(dgvPrescriptions)
        Controls.Add(Panel6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "AdmPrescription"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(dgvPrescriptions, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvPrescriptions As DataGridView
    Friend WithEvents Button1 As Button
End Class
