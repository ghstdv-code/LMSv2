Public Class Functions
    Inherits DataConfig

    Shared Function IsBookAvailable(isbn As Integer ) As Boolean
        _Book = New Book(isbn)
        Using newbook = Read.FindBook
            If _Book.Copies > 0 Then
                Return True
            End If
        End Using
        _Book.Dispose()
        Return False
    End Function

    Shared Function VerifyAdd(ByRef isbn As Integer) As Boolean
        _Book = New Book(isbn)
        Using newbook = Read.FindBook
            If Not (String.IsNullOrEmpty(_Book.BookTitle)) Then
                Dim item As New grid_item_transact() With {
                .BookISBN = newbook.ISBN,
                .BookName = newbook.BookTitle,
                .BookAuthor = newbook.BookAuthor,
                .BookPublisher = newbook.BookPublisher,
                .BookUID = newbook.Id}
                AddTransact.item_container.Controls.Add(item)
                AddTransact.idlist.Add(newbook.Id)
                AddTransact._copies.Add(newbook.Copies)
                Return True
            End If
        End Using
        _Book.Dispose()
        Return False
    End Function

    Shared Sub IsExist(id As String)
        _BorrowerInfo = New BorrowerInfo(id)
        Dim binfo = Read.IsStudentExist
        If (String.IsNullOrEmpty(binfo.BorrowerName) Or String.IsNullOrWhiteSpace(binfo.BorrowerName)) Then
            _BorrowerInfo.BorrowerID = AddTransact.tb_School_Id.Text
            _BorrowerInfo.BorrowerName = AddTransact.tb_Name.Text
            _BorrowerInfo.BorrowerLevel = AddTransact.cb_level.Text
            Create.AddStudent()
        Else
            AddTransact.tb_Name.Text = binfo.BorrowerName
            AddTransact.cb_level.Text = binfo.BorrowerLevel
        End If
        _BorrowerInfo.Dispose()
    End Sub

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

    Shared Function ABorrowBook() As Boolean
        If Create.BorrowBook Then
            _Borrower.Dispose()
            Return True
        End If
        Return False
    End Function

    Shared Function AStudentk() As Boolean
        If Create.AddStudent Then
            _Borrower.Dispose()
            Return True
        End If
        Return False
    End Function
End Class
