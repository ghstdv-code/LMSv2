Imports LMSv2.DataConfig

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

        If Not String.IsNullOrEmpty(tb_isbn.Text) Then
            _Book = New Book(tb_isbn.Text.Trim)
            Functions.DisplayBook(item_container, Read.Modes.SimilarSearch)
        Else
            Functions.DisplayBook(item_container, Read.Modes.GenericSearch)
        End If

    End Sub

    Private Sub BookTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        item_container.HorizontalScroll.Visible = False

    End Sub
End Class
