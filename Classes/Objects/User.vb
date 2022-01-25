Public Class User
    Public Property Id As Integer
    Public Property Username As String
    Public Property Password As String
    Public Property Role As String

    Public Sub New(id As Integer, username As String, password As String, role As String)
        Me.Id = id
        Me.Username = username
        Me.Password = password
        Me.Role = role
    End Sub

    Public Sub New(username As String, password As String)
        Me.Username = username
        Me.Password = password
    End Sub

    Public Sub New()
        'default constructor
    End Sub
End Class
