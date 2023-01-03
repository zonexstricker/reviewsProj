Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.OleDb

Module validationMod

    Function presenceCheck(ByVal textbox As String) 'the value textbox is used which will be passed into by (name of textbox).Text when used for presence checking
        If textbox = "" Then 'if the text box is empty return false, meaning validation has failed.
            Return False
        Else

            Return True 'if text box has text, return true, meaning validation succeeded. o/
            End If
        End Function

    Function profilePicLookup(ByVal userOrAdmin As Boolean) 'this finds out the users profile picture, then creates the appropriate return based on its file path so that the picture boxes on each page correctly use the correct profile picture innit :thumbs_up:

        Dim conn As New OleDbConnection("Provider=microsoft.ACE.OLEDB.12.0;Data Source=..\reviewsDB.accdb")
        Dim ds As New DataSet 'whenever a table moves from access it becomes a dataset when in vb
        Dim da As New OleDb.OleDbDataAdapter 'the data adapter is used to push data from vb into access and access into vb
        Dim sql As String 'The sql command

        conn.Open()

        If userOrAdmin = True Then 'this gets the correct PfP for a user

            sql = "SELECT UserID, PfP FROM Users WHERE UserID='" & UserLoggedIn & "'"
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(ds, "DSUsers")

            If ds.Tables("DSUsers").Rows(0).Item(1).ToString() = "" Then 'if there is no profile picture, use the default profile picture
                Return "..\pfps\default.png"
            Else
                Return "..\pfps\" & ds.Tables("DSUsers").Rows(0).Item(1).ToString()
            End If
        End If

        If userOrAdmin = False Then 'this gets the correct PfP for an admin

            sql = "SELECT EmployeeID, PfP FROM Employee WHERE EmployeeID='" & UserLoggedIn & "'"
            da = New OleDb.OleDbDataAdapter(sql, conn)
            da.Fill(ds, "DSEmployee")

            If ds.Tables("DSEmployee").Rows(0).Item(1).ToString() = "" Then 'if there is no profile picture, use the default profile picture
                Return "..\pfps\default.png"
            Else
                Return "..\pfps\" & ds.Tables("DSEmployee").Rows(0).Item(1).ToString()
            End If
        End If



    End Function
End Module
