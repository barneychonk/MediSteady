

Public Class userProfile

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        homePage.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        ConsultationBooking.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        cartPage.Show()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Me.Hide()
        editProfile.Show()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs)
        Hide()
        editAddress.Show()
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles Panel4.Click
        Me.Hide()
        favItems.Show()
    End Sub



    Private Sub userProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = (currentusername & "'s profile")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim respon As MsgBoxResult
        respon = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "EXIT")
        If respon = MsgBoxResult.Yes Then
            For Each frm As Form In Application.OpenForms.Cast(Of Form).ToArray()
                frm.Close()
            Next
        End If

    End Sub

    Private Sub lblInfo_Click(sender As Object, e As EventArgs)
        Hide()
        editProfile.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        favItems.Show()
        Me.Hide()
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles Panel5.Click
        orderStatus.Show()
        Me.Hide()

    End Sub
End Class