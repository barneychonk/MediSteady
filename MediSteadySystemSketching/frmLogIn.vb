Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class frmLogIn
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"

        Using con As New OleDbConnection(connectionString)
            Using cmd As New OleDbCommand("SELECT * FROM [Users] WHERE Username = @username AND Password = @password", con)
                cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim)
                cmd.Parameters.AddWithValue("@password", txtpass.Text.Trim)

                Try
                    con.Open()

                    Using rdr = cmd.ExecuteReader
                        If rdr.HasRows Then
                            SharedData.currentusername = txtusername.Text.Trim()
                            homePage.Show()
                            Me.Hide()
                        Else
                            MsgBox("Enter a valid username and password.")
                            txtusername.Text = ""
                            txtpass.Text = ""
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using

    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Account.Show()
        Me.Close()
    End Sub


End Class
