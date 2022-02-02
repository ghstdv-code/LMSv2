<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainView))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_manageuser = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_booktab = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.header = New System.Windows.Forms.Panel()
        Me.bt_aacount = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_close = New Guna.UI2.WinForms.Guna2Button()
        Me.border = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.moveControl = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.lb_datenow = New System.Windows.Forms.Label()
        Me.clock = New System.Windows.Forms.Timer(Me.components)
        Me.mbx = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.ui_container = New System.Windows.Forms.FlowLayoutPanel()
        Me.bt_newbook = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_add_borrow = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_return = New Guna.UI2.WinForms.Guna2Button()
        Me.Dashboard1 = New LMSv2.Dashboard()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.header.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2Button3)
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.bt_manageuser)
        Me.Panel1.Controls.Add(Me.Guna2Button5)
        Me.Panel1.Controls.Add(Me.bt_booktab)
        Me.Panel1.Controls.Add(Me.Guna2Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 720)
        Me.Panel1.TabIndex = 0
        '
        'Guna2Button3
        '
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.DisabledState.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Image = CType(resources.GetObject("Guna2Button3.Image"), System.Drawing.Image)
        Me.Guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button3.Location = New System.Drawing.Point(0, 277)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(210, 45)
        Me.Guna2Button3.TabIndex = 9
        Me.Guna2Button3.Text = "Transactions"
        Me.Guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 651)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(210, 45)
        Me.Guna2Button1.TabIndex = 9
        Me.Guna2Button1.Text = "About"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bt_manageuser
        '
        Me.bt_manageuser.CheckedState.Parent = Me.bt_manageuser
        Me.bt_manageuser.CustomImages.Parent = Me.bt_manageuser
        Me.bt_manageuser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_manageuser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_manageuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_manageuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_manageuser.DisabledState.Parent = Me.bt_manageuser
        Me.bt_manageuser.FillColor = System.Drawing.Color.Transparent
        Me.bt_manageuser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_manageuser.ForeColor = System.Drawing.Color.White
        Me.bt_manageuser.HoverState.Parent = Me.bt_manageuser
        Me.bt_manageuser.Image = CType(resources.GetObject("bt_manageuser.Image"), System.Drawing.Image)
        Me.bt_manageuser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bt_manageuser.Location = New System.Drawing.Point(0, 328)
        Me.bt_manageuser.Name = "bt_manageuser"
        Me.bt_manageuser.ShadowDecoration.Parent = Me.bt_manageuser
        Me.bt_manageuser.Size = New System.Drawing.Size(210, 45)
        Me.bt_manageuser.TabIndex = 9
        Me.bt_manageuser.Text = "Manage Users"
        Me.bt_manageuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button5
        '
        Me.Guna2Button5.CheckedState.Parent = Me.Guna2Button5
        Me.Guna2Button5.CustomImages.Parent = Me.Guna2Button5
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.DisabledState.Parent = Me.Guna2Button5
        Me.Guna2Button5.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.HoverState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Image = CType(resources.GetObject("Guna2Button5.Image"), System.Drawing.Image)
        Me.Guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button5.Location = New System.Drawing.Point(0, 226)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.Size = New System.Drawing.Size(210, 45)
        Me.Guna2Button5.TabIndex = 10
        Me.Guna2Button5.Text = "Borrowers"
        Me.Guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bt_booktab
        '
        Me.bt_booktab.CheckedState.Parent = Me.bt_booktab
        Me.bt_booktab.CustomImages.Parent = Me.bt_booktab
        Me.bt_booktab.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_booktab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_booktab.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_booktab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_booktab.DisabledState.Parent = Me.bt_booktab
        Me.bt_booktab.FillColor = System.Drawing.Color.Transparent
        Me.bt_booktab.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_booktab.ForeColor = System.Drawing.Color.White
        Me.bt_booktab.HoverState.Parent = Me.bt_booktab
        Me.bt_booktab.Image = CType(resources.GetObject("bt_booktab.Image"), System.Drawing.Image)
        Me.bt_booktab.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bt_booktab.Location = New System.Drawing.Point(0, 175)
        Me.bt_booktab.Name = "bt_booktab"
        Me.bt_booktab.ShadowDecoration.Parent = Me.bt_booktab
        Me.bt_booktab.Size = New System.Drawing.Size(210, 45)
        Me.bt_booktab.TabIndex = 12
        Me.bt_booktab.Text = "Books"
        Me.bt_booktab.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button2
        '
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.DisabledState.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(0, 124)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(210, 45)
        Me.Guna2Button2.TabIndex = 13
        Me.Guna2Button2.Text = "Dashboard"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(64, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 44)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "LIBRARY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MANAGEMENT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.header.Controls.Add(Me.bt_aacount)
        Me.header.Controls.Add(Me.bt_close)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(210, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1097, 40)
        Me.header.TabIndex = 1
        '
        'bt_aacount
        '
        Me.bt_aacount.BackColor = System.Drawing.Color.White
        Me.bt_aacount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_aacount.CheckedState.Parent = Me.bt_aacount
        Me.bt_aacount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_aacount.CustomImages.Parent = Me.bt_aacount
        Me.bt_aacount.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_aacount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_aacount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_aacount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_aacount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_aacount.DisabledState.Parent = Me.bt_aacount
        Me.bt_aacount.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.bt_aacount.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.bt_aacount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.bt_aacount.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.bt_aacount.HoverState.Parent = Me.bt_aacount
        Me.bt_aacount.Image = Global.LMSv2.My.Resources.Resources.reguser
        Me.bt_aacount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bt_aacount.Location = New System.Drawing.Point(0, 0)
        Me.bt_aacount.Name = "bt_aacount"
        Me.bt_aacount.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_aacount.ShadowDecoration.Parent = Me.bt_aacount
        Me.bt_aacount.Size = New System.Drawing.Size(146, 40)
        Me.bt_aacount.TabIndex = 3
        Me.bt_aacount.Text = "Administrator"
        Me.bt_aacount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.White
        Me.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_close.CheckedState.Parent = Me.bt_close
        Me.bt_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_close.CustomImages.Parent = Me.bt_close
        Me.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_close.DisabledState.Parent = Me.bt_close
        Me.bt_close.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.bt_close.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.bt_close.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.bt_close.HoverState.Parent = Me.bt_close
        Me.bt_close.Image = CType(resources.GetObject("bt_close.Image"), System.Drawing.Image)
        Me.bt_close.Location = New System.Drawing.Point(1005, 0)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_close.ShadowDecoration.Parent = Me.bt_close
        Me.bt_close.Size = New System.Drawing.Size(92, 40)
        Me.bt_close.TabIndex = 4
        Me.bt_close.Text = "Logout"
        '
        'border
        '
        Me.border.BorderRadius = 10
        Me.border.TargetControl = Me
        '
        'moveControl
        '
        Me.moveControl.DockIndicatorTransparencyValue = 0.6R
        Me.moveControl.TargetControl = Me.header
        Me.moveControl.UseTransparentDrag = True
        '
        'lb_datenow
        '
        Me.lb_datenow.AutoSize = True
        Me.lb_datenow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_datenow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lb_datenow.Location = New System.Drawing.Point(216, 52)
        Me.lb_datenow.Name = "lb_datenow"
        Me.lb_datenow.Size = New System.Drawing.Size(71, 16)
        Me.lb_datenow.TabIndex = 9
        Me.lb_datenow.Text = "Date Now"
        '
        'clock
        '
        Me.clock.Enabled = True
        '
        'mbx
        '
        Me.mbx.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.mbx.Caption = Nothing
        Me.mbx.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.mbx.Parent = Me
        Me.mbx.Style = Guna.UI2.WinForms.MessageDialogStyle.Light
        Me.mbx.Text = Nothing
        '
        'ui_container
        '
        Me.ui_container.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ui_container.Location = New System.Drawing.Point(224, 102)
        Me.ui_container.Margin = New System.Windows.Forms.Padding(0)
        Me.ui_container.Name = "ui_container"
        Me.ui_container.Size = New System.Drawing.Size(1069, 606)
        Me.ui_container.TabIndex = 12
        '
        'bt_newbook
        '
        Me.bt_newbook.BackColor = System.Drawing.Color.White
        Me.bt_newbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_newbook.BorderRadius = 5
        Me.bt_newbook.CheckedState.Parent = Me.bt_newbook
        Me.bt_newbook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_newbook.CustomImages.Parent = Me.bt_newbook
        Me.bt_newbook.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_newbook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_newbook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_newbook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_newbook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_newbook.DisabledState.Parent = Me.bt_newbook
        Me.bt_newbook.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.bt_newbook.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_newbook.ForeColor = System.Drawing.Color.White
        Me.bt_newbook.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bt_newbook.HoverState.Parent = Me.bt_newbook
        Me.bt_newbook.Image = CType(resources.GetObject("bt_newbook.Image"), System.Drawing.Image)
        Me.bt_newbook.Location = New System.Drawing.Point(888, 56)
        Me.bt_newbook.Name = "bt_newbook"
        Me.bt_newbook.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_newbook.ShadowDecoration.Parent = Me.bt_newbook
        Me.bt_newbook.Size = New System.Drawing.Size(131, 40)
        Me.bt_newbook.TabIndex = 8
        Me.bt_newbook.Text = "New Book"
        '
        'bt_add_borrow
        '
        Me.bt_add_borrow.BackColor = System.Drawing.Color.White
        Me.bt_add_borrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_add_borrow.BorderRadius = 5
        Me.bt_add_borrow.CheckedState.Parent = Me.bt_add_borrow
        Me.bt_add_borrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_add_borrow.CustomImages.Parent = Me.bt_add_borrow
        Me.bt_add_borrow.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_add_borrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_add_borrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_add_borrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_add_borrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_add_borrow.DisabledState.Parent = Me.bt_add_borrow
        Me.bt_add_borrow.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.bt_add_borrow.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_add_borrow.ForeColor = System.Drawing.Color.White
        Me.bt_add_borrow.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bt_add_borrow.HoverState.Parent = Me.bt_add_borrow
        Me.bt_add_borrow.Image = CType(resources.GetObject("bt_add_borrow.Image"), System.Drawing.Image)
        Me.bt_add_borrow.Location = New System.Drawing.Point(1162, 56)
        Me.bt_add_borrow.Name = "bt_add_borrow"
        Me.bt_add_borrow.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_add_borrow.ShadowDecoration.Parent = Me.bt_add_borrow
        Me.bt_add_borrow.Size = New System.Drawing.Size(131, 40)
        Me.bt_add_borrow.TabIndex = 8
        Me.bt_add_borrow.Text = "Issue Book"
        '
        'bt_return
        '
        Me.bt_return.BackColor = System.Drawing.Color.White
        Me.bt_return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_return.BorderRadius = 5
        Me.bt_return.CheckedState.Parent = Me.bt_return
        Me.bt_return.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_return.CustomImages.Parent = Me.bt_return
        Me.bt_return.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_return.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_return.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_return.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_return.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_return.DisabledState.Parent = Me.bt_return
        Me.bt_return.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.bt_return.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_return.ForeColor = System.Drawing.Color.White
        Me.bt_return.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bt_return.HoverState.Parent = Me.bt_return
        Me.bt_return.Image = CType(resources.GetObject("bt_return.Image"), System.Drawing.Image)
        Me.bt_return.Location = New System.Drawing.Point(1025, 56)
        Me.bt_return.Name = "bt_return"
        Me.bt_return.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_return.ShadowDecoration.Parent = Me.bt_return
        Me.bt_return.Size = New System.Drawing.Size(131, 40)
        Me.bt_return.TabIndex = 8
        Me.bt_return.Text = "Return Book"
        '
        'Dashboard1
        '
        Me.Dashboard1.BackColor = System.Drawing.Color.White
        Me.Dashboard1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard1.Location = New System.Drawing.Point(0, 0)
        Me.Dashboard1.Margin = New System.Windows.Forms.Padding(0)
        Me.Dashboard1.Name = "Dashboard1"
        Me.Dashboard1.Size = New System.Drawing.Size(1069, 606)
        Me.Dashboard1.TabIndex = 0
        '
        'MainView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1307, 720)
        Me.Controls.Add(Me.ui_container)
        Me.Controls.Add(Me.lb_datenow)
        Me.Controls.Add(Me.bt_newbook)
        Me.Controls.Add(Me.bt_add_borrow)
        Me.Controls.Add(Me.bt_return)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.header.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents header As Panel
    Friend WithEvents border As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bt_aacount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bt_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents moveControl As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents bt_manageuser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bt_booktab As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lb_datenow As Label
    Friend WithEvents bt_add_borrow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clock As Timer
    Friend WithEvents bt_return As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mbx As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents ui_container As FlowLayoutPanel
    Friend WithEvents bt_newbook As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Dashboard1 As Dashboard
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
