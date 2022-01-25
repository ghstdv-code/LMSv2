Public Class Book
    Public Property Id As Integer
    Public Property ISBN As Integer
    Public Property BookTitle As String
    Public Property BookAuthor As String
    Public Property BookPublisher As String
    Public Property Copies As Integer
    Public Property Condition As String

    Public Sub New(ByRef id As Integer, ByRef isbn As Integer, ByRef booktitle As String, ByRef bookauthor As String, ByRef bookpublisher As String, ByRef copies As Integer, ByRef condition As String)
        Me.Id = id
        Me.ISBN = isbn
        Me.BookTitle = booktitle
        Me.BookAuthor = bookauthor
        Me.BookPublisher = bookpublisher
        Me.Copies = copies
        Me.Condition = condition
    End Sub

    Public Sub New(ByRef isbn As Integer)
        Me.ISBN = isbn
    End Sub

    Public Sub New()
        'default constructor
    End Sub
End Class
