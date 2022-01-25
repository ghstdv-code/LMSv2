<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class grid_item_transact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(grid_item_transact))
        Me.lb_bookname = New System.Windows.Forms.Label()
        Me.lb_isbn = New System.Windows.Forms.Label()
        Me.lb_author = New System.Windows.Forms.Label()
        Me.lb_publisher = New System.Windows.Forms.Label()
        Me.bt_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lb_bookname
        '
        Me.lb_bookname.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_bookname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lb_bookname.Location = New System.Drawing.Point(0, 0)
        Me.lb_bookname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_bookname.Name = "lb_bookname"
        Me.lb_bookname.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lb_bookname.Size = New System.Drawing.Size(184, 40)
        Me.lb_bookname.TabIndex = 45
        Me.lb_bookname.Text = "$name"
        Me.lb_bookname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_isbn
        '
        Me.lb_isbn.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_isbn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lb_isbn.Location = New System.Drawing.Point(183, 0)
        Me.lb_isbn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_isbn.Name = "lb_isbn"
        Me.lb_isbn.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lb_isbn.Size = New System.Drawing.Size(170, 40)
        Me.lb_isbn.TabIndex = 45
        Me.lb_isbn.Text = "$isbm"
        Me.lb_isbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_author
        '
        Me.lb_author.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_author.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lb_author.Location = New System.Drawing.Point(352, 0)
        Me.lb_author.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_author.Name = "lb_author"
        Me.lb_author.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lb_author.Size = New System.Drawing.Size(153, 40)
        Me.lb_author.TabIndex = 45
        Me.lb_author.Text = "$author"
        Me.lb_author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_publisher
        '
        Me.lb_publisher.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_publisher.ForeColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.lb_publisher.Location = New System.Drawing.Point(504, 0)
        Me.lb_publisher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_publisher.Name = "lb_publisher"
        Me.lb_publisher.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lb_publisher.Size = New System.Drawing.Size(180, 40)
        Me.lb_publisher.TabIndex = 45
        Me.lb_publisher.Text = "$publisher"
        Me.lb_publisher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.bt_delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_delete.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bt_delete.ForeColor = System.Drawing.Color.White
        Me.bt_delete.HoverState.Parent = Me.bt_delete
        Me.bt_delete.Image = CType(resources.GetObject("bt_delete.Image"), System.Drawing.Image)
        Me.bt_delete.Location = New System.Drawing.Point(727, 2)
        Me.bt_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.ShadowDecoration.Parent = Me.bt_delete
        Me.bt_delete.Size = New System.Drawing.Size(35, 35)
        Me.bt_delete.TabIndex = 46
        '
        'grid_item_transact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.bt_delete)
        Me.Controls.Add(Me.lb_publisher)
        Me.Controls.Add(Me.lb_author)
        Me.Controls.Add(Me.lb_isbn)
        Me.Controls.Add(Me.lb_bookname)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "grid_item_transact"
        Me.Size = New System.Drawing.Size(818, 40)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lb_bookname As Label
    Friend WithEvents lb_isbn As Label
    Friend WithEvents lb_author As Label
    Friend WithEvents lb_publisher As Label
    Friend WithEvents bt_delete As Guna.UI2.WinForms.Guna2Button
End Class
