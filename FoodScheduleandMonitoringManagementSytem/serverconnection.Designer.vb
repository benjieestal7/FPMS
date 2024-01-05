<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class serverconnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(serverconnection))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.database = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.server = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.clos = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.LabelRegistration = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.clos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.loginbtn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.userid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.database)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.server)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 473)
        Me.Panel1.TabIndex = 0
        '
        'loginbtn
        '
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.loginbtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbtn.Location = New System.Drawing.Point(154, 351)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(265, 47)
        Me.loginbtn.TabIndex = 69
        Me.loginbtn.Text = "Connect"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(55, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Password:"
        '
        'password
        '
        Me.password.BackColor = System.Drawing.SystemColors.Control
        Me.password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.password.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(154, 275)
        Me.password.Multiline = True
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(265, 27)
        Me.password.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(71, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "User ID:"
        '
        'userid
        '
        Me.userid.BackColor = System.Drawing.SystemColors.Control
        Me.userid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userid.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userid.Location = New System.Drawing.Point(154, 216)
        Me.userid.Multiline = True
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(265, 27)
        Me.userid.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(55, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Database:"
        '
        'database
        '
        Me.database.BackColor = System.Drawing.SystemColors.Control
        Me.database.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.database.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.database.Location = New System.Drawing.Point(154, 160)
        Me.database.Multiline = True
        Me.database.Name = "database"
        Me.database.ReadOnly = True
        Me.database.Size = New System.Drawing.Size(265, 27)
        Me.database.TabIndex = 63
        Me.database.Text = "fpms"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(55, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "IP Address:"
        '
        'server
        '
        Me.server.BackColor = System.Drawing.SystemColors.Control
        Me.server.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.server.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.server.Location = New System.Drawing.Point(154, 102)
        Me.server.Multiline = True
        Me.server.Name = "server"
        Me.server.Size = New System.Drawing.Size(265, 27)
        Me.server.TabIndex = 61
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.clos)
        Me.Panel2.Controls.Add(Me.PictureBox8)
        Me.Panel2.Controls.Add(Me.LabelRegistration)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(509, 46)
        Me.Panel2.TabIndex = 60
        '
        'clos
        '
        Me.clos.Image = CType(resources.GetObject("clos.Image"), System.Drawing.Image)
        Me.clos.Location = New System.Drawing.Point(471, 12)
        Me.clos.Name = "clos"
        Me.clos.Size = New System.Drawing.Size(28, 23)
        Me.clos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.clos.TabIndex = 56
        Me.clos.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(437, 12)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 57
        Me.PictureBox8.TabStop = False
        '
        'LabelRegistration
        '
        Me.LabelRegistration.AutoSize = True
        Me.LabelRegistration.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegistration.ForeColor = System.Drawing.Color.White
        Me.LabelRegistration.Location = New System.Drawing.Point(15, 10)
        Me.LabelRegistration.Name = "LabelRegistration"
        Me.LabelRegistration.Size = New System.Drawing.Size(178, 25)
        Me.LabelRegistration.TabIndex = 0
        Me.LabelRegistration.Text = "Server Connection"
        '
        'serverconnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 473)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "serverconnection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "serverconnection"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.clos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents userid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents database As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents server As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents clos As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelRegistration As System.Windows.Forms.Label
    Friend WithEvents loginbtn As System.Windows.Forms.Button
End Class
