


Public Class staff
    Private Sub pbUnv_Click(sender As Object, e As EventArgs) Handles pbUnv.Click
        unverifiedReviews.Show()
    End Sub

    Private Sub pbRev_Click(sender As Object, e As EventArgs) Handles pbRev.Click
        verifiedReviews.Show()
    End Sub

    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        Me.Close()
    End Sub

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        Me.Close()
        passEntry.Show()
    End Sub

    Private Sub staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentUser.Text = UserLoggedIn
    End Sub

    Private Sub btnEBS_Click(sender As Object, e As EventArgs) Handles btnEBS.Click
        emailsBackupsStatistics.Show()
    End Sub
End Class