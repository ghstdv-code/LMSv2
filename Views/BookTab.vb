Imports LMSv2.DataConfig
Imports LMSv2.Functions

Public Class BookTab
    Public Shared this_instance As BookTab
    Public Shared ReadOnly Property Instance As BookTab
        Get
            If IsNothing(this_instance) Then
                Dim booktab As New BookTab()
                Return booktab
            End If
        End Get
    End Property

    Private Sub bt_searchfrombooklist_Click(sender As Object, e As EventArgs) Handles bt_searchfrombooklist.Click
        item_container.Controls.Clear()
        If Not String.IsNullOrEmpty(tb_isbn.Text) Then
            _Book = New Book(tb_isbn.Text.Trim)
            DisplayBook(item_container, Read.Modes.SimilarSearch)
        Else
            DisplayBook(item_container, Read.Modes.GenericSearch)
        End If

    End Sub

    Private Sub BookTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        item_container.HorizontalScroll.Visible = False
        DisplayBook(item_container, Read.Modes.GenericSearch)
    End Sub

    Private Sub bt_reload_Click(sender As Object, e As EventArgs) Handles bt_reload.Click
        item_container.HorizontalScroll.Visible = False
        DisplayBook(item_container, Read.Modes.GenericSearch)
    End Sub
End Class
