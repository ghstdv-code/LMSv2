Public Class User
    Inherits UserInfo
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

    Public Sub New(ByRef id As Integer, ByRef fname As String, ByRef lname As String, ByRef occupation As String, ByRef contact As String, ByRef gender As String, ByRef uname As String, ByRef passw As String, ByRef role As String)
        Me.ID = id
        Me.FirstName = fname
        Me.LastName = lname
        Me.Occupation = occupation
        Me.Contact = contact
        Me.Gender = gender
        Me.Username = uname
        Me.Password = passw
        Me.Role = role
    End Sub

    Public Sub New()
        'default constructor
    End Sub
End Class
