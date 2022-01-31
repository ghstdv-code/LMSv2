<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowerTab
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowerTab))
        Me.Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.bt_reload = New Guna.UI2.WinForms.Guna2Button()
        Me.gradient = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.bt_update = New Guna.UI2.WinForms.Guna2Button()
        Me.tb_clear = New Guna.UI2.WinForms.Guna2Button()
        Me.lb_error = New System.Windows.Forms.Label()
        Me.cb_level = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tb_bname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_bschid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.item_container = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_schid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bt_searchfrombooklist = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ShadowPanel2.SuspendLayout()
        Me.gradient.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel2
        '
        Me.Guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel2.Controls.Add(Me.bt_reload)
        Me.Guna2ShadowPanel2.Controls.Add(Me.gradient)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Guna2VSeparator1)
        Me.Guna2ShadowPanel2.Controls.Add(Me.item_container)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label13)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label14)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label15)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label5)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label11)
        Me.Guna2ShadowPanel2.Controls.Add(Me.tb_schid)
        Me.Guna2ShadowPanel2.Controls.Add(Me.bt_searchfrombooklist)
        Me.Guna2ShadowPanel2.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel2.Location = New System.Drawing.Point(12, 19)
        Me.Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Me.Guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel2.Size = New System.Drawing.Size(1044, 569)
        Me.Guna2ShadowPanel2.TabIndex = 2
        '
        'bt_reload
        '
        Me.bt_reload.BackColor = System.Drawing.Color.White
        Me.bt_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_reload.BorderRadius = 5
        Me.bt_reload.CheckedState.Parent = Me.bt_reload
        Me.bt_reload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_reload.CustomImages.Parent = Me.bt_reload
        Me.bt_reload.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_reload.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_reload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_reload.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_reload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_reload.DisabledState.Parent = Me.bt_reload
        Me.bt_reload.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.bt_reload.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_reload.ForeColor = System.Drawing.Color.White
        Me.bt_reload.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bt_reload.HoverState.Parent = Me.bt_reload
        Me.bt_reload.Image = CType(resources.GetObject("bt_reload.Image"), System.Drawing.Image)
        Me.bt_reload.Location = New System.Drawing.Point(873, 46)
        Me.bt_reload.Name = "bt_reload"
        Me.bt_reload.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_reload.ShadowDecoration.Parent = Me.bt_reload
        Me.bt_reload.Size = New System.Drawing.Size(148, 33)
        Me.bt_reload.TabIndex = 83
        Me.bt_reload.Text = "Reload"
        '
        'gradient
        '
        Me.gradient.BackColor = System.Drawing.Color.Transparent
        Me.gradient.BorderRadius = 10
        Me.gradient.Controls.Add(Me.bt_update)
        Me.gradient.Controls.Add(Me.tb_clear)
        Me.gradient.Controls.Add(Me.lb_error)
        Me.gradient.Controls.Add(Me.cb_level)
        Me.gradient.Controls.Add(Me.tb_bname)
        Me.gradient.Controls.Add(Me.tb_bschid)
        Me.gradient.Controls.Add(Me.PictureBox1)
        Me.gradient.Controls.Add(Me.Label6)
        Me.gradient.Controls.Add(Me.Label4)
        Me.gradient.Controls.Add(Me.Label2)
        Me.gradient.Controls.Add(Me.Label3)
        Me.gradient.FillColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.gradient.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.gradient.Location = New System.Drawing.Point(26, 40)
        Me.gradient.Name = "gradient"
        Me.gradient.ShadowDecoration.BorderRadius = 12
        Me.gradient.ShadowDecoration.Enabled = True
        Me.gradient.ShadowDecoration.Parent = Me.gradient
        Me.gradient.Size = New System.Drawing.Size(372, 504)
        Me.gradient.TabIndex = 82
        '
        'bt_update
        '
        Me.bt_update.BorderRadius = 5
        Me.bt_update.CheckedState.Parent = Me.bt_update
        Me.bt_update.CustomImages.Parent = Me.bt_update
        Me.bt_update.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_update.DisabledState.Parent = Me.bt_update
        Me.bt_update.FillColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bt_update.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_update.ForeColor = System.Drawing.Color.White
        Me.bt_update.HoverState.Parent = Me.bt_update
        Me.bt_update.Image = CType(resources.GetObject("bt_update.Image"), System.Drawing.Image)
        Me.bt_update.Location = New System.Drawing.Point(32, 303)
        Me.bt_update.Name = "bt_update"
        Me.bt_update.ShadowDecoration.Parent = Me.bt_update
        Me.bt_update.Size = New System.Drawing.Size(305, 34)
        Me.bt_update.TabIndex = 54
        Me.bt_update.Text = "Update"
        '
        'tb_clear
        '
        Me.tb_clear.BorderRadius = 5
        Me.tb_clear.CheckedState.Parent = Me.tb_clear
        Me.tb_clear.CustomImages.Parent = Me.tb_clear
        Me.tb_clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.tb_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.tb_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.tb_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.tb_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.tb_clear.DisabledState.Parent = Me.tb_clear
        Me.tb_clear.FillColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.tb_clear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_clear.ForeColor = System.Drawing.Color.White
        Me.tb_clear.HoverState.Parent = Me.tb_clear
        Me.tb_clear.Image = CType(resources.GetObject("tb_clear.Image"), System.Drawing.Image)
        Me.tb_clear.Location = New System.Drawing.Point(32, 343)
        Me.tb_clear.Name = "tb_clear"
        Me.tb_clear.ShadowDecoration.Parent = Me.tb_clear
        Me.tb_clear.Size = New System.Drawing.Size(305, 33)
        Me.tb_clear.TabIndex = 53
        Me.tb_clear.Text = "Clear"
        '
        'lb_error
        '
        Me.lb_error.AutoSize = True
        Me.lb_error.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_error.ForeColor = System.Drawing.Color.Coral
        Me.lb_error.Location = New System.Drawing.Point(20, 50)
        Me.lb_error.Name = "lb_error"
        Me.lb_error.Size = New System.Drawing.Size(55, 18)
        Me.lb_error.TabIndex = 52
        Me.lb_error.Text = "$error"
        Me.lb_error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lb_error.Visible = False
        '
        'cb_level
        '
        Me.cb_level.BackColor = System.Drawing.Color.Transparent
        Me.cb_level.BorderRadius = 5
        Me.cb_level.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_level.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_level.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_level.FocusedState.Parent = Me.cb_level
        Me.cb_level.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cb_level.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_level.HoverState.Parent = Me.cb_level
        Me.cb_level.ItemHeight = 30
        Me.cb_level.Items.AddRange(New Object() {"Elementary", "Junior High School", "Senior High School", "College"})
        Me.cb_level.ItemsAppearance.Parent = Me.cb_level
        Me.cb_level.Location = New System.Drawing.Point(121, 217)
        Me.cb_level.MaxDropDownItems = 5
        Me.cb_level.Name = "cb_level"
        Me.cb_level.ShadowDecoration.Parent = Me.cb_level
        Me.cb_level.Size = New System.Drawing.Size(206, 36)
        Me.cb_level.StartIndex = 0
        Me.cb_level.TabIndex = 51
        '
        'tb_bname
        '
        Me.tb_bname.Animated = True
        Me.tb_bname.BorderRadius = 5
        Me.tb_bname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_bname.DefaultText = ""
        Me.tb_bname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_bname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_bname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_bname.DisabledState.Parent = Me.tb_bname
        Me.tb_bname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_bname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_bname.FocusedState.Parent = Me.tb_bname
        Me.tb_bname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_bname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_bname.HoverState.Parent = Me.tb_bname
        Me.tb_bname.Location = New System.Drawing.Point(121, 139)
        Me.tb_bname.Name = "tb_bname"
        Me.tb_bname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_bname.PlaceholderText = ""
        Me.tb_bname.SelectedText = ""
        Me.tb_bname.ShadowDecoration.Parent = Me.tb_bname
        Me.tb_bname.Size = New System.Drawing.Size(206, 33)
        Me.tb_bname.TabIndex = 46
        '
        'tb_bschid
        '
        Me.tb_bschid.Animated = True
        Me.tb_bschid.BorderRadius = 5
        Me.tb_bschid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_bschid.DefaultText = ""
        Me.tb_bschid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_bschid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_bschid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_bschid.DisabledState.Parent = Me.tb_bschid
        Me.tb_bschid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_bschid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_bschid.FocusedState.Parent = Me.tb_bschid
        Me.tb_bschid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_bschid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_bschid.HoverState.Parent = Me.tb_bschid
        Me.tb_bschid.Location = New System.Drawing.Point(121, 178)
        Me.tb_bschid.Name = "tb_bschid"
        Me.tb_bschid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_bschid.PlaceholderText = ""
        Me.tb_bschid.SelectedText = ""
        Me.tb_bschid.ShadowDecoration.Parent = Me.tb_bschid
        Me.tb_bschid.Size = New System.Drawing.Size(206, 33)
        Me.tb_bschid.TabIndex = 45
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(267, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(29, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "School ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(29, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Level:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Borrowers Info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Name:"
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2VSeparator1.FillThickness = 2
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(416, 40)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 504)
        Me.Guna2VSeparator1.TabIndex = 81
        '
        'item_container
        '
        Me.item_container.AutoScroll = True
        Me.item_container.BackColor = System.Drawing.Color.WhiteSmoke
        Me.item_container.Location = New System.Drawing.Point(443, 107)
        Me.item_container.Margin = New System.Windows.Forms.Padding(0)
        Me.item_container.Name = "item_container"
        Me.item_container.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.item_container.Size = New System.Drawing.Size(578, 437)
        Me.item_container.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(890, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Action"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(740, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 25)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Grade/Level"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(590, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 25)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "ID"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(443, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(147, 25)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Name"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(784, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Hint: Select Borrower to Edit or Remove"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(442, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 18)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "School ID:"
        '
        'tb_schid
        '
        Me.tb_schid.Animated = True
        Me.tb_schid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_schid.DefaultText = ""
        Me.tb_schid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_schid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_schid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_schid.DisabledState.Parent = Me.tb_schid
        Me.tb_schid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_schid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_schid.FocusedState.Parent = Me.tb_schid
        Me.tb_schid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_schid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_schid.HoverState.Parent = Me.tb_schid
        Me.tb_schid.Location = New System.Drawing.Point(534, 46)
        Me.tb_schid.Name = "tb_schid"
        Me.tb_schid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_schid.PlaceholderText = ""
        Me.tb_schid.SelectedText = ""
        Me.tb_schid.ShadowDecoration.Parent = Me.tb_schid
        Me.tb_schid.Size = New System.Drawing.Size(206, 33)
        Me.tb_schid.TabIndex = 59
        '
        'bt_searchfrombooklist
        '
        Me.bt_searchfrombooklist.BackColor = System.Drawing.Color.White
        Me.bt_searchfrombooklist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_searchfrombooklist.BorderRadius = 5
        Me.bt_searchfrombooklist.CheckedState.Parent = Me.bt_searchfrombooklist
        Me.bt_searchfrombooklist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_searchfrombooklist.CustomImages.Parent = Me.bt_searchfrombooklist
        Me.bt_searchfrombooklist.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_searchfrombooklist.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_searchfrombooklist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_searchfrombooklist.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_searchfrombooklist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_searchfrombooklist.DisabledState.Parent = Me.bt_searchfrombooklist
        Me.bt_searchfrombooklist.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.bt_searchfrombooklist.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_searchfrombooklist.ForeColor = System.Drawing.Color.White
        Me.bt_searchfrombooklist.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bt_searchfrombooklist.HoverState.Parent = Me.bt_searchfrombooklist
        Me.bt_searchfrombooklist.Image = CType(resources.GetObject("bt_searchfrombooklist.Image"), System.Drawing.Image)
        Me.bt_searchfrombooklist.Location = New System.Drawing.Point(746, 46)
        Me.bt_searchfrombooklist.Name = "bt_searchfrombooklist"
        Me.bt_searchfrombooklist.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_searchfrombooklist.ShadowDecoration.Parent = Me.bt_searchfrombooklist
        Me.bt_searchfrombooklist.Size = New System.Drawing.Size(35, 33)
        Me.bt_searchfrombooklist.TabIndex = 68
        '
        'BorrowerTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2ShadowPanel2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "BorrowerTab"
        Me.Size = New System.Drawing.Size(1069, 606)
        Me.Guna2ShadowPanel2.ResumeLayout(False)
        Me.Guna2ShadowPanel2.PerformLayout()
        Me.gradient.ResumeLayout(False)
        Me.gradient.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Public WithEvents item_container As FlowLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_schid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bt_searchfrombooklist As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gradient As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_bname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cb_level As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tb_bschid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lb_error As Label
    Friend WithEvents bt_update As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tb_clear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bt_reload As Guna.UI2.WinForms.Guna2Button
End Class
