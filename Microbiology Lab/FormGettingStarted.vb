Public Class FormGettingStarted
    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles CmdLogin.Click
        If AppValidation.ValidateUsername(TxtUsername.Text) = False Or AppValidation.ValidatePassword(TxtPassword.Text, TxtRePassword.Text) = False Then
            Exit Sub
        End If
        Try
            Dim user As New User
            user.username = TxtUsername.Text
            user.password = TxtPassword.Text
            user.role = 1
            AppMain.Database.Users.Add(user)
            AppMain.Database.SaveChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MessageBox.Show("Welcome " + TxtUsername.Text + ", your account was created successfully, You can now proceed to login.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        FormLogin.Show()
        Me.Close()
    End Sub
End Class