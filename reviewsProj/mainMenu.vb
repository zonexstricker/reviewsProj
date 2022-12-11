Public Class mainMenu
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        newAccount.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        passEntry.Show()
        Me.Hide()
    End Sub
End Class