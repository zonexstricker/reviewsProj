Imports System.Data.OleDb

Public Class verifiedReviews
    Dim MaxRows As Integer 'maxiumum rows
    Dim MaxCol As Integer
    Dim curRow As Integer 'current row
    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\reviewsDB.accdb")
    Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Dim sql As String

    Private Sub disabledButton()
        If btnNext.Enabled = False Then
            btnNext.Image = reviewsProj.My.Resources.Resources.BtnNextDisabled
        Else
            btnNext.Image = reviewsProj.My.Resources.Resources.BtnNext
        End If
        If btnPrev.Enabled = False Then
            btnPrev.Image = reviewsProj.My.Resources.Resources.BtnBackDisabled
        Else
            btnPrev.Image = reviewsProj.My.Resources.Resources.BtnBack
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentUser.Text = UserLoggedIn
        pbProfilePic.ImageLocation = profilePicLookup(userOrAdmin:=False)

        conn.Open()

        sql = "SELECT * FROM Reviews"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "DSv")
        MaxRows = ds.Tables("DSv").Rows.Count
        curRow = 0
        MaxCol = ds.Tables("DSv").Columns.Count

        Call NavigateRecords()
        lblCurrentUser.Text = "Logged in as admin " & UserLoggedIn
        Call disabledButton()
    End Sub
    Private Sub NavigateRecords()
        txtBoxReviewID.Text = ds.Tables("DSv").Rows(curRow).Item(0)
        txtBoxSiteID.Text = ds.Tables("DSv").Rows(curRow).Item(1)
        txtBoxUserID.Text = ds.Tables("DSv").Rows(curRow).Item(2)
        txtBoxEmployeeID.Text = ds.Tables("DSv").Rows(curRow).Item(3)
        txtBoxSpd.Text = ds.Tables("DSv").Rows(curRow).Item(4)
        txtBoxQual.Text = ds.Tables("DSv").Rows(curRow).Item(5)
        txtBoxQuant.Text = ds.Tables("DSv").Rows(curRow).Item(6)
        txtBoxCom.Text = ds.Tables("DSv").Rows(curRow).Item(7)
        txtBoxResp.Text = ds.Tables("DSv").Rows(curRow).Item(8)
        txtBoxServ.Text = ds.Tables("DSv").Rows(curRow).Item(9)
        Call disabledButton()
    End Sub
    Private Sub btnNext_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click
        If curRow <> MaxRows - 1 Then
            curRow = curRow + 1
            NavigateRecords()
        Else
            MsgBox("No more rows")
        End If
        Call disabledButton()
    End Sub

    Private Sub btnPrev_Click_1(sender As Object, e As EventArgs) Handles btnPrev.Click
        If curRow > 0 Then
            curRow = curRow - 1
            NavigateRecords()
        ElseIf curRow = -1 Then
            MsgBox("No records yet")
        ElseIf curRow = 0 Then
            MsgBox("First record")
        End If
        Call disabledButton()
    End Sub
    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ' This is a validation check to see if there is any data actually present.

        If txtBoxReviewID.Text = "" Then
            MsgBox("Please fill all text boxes.")
        ElseIf txtBoxSiteID.Text = "" Then
            MsgBox("Please fill all text boxes.")
        ElseIf txtBoxUserID.Text = "" Then
            MsgBox("Please fill all text boxes.")
        ElseIf txtBoxEmployeeID.Text = "" Then
            MsgBox("Please fill all text boxes.")
        ElseIf txtBoxSpd.Text = "" Then
            MsgBox("Please fill all text boxes.")
        ElseIf txtBoxQual.Text = "" Then
            MsgBox("Please fill all text boxes.")
        ElseIf txtBoxQuant.Text = "" Then
            MsgBox("Please fill all text boxes.")
        ElseIf txtBoxCom.Text = "" Then
            MsgBox("Please fill all text boxes.")
        ElseIf txtBoxResp.Text = "" Then
            MsgBox("Please fill all text boxes.")
        ElseIf txtBoxServ.Text = "" Then
            MsgBox("Please fill all text boxes.")
        Else


            ' sql will not work without prefixes and suffixes
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"



            'Updates the dataset to whats written in the text boxes            
            ds.Tables("DSv").Rows(curRow).Item(0) = txtBoxReviewID.Text
            ds.Tables("DSv").Rows(curRow).Item(1) = txtBoxSiteID.Text
            ds.Tables("DSv").Rows(curRow).Item(2) = txtBoxUserID.Text
            ds.Tables("DSv").Rows(curRow).Item(3) = txtBoxEmployeeID.Text
            ds.Tables("DSv").Rows(curRow).Item(4) = txtBoxSpd.Text
            ds.Tables("DSv").Rows(curRow).Item(5) = txtBoxQual.Text
            ds.Tables("DSv").Rows(curRow).Item(6) = txtBoxQuant.Text
            ds.Tables("DSv").Rows(curRow).Item(7) = txtBoxCom.Text
            ds.Tables("DSv").Rows(curRow).Item(8) = txtBoxResp.Text
            ds.Tables("DSv").Rows(curRow).Item(9) = txtBoxServ.Text





            da.Update(ds, "DSV") 'Updates the database with new data

            MsgBox("Data updated") 'this message gives user confimation that an action has taken place (Data updated)
        End If 'end if statement
        Call disabledButton()
    End Sub ' end sub
    Private Sub BtnDelete_Click_1(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        If MessageBox.Show("Do you really want to Delete this Record?",'display a message box with the following message 
                           "Delete", MessageBoxButtons.YesNo,'makes the message box include yes and no buttons
                           MessageBoxIcon.Warning) = DialogResult.No Then 'if the user clicks the no button then execute the below 

            MsgBox("Operation Cancelled") 'display a message box with the following message 
            Exit Sub 'exits sub

        ElseIf DialogResult.Yes Then 'if the uer clicks the yes button, execute the below 

            ds.Tables("DSv").Rows(curRow).Delete() 'delete the row the user is currently viewing 
            MaxRows = MaxRows - 1 'Sets value to a variable

            curRow = 1 'Sets value to a variable
            NavigateRecords() 'calls function
            da.Update(ds, "DSv") 'udate the database
        End If 'end if statement
        Call disabledButton()
    End Sub
    Private Sub BtnAdd_Click_1(sender As Object, e As EventArgs) Handles BtnAdd.Click

        If curRow <> -1 Then 'If the current row selected isn't equal to -1 then execute the below 
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            Dim dsNewRow As DataRow


            ' validation/presence test
            If txtBoxReviewID.Text = "" Then
                MsgBox("Please fill all text boxes.")
            ElseIf txtBoxSiteID.Text = "" Then
                MsgBox("Please fill all text boxes.")
            ElseIf txtBoxUserID.Text = "" Then
                MsgBox("Please fill all text boxes.")
            ElseIf txtBoxEmployeeID.Text = "" Then
                MsgBox("Please fill all text boxes.")
            ElseIf txtBoxSpd.Text = "" Then
                MsgBox("Please fill all text boxes.")
            ElseIf txtBoxQual.Text = "" Then
                MsgBox("Please fill all text boxes.")
            ElseIf txtBoxQuant.Text = "" Then
                MsgBox("Please fill all text boxes.")
            ElseIf txtBoxCom.Text = "" Then
                MsgBox("Please fill all text boxes.")
            ElseIf txtBoxResp.Text = "" Then
                MsgBox("Please fill all text boxes.")
            ElseIf txtBoxServ.Text = "" Then
                MsgBox("Please fill all text boxes.")
            Else
                dsNewRow = ds.Tables("DSv").NewRow()
                ds.Tables("DSv").Rows.Add(dsNewRow) 'Adds the new row into the dataset 
                dsNewRow.Item("ReviewID") = txtBoxReviewID.Text
                dsNewRow.Item("SiteID") = txtBoxSiteID.Text
                dsNewRow.Item("UserID") = txtBoxUserID.Text
                dsNewRow.Item("EmployeeID") = txtBoxEmployeeID.Text
                dsNewRow.Item("ReviewPointDelSpeed") = txtBoxSpd.Text
                dsNewRow.Item("ReviewPointQual") = txtBoxQual.Text
                dsNewRow.Item("ReviewPointQuant") = txtBoxQuant.Text
                dsNewRow.Item("ReviewPointCom") = txtBoxCom.Text
                dsNewRow.Item("ReviewPointResp") = txtBoxResp.Text
                dsNewRow.Item("ReviewPointServ") = txtBoxServ.Text


                da.Update(ds, "DSv")
                MsgBox("New Record added to the Database")

                BtnAdd.Enabled = False 'Disable the add button
                BtnClearTxtBoxes.Enabled = True 'Enable the clear button
                btnUpdate.Enabled = True 'Enable the update button
                BtnDelete.Enabled = True 'Enable the delete button
            End If
        End If
        MaxRows = ds.Tables("DSv").Rows.Count
        MaxCol = ds.Tables("DSv").Columns.Count
        Call disabledButton()
    End Sub
    Private Sub BtnClearTxtBoxes_Click_1(sender As Object, e As EventArgs) Handles BtnClearTxtBoxes.Click
        BtnClearTxtBoxes.Enabled = True
        btnUpdate.Enabled = False
        BtnDelete.Enabled = False
        BtnAdd.Enabled = True



        txtBoxReviewID.Clear()
        txtBoxSiteID.Clear()
        txtBoxUserID.Clear()
        txtBoxEmployeeID.Clear()
        txtBoxSpd.Clear()
        txtBoxQual.Clear()
        txtBoxQuant.Clear()
        txtBoxCom.Clear()
        txtBoxResp.Clear()
        txtBoxServ.Clear()
        Call disabledButton()
    End Sub




End Class