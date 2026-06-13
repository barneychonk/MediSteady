<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homePage))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        Button4 = New Button()
        dgvResults = New DataGridView()
        btnDetails = New Button()
        CType(dgvResults, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(129, 35)
        Button1.Name = "Button1"
        Button1.Size = New Size(35, 40)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(166, 35)
        Button2.Name = "Button2"
        Button2.Size = New Size(34, 36)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(197, 35)
        Button3.Name = "Button3"
        Button3.Size = New Size(34, 36)
        Button3.TabIndex = 2
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkOliveGreen
        Label1.Location = New Point(166, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 40)
        Label1.TabIndex = 4
        Label1.Text = "Pharmacy's" & vbCrLf & "Location" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(78, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 5
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.Honeydew
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Cursor = Cursors.IBeam
        txtSearch.Font = New Font("Tw Cen MT", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(78, 165)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search..."
        txtSearch.Size = New Size(190, 22)
        txtSearch.TabIndex = 6
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Transparent
        btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), Image)
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Location = New Point(37, 161)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(33, 37)
        btnSearch.TabIndex = 7
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(239, 27)
        Button4.Name = "Button4"
        Button4.Size = New Size(49, 51)
        Button4.TabIndex = 11
        Button4.UseVisualStyleBackColor = False
        ' 
        ' dgvResults
        ' 
        DataGridViewCellStyle1.BackColor = Color.DarkSeaGreen
        DataGridViewCellStyle1.Font = New Font("Tw Cen MT", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.DarkGreen
        DataGridViewCellStyle1.SelectionBackColor = Color.Olive
        DataGridViewCellStyle1.SelectionForeColor = Color.Beige
        dgvResults.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvResults.BackgroundColor = Color.DarkSeaGreen
        dgvResults.BorderStyle = BorderStyle.Fixed3D
        dgvResults.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.SeaGreen
        DataGridViewCellStyle2.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.Honeydew
        DataGridViewCellStyle2.SelectionBackColor = Color.OliveDrab
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.DarkSeaGreen
        DataGridViewCellStyle3.Font = New Font("Tw Cen MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.DarkGreen
        DataGridViewCellStyle3.SelectionBackColor = Color.Olive
        DataGridViewCellStyle3.SelectionForeColor = Color.Beige
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvResults.DefaultCellStyle = DataGridViewCellStyle3
        dgvResults.GridColor = Color.DarkOliveGreen
        dgvResults.Location = New Point(14, 212)
        dgvResults.Margin = New Padding(3, 4, 3, 4)
        dgvResults.Name = "dgvResults"
        dgvResults.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.DarkSeaGreen
        DataGridViewCellStyle4.Font = New Font("Tw Cen MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = Color.Olive
        DataGridViewCellStyle4.SelectionForeColor = Color.LightGoldenrodYellow
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvResults.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvResults.RowHeadersWidth = 51
        DataGridViewCellStyle5.BackColor = Color.DarkSeaGreen
        DataGridViewCellStyle5.Font = New Font("Tw Cen MT", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = Color.Olive
        DataGridViewCellStyle5.SelectionForeColor = Color.LightGoldenrodYellow
        dgvResults.RowsDefaultCellStyle = DataGridViewCellStyle5
        dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvResults.Size = New Size(274, 335)
        dgvResults.TabIndex = 12
        ' 
        ' btnDetails
        ' 
        btnDetails.BackColor = Color.DarkSeaGreen
        btnDetails.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnDetails.ForeColor = SystemColors.ButtonFace
        btnDetails.Location = New Point(166, 555)
        btnDetails.Margin = New Padding(3, 4, 3, 4)
        btnDetails.Name = "btnDetails"
        btnDetails.Size = New Size(122, 31)
        btnDetails.TabIndex = 13
        btnDetails.Text = "View Details"
        btnDetails.UseVisualStyleBackColor = False
        ' 
        ' homePage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(btnDetails)
        Controls.Add(dgvResults)
        Controls.Add(Button4)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        DoubleBuffered = True
        Name = "homePage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home Page"
        CType(dgvResults, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents btnDetails As Button
End Class
