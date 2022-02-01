<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.border = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tb_uname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tb_pass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bt_close = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Login = New Guna.UI2.WinForms.Guna2Button()
        Me.lb_error = New System.Windows.Forms.Label()
        Me.shadow = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.drag = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'border
        '
        Me.border.BorderRadius = 10
        Me.border.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 456)
        Me.Panel1.TabIndex = 0
        '
        'tb_uname
        '
        Me.tb_uname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_uname.DefaultText = ""
        Me.tb_uname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_uname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_uname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_uname.DisabledState.Parent = Me.tb_uname
        Me.tb_uname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_uname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_uname.FocusedState.Parent = Me.tb_uname
        Me.tb_uname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_uname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_uname.HoverState.Parent = Me.tb_uname
        Me.tb_uname.IconLeft = CType(resources.GetObject("tb_uname.IconLeft"), System.Drawing.Image)
        Me.tb_uname.Location = New System.Drawing.Point(275, 190)
        Me.tb_uname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_uname.Name = "tb_uname"
        Me.tb_uname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tb_uname.PlaceholderText = "Username"
        Me.tb_uname.SelectedText = ""
        Me.tb_uname.ShadowDecoration.Parent = Me.tb_uname
        Me.tb_uname.Size = New System.Drawing.Size(229, 48)
        Me.tb_uname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.tb_uname.TabIndex = 0
        '
        'tb_pass
        '
        Me.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pass.DefaultText = ""
        Me.tb_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tb_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tb_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_pass.DisabledState.Parent = Me.tb_pass
        Me.tb_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tb_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_pass.FocusedState.Parent = Me.tb_pass
        Me.tb_pass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tb_pass.HoverState.Parent = Me.tb_pass
        Me.tb_pass.IconLeft = CType(resources.GetObject("tb_pass.IconLeft"), System.Drawing.Image)
        Me.tb_pass.Location = New System.Drawing.Point(275, 246)
        Me.tb_pass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_pass.Name = "tb_pass"
        Me.tb_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tb_pass.PlaceholderText = "Password"
        Me.tb_pass.SelectedText = ""
        Me.tb_pass.ShadowDecoration.Parent = Me.tb_pass
        Me.tb_pass.Size = New System.Drawing.Size(229, 48)
        Me.tb_pass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.tb_pass.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(360, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 25)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(335, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'bt_close
        '
        Me.bt_close.CheckedState.Parent = Me.bt_close
        Me.bt_close.CustomImages.Parent = Me.bt_close
        Me.bt_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_close.DisabledState.Parent = Me.bt_close
        Me.bt_close.FillColor = System.Drawing.Color.Transparent
        Me.bt_close.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_close.ForeColor = System.Drawing.Color.White
        Me.bt_close.HoverState.Parent = Me.bt_close
        Me.bt_close.Image = CType(resources.GetObject("bt_close.Image"), System.Drawing.Image)
        Me.bt_close.Location = New System.Drawing.Point(516, 0)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.PressedColor = System.Drawing.Color.SlateBlue
        Me.bt_close.ShadowDecoration.Parent = Me.bt_close
        Me.bt_close.Size = New System.Drawing.Size(30, 30)
        Me.bt_close.TabIndex = 89
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.White
        Me.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_Login.BorderRadius = 5
        Me.btn_Login.CheckedState.Parent = Me.btn_Login
        Me.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Login.CustomImages.Parent = Me.btn_Login
        Me.btn_Login.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Login.DisabledState.Parent = Me.btn_Login
        Me.btn_Login.FillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btn_Login.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Login.ForeColor = System.Drawing.Color.White
        Me.btn_Login.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btn_Login.HoverState.Parent = Me.btn_Login
        Me.btn_Login.Location = New System.Drawing.Point(271, 323)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.PressedColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Login.ShadowDecoration.Parent = Me.btn_Login
        Me.btn_Login.Size = New System.Drawing.Size(233, 45)
        Me.btn_Login.TabIndex = 90
        Me.btn_Login.Text = "Sign In"
        '
        'lb_error
        '
        Me.lb_error.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_error.ForeColor = System.Drawing.Color.Red
        Me.lb_error.Location = New System.Drawing.Point(237, 156)
        Me.lb_error.Name = "lb_error"
        Me.lb_error.Size = New System.Drawing.Size(298, 18)
        Me.lb_error.TabIndex = 91
        Me.lb_error.Text = "$error"
        Me.lb_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lb_error.Visible = False
        '
        'shadow
        '
        Me.shadow.TargetForm = Me
        '
        'drag
        '
        Me.drag.DockIndicatorTransparencyValue = 0.6R
        Me.drag.TargetControl = Me
        Me.drag.UseTransparentDrag = True
        '
        'Login
        '
        Me.AcceptButton = Me.btn_Login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(547, 456)
        Me.Controls.Add(Me.lb_error)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tb_pass)
        Me.Controls.Add(Me.tb_uname)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(547, 456)
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents border As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents tb_uname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tb_pass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bt_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lb_error As Label
    Friend WithEvents shadow As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents drag As Guna.UI2.WinForms.Guna2DragControl
End Class
