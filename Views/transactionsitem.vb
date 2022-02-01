Imports Guna.UI2.WinForms

Public Class transactionsitem
    Private _id As Integer
    Private _bookid As Integer
    Private _schid As String
    Private _staff As String
    Private _issuedate As String
    Private _duedate As String
    Private _status As String

    Public WriteOnly Property TRID As Integer
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property TRBookID As Integer
        Get
            TRBookID = _bookid
        End Get
        Set(value As Integer)
            _bookid = value
            lb_isbn.Text = value
        End Set
    End Property

    Public Property TRSchID As String
        Get
            TRSchID = _schid
        End Get
        Set(value As String)
            _schid = value
            lb_borrower.Text = value
        End Set
    End Property

    Public Property TRIssue As String
        Get
            TRIssue = _issuedate
        End Get
        Set(value As String)
            _issuedate = CDate(value).ToString("dd/MM/yyyy")
            lb_isssued.Text = CDate(value).ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property TRDue As String
        Get
            TRDue = _duedate
        End Get
        Set(value As String)
            _duedate = CDate(value).ToString("dd/MM/yyyy")
            lb_due.Text = CDate(value).ToString("dd/MM/yyyy")
        End Set
    End Property

    Public Property TRStaff As String
        Get
            TRStaff = _staff
        End Get
        Set(value As String)
            _staff = value
            lb_staff.Text = value
        End Set
    End Property

    Public Property TRStatus As String
        Get
            TRStatus = _status
        End Get
        Set(value As String)
            _status = value
            lb_status.Text = value
        End Set
    End Property

    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles bt_delete.Click
        MainView.mbx.Icon = MessageDialogIcon.Warning
        MainView.mbx.Buttons = MessageDialogButtons.YesNo
        MainView.mbx.Caption = "Warning"
        MainView.mbx.Text = "Are you sure you want to remove this entry?"
        If MainView.mbx.Show() = DialogResult.Yes Then
            DataConfig._Borrower = New Borrower(_id)
            Parent.Controls.Remove(Me)
            Delete.DeleteTransact()
        End If
    End Sub
End Class
