Imports System.Data.OleDb
Imports System.Security.Policy

Public Class newAccount

    Dim fd As OpenFileDialog = New OpenFileDialog()
    Dim strFileName As String
    Dim MaxRows As Integer 'maxiumum rows
    Dim MaxCol As Integer
    Dim curRow As Integer = 0 'current row
    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\reviewsDB.accdb")
    Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Dim sql As String 'The sql command

    Private Sub sSql(sender As Object, e As EventArgs) Handles PictureBox1.Click 'this adds the new user to the account system
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
        Dim parts As String() = strFileName.Split("/")
        MsgBox(parts())
    End Sub


End Class