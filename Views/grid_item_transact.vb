Public Class grid_item_transact
    Private _bookname As String
    Private _bookisbn As Integer
    Private _bookauthor As String
    Private _bookpubliher As String

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

    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles bt_delete.Click
        Parent.Controls.Remove(Me)
        AddTransact.idlist.Remove(CStr(_bookisbn))
        AddTransact.lb_error.Visible = False
    End Sub
End Class
