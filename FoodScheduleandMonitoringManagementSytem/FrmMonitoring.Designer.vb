<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonitoring
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMonitoring))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtto = New System.Windows.Forms.DateTimePicker()
        Me.dtfrom = New System.Windows.Forms.DateTimePicker()
        Me.lbto = New System.Windows.Forms.Label()
        Me.lbfrom = New System.Windows.Forms.Label()
        Me.btndaily = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.prntmon = New System.Windows.Forms.Button()
        Me.dgviewmon = New System.Windows.Forms.DataGridView()
        Me.searchinfo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.clos = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.LabelMon = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgviewmon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.clos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1182, 466)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.dtto)
        Me.Panel3.Controls.Add(Me.dtfrom)
        Me.Panel3.Controls.Add(Me.lbto)
        Me.Panel3.Controls.Add(Me.lbfrom)
        Me.Panel3.Controls.Add(Me.btndaily)
        Me.Panel3.Controls.Add(Me.txtsearch)
        Me.Panel3.Controls.Add(Me.prntmon)
        Me.Panel3.Controls.Add(Me.dgviewmon)
        Me.Panel3.Controls.Add(Me.searchinfo)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1182, 419)
        Me.Panel3.TabIndex = 1
        '
        'dtto
        '
        Me.dtto.CalendarFont = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(598, 36)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(97, 20)
        Me.dtto.TabIndex = 2
        Me.dtto.Value = New Date(2022, 8, 7, 0, 0, 0, 0)
        '
        'dtfrom
        '
        Me.dtfrom.CalendarFont = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtfrom.Checked = False
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(459, 36)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(97, 20)
        Me.dtfrom.TabIndex = 1
        Me.dtfrom.Value = New Date(2022, 8, 7, 0, 0, 0, 0)
        '
        'lbto
        '
        Me.lbto.AutoSize = True
        Me.lbto.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbto.Location = New System.Drawing.Point(562, 38)
        Me.lbto.Name = "lbto"
        Me.lbto.Size = New System.Drawing.Size(30, 14)
        Me.lbto.TabIndex = 83
        Me.lbto.Text = "To :"
        '
        'lbfrom
        '
        Me.lbfrom.AutoSize = True
        Me.lbfrom.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfrom.Location = New System.Drawing.Point(411, 39)
        Me.lbfrom.Name = "lbfrom"
        Me.lbfrom.Size = New System.Drawing.Size(47, 14)
        Me.lbfrom.TabIndex = 84
        Me.lbfrom.Text = "From :"
        '
        'btndaily
        '
        Me.btndaily.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btndaily.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndaily.Location = New System.Drawing.Point(708, 23)
        Me.btndaily.Name = "btndaily"
        Me.btndaily.Size = New System.Drawing.Size(107, 40)
        Me.btndaily.TabIndex = 3
        Me.btndaily.Text = "Search"
        Me.btndaily.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(44, 33)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(332, 23)
        Me.txtsearch.TabIndex = 0
        '
        'prntmon
        '
        Me.prntmon.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prntmon.ForeColor = System.Drawing.Color.Teal
        Me.prntmon.Location = New System.Drawing.Point(1029, 25)
        Me.prntmon.Name = "prntmon"
        Me.prntmon.Size = New System.Drawing.Size(131, 38)
        Me.prntmon.TabIndex = 4
        Me.prntmon.Text = "Print"
        Me.prntmon.UseVisualStyleBackColor = True
        '
        'dgviewmon
        '
        Me.dgviewmon.AllowUserToAddRows = False
        Me.dgviewmon.AllowUserToDeleteRows = False
        Me.dgviewmon.AllowUserToOrderColumns = True
        Me.dgviewmon.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgviewmon.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewmon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgviewmon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewmon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgviewmon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgviewmon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewmon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewmon.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgviewmon.EnableHeadersVisualStyles = False
        Me.dgviewmon.Location = New System.Drawing.Point(12, 79)
        Me.dgviewmon.Name = "dgviewmon"
        Me.dgviewmon.ReadOnly = True
        Me.dgviewmon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewmon.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgviewmon.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgviewmon.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgviewmon.RowTemplate.Height = 70
        Me.dgviewmon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewmon.Size = New System.Drawing.Size(1158, 328)
        Me.dgviewmon.TabIndex = 70
        '
        'searchinfo
        '
        Me.searchinfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchinfo.Location = New System.Drawing.Point(93, -23)
        Me.searchinfo.Name = "searchinfo"
        Me.searchinfo.Size = New System.Drawing.Size(235, 22)
        Me.searchinfo.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, -20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Search:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.clos)
        Me.Panel2.Controls.Add(Me.PictureBox8)
        Me.Panel2.Controls.Add(Me.LabelMon)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1182, 47)
        Me.Panel2.TabIndex = 0
        '
        'clos
        '
        Me.clos.Image = CType(resources.GetObject("clos.Image"), System.Drawing.Image)
        Me.clos.Location = New System.Drawing.Point(1142, 12)
        Me.clos.Name = "clos"
        Me.clos.Size = New System.Drawing.Size(28, 23)
        Me.clos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.clos.TabIndex = 5
        Me.clos.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(1108, 12)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'LabelMon
        '
        Me.LabelMon.AutoSize = True
        Me.LabelMon.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMon.ForeColor = System.Drawing.Color.White
        Me.LabelMon.Location = New System.Drawing.Point(12, 9)
        Me.LabelMon.Name = "LabelMon"
        Me.LabelMon.Size = New System.Drawing.Size(227, 25)
        Me.LabelMon.TabIndex = 0
        Me.LabelMon.Text = "Monitoring Record"
        '
        'FrmMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 466)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMonitoring"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMonitoring"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgviewmon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.clos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents clos As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelMon As System.Windows.Forms.Label
    Friend WithEvents dgviewmon As System.Windows.Forms.DataGridView
    Friend WithEvents searchinfo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents prntmon As System.Windows.Forms.Button
    Friend WithEvents btndaily As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents lbto As System.Windows.Forms.Label
    Friend WithEvents lbfrom As System.Windows.Forms.Label
    Friend WithEvents dtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtfrom As System.Windows.Forms.DateTimePicker
End Class
