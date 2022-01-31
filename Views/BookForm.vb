Imports System.IO
Imports Guna.UI2.WinForms
Imports LMSv2.DataConfig

Public Class BookForm
    Dim ofd As New OpenFileDialog
    Dim filePath As String
    Dim id As Integer

    Enum Modes
        Create
        Update
    End Enum

    Private mode As Modes
    Public Property SetMode As Modes
        Get
            SetMode = mode
        End Get
        Set(value As Modes)
            mode = value
        End Set
    End Property

    Public WriteOnly Property SetID As Integer
        Set(value As Integer)
            id = value
        End Set
    End Property
    Public WriteOnly Property SetTitle As String
        Set(value As String)
            lb_title.Text = value
        End Set
    End Property

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
            If (SetMode = Modes.Create) Then
                If Not Functions.VerifyAdd(CInt(tb_BookId.Text)) Then
                    makeBook()
                    If Functions.InsertBook() Then
                        lb_error.Text = "Book Successfully Added!"
                        lb_error.ForeColor = Color.Green
                        lb_error.Visible = True
                        ResetLayout()
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
            Else
                makeBook()
                If (Updates.UpdateBookInfo) Then
                    lb_error.Text = "Book Successfully Updated!"
                    lb_error.ForeColor = Color.Green
                    lb_error.Visible = True
                    MainView.ViewSwitch(BookTab.Instance)
                End If
            End If
        End If
        ' MsgBox(_Book.BookPublisher.ToString())
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

    Private Sub BookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SetMode = Modes.Update Then
            ResetLayout()
            tb_BookId.Text = _Book.ISBN
            tb_BookName.Text = _Book.BookTitle
            tb_Author.Text = _Book.BookAuthor
            tb_Publisher.Text = _Book.BookPublisher
            tb_Copies.Value = CInt(_Book.Copies)
            cb_condition.Text = _Book.Condition

            If (_Book.StringPath <> "NotAvailable") Then
                img_box.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & _Book.StringPath)
            Else
                img_box.Image = My.Resources.sendpabalik
            End If
        Else
            ResetLayout()
        End If

        Me.Size = New Point(682, 386)
        Me.border.TargetControl = Me
        Me.shadow.TargetForm = Me
    End Sub

    Private Sub bt_clear_Click(sender As Object, e As EventArgs) Handles bt_clear.Click
        ResetLayout
    End Sub

    Sub makeBook()
        Try
            _Book.Dispose()
        Catch
        End Try

        _Book = New Book(
        id,
        tb_BookId.Text,
        tb_BookName.Text,
        tb_Author.Text,
        tb_Publisher.Text,
        tb_Copies.Value,
        cb_condition.Text,
        filePath)
    End Sub

End Class