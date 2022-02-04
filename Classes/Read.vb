Imports System.Data.OleDb

Public Class Read
    Inherits DataConfig

    Enum Modes
        DirectSearch
        SimilarSearch
        GenericSearch
    End Enum

    Public Shared Function Trylogin() As DataTable
        cmd = New OleDbCommand()
        cmd.Connection = con
        Connect()

        cmd.CommandText = "SELECT * FROM tb_account_creds WHERE ac_Username = @uname AND ac_Password = @passw"
        cmd.Parameters.AddWithValue("@uname", _User.Username)
        cmd.Parameters.AddWithValue("@passw", _User.Password)
        reader = cmd.ExecuteReader()

        Dim dt As New DataTable
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Role", GetType(String))
        dt.Columns.Add("UserID", GetType(Integer))

        If reader.HasRows Then
            reader.Read()
            dt.Rows.Add(reader("ID"), reader("ac_Role"), reader("ac_UserID"))
        End If
        _User.Dispose()
        Return dt
    End Function

    Public Shared Function TransactConverter(_bookid As Integer, _schid As String, _staffid As Integer) As String()
        Dim str_col(3) As String
        cmd = New OleDbCommand()
        cmd.Connection = con
        Connect()

        cmd.CommandText = "SELECT ISBN FROM tb_bookdetails WHERE ID = @id"
        cmd.Parameters.AddWithValue("@id", _bookid)
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            str_col(0) = CStr(reader("ISBN"))
        End If
        cmd.Parameters.Clear()
        reader.Close()

        cmd.CommandText = "SELECT Firstname FROM tb_account_info WHERE ID = @id"
        cmd.Parameters.AddWithValue("@id", _staffid)
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            str_col(1) = CStr(reader("Firstname"))
        End If
        cmd.Parameters.Clear()
        reader.Close()

        cmd.CommandText = "SELECT BR_FullName FROM tb_borrowers WHERE BR_SchoolID = @sid"
        cmd.Parameters.AddWithValue("@sid", _schid)
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            str_col(2) = CStr(reader("BR_FullName"))
        End If
        cmd.Parameters.Clear()
        reader.Close()

        Return str_col
    End Function

    Public Shared Function ViewTransactions(mode As Modes) As DataTable
        cmd = New OleDbCommand()
        Select Case mode
            Case Modes.DirectSearch
            Case Modes.SimilarSearch
                cmd.CommandText = ("SELECT * FROM tb_borrow_transact WHERE isbn LIKE @isbn")
                cmd.Parameters.AddWithValue("@isbn", $"%{_Book.ISBN}%")
            Case Modes.GenericSearch
                cmd.CommandText = ("SELECT TOP 10 * FROM tb_borrow_transact")
        End Select
        cmd.Connection = con
        Connect()

        Dim dt As New DataTable
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("BookID", GetType(Integer))
        dt.Columns.Add("SchoolID", GetType(String))
        dt.Columns.Add("StaffID", GetType(Integer))
        dt.Columns.Add("IssueDate", GetType(String))
        dt.Columns.Add("Duedate", GetType(String))
        dt.Columns.Add("Status", GetType(String))

        reader = cmd.ExecuteReader
        If reader.HasRows Then
            While reader.Read()
                dt.Rows.Add(
                    reader("ID"),
                    reader("bookid"),
                   reader("studentid"),
                   reader("staffid"),
                   reader("releasedate"),
                   reader("duedate"),
                   reader("remarks")
                )
            End While
        End If

        reader.Close()
        cmd.Parameters.Clear()

        If mode = Modes.SimilarSearch Then
            _Book.Dispose()
        End If

        DisConnect()
        Return dt
    End Function

    Public Shared Function ViewUser(mode As Modes) As DataTable
        cmd = New OleDbCommand()
        Select Case mode
            Case Modes.DirectSearch
                cmd.CommandText = ("SELECT tb_account_info.ID, tb_account_info.Firstname, tb_account_info.Lastname, tb_account_info.Occupation, tb_account_info.Contact, tb_account_info.Gender, tb_account_creds.ac_Username, tb_account_creds.ac_Password, tb_account_creds.ac_Role FROM tb_account_info INNER JOIN tb_account_creds ON tb_account_info.ID = tb_account_creds.ac_UserID WHERE tb_account_info.ID = @id")
                cmd.Parameters.AddWithValue("@id", _UserInfo.ID)
            Case Modes.SimilarSearch
                cmd.CommandText = ("SELECT tb_account_info.ID, tb_account_info.Firstname, tb_account_info.Lastname, tb_account_info.Occupation, tb_account_info.Contact, tb_account_info.Gender, tb_account_creds.ac_Username, tb_account_creds.ac_Password, tb_account_creds.ac_Role FROM tb_account_info INNER JOIN tb_account_creds ON tb_account_info.ID = tb_account_creds.ac_UserID WHERE tb_account_info.Firstname LIKE @fname OR tb_account_info.Lastname = @lname ORDER BY tb_account_info.ID DESC")
                cmd.Parameters.AddWithValue("@fname", $"%{_UserInfo.FirstName}%")
                cmd.Parameters.AddWithValue("@lname", $"%{_UserInfo.LastName}%")
            Case Modes.GenericSearch
                cmd.CommandText = ("SELECT tb_account_info.ID, tb_account_info.Firstname, tb_account_info.Lastname, tb_account_info.Occupation, tb_account_info.Contact, tb_account_info.Gender, tb_account_creds.ac_Username, tb_account_creds.ac_Password, tb_account_creds.ac_Role FROM tb_account_info INNER JOIN tb_account_creds ON tb_account_creds.ac_UserID = tb_account_info.ID ORDER BY tb_account_info.ID DESC")
        End Select

        cmd.Connection = con
        Connect()

        Dim dt As New DataTable
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Occupation", GetType(String))
        dt.Columns.Add("Contact", GetType(String))
        dt.Columns.Add("Gender", GetType(String))
        dt.Columns.Add("Username", GetType(String))
        dt.Columns.Add("Password", GetType(String))
        dt.Columns.Add("Role", GetType(String))

        reader = cmd.ExecuteReader
        If reader.HasRows Then
            While reader.Read()
                dt.Rows.Add(
                    reader("ID"),
                    $"{reader("Firstname")} {reader("Lastname")}",
                    reader("Occupation"),
                    reader("Contact"),
                    reader("Gender"),
                    reader("ac_Username"),
                    reader("ac_Password"),
                    reader("ac_Role")
                )
            End While
        End If

        If (mode = Modes.SimilarSearch) Then _UserInfo.Dispose()

        DisConnect()
        Return dt
    End Function

    Public Shared Function DashboardData() As Integer()
        Dim counts(8) As Integer

        cmd = New OleDbCommand()
        cmd.Connection = con
        Connect()

        cmd.CommandText = "SELECT SUM (Copies) FROM tb_bookdetails"
        Try
            counts(0) = CInt(cmd.ExecuteScalar)
        Catch
        End Try
        cmd.Parameters.Clear()

        cmd.CommandText = "SELECT COUNT (*) FROM tb_borrowers"
        Try
            counts(1) = CInt(cmd.ExecuteScalar)
        Catch
        End Try
        cmd.Parameters.Clear()

        cmd.CommandText = "SELECT COUNT (*) FROM tb_borrow_transact"
        Try
            counts(2) = CInt(cmd.ExecuteScalar)
        Catch
        End Try
        cmd.Parameters.Clear()

        cmd.CommandText = "SELECT COUNT (*) FROM tb_account_info"
        Try
            counts(3) = CInt(cmd.ExecuteScalar)
        Catch
        End Try
        cmd.Parameters.Clear()

        cmd.CommandText = "SELECT COUNT (*) FROM tb_borrow_transact WHERE remarks = 'PENDING'"
        Try
            counts(4) = CInt(cmd.ExecuteScalar)
        Catch
        End Try
        cmd.Parameters.Clear()

        cmd.CommandText = "SELECT COUNT (*) FROM tb_borrow_transact WHERE remarks = 'RETURNED'"
        Try
            counts(5) = CInt(cmd.ExecuteScalar)
        Catch
        End Try
        cmd.Parameters.Clear()

        cmd.CommandText = "SELECT SUM (Copies) FROM tb_bookdetails WHERE BookCondition = @con1 OR BookCondition = @con2 OR BookCondition = @con3 OR BookCondition = @con4"
        cmd.Parameters.AddWithValue("@con1", "Fine (F)")
        cmd.Parameters.AddWithValue("@con2", "Near Fine (NF)")
        cmd.Parameters.AddWithValue("@con3", "Very Good (VG)")
        cmd.Parameters.AddWithValue("@con4", "Good (G)")
        Try
            counts(6) = CInt(cmd.ExecuteScalar)
        Catch
        End Try
        cmd.Parameters.Clear()

        cmd.CommandText = "SELECT SUM (Copies) FROM tb_bookdetails WHERE BookCondition = @con1 OR BookCondition = @con2"
        cmd.Parameters.AddWithValue("@con1", "Fair (FR)")
        cmd.Parameters.AddWithValue("@con2", "Poor (P)")
        Try
            counts(7) = CInt(cmd.ExecuteScalar)
        Catch
        End Try
        cmd.Parameters.Clear()

        cmd.Dispose()
        DisConnect()
        Return counts
    End Function

    Public Shared Function ViewBorrower(mode As Read.Modes) As DataTable
        cmd = New OleDbCommand()
        Select Case mode
            Case Modes.SimilarSearch
                cmd.CommandText = ("SELECT * FROM tb_borrowers WHERE BR_SchoolID LIKE @schid ORDER BY ID DESC")
                cmd.Parameters.AddWithValue("@schid", $"%{CStr(_BorrowerInfo.BorrowerID)}%")
            Case Modes.GenericSearch
                cmd.CommandText = ("SELECT TOP 10 * FROM tb_borrowers ORDER BY ID DESC")
        End Select

        cmd.Connection = con
        Connect()
        Dim dt As New DataTable
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("SCHID", GetType(String))
        dt.Columns.Add("Level", GetType(String))

        reader = cmd.ExecuteReader
        If reader.HasRows Then
            While reader.Read()
                dt.Rows.Add(
                reader("ID"),
                reader("BR_FullName"),
                reader("BR_SchoolID"),
                reader("BR_Level")
                )
            End While
        End If

        reader.Close()
        reader = Nothing
        cmd.Parameters.Clear()
        cmd.Dispose()

        If (mode = Modes.SimilarSearch) Then _BorrowerInfo.Dispose()

        DisConnect()
        Return dt
    End Function


    Public Shared Function ViewBooksRecords(mode As Modes) As DataTable
        Select Case mode
            Case Modes.DirectSearch
                cmd = New OleDbCommand("SELECT tb_borrow_transact.ID, tb_borrow_transact.bookid, tb_borrow_transact.studentid, tb_borrow_transact.releasedate,  tb_borrow_transact.duedate, tb_bookdetails.Copies, tb_bookdetails.ISBN, tb_bookdetails.BookCondition FROM tb_borrow_transact INNER JOIN tb_bookdetails ON tb_borrow_transact.bookid = tb_bookdetails.ID WHERE tb_borrow_transact.studentid = @scid AND tb_borrow_transact.remarks = @remarks")
                cmd.Parameters.AddWithValue("@scid", _BorrowerInfo.BorrowerID)
                cmd.Parameters.AddWithValue("@remarks", "PENDING")
            Case Modes.SimilarSearch

            Case Modes.GenericSearch
        End Select

        cmd.Connection = con
        Connect()

        Dim dt_bookReconds As New DataTable
        dt_bookReconds.Columns.Add("BookID", GetType(Integer))
        dt_bookReconds.Columns.Add("TransactID", GetType(Integer))
        dt_bookReconds.Columns.Add("BookISBN", GetType(Integer))
        dt_bookReconds.Columns.Add("BookCopies", GetType(Integer))
        dt_bookReconds.Columns.Add("BookCondition", GetType(String))
        dt_bookReconds.Columns.Add("IssuedDate", GetType(Date))
        dt_bookReconds.Columns.Add("DueDate", GetType(Date))

        reader = cmd.ExecuteReader
        If reader.HasRows Then
            While reader.Read()
                dt_bookReconds.Rows.Add(reader("bookid"), reader("ID"), reader("ISBN"), reader("Copies"), reader("BookCondition"), reader("releasedate"), reader("duedate"))
            End While
        End If

        reader.Close()
        reader = Nothing
        cmd.Parameters.Clear()
        cmd.Dispose()
        DisConnect()
        Return dt_bookReconds
    End Function

    Public Shared Function FindBook(mode As Modes) As DataTable
        cmd = New OleDbCommand()

        Select Case mode
            Case Modes.DirectSearch
                cmd.CommandText = ("SELECT * FROM tb_bookdetails WHERE ISBN = @isbn")
                cmd.Parameters.AddWithValue("@isbn", _Book.ISBN)
            Case Modes.SimilarSearch
                cmd.CommandText = ("SELECT * FROM tb_bookdetails WHERE ISBN LIKE @isbn ORDER BY ID DESC")
                cmd.Parameters.AddWithValue("@isbn", $"%{CStr(_Book.ISBN)}%")
            Case Modes.GenericSearch
                cmd.CommandText = ("SELECT TOP 10 * FROM tb_bookdetails ORDER BY ID DESC")
        End Select

        cmd.Connection = con
        Connect()

        Dim dt_bookReconds As New DataTable
        dt_bookReconds.Columns.Add("BookID", GetType(Integer))
        dt_bookReconds.Columns.Add("BookISBN", GetType(Integer))
        dt_bookReconds.Columns.Add("BookTitle", GetType(String))
        dt_bookReconds.Columns.Add("BookAuthor", GetType(String))
        dt_bookReconds.Columns.Add("BookPublisher", GetType(String))
        dt_bookReconds.Columns.Add("BookCondition", GetType(String))
        dt_bookReconds.Columns.Add("BookCopies", GetType(Integer))
        dt_bookReconds.Columns.Add("BookImage", GetType(String))

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                dt_bookReconds.Rows.Add(reader("ID"), reader("ISBN"), reader("BookTitle"), reader("Author"), reader("Publisher"), reader("BookCondition"), reader("Copies"), reader("ImagePath"))
            End While
        End If
        reader.Close()
        reader = Nothing
        cmd.Parameters.Clear()
        cmd.Dispose()
        DisConnect()

        Return dt_bookReconds
    End Function

    Public Shared Function IsStudentExist() As BorrowerInfo
        cmd = New OleDbCommand("SELECT * FROM tb_borrowers WHERE BR_SchoolID = @id")
        cmd.Connection = con
        Connect()
        cmd.Parameters.AddWithValue("@id", _BorrowerInfo.BorrowerID)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            _BorrowerInfo.ID = reader("ID")
            _BorrowerInfo.BorrowerID = reader("BR_SchoolID")
            _BorrowerInfo.BorrowerName = reader("BR_FullName")
            _BorrowerInfo.BorrowerLevel = reader("BR_Level")
        End If
        reader.Close()
        reader = Nothing
        cmd.Parameters.Clear()
        cmd.Dispose()
        DisConnect()
        Return _BorrowerInfo
    End Function
End Class
