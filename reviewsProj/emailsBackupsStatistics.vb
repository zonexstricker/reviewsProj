﻿Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Excel = Microsoft.Office.Interop.Excel
Imports outlook = Microsoft.Office.Interop.Outlook
Imports System.Net.Mail
Public Class emailsBackupsStatistics


    Dim MaxRows As Integer 'maxiumum rows
    Dim MaxCol As Integer
    Dim curRow As Integer = 0 'current row

    Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\reviewsDB.accdb")
    Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
    Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
    Dim sql As String 'The sql command

    Private Sub Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT Reviews.SiteID, Count(Reviews.UserID) AS CountOfUserID FROM Reviews GROUP BY Reviews.SiteID"
        conn.Open()
        da = New OleDb.OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()
        da.Fill(ds, "DSRev") 'this is the dataset made from the table "Products"

        MaxRows = ds.Tables("DSRev").Rows.Count
        curRow = 0
        MaxCol = ds.Tables("DSRev").Columns.Count

        Dim ChartArea1 As ChartArea = New ChartArea()
        Dim Legend1 As Legend = New Legend()
        Dim Series1 As Series = New Series()
        Dim Chart1 = New Chart()
        Me.Controls.Add(Chart1)
        Series1.ChartType = SeriesChartType.Bar
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New System.Drawing.Point(13, 13)
        Chart1.Name = "Review Chart"
        Chart1.Titles.Add("Review Chart")
        Series1.Name = "Review Chart"
        Chart1.Titles.Add("Review Chart")
        Series1.Name = "Review"
        Chart1.Series.Add(Series1)
        Chart1.Size = New System.Drawing.Size(400, 200)

        Chart1.Series("Review").XValueMember = "SiteID"
        Chart1.Series("Review").YValueMembers = "CountOfUserID"

        Chart1.DataSource = ds.Tables("DSRev")
        Chart1.Palette = ChartColorPalette.Chocolate
        Chart1.BackColor() = System.Drawing.Color.DarkRed
        Chart1.Cursor = System.Windows.Forms.Cursors.No




    End Sub

    Private Sub btnBackUp_Click(sender As Object, e As EventArgs) Handles btnBackUp.Click
        backupPrompt.Show()
        '   sql = "SELECT * FROM Reviews"

        '   da = New OleDb.OleDbDataAdapter(sql, conn)
        '   Dim ds As New DataSet()
        '  da.Fill(ds, "DSRev")

        '   Dim excelApp As New Excel.Application
        '   Dim excelWorkbook As Excel.Workbook
        '   Dim excelWorksheet As Excel.Worksheet
        '   Dim missingValue As Object = Reflection.Missing.Value

        '   excelApp = New Excel.Application
        '  excelWorkbook = excelApp.Workbooks.Add(missingValue)
        '  excelWorksheet = excelWorkbook.Sheets("Sheet1")

        '   For i = 0 To ds.Tables("DSRev").Rows.Count - 1
        '   For j = 0 To ds.Tables("DSRev").Columns.Count - 1
        '   excelWorksheet.Cells(i + 1, j + 1) = ds.Tables("DSRev").Rows(i).Item(j)
        '   Next
        '   Next

        '   excelWorksheet.SaveAs("backup")
        '  excelWorkbook.Close()
        '  excelApp.Quit()
        '  MsgBox("The review table has been backed up")
    End Sub
End Class