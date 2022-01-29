Imports System.Data.OleDb

Public Class Create
    Inherits DataConfig


    'Public Shared Function insertBorrowBook(ByRef bookId As Integer, ByRef As studentId As Integer) As Boolean

    'End Function

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
End Class
