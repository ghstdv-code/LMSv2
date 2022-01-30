
Imports System.Data.OleDb

Public Class Read
    Inherits DataConfig


    'Public Shared Function FindUser() As User
    '    cmd = New MySqlCommand("SELECT * FROM `tb_user` WHERE username=@user && password=@pass")
    '    cmd.Connection = con

    '    cmd.Parameters.AddWithValue("@user", _User.Username)
    '    cmd.Parameters.AddWithValue("@pass", _User.Password)
    '    Dim reader As MySqlDataReader = cmd.ExecuteReader()

    '    If reader.HasRows Then
    '        reader.Read()
    '        _User.Id = sreader("id")
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
            _Book.Id = reader("ID")
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

    Public Shared Function IsStudentExist() As BorrowerInfo
        cmd = New OleDbCommand("SELECT * FROM tb_borrowers WHERE BR_SchoolID = @id")
        cmd.Connection = con
        Connect()
        cmd.Parameters.AddWithValue("@id", _BorrowerInfo.BorrowerID)
        reader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            _BorrowerInfo.ID = reader("ID")
            _BorrowerInfo.BorrowerID = reader("BR_SchoolID")
            _BorrowerInfo.BorrowerName = reader("BR_FullName")
            _BorrowerInfo.BorrowerLevel = reader("BR_Level")
        End If
        reader.Close()
        reader = Nothing
        cmd.Parameters.Clear()
        cmd.Dispose()
        DisConnect()
        Return _BorrowerInfo
    End Function
End Class
