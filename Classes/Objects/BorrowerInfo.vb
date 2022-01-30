Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles

Public Class BorrowerInfo
    Implements IDisposable
    Public Property ID As Integer
    Public Property BorrowerID As String
    Public Property BorrowerName As String
    Public Property BorrowerLevel As String

    Public Sub New(id As Integer, b_id As String, b_name As String, b_level As String)
        Me.ID = id
        Me.BorrowerID = b_id
        Me.BorrowerName = b_name
        Me.BorrowerLevel = b_level
    End Sub

    Public Sub New(b_id As String)
        Me.BorrowerID = b_id
    End Sub

    Public Sub New()

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
