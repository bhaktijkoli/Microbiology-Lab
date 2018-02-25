<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PageRegister
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
        Me.PanelBack = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.GroupRegister = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.TxtNature = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.LblNature = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TxtPincode = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TxtAddress = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.CmdClear = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.CmdRegister = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TxtSample = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.TxtSex = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.TxtAge = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.TxtUnit = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtWard = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtRegNo = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.PanelBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBack.SuspendLayout()
        CType(Me.GroupRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupRegister.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupRegister.Panel.SuspendLayout()
        Me.GroupRegister.SuspendLayout()
        CType(Me.TxtNature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSample, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBack
        '
        Me.PanelBack.Controls.Add(Me.GroupRegister)
        Me.PanelBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBack.Location = New System.Drawing.Point(0, 0)
        Me.PanelBack.Name = "PanelBack"
        Me.PanelBack.Padding = New System.Windows.Forms.Padding(10)
        Me.PanelBack.Size = New System.Drawing.Size(800, 543)
        Me.PanelBack.TabIndex = 0
        '
        'GroupRegister
        '
        Me.GroupRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupRegister.Location = New System.Drawing.Point(10, 10)
        Me.GroupRegister.Name = "GroupRegister"
        '
        'GroupRegister.Panel
        '
        Me.GroupRegister.Panel.Controls.Add(Me.TxtNature)
        Me.GroupRegister.Panel.Controls.Add(Me.LblNature)
        Me.GroupRegister.Panel.Controls.Add(Me.TxtPincode)
        Me.GroupRegister.Panel.Controls.Add(Me.KryptonLabel9)
        Me.GroupRegister.Panel.Controls.Add(Me.TxtAddress)
        Me.GroupRegister.Panel.Controls.Add(Me.KryptonLabel8)
        Me.GroupRegister.Panel.Controls.Add(Me.CmdClear)
        Me.GroupRegister.Panel.Controls.Add(Me.CmdRegister)
        Me.GroupRegister.Panel.Controls.Add(Me.TxtSample)
        Me.GroupRegister.Panel.Controls.Add(Me.TxtSex)
        Me.GroupRegister.Panel.Controls.Add(Me.TxtAge)
        Me.GroupRegister.Panel.Controls.Add(Me.TxtUnit)
        Me.GroupRegister.Panel.Controls.Add(Me.TxtWard)
        Me.GroupRegister.Panel.Controls.Add(Me.TxtRegNo)
        Me.GroupRegister.Panel.Controls.Add(Me.TxtName)
        Me.GroupRegister.Panel.Controls.Add(Me.KryptonLabel7)
        Me.GroupRegister.Panel.Controls.Add(Me.KryptonLabel6)
        Me.GroupRegister.Panel.Controls.Add(Me.KryptonLabel5)
        Me.GroupRegister.Panel.Controls.Add(Me.KryptonLabel4)
        Me.GroupRegister.Panel.Controls.Add(Me.KryptonLabel3)
        Me.GroupRegister.Panel.Controls.Add(Me.KryptonLabel2)
        Me.GroupRegister.Panel.Controls.Add(Me.KryptonLabel1)
        Me.GroupRegister.Size = New System.Drawing.Size(780, 523)
        Me.GroupRegister.TabIndex = 2
        Me.GroupRegister.Values.Heading = "Register"
        '
        'TxtNature
        '
        Me.TxtNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtNature.DropDownWidth = 121
        Me.TxtNature.Items.AddRange(New Object() {"Serum", "Plasma", "Whole Blood"})
        Me.TxtNature.Location = New System.Drawing.Point(84, 368)
        Me.TxtNature.Name = "TxtNature"
        Me.TxtNature.Size = New System.Drawing.Size(318, 21)
        Me.TxtNature.TabIndex = 11
        '
        'LblNature
        '
        Me.LblNature.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.LblNature.Location = New System.Drawing.Point(15, 369)
        Me.LblNature.Name = "LblNature"
        Me.LblNature.Size = New System.Drawing.Size(51, 20)
        Me.LblNature.TabIndex = 22
        Me.LblNature.Values.Text = "Nature:"
        '
        'TxtPincode
        '
        Me.TxtPincode.Location = New System.Drawing.Point(85, 215)
        Me.TxtPincode.Name = "TxtPincode"
        Me.TxtPincode.Size = New System.Drawing.Size(121, 20)
        Me.TxtPincode.TabIndex = 6
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel9.Location = New System.Drawing.Point(15, 215)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(57, 20)
        Me.KryptonLabel9.TabIndex = 18
        Me.KryptonLabel9.Values.Text = "Pincode:"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(85, 157)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(318, 48)
        Me.TxtAddress.TabIndex = 5
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel8.Location = New System.Drawing.Point(15, 157)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel8.TabIndex = 16
        Me.KryptonLabel8.Values.Text = "Address"
        '
        'CmdClear
        '
        Me.CmdClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdClear.Location = New System.Drawing.Point(253, 404)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(150, 25)
        Me.CmdClear.TabIndex = 13
        Me.CmdClear.Values.Text = "Clear"
        '
        'CmdRegister
        '
        Me.CmdRegister.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdRegister.Location = New System.Drawing.Point(84, 404)
        Me.CmdRegister.Name = "CmdRegister"
        Me.CmdRegister.Size = New System.Drawing.Size(150, 25)
        Me.CmdRegister.TabIndex = 12
        Me.CmdRegister.Values.Text = "Register"
        '
        'TxtSample
        '
        Me.TxtSample.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtSample.DropDownWidth = 121
        Me.TxtSample.Items.AddRange(New Object() {"Blood", "Urine"})
        Me.TxtSample.Location = New System.Drawing.Point(85, 326)
        Me.TxtSample.Name = "TxtSample"
        Me.TxtSample.Size = New System.Drawing.Size(317, 21)
        Me.TxtSample.TabIndex = 9
        '
        'TxtSex
        '
        Me.TxtSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtSex.DropDownWidth = 121
        Me.TxtSex.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.TxtSex.Location = New System.Drawing.Point(84, 87)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.Size = New System.Drawing.Size(121, 21)
        Me.TxtSex.TabIndex = 3
        '
        'TxtAge
        '
        Me.TxtAge.Location = New System.Drawing.Point(85, 122)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.Size = New System.Drawing.Size(120, 22)
        Me.TxtAge.TabIndex = 4
        '
        'TxtUnit
        '
        Me.TxtUnit.Location = New System.Drawing.Point(84, 288)
        Me.TxtUnit.Name = "TxtUnit"
        Me.TxtUnit.Size = New System.Drawing.Size(318, 20)
        Me.TxtUnit.TabIndex = 8
        '
        'TxtWard
        '
        Me.TxtWard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtWard.Location = New System.Drawing.Point(85, 251)
        Me.TxtWard.Name = "TxtWard"
        Me.TxtWard.Size = New System.Drawing.Size(318, 20)
        Me.TxtWard.TabIndex = 7
        '
        'TxtRegNo
        '
        Me.TxtRegNo.Location = New System.Drawing.Point(84, 51)
        Me.TxtRegNo.Name = "TxtRegNo"
        Me.TxtRegNo.Size = New System.Drawing.Size(318, 20)
        Me.TxtRegNo.TabIndex = 2
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(84, 16)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(318, 20)
        Me.TxtName.TabIndex = 1
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel7.Location = New System.Drawing.Point(15, 326)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(53, 20)
        Me.KryptonLabel7.TabIndex = 5
        Me.KryptonLabel7.Values.Text = "Sample:"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel6.Location = New System.Drawing.Point(15, 288)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel6.TabIndex = 4
        Me.KryptonLabel6.Values.Text = "Unit:"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel5.Location = New System.Drawing.Point(15, 251)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(43, 20)
        Me.KryptonLabel5.TabIndex = 3
        Me.KryptonLabel5.Values.Text = "Ward:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel4.Location = New System.Drawing.Point(15, 87)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(32, 20)
        Me.KryptonLabel4.TabIndex = 2
        Me.KryptonLabel4.Values.Text = "Sex:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel3.Location = New System.Drawing.Point(15, 122)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(35, 20)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Values.Text = "Age:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel2.Location = New System.Drawing.Point(15, 51)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(56, 20)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Values.Text = "Reg NO:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel1.Location = New System.Drawing.Point(15, 16)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(46, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Name:"
        '
        'PageRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelBack)
        Me.MinimumSize = New System.Drawing.Size(800, 0)
        Me.Name = "PageRegister"
        Me.Size = New System.Drawing.Size(800, 543)
        CType(Me.PanelBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBack.ResumeLayout(False)
        CType(Me.GroupRegister.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupRegister.Panel.ResumeLayout(False)
        Me.GroupRegister.Panel.PerformLayout()
        CType(Me.GroupRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupRegister.ResumeLayout(False)
        CType(Me.TxtNature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSample, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBack As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents GroupRegister As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents TxtNature As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents LblNature As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TxtPincode As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TxtAddress As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents CmdClear As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents CmdRegister As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TxtSample As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TxtSex As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents TxtAge As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents TxtUnit As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtWard As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtRegNo As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
