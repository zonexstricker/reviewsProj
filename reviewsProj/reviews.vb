Public Class reviews
    Dim MaxRows As Integer 'maxiumum rows
    Dim MaxCol As Integer
    Dim curRow As Integer 'current row
    Dim con As New OleDb.OleDbConnection 'using a prefdefined library
    Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Dim sql As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\Visual Studio 2019\reviewsProj\reviewsDB.accdb"
        con.Open()
        sql = "SELECT * FROM Reviews"

        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "DSReviews") 'this is the dataset made from the table "Customers"

        MaxRows = ds.Tables("DSReviews").Rows.Count
        curRow = 0
        MaxCol = ds.Tables("DSReviews").Columns.Count

        For i = 0 To MaxRows - 1
            DataGridView1.Rows.Add()
            DataGridView1.Rows(i).Cells(0).Value = ds.Tables("DSReviews").Rows(i).Item(0)
            DataGridView1.Rows(i).Cells(1).Value = ds.Tables("DSReviews").Rows(i).Item(1)
            DataGridView1.Rows(i).Cells(2).Value = ds.Tables("DSReviews").Rows(i).Item(2)
            DataGridView1.Rows(i).Cells(3).Value = ds.Tables("DSReviews").Rows(i).Item(3)


        Next
        Call NavigateRecords()
    End Sub
    Private Sub NavigateRecords()
        TxtBoxReviewID.Text = ds.Tables("DSReviews").Rows(curRow).Item(0)
        TxtBoxSiteID.Text = ds.Tables("DSReviews").Rows(curRow).Item(1)
        TxtBoxUserID.Text = ds.Tables("DSReviews").Rows(curRow).Item(2)
        txtBoxEmployeeID.Text = ds.Tables("DSReviews").Rows(curRow).Item(3)

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

        If TxtBoxReviewID.Text = "" Then
            MsgBox("Please enter the student ID of the student.")
        ElseIf TxtBoxSiteID.Text = "" Then
            MsgBox("Please enter the first name of the student.")
        ElseIf TxtBoxUserID.Text = "" Then
            MsgBox("Please enter the surname of the student.")
        ElseIf TxtBoxEmployeeID.Text = "" Then
            MsgBox("Please enter the DOB of the student.")
        Else


            ' sql will not work without prefixes and suffixes
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"


            ds.Tables("DSReviews").Rows(curRow).Item(0) = TxtBoxReviewID.Text
            'Updates the dataset to whats written in the text boxes            
            ds.Tables("DSReviews").Rows(curRow).Item(1) = TxtBoxSiteID.Text
            ds.Tables("DSReviews").Rows(curRow).Item(2) = txtBoxEmployeeID.Text





            da.Update(ds, "DSReviews") 'Updates the database with new data

            MsgBox("Data updated") 'this message gives user confimation that an action has taken place (Data updated)
        End If 'end if statement
    End Sub ' end sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
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
End Class

