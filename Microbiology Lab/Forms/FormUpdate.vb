Public Class FormUpdate
    Private test As Test
    Public Sub New(t As Test)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        test = t
    End Sub

    Private Sub FormUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.icon
        Me.Text = "Update - " + test.name
        DetailsControlEx.updateData(test)
        ReportControl1.updateData(test)
    End Sub

    Private Sub FormUpdate_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            FlowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight
        End If
    End Sub
End Class