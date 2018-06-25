<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PageAntibiotics
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelBack = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.GroupAntibiotics = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.ListItems = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.col_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_remove = New ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.CmdImport = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.CmdAdd = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ListGramStrain = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        CType(Me.PanelBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBack.SuspendLayout()
        CType(Me.GroupAntibiotics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupAntibiotics.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupAntibiotics.Panel.SuspendLayout()
        Me.GroupAntibiotics.SuspendLayout()
        CType(Me.ListItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.ListGramStrain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBack
        '
        Me.PanelBack.Controls.Add(Me.GroupAntibiotics)
        Me.PanelBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBack.Location = New System.Drawing.Point(0, 0)
        Me.PanelBack.Name = "PanelBack"
        Me.PanelBack.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelBack.Size = New System.Drawing.Size(800, 187)
        Me.PanelBack.TabIndex = 0
        '
        'GroupAntibiotics
        '
        Me.GroupAntibiotics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupAntibiotics.Location = New System.Drawing.Point(10, 10)
        Me.GroupAntibiotics.Name = "GroupAntibiotics"
        '
        'GroupAntibiotics.Panel
        '
        Me.GroupAntibiotics.Panel.Controls.Add(Me.ListItems)
        Me.GroupAntibiotics.Panel.Controls.Add(Me.KryptonPanel1)
        Me.GroupAntibiotics.Panel.Controls.Add(Me.KryptonPanel2)
        Me.GroupAntibiotics.Size = New System.Drawing.Size(780, 167)
        Me.GroupAntibiotics.TabIndex = 0
        Me.GroupAntibiotics.Values.Heading = "Antibiotics"
        '
        'ListItems
        '
        Me.ListItems.AllowUserToAddRows = False
        Me.ListItems.AllowUserToDeleteRows = False
        Me.ListItems.AllowUserToOrderColumns = True
        Me.ListItems.AllowUserToResizeRows = False
        Me.ListItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ListItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_no, Me.col_name, Me.col_remove})
        Me.ListItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListItems.Location = New System.Drawing.Point(0, 36)
        Me.ListItems.MultiSelect = False
        Me.ListItems.Name = "ListItems"
        Me.ListItems.RowHeadersVisible = False
        Me.ListItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListItems.ShowCellErrors = False
        Me.ListItems.ShowCellToolTips = False
        Me.ListItems.ShowEditingIcon = False
        Me.ListItems.ShowRowErrors = False
        Me.ListItems.Size = New System.Drawing.Size(776, 59)
        Me.ListItems.TabIndex = 20
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
        'col_remove
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "Remove"
        Me.col_remove.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_remove.FillWeight = 45.68528!
        Me.col_remove.HeaderText = ""
        Me.col_remove.Name = "col_remove"
        Me.col_remove.ReadOnly = True
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.CmdImport)
        Me.KryptonPanel2.Controls.Add(Me.CmdAdd)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 95)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(776, 48)
        Me.KryptonPanel2.TabIndex = 21
        '
        'CmdImport
        '
        Me.CmdImport.Location = New System.Drawing.Point(179, 6)
        Me.CmdImport.Name = "CmdImport"
        Me.CmdImport.Size = New System.Drawing.Size(150, 25)
        Me.CmdImport.TabIndex = 20
        Me.CmdImport.Values.Text = "Import Default"
        '
        'CmdAdd
        '
        Me.CmdAdd.Location = New System.Drawing.Point(12, 6)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(150, 25)
        Me.CmdAdd.TabIndex = 19
        Me.CmdAdd.Values.Text = "Add"
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.ListGramStrain)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(776, 36)
        Me.KryptonPanel1.TabIndex = 22
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 10)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(76, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Gram strain:"
        '
        'ListGramStrain
        '
        Me.ListGramStrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListGramStrain.DropDownWidth = 235
        Me.ListGramStrain.Items.AddRange(New Object() {"Gram Positive", "Gram Negative"})
        Me.ListGramStrain.Location = New System.Drawing.Point(94, 9)
        Me.ListGramStrain.Name = "ListGramStrain"
        Me.ListGramStrain.Size = New System.Drawing.Size(235, 21)
        Me.ListGramStrain.TabIndex = 1
        '
        'PageAntibiotics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelBack)
        Me.MinimumSize = New System.Drawing.Size(800, 0)
        Me.Name = "PageAntibiotics"
        Me.Size = New System.Drawing.Size(800, 187)
        CType(Me.PanelBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBack.ResumeLayout(False)
        CType(Me.GroupAntibiotics.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupAntibiotics.Panel.ResumeLayout(False)
        CType(Me.GroupAntibiotics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupAntibiotics.ResumeLayout(False)
        CType(Me.ListItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
        CType(Me.ListGramStrain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBack As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents GroupAntibiotics As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents ListItems As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents col_no As DataGridViewTextBoxColumn
    Friend WithEvents col_name As DataGridViewTextBoxColumn
    Friend WithEvents col_remove As ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents CmdImport As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents CmdAdd As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ListGramStrain As ComponentFactory.Krypton.Toolkit.KryptonComboBox
End Class
