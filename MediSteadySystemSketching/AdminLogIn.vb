Imports System.Data.OleDb
Imports System.IO
Public Class AdminLogIn
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"

        Using con As New OleDbConnection(connectionString)
            Using cmd As New OleDbCommand("SELECT * FROM [Admin] WHERE AdminUsername = @username AND AdminPassword = @password", con)
                cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim)
                cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim)

                Try
                    con.Open
                    Using rdr = cmd.ExecuteReader
                        If rdr.HasRows Then
                            AdmProductList.Show
                            Hide
                        Else
                            MsgBox("Enter a valid username and password.")
                            txtusername.Text = ""
                            txtpassword.Text = ""
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Account.Show()
        Me.Hide()
    End Sub
End Class