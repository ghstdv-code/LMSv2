Public Class Borrower
    Public Property BookId As Integer
    Public Property BorrowerId As Integer
    Public Property StaffId As Integer
    Public Property IssueDate As Date
    Public Property DueDate As Date

    Public Sub New(ByRef bookid As Integer, ByRef borrowerid As Integer, ByRef staffid As Integer, ByRef issuedate As Date, ByRef duedate As Date)
        Me.BookId = bookid
        Me.BorrowerId = borrowerid
        Me.StaffId = staffid
        Me.IssueDate = issuedate
        Me.DueDate = duedate
    End Sub

    Public Sub New()
        'Default Constructor
    End Sub
End Class
