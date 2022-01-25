
Imports System.Data.OleDb

Public Class DataConfig
    Protected Shared ReadOnly con As OleDbConnection = New OleDbConnection($"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={Application.StartupPath}\lms_db.mdb")
    Shared Function Connect() As Boolean
        Try
            con.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Shared Function DisConnect() As Boolean
        Try
            con.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return False
    End Function
End Class
