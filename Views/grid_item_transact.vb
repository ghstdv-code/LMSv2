﻿Public Class grid_item_transact
    Private _bookname As String
    Private _bookisbn As Integer
    Private _bookauthor As String
    Private _bookpubliher As String

    Public Property BookName As String
        Get
            BookName = _bookname
        End Get
        Set(value As String)
            lb_bookname.Text = value
        End Set
    End Property

    Public Property BookISBN As Integer
        Get
            BookISBN = _bookisbn
        End Get
        Set(value As Integer)
            lb_isbn.Text = Convert.ToString(value)
        End Set
    End Property

    Public Property BookAuthor As String
        Get
            BookAuthor = _bookauthor
        End Get
        Set(value As String)
            lb_author.Text = value
        End Set
    End Property

    Public Property BookPublisher As String
        Get
            BookPublisher = _bookpubliher
        End Get
        Set(value As String)
            lb_publisher.Text = value
        End Set
    End Property

    Private Sub grid_item_transact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles bt_delete.Click
        Parent.Controls.Remove(Me)
    End Sub
End Class
