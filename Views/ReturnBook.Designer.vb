<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnBook))
        Me.header = New System.Windows.Forms.Panel()
        Me.bt_close = New Guna.UI2.WinForms.Guna2Button()
        Me.lb_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.border = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.shadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.item_container = New System.Windows.Forms.FlowLayoutPanel()
        Me.bt_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_check = New Guna.UI2.WinForms.Guna2Button()
        Me.tb_studID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.header.TabIndex = 2
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
        Me.lb_title.Size = New System.Drawing.Size(86, 16)
        Me.lb_title.TabIndex = 1
        Me.lb_title.Text = "Return Book"
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
        'border
        '
        Me.border.BorderRadius = 10
        Me.border.TargetControl = Me
        '
        'shadow
        '
        Me.shadow.TargetForm = Me
        '
        'item_container
        '
        Me.item_container.BackColor = System.Drawing.Color.WhiteSmoke
        Me.item_container.Location = New System.Drawing.Point(13, 115)
        Me.item_container.Margin = New System.Windows.Forms.Padding(0)
        Me.item_container.Name = "item_container"
        Me.item_container.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.item_container.Size = New System.Drawing.Size(818, 170)
        Me.item_container.TabIndex = 65
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
        Me.bt_save.Location = New System.Drawing.Point(680, 291)
        Me.bt_save.Name = "bt_save"
        Me.bt_save.ShadowDecoration.Parent = Me.bt_save
        Me.bt_save.Size = New System.Drawing.Size(151, 34)
        Me.bt_save.TabIndex = 64
        Me.bt_save.Text = "Update"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(700, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 25)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Action"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(520, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(180, 25)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Due Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(367, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 25)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Issued Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(197, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 25)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "ISBN/ID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 25)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Book Name"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.bt_check.Location = New System.Drawing.Point(537, 45)
        Me.bt_check.Name = "bt_check"
        Me.bt_check.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_check.ShadowDecoration.Parent = Me.bt_check
        Me.bt_check.Size = New System.Drawing.Size(130, 33)
        Me.bt_check.TabIndex = 62
        Me.bt_check.Text = "Find"
        '
        'tb_studID
        '
        Me.tb_studID.Animated = True
        Me.tb_studID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.tb_studID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.tb_studID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_studID.DefaultText = ""
        Me.tb_studID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_studID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_studID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_studID.DisabledState.Parent = Me.tb_studID
        Me.tb_studID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_studID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_studID.FocusedState.Parent = Me.tb_studID
        Me.tb_studID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_studID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_studID.HoverState.Parent = Me.tb_studID
        Me.tb_studID.Location = New System.Drawing.Point(274, 45)
        Me.tb_studID.Name = "tb_studID"
        Me.tb_studID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_studID.PlaceholderText = ""
        Me.tb_studID.SelectedText = ""
        Me.tb_studID.ShadowDecoration.Parent = Me.tb_studID
        Me.tb_studID.Size = New System.Drawing.Size(257, 33)
        Me.tb_studID.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(182, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 18)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "School ID:"
        '
        'ReturnBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(845, 341)
        Me.Controls.Add(Me.item_container)
        Me.Controls.Add(Me.bt_save)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bt_check)
        Me.Controls.Add(Me.tb_studID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.header)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ReturnBook"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReturnBook"
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
    Friend WithEvents border As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents shadow As Guna.UI2.WinForms.Guna2ShadowForm
    Public WithEvents item_container As FlowLayoutPanel
    Friend WithEvents bt_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bt_check As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tb_studID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
End Class
