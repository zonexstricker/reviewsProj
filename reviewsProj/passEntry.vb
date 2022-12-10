
Imports System.Data.OleDb

Module SUsername
    Public UserLoggedIn As String
End Module
Public Class passEntry
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
        sql = "SELECT UserID, UserPass FROM Users"
        da = New OleDb.OleDbDataAdapter(Sql, conn)
        da.Fill(ds, "DSUsers")

        If Control.IsKeyLocked(Keys.CapsLock) Then
            lblCapsWarning.Text = "Warning caps lock on"
        Else
            lblCapsWarning.Text = ""
        End If

    End Sub
    Private Sub LogIn()

        If rbAdmin.Checked = False Then
            MaxRows = ds.Tables("DSUsers").Rows.Count
            curRow = 0
            While (curRow < MaxRows)

                If (txtBoxUsername.Text = ds.Tables("DSUsers").Rows(curRow).Item(0)) Then
                    If (txtBoxPassword.Text = ds.Tables("DSUsers").Rows(curRow).Item(1)) Then
                        UserLoggedIn = txtBoxUsername.Text
                        curRow = 0
                        UserLoggedIn = txtBoxUsername.Text
                        users.Show()
                        Me.Hide()
                        Exit While
                    Else
                        MsgBox("Username or Password incorrect")
                    End If

                    ' If (curRow > 2) Then 'temporary until i make the program know how many rows there are''
                    'MsgBox("The username or password you have entered is incorrect, please try again.") 'we tell the user that the username and password needs to be reentered to avoid brute force attacks''
                Else
                    '

                    curRow = curRow + 1
                End If
            End While

            If (curRow = MaxRows) Then
                MsgBox("Username or Password incorrect")
                passedValidation = 0 'resets validation so that empty fields tell the user the respective error
            End If
        End If
        If rbAdmin.Checked = True Then 'LOOKING FOR ADMIN
            sql = "SELECT EmployeeID, EmployeePass FROM Employee"
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(ds, "DSEmployee")

            MaxRows = ds.Tables("DSEmployee").Rows.Count
            curRow = 0
            While (curRow < MaxRows)

                If (txtBoxUsername.Text = ds.Tables("DSEmployee").Rows(curRow).Item(0)) Then
                    If (txtBoxPassword.Text = ds.Tables("DSEmployee").Rows(curRow).Item(1)) Then
                        UserLoggedIn = txtBoxUsername.Text
                        curRow = 0
                        UserLoggedIn = txtBoxUsername.Text
                        staff.Show()
                        Me.Hide()
                        Exit While
                    Else
                        MsgBox("Username or Password incorrect")
                    End If

                    ' If (curRow > 2) Then 'temporary until i make the program know how many rows there are''
                    'MsgBox("The username or password you have entered is incorrect, please try again.") 'we tell the user that the username and password needs to be reentered to avoid brute force attacks''
                Else
                    '

                    curRow = curRow + 1
                End If
            End While
            If (curRow > MaxRows) Then
                MsgBox("Username or Password incorrect")
                passedValidation = 0 'resets validation so that empty fields tell the user the respective error
            End If
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Call VALIDATETIMELETSGOOOOOOO()
        If passedValidation = 1 Then
            Call LogIn()
        End If
    End Sub


    Private Sub VALIDATETIMELETSGOOOOOOO()

        If presenceCheck(txtBoxPassword.Text) = False Then 'calls the validation module, specifically the presence check, it passes the txtBoxPassword's contents by value and then returns a false if it is empty, true if it contains data
            MsgBox("Please enter a password")
            Exit Sub
        End If
        If presenceCheck(txtBoxUsername.Text) = False Then '^ but username
            MsgBox("Please enter a username")
            Exit Sub
        End If
        passedValidation = 1
    End Sub
    Dim firstClickUser As Integer = 0
    Dim firstClickPass As Integer = 0 'both of these are used so the password and username is not cleared on every click
    Private Sub txtBoxUsername_Click(sender As Object, e As EventArgs) Handles txtBoxUsername.Click 'Clears the box upon click, but only the first click

        If firstClickUser = 0 Then
            txtBoxUsername.Text = ""
            firstClickUser = 1
        End If
    End Sub
    Private Sub txtBoxPassword_Click(sender As Object, e As EventArgs) Handles txtBoxPassword.Click 'Clears the box upon click, but only the first click

        If firstClickPass = 0 Then
            txtBoxPassword.Text = ""
            firstClickPass = 1
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

    Private Sub txtBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles txtBoxUsername.TextChanged
        If Control.IsKeyLocked(Keys.CapsLock) Then
            lblCapsWarning.Text = "Warning caps lock on"
        Else
            lblCapsWarning.Text = ""
        End If
    End Sub

    Private Sub txtBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles txtBoxPassword.TextChanged
        If Control.IsKeyLocked(Keys.CapsLock) Then
            lblCapsWarning.Text = "Warning caps lock on"
        Else
            lblCapsWarning.Text = ""
        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        passwordRecovery.Show()
    End Sub




End Class