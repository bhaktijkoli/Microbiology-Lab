<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.KryptonGroupBox1 = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TxtName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtReg = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtSex = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtAddress = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtPin = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtWard = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtUnit = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtSample = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtAge = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroupBox1.Panel.SuspendLayout()
        Me.KryptonGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(584, 562)
        Me.KryptonPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.KryptonGroupBox1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(584, 562)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'KryptonGroupBox1
        '
        Me.KryptonGroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonGroupBox1.Name = "KryptonGroupBox1"
        '
        'KryptonGroupBox1.Panel
        '
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.TxtAge)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.TxtSample)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.TxtUnit)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.TxtWard)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.TxtPin)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.TxtAddress)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.TxtSex)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.TxtReg)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.TxtName)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel2)
        Me.KryptonGroupBox1.Panel.Controls.Add(Me.KryptonLabel1)
        Me.KryptonGroupBox1.Size = New System.Drawing.Size(578, 284)
        Me.KryptonGroupBox1.TabIndex = 1
        Me.KryptonGroupBox1.Values.Heading = "Details"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel1.Location = New System.Drawing.Point(7, 3)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(46, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Name:"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel2.Location = New System.Drawing.Point(7, 29)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Values.Text = "Reg No:"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel3.Location = New System.Drawing.Point(7, 55)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(32, 20)
        Me.KryptonLabel3.TabIndex = 2
        Me.KryptonLabel3.Values.Text = "Sex:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel4.Location = New System.Drawing.Point(7, 81)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(57, 20)
        Me.KryptonLabel4.TabIndex = 3
        Me.KryptonLabel4.Values.Text = "Address:"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel5.Location = New System.Drawing.Point(7, 146)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(57, 20)
        Me.KryptonLabel5.TabIndex = 4
        Me.KryptonLabel5.Values.Text = "Pincode:"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel6.Location = New System.Drawing.Point(7, 172)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel6.TabIndex = 5
        Me.KryptonLabel6.Values.Text = "Ward/OPD:"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel7.Location = New System.Drawing.Point(7, 198)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel7.TabIndex = 6
        Me.KryptonLabel7.Values.Text = "Unit:"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel8.Location = New System.Drawing.Point(7, 224)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(53, 20)
        Me.KryptonLabel8.TabIndex = 7
        Me.KryptonLabel8.Values.Text = "Sample:"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(80, 3)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(430, 20)
        Me.TxtName.TabIndex = 8
        '
        'TxtReg
        '
        Me.TxtReg.Location = New System.Drawing.Point(80, 29)
        Me.TxtReg.Name = "TxtReg"
        Me.TxtReg.ReadOnly = True
        Me.TxtReg.Size = New System.Drawing.Size(430, 20)
        Me.TxtReg.TabIndex = 9
        '
        'TxtSex
        '
        Me.TxtSex.Location = New System.Drawing.Point(80, 55)
        Me.TxtSex.Name = "TxtSex"
        Me.TxtSex.ReadOnly = True
        Me.TxtSex.Size = New System.Drawing.Size(200, 20)
        Me.TxtSex.TabIndex = 10
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(80, 81)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.ReadOnly = True
        Me.TxtAddress.Size = New System.Drawing.Size(430, 59)
        Me.TxtAddress.TabIndex = 11
        '
        'TxtPin
        '
        Me.TxtPin.Location = New System.Drawing.Point(80, 146)
        Me.TxtPin.Name = "TxtPin"
        Me.TxtPin.ReadOnly = True
        Me.TxtPin.Size = New System.Drawing.Size(430, 20)
        Me.TxtPin.TabIndex = 12
        '
        'TxtWard
        '
        Me.TxtWard.Location = New System.Drawing.Point(80, 172)
        Me.TxtWard.Name = "TxtWard"
        Me.TxtWard.ReadOnly = True
        Me.TxtWard.Size = New System.Drawing.Size(430, 20)
        Me.TxtWard.TabIndex = 13
        '
        'TxtUnit
        '
        Me.TxtUnit.Location = New System.Drawing.Point(80, 198)
        Me.TxtUnit.Name = "TxtUnit"
        Me.TxtUnit.ReadOnly = True
        Me.TxtUnit.Size = New System.Drawing.Size(430, 20)
        Me.TxtUnit.TabIndex = 14
        '
        'TxtSample
        '
        Me.TxtSample.Location = New System.Drawing.Point(80, 224)
        Me.TxtSample.Name = "TxtSample"
        Me.TxtSample.ReadOnly = True
        Me.TxtSample.Size = New System.Drawing.Size(430, 20)
        Me.TxtSample.TabIndex = 15
        '
        'TxtAge
        '
        Me.TxtAge.Location = New System.Drawing.Point(371, 55)
        Me.TxtAge.Name = "TxtAge"
        Me.TxtAge.ReadOnly = True
        Me.TxtAge.Size = New System.Drawing.Size(139, 20)
        Me.TxtAge.TabIndex = 17
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel9.Location = New System.Drawing.Point(333, 55)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(35, 20)
        Me.KryptonLabel9.TabIndex = 16
        Me.KryptonLabel9.Values.Text = "Age:"
        '
        'FormUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUpdate"
        Me.Text = "Update"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.KryptonGroupBox1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.Panel.ResumeLayout(False)
        Me.KryptonGroupBox1.Panel.PerformLayout()
        CType(Me.KryptonGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents KryptonGroupBox1 As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TxtName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtSample As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtUnit As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtWard As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtPin As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtAddress As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtSex As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtReg As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtAge As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
