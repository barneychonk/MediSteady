Imports System.Data.OleDb
Imports System.IO

Public Class AdmProductList
    Private productsTable As DataTable
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
    Private Sub homePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProducts.Columns.Clear()
        dgvProducts.Columns.Add("ProductID", "Product ID")

        Dim imageColumn As New DataGridViewImageColumn()
        imageColumn.Name = "ProductImage"
        imageColumn.HeaderText = "Image"
        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom

        dgvProducts.Columns.Add(imageColumn)
        dgvProducts.Columns.Add("ProductName", "Product Name")
        dgvProducts.Columns.Add("ProductPrice", "Product Price (RM)")

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
        dgvProducts.Rows.Clear()

        For Each row As DataRow In dataTable.Rows
            Dim productImage As Image = LoadImage(row("ProductImagePath").ToString())
            dgvProducts.Rows.Add(row("ProductID"), productImage, row("ProductName"), row("ProductPrice"))
        Next
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        AdmAdd.Show()
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
        Me.Hide()
    End Sub


End Class