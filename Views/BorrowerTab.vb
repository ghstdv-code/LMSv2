Imports Guna.UI2.WinForms
Imports LMSv2.DataConfig

Public Class BorrowerTab

    Public Property br_id As Integer = -1

    Public Shared this_instance As BorrowerTab
    Public Shared ReadOnly Property Instance As BorrowerTab
        Get
            If IsNothing(this_instance) Then
                Dim borrowertab As New BorrowerTab()
                Return borrowertab
            End If
        End Get
    End Property

    Private Sub bt_searchfrombooklist_Click(sender As Object, e As EventArgs) Handles bt_searchfrombooklist.Click
        item_container.Controls.Clear()
        If Not String.IsNullOrEmpty(tb_schid.Text) Then
            _BorrowerInfo = New BorrowerInfo(tb_schid.Text)
            Functions.DisplayBorrower(item_container, Read.Modes.SimilarSearch)
        Else
            Functions.DisplayBorrower(item_container, Read.Modes.GenericSearch)
        End If
    End Sub

    Private Sub bt_reload_Click(sender As Object, e As EventArgs) Handles bt_reload.Click
        item_container.Controls.Clear()
        Functions.DisplayBorrower(item_container, Read.Modes.GenericSearch)
    End Sub

    Private Sub bt_update_Click(sender As Object, e As EventArgs) Handles bt_update.Click
        If Me.gradient.Controls.OfType(Of Guna2TextBox)().Where(Function(txt) txt.Text.Length = 0).Any Then
            lb_error.Text = "Please fill-up empty fields"
            lb_error.ForeColor = Color.Coral
            lb_error.Visible = True
        Else
            If br_id >= 0 Then
                _BorrowerInfo = New BorrowerInfo(
                br_id,
                tb_bschid.Text,
                tb_bname.Text,
                cb_level.Text)
                If (Updates.UpdateBorrower()) Then
                    CleanUp()
                    Functions.DisplayBorrower(item_container, Read.Modes.GenericSearch)
                    lb_error.Text = "Record Updated!"
                    lb_error.ForeColor = Color.CornflowerBlue
                    lb_error.Visible = True
                End If
            Else
                lb_error.Text = "No ID matches select name first!"
                lb_error.ForeColor = Color.Coral
                lb_error.Visible = True
            End If
        End If
    End Sub

    Sub CleanUp()
        br_id = 0
        tb_bname.Clear()
        tb_bschid.Clear()
        cb_level.SelectedIndex = 0
    End Sub
    Sub HideError() Handles tb_bschid.TextChanged, tb_bname.TextChanged, cb_level.TextChanged
        lb_error.Visible = False
    End Sub

    Private Sub tb_clear_Click(sender As Object, e As EventArgs) Handles tb_clear.Click
        CleanUp()
        lb_error.Visible = False
    End Sub
End Class
