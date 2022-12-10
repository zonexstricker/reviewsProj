Imports System.Data.OleDb

Public Class unverifiedReviews
    Dim MaxRows As Integer 'maxiumum rows
    Dim MaxCol As Integer
    Dim curRow As Integer 'current row
    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\reviewsDB.accdb")
    Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Dim sql As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReviewsDBDataSet.unverifiedReviews' table. You can move, or remove it, as needed.
        Me.UnverifiedReviewsTableAdapter.Fill(Me.ReviewsDBDataSet.unverifiedReviews)


        conn.Open()

        sql = "SELECT * FROM unverifiedReviews"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "DSu")
        MaxRows = ds.Tables("DSu").Rows.Count
        curRow = 0
        MaxCol = ds.Tables("DSu").Columns.Count
        lblCurrentUser.Text = "Logged in as admin " & UserLoggedIn
        Call NavigateRecords()

    End Sub

    Private Sub queryUnverified()
        sql = "SELECT * FROM unverifiedReviews"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "DSu")
        MaxRows = ds.Tables("DSu").Rows.Count
        curRow = 0
        MaxCol = ds.Tables("DSu").Columns.Count
        lblCurrentUser.Text = "Logged in as admin " & UserLoggedIn
        Call NavigateRecords()
    End Sub
    Private Sub NavigateRecords()
        txtBoxUnverifiedID.Text = ds.Tables("DSu").Rows(curRow).Item(0)
        txtBoxSiteID.Text = ds.Tables("DSu").Rows(curRow).Item(1)
        txtBoxUserID.Text = ds.Tables("DSu").Rows(curRow).Item(2)
        txtBoxSpd.Text = ds.Tables("DSu").Rows(curRow).Item(3)
        txtBoxQual.Text = ds.Tables("DSu").Rows(curRow).Item(4)
        txtBoxQuant.Text = ds.Tables("DSu").Rows(curRow).Item(5)
        txtBoxCom.Text = ds.Tables("DSu").Rows(curRow).Item(6)
        txtBoxResp.Text = ds.Tables("DSu").Rows(curRow).Item(7)
        txtBoxServ.Text = ds.Tables("DSu").Rows(curRow).Item(8)
    End Sub

    Private Sub btnReject_Click_1(sender As Object, e As EventArgs) Handles btnReject.Click

        Dim cb As New OleDb.OleDbCommandBuilder(da) 'declares variable
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        If MessageBox.Show("Do you really want to reject this review?",'display a message box with the following message 
                           "Reject", MessageBoxButtons.YesNo,'makes the message box include yes and no buttons
                           MessageBoxIcon.Warning) = DialogResult.No Then 'if the user clicks the no button then execute the below 

            MsgBox("Operation Cancelled") 'display a message box with the following message 
            Exit Sub 'exits sub

        ElseIf DialogResult.Yes Then 'if the uer clicks the yes button, execute the below 

            ds.Tables("DSu").Rows(MaxRows - 1).Delete() 'delete the row the user is currently viewing 
            MaxRows = MaxRows - 1 'Sets value to a variable

            If MaxRows >= 1 Then
                NavigateRecords() 'calls function
            End If
            da.Update(ds, "DSu") 'udate the database
        End If 'end if statement
    End Sub

    Private Sub btnPush_Click_1(sender As Object, e As EventArgs) Handles btnPush.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        sql = "SELECT * FROM Reviews"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "DSv")
        MaxRows = ds.Tables("DSv").Rows.Count
        curRow = MaxRows
        MaxCol = ds.Tables("DSv").Columns.Count

        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        Dim dsNewRow As DataRow


        dsNewRow = ds.Tables("DSv").NewRow()
        ds.Tables("DSv").Rows.Add(dsNewRow) 'Adds the new row into the dataset 
        dsNewRow.Item("ReviewID") = "R" & MaxRows + 2
        dsNewRow.Item("SiteID") = txtBoxSiteID.Text
        dsNewRow.Item("UserID") = txtBoxUserID.Text
        dsNewRow.Item("EmployeeID") = UserLoggedIn
        dsNewRow.Item("ReviewPointDelSpeed") = txtBoxSpd.Text
        dsNewRow.Item("ReviewPointQual") = txtBoxQual.Text
        dsNewRow.Item("ReviewPointQuant") = txtBoxQuant.Text
        dsNewRow.Item("ReviewPointCom") = txtBoxCom.Text
        dsNewRow.Item("ReviewPointResp") = txtBoxResp.Text
        dsNewRow.Item("ReviewPointServ") = txtBoxServ.Text

        da.Update(ds, "DSv")
        MsgBox("New Record added to the Database")

        Call queryUnverified()
    End Sub



End Class