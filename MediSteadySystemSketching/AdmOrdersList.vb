Imports System.Data.OleDb
Imports System.IO
Public Class AdmOrdersList
    Private Sub OrderStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderSummaries()
    End Sub

    Private Sub LoadOrderSummaries()
        Dim AdminOrderTable As New DataTable()
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
        Dim query As String = "SELECT OrderId, Username, OrderDate, TotalAmount, Status, Address, ContactNumber FROM OrderList"

        Using connection As New OleDbConnection(connString)
            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.Fill(AdminOrderTable)
            dgvAllOrders.DataSource = AdminOrderTable
        End Using

    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        AdmProductList.Show()
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

    Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
        If dgvAllOrders.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvAllOrders.SelectedRows(0)
            Dim orderId As Integer = CInt(selectedRow.Cells("OrderId").Value)
            Dim orderDetails As New ADMOrdersDetails(orderId)
            orderDetails.Show()
            Me.Close()
        Else
            MessageBox.Show("Please select an order to view order details.", "Please Select an Order.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

End Class