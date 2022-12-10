


Imports System.Data.OleDb

Public Class publishReview
    Dim MaxRows As Integer 'maxiumum rows
    Dim SiteID As String

    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\reviewsDB.accdb")
    Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Dim sql As String 'The sql command
    Dim validationCleared As Integer = 0
    Dim intSiteNamePass As Integer = 0

    Private Sub siteNameToID() 'converts the site name into the site ID so that it can be sent to unverified review table with the correct information
        sql = "SELECT SiteID FROM Sites WHERE SiteName = '" & txtBoxSiteName.Text & "'"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "DSSites") 'this is the dataset made from the table "Sites"
        Try
            SiteID = ds.Tables("DSSites").Rows(0).Item(0).ToString()
        Catch
            MsgBox("Site name invalid, please enter a valid site name.")
            intSiteNamePass = 1
        End Try
    End Sub
    Private Sub unverifiedSQL() 'this submits the unverified review
        sql = "SELECT * FROM unverifiedReviews"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "DSUnvRev") 'this is the dataset made from the table "unverifedReviews"
        MaxRows = ds.Tables("DSUnvRev").Rows.Count
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables("DSUnvRev").NewRow()
        ds.Tables("DSUnvRev").Rows.Add(dsNewRow) 'Adds the new row into the dataset 
        dsNewRow.Item("UnverifiedID") = "V" & MaxRows + 1
        dsNewRow.Item("SiteID") = SiteID
        dsNewRow.Item("UserID") = UserLoggedIn
        dsNewRow.Item("rpDelivSpd") = cmbxDeliverySpeed.Text
        dsNewRow.Item("rpQual") = cmbxQuality.Text
        dsNewRow.Item("rpQuant") = cmbxQuantity.Text
        dsNewRow.Item("rpCom") = cmbxCom.Text
        dsNewRow.Item("rpRespSpd") = cmbxResp.Text
        dsNewRow.Item("rpServ") = cmbxServ.Text
        da.Update(ds, "DSUnvRev")
        MsgBox("Review has been submitted for manual review")
        txtBoxSiteName.Text = "" 'clearning text boxes
        cmbxDeliverySpeed.Text = ""
        cmbxQuality.Text = ""
        cmbxQuantity.Text = ""
        cmbxCom.Text = ""
        cmbxResp.Text = ""
        cmbxServ.Text = ""



    End Sub

    Private Sub validateData() 'this is validation, it checks if each combo box and the site name has been entered so that empty cells cannot be sent into the database
        validationCleared = 1

        If presenceCheck(txtBoxSiteName.Text) = False Then
            MsgBox("Site name has not been entered")
            Exit Sub
        ElseIf presenceCheck(cmbxDeliverySpeed.Text) = False Then
            MsgBox("Delivery speed has not been entered")
            Exit Sub
        ElseIf presenceCheck(cmbxQuality.Text) = False Then
            MsgBox("Quality has not been entered")
            Exit Sub
        ElseIf presenceCheck(cmbxQuantity.Text) = False Then
            MsgBox("Quantity has not been entered")
            Exit Sub
        ElseIf presenceCheck(cmbxCom.Text) = False Then
            MsgBox("Communication has not been entered")
            Exit Sub
        ElseIf presenceCheck(cmbxResp.Text) = False Then
            MsgBox("Response has not been entered")
            Exit Sub
        ElseIf presenceCheck(cmbxServ.Text) = False Then
            MsgBox("Service has not been entered")
            Exit Sub
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click 'this calls the subroutines used to send the data to the unverified table via clicking on the submit button
        Call validateData()
        If validationCleared = 1 Then
            Call siteNameToID()
            If intSiteNamePass = 0 Then
                Call unverifiedSQL()
                users.Show()
                Me.Close()
            Else
                MsgBox("Validation has failed, please fill each box with data")
            End If
        End If
    End Sub


End Class