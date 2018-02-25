﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.NavMain = New ComponentFactory.Krypton.Navigator.KryptonNavigator()
        Me.NavRegister = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.PageRegister1 = New Microbiology_Lab.PageRegister()
        Me.NavList = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.PageSamples = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.PageSamples1 = New Microbiology_Lab.PageSamples()
        CType(Me.NavMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavMain.SuspendLayout()
        CType(Me.NavRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavRegister.SuspendLayout()
        CType(Me.NavList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageSamples.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavMain
        '
        Me.NavMain.AllowTabFocus = False
        Me.NavMain.Bar.ItemMinimumSize = New System.Drawing.Size(150, 30)
        Me.NavMain.Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop
        Me.NavMain.Bar.ItemSizing = ComponentFactory.Krypton.Navigator.BarItemSizing.SameWidthAndHeight
        Me.NavMain.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None
        Me.NavMain.Button.CloseButtonAction = ComponentFactory.Krypton.Navigator.CloseButtonAction.None
        Me.NavMain.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide
        Me.NavMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavMain.Location = New System.Drawing.Point(0, 0)
        Me.NavMain.Name = "NavMain"
        Me.NavMain.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelAlternate
        Me.NavMain.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.NavRegister, Me.NavList, Me.PageSamples})
        Me.NavMain.SelectedIndex = 2
        Me.NavMain.Size = New System.Drawing.Size(784, 562)
        Me.NavMain.TabIndex = 0
        Me.NavMain.Text = "KryptonNavigator1"
        '
        'NavRegister
        '
        Me.NavRegister.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.NavRegister.Controls.Add(Me.PageRegister1)
        Me.NavRegister.Flags = 65534
        Me.NavRegister.LastVisibleSet = True
        Me.NavRegister.MinimumSize = New System.Drawing.Size(50, 50)
        Me.NavRegister.Name = "NavRegister"
        Me.NavRegister.Size = New System.Drawing.Size(782, 530)
        Me.NavRegister.Text = "Register"
        Me.NavRegister.ToolTipTitle = "Page ToolTip"
        Me.NavRegister.UniqueName = "091DBF10C75F45C3F5BA4035A4312A5E"
        '
        'PageRegister1
        '
        Me.PageRegister1.Location = New System.Drawing.Point(154, 112)
        Me.PageRegister1.MinimumSize = New System.Drawing.Size(800, 0)
        Me.PageRegister1.Name = "PageRegister1"
        Me.PageRegister1.Size = New System.Drawing.Size(800, 543)
        Me.PageRegister1.TabIndex = 0
        '
        'NavList
        '
        Me.NavList.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.NavList.Flags = 65534
        Me.NavList.LastVisibleSet = True
        Me.NavList.MinimumSize = New System.Drawing.Size(50, 50)
        Me.NavList.Name = "NavList"
        Me.NavList.Size = New System.Drawing.Size(782, 530)
        Me.NavList.Text = "List"
        Me.NavList.ToolTipTitle = "Page ToolTip"
        Me.NavList.UniqueName = "A230ECA84BA74277CBA34CB632F611BC"
        '
        'PageSamples
        '
        Me.PageSamples.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.PageSamples.Controls.Add(Me.PageSamples1)
        Me.PageSamples.Flags = 65534
        Me.PageSamples.LastVisibleSet = True
        Me.PageSamples.MinimumSize = New System.Drawing.Size(50, 50)
        Me.PageSamples.Name = "PageSamples"
        Me.PageSamples.Size = New System.Drawing.Size(782, 530)
        Me.PageSamples.Text = "Samples"
        Me.PageSamples.ToolTipTitle = "Page ToolTip"
        Me.PageSamples.UniqueName = "B8B2F040313E4ECA6F8A7BF64F7C2A88"
        '
        'PageSamples1
        '
        Me.PageSamples1.Location = New System.Drawing.Point(215, 100)
        Me.PageSamples1.MinimumSize = New System.Drawing.Size(800, 0)
        Me.PageSamples1.Name = "PageSamples1"
        Me.PageSamples1.Size = New System.Drawing.Size(800, 415)
        Me.PageSamples1.TabIndex = 0
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.NavMain)
        Me.Icon = Global.Microbiology_Lab.My.Resources.Resources.icon
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FormMain"
        CType(Me.NavMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavMain.ResumeLayout(False)
        CType(Me.NavRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavRegister.ResumeLayout(False)
        CType(Me.NavList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageSamples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageSamples.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavMain As ComponentFactory.Krypton.Navigator.KryptonNavigator
    Friend WithEvents NavRegister As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents NavList As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents PageRegister1 As PageRegister
    Friend WithEvents PageSamples As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents PageSamples1 As PageSamples
End Class
