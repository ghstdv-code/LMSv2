Imports Guna.UI2.WinForms

Public Class MainView

    Public Property UserID As Integer

    Private _role As Role
    Public Property UserRole As Role
        Get
            UserRole = _role
        End Get
        Set(value As Role)
            _role = value
        End Set
    End Property

    Public Enum Role
        User
        Admin
    End Enum


    Sub ResetForm()
        ui_container.Controls.Clear()
    End Sub
    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        lb_datenow.Text = $"Date: {Date.UtcNow.AddHours(8).ToString("MMMM dd, yyyy HH:mm:ss tt")} UTC+8"
    End Sub

    Private Sub bt_add_borrow_Click(sender As Object, e As EventArgs) Handles bt_add_borrow.Click
        AddTransact.StaffID = UserID
        AddTransact.ShowDialog()
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        mbx.Caption = "Warning"
        mbx.Text = "Do you want to logout?"
        mbx.Icon = MessageDialogIcon.Question
        mbx.Buttons = MessageDialogButtons.YesNo
        If mbx.Show() = DialogResult.Yes Then
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub MainView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case UserRole
            Case Role.Admin
                bt_manageuser.Visible = True
                bt_aacount.Text = "Administrator"
                bt_aacount.Image = My.Resources.admin
            Case Role.User
                bt_manageuser.Visible = False
                bt_aacount.Text = "User"
                bt_aacount.Image = My.Resources.reguser
        End Select
        ViewSwitch(Dashboard.Instance)
    End Sub

    Sub ViewSwitch(views As UserControl)
        ui_container.Controls.Clear()
        ui_container.Controls.Add(views)
        views.BringToFront()
        views.Show()
    End Sub

    Private Sub bt_booktab_Click(sender As Object, e As EventArgs) Handles bt_booktab.Click
        ViewSwitch(BookTab.Instance)
    End Sub

    Private Sub bt_newbook_Click(sender As Object, e As EventArgs) Handles bt_newbook.Click
        Dim bookform As New BookForm With {.SetTitle = "AddBook"}
        bookform.ShowDialog()
    End Sub

    Private Sub bt_return_Click(sender As Object, e As EventArgs) Handles bt_return.Click
        ReturnBook.ShowDialog()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ViewSwitch(Dashboard.Instance)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        ViewSwitch(BorrowerTab.Instance)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles bt_manageuser.Click
        ViewSwitch(ManageUsersTab.Instance)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ViewSwitch(TransactionTab.Instance)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        AboutBox.ShowDialog()
    End Sub
End Class

