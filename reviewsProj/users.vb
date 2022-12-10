Imports System.Data.OleDb

Public Class users
    Dim MaxRows As Integer 'maxiumum rows
    Dim MaxCol As Integer
    Dim curRow As Integer = 0 'current row

    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\reviewsDB.accdb")
    Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Dim sql As String 'The sql command








    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        conn.Open()

        sql = "SELECT UserID, UserPass FROM Users"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "DSUsers")

        Call FillDataSets()
        lblCurrentUser.Text = UserLoggedIn
    End Sub


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


    Private Sub FillDataSets()


        sql = "SELECT SiteName, SiteWebAddress FROM Sites"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "DSSites") 'this is the dataset made from the table "Customers"

        lblNameOfBus.Text = ds.Tables("DSSites").Rows(curRow).Item(0).ToString()
        lblBusDesc.Text = ds.Tables("DSSites").Rows(curRow).Item(1).ToString()


        sql = "SELECT * FROM Reviews"

        da = New OleDb.OleDbDataAdapter(sql, conn)

        da.Fill(ds, "DSReviews") 'this is the dataset made from the table "Customers"

        MaxRows = ds.Tables("DSReviews").Rows.Count
        curRow = 0
        MaxCol = ds.Tables("DSReviews").Columns.Count

        Call NavigateRecords()

    End Sub

    Private Sub NavigateRecords()

        lblUsernameGb1.Text = ds.Tables("DSReviews").Rows(curRow).Item(2).ToString()
        lblReviewpoint1Gb1.Text = ds.Tables("DSReviews").Rows(curRow).Item(4).ToString()
        lblReviewpoint2Gb1.Text = ds.Tables("DSReviews").Rows(curRow).Item(5).ToString()
        lblReviewpoint3Gb1.Text = ds.Tables("DSReviews").Rows(curRow).Item(6).ToString()
        lblReviewpoint4Gb1.Text = ds.Tables("DSReviews").Rows(curRow).Item(7).ToString()
        lblReviewpoint5Gb1.Text = ds.Tables("DSReviews").Rows(curRow).Item(8).ToString()
        lblReviewpoint6Gb1.Text = ds.Tables("DSReviews").Rows(curRow).Item(9).ToString()

        lblUsernameGb2.Text = ds.Tables("DSReviews").Rows(curRow + 1).Item(2).ToString()
        lblReviewpoint1Gb2.Text = ds.Tables("DSReviews").Rows(curRow + 1).Item(4).ToString()
        lblReviewpoint2Gb2.Text = ds.Tables("DSReviews").Rows(curRow + 1).Item(5).ToString()
        lblReviewpoint3Gb2.Text = ds.Tables("DSReviews").Rows(curRow + 1).Item(6).ToString()
        lblReviewpoint4Gb2.Text = ds.Tables("DSReviews").Rows(curRow + 1).Item(7).ToString()
        lblReviewpoint5Gb2.Text = ds.Tables("DSReviews").Rows(curRow + 1).Item(8).ToString()
        lblReviewpoint6Gb2.Text = ds.Tables("DSReviews").Rows(curRow + 1).Item(9).ToString()

        lblUsernameGb3.Text = ds.Tables("DSReviews").Rows(curRow + 2).Item(2).ToString()
        lblReviewpoint1Gb3.Text = ds.Tables("DSReviews").Rows(curRow + 2).Item(4).ToString()
        lblReviewpoint2Gb3.Text = ds.Tables("DSReviews").Rows(curRow + 2).Item(5).ToString()
        lblReviewpoint3Gb3.Text = ds.Tables("DSReviews").Rows(curRow + 2).Item(6).ToString()
        lblReviewpoint4Gb3.Text = ds.Tables("DSReviews").Rows(curRow + 2).Item(7).ToString()
        lblReviewpoint5Gb3.Text = ds.Tables("DSReviews").Rows(curRow + 2).Item(8).ToString()
        lblReviewpoint6Gb3.Text = ds.Tables("DSReviews").Rows(curRow + 2).Item(9).ToString()
        If curRow < 2 Then
            btnPrev.Enabled = False

        Else
            btnPrev.Enabled = True
        End If
        If curRow = (MaxRows - 3) Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If
        Call disabledButton()
    End Sub

    Private Sub btnPrev_Click_1(sender As Object, e As EventArgs) Handles btnPrev.Click
        If curRow < 2 Then
            btnPrev.Enabled = False
        Else
            btnPrev.Enabled = True
        End If
        curRow = curRow - 3
        If curRow = MaxRows / 3 Then
            btnNext.Enabled = False
        Else
            btnNext.Enabled = True
        End If
        Call disabledButton()
        Call NavigateRecords()
    End Sub

    Private Sub btnNext_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click
        curRow = curRow + 3

        If curRow = (MaxRows - 3) Then
            btnNext.Enabled = False

        Else
            btnNext.Enabled = True

        End If
        Call disabledButton()
        Call NavigateRecords()

    End Sub

    Private Sub btnReview_Click_1(sender As Object, e As EventArgs) Handles btnReview.Click
        publishReview.Show()
        Me.Hide()
    End Sub



    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        Me.Close()
    End Sub

    Private Sub pbBack_Click(sender As Object, e As EventArgs) Handles pbBack.Click
        Me.Close()
        passEntry.Show()
    End Sub


End Class

