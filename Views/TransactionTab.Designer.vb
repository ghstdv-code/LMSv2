<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionTab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionTab))
        Me.Guna2ShadowPanel2 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.item_container = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tb_isbn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_reload = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_searchfrombooklist = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel2
        '
        Me.Guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel2.Controls.Add(Me.item_container)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label18)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label1)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label12)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label13)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label14)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label15)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label17)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label10)
        Me.Guna2ShadowPanel2.Controls.Add(Me.Label11)
        Me.Guna2ShadowPanel2.Controls.Add(Me.tb_isbn)
        Me.Guna2ShadowPanel2.Controls.Add(Me.bt_reload)
        Me.Guna2ShadowPanel2.Controls.Add(Me.bt_searchfrombooklist)
        Me.Guna2ShadowPanel2.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel2.Location = New System.Drawing.Point(12, 19)
        Me.Guna2ShadowPanel2.Name = "Guna2ShadowPanel2"
        Me.Guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel2.Size = New System.Drawing.Size(1044, 569)
        Me.Guna2ShadowPanel2.TabIndex = 2
        '
        'item_container
        '
        Me.item_container.AutoScroll = True
        Me.item_container.BackColor = System.Drawing.Color.WhiteSmoke
        Me.item_container.Location = New System.Drawing.Point(22, 123)
        Me.item_container.Margin = New System.Windows.Forms.Padding(0)
        Me.item_container.Name = "item_container"
        Me.item_container.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.item_container.Size = New System.Drawing.Size(1003, 428)
        Me.item_container.TabIndex = 74
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(893, 99)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 25)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Action"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(472, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(150, 25)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Issued Date"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(322, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 25)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Borrower"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(172, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 25)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Staff"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(22, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(150, 25)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "ISBN/Book ID"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(23, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(183, 18)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Transaction Transaction"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(17, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 25)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Transaction List"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(306, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 18)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "ISBN/BOOK ID:"
        '
        'tb_isbn
        '
        Me.tb_isbn.Animated = True
        Me.tb_isbn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_isbn.DefaultText = ""
        Me.tb_isbn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_isbn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_isbn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_isbn.DisabledState.Parent = Me.tb_isbn
        Me.tb_isbn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_isbn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_isbn.FocusedState.Parent = Me.tb_isbn
        Me.tb_isbn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_isbn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_isbn.HoverState.Parent = Me.tb_isbn
        Me.tb_isbn.Location = New System.Drawing.Point(433, 54)
        Me.tb_isbn.Name = "tb_isbn"
        Me.tb_isbn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_isbn.PlaceholderText = ""
        Me.tb_isbn.SelectedText = ""
        Me.tb_isbn.ShadowDecoration.Parent = Me.tb_isbn
        Me.tb_isbn.Size = New System.Drawing.Size(206, 33)
        Me.tb_isbn.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(622, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Due Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.bt_reload.Location = New System.Drawing.Point(877, 54)
        Me.bt_reload.Name = "bt_reload"
        Me.bt_reload.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_reload.ShadowDecoration.Parent = Me.bt_reload
        Me.bt_reload.Size = New System.Drawing.Size(148, 33)
        Me.bt_reload.TabIndex = 68
        Me.bt_reload.Text = "Reload"
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
        Me.bt_searchfrombooklist.Location = New System.Drawing.Point(645, 54)
        Me.bt_searchfrombooklist.Name = "bt_searchfrombooklist"
        Me.bt_searchfrombooklist.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bt_searchfrombooklist.ShadowDecoration.Parent = Me.bt_searchfrombooklist
        Me.bt_searchfrombooklist.Size = New System.Drawing.Size(35, 33)
        Me.bt_searchfrombooklist.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(772, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Status"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TransactionTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Guna2ShadowPanel2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "TransactionTab"
        Me.Size = New System.Drawing.Size(1069, 606)
        Me.Guna2ShadowPanel2.ResumeLayout(False)
        Me.Guna2ShadowPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2ShadowPanel2 As Guna.UI2.WinForms.Guna2ShadowPanel
    Public WithEvents item_container As FlowLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_isbn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bt_reload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bt_searchfrombooklist As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
