Imports System.Data.OleDb
Imports System.IO
Public Class AdmBooking
    Private Sub LoadBookingsFromDatabase()
        Dim Bookings As New DataTable()
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
        Dim query As String = "SELECT SlotId, Username, BookingDate, Status FROM Slots"

        Using connection As New OleDbConnection(connString)
            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.Fill(Bookings)
            dgvBookings.DataSource = Bookings
        End Using
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        AdmProductList.Show()
        Me.Close()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        AdmOrdersList.Show()
        Me.Close()
    End Sub

    Private Sub Panel6_Click(sender As Object, e As EventArgs) Handles Panel6.Click
        AdmPrescription.Show()
        Me.Hide()
    End Sub

    Private Sub AdmBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBookingsFromDatabase()
    End Sub

End Class