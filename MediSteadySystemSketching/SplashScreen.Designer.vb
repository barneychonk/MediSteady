<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        ProgressBar1 = New ProgressBar()
        lblLoading = New Label()
        timerLoading = New Timer(components)
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = SystemColors.Control
        ProgressBar1.ForeColor = Color.DarkSeaGreen
        ProgressBar1.Location = New Point(11, 315)
        ProgressBar1.Margin = New Padding(3, 4, 3, 4)
        ProgressBar1.MarqueeAnimationSpeed = 120
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(283, 31)
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.TabIndex = 0
        ' 
        ' lblLoading
        ' 
        lblLoading.AutoSize = True
        lblLoading.BackColor = Color.Transparent
        lblLoading.Font = New Font("Tw Cen MT", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblLoading.ForeColor = SystemColors.ButtonFace
        lblLoading.Location = New Point(12, 350)
        lblLoading.Name = "lblLoading"
        lblLoading.Size = New Size(53, 20)
        lblLoading.TabIndex = 1
        lblLoading.Text = "Label1"
        ' 
        ' timerLoading
        ' 
        timerLoading.Enabled = True
        ' 
        ' SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(302, 620)
        Controls.Add(lblLoading)
        Controls.Add(ProgressBar1)
        DoubleBuffered = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "SplashScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SplashScreen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblLoading As Label
    Friend WithEvents timerLoading As Timer
End Class
