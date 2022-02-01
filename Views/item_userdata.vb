Imports Guna.UI2.WinForms

Public Class item_userdata
    Private _id As Integer
    Private _name As String
    Private _occupation As String
    Private _contact As String
    Private _gender As String
    Private _username As String
    Private _password As String
    Private _role As String

    Public WriteOnly Property ID As Integer
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property UserInfoName As String
        Get
            UserInfoName = _name
        End Get
        Set(value As String)
            _name = value
            lb_name.Text = value
        End Set
    End Property

    Public Property UserInfoWork As String
        Get
            UserInfoWork = _occupation
        End Get
        Set(value As String)
            _occupation = value
            lb_occupation.Text = value
        End Set
    End Property
    Public Property UserInfoContact As String
        Get
            UserInfoContact = _contact
        End Get
        Set(value As String)
            _contact = value
        End Set
    End Property
    Public Property UserInfoGender As String
        Get
            UserInfoGender = _gender
        End Get
        Set(value As String)
            _gender = value
            lb_gender.Text = value
        End Set
    End Property
    Public Property UserInfoUserName As String
        Get
            UserInfoUserName = _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property
    Public Property UserInfoPassword As String
        Get
            UserInfoPassword = _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
    Public Property UserInfoRole As String
        Get
            UserInfoRole = _role
        End Get
        Set(value As String)
            _role = value
        End Set
    End Property

    Private Sub bt_view_Click(sender As Object, e As EventArgs) Handles bt_view.Click
        For Each ctrl As Control In MainView.ui_container.Controls
            Dim utab As ManageUsersTab = CType(ctrl, ManageUsersTab)
            utab._id = _id
            Dim fullname() As String = _name.Split(" ")
            If (fullname.Length > 2) Then
                utab.tb_fname.Clear()
                For i As SByte = 0 To fullname.Length - 2 Step 1
                    utab.tb_fname.Text += fullname(i) & " "
                Next
                utab.tb_lname.Text = fullname(fullname.Length - 1)
            Else
                utab.tb_fname.Text = fullname(0)
                utab.tb_lname.Text = fullname(1)
            End If
            utab.tb_work.Text = _occupation
            utab.tb_Contact.Text = _contact
            utab.cb_gender.Text = _gender
            utab.tb_uname.Text = _username
            utab.tb_passw.Text = _password
            utab.cb_role.Text = _role
        Next
    End Sub

    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles bt_delete.Click
        MainView.mbx.Icon = MessageDialogIcon.Warning
        MainView.mbx.Buttons = MessageDialogButtons.YesNo
        MainView.mbx.Caption = "Warning"
        MainView.mbx.Text = "Are you sure you want to remove this book?"
        If MainView.mbx.Show() = DialogResult.Yes Then
            DataConfig._User = New User With {.ID = _id}
            Parent.Controls.Remove(Me)
            Delete.DeleteUser()
        End If
    End Sub
End Class
