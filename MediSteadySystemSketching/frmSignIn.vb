Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class SignInPage
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader


    Private Function IsValidPassword(password As String) As Boolean
        Dim hasUpperCase As Boolean = password.Any(Function(c) Char.IsUpper(c))
        Dim hasLowerCase As Boolean = password.Any(Function(c) Char.IsLower(c))
        Dim hasDigits As Boolean = password.Any(Function(c) Char.IsDigit(c))
        Dim hasSpecialChars As Boolean = password.Any(Function(c) Not Char.IsLetterOrDigit(c))

        Return password.Length >= 8 AndAlso hasUpperCase AndAlso hasLowerCase AndAlso hasDigits AndAlso hasSpecialChars
    End Function

    Private Function IsDigitsOnly(str As String) As Boolean
        ' Check if all characters in the string are digits
        For Each c As Char In str
            If Not Char.IsDigit(c) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        ' Check if the email contains "@" and "."
        Return email.Contains("@") AndAlso email.Contains(".")
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
        Dim query As String = "INSERT INTO [Users] (Username, UserPassword, Contact, Email) VALUES (@username, @password, @contact, @email)"

        Using con As New OleDbConnection(connectionString)
            Using cmd As New OleDbCommand(query, con)

                cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim())
                cmd.Parameters.AddWithValue("@password", txtconfirm.Text.Trim())
                cmd.Parameters.AddWithValue("@contact", txtcontact.Text.Trim())
                cmd.Parameters.AddWithValue("@email", txtemail.Text.Trim())
                Try
                    con.Open()
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using


        Dim password As String = txtpassword.Text.Trim()
        Dim confirmPassword As String = txtconfirm.Text.Trim()


        If (txtusername.Text = "") Then
            MessageBox.Show("Please enter a username")
            txtusername.Focus()

        ElseIf (txtemail.Text = "") Then
            MessageBox.Show("Please enter your email")
            txtemail.Focus()

        ElseIf Not IsValidEmail(txtemail.Text) Then
            MessageBox.Show("Please enter a valid email address")
            txtemail.Focus()

        ElseIf (txtcontact.Text = "") Then
            MessageBox.Show("Please enter your contact number")
            txtcontact.Focus()

        ElseIf Not IsDigitsOnly(txtcontact.Text) OrElse txtcontact.Text.Length <> 11 Then
            MessageBox.Show("Please enter a valid contact number (without any symbols)")
            txtcontact.Focus()

        ElseIf (txtpassword.Text = "") Then
            MessageBox.Show("Please enter a password")
            txtpassword.Focus()

        ElseIf (txtconfirm.Text = "") Then
            MessageBox.Show("Please re-enter a valid password")
            txtconfirm.Focus()

        ElseIf txtpassword.Text <> confirmPassword Then
            MessageBox.Show("Passwords do not match. Please try again.")
            txtpassword.Focus()
            Return
        ElseIf Not IsValidPassword(password) Then
            MsgBox("Password must be at least 8 characters long, contain upper and lower case letters, numbers, and special characters.")
        Else
            frmLogIn.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub lblLogIn_Click(sender As Object, e As EventArgs) Handles lblLogIn.Click
        frmLogIn.Show()
        Me.Hide()
    End Sub
End Class
