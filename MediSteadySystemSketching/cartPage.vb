Imports System.Data.Common
Imports MediSteadySystemSketching.medsDetails
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class cartPage


    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Private Sub cartPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvCart.Columns.Clear()

        dgvCart.Columns.Add("ProductID", "Product ID")
        dgvCart.Columns.Add("ProductName", "Product Name")
        dgvCart.Columns.Add("ProductPrice", "Product Price (RM)")
        dgvCart.Columns.Add("Quantity", "Quantity")
        dgvCart.Columns.Add("RowTotal", "Total (RM)")

        UpdateCartDisplay()
    End Sub


    Private Sub UpdateCartDisplay()
        dgvCart.Rows.Clear()
        Dim totalPrice As Decimal = 0
        Dim deliverycharges As Double = 5.9

        For Each item In SharedData.cartItems
            Dim rowTotal = item.GetTotalPrice()
            dgvCart.Rows.Add(item.Product.ProductID, item.Product.ProductName, item.Product.ProductPrice.ToString("F2"), item.Quantity, rowTotal.ToString("F2"))
            totalPrice += rowTotal
        Next

        lblPrice.Text = "RM" & totalPrice.ToString("F2")
        lblDelivery.Text = "RM" & deliverycharges.ToString
        lblTotalPrice.Text = "RM" & (totalPrice + deliverycharges).ToString
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        orderStatus.Show()
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
        userProfile.Show()
    End Sub

    Private Sub btnFavItems_Click(sender As Object, e As EventArgs) Handles btnFavItems.Click
        Me.Close()
        favItems.Show()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvCart.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgvCart.SelectedRows
                Dim selectedItemName As String = row.Cells("ProductName").Value.ToString()
                Dim itemToRemove As CartItem = SharedData.cartItems.FirstOrDefault(Function(p) p.Product.ProductName = selectedItemName)
                If itemToRemove IsNot Nothing Then
                    SharedData.cartItems.Remove(itemToRemove)
                End If
            Next

            UpdateCartDisplay()
        Else
            MessageBox.Show("Please select an item in the cart that you wish to remove.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        checkoutPage.Show()
        Me.Close()

    End Sub


End Class
