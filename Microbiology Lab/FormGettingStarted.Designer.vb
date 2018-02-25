<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGettingStarted
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
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.GroupSetup = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.TxtRePassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.CmdLogin = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TxtPassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtUsername = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.GroupSetup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupSetup.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSetup.Panel.SuspendLayout()
        Me.GroupSetup.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.GroupSetup)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(492, 216)
        Me.KryptonPanel1.TabIndex = 0
        '
        'GroupSetup
        '
        Me.GroupSetup.Location = New System.Drawing.Point(12, 12)
        Me.GroupSetup.Name = "GroupSetup"
        '
        'GroupSetup.Panel
        '
        Me.GroupSetup.Panel.Controls.Add(Me.TxtRePassword)
        Me.GroupSetup.Panel.Controls.Add(Me.KryptonLabel3)
        Me.GroupSetup.Panel.Controls.Add(Me.CmdLogin)
        Me.GroupSetup.Panel.Controls.Add(Me.TxtPassword)
        Me.GroupSetup.Panel.Controls.Add(Me.TxtUsername)
        Me.GroupSetup.Panel.Controls.Add(Me.KryptonLabel2)
        Me.GroupSetup.Panel.Controls.Add(Me.KryptonLabel1)
        Me.GroupSetup.Size = New System.Drawing.Size(468, 182)
        Me.GroupSetup.TabIndex = 1
        Me.GroupSetup.Values.Heading = "Setup Administrator Account"
        '
        'TxtRePassword
        '
        Me.TxtRePassword.Location = New System.Drawing.Point(135, 86)
        Me.TxtRePassword.Name = "TxtRePassword"
        Me.TxtRePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TxtRePassword.Size = New System.Drawing.Size(269, 20)
        Me.TxtRePassword.TabIndex = 6
        Me.TxtRePassword.UseSystemPasswordChar = True
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel3.Location = New System.Drawing.Point(17, 86)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(112, 20)
        Me.KryptonLabel3.TabIndex = 5
        Me.KryptonLabel3.Values.Text = "Confirm Password:"
        '
        'CmdLogin
        '
        Me.CmdLogin.Location = New System.Drawing.Point(135, 122)
        Me.CmdLogin.Name = "CmdLogin"
        Me.CmdLogin.Size = New System.Drawing.Size(90, 25)
        Me.CmdLogin.TabIndex = 4
        Me.CmdLogin.Values.Text = "Start"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(135, 51)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TxtPassword.Size = New System.Drawing.Size(269, 20)
        Me.TxtPassword.TabIndex = 3
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(135, 15)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(269, 20)
        Me.TxtUsername.TabIndex = 2
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel2.Location = New System.Drawing.Point(17, 51)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(65, 20)
        Me.KryptonLabel2.TabIndex = 1
        Me.KryptonLabel2.Values.Text = "Password:"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel1.Location = New System.Drawing.Point(17, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(68, 20)
        Me.KryptonLabel1.TabIndex = 0
        Me.KryptonLabel1.Values.Text = "Username:"
        '
        'FormGettingStarted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 216)
        Me.Controls.Add(Me.KryptonPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Global.Microbiology_Lab.My.Resources.Resources.icon
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGettingStarted"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Getting Started"
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.GroupSetup.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupSetup.Panel.ResumeLayout(False)
        Me.GroupSetup.Panel.PerformLayout()
        CType(Me.GroupSetup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupSetup.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents GroupSetup As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents CmdLogin As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TxtPassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtUsername As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TxtRePassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
