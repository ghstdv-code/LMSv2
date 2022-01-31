Imports System.Data.OleDb

Public Class Updates
    Inherits DataConfig

    Public Shared Function UpdateBorrower() As Boolean
        cmd = New OleDbCommand()
        cmd.Connection = con
        Connect()

        cmd.CommandText = "UPDATE tb_borrowers SET BR_FullName = @name, BR_SchoolID = @schid, BR_Level = @level WHERE ID = @id"
        cmd.Parameters.AddWithValue("@name", _BorrowerInfo.BorrowerName)
        cmd.Parameters.AddWithValue("@schid", _BorrowerInfo.BorrowerID)
        cmd.Parameters.AddWithValue("@level", _BorrowerInfo.BorrowerLevel)
        cmd.Parameters.AddWithValue("@id", _BorrowerInfo.ID)
        cmd.ExecuteNonQuery()

        cmd.Parameters.Clear()
        cmd.Dispose()
        _BorrowerInfo.Dispose()
        DisConnect()

        Return True
    End Function

    Public Shared Function UpdateBookInfo() As Boolean
        cmd = New OleDbCommand()
        cmd.Connection = con
        Connect()

        cmd.CommandText = "UPDATE tb_bookdetails SET ISBN = @isbn, BookTitle = @title, Publisher = @publisher, Copies = @copies, BookCondition = @bcondition, Author =@author, ImagePath = @path WHERE ID = @id"
        cmd.Parameters.AddWithValue("@isbn", _Book.ISBN)
        cmd.Parameters.AddWithValue("@title", _Book.BookTitle)
        cmd.Parameters.AddWithValue("@publisher", _Book.BookPublisher)
        cmd.Parameters.AddWithValue("@copies", _Book.Copies)
        cmd.Parameters.AddWithValue("@bcondition", _Book.Condition)
        cmd.Parameters.AddWithValue("@author", _Book.BookAuthor)
        cmd.Parameters.AddWithValue("@path", _Book.StringPath)
        cmd.Parameters.AddWithValue("@id", _Book.Id)
        cmd.ExecuteNonQuery()

        cmd.Parameters.Clear()
        cmd.Dispose()
        _Book.Dispose()
        DisConnect()
        Return True
    End Function
    Public Shared Function ReturnBook() As Boolean
        cmd = New OleDbCommand()
        cmd.Connection = con
        Connect()

        cmd.CommandText = "UPDATE tb_bookdetails SET Copies = @copies, BookCondition = @bcondition WHERE ID = @id"
        cmd.Parameters.AddWithValue("@copies", _Book.Copies + 1)
        cmd.Parameters.AddWithValue("@bcondition", _Book.Condition)
        cmd.Parameters.AddWithValue("@id", _Book.Id)
        cmd.ExecuteNonQuery()

        cmd.Parameters.Clear()
        cmd.CommandText = "UPDATE tb_borrow_transact SET remarks = @remarks WHERE ID = @id"
        cmd.Parameters.AddWithValue("@remarks", _Borrower.Remarks)
        cmd.Parameters.AddWithValue("@id", _Borrower.TransactId)
        cmd.ExecuteNonQuery()

        cmd.Parameters.Clear()
        cmd.Dispose()
        _Borrower.Dispose()
        _Book.Dispose()
        Return True
    End Function

    Public Shared Function UpdateCopies(mode As String, id As Integer, copies As Integer) As Boolean
        Dim i As Integer
        cmd = New OleDbCommand()
        cmd.CommandText = "UPDATE tb_bookdetails SET Copies = @copies WHERE ID = @id"
        cmd.Connection = con
        Connect()
        Select Case mode
            Case "Borrow"
                i = -1
            Case "Return"
                i = 1
        End Select

        cmd.Parameters.AddWithValue("@copies", copies + i)
        cmd.Parameters.AddWithValue("@id", id)

        Try
            cmd.ExecuteNonQuery()
        Catch

        End Try
        DisConnect()
        cmd.Parameters.Clear()
        cmd.Dispose()
        Return True
    End Function
End Class
