<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExpenseDetails
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelSched = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.total = New System.Windows.Forms.Label()
        Me.tots = New System.Windows.Forms.Label()
        Me.lbltotalsched = New System.Windows.Forms.Label()
        Me.dgviewexpense = New System.Windows.Forms.DataGridView()
        Me.clearselectionsched = New System.Windows.Forms.Button()
        Me.searchlist = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LabelRecordViewSc = New System.Windows.Forms.Label()
        Me.dit = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ad = New System.Windows.Forms.RadioButton()
        Me.budid = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dayt = New System.Windows.Forms.Label()
        Me.moni = New System.Windows.Forms.Label()
        Me.acti = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tim = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgviewlist = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        CType(Me.dgviewexpense, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgviewlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelSched
        '
        Me.LabelSched.AutoSize = True
        Me.LabelSched.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSched.ForeColor = System.Drawing.Color.White
        Me.LabelSched.Location = New System.Drawing.Point(12, 9)
        Me.LabelSched.Name = "LabelSched"
        Me.LabelSched.Size = New System.Drawing.Size(98, 30)
        Me.LabelSched.TabIndex = 0
        Me.LabelSched.Text = "Item List"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.total)
        Me.Panel4.Controls.Add(Me.tots)
        Me.Panel4.Controls.Add(Me.lbltotalsched)
        Me.Panel4.Controls.Add(Me.dgviewexpense)
        Me.Panel4.Controls.Add(Me.clearselectionsched)
        Me.Panel4.Controls.Add(Me.searchlist)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(13, 224)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(460, 291)
        Me.Panel4.TabIndex = 8
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(420, 55)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(15, 17)
        Me.total.TabIndex = 12
        Me.total.Text = "0"
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
        Me.lbltotalsched.Location = New System.Drawing.Point(334, 53)
        Me.lbltotalsched.Name = "lbltotalsched"
        Me.lbltotalsched.Size = New System.Drawing.Size(80, 23)
        Me.lbltotalsched.TabIndex = 10
        Me.lbltotalsched.Text = "No. Of Items:"
        Me.lbltotalsched.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgviewexpense
        '
        Me.dgviewexpense.AllowUserToAddRows = False
        Me.dgviewexpense.AllowUserToDeleteRows = False
        Me.dgviewexpense.AllowUserToOrderColumns = True
        Me.dgviewexpense.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgviewexpense.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgviewexpense.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgviewexpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewexpense.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgviewexpense.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgviewexpense.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewexpense.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewexpense.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgviewexpense.EnableHeadersVisualStyles = False
        Me.dgviewexpense.Location = New System.Drawing.Point(20, 83)
        Me.dgviewexpense.Name = "dgviewexpense"
        Me.dgviewexpense.ReadOnly = True
        Me.dgviewexpense.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewexpense.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgviewexpense.RowHeadersVisible = False
        Me.dgviewexpense.RowTemplate.Height = 70
        Me.dgviewexpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewexpense.Size = New System.Drawing.Size(421, 188)
        Me.dgviewexpense.TabIndex = 9
        '
        'clearselectionsched
        '
        Me.clearselectionsched.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearselectionsched.Location = New System.Drawing.Point(19, 53)
        Me.clearselectionsched.Name = "clearselectionsched"
        Me.clearselectionsched.Size = New System.Drawing.Size(91, 23)
        Me.clearselectionsched.TabIndex = 2
        Me.clearselectionsched.Text = "Clear Selection"
        Me.clearselectionsched.UseVisualStyleBackColor = True
        '
        'searchlist
        '
        Me.searchlist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchlist.Location = New System.Drawing.Point(172, 50)
        Me.searchlist.Name = "searchlist"
        Me.searchlist.Size = New System.Drawing.Size(156, 22)
        Me.searchlist.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(116, 54)
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
        Me.Panel5.Size = New System.Drawing.Size(460, 41)
        Me.Panel5.TabIndex = 0
        '
        'LabelRecordViewSc
        '
        Me.LabelRecordViewSc.AutoSize = True
        Me.LabelRecordViewSc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRecordViewSc.ForeColor = System.Drawing.Color.White
        Me.LabelRecordViewSc.Location = New System.Drawing.Point(4, 11)
        Me.LabelRecordViewSc.Name = "LabelRecordViewSc"
        Me.LabelRecordViewSc.Size = New System.Drawing.Size(75, 21)
        Me.LabelRecordViewSc.TabIndex = 0
        Me.LabelRecordViewSc.Text = "Item List"
        '
        'dit
        '
        Me.dit.AutoSize = True
        Me.dit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dit.Location = New System.Drawing.Point(1102, 21)
        Me.dit.Name = "dit"
        Me.dit.Size = New System.Drawing.Size(70, 18)
        Me.dit.TabIndex = 63
        Me.dit.Text = "----/--/--"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1045, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 18)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Date :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.ad)
        Me.Panel3.Controls.Add(Me.budid)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.dayt)
        Me.Panel3.Controls.Add(Me.moni)
        Me.Panel3.Controls.Add(Me.acti)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1197, 150)
        Me.Panel3.TabIndex = 7
        '
        'ad
        '
        Me.ad.AutoSize = True
        Me.ad.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ad.Location = New System.Drawing.Point(1087, 110)
        Me.ad.Name = "ad"
        Me.ad.Size = New System.Drawing.Size(98, 25)
        Me.ad.TabIndex = 63
        Me.ad.TabStop = True
        Me.ad.Text = "Add Item"
        Me.ad.UseVisualStyleBackColor = True
        '
        'budid
        '
        Me.budid.AutoSize = True
        Me.budid.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.budid.Location = New System.Drawing.Point(155, 18)
        Me.budid.Name = "budid"
        Me.budid.Size = New System.Drawing.Size(16, 17)
        Me.budid.TabIndex = 62
        Me.budid.Text = "#"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(87, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Budget ID:"
        '
        'dayt
        '
        Me.dayt.AutoSize = True
        Me.dayt.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayt.Location = New System.Drawing.Point(153, 115)
        Me.dayt.Name = "dayt"
        Me.dayt.Size = New System.Drawing.Size(16, 17)
        Me.dayt.TabIndex = 55
        Me.dayt.Text = "#"
        '
        'moni
        '
        Me.moni.AutoSize = True
        Me.moni.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moni.Location = New System.Drawing.Point(155, 83)
        Me.moni.Name = "moni"
        Me.moni.Size = New System.Drawing.Size(16, 17)
        Me.moni.TabIndex = 54
        Me.moni.Text = "#"
        '
        'acti
        '
        Me.acti.AutoSize = True
        Me.acti.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acti.Location = New System.Drawing.Point(155, 51)
        Me.acti.Name = "acti"
        Me.acti.Size = New System.Drawing.Size(16, 17)
        Me.acti.TabIndex = 53
        Me.acti.Text = "#"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(100, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Activity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Budget Amount:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Transaction Date:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.dit)
        Me.Panel2.Controls.Add(Me.LabelSched)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.tim)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1197, 54)
        Me.Panel2.TabIndex = 6
        '
        'tim
        '
        Me.tim.AutoSize = True
        Me.tim.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tim.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tim.Location = New System.Drawing.Point(979, 21)
        Me.tim.Name = "tim"
        Me.tim.Size = New System.Drawing.Size(36, 18)
        Me.tim.TabIndex = 65
        Me.tim.Text = "--:--"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(923, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 18)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Time :"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dgviewlist)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Location = New System.Drawing.Point(479, 224)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(706, 291)
        Me.Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(772, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "0"
        '
        'dgviewlist
        '
        Me.dgviewlist.AllowUserToAddRows = False
        Me.dgviewlist.AllowUserToDeleteRows = False
        Me.dgviewlist.AllowUserToOrderColumns = True
        Me.dgviewlist.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgviewlist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgviewlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgviewlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgviewlist.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgviewlist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgviewlist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(131, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewlist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgviewlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgviewlist.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgviewlist.EnableHeadersVisualStyles = False
        Me.dgviewlist.Location = New System.Drawing.Point(20, 83)
        Me.dgviewlist.Name = "dgviewlist"
        Me.dgviewlist.ReadOnly = True
        Me.dgviewlist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgviewlist.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgviewlist.RowHeadersVisible = False
        Me.dgviewlist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgviewlist.RowTemplate.Height = 70
        Me.dgviewlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgviewlist.Size = New System.Drawing.Size(668, 188)
        Me.dgviewlist.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(20, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Clear Selection"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Teal
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(706, 41)
        Me.Panel6.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(4, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Item Purchase"
        '
        'FrmExpenseDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 525)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmExpenseDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmExpenseDetails"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgviewexpense, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgviewlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelSched As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents tots As System.Windows.Forms.Label
    Friend WithEvents lbltotalsched As System.Windows.Forms.Label
    Friend WithEvents dgviewexpense As System.Windows.Forms.DataGridView
    Friend WithEvents clearselectionsched As System.Windows.Forms.Button
    Friend WithEvents searchlist As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents LabelRecordViewSc As System.Windows.Forms.Label
    Friend WithEvents dit As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents budid As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dayt As System.Windows.Forms.Label
    Friend WithEvents moni As System.Windows.Forms.Label
    Friend WithEvents acti As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tim As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgviewlist As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ad As System.Windows.Forms.RadioButton
End Class
