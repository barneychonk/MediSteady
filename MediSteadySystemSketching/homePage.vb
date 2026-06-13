Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class homePage
    Private productsTable As DataTable
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
    Private Sub homePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvResults.Columns.Clear()
        dgvResults.Columns.Add("ProductID", "Product ID")

        Dim imageColumn As New DataGridViewImageColumn()
        imageColumn.Name = "ProductImage"
        imageColumn.HeaderText = "Image"
        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom

        dgvResults.Columns.Add(imageColumn)
        dgvResults.Columns.Add("ProductName", "Product Name")
        dgvResults.Columns.Add("ProductPrice", "Product Price (RM)")

        LoadProductsFromDatabase()
    End Sub

    Private Sub LoadProductsFromDatabase()
        productsTable = New DataTable()

        Using connection As New OleDbConnection(connectionString)
            Dim query As String = "SELECT ProductID, ProductName, ProductPrice, ProductImagePath FROM Products"
            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.Fill(productsTable)
        End Using

        DisplayProducts(productsTable)
    End Sub
    Private Function LoadImage(filePath As String) As Image
        Try
            Dim imagePath As String = Path.Combine(Application.StartupPath, "Images", filePath)
            Return Image.FromFile(imagePath)
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub DisplayProducts(dataTable As DataTable)
        dgvResults.Rows.Clear()

        For Each row As DataRow In dataTable.Rows
            Dim productImage As Image = LoadImage(row("ProductImagePath").ToString())
            dgvResults.Rows.Add(row("ProductID"), productImage, row("ProductName"), row("ProductPrice"))
        Next
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()
        Dim filteredTable As DataTable = productsTable.Clone()

        For Each row As DataRow In productsTable.Rows
            If row("ProductName").ToString().ToLower().Contains(searchTerm) Then
                filteredTable.ImportRow(row)
            End If
        Next
        DisplayProducts(filteredTable)
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        If dgvResults.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvResults.SelectedRows(0)
            Dim productID As Integer = CInt(selectedRow.Cells("ProductID").Value)
            Dim productName As String = selectedRow.Cells("ProductName").Value.ToString()
            Dim productPrice As Decimal = CDec(selectedRow.Cells("ProductPrice").Value)
            Dim productImage As Image = CType(selectedRow.Cells("ProductImage").Value, Image)
            Dim detailsForm As New medsDetails(productID, productName, productPrice, productImage)
            detailsForm.ShowDialog()
        Else
            MessageBox.Show("Please select a product to see details.", "Select an Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cartPage.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        userProfile.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ConsultationBooking.Show()
        Me.Close()
    End Sub


End Class
