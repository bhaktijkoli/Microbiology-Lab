<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUpdateBlood
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
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.CmdUpdate = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.DetailsControlEx = New Microbiology_Lab.DetailsControl()
        Me.ReportControl1 = New Microbiology_Lab.ReportControl()
        Me.RemarkControl1 = New Microbiology_Lab.RemarkControl()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.KryptonPanel1.Controls.Add(Me.KryptonPanel2)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(653, 354)
        Me.KryptonPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.DetailsControlEx)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReportControl1)
        Me.FlowLayoutPanel1.Controls.Add(Me.RemarkControl1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(653, 308)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.CmdUpdate)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 308)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.KryptonPanel2.Size = New System.Drawing.Size(653, 46)
        Me.KryptonPanel2.TabIndex = 1
        '
        'CmdUpdate
        '
        Me.CmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdUpdate.Location = New System.Drawing.Point(524, 9)
        Me.CmdUpdate.Name = "CmdUpdate"
        Me.CmdUpdate.Size = New System.Drawing.Size(117, 25)
        Me.CmdUpdate.TabIndex = 0
        Me.CmdUpdate.Values.Text = "Update"
        '
        'DetailsControlEx
        '
        Me.DetailsControlEx.BackColor = System.Drawing.Color.Transparent
        Me.DetailsControlEx.Location = New System.Drawing.Point(10, 10)
        Me.DetailsControlEx.Margin = New System.Windows.Forms.Padding(10)
        Me.DetailsControlEx.Name = "DetailsControlEx"
        Me.DetailsControlEx.Size = New System.Drawing.Size(595, 366)
        Me.DetailsControlEx.TabIndex = 0
        '
        'ReportControl1
        '
        Me.ReportControl1.BackColor = System.Drawing.Color.Transparent
        Me.ReportControl1.Location = New System.Drawing.Point(10, 396)
        Me.ReportControl1.Margin = New System.Windows.Forms.Padding(10)
        Me.ReportControl1.Name = "ReportControl1"
        Me.ReportControl1.Size = New System.Drawing.Size(595, 200)
        Me.ReportControl1.TabIndex = 1
        '
        'RemarkControl1
        '
        Me.RemarkControl1.Location = New System.Drawing.Point(10, 616)
        Me.RemarkControl1.Margin = New System.Windows.Forms.Padding(10)
        Me.RemarkControl1.Name = "RemarkControl1"
        Me.RemarkControl1.Size = New System.Drawing.Size(603, 144)
        Me.RemarkControl1.TabIndex = 2
        '
        'FormUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(653, 354)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormUpdate"
        Me.Text = "FormUpdate"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents DetailsControl1 As DetailsControl
    Friend WithEvents DetailsControlEx As DetailsControl
    Friend WithEvents ReportControl1 As ReportControl
    Friend WithEvents RemarkControl1 As RemarkControl
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents CmdUpdate As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
