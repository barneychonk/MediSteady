Imports System.Data.OleDb
Imports System.IO
Imports MediSteadySystemSketching.checkoutPage
Public Class orderStatus

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        favItems.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        cartPage.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        ConsultationBooking.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        homePage.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        cartPage.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        userProfile.Show()
    End Sub

    Private Sub OrderStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderSummaries()
    End Sub

    Private Sub LoadOrderSummaries()
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
        Dim query As String = "SELECT OrderId, OrderDate, TotalAmount, Status, Address, ContactNumber " &
                              "FROM OrderList " &
                              "WHERE Username = @Username"

        Using connection As New OleDbConnection(connString)
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@Username", currentusername)

            Dim adapter As New OleDbDataAdapter(command)
            Dim orderTable As New DataTable()
            adapter.Fill(orderTable)

            dgvOrderHistory.DataSource = orderTable
        End Using
    End Sub
    Private Sub btnViewOrderDetails_Click(sender As Object, e As EventArgs) Handles btnViewOrderDetails.Click
        If dgvOrderHistory.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvOrderHistory.SelectedRows(0)
            Dim orderId As Integer = CInt(selectedRow.Cells("OrderId").Value)
            Dim address As String = selectedRow.Cells("Address").Value.ToString()
            Dim contact As String = selectedRow.Cells("ContactNumber").Value.ToString()
            Dim total As Double = CDbl(selectedRow.Cells("TotalAmount").Value)

            Dim orderDetailsForm As New orderHistory(orderId, address, contact, total)
            orderDetailsForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Please select an order to view order details.", "Please Select an Order.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


End Class