Imports LMSv2.DataConfig
Imports Guna.UI2.WinForms

Public Class item_booklist
    Private _bookname As String
    Private _bookisbn As Integer
    Private _bookauthor As String
    Private _bookpubliher As String
    Private _bookcopies As Integer
    Private _bookcondition As String
    Private _ID As Integer
    Private _bookimgpath As String

    Public Property BookImgPath As String
        Get
            BookImgPath = _bookimgpath
        End Get
        Set(value As String)
            _bookimgpath = value
        End Set
    End Property

    Public WriteOnly Property ID As Integer
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property BookName As String
        Get
            BookName = _bookname
        End Get
        Set(value As String)
            _bookname = value
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
            _bookauthor = value
            lb_author.Text = value
        End Set
    End Property

    Public Property BookPublisher As String
        Get
            BookPublisher = _bookpubliher
        End Get
        Set(value As String)
            _bookpubliher = value
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
            Select Case value
                Case "Fine (F)"
                Case "Near Fine (NF)"
                    lb_condition.BackColor = Color.FromArgb(1, 162, 153)
                Case "Very Good (VG)"
                Case "Good (G)"
                    lb_condition.BackColor = Color.CornflowerBlue
                Case "Fair (FR)"
                Case "Poor (P)"
                    lb_condition.BackColor = Color.FromArgb(176, 0, 32)
            End Select
            _bookcondition = value
            lb_condition.Text = value
        End Set
    End Property

    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles bt_delete.Click
        MainView.mbx.Icon = MessageDialogIcon.Warning
        MainView.mbx.Buttons = MessageDialogButtons.YesNo
        MainView.mbx.Caption = "Warning"
        MainView.mbx.Text = "Are you sure you want to remove this book?"
        If MainView.mbx.Show() = DialogResult.Yes Then

            _Book = New Book With {.Id = _ID}
            Parent.Controls.Remove(Me)
            Delete.DeleteBook()
            If _bookimgpath <> "NotAvailable" Then
                BookForm.Dispose()
                GC.Collect()
                GC.WaitForPendingFinalizers()
                My.Computer.FileSystem.DeleteFile(AppDomain.CurrentDomain.BaseDirectory & _bookimgpath)
            End If
        End If
    End Sub

    Private Sub bt_view_Click(sender As Object, e As EventArgs) Handles bt_view.Click
        _Book = New Book With {
            .Id = _ID,
            .ISBN = _bookisbn,
            .BookTitle = _bookname,
            .BookAuthor = _bookauthor,
            .BookPublisher = _bookpubliher,
            .Copies = _bookcopies,
            .Condition = _bookcondition,
            .StringPath = _bookimgpath}
        Dim bookform As New BookForm With {.SetTitle = "Manage Book Details", .SetMode = BookForm.Modes.Update, .SetID = _ID}
        bookform.ShowDialog()
    End Sub
End Class
