<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConversion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConversion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblconvert = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnconvert = New System.Windows.Forms.Button()
        Me.convert = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.clos = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.metr = New System.Windows.Forms.CheckBox()
        Me.fee = New System.Windows.Forms.CheckBox()
        Me.mete = New System.Windows.Forms.CheckBox()
        Me.met = New System.Windows.Forms.CheckBox()
        Me.kil = New System.Windows.Forms.CheckBox()
        Me.mil = New System.Windows.Forms.CheckBox()
        Me.li = New System.Windows.Forms.CheckBox()
        Me.gra = New System.Windows.Forms.CheckBox()
        Me.kilog = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.clos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblconvert)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnconvert)
        Me.Panel1.Controls.Add(Me.convert)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 415)
        Me.Panel1.TabIndex = 0
        '
        'lblconvert
        '
        Me.lblconvert.AutoSize = True
        Me.lblconvert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconvert.Location = New System.Drawing.Point(430, 76)
        Me.lblconvert.Name = "lblconvert"
        Me.lblconvert.Size = New System.Drawing.Size(19, 21)
        Me.lblconvert.TabIndex = 12
        Me.lblconvert.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(360, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Convert:"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(306, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnconvert
        '
        Me.btnconvert.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnconvert.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconvert.Location = New System.Drawing.Point(117, 366)
        Me.btnconvert.Name = "btnconvert"
        Me.btnconvert.Size = New System.Drawing.Size(143, 37)
        Me.btnconvert.TabIndex = 7
        Me.btnconvert.Text = "Convert"
        Me.btnconvert.UseVisualStyleBackColor = True
        '
        'convert
        '
        Me.convert.Location = New System.Drawing.Point(222, 75)
        Me.convert.Name = "convert"
        Me.convert.Size = New System.Drawing.Size(100, 20)
        Me.convert.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.clos)
        Me.Panel2.Controls.Add(Me.PictureBox8)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(600, 47)
        Me.Panel2.TabIndex = 3
        '
        'clos
        '
        Me.clos.Image = CType(resources.GetObject("clos.Image"), System.Drawing.Image)
        Me.clos.Location = New System.Drawing.Point(560, 12)
        Me.clos.Name = "clos"
        Me.clos.Size = New System.Drawing.Size(28, 23)
        Me.clos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.clos.TabIndex = 5
        Me.clos.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(526, 12)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Application of Unit Conversion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter The Value To Convert"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.metr)
        Me.GroupBox1.Controls.Add(Me.fee)
        Me.GroupBox1.Controls.Add(Me.mete)
        Me.GroupBox1.Controls.Add(Me.met)
        Me.GroupBox1.Controls.Add(Me.kil)
        Me.GroupBox1.Controls.Add(Me.mil)
        Me.GroupBox1.Controls.Add(Me.li)
        Me.GroupBox1.Controls.Add(Me.gra)
        Me.GroupBox1.Controls.Add(Me.kilog)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 237)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Unit For Conversion"
        '
        'metr
        '
        Me.metr.AutoSize = True
        Me.metr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.metr.Location = New System.Drawing.Point(352, 138)
        Me.metr.Name = "metr"
        Me.metr.Size = New System.Drawing.Size(169, 25)
        Me.metr.TabIndex = 10
        Me.metr.Text = "Meter to Centimeter"
        Me.metr.UseVisualStyleBackColor = True
        '
        'fee
        '
        Me.fee.AutoSize = True
        Me.fee.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fee.Location = New System.Drawing.Point(352, 200)
        Me.fee.Name = "fee"
        Me.fee.Size = New System.Drawing.Size(124, 25)
        Me.fee.TabIndex = 9
        Me.fee.Text = "Feet to Inches"
        Me.fee.UseVisualStyleBackColor = True
        '
        'mete
        '
        Me.mete.AutoSize = True
        Me.mete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mete.Location = New System.Drawing.Point(352, 169)
        Me.mete.Name = "mete"
        Me.mete.Size = New System.Drawing.Size(121, 25)
        Me.mete.TabIndex = 8
        Me.mete.Text = "Meter to Feet"
        Me.mete.UseVisualStyleBackColor = True
        '
        'met
        '
        Me.met.AutoSize = True
        Me.met.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.met.Location = New System.Drawing.Point(352, 107)
        Me.met.Name = "met"
        Me.met.Size = New System.Drawing.Size(169, 25)
        Me.met.TabIndex = 7
        Me.met.Text = "Centimeter to Meter"
        Me.met.UseVisualStyleBackColor = True
        '
        'kil
        '
        Me.kil.AutoSize = True
        Me.kil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kil.Location = New System.Drawing.Point(352, 76)
        Me.kil.Name = "kil"
        Me.kil.Size = New System.Drawing.Size(136, 25)
        Me.kil.TabIndex = 6
        Me.kil.Text = "Inches to Meter"
        Me.kil.UseVisualStyleBackColor = True
        '
        'mil
        '
        Me.mil.AutoSize = True
        Me.mil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mil.Location = New System.Drawing.Point(32, 169)
        Me.mil.Name = "mil"
        Me.mil.Size = New System.Drawing.Size(135, 25)
        Me.mil.TabIndex = 5
        Me.mil.Text = "Mililiter to Liter"
        Me.mil.UseVisualStyleBackColor = True
        '
        'li
        '
        Me.li.AutoSize = True
        Me.li.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.li.Location = New System.Drawing.Point(32, 138)
        Me.li.Name = "li"
        Me.li.Size = New System.Drawing.Size(135, 25)
        Me.li.TabIndex = 4
        Me.li.Text = "Liter to Mililiter"
        Me.li.UseVisualStyleBackColor = True
        '
        'gra
        '
        Me.gra.AutoSize = True
        Me.gra.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gra.Location = New System.Drawing.Point(32, 107)
        Me.gra.Name = "gra"
        Me.gra.Size = New System.Drawing.Size(153, 25)
        Me.gra.TabIndex = 3
        Me.gra.Text = "Gram to Kilogram"
        Me.gra.UseVisualStyleBackColor = True
        '
        'kilog
        '
        Me.kilog.AutoSize = True
        Me.kilog.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilog.Location = New System.Drawing.Point(32, 76)
        Me.kilog.Name = "kilog"
        Me.kilog.Size = New System.Drawing.Size(153, 25)
        Me.kilog.TabIndex = 2
        Me.kilog.Text = "Kilogram to Gram"
        Me.kilog.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(372, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Height/Length"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Weight"
        '
        'FrmConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 415)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConversion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.clos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents clos As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents convert As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnconvert As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents metr As System.Windows.Forms.CheckBox
    Friend WithEvents fee As System.Windows.Forms.CheckBox
    Friend WithEvents mete As System.Windows.Forms.CheckBox
    Friend WithEvents met As System.Windows.Forms.CheckBox
    Friend WithEvents kil As System.Windows.Forms.CheckBox
    Friend WithEvents mil As System.Windows.Forms.CheckBox
    Friend WithEvents li As System.Windows.Forms.CheckBox
    Friend WithEvents gra As System.Windows.Forms.CheckBox
    Friend WithEvents kilog As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblconvert As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
