
Imports System.Data.OleDb

Public Class Read
    Inherits DataConfig

    Enum Modes
        DirectSearch
        SimilarSearch
        GenericSearch
    End Enum

    Public Shared Function ViewBooksRecords() As DataTable
        cmd = New OleDbCommand("SELECT tb_borrow_transact.ID, tb_borrow_transact.bookid, tb_borrow_transact.studentid, tb_borrow_transact.releasedate,  tb_borrow_transact.duedate, tb_bookdetails.Copies, tb_bookdetails.ISBN, tb_bookdetails.BookCondition FROM tb_borrow_transact INNER JOIN tb_bookdetails ON tb_borrow_transact.bookid = tb_bookdetails.ID WHERE tb_borrow_transact.studentid = @scid AND tb_borrow_transact.remarks = @remarks")
        cmd.Connection = con
        Connect()
        cmd.Parameters.AddWithValue("@scid", _BorrowerInfo.BorrowerID)
        cmd.Parameters.AddWithValue("@remarks", "PENDING")

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

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                dt_bookReconds.Rows.Add(reader("ID"), reader("ISBN"), reader("BookTitle"), reader("Author"), reader("Publisher"), reader("BookCondition"), reader("Copies"))
            End While
        End If
        reader.Close()
        reader = Nothing
        cmd.Parameters.Clear()
        cmd.Dispose()
        DisConnect()
        '_Book.Dispose()
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
