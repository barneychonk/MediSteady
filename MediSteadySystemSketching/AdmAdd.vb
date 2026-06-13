Imports System.Data.Common
Imports System.Data.OleDb
Imports System.IO
Public Class AdmAdd
    Private selectedImageFileName As String
    Private ReadOnly ImageFolderPath As String = Path.Combine(Application.StartupPath, "Images")
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
    Private Sub AdmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub SaveFileToDatabase()
        Dim ProductPrice As Decimal = Decimal.Parse(txtProductPrice.Text)
        Dim ProductID As Integer = Integer.Parse(txtProductID.Text)
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmdAdd As New OleDbCommand("INSERT INTO [Products] (ProductID, ProductName, ProductPrice, ProductImagePath) VALUES (@ProductID, @ProductName, @ProductPrice, @ProductImagePath)", conn)
            cmdAdd.Parameters.Add("@ProductID", OleDbType.Currency).Value = ProductID
            cmdAdd.Parameters.Add("@ProductName", OleDbType.VarWChar).Value = txtProductName.Text
            cmdAdd.Parameters.Add("@ProductPrice", OleDbType.Currency).Value = ProductPrice
            cmdAdd.Parameters.Add("@ProductImagePath", OleDbType.VarWChar).Value = Path.Combine(selectedImageFileName)
            cmdAdd.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Dim targetFolderPath As String = Path.Combine(Application.StartupPath, "Images")

        If Not Directory.Exists(targetFolderPath) Then
            Directory.CreateDirectory(targetFolderPath)
        End If

        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            ofd.Title = "Select Product Image"
            ofd.InitialDirectory = targetFolderPath

            If ofd.ShowDialog() = DialogResult.OK Then
                Dim originalFilePath As String = ofd.FileName
                selectedImageFileName = Path.GetFileName(originalFilePath)
                Dim targetFilePath As String = Path.Combine(targetFolderPath, selectedImageFileName)

                Try
                    File.Copy(originalFilePath, targetFilePath, True)
                    pbProductImage.Image = Image.FromFile(targetFilePath)

                    MessageBox.Show("Image successfully copied and loaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub
    Private Sub panelAdd_Click(sender As Object, e As EventArgs) Handles panelAdd.Click
        If txtProductID.Text = "" Or txtProductName.Text = "" Or txtProductPrice.Text = "" Or String.IsNullOrEmpty(selectedImageFileName) Then
            MessageBox.Show("Please insert all the product details.")
        Else
            SaveFileToDatabase()
            MessageBox.Show("Product uploaded to the products database successfully!")
            selectedImageFileName = ""
        End If

    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        AdmProductList.Show()
        Me.Close()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        AdmOrdersList.Show()
        Me.Close()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        AdmBooking.Show()
        Me.Close()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        AdmPrescription.Show()
        Me.Close()
    End Sub
End Class
