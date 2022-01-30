Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles

Public Class Borrower
    Inherits BorrowerInfo
    Implements IDisposable
    Public Property TransactId As Integer
    Public Property BookId As Integer
    Public Property StaffId As Integer
    Public Property IssueDate As Date
    Public Property DueDate As Date
    Public Property Remarks As String

    Public Sub New(ByRef bookid As Integer, ByRef borrowerid As String, ByRef staffid As Integer, ByRef issuedate As Date, ByRef duedate As Date, ByRef remarks As String, ByRef borrowername As String, ByRef level As String)
        Me.BookId = bookid
        Me.BorrowerID = borrowerid
        Me.StaffId = staffid
        Me.IssueDate = issuedate
        Me.DueDate = duedate
        Me.Remarks = remarks
        Me.BorrowerName = borrowername
        Me.BorrowerLevel = level
    End Sub

    Public Sub New(ByRef transactis As Integer)
        TransactId = transactis
    End Sub

    Public Sub New(ByRef transactis As Integer, ByRef remarks As String)
        Me.Remarks = remarks
        TransactId = transactis
    End Sub

    Public Sub New()
        'Default Constructor
    End Sub


End Class
