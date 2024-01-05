<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFinance
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFinance))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pesign = New System.Windows.Forms.Label()
        Me.expense = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sum = New System.Windows.Forms.Label()
        Me.equals = New System.Windows.Forms.Label()
        Me.budid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.update = New System.Windows.Forms.Button()
        Me.activ = New System.Windows.Forms.TextBox()
        Me.dtdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.money = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clr = New System.Windows.Forms.Button()
        Me.registerbtn2 = New System.Windows.Forms.Button()
        Me.LabelRecordView = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.addn = New System.Windows.Forms.Button()
        Me.searchmon = New System.Windows.Forms.TextBox()
        Me.dgviewbudget = New System.Windows.Forms.DataGridView()
        Me.clearselection = New System.Windows.Forms.Button()
        Me.det = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.clos = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.LabelRegistration = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CMSUserDataTable = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgviewbudget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.clos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.CMSUserDataTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.pesign)
        Me.Panel3.Controls.Add(Me.expense)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.sum)
        Me.Panel3.Controls.Add(Me.equals)
        Me.Panel3.Controls.Add(Me.budid)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.update)
        Me.Panel3.Controls.Add(Me.activ)
        Me.Panel3.Controls.Add(Me.dtdate)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.money)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.clr)
        Me.Panel3.Controls.Add(Me.registerbtn2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(713, 257)
        Me.Panel3.TabIndex = 0
        '
        'pesign
        '
        Me.pesign.AutoSize = True
        Me.pesign.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pesign.Location = New System.Drawing.Point(627, 120)
        Me.pesign.Name = "pesign"
        Me.pesign.Size = New System.Drawing.Size(24, 21)
        Me.pesign.TabIndex = 65
        Me.pesign.Text = " ₱"
        Me.pesign.Visible = False
        '
        'expense
        '
        Me.expense.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.expense.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expense.Location = New System.Drawing.Point(400, 112)
        Me.expense.Multiline = True
        Me.expense.Name = "expense"
        Me.expense.Size = New System.Drawing.Size(83, 28)
        Me.expense.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(289, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Expense Amount:"
        '
        'sum
        '
        Me.sum.AutoSize = True
        Me.sum.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sum.Location = New System.Drawing.Point(652, 120)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(19, 21)
        Me.sum.TabIndex = 62
        Me.sum.Text = "0"
        '
        'equals
        '
        Me.equals.AutoSize = True
        Me.equals.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equals.Location = New System.Drawing.Point(485, 120)
        Me.equals.Name = "equals"
        Me.equals.Size = New System.Drawing.Size(149, 21)
        Me.equals.TabIndex = 61
        Me.equals.Text = "Remaining Budget:"
        '
        'budid
        '
        Me.budid.AutoSize = True
        Me.budid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.budid.Location = New System.Drawing.Point(198, 57)
        Me.budid.Name = "budid"
        Me.budid.Size = New System.Drawing.Size(21, 17)
        Me.budid.TabIndex = 55
        Me.budid.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Budget ID:"
        '
        'update
        '
        Me.update.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.update.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(340, 191)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(143, 37)
        Me.update.TabIndex = 5
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'activ
        '
        Me.activ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.activ.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activ.Location = New System.Drawing.Point(200, 80)
        Me.activ.Multiline = True
        Me.activ.Name = "activ"
        Me.activ.Size = New System.Drawing.Size(283, 26)
        Me.activ.TabIndex = 0
        '
        'dtdate
        '
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdate.Location = New System.Drawing.Point(201, 153)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(282, 20)
        Me.dtdate.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(137, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Activity:"
        '
        'money
        '
        Me.money.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.money.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.money.Location = New System.Drawing.Point(201, 112)
        Me.money.Multiline = True
        Me.money.Name = "money"
        Me.money.Size = New System.Drawing.Size(83, 28)
        Me.money.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Transaction Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(87, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 17)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Budget Amount:"
        '
        'clr
        '
        Me.clr.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clr.Location = New System.Drawing.Point(489, 191)
        Me.clr.Name = "clr"
        Me.clr.Size = New System.Drawing.Size(143, 37)
        Me.clr.TabIndex = 6
        Me.clr.Text = "Clear All"
        Me.clr.UseVisualStyleBackColor = True
        '
        'registerbtn2
        '
        Me.registerbtn2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.registerbtn2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerbtn2.Location = New System.Drawing.Point(191, 191)
        Me.registerbtn2.Name = "registerbtn2"
        Me.registerbtn2.Size = New System.Drawing.Size(143, 37)
        Me.registerbtn2.TabIndex = 4
        Me.registerbtn2.Text = "Save"
        Me.registerbtn2.UseVisualStyleBackColor = True
        '
        'LabelRecordView
        '
        Me.LabelRecordView.AutoSize = True
        Me.LabelRecordView.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRecordView.ForeColor = System.Drawing.Color.White
        Me.LabelRecordView.Location = New System.Drawing.Point(4, 11)
        Me.LabelRecordView.Name = "LabelRecordView"
        Me.LabelRecordView.Size = New System.Drawing.Size(105, 21)
        Me.LabelRecordView.TabIndex = 0
        Me.LabelRecordView.Text = "Record View"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Teal
        Me.Panel5.Controls.Add(Me.LabelRecordView)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(691, 41)
        Me.Panel5.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.addn)
        Me.Panel4.Controls.Add(Me.searchmon)
        Me.Panel4.Controls.Add(Me.dgviewbudget)
        Me.Panel4.Controls.Add(Me.clearselection)
        Me.Panel4.Controls.Add(Me.det)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(11, 272)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(691, 308)
        Me.Panel4.TabIndex = 1
        '
        'addn
        '
        Me.addn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addn.Location = New System.Drawing.Point(198, 73)
        Me.addn.Name = "addn"
        Me.addn.Size = New System.Drawing.Size(75, 23)
        Me.addn.TabIndex = 3
        Me.addn.Text = "Add New"
        Me.addn.UseVisualStyleBackColor = True
        '
        'searchmon
        '
        Me.searchmon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchmon.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchmon.Location = New System.Drawing.Point(77, 47)
        Me.searchmon.Multiline = True
        Me.searchmon.Name = "searchmon"
        Me.searchmon.Size = New System.Drawing.Size(341, 20)
        Me.searchmon.TabIndex = 0
        '
        'dgviewbudget
        '
        Me.dgviewbudget.AllowUserToAddRows = False
        Me.dgviewbudget.AllowUserToDeleteRows = False
        Me.dgviewbudget.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        Me.dgviewbudget.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgviewbudget.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewbudget.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgviewbudget.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgviewbudget.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewbudget.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgviewbudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewbudget.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgviewbudget.EnableHeadersVisualStyles = False
        Me.dgviewbudget.Location = New System.Drawing.Point(22, 102)
        Me.dgviewbudget.Name = "dgviewbudget"
        Me.dgviewbudget.ReadOnly = True
        Me.dgviewbudget.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewbudget.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgviewbudget.RowHeadersVisible = False
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgviewbudget.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgviewbudget.RowTemplate.Height = 70
        Me.dgviewbudget.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewbudget.Size = New System.Drawing.Size(651, 187)
        Me.dgviewbudget.TabIndex = 7
        '
        'clearselection
        '
        Me.clearselection.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearselection.Location = New System.Drawing.Point(101, 73)
        Me.clearselection.Name = "clearselection"
        Me.clearselection.Size = New System.Drawing.Size(91, 23)
        Me.clearselection.TabIndex = 2
        Me.clearselection.Text = "Clear Selection"
        Me.clearselection.UseVisualStyleBackColor = True
        '
        'det
        '
        Me.det.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.det.Location = New System.Drawing.Point(20, 73)
        Me.det.Name = "det"
        Me.det.Size = New System.Drawing.Size(75, 23)
        Me.det.TabIndex = 1
        Me.det.Text = "Edit"
        Me.det.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Search:"
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
        Me.Panel2.Size = New System.Drawing.Size(715, 46)
        Me.Panel2.TabIndex = 3
        '
        'clos
        '
        Me.clos.Image = CType(resources.GetObject("clos.Image"), System.Drawing.Image)
        Me.clos.Location = New System.Drawing.Point(657, 10)
        Me.clos.Name = "clos"
        Me.clos.Size = New System.Drawing.Size(28, 23)
        Me.clos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.clos.TabIndex = 56
        Me.clos.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(623, 10)
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
        Me.LabelRegistration.Size = New System.Drawing.Size(222, 25)
        Me.LabelRegistration.TabIndex = 0
        Me.LabelRegistration.Text = "Manage Budget Record"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(715, 603)
        Me.Panel1.TabIndex = 2
        '
        'CMSUserDataTable
        '
        Me.CMSUserDataTable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ToolStripSeparator1, Me.AddListToolStripMenuItem, Me.DetailsToolStripMenuItem})
        Me.CMSUserDataTable.Name = "CMSUserDataTable"
        Me.CMSUserDataTable.Size = New System.Drawing.Size(118, 76)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(114, 6)
        '
        'AddListToolStripMenuItem
        '
        Me.AddListToolStripMenuItem.Name = "AddListToolStripMenuItem"
        Me.AddListToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AddListToolStripMenuItem.Text = "Add List"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DetailsToolStripMenuItem.Text = "Details"
        '
        'FrmFinance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 603)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmFinance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFinance"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgviewbudget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.clos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.CMSUserDataTable.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents clr As System.Windows.Forms.Button
    Friend WithEvents registerbtn2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelRecordView As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgviewbudget As System.Windows.Forms.DataGridView
    Friend WithEvents clearselection As System.Windows.Forms.Button
    Friend WithEvents det As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelRegistration As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents money As System.Windows.Forms.TextBox
    Friend WithEvents activ As System.Windows.Forms.TextBox
    Friend WithEvents searchmon As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents budid As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents addn As System.Windows.Forms.Button
    Friend WithEvents CMSUserDataTable As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clos As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents sum As System.Windows.Forms.Label
    Friend WithEvents equals As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents expense As System.Windows.Forms.TextBox
    Friend WithEvents pesign As System.Windows.Forms.Label
End Class
