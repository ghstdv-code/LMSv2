Public Class MainView
    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        lb_datenow.Text = $"Date: {Date.UtcNow.AddHours(8).ToString("MMMM dd, yyyy HH:mm:ss tt")} UTC+8"
    End Sub

    Private Sub bt_add_borrow_Click(sender As Object, e As EventArgs) Handles bt_add_borrow.Click, Guna2Button7.Click
        AddTransact.ShowDialog()
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        mbx.Caption = "Warning"
        mbx.Text = "Do you want to logout?"
        mbx.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information
        mbx.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo
        If mbx.Show() = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub MainView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ui_container.Controls.Add(New BookTab)
    End Sub
End Class
