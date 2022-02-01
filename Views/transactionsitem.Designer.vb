<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactionsitem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transactionsitem))
        Me.bt_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.lb_status = New System.Windows.Forms.Label()
        Me.lb_due = New System.Windows.Forms.Label()
        Me.lb_isssued = New System.Windows.Forms.Label()
        Me.lb_borrower = New System.Windows.Forms.Label()
        Me.lb_staff = New System.Windows.Forms.Label()
        Me.lb_isbn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.bt_delete.Location = New System.Drawing.Point(906, 3)
        Me.bt_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.bt_delete.Name = "bt_delete"
        Me.bt_delete.ShadowDecoration.Parent = Me.bt_delete
        Me.bt_delete.Size = New System.Drawing.Size(35, 35)
        Me.bt_delete.TabIndex = 80
        '
        'lb_status
        '
        Me.lb_status.BackColor = System.Drawing.Color.Transparent
        Me.lb_status.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_status.ForeColor = System.Drawing.Color.Gray
        Me.lb_status.Location = New System.Drawing.Point(750, 0)
        Me.lb_status.Name = "lb_status"
        Me.lb_status.Size = New System.Drawing.Size(121, 40)
        Me.lb_status.TabIndex = 82
        Me.lb_status.Text = "Status"
        Me.lb_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_due
        '
        Me.lb_due.BackColor = System.Drawing.Color.Transparent
        Me.lb_due.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_due.ForeColor = System.Drawing.Color.Gray
        Me.lb_due.Location = New System.Drawing.Point(600, 0)
        Me.lb_due.Name = "lb_due"
        Me.lb_due.Size = New System.Drawing.Size(150, 40)
        Me.lb_due.TabIndex = 83
        Me.lb_due.Text = "Due Date"
        Me.lb_due.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_isssued
        '
        Me.lb_isssued.BackColor = System.Drawing.Color.Transparent
        Me.lb_isssued.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_isssued.ForeColor = System.Drawing.Color.Gray
        Me.lb_isssued.Location = New System.Drawing.Point(450, 0)
        Me.lb_isssued.Name = "lb_isssued"
        Me.lb_isssued.Size = New System.Drawing.Size(150, 40)
        Me.lb_isssued.TabIndex = 84
        Me.lb_isssued.Text = "Issued Date"
        Me.lb_isssued.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_borrower
        '
        Me.lb_borrower.BackColor = System.Drawing.Color.Transparent
        Me.lb_borrower.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_borrower.ForeColor = System.Drawing.Color.Gray
        Me.lb_borrower.Location = New System.Drawing.Point(300, 0)
        Me.lb_borrower.Name = "lb_borrower"
        Me.lb_borrower.Size = New System.Drawing.Size(150, 40)
        Me.lb_borrower.TabIndex = 85
        Me.lb_borrower.Text = "Borrower"
        Me.lb_borrower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_staff
        '
        Me.lb_staff.BackColor = System.Drawing.Color.Transparent
        Me.lb_staff.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_staff.ForeColor = System.Drawing.Color.Gray
        Me.lb_staff.Location = New System.Drawing.Point(150, 0)
        Me.lb_staff.Name = "lb_staff"
        Me.lb_staff.Size = New System.Drawing.Size(150, 40)
        Me.lb_staff.TabIndex = 86
        Me.lb_staff.Text = "Staff"
        Me.lb_staff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_isbn
        '
        Me.lb_isbn.BackColor = System.Drawing.Color.Transparent
        Me.lb_isbn.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_isbn.ForeColor = System.Drawing.Color.Gray
        Me.lb_isbn.Location = New System.Drawing.Point(0, 0)
        Me.lb_isbn.Name = "lb_isbn"
        Me.lb_isbn.Size = New System.Drawing.Size(150, 40)
        Me.lb_isbn.TabIndex = 87
        Me.lb_isbn.Text = "ISBN/Book ID"
        Me.lb_isbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'transactionsitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lb_status)
        Me.Controls.Add(Me.lb_due)
        Me.Controls.Add(Me.lb_isssued)
        Me.Controls.Add(Me.lb_borrower)
        Me.Controls.Add(Me.lb_staff)
        Me.Controls.Add(Me.lb_isbn)
        Me.Controls.Add(Me.bt_delete)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "transactionsitem"
        Me.Size = New System.Drawing.Size(965, 40)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lb_status As Label
    Friend WithEvents lb_due As Label
    Friend WithEvents lb_isssued As Label
    Friend WithEvents lb_borrower As Label
    Friend WithEvents lb_staff As Label
    Friend WithEvents lb_isbn As Label
End Class
