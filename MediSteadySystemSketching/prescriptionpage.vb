Imports System.IO
Imports System.Data.OleDb

Public Class prescriptionpage

    Private uploadedFiles As New List(Of String)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = "No Files"
    End Sub

    Private Sub homepage_Click(sender As Object, e As EventArgs) Handles Button3.Click
        homePage.Show()
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cartPage.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        userProfile.Show()
        Me.Close()
    End Sub

    Private Sub btnUploadfile_Click(sender As Object, e As EventArgs) Handles btnUploadfile.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "PDF Files (*.pdf)|*.pdf|Image Files (*.jpg; *.jpeg; *.JPG; *.JPEG; *.png; *.PNG)|*.jpg;*.jpeg;*.JPG;*.JPEG;*.png;*.PNG"
            ofd.Multiselect = True

            If ofd.ShowDialog = DialogResult.OK Then
                For Each filePath In ofd.FileNames
                    If uploadedFiles.Count < 3 Then
                        uploadedFiles.Add(filePath)
                        lstUploadFiles.Items.Add(Path.GetFileName(filePath))

                        SaveFileToDatabase(Path.GetFileName(filePath), filePath)
                    Else
                        MessageBox.Show("You can only upload up to 3 files.", "Upload Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit For
                    End If
                Next
            End If
        End Using
    End Sub

    Private Sub SaveFileToDatabase(fileName As String, filePath As String)

        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"

        Dim query As String = "INSERT INTO PrescriptionChecks (Username, FileName, FilePath, UploadDate) VALUES (@Username, @FileName, @FilePath, @UploadDate)"

        Using connection As New OleDbConnection(connString)
            Using command As New OleDbCommand(query, connection)

                command.Parameters.AddWithValue("@Username", SharedData.currentusername)
                command.Parameters.AddWithValue("@FileName", fileName)
                command.Parameters.AddWithValue("@FilePath", filePath)
                command.Parameters.AddWithValue("@UploadDate", DateTime.Now)
                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using
    End Sub


    Private Sub btnConfirmUpload_Click(sender As Object, e As EventArgs) Handles btnConfirmUpload.Click
        If uploadedFiles.Count > 0 Then
            lblStatus.Text = "Pending"
            MessageBox.Show("Files uploaded successfully. Waiting for pharmacist confirmation.", "Upload Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please upload at least one file before confirming.", "No Files Uploaded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Me.Hide()
        ConsultationBooking.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        ConsultationBooking.Show()
    End Sub
End Class
