Imports LMSv2.Functions
Imports Guna.UI2.WinForms

Public Class AddTransact
    Dim flag As Boolean
    Public idlist As New List(Of String)
    Public _copies As New List(Of Integer)
    Public _isbn As New List(Of String)

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub

    Private Sub AddTransact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_dueDate.Value = Date.Now.AddDays(2)
        Me.Size = New Point(845, 491)
        Me.border.TargetControl = Me
        Me.shadow.TargetForm = Me
        Reset()
    End Sub

    Private Sub bt_check_Click(sender As Object, e As EventArgs) Handles bt_check.Click
        AddBookToList(tb_id.Text)
    End Sub

    Private Sub tb_textchanged(sender As Object, e As EventArgs) Handles tb_id.TextChanged
        lb_error.Visible = False
    End Sub

    Sub Reset()
        idlist.Clear()
        _copies.Clear()
        _isbn.Clear()
        tb_id.Clear()
        tb_Name.Clear()
        tb_School_Id.Clear()
        cb_level.SelectedIndex = 0
        lb_error.Visible = False
        item_container.Controls.Clear()
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If Me.Controls.OfType(Of Guna2TextBox)().Where(Function(txt) txt.Text.Length = 0).Any Then
            lb_error.Text = "Please fill-up empty fields"
            lb_error.ForeColor = Color.Red
            lb_error.Visible = True
        ElseIf idlist.Count <= 0 Then
            lb_error.Text = "No Book was added!"
            lb_error.ForeColor = Color.Red
            lb_error.Visible = True
        Else
            SaveBorrow(tb_School_Id.Text.Trim)
            If ABorrowBook() Then
                lb_error.Text = "Record Successfully Added!"
                lb_error.ForeColor = Color.Green
                lb_error.Visible = True
            End If
            Reset()
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles tb_clear.Click
        Reset()
    End Sub
End Class