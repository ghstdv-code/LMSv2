Public Class Functions
    Inherits DataConfig

    Shared newbook As Book

    Shared Function VerifyAdd(ByRef isbn As Integer) As Boolean
        _Book = New Book(isbn)
        Using newbook = Read.FindBook
            If Not (String.IsNullOrEmpty(_Book.BookTitle)) Then
                Dim item As New grid_item_transact() With {
                .BookISBN = newbook.ISBN,
                .BookName = newbook.BookTitle,
                .BookAuthor = newbook.BookAuthor,
                .BookPublisher = newbook.BookPublisher}
                AddTransact.item_container.Controls.Add(item)
                Return True
            End If
        End Using
        _Book.Dispose()
        Return False
    End Function

    Shared Function BookExist(ByRef isbn As Integer) As Boolean
        _Book = New Book(isbn)
        Using newbook = Read.FindBook
            If Not String.IsNullOrEmpty(_Book.BookTitle) Then
                Return True
            End If
        End Using
        _Book.Dispose()
        Return False
    End Function

    Shared Function InsertBook() As Boolean
        If Create.addBook() Then
            _Book.Dispose()
            Return True
        End If
        Return False
    End Function
End Class
