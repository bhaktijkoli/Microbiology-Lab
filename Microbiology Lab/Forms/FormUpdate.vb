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
        DetailsControl1.updateData(test)
    End Sub
End Class