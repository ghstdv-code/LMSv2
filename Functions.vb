Public Class Functions
    Shared Function VerifyAdd(ByRef isbn As Integer) As Boolean
        Read._Book = New Book(isbn)
        Dim _book As Book = Read.FindBook
        If Not (String.IsNullOrEmpty(_book.BookTitle)) Then
            Dim item As New grid_item_transact() With {
            .BookISBN = _book.ISBN,
            .BookName = _book.BookTitle,
            .BookAuthor = _book.BookAuthor,
            .BookPublisher = _book.BookPublisher}
            AddTransact.item_container.Controls.Add(item)
            Return True
        End If
        Return False
    End Function
End Class
