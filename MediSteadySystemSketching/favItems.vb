Imports MediSteadySystemSketching.medsDetails
Imports MediSteadySystemSketching.homePage

Public Class favItems

    Public Sub ShowFavorites(favorites As List(Of ProductItem))
        dgvFavorites.Rows.Clear()
        For Each item In favorites
            dgvFavorites.Rows.Add(item.ProductID, item.ProductImage, item.ProductName, item.ProductPrice)
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        orderStatus.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        cartPage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        userProfile.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        homePage.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        ConsultationBooking.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        cartPage.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        userProfile.Show()
    End Sub
    Private Sub favItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvFavorites.Columns.Clear()

        dgvFavorites.Columns.Add("ProductID", "Product ID")
        Dim imageColumn As New DataGridViewImageColumn()
        imageColumn.Name = "ProductImage"
        imageColumn.HeaderText = "Image"
        imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom
        dgvFavorites.Columns.Add(imageColumn)

        dgvFavorites.Columns.Add("ProductName", "Product Name")
        dgvFavorites.Columns.Add("ProductPrice", "Product Price (RM)")

        ShowFavorites(SharedData.favoriteItems)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvFavorites.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvFavorites.SelectedRows
                Dim selectedItemName As String = row.Cells("ProductName").Value.ToString()
                Dim itemToRemove As ProductItem = SharedData.favoriteItems.FirstOrDefault(Function(p) p.ProductName = selectedItemName)
                If itemToRemove IsNot Nothing Then
                    SharedData.favoriteItems.Remove(itemToRemove)
                End If
            Next
            ShowFavorites(SharedData.favoriteItems)
        Else
            MessageBox.Show("Please select an item in the cart that you wish to remove.")
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If dgvFavorites.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvFavorites.SelectedRows(0)
            Dim productID As Integer = CInt(selectedRow.Cells("ProductID").Value)
            Dim productName As String = selectedRow.Cells("ProductName").Value.ToString()
            Dim productPrice As Decimal = CDec(selectedRow.Cells("ProductPrice").Value)
            Dim productImage As Image = CType(selectedRow.Cells("ProductImage").Value, Image)

            Dim detailsForm As New medsDetails(productID, productName, productPrice, productImage)
            detailsForm.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Please select a product to see details.", "Select an Item", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class