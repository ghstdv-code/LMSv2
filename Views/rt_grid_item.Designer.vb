<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rt_grid_item
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rt_grid_item))
        Me.bt_return = New Guna.UI2.WinForms.Guna2Button()
        Me.lb_duedate = New System.Windows.Forms.Label()
        Me.lb_issued = New System.Windows.Forms.Label()
        Me.lb_isbn = New System.Windows.Forms.Label()
        Me.cb_level = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'bt_return
        '
        Me.bt_return.BorderRadius = 5
        Me.bt_return.CheckedState.Parent = Me.bt_return
        Me.bt_return.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_return.CustomImages.Parent = Me.bt_return
        Me.bt_return.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_return.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_return.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_return.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_return.DisabledState.Parent = Me.bt_return
        Me.bt_return.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.bt_return.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_return.ForeColor = System.Drawing.Color.White
        Me.bt_return.HoverState.Parent = Me.bt_return
        Me.bt_return.Image = CType(resources.GetObject("bt_return.Image"), System.Drawing.Image)
        Me.bt_return.Location = New System.Drawing.Point(734, 3)
        Me.bt_return.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bt_return.Name = "bt_return"
        Me.bt_return.ShadowDecoration.Parent = Me.bt_return
        Me.bt_return.Size = New System.Drawing.Size(35, 35)
        Me.bt_return.TabIndex = 51
        '
        'lb_duedate
        '
        Me.lb_duedate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_duedate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lb_duedate.Location = New System.Drawing.Point(322, 0)
        Me.lb_duedate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_duedate.Name = "lb_duedate"
        Me.lb_duedate.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lb_duedate.Size = New System.Drawing.Size(180, 40)
        Me.lb_duedate.TabIndex = 47
        Me.lb_duedate.Text = "$duedate"
        Me.lb_duedate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_issued
        '
        Me.lb_issued.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_issued.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lb_issued.Location = New System.Drawing.Point(170, 0)
        Me.lb_issued.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_issued.Name = "lb_issued"
        Me.lb_issued.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lb_issued.Size = New System.Drawing.Size(153, 40)
        Me.lb_issued.TabIndex = 48
        Me.lb_issued.Text = "$issuedate"
        Me.lb_issued.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_isbn
        '
        Me.lb_isbn.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_isbn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lb_isbn.Location = New System.Drawing.Point(1, 0)
        Me.lb_isbn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_isbn.Name = "lb_isbn"
        Me.lb_isbn.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lb_isbn.Size = New System.Drawing.Size(170, 40)
        Me.lb_isbn.TabIndex = 49
        Me.lb_isbn.Text = "$isbm"
        Me.lb_isbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cb_level
        '
        Me.cb_level.BackColor = System.Drawing.Color.Transparent
        Me.cb_level.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_level.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_level.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb_level.FocusedState.Parent = Me.cb_level
        Me.cb_level.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_level.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cb_level.HoverState.Parent = Me.cb_level
        Me.cb_level.ItemHeight = 30
        Me.cb_level.Items.AddRange(New Object() {"Fine (F)", "Near Fine (NF)", "Very Good (VG)", "Good (G)", "Fair (FR)", "Poor (P)"})
        Me.cb_level.ItemsAppearance.Parent = Me.cb_level
        Me.cb_level.Location = New System.Drawing.Point(523, 2)
        Me.cb_level.MaxDropDownItems = 5
        Me.cb_level.Name = "cb_level"
        Me.cb_level.ShadowDecoration.Parent = Me.cb_level
        Me.cb_level.Size = New System.Drawing.Size(160, 36)
        Me.cb_level.StartIndex = 0
        Me.cb_level.TabIndex = 52
        '
        'rt_grid_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cb_level)
        Me.Controls.Add(Me.bt_return)
        Me.Controls.Add(Me.lb_duedate)
        Me.Controls.Add(Me.lb_issued)
        Me.Controls.Add(Me.lb_isbn)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "rt_grid_item"
        Me.Size = New System.Drawing.Size(789, 40)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bt_return As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lb_duedate As Label
    Friend WithEvents lb_issued As Label
    Friend WithEvents lb_isbn As Label
    Friend WithEvents cb_level As Guna.UI2.WinForms.Guna2ComboBox
End Class
