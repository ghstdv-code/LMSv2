<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddTransact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddTransact))
        Me.header = New System.Windows.Forms.Panel()
        Me.bt_close = New Guna.UI2.WinForms.Guna2Button()
        Me.lb_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tb_id = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb_level = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_School_Id = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.item_container = New System.Windows.Forms.FlowLayoutPanel()
        Me.lb_error = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_Name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtp_dueDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bt_save = New Guna.UI2.WinForms.Guna2Button()
        Me.tb_clear = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_check = New Guna.UI2.WinForms.Guna2Button()
        Me.border = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.shadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.header.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.header.Controls.Add(Me.bt_close)
        Me.header.Controls.Add(Me.lb_title)
        Me.header.Controls.Add(Me.PictureBox1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(845, 30)
        Me.header.TabIndex = 1
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.Color.Transparent
        Me.bt_close.BackgroundImage = CType(resources.GetObject("bt_close.BackgroundImage"), System.Drawing.Image)
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
        Me.bt_close.FillColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.bt_close.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_close.ForeColor = System.Drawing.Color.White
        Me.bt_close.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bt_close.HoverState.Parent = Me.bt_close
        Me.bt_close.Image = CType(resources.GetObject("bt_close.Image"), System.Drawing.Image)
        Me.bt_close.Location = New System.Drawing.Point(813, 0)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.PressedColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.bt_close.ShadowDecoration.Parent = Me.bt_close
        Me.bt_close.Size = New System.Drawing.Size(32, 30)
        Me.bt_close.TabIndex = 2
        '
        'lb_title
        '
        Me.lb_title.AutoSize = True
        Me.lb_title.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_title.ForeColor = System.Drawing.Color.White
        Me.lb_title.Location = New System.Drawing.Point(34, 7)
        Me.lb_title.Name = "lb_title"
        Me.lb_title.Size = New System.Drawing.Size(78, 16)
        Me.lb_title.TabIndex = 1
        Me.lb_title.Text = "Issue Book"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Separator1.FillThickness = 2
        Me.Guna2Separator1.Location = New System.Drawing.Point(16, 142)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(815, 10)
        Me.Guna2Separator1.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(700, 237)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 25)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Action"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(520, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(180, 25)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Publisher"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(367, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 25)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Author"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(197, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 25)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "ISBN/ID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 25)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Book Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_id
        '
        Me.tb_id.Animated = True
        Me.tb_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_id.DefaultText = ""
        Me.tb_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_id.DisabledState.Parent = Me.tb_id
        Me.tb_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_id.FocusedState.Parent = Me.tb_id
        Me.tb_id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_id.HoverState.Parent = Me.tb_id
        Me.tb_id.Location = New System.Drawing.Point(274, 191)
        Me.tb_id.Name = "tb_id"
        Me.tb_id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_id.PlaceholderText = ""
        Me.tb_id.SelectedText = ""
        Me.tb_id.ShadowDecoration.Parent = Me.tb_id
        Me.tb_id.Size = New System.Drawing.Size(257, 33)
        Me.tb_id.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(154, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 18)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "BOOK ID/ISBN:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(13, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Book Info"
        '
        'cb_level
        '
        Me.cb_level.BackColor = System.Drawing.Color.Transparent
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
        Me.cb_level.Location = New System.Drawing.Point(633, 82)
        Me.cb_level.MaxDropDownItems = 5
        Me.cb_level.Name = "cb_level"
        Me.cb_level.ShadowDecoration.Parent = Me.cb_level
        Me.cb_level.Size = New System.Drawing.Size(180, 36)
        Me.cb_level.StartIndex = 0
        Me.cb_level.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Borrowers Info"
        '
        'tb_School_Id
        '
        Me.tb_School_Id.Animated = True
        Me.tb_School_Id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_School_Id.DefaultText = ""
        Me.tb_School_Id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_School_Id.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_School_Id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_School_Id.DisabledState.Parent = Me.tb_School_Id
        Me.tb_School_Id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_School_Id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_School_Id.FocusedState.Parent = Me.tb_School_Id
        Me.tb_School_Id.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_School_Id.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_School_Id.HoverState.Parent = Me.tb_School_Id
        Me.tb_School_Id.Location = New System.Drawing.Point(391, 85)
        Me.tb_School_Id.Name = "tb_School_Id"
        Me.tb_School_Id.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_School_Id.PlaceholderText = ""
        Me.tb_School_Id.SelectedText = ""
        Me.tb_School_Id.ShadowDecoration.Parent = Me.tb_School_Id
        Me.tb_School_Id.Size = New System.Drawing.Size(177, 33)
        Me.tb_School_Id.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(574, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Level:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(299, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "School ID:"
        '
        'item_container
        '
        Me.item_container.BackColor = System.Drawing.Color.WhiteSmoke
        Me.item_container.Location = New System.Drawing.Point(13, 261)
        Me.item_container.Margin = New System.Windows.Forms.Padding(0)
        Me.item_container.Name = "item_container"
        Me.item_container.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.item_container.Size = New System.Drawing.Size(818, 170)
        Me.item_container.TabIndex = 50
        '
        'lb_error
        '
        Me.lb_error.AutoSize = True
        Me.lb_error.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_error.ForeColor = System.Drawing.Color.Red
        Me.lb_error.Location = New System.Drawing.Point(154, 48)
        Me.lb_error.Name = "lb_error"
        Me.lb_error.Size = New System.Drawing.Size(55, 18)
        Me.lb_error.TabIndex = 44
        Me.lb_error.Text = "$error"
        Me.lb_error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lb_error.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 18)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Name:"
        '
        'tb_Name
        '
        Me.tb_Name.Animated = True
        Me.tb_Name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Name.DefaultText = ""
        Me.tb_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Name.DisabledState.Parent = Me.tb_Name
        Me.tb_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Name.FocusedState.Parent = Me.tb_Name
        Me.tb_Name.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Name.HoverState.Parent = Me.tb_Name
        Me.tb_Name.Location = New System.Drawing.Point(87, 85)
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Name.PlaceholderText = ""
        Me.tb_Name.SelectedText = ""
        Me.tb_Name.ShadowDecoration.Parent = Me.tb_Name
        Me.tb_Name.Size = New System.Drawing.Size(206, 33)
        Me.tb_Name.TabIndex = 30
        '
        'dtp_dueDate
        '
        Me.dtp_dueDate.BorderRadius = 5
        Me.dtp_dueDate.Checked = True
        Me.dtp_dueDate.CheckedState.Parent = Me.dtp_dueDate
        Me.dtp_dueDate.FillColor = System.Drawing.Color.White
        Me.dtp_dueDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_dueDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.dtp_dueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtp_dueDate.HoverState.Parent = Me.dtp_dueDate
        Me.dtp_dueDate.Location = New System.Drawing.Point(103, 438)
        Me.dtp_dueDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_dueDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_dueDate.Name = "dtp_dueDate"
        Me.dtp_dueDate.ShadowDecoration.Parent = Me.dtp_dueDate
        Me.dtp_dueDate.Size = New System.Drawing.Size(250, 33)
        Me.dtp_dueDate.TabIndex = 53
        Me.dtp_dueDate.Value = New Date(2022, 1, 27, 12, 14, 38, 339)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(13, 446)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 18)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Due Date:"
        '
        'bt_save
        '
        Me.bt_save.BorderRadius = 5
        Me.bt_save.CheckedState.Parent = Me.bt_save
        Me.bt_save.CustomImages.Parent = Me.bt_save
        Me.bt_save.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_save.DisabledState.Parent = Me.bt_save
        Me.bt_save.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.bt_save.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_save.ForeColor = System.Drawing.Color.White
        Me.bt_save.HoverState.Parent = Me.bt_save
        Me.bt_save.Image = CType(resources.GetObject("bt_save.Image"), System.Drawing.Image)
        Me.bt_save.Location = New System.Drawing.Point(680, 437)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.ShadowDecoration.Parent = Me.bt_save
        Me.bt_save.Size = New System.Drawing.Size(151, 34)
        Me.bt_save.TabIndex = 49
        Me.bt_save.Text = "Save"
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
        Me.tb_clear.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tb_clear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_clear.ForeColor = System.Drawing.Color.White
        Me.tb_clear.HoverState.Parent = Me.tb_clear
        Me.tb_clear.Image = CType(resources.GetObject("tb_clear.Image"), System.Drawing.Image)
        Me.tb_clear.Location = New System.Drawing.Point(523, 438)
        Me.tb_clear.Name = "tb_clear"
        Me.tb_clear.ShadowDecoration.Parent = Me.tb_clear
        Me.tb_clear.Size = New System.Drawing.Size(151, 33)
        Me.tb_clear.TabIndex = 48
        Me.tb_clear.Text = "Clear"
        '
        'bt_check
        '
        Me.bt_check.BackColor = System.Drawing.Color.White
        Me.bt_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_check.BorderRadius = 5
        Me.bt_check.CheckedState.Parent = Me.bt_check
        Me.bt_check.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_check.CustomImages.Parent = Me.bt_check
        Me.bt_check.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_check.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_check.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_check.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_check.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_check.DisabledState.Parent = Me.bt_check
        Me.bt_check.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.bt_check.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.bt_check.ForeColor = System.Drawing.Color.White
        Me.bt_check.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bt_check.HoverState.Parent = Me.bt_check
        Me.bt_check.Image = CType(resources.GetObject("bt_check.Image"), System.Drawing.Image)
        Me.bt_check.Location = New System.Drawing.Point(537, 191)
        Me.bt_check.Name = "bt_check"
        Me.bt_check.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_check.ShadowDecoration.Parent = Me.bt_check
        Me.bt_check.Size = New System.Drawing.Size(130, 33)
        Me.bt_check.TabIndex = 45
        Me.bt_check.Text = "Validate/Add"
        '
        'border
        '
        Me.border.BorderRadius = 10
        Me.border.TargetControl = Me
        '
        'shadow
        '
        Me.shadow.TargetForm = Me
        '
        'AddTransact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(845, 491)
        Me.Controls.Add(Me.dtp_dueDate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.item_container)
        Me.Controls.Add(Me.bt_save)
        Me.Controls.Add(Me.tb_clear)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bt_check)
        Me.Controls.Add(Me.tb_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lb_error)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_Name)
        Me.Controls.Add(Me.cb_level)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_School_Id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.header)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddTransact"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddTransact"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As Panel
    Friend WithEvents bt_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lb_title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bt_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tb_clear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bt_check As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tb_id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_level As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_School_Id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents item_container As FlowLayoutPanel
    Friend WithEvents lb_error As Label
    Friend WithEvents dtp_dueDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents tb_Name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents border As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents shadow As Guna.UI2.WinForms.Guna2ShadowForm
End Class
