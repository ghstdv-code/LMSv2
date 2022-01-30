Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles

Public Class Book
    Implements IDisposable

    Public Property Id As Integer
    Public Property ISBN As Integer
    Public Property BookTitle As String
    Public Property BookAuthor As String
    Public Property BookPublisher As String
    Public Property Copies As Integer
    Public Property Condition As String
    Public Property StringPath As String

    Public Sub New(ByRef id As Integer, ByRef isbn As Integer, ByRef booktitle As String, ByRef bookauthor As String, ByRef bookpublisher As String, ByRef copies As Integer, ByRef condition As String, ByRef stringpath As String)
        Me.Id = id
        Me.ISBN = isbn
        Me.BookTitle = booktitle
        Me.BookAuthor = bookauthor
        Me.BookPublisher = bookpublisher
        Me.Copies = copies
        Me.Condition = condition
        Me.StringPath = stringpath
    End Sub

    Public Sub New(ByRef isbn As Integer, ByRef booktitle As String, ByRef bookauthor As String, ByRef bookpublisher As String, ByRef copies As Integer, ByRef condition As String, ByRef stringpath As String)
        Me.ISBN = isbn
        Me.BookTitle = booktitle
        Me.BookAuthor = bookauthor
        Me.BookPublisher = bookpublisher
        Me.Copies = copies
        Me.Condition = condition
        Me.StringPath = stringpath
    End Sub

    Public Sub New(ByRef isbn As Integer)
        Me.ISBN = isbn
    End Sub

    Public Sub New(ByRef copies As Integer, ByRef condition As String, ByRef id As Integer)
        Me.Id = id
        Me.Copies = copies
        Me.Condition = condition
    End Sub

    Public Sub New()
        'default constructor
    End Sub
#Region "TagaSira"
    Private _disposedValue As Boolean
    ' Instantiate a SafeHandle instance.
    Private _safeHandle As SafeHandle = New SafeFileHandle(IntPtr.Zero, True)

    ' Public implementation of Dispose pattern callable by consumers.
    Public Sub Dispose()
        Dispose(True)
    End Sub

    ' Protected implementation of Dispose pattern.
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not _disposedValue Then
            If disposing Then
                _safeHandle.Dispose()
            End If

            _disposedValue = True
        End If
    End Sub

    Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
        DirectCast(_safeHandle, IDisposable).Dispose()
    End Sub
#End Region

End Class
