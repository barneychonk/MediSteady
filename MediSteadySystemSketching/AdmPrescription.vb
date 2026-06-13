Imports System.Data.OleDb
Imports System.IO

Public Class AdmPrescription
    Private Sub LoadPrescription()
        Dim Prescriptions As New DataTable()
        Dim connString As String = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "Database", "MediSteadyUsers.accdb")};"
        Dim query As String = "SELECT ID, Username, FileName, FilePath, UploadDate FROM PrescriptionChecks"

        Using connection As New OleDbConnection(connString)
            Dim adapter As New OleDbDataAdapter(query, connection)
            adapter.Fill(Prescriptions)
            dgvPrescriptions.DataSource = Prescriptions
        End Using
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        AdmProductList.Show()
        Me.Close()
    End Sub

    Private Sub Panel3_CLICK(sender As Object, e As EventArgs) Handles Panel3.Click
        AdmOrdersList.Show()
        Me.Close()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        AdmBooking.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim respon As MsgBoxResult
        respon = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "EXIT")
        If respon = MsgBoxResult.Yes Then
            For Each frm As Form In Application.OpenForms.Cast(Of Form).ToArray()
                frm.Close()
            Next
        End If
    End Sub


    Private Sub AdmPrescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPrescription()
    End Sub


End Class