Imports System.IO

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
        Dim item As New item_booklist With {
            .BookISBN = "112312",
            .BookName = "Sulat Ni Carding",
            .BookAuthor = "Si Carding Mismo",
            .BookPublisher = "Kabarangay",
            .BookCopies = 2,
            .BookCondition = "Fine (F)"
            }
        item_container.Controls.Add(item)

    End Sub

    Private Sub BookTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        item_container.HorizontalScroll.Visible = False
    End Sub
End Class
