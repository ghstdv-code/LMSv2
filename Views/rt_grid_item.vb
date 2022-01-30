Public Class rt_grid_item
    Private _bookCondition As String
    Private _bookisbn As Integer
    Private _issuedate As String
    Private _duedate As String
    Private _transactid As Integer
    Private _bookId As Integer
    Private _bookcopies As Integer

    Public WriteOnly Property BookCopies As Integer
        Set(value As Integer)
            _bookcopies = value
        End Set
    End Property

    Public WriteOnly Property BookID As Integer
        Set(value As Integer)
            _bookId = value
        End Set
    End Property

    Public WriteOnly Property TransactID As Integer
        Set(value As Integer)
            _transactid = value
        End Set
    End Property

    Public Property BookCondition As String
        Get
            BookCondition = _bookCondition
        End Get
        Set(value As String)
            _bookCondition = value
            cb_level.Text = value
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

    Public Property IssueDate As String
        Get
            IssueDate = _issuedate
        End Get
        Set(value As String)
            _issuedate = value
            lb_issued.Text = value
        End Set
    End Property

    Public Property DueDate As String
        Get
            DueDate = _duedate
        End Get
        Set(value As String)
            If CDate(value) <= Date.UtcNow Then
                lb_duedate.ForeColor = Color.Red
            End If
            _duedate = value
            lb_duedate.Text = value
        End Set
    End Property

    Private Sub bt_return_Click(sender As Object, e As EventArgs) Handles bt_return.Click
        DataConfig._Book = New Book(_bookcopies, _bookCondition, _bookId)
        DataConfig._Borrower = New Borrower(_transactid, "RETURNED")
        If Updates.ReturnBook() Then
            Parent.Controls.Remove(Me)
        End If
    End Sub
End Class
