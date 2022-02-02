Imports Guna.UI2.WinForms

Public Class Login
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Application.Exit()
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If Controls.OfType(Of Guna2TextBox)().Where(Function(txt) txt.Text.Length = 0).Any Then
            lb_error.Text = "Please fill-up empty fields"
            lb_error.ForeColor = Color.Coral
            lb_error.Visible = True
        Else
            DataConfig._User = New User(tb_uname.Text, tb_pass.Text)
            Dim dt = Read.Trylogin()
            If (dt.Rows.Count > 0) Then
                MainView.UserID = dt.Rows(0).Item("UserID")
                MainView.UserRole = IIf(dt.Rows(0).Item("Role") = "Admin", MainView.Role.Admin, MainView.Role.User)
                MainView.Show()
                Me.Hide()
                Me.ResetForm()
            Else
                lb_error.Text = "Username or Password Incorrect!"
                lb_error.ForeColor = Color.Coral
                lb_error.Visible = True
            End If
        End If

    End Sub

    Sub ClearError() Handles tb_uname.TextChanged, tb_pass.TextChanged
        lb_error.Visible = False
    End Sub

    Sub ResetForm()
        tb_uname.Clear()
        tb_pass.Clear()
        ClearError()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Me.MaximumSize = New Point(547, 456)
        Me.shadow.TargetForm = Me
        Me.border.TargetControl = Me
        Me.drag.TargetControl = Me
        ResetForm()
    End Sub

    Private Sub ClearError(sender As Object, e As EventArgs) Handles tb_uname.TextChanged, tb_pass.TextChanged

    End Sub
End Class