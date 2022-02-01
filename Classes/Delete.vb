Imports System.Data.OleDb

Public Class Delete
    Inherits DataConfig

    Public Shared Function DeleteTransact() As Boolean
        cmd = New OleDbCommand("DELETE FROM tb_borrow_transact WHERE ID = @id")
        cmd.Parameters.AddWithValue("@id", _Borrower.TransactId)
        cmd.Connection = con
        Connect()
        cmd.ExecuteNonQuery()
        DisConnect()
        cmd.Parameters.Clear()
        cmd.Dispose()
        _Borrower.Dispose()
        Return True
    End Function

    Public Shared Function DeleteUser() As Boolean
        cmd = New OleDbCommand("DELETE FROM tb_account_info WHERE ID = @id")
        cmd.Parameters.AddWithValue("@id", _User.ID)
        cmd.Connection = con
        Connect()
        cmd.ExecuteNonQuery()
        DisConnect()
        cmd.Parameters.Clear()
        cmd.Dispose()
        _User.Dispose()
        Return True
    End Function

    Public Shared Function DeleteBook() As Boolean
        cmd = New OleDbCommand("DELETE FROM tb_bookdetails WHERE ID = @id")
        cmd.Parameters.AddWithValue("@id", _Book.Id)
        cmd.Connection = con
        Connect()
        cmd.ExecuteNonQuery()
        DisConnect()
        cmd.Parameters.Clear()
        cmd.Dispose()
        _Book.Dispose()
        Return True
    End Function

    Public Shared Function DeleteBorrower() As Boolean
        cmd = New OleDbCommand("DELETE FROM tb_borrowers WHERE ID = @id")
        cmd.Parameters.AddWithValue("@id", _BorrowerInfo.BorrowerID)
        cmd.Connection = con
        Connect()
        cmd.ExecuteNonQuery()
        DisConnect()
        cmd.Parameters.Clear()
        cmd.Dispose()
        _BorrowerInfo.Dispose()
        Return True
    End Function

End Class
