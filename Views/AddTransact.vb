Imports System.Text.RegularExpressions
Imports LMSv2.Functions


Public Class AddTransact

    Public idlist As New List(Of String)
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub

    Private Sub AddTransact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reset()
    End Sub

    Private Sub bt_check_Click(sender As Object, e As EventArgs) Handles bt_check.Click
        If Not (String.IsNullOrEmpty(tb_id.Text) Or String.IsNullOrWhiteSpace(tb_id.Text)) Then
            Dim record = From t_record In idlist Where t_record = tb_id.Text
            If Not record.Any Then
                If (VerifyAdd(CInt(tb_id.Text))) Then
                    idlist.Add(tb_id.Text)
                Else
                    Me.lb_error.Visible = True
                    Me.lb_error.Text = "Status: Book Not Found!!"
                End If
            Else
                Me.lb_error.Visible = True
                Me.lb_error.Text = "Status: Book Already Exist!!"
            End If
        End If
    End Sub

    Private Sub tb_textchanged(sender As Object, e As EventArgs) Handles tb_id.TextChanged
        lb_error.Visible = False
    End Sub

    Sub Reset()
        idlist.Clear()
        tb_id.Clear()
        tb_user.Clear()
        tb_sid.Clear()
        'cb_level.SelectedIndex = 0
        lb_error.Visible = False
    End Sub
End Class