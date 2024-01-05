<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExpenseList
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelRegistration = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.quan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itemid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.aytem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prays = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clr = New System.Windows.Forms.Button()
        Me.registerbtn2 = New System.Windows.Forms.Button()
        Me.equals = New System.Windows.Forms.Label()
        Me.sum = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.LabelRegistration)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(573, 46)
        Me.Panel2.TabIndex = 5
        '
        'LabelRegistration
        '
        Me.LabelRegistration.AutoSize = True
        Me.LabelRegistration.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegistration.ForeColor = System.Drawing.Color.White
        Me.LabelRegistration.Location = New System.Drawing.Point(7, 9)
        Me.LabelRegistration.Name = "LabelRegistration"
        Me.LabelRegistration.Size = New System.Drawing.Size(197, 25)
        Me.LabelRegistration.TabIndex = 0
        Me.LabelRegistration.Text = "Manage Expense List"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 242)
        Me.Panel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.sum)
        Me.Panel3.Controls.Add(Me.equals)
        Me.Panel3.Controls.Add(Me.quan)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.itemid)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.aytem)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.prays)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.clr)
        Me.Panel3.Controls.Add(Me.registerbtn2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(571, 241)
        Me.Panel3.TabIndex = 0
        '
        'quan
        '
        Me.quan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quan.Location = New System.Drawing.Point(209, 148)
        Me.quan.Multiline = True
        Me.quan.Name = "quan"
        Me.quan.Size = New System.Drawing.Size(81, 27)
        Me.quan.TabIndex = 2
        Me.quan.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Quantity:"
        '
        'itemid
        '
        Me.itemid.AutoSize = True
        Me.itemid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemid.Location = New System.Drawing.Point(207, 60)
        Me.itemid.Name = "itemid"
        Me.itemid.Size = New System.Drawing.Size(16, 17)
        Me.itemid.TabIndex = 55
        Me.itemid.Text = "#"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(141, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Item No:"
        '
        'aytem
        '
        Me.aytem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aytem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aytem.Location = New System.Drawing.Point(209, 83)
        Me.aytem.Multiline = True
        Me.aytem.Name = "aytem"
        Me.aytem.Size = New System.Drawing.Size(189, 26)
        Me.aytem.TabIndex = 0
        Me.aytem.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(163, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Item:"
        '
        'prays
        '
        Me.prays.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prays.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prays.Location = New System.Drawing.Point(210, 115)
        Me.prays.Multiline = True
        Me.prays.Name = "prays"
        Me.prays.Size = New System.Drawing.Size(142, 27)
        Me.prays.TabIndex = 1
        Me.prays.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(163, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Price:"
        '
        'clr
        '
        Me.clr.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clr.Location = New System.Drawing.Point(315, 192)
        Me.clr.Name = "clr"
        Me.clr.Size = New System.Drawing.Size(143, 37)
        Me.clr.TabIndex = 4
        Me.clr.Text = "Clear All"
        Me.clr.UseVisualStyleBackColor = True
        '
        'registerbtn2
        '
        Me.registerbtn2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.registerbtn2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerbtn2.Location = New System.Drawing.Point(166, 192)
        Me.registerbtn2.Name = "registerbtn2"
        Me.registerbtn2.Size = New System.Drawing.Size(143, 37)
        Me.registerbtn2.TabIndex = 3
        Me.registerbtn2.Text = "Save"
        Me.registerbtn2.UseVisualStyleBackColor = True
        '
        'equals
        '
        Me.equals.AutoSize = True
        Me.equals.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equals.Location = New System.Drawing.Point(409, 154)
        Me.equals.Name = "equals"
        Me.equals.Size = New System.Drawing.Size(49, 21)
        Me.equals.TabIndex = 59
        Me.equals.Text = "Total:"
        '
        'sum
        '
        Me.sum.AutoSize = True
        Me.sum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sum.Location = New System.Drawing.Point(464, 154)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(19, 21)
        Me.sum.TabIndex = 60
        Me.sum.Text = "0"
        '
        'FrmExpenseList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 242)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmExpenseList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmExpenseList"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelRegistration As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents itemid As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents aytem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents prays As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents clr As System.Windows.Forms.Button
    Friend WithEvents registerbtn2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents quan As System.Windows.Forms.TextBox
    Friend WithEvents sum As System.Windows.Forms.Label
    Friend WithEvents equals As System.Windows.Forms.Label
End Class
