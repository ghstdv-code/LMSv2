Imports LMSv2.DataConfig
Imports Guna.UI2.WinForms

Public Class ManageUsersTab
    Public Shared this_instance As ManageUsersTab
    Public Shared ReadOnly Property Instance As ManageUsersTab
        Get
            If IsNothing(this_instance) Then
                Dim manageusertab As New ManageUsersTab()
                Return manageusertab
            End If
        End Get
    End Property

    Public _id As Integer = -1

    Private Sub bt_searchfrombooklist_Click(sender As Object, e As EventArgs) Handles bt_searchfrombooklist.Click
        item_container.Controls.Clear()
        If Not (String.IsNullOrEmpty(tb_schid.Text)) Then
            _UserInfo = New UserInfo(tb_schid.Text, tb_schid.Text)
            Functions.DisplayUsers(item_container, Read.Modes.SimilarSearch)
        Else
            Functions.DisplayUsers(item_container, Read.Modes.GenericSearch)
        End If
    End Sub

    Private Sub ManageUsersTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load, bt_reload.Click
        item_container.Controls.Clear()
        Functions.DisplayUsers(item_container, Read.Modes.GenericSearch)
    End Sub

    Private Sub bt_update_Click(sender As Object, e As EventArgs) Handles bt_update.Click
        If Me.gradient.Controls.OfType(Of Guna2TextBox)().Where(Function(txt) txt.Text.Length = 0).Any Then
            lb_error.Text = "Please fill-up empty fields"
            lb_error.ForeColor = Color.Coral
            lb_error.Visible = True
        Else
            _User = New User(
                    _id,
                    tb_fname.Text.Trim,
                    tb_lname.Text.Trim,
                    tb_work.Text.Trim,
                    tb_Contact.Text.Trim,
                    cb_gender.Text.Trim,
                    tb_uname.Text.Trim,
                    tb_passw.Text.Trim,
                    cb_role.Text.Trim
                )
            If _id >= 0 Then
                If Updates.UpdateUser Then
                    CleanUp()
                    Functions.DisplayUsers(item_container, Read.Modes.GenericSearch)
                    lb_error.Text = "Record Updated!"
                    lb_error.ForeColor = Color.CornflowerBlue
                    lb_error.Visible = True
                End If
            Else
                If (Create.AddUser()) Then
                    CleanUp()
                    Functions.DisplayUsers(item_container, Read.Modes.GenericSearch)
                    lb_error.Text = "Record Inserted!"
                    lb_error.ForeColor = Color.CornflowerBlue
                    lb_error.Visible = True
                End If
            End If
        End If
    End Sub

    Sub CleanUp()
        _id = -1
        tb_fname.Clear()
        tb_lname.Clear()
        tb_work.Clear()
        tb_work.Clear()
        tb_Contact.Clear()
        cb_gender.SelectedIndex = 0
        tb_uname.Clear()
        tb_passw.Clear()
        item_container.Controls.Clear()
        cb_role.Text = "User"
    End Sub

    Sub HideError() Handles tb_fname.TextChanged, tb_lname.TextChanged, tb_work.TextChanged, tb_Contact.TextChanged, tb_Contact.TextChanged, cb_gender.TextChanged, tb_uname.TextChanged, tb_passw.TextChanged
        lb_error.Hide()
    End Sub

    Private Sub tb_clear_Click(sender As Object, e As EventArgs) Handles tb_clear.Click
        CleanUp()
    End Sub
End Class
