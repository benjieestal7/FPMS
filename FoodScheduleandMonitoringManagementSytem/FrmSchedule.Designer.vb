<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSchedule
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSchedule))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tots = New System.Windows.Forms.Label()
        Me.lbltotalsched = New System.Windows.Forms.Label()
        Me.dgviewschedule = New System.Windows.Forms.DataGridView()
        Me.clearselectionsched = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.searchsched = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LabelRecordViewSc = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.update = New System.Windows.Forms.Button()
        Me.cod = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.faci = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clr2 = New System.Windows.Forms.Button()
        Me.timesched = New System.Windows.Forms.MaskedTextBox()
        Me.savesched = New System.Windows.Forms.Button()
        Me.task = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.venue = New System.Windows.Forms.TextBox()
        Me.schdate = New System.Windows.Forms.DateTimePicker()
        Me.description = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.clos = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.LabelSched = New System.Windows.Forms.Label()
        Me.CMSUserDataTable = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgviewschedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.clos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSUserDataTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 602)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.tots)
        Me.Panel4.Controls.Add(Me.lbltotalsched)
        Me.Panel4.Controls.Add(Me.dgviewschedule)
        Me.Panel4.Controls.Add(Me.clearselectionsched)
        Me.Panel4.Controls.Add(Me.edit)
        Me.Panel4.Controls.Add(Me.searchsched)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(17, 251)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(827, 339)
        Me.Panel4.TabIndex = 0
        '
        'tots
        '
        Me.tots.AutoSize = True
        Me.tots.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tots.Location = New System.Drawing.Point(772, 83)
        Me.tots.Name = "tots"
        Me.tots.Size = New System.Drawing.Size(15, 17)
        Me.tots.TabIndex = 11
        Me.tots.Text = "0"
        '
        'lbltotalsched
        '
        Me.lbltotalsched.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotalsched.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalsched.Location = New System.Drawing.Point(666, 81)
        Me.lbltotalsched.Name = "lbltotalsched"
        Me.lbltotalsched.Size = New System.Drawing.Size(100, 23)
        Me.lbltotalsched.TabIndex = 10
        Me.lbltotalsched.Text = "No. Of Schedule:"
        Me.lbltotalsched.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgviewschedule
        '
        Me.dgviewschedule.AllowUserToAddRows = False
        Me.dgviewschedule.AllowUserToDeleteRows = False
        Me.dgviewschedule.AllowUserToOrderColumns = True
        Me.dgviewschedule.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgviewschedule.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewschedule.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgviewschedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewschedule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgviewschedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgviewschedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewschedule.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgviewschedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewschedule.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgviewschedule.EnableHeadersVisualStyles = False
        Me.dgviewschedule.Location = New System.Drawing.Point(20, 110)
        Me.dgviewschedule.Name = "dgviewschedule"
        Me.dgviewschedule.ReadOnly = True
        Me.dgviewschedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewschedule.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgviewschedule.RowHeadersVisible = False
        Me.dgviewschedule.RowTemplate.Height = 70
        Me.dgviewschedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewschedule.Size = New System.Drawing.Size(789, 212)
        Me.dgviewschedule.TabIndex = 9
        '
        'clearselectionsched
        '
        Me.clearselectionsched.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearselectionsched.Location = New System.Drawing.Point(101, 81)
        Me.clearselectionsched.Name = "clearselectionsched"
        Me.clearselectionsched.Size = New System.Drawing.Size(91, 23)
        Me.clearselectionsched.TabIndex = 2
        Me.clearselectionsched.Text = "Clear Selection"
        Me.clearselectionsched.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.Location = New System.Drawing.Point(20, 81)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 23)
        Me.edit.TabIndex = 1
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'searchsched
        '
        Me.searchsched.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchsched.Location = New System.Drawing.Point(75, 53)
        Me.searchsched.Name = "searchsched"
        Me.searchsched.Size = New System.Drawing.Size(475, 22)
        Me.searchsched.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Search:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Teal
        Me.Panel5.Controls.Add(Me.LabelRecordViewSc)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(827, 41)
        Me.Panel5.TabIndex = 0
        '
        'LabelRecordViewSc
        '
        Me.LabelRecordViewSc.AutoSize = True
        Me.LabelRecordViewSc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRecordViewSc.ForeColor = System.Drawing.Color.White
        Me.LabelRecordViewSc.Location = New System.Drawing.Point(4, 11)
        Me.LabelRecordViewSc.Name = "LabelRecordViewSc"
        Me.LabelRecordViewSc.Size = New System.Drawing.Size(105, 21)
        Me.LabelRecordViewSc.TabIndex = 0
        Me.LabelRecordViewSc.Text = "Record View"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.update)
        Me.Panel3.Controls.Add(Me.cod)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.faci)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.clr2)
        Me.Panel3.Controls.Add(Me.timesched)
        Me.Panel3.Controls.Add(Me.savesched)
        Me.Panel3.Controls.Add(Me.task)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.venue)
        Me.Panel3.Controls.Add(Me.schdate)
        Me.Panel3.Controls.Add(Me.description)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(864, 198)
        Me.Panel3.TabIndex = 1
        '
        'update
        '
        Me.update.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.update.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(555, 155)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(143, 37)
        Me.update.TabIndex = 7
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.Location = New System.Drawing.Point(89, 15)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(57, 17)
        Me.cod.TabIndex = 51
        Me.cod.Text = "ActCode"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 17)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Code:"
        '
        'faci
        '
        Me.faci.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.faci.Location = New System.Drawing.Point(88, 111)
        Me.faci.Multiline = True
        Me.faci.Name = "faci"
        Me.faci.Size = New System.Drawing.Size(200, 26)
        Me.faci.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Facilitator:"
        '
        'clr2
        '
        Me.clr2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clr2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clr2.Location = New System.Drawing.Point(701, 155)
        Me.clr2.Name = "clr2"
        Me.clr2.Size = New System.Drawing.Size(143, 37)
        Me.clr2.TabIndex = 8
        Me.clr2.Text = "Clear All"
        Me.clr2.UseVisualStyleBackColor = True
        '
        'timesched
        '
        Me.timesched.Location = New System.Drawing.Point(88, 172)
        Me.timesched.Mask = "##:##"
        Me.timesched.Name = "timesched"
        Me.timesched.Size = New System.Drawing.Size(200, 20)
        Me.timesched.TabIndex = 4
        '
        'savesched
        '
        Me.savesched.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.savesched.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savesched.Location = New System.Drawing.Point(406, 155)
        Me.savesched.Name = "savesched"
        Me.savesched.Size = New System.Drawing.Size(143, 37)
        Me.savesched.TabIndex = 6
        Me.savesched.Text = "Save"
        Me.savesched.UseVisualStyleBackColor = True
        '
        'task
        '
        Me.task.Location = New System.Drawing.Point(88, 46)
        Me.task.Multiline = True
        Me.task.Name = "task"
        Me.task.Size = New System.Drawing.Size(200, 21)
        Me.task.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Activity:"
        '
        'venue
        '
        Me.venue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.venue.Location = New System.Drawing.Point(88, 73)
        Me.venue.Multiline = True
        Me.venue.Name = "venue"
        Me.venue.Size = New System.Drawing.Size(200, 26)
        Me.venue.TabIndex = 1
        '
        'schdate
        '
        Me.schdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.schdate.Location = New System.Drawing.Point(88, 143)
        Me.schdate.Name = "schdate"
        Me.schdate.Size = New System.Drawing.Size(200, 23)
        Me.schdate.TabIndex = 3
        Me.schdate.Value = New Date(2022, 5, 14, 0, 0, 0, 0)
        '
        'description
        '
        Me.description.Location = New System.Drawing.Point(396, 10)
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(448, 131)
        Me.description.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(313, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Venue:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Date:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.clos)
        Me.Panel2.Controls.Add(Me.PictureBox8)
        Me.Panel2.Controls.Add(Me.LabelSched)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 47)
        Me.Panel2.TabIndex = 0
        '
        'clos
        '
        Me.clos.Image = CType(resources.GetObject("clos.Image"), System.Drawing.Image)
        Me.clos.Location = New System.Drawing.Point(824, 9)
        Me.clos.Name = "clos"
        Me.clos.Size = New System.Drawing.Size(28, 23)
        Me.clos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.clos.TabIndex = 5
        Me.clos.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(790, 9)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(28, 23)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'LabelSched
        '
        Me.LabelSched.AutoSize = True
        Me.LabelSched.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSched.ForeColor = System.Drawing.Color.White
        Me.LabelSched.Location = New System.Drawing.Point(12, 9)
        Me.LabelSched.Name = "LabelSched"
        Me.LabelSched.Size = New System.Drawing.Size(187, 30)
        Me.LabelSched.TabIndex = 0
        Me.LabelSched.Text = "Manage Schedule"
        '
        'CMSUserDataTable
        '
        Me.CMSUserDataTable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator1, Me.SelectAllToolStripMenuItem, Me.ClearSelectionToolStripMenuItem, Me.DetailsToolStripMenuItem})
        Me.CMSUserDataTable.Name = "CMSUserDataTable"
        Me.CMSUserDataTable.Size = New System.Drawing.Size(153, 120)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ClearSelectionToolStripMenuItem
        '
        Me.ClearSelectionToolStripMenuItem.Name = "ClearSelectionToolStripMenuItem"
        Me.ClearSelectionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearSelectionToolStripMenuItem.Text = "Clear Selection"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'FrmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 602)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgviewschedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.clos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSUserDataTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelSched As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents description As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents venue As System.Windows.Forms.TextBox
    Friend WithEvents schdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbltotalsched As System.Windows.Forms.Label
    Friend WithEvents dgviewschedule As System.Windows.Forms.DataGridView
    Friend WithEvents clearselectionsched As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents searchsched As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LabelRecordViewSc As System.Windows.Forms.Label
    Friend WithEvents task As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents savesched As System.Windows.Forms.Button
    Friend WithEvents timesched As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CMSUserDataTable As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearSelectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clr2 As System.Windows.Forms.Button
    Friend WithEvents faci As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clos As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents tots As System.Windows.Forms.Label
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cod As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents update As System.Windows.Forms.Button
End Class
