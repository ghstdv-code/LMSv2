<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rt_grid_item
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rt_grid_item))
        Me.bt_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.lb_duedate = New System.Windows.Forms.Label()
        Me.lb_issued = New System.Windows.Forms.Label()
        Me.lb_isbn = New System.Windows.Forms.Label()
        Me.lb_bookname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bt_delete
        '
        Me.bt_delete.BorderRadius = 5
        Me.bt_delete.CheckedState.Parent = Me.bt_delete
        Me.bt_delete.CustomImages.Parent = Me.bt_delete
        Me.bt_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bt_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bt_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bt_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bt_delete.DisabledState.Parent = Me.bt_delete
        Me.bt_delete.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.bt_delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_delete.ForeColor = System.Drawing.Color.White
        Me.bt_delete.HoverState.Parent = Me.bt_delete
        Me.bt_delete.Image = CType(resources.GetObject("bt_delete.Image"), System.Drawing.Image)
        Me.bt_delete.Location = New System.Drawing.Point(755, 2)
        Me.bt_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.ShadowDecoration.Parent = Me.bt_delete
        Me.bt_delete.Size = New System.Drawing.Size(35, 35)
        Me.bt_delete.TabIndex = 51
        '
        'lb_duedate
        '
        Me.lb_duedate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_duedate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lb_duedate.Location = New System.Drawing.Point(532, 0)
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
        Me.lb_issued.Location = New System.Drawing.Point(380, 0)
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
        Me.lb_isbn.Location = New System.Drawing.Point(211, 0)
        Me.lb_isbn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_isbn.Name = "lb_isbn"
        Me.lb_isbn.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lb_isbn.Size = New System.Drawing.Size(170, 40)
        Me.lb_isbn.TabIndex = 49
        Me.lb_isbn.Text = "$isbm"
        Me.lb_isbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_bookname
        '
        Me.lb_bookname.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_bookname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lb_bookname.Location = New System.Drawing.Point(28, 0)
        Me.lb_bookname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_bookname.Name = "lb_bookname"
        Me.lb_bookname.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lb_bookname.Size = New System.Drawing.Size(184, 40)
        Me.lb_bookname.TabIndex = 50
        Me.lb_bookname.Text = "$name"
        Me.lb_bookname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rt_grid_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bt_delete)
        Me.Controls.Add(Me.lb_duedate)
        Me.Controls.Add(Me.lb_issued)
        Me.Controls.Add(Me.lb_isbn)
        Me.Controls.Add(Me.lb_bookname)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "rt_grid_item"
        Me.Size = New System.Drawing.Size(818, 40)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bt_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lb_duedate As Label
    Friend WithEvents lb_issued As Label
    Friend WithEvents lb_isbn As Label
    Friend WithEvents lb_bookname As Label
End Class
