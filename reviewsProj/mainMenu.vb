Public Class mainMenu
    Private Sub btnNewAccount_Click(sender As Object, e As EventArgs) Handles btnNewAccount.Click
        newAccount.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        passEntry.Show()
        Me.Hide()
    End Sub


End Class