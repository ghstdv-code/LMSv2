Imports LMSv2.DataConfig

Public Class TransactionTab

    Public Shared this_instance As TransactionTab
    Public Shared ReadOnly Property Instance As TransactionTab
        Get
            If IsNothing(this_instance) Then
                Dim trasacttab As New TransactionTab()
                Return trasacttab
            End If
        End Get
    End Property

    Private Sub bt_searchfrombooklist_Click(sender As Object, e As EventArgs) Handles bt_searchfrombooklist.Click
        item_container.Controls.Clear()
        If Not String.IsNullOrEmpty(tb_isbn.Text) Then

            _Book = New Book(tb_isbn.Text)
            Functions.DisplayTransactions(item_container, Read.Modes.SimilarSearch)
        Else
            Functions.DisplayTransactions(item_container, Read.Modes.GenericSearch)
        End If


    End Sub

    Private Sub TransactionTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load, bt_reload.Click
        item_container.Controls.Clear()
        Functions.DisplayTransactions(item_container, Read.Modes.GenericSearch)
    End Sub


End Class
