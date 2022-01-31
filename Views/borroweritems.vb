Imports Guna.UI2.WinForms

Public Class borroweritems
    Private _id As Integer
    Private _name As String
    Private _schid As String
    Private _level As String

    Public WriteOnly Property BID As Integer
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property BName As String
        Get
            BName = _name
        End Get
        Set(value As String)
            _name = value
            lb_name.Text = value
        End Set
    End Property

    Public Property BSCHID As String
        Get
            BSCHID = _schid
        End Get
        Set(value As String)
            _schid = value
            lb_id.Text = value
        End Set
    End Property

    Public Property BLevel As String
        Get
            BLevel = _level
        End Get
        Set(value As String)
            _level = value
            lb_glevel.Text = value
        End Set
    End Property

    Private Sub bt_view_Click(sender As Object, e As EventArgs) Handles bt_view.Click
        For Each ctrl As Control In MainView.ui_container.Controls
            Dim btab As BorrowerTab = CType(ctrl, BorrowerTab)
            btab.tb_bname.Text = _name
            btab.tb_bschid.Text = _schid
            btab.cb_level.Text = _level
            btab.br_id = _id
        Next
    End Sub

    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles bt_delete.Click
        MainView.mbx.Icon = MessageDialogIcon.Warning
        MainView.mbx.Buttons = MessageDialogButtons.YesNo
        MainView.mbx.Caption = "Warning"
        MainView.mbx.Text = "Are you sure you want to remove this entry?"
        If MainView.mbx.Show() = DialogResult.Yes Then
            DataConfig._BorrowerInfo = New BorrowerInfo(_id)
            Parent.Controls.Remove(Me)
            Delete.DeleteBorrower()
        End If
    End Sub
End Class
