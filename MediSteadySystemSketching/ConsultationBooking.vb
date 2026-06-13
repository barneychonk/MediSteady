Imports System.Data.OleDb
Imports System.IO

Public Class ConsultationBooking
    Private Sub homepage_Click(sender As Object, e As EventArgs) Handles Button3.Click
        homePage.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cartPage.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        userProfile.Show()
        Me.Close()
    End Sub

    Private Sub btnSlot_Click(sender As Object, e As EventArgs) Handles btnSlot1.Click, btnSlot2.Click, btnSlot3.Click, btnSlot4.Click
        Dim button As Button = CType(sender, Button)
        If button.Text = "APPOINTMENT BOOKED" Then
            MessageBox.Show("This slot is already booked.", "Slot Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Do you want to confirm this appointment?", "Confirm Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Book the slot in the database
            Dim slotId As String = button.Name.Replace("btnSlot", "")
            If BookSlot(slotId, SharedData.currentusername) Then
                MessageBox.Show("Booking confirmed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                button.Text = "BOOKED"
                button.Enabled = False
            Else
                MessageBox.Show("Failed to book the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Booking cancelled.", " Booking cancelled", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function BookSlot(slotId As String, username As String) As Boolean
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
        Dim query As String = "INSERT INTO Slots (SlotID, Username, Status, BookingDate) VALUES (@SlotID, @Username, 'Booked', @BookingDate)"

        Using connection As New OleDbConnection(connString)
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@SlotID", slotId)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@BookingDate", DateTime.Now)

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            Return rowsAffected > 0
        End Using
    End Function

    Private Sub AppointmentBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserBookings()
    End Sub

    ' Load user's booked slots and display the booking date on buttons
    Private Sub LoadUserBookings()
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
        Dim query As String = "SELECT SlotID, BookingDate FROM Slots WHERE Username = @Username AND Status = 'Booked'"

        Using connection As New OleDbConnection(connString)
            Dim command As New OleDbCommand(query, connection)
            command.Parameters.AddWithValue("@Username", SharedData.currentusername)

            connection.Open()
            Using reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim slotId As String = reader("SlotID").ToString()
                    Dim bookingDate As DateTime = Convert.ToDateTime(reader("BookingDate"))

                    Dim button As Button = CType(Me.Controls("btnSlot" & slotId), Button)
                    If button IsNot Nothing Then
                        button.Text = "BOOKED"
                        button.Enabled = False
                        ' Display the booking date in the tooltip
                        button.Tag = "Booked on: " & bookingDate.ToShortDateString()
                        ToolTip1.SetToolTip(button, button.Tag.ToString())
                    End If
                End While
            End Using
        End Using
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        prescriptionpage.Show()
        Me.Close()
    End Sub
End Class
