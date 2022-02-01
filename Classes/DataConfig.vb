Imports System.Data.OleDb

Public Class DataConfig

    Public Shared cmd As OleDbCommand
    Public Shared reader As OleDbDataReader
    Public Shared _User As User
    Public Shared _Book As Book
    Public Shared _Borrower As Borrower
    Public Shared _BorrowerInfo As BorrowerInfo
    Public Shared _UserInfo As UserInfo
    Protected Shared ReadOnly con As OleDbConnection = New OleDbConnection($"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\lms_db.mdb")
    Shared Function Connect() As Boolean
        Try
            con.Open()
            Return True
        Catch
        End Try
        Return False
    End Function

    Shared Function DisConnect() As Boolean
        Try
            con.Close()
            Return True
        Catch
        End Try
        Return False
    End Function
End Class
