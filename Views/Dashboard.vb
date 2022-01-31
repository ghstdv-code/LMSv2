Public Class Dashboard
    Public Shared this_instance As Dashboard
    Public Shared ReadOnly Property Instance As Dashboard
        Get
            If IsNothing(this_instance) Then
                Dim dashboard As New Dashboard()
                Return dashboard
            End If
        End Get
    End Property

    Private _bookcount
    Private WriteOnly Property BookCount As Integer
        Set(value As Integer)

            lb_books.Text = CStr(value)
        End Set
    End Property

    Private WriteOnly Property Borrower As Integer
        Set(value As Integer)
            lb_borrowers.Text = CStr(value)
        End Set
    End Property

    Private WriteOnly Property Transactions As Integer
        Set(value As Integer)
            lb_transactions.Text = CStr(value)
        End Set
    End Property

    Private WriteOnly Property Accounts As Integer
        Set(value As Integer)
            lb_newbooks.Text = CStr(value)
        End Set
    End Property

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datalist() As Integer = Read.DashboardData()
        lb_books.Text = datalist(0)
        lb_borrowers.Text = datalist(1)
        lb_transactions.Text = datalist(2)
        lb_newbooks.Text = datalist(3)

        pbar_issued.Value = (CDbl(datalist(4) / datalist(0))) * 100.0
        pbar_return.Value = (CDbl(datalist(5) / datalist(0))) * 100.0

        pbar_good.Value = (CDbl(datalist(6) / datalist(0))) * 100
        pbar_bad.Value = (CDbl(datalist(7) / datalist(0))) * 100
    End Sub

    Private Sub lb_datenow_Click(sender As Object, e As EventArgs) Handles lb_datenow.Click, Label9.Click, Label8.Click, Label11.Click, Label10.Click, lb_transactions.Click, lb_newbooks.Click, lb_borrowers.Click, lb_books.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click, PictureBox4.Click

    End Sub
End Class
