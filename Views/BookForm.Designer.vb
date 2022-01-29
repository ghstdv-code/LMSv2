<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookForm))
        Me.header = New System.Windows.Forms.Panel()
        Me.lb_title = New System.Windows.Forms.Label()
        Me.border = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.shadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.lb_error = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Copies = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.tb_Publisher = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_Author = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_BookName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_condition = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_BookId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.img_box = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.bt_upload = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_save = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_clear = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_close = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.header.SuspendLayout()
        CType(Me.tb_Copies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_box, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.header.Size = New System.Drawing.Size(682, 30)
        Me.header.TabIndex = 2
        '
        'lb_title
        '
        Me.lb_title.AutoSize = True
        Me.lb_title.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_title.ForeColor = System.Drawing.Color.White
        Me.lb_title.Location = New System.Drawing.Point(34, 7)
        Me.lb_title.Name = "lb_title"
        Me.lb_title.Size = New System.Drawing.Size(41, 16)
        Me.lb_title.TabIndex = 1
        Me.lb_title.Text = "$title"
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
        'lb_error
        '
        Me.lb_error.AutoSize = True
        Me.lb_error.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_error.ForeColor = System.Drawing.Color.Red
        Me.lb_error.Location = New System.Drawing.Point(155, 47)
        Me.lb_error.Name = "lb_error"
        Me.lb_error.Size = New System.Drawing.Size(55, 18)
        Me.lb_error.TabIndex = 93
        Me.lb_error.Text = "$error"
        Me.lb_error.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lb_error.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Fill-up Details"
        '
        'tb_Copies
        '
        Me.tb_Copies.BackColor = System.Drawing.Color.Transparent
        Me.tb_Copies.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Copies.DisabledState.Parent = Me.tb_Copies
        Me.tb_Copies.FocusedState.Parent = Me.tb_Copies
        Me.tb_Copies.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tb_Copies.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tb_Copies.Location = New System.Drawing.Point(158, 240)
        Me.tb_Copies.Name = "tb_Copies"
        Me.tb_Copies.ShadowDecoration.Parent = Me.tb_Copies
        Me.tb_Copies.Size = New System.Drawing.Size(206, 33)
        Me.tb_Copies.TabIndex = 114
        Me.tb_Copies.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tb_Copies.UpDownButtonForeColor = System.Drawing.Color.White
        '
        'tb_Publisher
        '
        Me.tb_Publisher.Animated = True
        Me.tb_Publisher.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Publisher.DefaultText = ""
        Me.tb_Publisher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Publisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Publisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Publisher.DisabledState.Parent = Me.tb_Publisher
        Me.tb_Publisher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Publisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Publisher.FocusedState.Parent = Me.tb_Publisher
        Me.tb_Publisher.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Publisher.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Publisher.HoverState.Parent = Me.tb_Publisher
        Me.tb_Publisher.Location = New System.Drawing.Point(158, 201)
        Me.tb_Publisher.Name = "tb_Publisher"
        Me.tb_Publisher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Publisher.PlaceholderText = ""
        Me.tb_Publisher.SelectedText = ""
        Me.tb_Publisher.ShadowDecoration.Parent = Me.tb_Publisher
        Me.tb_Publisher.Size = New System.Drawing.Size(206, 33)
        Me.tb_Publisher.TabIndex = 102
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(31, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 18)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Copies:"
        '
        'tb_Author
        '
        Me.tb_Author.Animated = True
        Me.tb_Author.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_Author.DefaultText = ""
        Me.tb_Author.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_Author.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_Author.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Author.DisabledState.Parent = Me.tb_Author
        Me.tb_Author.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_Author.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Author.FocusedState.Parent = Me.tb_Author
        Me.tb_Author.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Author.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_Author.HoverState.Parent = Me.tb_Author
        Me.tb_Author.Location = New System.Drawing.Point(158, 162)
        Me.tb_Author.Name = "tb_Author"
        Me.tb_Author.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_Author.PlaceholderText = ""
        Me.tb_Author.SelectedText = ""
        Me.tb_Author.ShadowDecoration.Parent = Me.tb_Author
        Me.tb_Author.Size = New System.Drawing.Size(206, 33)
        Me.tb_Author.TabIndex = 103
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(31, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Publisher:"
        '
        'tb_BookName
        '
        Me.tb_BookName.Animated = True
        Me.tb_BookName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_BookName.DefaultText = ""
        Me.tb_BookName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_BookName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_BookName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_BookName.DisabledState.Parent = Me.tb_BookName
        Me.tb_BookName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_BookName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_BookName.FocusedState.Parent = Me.tb_BookName
        Me.tb_BookName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_BookName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_BookName.HoverState.Parent = Me.tb_BookName
        Me.tb_BookName.Location = New System.Drawing.Point(158, 123)
        Me.tb_BookName.Name = "tb_BookName"
        Me.tb_BookName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_BookName.PlaceholderText = ""
        Me.tb_BookName.SelectedText = ""
        Me.tb_BookName.ShadowDecoration.Parent = Me.tb_BookName
        Me.tb_BookName.Size = New System.Drawing.Size(206, 33)
        Me.tb_BookName.TabIndex = 104
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(31, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Author:"
        '
        'cb_condition
        '
        Me.cb_condition.BackColor = System.Drawing.Color.Transparent
        Me.cb_condition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_condition.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_condition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_condition.FocusedState.Parent = Me.cb_condition
        Me.cb_condition.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cb_condition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_condition.HoverState.Parent = Me.cb_condition
        Me.cb_condition.ItemHeight = 30
        Me.cb_condition.Items.AddRange(New Object() {"Fine (F)", "Near Fine (NF)", "Very Good (VG)", "Good (G)", "Fair (FR)", "Poor (P)"})
        Me.cb_condition.ItemsAppearance.Parent = Me.cb_condition
        Me.cb_condition.Location = New System.Drawing.Point(158, 279)
        Me.cb_condition.MaxDropDownItems = 5
        Me.cb_condition.Name = "cb_condition"
        Me.cb_condition.ShadowDecoration.Parent = Me.cb_condition
        Me.cb_condition.Size = New System.Drawing.Size(206, 36)
        Me.cb_condition.StartIndex = 0
        Me.cb_condition.TabIndex = 112
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(31, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Book Name:"
        '
        'tb_BookId
        '
        Me.tb_BookId.Animated = True
        Me.tb_BookId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_BookId.DefaultText = ""
        Me.tb_BookId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_BookId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_BookId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_BookId.DisabledState.Parent = Me.tb_BookId
        Me.tb_BookId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_BookId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_BookId.FocusedState.Parent = Me.tb_BookId
        Me.tb_BookId.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_BookId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_BookId.HoverState.Parent = Me.tb_BookId
        Me.tb_BookId.Location = New System.Drawing.Point(158, 84)
        Me.tb_BookId.Name = "tb_BookId"
        Me.tb_BookId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_BookId.PlaceholderText = ""
        Me.tb_BookId.SelectedText = ""
        Me.tb_BookId.ShadowDecoration.Parent = Me.tb_BookId
        Me.tb_BookId.Size = New System.Drawing.Size(206, 33)
        Me.tb_BookId.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(31, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Condition:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(31, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 18)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "ISBN/BOOK ID:"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 321)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(682, 10)
        Me.Guna2Separator1.TabIndex = 116
        '
        'img_box
        '
        Me.img_box.BackColor = System.Drawing.Color.Transparent
        Me.img_box.BorderRadius = 10
        Me.img_box.FillColor = System.Drawing.Color.Gray
        Me.img_box.ImageRotate = 0!
        Me.img_box.InitialImage = Nothing
        Me.img_box.Location = New System.Drawing.Point(382, 84)
        Me.img_box.Name = "img_box"
        Me.img_box.ShadowDecoration.Parent = Me.img_box
        Me.img_box.Size = New System.Drawing.Size(269, 192)
        Me.img_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_box.TabIndex = 115
        Me.img_box.TabStop = False
        '
        'bt_upload
        '
        Me.bt_upload.BackColor = System.Drawing.Color.White
        Me.bt_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bt_upload.BorderRadius = 5
        Me.bt_upload.CheckedState.Parent = Me.bt_upload
        Me.bt_upload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_upload.CustomImages.Parent = Me.bt_upload
        Me.bt_upload.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_upload.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_upload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_upload.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_upload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_upload.DisabledState.Parent = Me.bt_upload
        Me.bt_upload.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.bt_upload.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_upload.ForeColor = System.Drawing.Color.White
        Me.bt_upload.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.bt_upload.HoverState.Parent = Me.bt_upload
        Me.bt_upload.Image = CType(resources.GetObject("bt_upload.Image"), System.Drawing.Image)
        Me.bt_upload.Location = New System.Drawing.Point(382, 282)
        Me.bt_upload.Name = "bt_upload"
        Me.bt_upload.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_upload.ShadowDecoration.Parent = Me.bt_upload
        Me.bt_upload.Size = New System.Drawing.Size(269, 33)
        Me.bt_upload.TabIndex = 113
        Me.bt_upload.Text = "Upload Image"
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
        Me.bt_save.Location = New System.Drawing.Point(521, 337)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.ShadowDecoration.Parent = Me.bt_save
        Me.bt_save.Size = New System.Drawing.Size(130, 34)
        Me.bt_save.TabIndex = 92
        Me.bt_save.Text = "Save"
        '
        'bt_clear
        '
        Me.bt_clear.BorderRadius = 5
        Me.bt_clear.CheckedState.Parent = Me.bt_clear
        Me.bt_clear.CustomImages.Parent = Me.bt_clear
        Me.bt_clear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_clear.DisabledState.Parent = Me.bt_clear
        Me.bt_clear.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.bt_clear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_clear.ForeColor = System.Drawing.Color.White
        Me.bt_clear.HoverState.Parent = Me.bt_clear
        Me.bt_clear.Image = CType(resources.GetObject("bt_clear.Image"), System.Drawing.Image)
        Me.bt_clear.Location = New System.Drawing.Point(382, 337)
        Me.bt_clear.Name = "bt_clear"
        Me.bt_clear.ShadowDecoration.Parent = Me.bt_clear
        Me.bt_clear.Size = New System.Drawing.Size(130, 34)
        Me.bt_clear.TabIndex = 91
        Me.bt_clear.Text = "Clear"
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
        Me.bt_close.Location = New System.Drawing.Point(650, 0)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.PressedColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.bt_close.ShadowDecoration.Parent = Me.bt_close
        Me.bt_close.Size = New System.Drawing.Size(32, 30)
        Me.bt_close.TabIndex = 2
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
        'BookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(682, 386)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.img_box)
        Me.Controls.Add(Me.tb_Copies)
        Me.Controls.Add(Me.bt_upload)
        Me.Controls.Add(Me.tb_Publisher)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_Author)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tb_BookName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_condition)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_BookId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_error)
        Me.Controls.Add(Me.bt_save)
        Me.Controls.Add(Me.bt_clear)
        Me.Controls.Add(Me.header)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "BookForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BookForm"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.tb_Copies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As Panel
    Friend WithEvents bt_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lb_title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bt_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bt_clear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents border As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents shadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents lb_error As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents img_box As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents tb_Copies As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents bt_upload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tb_Publisher As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tb_Author As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_BookName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_condition As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_BookId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
