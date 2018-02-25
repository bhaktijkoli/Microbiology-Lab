Public Class FormMain

    Private Sub NavMain_SelectedPageChanged(sender As Object, e As EventArgs) Handles NavMain.SelectedPageChanged
        Me.Text = My.Application.Info.Title + " - " + NavMain.SelectedPage.Text
        FormMain_Resize()
        NavMain.SelectedPage.AutoScrollPosition = New Point(0, 0)
    End Sub

    Private Sub FormMain_Resize() Handles Me.Resize
        For Each control As Control In NavMain.SelectedPage.Controls
            control.Location = New Point((NavMain.SelectedPage.Size.Width / 2) - control.Width / 2, 5)
        Next
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        AppMain.EventSettings()
        If Not AppMain.User.role = 1 Then
            NavSamples.Visible = False
            NavBloodTests.Visible = False
        End If
    End Sub
End Class