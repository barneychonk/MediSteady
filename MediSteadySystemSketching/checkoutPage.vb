Imports System.Data.Common
Imports MediSteadySystemSketching.cartPage
Imports System.Data.OleDb
Imports System.IO
Public Class checkoutPage

    Public order(ordercount) As DataTable
    Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
    Sub ConnectToDatabase()

        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()

            Catch ex As Exception
                MsgBox("Error connecting to database: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        orderStatus.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        favItems.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        homePage.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        ConsultationBooking.Show()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        userProfile.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        cartPage.Show()
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Dim totalAmount As Decimal = 0
        For Each item In SharedData.cartItems
            totalAmount += item.GetTotalPrice()
        Next
        totalAmount += 5.9 'delivery charges

        Dim orderID As Integer
        Using conn As New OleDbConnection(connectionString)

            Dim cmdOrder As New OleDbCommand("INSERT INTO [OrderList] (Username, OrderDate, TotalAmount, Status, Address, ContactNumber) VALUES (@Username, @OrderDate, @TotalAmount, @Status, @Address, @ContactNumber)", conn)
            cmdOrder.Parameters.Add("@Username", OleDbType.VarWChar).Value = SharedData.currentusername
            cmdOrder.Parameters.Add("@OrderDate", OleDbType.Date).Value = DateTime.Now
            cmdOrder.Parameters.Add("@TotalAmount", OleDbType.Currency).Value = totalAmount
            cmdOrder.Parameters.Add("@Status", OleDbType.VarWChar).Value = "Pending"
            cmdOrder.Parameters.Add("@Address", OleDbType.VarWChar).Value = txtAddress.Text
            cmdOrder.Parameters.Add("@ContactNumber", OleDbType.VarWChar).Value = txtContact.Text

            Try
                conn.Open()
                cmdOrder.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try

            cmdOrder.CommandText = "SELECT @@IDENTITY"
            orderID = Convert.ToInt32(cmdOrder.ExecuteScalar())

            For Each item In SharedData.cartItems
                Dim cmdDetail As New OleDbCommand("INSERT INTO [OrderDetails] (OrderID, ProductID, ProductName, ProductPrice, Quantity, RowTotal) VALUES (@OrderID, @ProductID, @ProductName, @ProductPrice, @Quantity, @RowTotal)", conn)
                cmdDetail.Parameters.AddWithValue("@OrderID", orderID)
                cmdDetail.Parameters.AddWithValue("@ProductID", item.Product.ProductID)
                cmdDetail.Parameters.AddWithValue("@ProductName", item.Product.ProductName)
                cmdDetail.Parameters.AddWithValue("@ProductPrice", item.Product.ProductPrice)
                cmdDetail.Parameters.AddWithValue("@Quantity", item.Quantity)
                cmdDetail.Parameters.AddWithValue("@RowTotal", item.GetTotalPrice())
                Try
                    cmdDetail.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Next
        End Using

        If txtAddress.Text = "" Or txtContact.Text = "" Then
            MsgBox("Please enter your delivery address and contact number.")
            Exit Sub

        Else SharedData.cartItems.Clear()
            MsgBox("Order placed successfully!")
            txtAddress.Text = ""
            txtContact.Text = ""

        End If

    End Sub


    Private Sub checkoutPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConnectToDatabase()
        Dim totalAmount As Decimal = 0
        For Each item In SharedData.cartItems
            totalAmount += item.GetTotalPrice()
        Next
        totalAmount += 5.9
        lblPrice.Text = "RM" & totalAmount

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openPhoto As New OpenFileDialog
        openPhoto.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
        openPhoto.ShowDialog()
        pcbPhoto.ImageLocation = openPhoto.FileName
    End Sub

End Class
