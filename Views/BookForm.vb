Imports System.IO
Imports Guna.UI2.WinForms

Public Class BookForm
    Dim ofd As New OpenFileDialog
    Dim filePath As String

    Private Sub bt_upload_Click(sender As Object, e As EventArgs) Handles bt_upload.Click
        ofd.Filter = "Image|*.jpg;*.jpeg;*.png"
        If ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Try
            If Not IsNothing(img_box.Image) Then img_box.Image.Dispose()
            Me.img_box.Image = New Bitmap(ofd.FileName)
            filePath = $"app\data\images\{tb_BookId.Text}." & Path.GetFileName(ofd.FileName).Split(".")(1)
        Catch
            MainView.mbx.Buttons = MessageDialogButtons.OK
            MainView.mbx.Caption = "Image Invalid"
            MainView.mbx.Text = $"File cannot be uploader{vbCrLf}Please Try again :)"
            MainView.mbx.Icon = MessageDialogIcon.Error
            MainView.mbx.Show()
        End Try
    End Sub

    Private Sub bt_save_Click(sender As Object, e As EventArgs) Handles bt_save.Click
        If Me.Controls.OfType(Of Guna2TextBox)().Where(Function(txt) txt.Text.Length = 0).Any Then
            lb_error.Text = "Please fill-up empty fields"
            lb_error.ForeColor = Color.Red
            lb_error.Visible = True
        ElseIf tb_Copies.Value <= 0 Then
            lb_error.Text = "Copies must be greater than zero"
            lb_error.ForeColor = Color.Red
            lb_error.Visible = True
        Else
            Try
                File.Copy(ofd.FileName, (AppDomain.CurrentDomain.BaseDirectory & filePath), True)
            Catch
                filePath = "NotAvailable"
            End Try
            If Not Functions.VerifyAdd(CInt(tb_BookId.Text)) Then
                DataConfig._Book = New Book(
                  tb_BookId.Text,
                  tb_BookName.Text,
                  tb_Author.Text,
                  tb_Publisher.Text,
                  tb_Copies.Value,
                  cb_condition.Text,
                  filePath)
                If Functions.InsertBook() Then
                    lb_error.Text = "Book Successfully Added!"
                    lb_error.ForeColor = Color.Green
                    lb_error.Visible = True
                Else
                    lb_error.Text = "Error Occured. Please try again!"
                    lb_error.ForeColor = Color.Red
                    lb_error.Visible = True
                End If
            Else
                lb_error.Text = "Book was already added. Please verify Book ID and try again"
                lb_error.ForeColor = Color.Red
                lb_error.Visible = True
            End If
        End If
    End Sub

    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub

    Sub HideLabel() Handles tb_BookId.TextChanged, tb_BookName.TextChanged, tb_Author.TextChanged, tb_Copies.ValueChanged, tb_Publisher.TextChanged, bt_upload.Click
        lb_error.Visible = False
    End Sub

    Sub ResetLayout()
        tb_Author.Clear()
        tb_BookId.Clear()
        tb_BookName.Clear()
        tb_Copies.Value = 0
        tb_Publisher.Clear()
        img_box.Image = My.Resources.sendpabalik
    End Sub

    Private Sub BookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load, bt_clear.Click
        ResetLayout()
        Me.Size = New Point(682, 386)
        Me.border.TargetControl = Me
        Me.shadow.TargetForm = Me
    End Sub
End Class