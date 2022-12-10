Public Class MainMenu




    Private Sub pbUser_Click(sender As Object, e As EventArgs) Handles pbUser.Click
        Try

            users.Show()

        Catch ex As Exception

            MsgBox("The form may be open in another program, close other programs using the table and try again")

        End Try
    End Sub
    Private Sub pbStaff_Click(sender As Object, e As EventArgs) Handles pbStaff.Click
        Try

            staff.Show()

        Catch ex As Exception

            MsgBox("The form may be open in another program, close other programs using the table and try again")

        End Try
    End Sub
End Class