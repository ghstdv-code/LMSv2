Imports System.Data.OleDb

Public Class Updates
    Inherits DataConfig

    Public Shared Function UpdateCopies(mode As String, id As Integer, copies As Integer) As Boolean
        Dim i As Integer
        cmd = New OleDbCommand()
        cmd.CommandText = "UPDATE tb_bookdetails SET Copies = @copies WHERE ID = @id"
        cmd.Connection = con
        Connect()
        Select Case mode
            Case "Borrow"
                i = -1
            Case "Return"
                i = 1
        End Select

        cmd.Parameters.AddWithValue("@copies", copies + i)
        cmd.Parameters.AddWithValue("@id", id)

        Try
            cmd.ExecuteNonQuery()
        Catch

        End Try
        DisConnect()
        cmd.Parameters.Clear()
        cmd.Dispose()
        Return True
    End Function
End Class
