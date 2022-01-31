<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borroweritems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(borroweritems))
        Me.lb_glevel = New System.Windows.Forms.Label()
        Me.lb_id = New System.Windows.Forms.Label()
        Me.lb_name = New System.Windows.Forms.Label()
        Me.bt_view = New Guna.UI2.WinForms.Guna2Button()
        Me.bt_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lb_glevel
        '
        Me.lb_glevel.BackColor = System.Drawing.Color.Transparent
        Me.lb_glevel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_glevel.ForeColor = System.Drawing.Color.DimGray
        Me.lb_glevel.Location = New System.Drawing.Point(297, 0)
        Me.lb_glevel.Name = "lb_glevel"
        Me.lb_glevel.Size = New System.Drawing.Size(150, 40)
        Me.lb_glevel.TabIndex = 75
        Me.lb_glevel.Text = "Grade/Level"
        Me.lb_glevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_id
        '
        Me.lb_id.BackColor = System.Drawing.Color.Transparent
        Me.lb_id.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_id.ForeColor = System.Drawing.Color.DimGray
        Me.lb_id.Location = New System.Drawing.Point(147, 0)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(150, 40)
        Me.lb_id.TabIndex = 76
        Me.lb_id.Text = "ID"
        Me.lb_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_name
        '
        Me.lb_name.BackColor = System.Drawing.Color.Transparent
        Me.lb_name.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_name.ForeColor = System.Drawing.Color.DimGray
        Me.lb_name.Location = New System.Drawing.Point(0, 0)
        Me.lb_name.Name = "lb_name"
        Me.lb_name.Size = New System.Drawing.Size(147, 40)
        Me.lb_name.TabIndex = 77
        Me.lb_name.Text = "Name"
        Me.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_view
        '
        Me.bt_view.BorderRadius = 5
        Me.bt_view.CheckedState.Parent = Me.bt_view
        Me.bt_view.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_view.CustomImages.Parent = Me.bt_view
        Me.bt_view.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_view.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_view.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_view.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_view.DisabledState.Parent = Me.bt_view
        Me.bt_view.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.bt_view.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_view.ForeColor = System.Drawing.Color.White
        Me.bt_view.HoverState.Parent = Me.bt_view
        Me.bt_view.Image = CType(resources.GetObject("bt_view.Image"), System.Drawing.Image)
        Me.bt_view.Location = New System.Drawing.Point(463, 3)
        Me.bt_view.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bt_view.Name = "bt_view"
        Me.bt_view.ShadowDecoration.Parent = Me.bt_view
        Me.bt_view.Size = New System.Drawing.Size(35, 35)
        Me.bt_view.TabIndex = 78
        '
        'bt_delete
        '
        Me.bt_delete.BorderRadius = 5
        Me.bt_delete.CheckedState.Parent = Me.bt_delete
        Me.bt_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_delete.CustomImages.Parent = Me.bt_delete
        Me.bt_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_delete.DisabledState.Parent = Me.bt_delete
        Me.bt_delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_delete.ForeColor = System.Drawing.Color.White
        Me.bt_delete.HoverState.Parent = Me.bt_delete
        Me.bt_delete.Image = CType(resources.GetObject("bt_delete.Image"), System.Drawing.Image)
        Me.bt_delete.Location = New System.Drawing.Point(505, 3)
        Me.bt_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.ShadowDecoration.Parent = Me.bt_delete
        Me.bt_delete.Size = New System.Drawing.Size(35, 35)
        Me.bt_delete.TabIndex = 79
        '
        'borroweritems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bt_view)
        Me.Controls.Add(Me.bt_delete)
        Me.Controls.Add(Me.lb_glevel)
        Me.Controls.Add(Me.lb_id)
        Me.Controls.Add(Me.lb_name)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "borroweritems"
        Me.Size = New System.Drawing.Size(544, 40)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lb_glevel As Label
    Friend WithEvents lb_id As Label
    Friend WithEvents lb_name As Label
    Friend WithEvents bt_view As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bt_delete As Guna.UI2.WinForms.Guna2Button
End Class
