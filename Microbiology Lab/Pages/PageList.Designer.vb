<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelBack = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.ListUsers = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.col_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_regno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ward = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sample = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_update = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn()
        Me.col_print = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.CmdRefresh = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.CmdSearch = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TxtSearch = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.PanelBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBack.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        CType(Me.ListUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBack
        '
        Me.PanelBack.Controls.Add(Me.KryptonGroupBox1)
        Me.PanelBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBack.Location = New System.Drawing.Point(0, 0)
        Me.PanelBack.Name = "PanelBack"
        Me.PanelBack.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelBack.Size = New System.Drawing.Size(800, 415)
        Me.PanelBack.TabIndex = 0
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.ListUsers)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(780, 395)
        Me.KryptonGroupBox1.TabIndex = 0
        Me.KryptonGroupBox1.Values.Heading = "List"
        '
        'ListUsers
        '
        Me.ListUsers.AllowUserToAddRows = False
        Me.ListUsers.AllowUserToDeleteRows = False
        Me.ListUsers.AllowUserToOrderColumns = True
        Me.ListUsers.AllowUserToResizeRows = False
        Me.ListUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_no, Me.col_name, Me.col_regno, Me.col_ward, Me.col_unit, Me.col_sample, Me.col_date, Me.col_update, Me.col_print})
        Me.ListUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListUsers.Location = New System.Drawing.Point(0, 39)
        Me.ListUsers.MultiSelect = False
        Me.ListUsers.Name = "ListUsers"
        Me.ListUsers.RowHeadersVisible = False
        Me.ListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListUsers.ShowCellErrors = False
        Me.ListUsers.ShowCellToolTips = False
        Me.ListUsers.ShowEditingIcon = False
        Me.ListUsers.ShowRowErrors = False
        Me.ListUsers.Size = New System.Drawing.Size(776, 332)
        Me.ListUsers.TabIndex = 18
        '
        'col_no
        '
        Me.col_no.FillWeight = 46.87829!
        Me.col_no.HeaderText = "#"
        Me.col_no.Name = "col_no"
        Me.col_no.ReadOnly = True
        '
        'col_name
        '
        Me.col_name.FillWeight = 207.4364!
        Me.col_name.HeaderText = "Name"
        Me.col_name.Name = "col_name"
        Me.col_name.ReadOnly = True
        '
        'col_regno
        '
        Me.col_regno.HeaderText = "Reg.NO"
        Me.col_regno.Name = "col_regno"
        Me.col_regno.ReadOnly = True
        '
        'col_ward
        '
        Me.col_ward.HeaderText = "Ward"
        Me.col_ward.Name = "col_ward"
        Me.col_ward.ReadOnly = True
        '
        'col_unit
        '
        Me.col_unit.HeaderText = "Unit"
        Me.col_unit.Name = "col_unit"
        Me.col_unit.ReadOnly = True
        '
        'col_sample
        '
        Me.col_sample.HeaderText = "Sample"
        Me.col_sample.Name = "col_sample"
        Me.col_sample.ReadOnly = True
        '
        'col_date
        '
        Me.col_date.HeaderText = "Date"
        Me.col_date.Name = "col_date"
        Me.col_date.ReadOnly = True
        '
        'col_update
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Update"
        Me.col_update.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_update.HeaderText = ""
        Me.col_update.Name = "col_update"
        Me.col_update.ReadOnly = True
        '
        'col_print
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "Print"
        Me.col_print.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_print.HeaderText = ""
        Me.col_print.Name = "col_print"
        Me.col_print.ReadOnly = True
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.CmdRefresh)
        Me.KryptonPanel1.Controls.Add(Me.CmdSearch)
        Me.KryptonPanel1.Controls.Add(Me.TxtSearch)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(776, 39)
        Me.KryptonPanel1.TabIndex = 0
        '
        'CmdRefresh
        '
        Me.CmdRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdRefresh.Location = New System.Drawing.Point(649, 3)
        Me.CmdRefresh.Name = "CmdRefresh"
        Me.CmdRefresh.Size = New System.Drawing.Size(105, 25)
        Me.CmdRefresh.TabIndex = 3
        Me.CmdRefresh.Values.Text = "Refresh"
        '
        'CmdSearch
        '
        Me.CmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSearch.Location = New System.Drawing.Point(538, 3)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(105, 25)
        Me.CmdSearch.TabIndex = 2
        Me.CmdSearch.Values.Text = "Search"
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(101, 3)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(431, 20)
        Me.TxtSearch.TabIndex = 1
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(92, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Name / RegNo"
        '
        'PageList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelBack)
        Me.MinimumSize = New System.Drawing.Size(800, 0)
        Me.Name = "PageList"
        Me.Size = New System.Drawing.Size(800, 415)
        CType(Me.PanelBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBack.ResumeLayout(False)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        CType(Me.ListUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBack As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TxtSearch As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents CmdSearch As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents ListUsers As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents col_no As DataGridViewTextBoxColumn
    Friend WithEvents col_name As DataGridViewTextBoxColumn
    Friend WithEvents col_regno As DataGridViewTextBoxColumn
    Friend WithEvents col_ward As DataGridViewTextBoxColumn
    Friend WithEvents col_unit As DataGridViewTextBoxColumn
    Friend WithEvents col_sample As DataGridViewTextBoxColumn
    Friend WithEvents col_date As DataGridViewTextBoxColumn
    Friend WithEvents col_update As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn
    Friend WithEvents col_print As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn
    Friend WithEvents CmdRefresh As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
