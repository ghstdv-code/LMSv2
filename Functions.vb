Public Class Functions
    Inherits DataConfig

    Shared Function DisplayBorrower(_container As Panel, _mode As Read.Modes) As Boolean
        Dim dt As New DataTable
        Select Case _mode
            Case Read.Modes.DirectSearch
                dt = Read.ViewBorrower(Read.Modes.DirectSearch)
            Case Read.Modes.SimilarSearch
                dt = Read.ViewBorrower(Read.Modes.SimilarSearch)
            Case Read.Modes.GenericSearch
                dt = Read.ViewBorrower(Read.Modes.GenericSearch)
        End Select

        For i As SByte = 0 To dt.Rows.Count - 1 Step 1
            Dim itm As New borroweritems With {
                .BID = dt.Rows(i).Item("ID"),
                .BSCHID = dt.Rows(i).Item("SCHID"),
                .BName = dt.Rows(i).Item("Name"),
                .BLevel = dt.Rows(i).Item("Level")}
            _container.Controls.Add(itm)
        Next
        Return True
    End Function

    Shared Function DisplayBook(_container As Panel, _mode As Read.Modes) As Boolean
        Dim dt_book As new DataTable
        Select Case _mode
            Case Read.Modes.DirectSearch
                dt_book = Read.FindBook(Read.Modes.DirectSearch)
            Case Read.Modes.SimilarSearch
                dt_book = Read.FindBook(Read.Modes.SimilarSearch)
            Case Read.Modes.GenericSearch
                dt_book = Read.FindBook(Read.Modes.GenericSearch)
        End Select

        For i As SByte = 0 To dt_book.Rows.Count - 1 Step 1
            Dim item As New item_booklist With {
                .ID = dt_book.Rows(i).Item("BookID"),
                .BookISBN = dt_book.Rows(i).Item("BookISBN"),
                .BookName = dt_book.Rows(i).Item("BookTitle"),
                .BookAuthor = dt_book.Rows(i).Item("BookAuthor"),
                .BookPublisher = dt_book.Rows(i).Item("BookPublisher"),
                .BookCondition = dt_book.Rows(i).Item("BookCondition"),
                .BookCopies = dt_book.Rows(i).Item("BookCopies"),
                .BookImgPath = dt_book.Rows(i).Item("BookImage")}
            _container.Controls.Add(item)
        Next
        dt_book.Dispose()
        Return False
    End Function

    Shared Function AddReturnBookList() As Boolean
        _BorrowerInfo = New BorrowerInfo(ReturnBook.tb_studID.Text)
        Dim r_borrower = Read.IsStudentExist
        If Not (String.IsNullOrEmpty(r_borrower.BorrowerName) Or String.IsNullOrWhiteSpace(r_borrower.BorrowerName)) Then
            Dim dt = Read.ViewBooksRecords
            For i As SByte = 0 To dt.Rows.Count - 1 Step 1
                Dim item As New rt_grid_item With {
                   .BookID = dt.Rows(i).Item("BookID"),
                   .TransactID = dt.Rows(i).Item("TransactID"),
                   .BookISBN = dt.Rows(i).Item("BookISBN"),
                   .BookCopies = dt.Rows(i).Item("BookCopies"),
                   .BookCondition = dt.Rows(i).Item("BookCondition"),
                   .IssueDate = dt.Rows(i).Item("IssuedDate"),
                   .DueDate = dt.Rows(i).Item("DueDate")
                }
                ReturnBook.item_container.Controls.Add(item)
            Next
            dt.Dispose()
            Return True
        End If
        _BorrowerInfo.Dispose()
        Return False
    End Function

    Shared Function IsBookAvailable(isbn As Integer ) As Boolean
        _Book = New Book(isbn)
        Using newbook = Read.FindBook(Read.Modes.DirectSearch)
            If newbook.Rows(0).Item("BookCopies") > 0 Then
                Return True
            End If
        End Using
        _Book.Dispose()
        Return False
    End Function

    Shared Function VerifyAdd(ByRef isbn As Integer) As Boolean
        _Book = New Book(isbn)
        Using dt_book = Read.FindBook(Read.Modes.DirectSearch)
            If dt_book.Rows.Count > 0 Then
                For i As SByte = 0 To dt_book.Rows.Count - 1 Step 1
                    Dim item As New grid_item_transact() With {
                    .BookISBN = dt_book.Rows(i).Item("BookISBN"),
                    .BookName = dt_book.Rows(i).Item("BookTitle"),
                    .BookAuthor = dt_book.Rows(i).Item("BookAuthor"),
                    .BookPublisher = dt_book.Rows(i).Item("BookPublisher"),
                    .BookUID = dt_book.Rows(i).Item("BookID")}
                    AddTransact.item_container.Controls.Add(item)
                    AddTransact.idlist.Add(dt_book.Rows(i).Item("BookID"))
                    AddTransact._copies.Add(dt_book.Rows(i).Item("BookCopies"))
                Next
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
        Using newbook = Read.FindBook(Read.Modes.DirectSearch)
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

    Shared Function AddBookToList(id As String) As Boolean
        If Not (String.IsNullOrEmpty(id) Or String.IsNullOrWhiteSpace(id)) Then
            MsgBox(IsBookAvailable(CInt(id)).ToString())
            If IsBookAvailable(CInt(id)) Then
                Dim record = From t_record In AddTransact._isbn Where t_record = id
                If Not record.Any Then
                    If (VerifyAdd(CInt(id))) Then
                        AddTransact._isbn.Add(id)
                    Else
                        AddTransact.lb_error.Visible = True
                        AddTransact.lb_error.Text = "Status: Book Not Found!!"
                        AddTransact.lb_error.ForeColor = Color.Red
                    End If
                Else
                    AddTransact.lb_error.Visible = True
                    AddTransact.lb_error.Text = "Status: Book Already Exist!!"
                    AddTransact.lb_error.ForeColor = Color.Red
                End If
            Else
                AddTransact.lb_error.Visible = True
                AddTransact.lb_error.Text = "Status: Out of stock"
                AddTransact.lb_error.ForeColor = Color.Red
            End If
        Else
            AddTransact.lb_error.Visible = True
            AddTransact.lb_error.Text = "Status: No Input Detected!!"
            AddTransact.lb_error.ForeColor = Color.Red
        End If
        Return True
    End Function

    Shared Sub SaveBorrow(schoolid As String)
        IsExist(schoolid)
        Dim borrower As New Borrower()
        For i As SByte = 0 To AddTransact.idlist.Count - 1 Step 1
            Updates.UpdateCopies("Borrow", AddTransact.idlist(i), AddTransact._copies(i))
            borrower.BorrowerID = schoolid
            borrower.BookId = CInt(AddTransact.idlist(i))
            borrower.StaffId = 1
            borrower.IssueDate = CDate(Date.Now.ToString("dd/MM/yyyy"))
            borrower.DueDate = CDate(AddTransact.dtp_dueDate.Value.ToString("dd/MM/yyyy"))
            borrower.Remarks = "PENDING"
            _Borrower = borrower
        Next
    End Sub
End Class
