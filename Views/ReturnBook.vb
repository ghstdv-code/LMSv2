Public Class ReturnBook
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Close()
    End Sub

    Private Sub bt_check_Click(sender As Object, e As EventArgs) Handles bt_check.Click
        If (String.IsNullOrEmpty(tb_studID.Text)) Then
            lb_error.Visible = True
            lb_error.Text = "Invalid Input!"
            lb_error.ForeColor = Color.Red
        Else
            item_container.Controls.Clear()
            If (Functions.AddReturnBookList()) Then
                'DO NOTHING
            Else
                lb_error.Visible = True
                lb_error.Text = "No Borrowed Books for this ID"
                lb_error.ForeColor = Color.Red
            End If
        End If
    End Sub

    Sub ResetForm()
        tb_studID.Clear()
        HideLabel()
        item_container.Controls.Clear()
    End Sub

    Sub HideLabel() Handles tb_studID.TextChanged
        lb_error.Visible = False
    End Sub

    Private Sub ReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.border.TargetControl = Me
        Me.shadow.TargetForm = Me
        ResetForm()
    End Sub
End Class