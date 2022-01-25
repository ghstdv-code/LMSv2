Public Class AddTransact
    Private Sub bt_close_Click(sender As Object, e As EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub

    Private Sub bt_add_borrow_Click(sender As Object, e As EventArgs) Handles bt_add_borrow.Click
        Dim grd_item As New grid_item_transact
        grd_item.BookName = "Halamang Gamot"
        grd_item.BookAuthor = "Mang Kepweng"
        grd_item.BookISBN = 691230564
        grd_item.BookPublisher = "Payagan ng Itlog"
        item_container.Controls.Add(grd_item)
    End Sub
End Class