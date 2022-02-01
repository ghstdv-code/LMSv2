Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles

Public Class UserInfo
    Implements IDisposable
    Public Property ID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Occupation As String
    Public Property Contact As String
    Public Property Gender As String

    Public Sub New(ByRef id As Integer, ByRef fname As String, ByRef lname As String, ByRef occupation As String, ByRef contact As String, ByRef gender As String)
        Me.ID = id
        Me.FirstName = fname
        Me.LastName = lname
        Me.Occupation = occupation
        Me.Contact = contact
        Me.Gender = gender
    End Sub

    Public Sub New(ByRef id As Integer)
        Me.ID = id
    End Sub

    Public Sub New()
        'Do not touch
    End Sub

    Public Sub New(ByRef fname As String, ByRef lname As String)
        Me.FirstName = fname
        Me.LastName = lname
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
