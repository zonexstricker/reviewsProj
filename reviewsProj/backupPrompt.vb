Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class backupPrompt

    Dim MaxRows As Integer 'maxiumum rows
    Dim MaxCol As Integer
    Dim curRow As Integer = 0 'current row

    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\reviewsDB.accdb")
    Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Dim sql As String 'The sql command
    Dim intSheetCount As Integer 'used to count the ammount of sheets needed
    Dim intLoops As Integer
    Dim stringTable As String
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click

        If rbEmp.Checked = True Then

            sql = "SELECT * FROM Employee"

            da = New OleDb.OleDbDataAdapter(sql, conn)
            Dim ds As New DataSet()
            da.Fill(ds, "DS")

            Dim excelApp As New Excel.Application
            Dim excelWorkbook As Excel.Workbook
            Dim excelWorksheet As Excel.Worksheet
            Dim missingValue As Object = Reflection.Missing.Value

            excelApp = New Excel.Application
            excelWorkbook = excelApp.Workbooks.Add(missingValue)
            excelWorksheet = excelWorkbook.Sheets("Sheet1")

            For i = 0 To ds.Tables("DS").Rows.Count - 1
                For j = 0 To ds.Tables("DS").Columns.Count - 1
                    excelWorksheet.Cells(i + 1, j + 1) = ds.Tables("DS").Rows(i).Item(j) 'adds each data entry as a cell on an excel sheet
                Next
            Next

            excelWorksheet.SaveAs("backup")
            excelWorkbook.Close()
            excelApp.Quit()
            MsgBox("The review table has been backed up")
        End If
        If rbRev.Checked = True Then
            sql = "SELECT * FROM Reviews"

            da = New OleDb.OleDbDataAdapter(sql, conn)
            Dim ds As New DataSet()
            da.Fill(ds, "DS")

            Dim excelApp As New Excel.Application
            Dim excelWorkbook As Excel.Workbook
            Dim excelWorksheet As Excel.Worksheet
            Dim missingValue As Object = Reflection.Missing.Value

            excelApp = New Excel.Application
            excelWorkbook = excelApp.Workbooks.Add(missingValue)
            excelWorksheet = excelWorkbook.Sheets("Sheet1")

            For i = 0 To ds.Tables("DS").Rows.Count - 1
                For j = 0 To ds.Tables("DS").Columns.Count - 1
                    excelWorksheet.Cells(i + 1, j + 1) = ds.Tables("DS").Rows(i).Item(j)
                Next
            Next

            excelWorksheet.SaveAs("backup")
            excelWorkbook.Close()
            excelApp.Quit()
            MsgBox("The review table has been backed up")
        End If
        If rbSites.Checked = True Then
            sql = "SELECT * FROM Sites"

            da = New OleDb.OleDbDataAdapter(sql, conn)
            Dim ds As New DataSet()
            da.Fill(ds, "DS")

            Dim excelApp As New Excel.Application
            Dim excelWorkbook As Excel.Workbook
            Dim excelWorksheet As Excel.Worksheet
            Dim missingValue As Object = Reflection.Missing.Value

            excelApp = New Excel.Application
            excelWorkbook = excelApp.Workbooks.Add(missingValue)
            excelWorksheet = excelWorkbook.Sheets("Sheet1")

            For i = 0 To ds.Tables("DS").Rows.Count - 1
                For j = 0 To ds.Tables("DS").Columns.Count - 1
                    excelWorksheet.Cells(i + 1, j + 1) = ds.Tables("DS").Rows(i).Item(j)
                Next
            Next

            excelWorksheet.SaveAs("backup")
            excelWorkbook.Close()
            excelApp.Quit()
            MsgBox("The review table has been backed up")
        End If
        If rbUnv.Checked = True Then
            sql = "SELECT * FROM unverifiedReviews"

            da = New OleDb.OleDbDataAdapter(sql, conn)
            Dim ds As New DataSet()
            da.Fill(ds, "DS")

            Dim excelApp As New Excel.Application
            Dim excelWorkbook As Excel.Workbook
            Dim excelWorksheet As Excel.Worksheet
            Dim missingValue As Object = Reflection.Missing.Value

            excelApp = New Excel.Application
            excelWorkbook = excelApp.Workbooks.Add(missingValue)
            excelWorksheet = excelWorkbook.Sheets("Sheet1")

            For i = 0 To ds.Tables("DS").Rows.Count - 1
                For j = 0 To ds.Tables("DS").Columns.Count - 1
                    excelWorksheet.Cells(i + 1, j + 1) = ds.Tables("DS").Rows(i).Item(j)
                Next
            Next

            excelWorksheet.SaveAs("backup")
            excelWorkbook.Close()
            excelApp.Quit()
            MsgBox("The review table has been backed up")
        End If
        If rbUsers.Checked = True Then
            sql = "SELECT * FROM Users"

            da = New OleDb.OleDbDataAdapter(sql, conn)
            Dim ds As New DataSet()
            da.Fill(ds, "DS")

            Dim excelApp As New Excel.Application
            Dim excelWorkbook As Excel.Workbook
            Dim excelWorksheet As Excel.Worksheet
            Dim missingValue As Object = Reflection.Missing.Value

            excelApp = New Excel.Application
            excelWorkbook = excelApp.Workbooks.Add(missingValue)
            excelWorksheet = excelWorkbook.Sheets("Sheet1")

            For i = 0 To ds.Tables("DS").Rows.Count - 1
                For j = 0 To ds.Tables("DS").Columns.Count - 1
                    excelWorksheet.Cells(i + 1, j + 1) = ds.Tables("DS").Rows(i).Item(j)
                Next
            Next

            excelWorksheet.SaveAs("backup")
            excelWorkbook.Close()
            excelApp.Quit()
            MsgBox("The review table has been backed up")
        End If


    End Sub

    Private Sub backupPrompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentUser.Text = UserLoggedIn
        pbProfilePic.ImageLocation = profilePicLookup(userOrAdmin:=False)
    End Sub
End Class