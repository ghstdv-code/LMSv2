Imports LMSv2.DataConfig

Public Class Functions
    Public Shared Function CheckBook(isbn As Integer) As Boolean
        Read._Book = New Book(isbn)
        Connect()
        Dim _book As Book = Read.FindBook
        DisConnect()
        If Not (String.IsNullOrEmpty(_book.BookTitle)) Then
            Dim item As New grid_item_transact
            item.BookISBN = _book.ISBN
            item.BookName = _book.BookTitle
            item.BookAuthor = _book.BookAuthor
            item.BookPublisher = _book.BookPublisher
            AddTransact.item_container.Controls.Add(item)
            Return True
        End If
        Return False
    End Function

End Class
