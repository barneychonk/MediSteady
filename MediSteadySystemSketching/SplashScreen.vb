Imports Microsoft.Win32

Public Class SplashScreen

    Private Sub tmrLoading_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timerLoading.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 10 Then
            lblLoading.Text = "Initiliazing System..."
        ElseIf ProgressBar1.Value <= 20 Then
            lblLoading.Text = "Loading all Components..."
        ElseIf ProgressBar1.Value <= 50 Then
            lblLoading.Text = "Integrating Database..."
        ElseIf ProgressBar1.Value <= 70 Then
            lblLoading.Text = "Checking for errors..."
        ElseIf ProgressBar1.Value <= 98 Then
            lblLoading.Text = "Loading Complete..."
        ElseIf ProgressBar1.Value <= 100 Then
            lblLoading.Text = "Welcome to MediSteady!"
            If ProgressBar1.Value = 100 Then
                timerLoading.Dispose()
                Me.Hide()
                Account.Show()
            End If
        End If
    End Sub


End Class