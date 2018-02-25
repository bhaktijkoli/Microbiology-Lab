<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.PanelBack = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.GroupLogin = New ComponentFactory.Krypton.Toolkit.KryptonGroupBox()
        Me.CmdLogin = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TxtPassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TxtUsername = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.PanelBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBack.SuspendLayout()
        CType(Me.GroupLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupLogin.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupLogin.Panel.SuspendLayout()
        Me.GroupLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBack
        '
        Me.PanelBack.Controls.Add(Me.GroupLogin)
        Me.PanelBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBack.Location = New System.Drawing.Point(0, 0)
        Me.PanelBack.Name = "PanelBack"
        Me.PanelBack.Size = New System.Drawing.Size(405, 183)
        Me.PanelBack.TabIndex = 0
        '
        'GroupLogin
        '
        Me.GroupLogin.Location = New System.Drawing.Point(12, 12)
        Me.GroupLogin.Name = "GroupLogin"
        '
        'GroupLogin.Panel
        '
        Me.GroupLogin.Panel.Controls.Add(Me.CmdLogin)
        Me.GroupLogin.Panel.Controls.Add(Me.TxtPassword)
        Me.GroupLogin.Panel.Controls.Add(Me.TxtUsername)
        Me.GroupLogin.Panel.Controls.Add(Me.KryptonLabel2)
        Me.GroupLogin.Panel.Controls.Add(Me.KryptonLabel1)
        Me.GroupLogin.Size = New System.Drawing.Size(378, 152)
        Me.GroupLogin.TabIndex = 0
        Me.GroupLogin.Values.Heading = "Login"
        '
        'CmdLogin
        '
        Me.CmdLogin.Location = New System.Drawing.Point(91, 89)
        Me.CmdLogin.Name = "CmdLogin"
        Me.CmdLogin.Size = New System.Drawing.Size(90, 25)
        Me.CmdLogin.TabIndex = 4
        Me.CmdLogin.Values.Text = "Login"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(91, 51)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TxtPassword.Size = New System.Drawing.Size(269, 20)
        Me.TxtPassword.TabIndex = 3
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(91, 15)
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
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 183)
        Me.Controls.Add(Me.PanelBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = Global.Microbiology_Lab.My.Resources.Resources.icon
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PanelBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBack.ResumeLayout(False)
        CType(Me.GroupLogin.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupLogin.Panel.ResumeLayout(False)
        Me.GroupLogin.Panel.PerformLayout()
        CType(Me.GroupLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupLogin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBack As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents GroupLogin As ComponentFactory.Krypton.Toolkit.KryptonGroupBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TxtPassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TxtUsername As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents CmdLogin As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
