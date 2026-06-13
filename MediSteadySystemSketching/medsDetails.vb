Public Class medsDetails
    Dim quantity As Integer = 1
    Public favoriteItems As New List(Of ProductItem)
    Public Class ProductItem
        Public Property ProductID As Integer
        Public Property ProductName As String
        Public Property ProductPrice As Decimal
        Public Property ProductImage As Image

        Public Sub New(id As Integer, name As String, price As Decimal, image As Image)
            ProductID = id
            ProductName = name
            ProductPrice = price
            ProductImage = image
        End Sub
    End Class
    Public Sub New(productID As Integer, productName As String, productPrice As Decimal, productImage As Image)
        InitializeComponent()
        lblProductID.Text = "Product ID: " & productID
        lblProductName.Text = productName
        lblProductPrice.Text = "RM " & productPrice.ToString("F2")
        pictureBoxProduct.Image = productImage
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        homePage.Close()
        ConsultationBooking.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        userProfile.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        homePage.Show()
    End Sub

    Private Sub btnCartPage_Click(sender As Object, e As EventArgs) Handles btnCartPage.Click
        Me.Close()
        homePage.Close()
        cartPage.Show()
    End Sub


    Private Sub btnAddQty_Click(sender As Object, e As EventArgs) Handles btnAddQty.Click
        quantity += 1
        lblQty.Text = quantity.ToString()
    End Sub

    Private Sub btnRemoveQty_Click(sender As Object, e As EventArgs) Handles btnRemoveQty.Click
        If quantity > 1 Then
            quantity -= 1
            lblQty.Text = quantity.ToString()

        Else
            quantity = 1
            lblQty.Text = quantity.ToString()
        End If
    End Sub

    Private Sub btnFav_Click(sender As Object, e As EventArgs) Handles btnFav.Click
        Dim productID As Integer = CInt(lblProductID.Text.Split(":")(1).Trim())
        Dim productName As String = lblProductName.Text
        Dim productPrice As Decimal = CDec(lblProductPrice.Text.Replace("RM ", "").Trim())
        Dim productImage As Image = pictureBoxProduct.Image

        Dim favoriteItem As New ProductItem(productID, productName, productPrice, productImage)
        SharedData.favoriteItems.Add(favoriteItem)

        MessageBox.Show($"{productName} has been added to your favorites.", "Favorite Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAddCart_Click(sender As Object, e As EventArgs) Handles btnAddCart.Click
        Dim productID As Integer = CInt(lblProductID.Text.Split(":")(1).Trim())
        Dim productName As String = lblProductName.Text
        Dim productPrice As Decimal = CDec(lblProductPrice.Text.Replace("RM ", "").Trim())
        Dim productImage As Image = pictureBoxProduct.Image
        Dim quantity As Integer = CInt(lblQty.Text)

        Dim existingCartItem = SharedData.cartItems.Find(Function(item) item.Product.ProductID = productID)

        If existingCartItem IsNot Nothing Then
            existingCartItem.Quantity += quantity
        Else
            Dim newProduct = New ProductItem(productID, productName, productPrice, productImage)
            Dim cartItem = New CartItem(newProduct, quantity)
            SharedData.cartItems.Add(cartItem)
        End If

        MessageBox.Show($"{productName} has been added to your cart.", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class