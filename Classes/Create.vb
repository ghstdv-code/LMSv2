Imports System.Data.OleDb

Public Class Create
    Inherits DataConfig


    Public Shared Function addBook() As Boolean
        cmd = New OleDbCommand("INSERT INTO tb_bookdetails (ISBN, BookTitle, Publisher, Copies, BookCondition, Author, ImagePath) VALUES (@isbn, @booktitle, @publisher, @copies, @bookcondition, @author, @imagepath)")
        cmd.Connection = con
        Connect()

        '@isbn, @booktitle, @publisher, @copies, @bookcondition, @author, @imagepath)
        cmd.Parameters.AddWithValue("@isbn", _Book.ISBN)
        cmd.Parameters.AddWithValue("@booktitle", _Book.BookTitle)
        cmd.Parameters.AddWithValue("@publisher", _Book.BookPublisher)
        cmd.Parameters.AddWithValue("@copies", _Book.Copies)
        cmd.Parameters.AddWithValue("@bookcondition", _Book.Condition)
        cmd.Parameters.AddWithValue("@author", _Book.BookAuthor)
        cmd.Parameters.AddWithValue("@imagepath", _Book.StringPath)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        DisConnect()
        cmd.Parameters.Clear()
        cmd.Dispose()
        Return False
    End Function

    Public Shared Function BorrowBook() As Boolean
        cmd = New OleDbCommand("INSERT INTO tb_borrow_transact (bookid, studentid, staffid, releasedate, duedate, remarks) VALUES (@id, @studid, @staffid, @releasedate, @duedate, @remarks)")
        cmd.Connection = con
        Connect()

        '@id, @studid, @staffid, @releasedate, @duedate, @remarks, @borrowername
        cmd.Parameters.AddWithValue("@id", _Borrower.BookId)
        cmd.Parameters.AddWithValue("@studid", _Borrower.BorrowerId)
        cmd.Parameters.AddWithValue("@staffid", _Borrower.StaffId)
        cmd.Parameters.AddWithValue("@releasedate", _Borrower.IssueDate)
        cmd.Parameters.AddWithValue("@duedate", _Borrower.DueDate)
        cmd.Parameters.AddWithValue("@remarks", _Borrower.Remarks)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        DisConnect()
        cmd.Parameters.Clear()
        cmd.Dispose()
        Return False
    End Function

    Public Shared Function AddStudent() As Boolean
        cmd = New OleDbCommand("INSERT INTO tb_borrowers (BR_SchoolID, BR_FullName, BR_Level) VALUES (@schoolid, @fullname, @level)")
        cmd.Connection = con
        Connect()

        '@id, @studid, @staffid, @releasedate, @duedate, @remarks, @borrowername
        cmd.Parameters.AddWithValue("@schoolid", _BorrowerInfo.BorrowerID)
        cmd.Parameters.AddWithValue("@fullname", _BorrowerInfo.BorrowerName)
        cmd.Parameters.AddWithValue("@level", _BorrowerInfo.BorrowerLevel)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

        DisConnect()
        cmd.Parameters.Clear()
        cmd.Dispose()
        Return False
    End Function
End Class
