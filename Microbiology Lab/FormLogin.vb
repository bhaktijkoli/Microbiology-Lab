Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.ProductName + " - Login"
        If AppMain.Database.Users.Count = 0 Then
            Dim frm As New FormGettingStarted
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles CmdLogin.Click
        Dim user = AppMain.Database.Users.Where(Function(u) u.username = TxtUsername.Text).FirstOrDefault
        If IsNothing(user) Then
            GoTo erorr
        ElseIf Not user.password = TxtPassword.Text Then
            GoTo erorr
        Else
            MsgBox("Success")
            Exit Sub
        End If
erorr:
        MessageBox.Show("Invalid username or password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
