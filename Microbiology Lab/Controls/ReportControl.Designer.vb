<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportControl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.ListAntibiotics = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.col_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sen = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.col_res = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.col_inter = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ListPathogen = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ListGram = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ListResult = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        CType(Me.ListAntibiotics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListPathogen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListGram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroupBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.ListAntibiotics)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.ListPathogen)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.ListGram)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.ListResult)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(692, 200)
        Me.KryptonGroupBox1.TabIndex = 3
        Me.KryptonGroupBox1.Values.Heading = "Report"
        '
        'ListAntibiotics
        '
        Me.ListAntibiotics.AllowUserToAddRows = False
        Me.ListAntibiotics.AllowUserToDeleteRows = False
        Me.ListAntibiotics.AllowUserToResizeColumns = False
        Me.ListAntibiotics.AllowUserToResizeRows = False
        Me.ListAntibiotics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ListAntibiotics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListAntibiotics.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_name, Me.col_sen, Me.col_res, Me.col_inter})
        Me.ListAntibiotics.Enabled = False
        Me.ListAntibiotics.Location = New System.Drawing.Point(80, 123)
        Me.ListAntibiotics.Margin = New System.Windows.Forms.Padding(10)
        Me.ListAntibiotics.MultiSelect = False
        Me.ListAntibiotics.Name = "ListAntibiotics"
        Me.ListAntibiotics.RowHeadersVisible = False
        Me.ListAntibiotics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.ListAntibiotics.ShowCellErrors = False
        Me.ListAntibiotics.ShowCellToolTips = False
        Me.ListAntibiotics.ShowEditingIcon = False
        Me.ListAntibiotics.ShowRowErrors = False
        Me.ListAntibiotics.Size = New System.Drawing.Size(430, 43)
        Me.ListAntibiotics.TabIndex = 25
        '
        'col_name
        '
        Me.col_name.FillWeight = 254.3147!
        Me.col_name.HeaderText = "Name"
        Me.col_name.Name = "col_name"
        '
        'col_sen
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.col_sen.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_sen.FalseValue = Nothing
        Me.col_sen.HeaderText = "S"
        Me.col_sen.IndeterminateValue = Nothing
        Me.col_sen.Name = "col_sen"
        Me.col_sen.TrueValue = Nothing
        '
        'col_res
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = False
        Me.col_res.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_res.FalseValue = Nothing
        Me.col_res.HeaderText = "R"
        Me.col_res.IndeterminateValue = Nothing
        Me.col_res.Name = "col_res"
        Me.col_res.TrueValue = Nothing
        '
        'col_inter
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = False
        Me.col_inter.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_inter.FalseValue = Nothing
        Me.col_inter.HeaderText = "I"
        Me.col_inter.IndeterminateValue = Nothing
        Me.col_inter.Name = "col_inter"
        Me.col_inter.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.col_inter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.col_inter.TrueValue = Nothing
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel4.Location = New System.Drawing.Point(7, 123)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(71, 20)
        Me.KryptonLabel4.TabIndex = 15
        Me.KryptonLabel4.Values.Text = "Antibiotics:"
        '
        'ListPathogen
        '
        Me.ListPathogen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListPathogen.DropDownWidth = 430
        Me.ListPathogen.Enabled = False
        Me.ListPathogen.Items.AddRange(New Object() {"Gram Positive", "Gram Negative"})
        Me.ListPathogen.Location = New System.Drawing.Point(80, 82)
        Me.ListPathogen.Margin = New System.Windows.Forms.Padding(10)
        Me.ListPathogen.Name = "ListPathogen"
        Me.ListPathogen.Size = New System.Drawing.Size(430, 21)
        Me.ListPathogen.TabIndex = 14
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel3.Location = New System.Drawing.Point(7, 83)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel3.TabIndex = 13
        Me.KryptonLabel3.Values.Text = "Pathogen:"
        '
        'ListGram
        '
        Me.ListGram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListGram.DropDownWidth = 430
        Me.ListGram.Enabled = False
        Me.ListGram.Items.AddRange(New Object() {"Gram Positive", "Gram Negative"})
        Me.ListGram.Location = New System.Drawing.Point(80, 41)
        Me.ListGram.Margin = New System.Windows.Forms.Padding(10)
        Me.ListGram.Name = "ListGram"
        Me.ListGram.Size = New System.Drawing.Size(430, 21)
        Me.ListGram.TabIndex = 12
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel2.Location = New System.Drawing.Point(7, 42)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel2.TabIndex = 11
        Me.KryptonLabel2.Values.Text = "Gram stain:"
        '
        'ListResult
        '
        Me.ListResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListResult.DropDownWidth = 430
        Me.ListResult.Items.AddRange(New Object() {"Not Tested", "No Growth", "Growth"})
        Me.ListResult.Location = New System.Drawing.Point(80, 3)
        Me.ListResult.Margin = New System.Windows.Forms.Padding(10)
        Me.ListResult.Name = "ListResult"
        Me.ListResult.Size = New System.Drawing.Size(430, 21)
        Me.ListResult.TabIndex = 10
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel1.Location = New System.Drawing.Point(7, 3)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(46, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Result:"
        '
        'ReportControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.KryptonGroupBox1)
        Me.Name = "ReportControl"
        Me.Size = New System.Drawing.Size(692, 200)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        CType(Me.ListAntibiotics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListPathogen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListGram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ListResult As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents ListGram As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ListPathogen As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ListAntibiotics As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents col_name As DataGridViewTextBoxColumn
    Friend WithEvents col_sen As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents col_res As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
    Friend WithEvents col_inter As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn
End Class
