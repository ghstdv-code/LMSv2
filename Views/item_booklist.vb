Public Class item_booklist
    Private _bookname As String
    Private _bookisbn As Integer
    Private _bookauthor As String
    Private _bookpubliher As String
    Private _bookcopies As Integer
    Private _bookcondition As String
    Private _bookID As Integer

    Public WriteOnly Property SetId As Integer
        Set(value As Integer)
            _bookID = value
        End Set
    End Property

    Public Property BookName As String
        Get
            BookName = _bookname
        End Get
        Set(value As String)
            lb_bookname.Text = value
        End Set
    End Property

    Public Property BookISBN As Integer
        Get
            BookISBN = _bookisbn
        End Get
        Set(value As Integer)
            _bookisbn = value
            lb_isbn.Text = Convert.ToString(value)
        End Set
    End Property

    Public Property BookAuthor As String
        Get
            BookAuthor = _bookauthor
        End Get
        Set(value As String)
            lb_author.Text = value
        End Set
    End Property

    Public Property BookPublisher As String
        Get
            BookPublisher = _bookpubliher
        End Get
        Set(value As String)
            lb_publisher.Text = value
        End Set
    End Property
    Public Property BookCopies As Integer
        Get
            BookCopies = _bookcopies
        End Get
        Set(value As Integer)
            _bookcopies = value
            lb_copies.Text = Convert.ToString(value)
        End Set
    End Property

    Public Property BookCondition As String
        Get
            BookCondition = _bookcondition
        End Get
        Set(value As String)

            _bookcondition = value
            lb_condition.Text = value
        End Set
    End Property
End Class
