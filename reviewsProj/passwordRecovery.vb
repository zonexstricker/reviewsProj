
Imports System.Data.OleDb

Public Class passwordRecovery

    Dim MaxRows As Integer 'maxiumum rows
    Dim MaxCol As Integer
    Dim curRow As Integer = 0 'current row
    Dim passedValidation As Integer = 0
    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\reviewsDB.accdb")
    Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Dim sql As String 'The sql command
    Dim userFound As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        sql = "SELECT UserID, UserPass, FirstName FROM Users"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "DSUsers")

        If Control.IsKeyLocked(Keys.CapsLock) Then
            lblCapsWarning.Text = "Warning caps lock on"
        Else
            lblCapsWarning.Text = ""
        End If

    End Sub

    Private Sub pbHideShow_Click(sender As Object, e As EventArgs) Handles pbHideShow.Click
        If txtBoxPassword.UseSystemPasswordChar = True Then
            txtBoxPassword.UseSystemPasswordChar = False
            lblStatus.Text = "Shown"
        Else
            txtBoxPassword.UseSystemPasswordChar = True
            lblStatus.Text = "Hidden"
        End If
    End Sub
    Private Sub Submit(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MaxRows = ds.Tables("DSUsers").Rows.Count
        curRow = 0
        While (curRow < MaxRows)

            If (txtBoxUsername.Text = ds.Tables("DSUsers").Rows(curRow).Item(0)) Then
                If (txtBoxForename.Text = ds.Tables("DSUsers").Rows(curRow).Item(2)) Then
                    txtBoxPassword.Text = ds.Tables("DSUsers").Rows(curRow).Item(1)
                    Exit While
                Else
                    MsgBox("Username or Forename incorrect")
                End If

                ' If (curRow > 2) Then 'temporary until i make the program know how many rows there are''
                'MsgBox("The username or password you have entered is incorrect, please try again.") 'we tell the user that the username and password needs to be reentered to avoid brute force attacks''
            Else
                '

                curRow = curRow + 1
            End If
        End While
    End Sub
End Class