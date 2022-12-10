Public Class sites
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
        sql = "SELECT * FROM Sites"

        da = New OleDb.OleDbDataAdapter(sql, con)

        da.Fill(ds, "DSSites") 'this is the dataset made from the table "Customers"

        MaxRows = ds.Tables("DSSites").Rows.Count
        curRow = 0
        MaxCol = ds.Tables("DSSites").Columns.Count

        For i = 0 To MaxRows - 1
            DataGridView1.Rows.Add()
            DataGridView1.Rows(i).Cells(0).Value = ds.Tables("DSSites").Rows(i).Item(0)
            DataGridView1.Rows(i).Cells(1).Value = ds.Tables("DSSites").Rows(i).Item(1)
            DataGridView1.Rows(i).Cells(2).Value = ds.Tables("DSSites").Rows(i).Item(2)
            DataGridView1.Rows(i).Cells(3).Value = ds.Tables("DSSites").Rows(i).Item(3)


        Next
    End Sub
End Class

