﻿Imports System.Data.OleDb
Imports System.Security.Policy

Public Class newAccount

    Dim fd As OpenFileDialog = New OpenFileDialog()
    Dim strFileName As String = ""
    Dim MaxRows As Integer 'maxiumum rows
    Dim MaxCol As Integer
    Dim curRow As Integer = 0 'current row
    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\reviewsDB.accdb")
    Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Dim sql As String 'The sql command
    Dim valPass As Boolean 

    Private Sub validationCheck()
        If presenceCheck(txtBoxPassword.Text) = False Then 'calls the validation module, specifically the presence check, it passes the txtBoxPassword's contents by value and then returns a false if it is empty, true if it contains data
            MsgBox("Please enter a password")
            Exit Sub
        End If
        If presenceCheck(txtBoxUsername.Text) = False Then '^ but username
            MsgBox("Please enter a username")
            Exit Sub
        End If
        If presenceCheck(txtBoxFirst.Text) = False Then 'calls the validation module, specifically the presence check, it passes the txtBoxPassword's contents by value and then returns a false if it is empty, true if it contains data
            MsgBox("Please enter a first name")
            Exit Sub
        End If
        If presenceCheck(txtBoxSurname.Text) = False Then '^ but username
            MsgBox("Please enter a surname")
            Exit Sub
        End If

        valPass = True
    End Sub

    Private Sub sSql(sender As Object, e As EventArgs) Handles PictureBox1.Click 'this adds the new user to the account system
        Call validationCheck()
        If valPass = True Then
            sql = "SELECT * FROM Users"
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(ds, "DSUsers") 'this is the dataset made from the table "unverifedReviews"
            MaxRows = ds.Tables("DSUsers").Rows.Count
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("DSUsers").NewRow()
            ds.Tables("DSUsers").Rows.Add(dsNewRow) 'Adds the new row into the dataset 
            dsNewRow.Item("UserID") = txtBoxUsername.Text
            dsNewRow.Item("FirstName") = txtBoxFirst.Text
            dsNewRow.Item("Surname") = txtBoxSurname.Text
            dsNewRow.Item("UserPass") = txtBoxPassword.Text
            dsNewRow.Item("PfP") = strFileName
            da.Update(ds, "DSUsers")
            MsgBox("Your profile has been added to the database!")
        End If



    End Sub

    Private Sub pbHideShow_Click(sender As Object, e As EventArgs) Handles pbHideShow.Click 'shows and hides the password box
        If txtBoxPassword.UseSystemPasswordChar = True Then
            txtBoxPassword.UseSystemPasswordChar = False
            lblStatus.Text = "Shown"
        Else
            txtBoxPassword.UseSystemPasswordChar = True
            lblStatus.Text = "Hidden"
        End If
    End Sub


    Private Sub btnUploadPfp_Click(sender As Object, e As EventArgs) Handles btnUploadPfp.Click
        fd.Title = "Choose an image"
        fd.InitialDirectory = "..\"
        fd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If

        pbProfilePic.ImageLocation = strFileName ' sets the picture box profile pic to the one selected by the user after pressing the upload pfp button. Does not send into the database
        Dim parts As String() = strFileName.Split("\")
        strFileName = parts(parts.Length - 1) 'sets the variable to the correct file name
    End Sub


End Class