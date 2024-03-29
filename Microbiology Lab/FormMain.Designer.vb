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
        Me.NavList = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.NavSamples = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.NavBloodTests = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.NavPathogens = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.NavAntibiotics = New ComponentFactory.Krypton.Navigator.KryptonPage()
        Me.PageRegister1 = New Microbiology_Lab.PageRegister()
        Me.PageList1 = New Microbiology_Lab.PageList()
        Me.PageSamples1 = New Microbiology_Lab.PageSamples()
        Me.PageBloodTests1 = New Microbiology_Lab.PageBloodTests()
        Me.PagePathogens1 = New Microbiology_Lab.PagePathogens()
        Me.PageAntibiotics1 = New Microbiology_Lab.PageAntibiotics()
        CType(Me.NavMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavMain.SuspendLayout()
        CType(Me.NavRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavRegister.SuspendLayout()
        CType(Me.NavList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavList.SuspendLayout()
        CType(Me.NavSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavSamples.SuspendLayout()
        CType(Me.NavBloodTests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavBloodTests.SuspendLayout()
        CType(Me.NavPathogens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavPathogens.SuspendLayout()
        CType(Me.NavAntibiotics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavAntibiotics.SuspendLayout()
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
        Me.NavMain.Pages.AddRange(New ComponentFactory.Krypton.Navigator.KryptonPage() {Me.NavRegister, Me.NavList, Me.NavSamples, Me.NavBloodTests, Me.NavPathogens, Me.NavAntibiotics})
        Me.NavMain.SelectedIndex = 5
        Me.NavMain.Size = New System.Drawing.Size(804, 582)
        Me.NavMain.TabIndex = 0
        Me.NavMain.Text = "KryptonNavigator1"
        '
        'NavRegister
        '
        Me.NavRegister.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.NavRegister.AutoScroll = True
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
        'NavList
        '
        Me.NavList.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.NavList.AutoScroll = True
        Me.NavList.Controls.Add(Me.PageList1)
        Me.NavList.Flags = 65534
        Me.NavList.LastVisibleSet = True
        Me.NavList.MinimumSize = New System.Drawing.Size(50, 50)
        Me.NavList.Name = "NavList"
        Me.NavList.Size = New System.Drawing.Size(802, 550)
        Me.NavList.Text = "List"
        Me.NavList.ToolTipTitle = "Page ToolTip"
        Me.NavList.UniqueName = "A230ECA84BA74277CBA34CB632F611BC"
        '
        'NavSamples
        '
        Me.NavSamples.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.NavSamples.AutoScroll = True
        Me.NavSamples.Controls.Add(Me.PageSamples1)
        Me.NavSamples.Flags = 65534
        Me.NavSamples.LastVisibleSet = True
        Me.NavSamples.MinimumSize = New System.Drawing.Size(50, 50)
        Me.NavSamples.Name = "NavSamples"
        Me.NavSamples.Size = New System.Drawing.Size(802, 550)
        Me.NavSamples.Text = "Samples"
        Me.NavSamples.ToolTipTitle = "Page ToolTip"
        Me.NavSamples.UniqueName = "B8B2F040313E4ECA6F8A7BF64F7C2A88"
        '
        'NavBloodTests
        '
        Me.NavBloodTests.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.NavBloodTests.AutoScroll = True
        Me.NavBloodTests.Controls.Add(Me.PageBloodTests1)
        Me.NavBloodTests.Flags = 65534
        Me.NavBloodTests.LastVisibleSet = True
        Me.NavBloodTests.MinimumSize = New System.Drawing.Size(50, 50)
        Me.NavBloodTests.Name = "NavBloodTests"
        Me.NavBloodTests.Size = New System.Drawing.Size(802, 550)
        Me.NavBloodTests.Text = "Blood Tests"
        Me.NavBloodTests.ToolTipTitle = "Page ToolTip"
        Me.NavBloodTests.UniqueName = "9C06F1181CB14F85659E9469E9BDE3F8"
        '
        'NavPathogens
        '
        Me.NavPathogens.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.NavPathogens.Controls.Add(Me.PagePathogens1)
        Me.NavPathogens.Flags = 65534
        Me.NavPathogens.LastVisibleSet = True
        Me.NavPathogens.MinimumSize = New System.Drawing.Size(50, 50)
        Me.NavPathogens.Name = "NavPathogens"
        Me.NavPathogens.Size = New System.Drawing.Size(802, 550)
        Me.NavPathogens.Text = "Pathogens"
        Me.NavPathogens.ToolTipTitle = "Page ToolTip"
        Me.NavPathogens.UniqueName = "C665CB3B00AF43DE4382909E630523FF"
        '
        'NavAntibiotics
        '
        Me.NavAntibiotics.AutoHiddenSlideSize = New System.Drawing.Size(200, 200)
        Me.NavAntibiotics.Controls.Add(Me.PageAntibiotics1)
        Me.NavAntibiotics.Flags = 65534
        Me.NavAntibiotics.LastVisibleSet = True
        Me.NavAntibiotics.MinimumSize = New System.Drawing.Size(50, 50)
        Me.NavAntibiotics.Name = "NavAntibiotics"
        Me.NavAntibiotics.Size = New System.Drawing.Size(802, 550)
        Me.NavAntibiotics.Text = "Antibiotics"
        Me.NavAntibiotics.ToolTipTitle = "Page ToolTip"
        Me.NavAntibiotics.UniqueName = "2E3F42F8D64E4301F79B9F7E354D1CB5"
        '
        'PageRegister1
        '
        Me.PageRegister1.Location = New System.Drawing.Point(163, 61)
        Me.PageRegister1.MinimumSize = New System.Drawing.Size(800, 0)
        Me.PageRegister1.Name = "PageRegister1"
        Me.PageRegister1.Size = New System.Drawing.Size(800, 530)
        Me.PageRegister1.TabIndex = 0
        '
        'PageList1
        '
        Me.PageList1.Location = New System.Drawing.Point(250, 57)
        Me.PageList1.MinimumSize = New System.Drawing.Size(800, 0)
        Me.PageList1.Name = "PageList1"
        Me.PageList1.Size = New System.Drawing.Size(800, 415)
        Me.PageList1.TabIndex = 0
        '
        'PageSamples1
        '
        Me.PageSamples1.Location = New System.Drawing.Point(215, 100)
        Me.PageSamples1.MinimumSize = New System.Drawing.Size(800, 0)
        Me.PageSamples1.Name = "PageSamples1"
        Me.PageSamples1.Size = New System.Drawing.Size(800, 150)
        Me.PageSamples1.TabIndex = 0
        '
        'PageBloodTests1
        '
        Me.PageBloodTests1.Location = New System.Drawing.Point(76, 44)
        Me.PageBloodTests1.MinimumSize = New System.Drawing.Size(800, 0)
        Me.PageBloodTests1.Name = "PageBloodTests1"
        Me.PageBloodTests1.Size = New System.Drawing.Size(800, 150)
        Me.PageBloodTests1.TabIndex = 0
        '
        'PagePathogens1
        '
        Me.PagePathogens1.Location = New System.Drawing.Point(40, 57)
        Me.PagePathogens1.MinimumSize = New System.Drawing.Size(800, 0)
        Me.PagePathogens1.Name = "PagePathogens1"
        Me.PagePathogens1.Size = New System.Drawing.Size(800, 150)
        Me.PagePathogens1.TabIndex = 0
        '
        'PageAntibiotics1
        '
        Me.PageAntibiotics1.Location = New System.Drawing.Point(11, 20)
        Me.PageAntibiotics1.MinimumSize = New System.Drawing.Size(800, 0)
        Me.PageAntibiotics1.Name = "PageAntibiotics1"
        Me.PageAntibiotics1.Size = New System.Drawing.Size(800, 187)
        Me.PageAntibiotics1.TabIndex = 0
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 582)
        Me.Controls.Add(Me.NavMain)
        Me.Icon = Global.Microbiology_Lab.My.Resources.Resources.icon
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "FormMain"
        CType(Me.NavMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavMain.ResumeLayout(False)
        CType(Me.NavRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavRegister.ResumeLayout(False)
        CType(Me.NavList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavList.ResumeLayout(False)
        CType(Me.NavSamples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavSamples.ResumeLayout(False)
        CType(Me.NavBloodTests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavBloodTests.ResumeLayout(False)
        CType(Me.NavPathogens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavPathogens.ResumeLayout(False)
        CType(Me.NavAntibiotics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavAntibiotics.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavMain As ComponentFactory.Krypton.Navigator.KryptonNavigator
    Friend WithEvents NavRegister As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents NavList As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents NavSamples As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents PageSamples1 As PageSamples
    Friend WithEvents NavBloodTests As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents PageBloodTests1 As PageBloodTests
    Friend WithEvents PageRegister1 As PageRegister
    Friend WithEvents PageList1 As PageList
    Friend WithEvents NavPathogens As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents PagePathogens1 As PagePathogens
    Friend WithEvents NavAntibiotics As ComponentFactory.Krypton.Navigator.KryptonPage
    Friend WithEvents PageAntibiotics1 As PageAntibiotics
End Class
