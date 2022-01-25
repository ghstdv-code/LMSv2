Imports LMSv2


Public Class AddTransact

    Dim _book As Book
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub



    Private Sub AddTransact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_check_Click(sender As Object, e As EventArgs) Handles bt_check.Click
        If Not (String.IsNullOrEmpty(tb_id.Text) Or String.IsNullOrWhiteSpace(tb_id.Text)) Then
            If Not Functions.CheckBook(Convert.ToInt32(tb_id.Text)) Then
                mbox.Caption = "Error"
                mbox.Text = "Book Not Found"
                mbox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
                mbox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
                mbox.Show()
            End If
        End If
    End Sub

    Function ParseValues() As Boolean
        Read._Book = New Book()
        _book = Read.FindBook()
        If Not (_book Is Nothing) Then
            Return True
        End If
        Return False
    End Function
End Class