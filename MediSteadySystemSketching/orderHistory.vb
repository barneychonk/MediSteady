Imports System.Data.OleDb
Imports System.Diagnostics.Contracts
Imports System.IO
Imports System.Net
Imports MediSteadySystemSketching.orderStatus
Public Class orderHistory
    Private orderId As Integer
    Private address As String
    Private contact As String
    Private total As Double


    Public Sub New(selectedOrderID As Integer, selectedaddress As String, selectedcontact As String, selectedtotal As Double)
        InitializeComponent()
        Me.orderId = selectedOrderID
        Me.address = selectedaddress
        Me.contact = selectedcontact
        Me.total = selectedtotal
    End Sub

    Private Sub orderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderDetails()
        lblContact.Text = contact
        lbladdress.Text = address
        lblTotal.Text = total

    End Sub

    Private Sub LoadOrderDetails()
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
        Dim query As String = "SELECT ProductId, ProductName, Quantity, ProductPrice, RowTotal " &
                              "FROM OrderDetails " &
                              "WHERE OrderId = @OrderId"

        Using connection As New OleDbConnection(connString)
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@OrderId", Me.orderID)

            Dim adapter As New OleDbDataAdapter(command)
            Dim detailsTable As New DataTable()
            adapter.Fill(detailsTable)

            dgvOrderDetails.DataSource = detailsTable
        End Using

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        orderStatus.Show()
        Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        homePage.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ConsultationBooking.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cartPage.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        userProfile.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        orderStatus.Show()
        Close()
    End Sub

End Class
