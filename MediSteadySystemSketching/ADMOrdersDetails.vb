Imports System.Data.OleDb
Imports System.IO
Imports MediSteadySystemSketching.AdmOrdersList

Public Class ADMOrdersDetails
    Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
    Private orderId As Integer

    Public Sub New(selectedOrderID As Integer)
        InitializeComponent()
        Me.orderId = selectedOrderID

    End Sub

    Private Sub orderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderDetails()
    End Sub

    Private Sub LoadOrderDetails()
        Dim query As String = "SELECT ProductId, ProductName, Quantity, ProductPrice, RowTotal " &
                              "FROM OrderDetails " &
                              "WHERE OrderId = @OrderId"

        Using connection As New OleDbConnection(connString)
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@OrderId", Me.orderId)

            Dim adapter As New OleDbDataAdapter(command)
            Dim detailsTable As New DataTable()
            adapter.Fill(detailsTable)

            dgvOrdersDetails.DataSource = detailsTable
        End Using

    End Sub


    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        AdmAdd.Show()
        Me.Hide()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        AdmBooking.Show()
        Me.Hide()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        Me.Hide()
        AdmPrescription.Show()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        AdmOrdersList.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdmOrdersList.Show()
        Me.Close()
    End Sub
End Class