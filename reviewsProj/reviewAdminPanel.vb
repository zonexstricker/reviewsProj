Public Class staff
    Dim MaxRows As Integer 'maxiumum rows
    Dim MaxCol As Integer
    Dim curRow As Integer 'current row
    Dim con As New OleDb.OleDbConnection 'using a prefdefined library
    Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Dim sql As String
    Private Sub staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\reviewsProj\reviewsDb.accdb"
        con.Open()
        sql = "SELECT * FROM Reviews"

        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "DSReviews") 'this si the dataset made from the table "Students"

        MaxRows = ds.Tables("DSReviews").Rows.Count
        curRow = 0



        MaxCol = ds.Tables("DSReviews").Columns.Count




        Call NavigateRecords() 'calls the subroutine to fill out the text boxes
    End Sub
    Private Sub NavigateRecords()
        TxtBoxReview.Text = ds.Tables("DSReviews").Rows(curRow).Item(0)
        TxtBoxSite.Text = ds.Tables("DSReviews").Rows(curRow).Item(1)
        TxtBoxUser.Text = ds.Tables("DSReviews").Rows(curRow).ItemArray(2)
        TxtBoxEmployee.Text = ds.Tables("DSReviews").Rows(curRow).ItemArray(3)
        TxtBoxReview1.Text = ds.Tables("DSReviews").Rows(curRow).Item(4)
        TxtBoxReview2.Text = ds.Tables("DSReviews").Rows(curRow).Item(5)
        TxtBoxReview3.Text = ds.Tables("DSReviews").Rows(curRow).ItemArray(6)
        TxtBoxReview4.Text = ds.Tables("DSReviews").Rows(curRow).ItemArray(7)
        TxtBoxReview5.Text = ds.Tables("DSReviews").Rows(curRow).ItemArray(8)
        TxtBoxReview6.Text = ds.Tables("DSReviews").Rows(curRow).ItemArray(9)

    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If curRow <> MaxRows - 1 Then
            curRow = curRow + 1
            NavigateRecords()
        Else
            MsgBox("No more rows")
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If curRow > 0 Then
            curRow = curRow - 1
            NavigateRecords()
        ElseIf curRow = -1 Then
            MsgBox("No records yet")
        ElseIf curRow = 0 Then
            MsgBox("First record")
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable

        ' This is a validation check to see if there is any data actually present.

        If TxtBoxReview.Text = "" Then
            MsgBox("Please enter the ID of the review.")
        ElseIf TxtBoxSite.Text = "" Then
            MsgBox("Please enter the ID of the site.")
        ElseIf TxtBoxUser.Text = "" Then
            MsgBox("Please enter the ID of the user.")
        ElseIf TxtBoxEmployee.Text = "" Then
            MsgBox("Please enter the ID of the student.")
        ElseIf TxtBoxReview1.Text = "" Then
            MsgBox("Please enter the contents of the review point 1.")
        ElseIf TxtBoxReview2.Text = "" Then
            MsgBox("Please enter the contents of the review point 2.")
        ElseIf TxtBoxReview3.Text = "" Then
            MsgBox("Please enter the contents of the review point 3.")
        ElseIf TxtBoxReview4.Text = "" Then
            MsgBox("Please enter the contents of the review point 4.")
        ElseIf TxtBoxReview5.Text = "" Then
            MsgBox("Please enter the contents of the review point 5.")
        ElseIf TxtBoxReview6.Text = "" Then
            MsgBox("Please enter the contents of the review point 6.")
        Else


            ' sql will not work without prefixes and suffixes
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"


            ds.Tables("DSReviews").Rows(curRow).Item(0) = TxtBoxReview.Text
            'Updates the dataset to whats written in the text boxes            
            ds.Tables("DSReviews").Rows(curRow).Item(1) = TxtBoxSite.Text
            ds.Tables("DSReviews").Rows(curRow).Item(2) = TxtBoxUser.Text
            ds.Tables("DSReviews").Rows(curRow).Item(3) = TxtBoxEmployee.Text
            ds.Tables("DSReviews").Rows(curRow).Item(4) = TxtBoxReview1.Text
            ds.Tables("DSReviews").Rows(curRow).Item(5) = TxtBoxReview2.Text
            ds.Tables("DSReviews").Rows(curRow).Item(6) = TxtBoxReview3.Text
            ds.Tables("DSReviews").Rows(curRow).Item(7) = TxtBoxReview4.Text
            ds.Tables("DSReviews").Rows(curRow).Item(8) = TxtBoxReview5.Text
            ds.Tables("DSReviews").Rows(curRow).Item(9) = TxtBoxReview6.Text





            da.Update(ds, "DSReviews") 'Updates the database with new data

            MsgBox("Data updated") 'this message gives user confimation that an action has taken place (Data updated)
        End If 'end if statement
    End Sub ' end sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        If MessageBox.Show("Do you really want to Delete this Record?",'display a message box with the following message 
                           "Delete", MessageBoxButtons.YesNo,'makes the message box include yes and no buttons
                           MessageBoxIcon.Warning) = DialogResult.No Then 'if the user clicks the no button then execute the below 

            MsgBox("Operation Cancelled") 'display a message box with the following message 
            Exit Sub 'exits sub

        ElseIf DialogResult.Yes Then 'if the uer clicks the yes button, execute the below 

            ds.Tables("DSReviews").Rows(curRow).Delete() 'delete the row the user is currently viewing 
            MaxRows = MaxRows - 1 'Sets value to a variable

            curRow = 1 'Sets value to a variable
            NavigateRecords() 'calls function
            da.Update(ds, "DSReviews") 'udate the database
        End If 'end if statement
    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        If curRow <> -1 Then 'If the current row selected isn't equal to -1 then execute the below 
            Dim cb As New OleDb.OleDbCommandBuilder(da)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            Dim dsNewRow As DataRow


            ' validation/presence test
            If TxtBoxReview.Text = "" Then ' checks if box is empty
                MsgBox("Please enter the ID of the review.") ' provides error message to make user correct it
            ElseIf TxtBoxSite.Text = "" Then
                MsgBox("Please enter the ID of the site.")
            ElseIf TxtBoxUser.Text = "" Then
                MsgBox("Please enter the ID fo the user.")
            ElseIf TxtBoxEmployee.Text = "" Then
                MsgBox("Please enter the ID of the employee.")
            ElseIf TxtBoxReview1.Text = "" Then
                MsgBox("Please enter the review point 1.")
            ElseIf TxtBoxReview2.Text = "" Then
                MsgBox("Please enter the review point 2.")
            ElseIf TxtBoxReview3.Text = "" Then
                MsgBox("Please enter the review point 3.")
            ElseIf TxtBoxReview4.Text = "" Then
                MsgBox("Please enter the review point 4.")
            ElseIf TxtBoxReview5.Text = "" Then
                MsgBox("Please enter the review point 5.")
            ElseIf TxtBoxReview6.Text = "" Then
                MsgBox("Please enter the review point 6.")

                dsNewRow = ds.Tables("DSReviews").NewRow()
                ds.Tables("DSReviews").Rows.Add(dsNewRow) 'Adds the new row into the dataset 
                dsNewRow.Item("ReviewID") = TxtBoxReview.Text
                dsNewRow.Item("SiteID") = TxtBoxSite.Text
                dsNewRow.Item("UserID") = TxtBoxUser.Text
                dsNewRow.Item("EmployeeID") = TxtBoxEmployee.Text
                dsNewRow.Item("ReviewPoint1") = TxtBoxReview1.Text
                dsNewRow.Item("ReviewPoint2") = TxtBoxReview2.Text
                dsNewRow.Item("ReviewPoint3") = TxtBoxReview3.Text
                dsNewRow.Item("ReviewPoint4") = TxtBoxReview4.Text
                dsNewRow.Item("ReviewPoint5") = TxtBoxReview5.Text
                dsNewRow.Item("ReviewPoint6") = TxtBoxReview6.Text


                da.Update(ds, "DSReviews")
                MsgBox("New Record added to the Database")

                BtnAdd.Enabled = False 'Disable the add button
                BtnClearTxtBoxes.Enabled = True 'Enable the clear button
                btnUpdate.Enabled = True 'Enable the update button
                BtnDelete.Enabled = True 'Enable the delete button
            End If
        End If
        MaxRows = ds.Tables("DSReviews").Rows.Count
        MaxCol = ds.Tables("DSReviews").Columns.Count
    End Sub

    Private Sub BtnClearTxtBoxes_Click(sender As Object, e As EventArgs) Handles BtnClearTxtBoxes.Click
        BtnClearTxtBoxes.Enabled = True
        btnUpdate.Enabled = False
        BtnDelete.Enabled = False
        BtnAdd.Enabled = True



        TxtBoxReview.Clear()
        TxtBoxSite.Clear()
        TxtBoxUser.Clear()
        TxtBoxEmployee.Clear()
        TxtBoxReview1.Clear()
        TxtBoxReview2.Clear()
        TxtBoxReview3.Clear()
        TxtBoxReview4.Clear()
        TxtBoxReview5.Clear()
        TxtBoxReview6.Clear()
    End Sub


End Class