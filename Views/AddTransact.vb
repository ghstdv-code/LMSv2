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
        Me.Size = New Point(845, 491)
        Me.border.TargetControl = Me
        Me.shadow.TargetForm = Me
        Reset()
    End Sub

    Private Sub bt_check_Click(sender As Object, e As EventArgs) Handles bt_check.Click
        If Not (String.IsNullOrEmpty(tb_id.Text) Or String.IsNullOrWhiteSpace(tb_id.Text)) Then
            If IsBookAvailable(CInt(tb_id.Text)) Then
                Dim record = From t_record In _isbn Where t_record = tb_id.Text
                If Not record.Any Then
                    If (VerifyAdd(CInt(tb_id.Text))) Then
                        _isbn.Add(tb_id.Text)
                    Else
                        Me.lb_error.Visible = True
                        Me.lb_error.Text = "Status: Book Not Found!!"
                        Me.lb_error.ForeColor = Color.Red
                    End If
                Else
                    Me.lb_error.Visible = True
                    Me.lb_error.Text = "Status: Book Already Exist!!"
                    Me.lb_error.ForeColor = Color.Red
                End If
            Else
                Me.lb_error.Visible = True
                Me.lb_error.Text = "Status: Out of stock"
                Me.lb_error.ForeColor = Color.Red
            End If
        Else
            Me.lb_error.Visible = True
            Me.lb_error.Text = "Status: No Input Detected!!"
            Me.lb_error.ForeColor = Color.Red
        End If
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
            IsExist(tb_School_Id.Text.Trim)
            Dim borrower As New Borrower()
            For i As SByte = 0 To idlist.Count - 1 Step 1
                Updates.UpdateCopies("Borrow", idlist(i), _copies(i))
                borrower.BorrowerID = tb_School_Id.Text.Trim
                borrower.BookId = CInt(idlist(i))
                borrower.StaffId = 1
                borrower.IssueDate = CDate(Date.Now.ToString("dd/MM/yyyy"))
                borrower.DueDate = CDate(dtp_dueDate.Value.ToString("dd/MM/yyyy"))
                borrower.Remarks = "PENDING"
                _Borrower = borrower
                If ABorrowBook() Then
                    lb_error.Text = "Record Successfully Added!"
                    lb_error.ForeColor = Color.Green
                    lb_error.Visible = True
                End If
            Next
            Reset()
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles tb_clear.Click
        Reset()
    End Sub
End Class