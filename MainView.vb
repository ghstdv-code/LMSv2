﻿Imports Guna.UI2.WinForms

Public Class MainView
    Dim CurrentPoint As Point
    Private Sub clock_Tick(sender As Object, e As EventArgs) Handles clock.Tick
        lb_datenow.Text = $"Date: {Date.UtcNow.AddHours(8).ToString("MMMM dd, yyyy HH:mm:ss tt")} UTC+8"
    End Sub

    Private Sub bt_add_borrow_Click(sender As Object, e As EventArgs) Handles bt_add_borrow.Click
        AddTransact.ShowDialog()
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        mbx.Caption = "Warning"
        mbx.Text = "Do you want to logout?"
        mbx.Icon = MessageDialogIcon.Question
        mbx.Buttons = MessageDialogButtons.YesNo
        If mbx.Show() = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub MainView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub bt_booklist_Click(sender As Object, e As EventArgs) Handles bt_booklist.Click

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
        BookForm.ShowDialog()
    End Sub
End Class

