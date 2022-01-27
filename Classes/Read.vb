
Imports System.Data.OleDb

Public Class Read
    Inherits DataConfig

    Shared cmd As OleDbCommand
    Shared reader As OleDbDataReader
    Public Shared _User As User
    Public Shared _Book As Book

    'Public Shared Function FindUser() As User
    '    cmd = New MySqlCommand("SELECT * FROM `tb_user` WHERE username=@user && password=@pass")
    '    cmd.Connection = con

    '    cmd.Parameters.AddWithValue("@user", _User.Username)
    '    cmd.Parameters.AddWithValue("@pass", _User.Password)
    '    Dim reader As MySqlDataReader = cmd.ExecuteReader()

    '    If reader.HasRows Then
    '        reader.Read()
    '        _User.Id = reader("id")
    '        _User.Role = reader("role")
    '    Else
    '        Login.dialog.Text = "Username or Password Incorrect!!"
    '        Login.dialog.Show()
    '        Login.tb_user.Select()
    '    End If

    '    reader.Close()
    '    cmd.Parameters.Clear()

    '    Return _User
    'End Function


    Public Shared Function FindBook() As Book
        cmd = New OleDbCommand("SELECT * FROM tb_bookdetails WHERE ISBN = @isbn")
        cmd.Connection = con
        Connect()
        cmd.Parameters.AddWithValue("@isbn", _Book.ISBN)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            _Book.Id = reader("id")
            _Book.ISBN = reader("ISBN")
            _Book.BookTitle = reader("BookTitle")
            _Book.BookAuthor = reader("Author")
            _Book.BookPublisher = reader("Publisher")
            _Book.Condition = reader("BookCondition")
            _Book.Copies = reader("Copies")
        End If
        reader.Close()
        reader = Nothing
        cmd.Parameters.Clear()
        cmd.Dispose()
        DisConnect()
        Return _Book
    End Function

    Public Shared Function ClassesList() As List(Of String)
        Dim classlist As New List(Of String)

        cmd = New OleDbCommand("SELECT * FROM tb_classes")
        cmd.Connection = con
        Connect()

        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            While reader.Read()
                classlist.Add(reader("Classes"))
            End While
        End If
        reader.Close()
        cmd.Parameters.Clear()
        cmd.Dispose()
        DisConnect()

        Return classlist
    End Function
End Class
